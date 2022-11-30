using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace SunriseSunset
{
    public partial class MainForm : Form
	{
        private List<String> temp;
        private List<TdataClass> mycdata = null;
        private List<Moon_lines> moon_lines = null;
        int month;
        public MainForm()
		{
			InitializeComponent();
            btnAdd2List.Enabled = false;
            btnOpenCSV.Enabled = false;
        }
        private void btnOpenCSV_Click(object sender, EventArgs e)
		{
            string tfilename;
            int k = 0;
            // can't have the 1st line blank
            MessageBox.Show("make sure this csv file is in the sunset/sunrise format", "WARNING");
            tfilename = ChooseCSVFileName();
            if (tfilename == "")
                return;
            temp = new List<string>();
            String[] file = File.ReadAllLines(tfilename);
            foreach (String sr in file)
            {
                if (temp.Count == 19)
                    k++;
                int i = sr.IndexOf('?');
                i--;
                int j = sr.IndexOf(',', i);
                String temp2 = sr.Remove(i, j - i);
                i = temp2.IndexOf('?');
                i--;
                j = temp2.IndexOf(',', i);
                temp2 = temp2.Remove(i, j - i);
                i = temp2.IndexOf('?');
                if(i > 0)
                    temp2 = temp2.Remove(i, 1);
                i = temp2.IndexOf('(');
                j = temp2.IndexOf(')');
                temp2 = temp2.Remove(i, j - i + 1);
                temp.Add(temp2);
            }
            String xml = "";
            XElement top = new XElement("Table",
            from items in temp
            let fields = items.Split(',')
            select new XElement("T_DATA",
            new XElement("Day", fields[0]),
            new XElement("Month", month),
            new XElement("Sunrise", fields[1]),
            new XElement("Sunset", fields[2]),
            //new XElement("Length", fields[3]),
            //new XElement("Diff", fields[4]),
            new XElement("AstStart", fields[5]),
            new XElement("AstEnd", fields[6]),
            new XElement("NautStart", fields[7]),
            new XElement("NautEnd", fields[8]),
            new XElement("CivilStart", fields[9]),
            new XElement("CivilEnd", fields[10])
            //new XElement("Time", fields[11]),
            //new XElement("MilMiles", fields[12])
            )
            );
            tfilename = @"C:\Users\Daniel\dev\tdata" + month.ToString() + ".xml";
            File.WriteAllText(tfilename, xml + top.ToString());
            //MessageBox.Show("C:\\Users\\Daniel\\dev\\tdata.xml (used by Win Client)");
        }
		private void SelectedIndexChanged(object sender, EventArgs e)
		{
            btnAdd2List.Enabled = true;
            btnOpenCSV.Enabled = true;
            month = lbMonth.SelectedIndex + 1;
        }
        private void btnAdd2List_Click(object sender, EventArgs e)
        {
            XmlReader xmlfile = null;
            TdataClass item;
            string tfilename;
            int day = 1;
            tfilename = ChooseXMLFileName();
            if (tfilename == "")
                return;

            if (!File.Exists(tfilename))
            {
                MessageBox.Show("can't find file: " + tfilename);
                return;
            }
            DataSet ds = new DataSet();
            var filePath = tfilename;
            xmlfile = XmlReader.Create(filePath, new XmlReaderSettings());
            ds.ReadXml(xmlfile);
            //mycdata.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                item = new TdataClass();
                item.month = month;
                item.day = Convert.ToInt16(dr.ItemArray[0]);
                item.sunrise = dr.ItemArray[1].ToString();
                item.sunset = dr.ItemArray[2].ToString();
                item.AstTwiStart = dr.ItemArray[5].ToString();
                item.AstTwiEnd = dr.ItemArray[6].ToString();
                item.NautTwiStart = dr.ItemArray[7].ToString();
                item.NautTwiEnd = dr.ItemArray[8].ToString();
                item.CivilTwiStart = dr.ItemArray[9].ToString();
                item.CivilTwiEnd = dr.ItemArray[10].ToString();
                mycdata.Add(item);
            }
            if (moon_lines.Count < 20)
            {
                MessageBox.Show("moon data not loaded");
                return;
            }
            foreach (Moon_lines ml in moon_lines)
            {
                string temp = ml.line;
            }
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void btnHelp_Click(object sender, EventArgs e)
		{
            string text = System.IO.File.ReadAllText(@"C:\Users\Daniel\SunriseSunsetData\help.txt");
            MessageBox.Show(text);
		}
        private void btnMoon_Click(object sender, EventArgs e)
        {
            string tfilename;
            int k = 0;
            tfilename = ChooseMoonFileName();
            if (tfilename == "")
                return;

            if (File.Exists(tfilename))
            {
                string[] lines = File.ReadAllLines(tfilename);
                //AddMsg(lines.Length.ToString());
                int no_days = 0;
                if (moon_lines.Count == 0)
                    moon_lines = new List<Moon_lines>();
                else moon_lines.Clear();
                int j = 0;
                int i = 0;
                Moon_lines temp2;
                foreach (string line in lines)
                {
                    if (line.Length > 0)
                    {
                        char first = line[0];
                        if (first != ' ' && first != '\t')
                        {
                            if (first > 47 && first < 58)
                                no_days = int.Parse(line);
                            else
                            {
                                temp2 = new Moon_lines();
                                temp2.date = no_days;
                                temp2.line = line;
                                temp2.index = i;
                                //AddMsg(temp2.date.ToString() + " " + temp2.line + " " + temp2.index.ToString());
                                moon_lines.Add(temp2);
                                temp2 = null;
                                i++;
                            }
                        }
                    }
                }
            }
        }
        private DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            //          Step 2: Create column name or heading by mentioning the datatype.
            DataColumn dc0 = new DataColumn("Month", typeof(string));
            DataColumn dc1 = new DataColumn("Day", typeof(string));
            DataColumn dc2 = new DataColumn("Sunrise", typeof(string));
            DataColumn dc3 = new DataColumn("Sunset", typeof(string));
            DataColumn dc4 = new DataColumn("Moonrise", typeof(string));
            DataColumn dc5 = new DataColumn("Moonset", typeof(string));
            DataColumn dc6 = new DataColumn("AstTwiStart", typeof(string));
            DataColumn dc7 = new DataColumn("AstTwiEnd", typeof(string));
            DataColumn dc8 = new DataColumn("NautTwiStart", typeof(string));
            DataColumn dc9 = new DataColumn("NautTwiEnd", typeof(string));
            DataColumn dc10 = new DataColumn("CivilTwiStart", typeof(string));
            DataColumn dc11 = new DataColumn("CivilTwiEnd", typeof(string));

            //          Step 3: Adding these Columns to the DataTable,
            dt.Columns.Add(dc0);
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);
            dt.Columns.Add(dc8);
            dt.Columns.Add(dc9);
            dt.Columns.Add(dc10);
            dt.Columns.Add(dc11);
            return dt;
        }
        private string ChooseCSVFileName()
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Daniel\SunriseSunsetData",
                Title = "Browse CSV Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.CSV",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = openFileDialog2.FileName;
                return openFileDialog2.FileName;
            }
            else return "";
        }
        private string ChooseXMLFileName()
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Daniel\SunriseSunsetData",
                Title = "Browse XML Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xml",
                Filter = "xml files (*.xml)|*.XML",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = openFileDialog2.FileName;
                return openFileDialog2.FileName;
            }
            else return "";

        }
        private string ChooseMoonFileName()
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Daniel\SunriseSunsetData",
                Title = "Browse Moon Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "moon",
                Filter = "moon files (*.moon)|*.MOON",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = openFileDialog2.FileName;
                return openFileDialog2.FileName;
            }
            else return "";

        }
		private void btnShowCdata_Click(object sender, EventArgs e)
		{
            DataTable dt = GetDataTable();
            foreach (TdataClass td in mycdata)
            {
                dt.Rows.Add(td.month.ToString(), td.day.ToString(), td.sunrise, td.sunset, td.moonrise, td.moonset, td.AstTwiStart, td.AstTwiEnd, td.NautTwiStart, td.NautTwiEnd, td.CivilTwiStart, td.CivilTwiEnd);
            }
            dataGridView1.DataSource = dt;
        }
	}
}
