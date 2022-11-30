
namespace SunriseSunset
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOpenCSV = new System.Windows.Forms.Button();
			this.lbMonth = new System.Windows.Forms.ListBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tbFileName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAdd2List = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnMoon = new System.Windows.Forms.Button();
			this.btnShowCdata = new System.Windows.Forms.Button();
			this.tbNoRecs = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnAddMoon = new System.Windows.Forms.Button();
			this.btnCreateFinal = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOpenCSV
			// 
			this.btnOpenCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpenCSV.Location = new System.Drawing.Point(27, 12);
			this.btnOpenCSV.Name = "btnOpenCSV";
			this.btnOpenCSV.Size = new System.Drawing.Size(117, 23);
			this.btnOpenCSV.TabIndex = 0;
			this.btnOpenCSV.Text = "Open CSV";
			this.btnOpenCSV.UseVisualStyleBackColor = true;
			this.btnOpenCSV.Click += new System.EventHandler(this.btnOpenCSV_Click);
			// 
			// lbMonth
			// 
			this.lbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMonth.FormattingEnabled = true;
			this.lbMonth.ItemHeight = 16;
			this.lbMonth.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
			this.lbMonth.Location = new System.Drawing.Point(184, 19);
			this.lbMonth.Name = "lbMonth";
			this.lbMonth.Size = new System.Drawing.Size(125, 20);
			this.lbMonth.TabIndex = 1;
			this.lbMonth.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(184, 52);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1001, 502);
			this.dataGridView1.TabIndex = 2;
			// 
			// tbFileName
			// 
			this.tbFileName.Location = new System.Drawing.Point(440, 19);
			this.tbFileName.Name = "tbFileName";
			this.tbFileName.Size = new System.Drawing.Size(416, 20);
			this.tbFileName.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(364, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "File Name";
			// 
			// btnAdd2List
			// 
			this.btnAdd2List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd2List.Location = new System.Drawing.Point(27, 90);
			this.btnAdd2List.Name = "btnAdd2List";
			this.btnAdd2List.Size = new System.Drawing.Size(117, 23);
			this.btnAdd2List.TabIndex = 10;
			this.btnAdd2List.Text = "Add Tdata";
			this.btnAdd2List.UseVisualStyleBackColor = true;
			this.btnAdd2List.Click += new System.EventHandler(this.btnAdd2List_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHelp.Location = new System.Drawing.Point(27, 531);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(117, 23);
			this.btnHelp.TabIndex = 12;
			this.btnHelp.Text = "Help";
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnMoon
			// 
			this.btnMoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoon.Location = new System.Drawing.Point(27, 52);
			this.btnMoon.Name = "btnMoon";
			this.btnMoon.Size = new System.Drawing.Size(117, 23);
			this.btnMoon.TabIndex = 13;
			this.btnMoon.Text = "Open Moon";
			this.btnMoon.UseVisualStyleBackColor = true;
			this.btnMoon.Click += new System.EventHandler(this.btnMoon_Click);
			// 
			// btnShowCdata
			// 
			this.btnShowCdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowCdata.Location = new System.Drawing.Point(27, 162);
			this.btnShowCdata.Name = "btnShowCdata";
			this.btnShowCdata.Size = new System.Drawing.Size(117, 23);
			this.btnShowCdata.TabIndex = 14;
			this.btnShowCdata.Text = "Show Cdata";
			this.btnShowCdata.UseVisualStyleBackColor = true;
			this.btnShowCdata.Click += new System.EventHandler(this.btnShowCdata_Click);
			// 
			// tbNoRecs
			// 
			this.tbNoRecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNoRecs.Location = new System.Drawing.Point(109, 268);
			this.tbNoRecs.Name = "tbNoRecs";
			this.tbNoRecs.Size = new System.Drawing.Size(35, 22);
			this.tbNoRecs.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 271);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 16;
			this.label1.Text = "No. Recs";
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(27, 232);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(117, 23);
			this.btnReset.TabIndex = 17;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnAddMoon
			// 
			this.btnAddMoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddMoon.Location = new System.Drawing.Point(27, 126);
			this.btnAddMoon.Name = "btnAddMoon";
			this.btnAddMoon.Size = new System.Drawing.Size(117, 23);
			this.btnAddMoon.TabIndex = 18;
			this.btnAddMoon.Text = "Add Moon";
			this.btnAddMoon.UseVisualStyleBackColor = true;
			this.btnAddMoon.Click += new System.EventHandler(this.btnAddMoon_Click);
			// 
			// btnCreateFinal
			// 
			this.btnCreateFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreateFinal.Location = new System.Drawing.Point(27, 197);
			this.btnCreateFinal.Name = "btnCreateFinal";
			this.btnCreateFinal.Size = new System.Drawing.Size(117, 23);
			this.btnCreateFinal.TabIndex = 19;
			this.btnCreateFinal.Text = "Create Final XML";
			this.btnCreateFinal.UseVisualStyleBackColor = true;
			this.btnCreateFinal.Click += new System.EventHandler(this.btnCreateFinal_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1226, 635);
			this.Controls.Add(this.btnCreateFinal);
			this.Controls.Add(this.btnAddMoon);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbNoRecs);
			this.Controls.Add(this.btnShowCdata);
			this.Controls.Add(this.btnMoon);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnAdd2List);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbFileName);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lbMonth);
			this.Controls.Add(this.btnOpenCSV);
			this.Name = "MainForm";
			this.Text = "Sunrise Sunset";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOpenCSV;
		private System.Windows.Forms.ListBox lbMonth;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox tbFileName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAdd2List;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Button btnMoon;
		private System.Windows.Forms.Button btnShowCdata;
		private System.Windows.Forms.TextBox tbNoRecs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnAddMoon;
		private System.Windows.Forms.Button btnCreateFinal;
	}
}

