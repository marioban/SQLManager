namespace SQLManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.LbTables = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbTableColumns = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LbViews = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbViewColumns = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LbProcedures = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbProcedure = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LbProcedureParameters = new System.Windows.Forms.ListBox();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.BtnXML_Table = new System.Windows.Forms.Button();
            this.BtnSelect_Table = new System.Windows.Forms.Button();
            this.BtnSelect_View = new System.Windows.Forms.Button();
            this.BtnXML_View = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases";
            // 
            // CbDatabases
            // 
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(163, 58);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(184, 24);
            this.CbDatabases.TabIndex = 1;
            this.CbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // LbTables
            // 
            this.LbTables.FormattingEnabled = true;
            this.LbTables.ItemHeight = 16;
            this.LbTables.Location = new System.Drawing.Point(163, 234);
            this.LbTables.Name = "LbTables";
            this.LbTables.Size = new System.Drawing.Size(226, 340);
            this.LbTables.TabIndex = 2;
            this.LbTables.SelectedIndexChanged += new System.EventHandler(this.LbTables_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Columns";
            // 
            // LbTableColumns
            // 
            this.LbTableColumns.FormattingEnabled = true;
            this.LbTableColumns.ItemHeight = 16;
            this.LbTableColumns.Location = new System.Drawing.Point(619, 234);
            this.LbTableColumns.Name = "LbTableColumns";
            this.LbTableColumns.Size = new System.Drawing.Size(221, 340);
            this.LbTableColumns.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1001, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Views";
            // 
            // LbViews
            // 
            this.LbViews.FormattingEnabled = true;
            this.LbViews.ItemHeight = 16;
            this.LbViews.Location = new System.Drawing.Point(1099, 234);
            this.LbViews.Name = "LbViews";
            this.LbViews.Size = new System.Drawing.Size(220, 340);
            this.LbViews.TabIndex = 6;
            this.LbViews.SelectedIndexChanged += new System.EventHandler(this.LbViews_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1427, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Columns";
            // 
            // LbViewColumns
            // 
            this.LbViewColumns.FormattingEnabled = true;
            this.LbViewColumns.ItemHeight = 16;
            this.LbViewColumns.Location = new System.Drawing.Point(1525, 234);
            this.LbViewColumns.Name = "LbViewColumns";
            this.LbViewColumns.Size = new System.Drawing.Size(210, 340);
            this.LbViewColumns.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 678);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Procedures";
            // 
            // LbProcedures
            // 
            this.LbProcedures.FormattingEnabled = true;
            this.LbProcedures.ItemHeight = 16;
            this.LbProcedures.Location = new System.Drawing.Point(163, 678);
            this.LbProcedures.Name = "LbProcedures";
            this.LbProcedures.Size = new System.Drawing.Size(226, 324);
            this.LbProcedures.TabIndex = 10;
            this.LbProcedures.SelectedIndexChanged += new System.EventHandler(this.LbProcedures_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 678);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Definition";
            // 
            // TbProcedure
            // 
            this.TbProcedure.Location = new System.Drawing.Point(619, 675);
            this.TbProcedure.Multiline = true;
            this.TbProcedure.Name = "TbProcedure";
            this.TbProcedure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbProcedure.Size = new System.Drawing.Size(700, 327);
            this.TbProcedure.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1427, 678);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Params";
            // 
            // LbProcedureParameters
            // 
            this.LbProcedureParameters.FormattingEnabled = true;
            this.LbProcedureParameters.ItemHeight = 16;
            this.LbProcedureParameters.Location = new System.Drawing.Point(1525, 678);
            this.LbProcedureParameters.Name = "LbProcedureParameters";
            this.LbProcedureParameters.Size = new System.Drawing.Size(215, 324);
            this.LbProcedureParameters.TabIndex = 15;
            // 
            // BtnQuery
            // 
            this.BtnQuery.Location = new System.Drawing.Point(400, 50);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(95, 39);
            this.BtnQuery.TabIndex = 17;
            this.BtnQuery.Text = "Query";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // BtnXML_Table
            // 
            this.BtnXML_Table.Location = new System.Drawing.Point(400, 464);
            this.BtnXML_Table.Name = "BtnXML_Table";
            this.BtnXML_Table.Size = new System.Drawing.Size(95, 43);
            this.BtnXML_Table.TabIndex = 18;
            this.BtnXML_Table.Text = "XML";
            this.BtnXML_Table.UseVisualStyleBackColor = true;
            this.BtnXML_Table.Click += new System.EventHandler(this.BtnXml_Click);
            // 
            // BtnSelect_Table
            // 
            this.BtnSelect_Table.Location = new System.Drawing.Point(400, 531);
            this.BtnSelect_Table.Name = "BtnSelect_Table";
            this.BtnSelect_Table.Size = new System.Drawing.Size(95, 43);
            this.BtnSelect_Table.TabIndex = 19;
            this.BtnSelect_Table.Text = "Select";
            this.BtnSelect_Table.UseVisualStyleBackColor = true;
            this.BtnSelect_Table.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnSelect_View
            // 
            this.BtnSelect_View.Location = new System.Drawing.Point(1338, 531);
            this.BtnSelect_View.Name = "BtnSelect_View";
            this.BtnSelect_View.Size = new System.Drawing.Size(95, 43);
            this.BtnSelect_View.TabIndex = 21;
            this.BtnSelect_View.Text = "Select";
            this.BtnSelect_View.UseVisualStyleBackColor = true;
            this.BtnSelect_View.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnXML_View
            // 
            this.BtnXML_View.Location = new System.Drawing.Point(1338, 464);
            this.BtnXML_View.Name = "BtnXML_View";
            this.BtnXML_View.Size = new System.Drawing.Size(95, 43);
            this.BtnXML_View.TabIndex = 20;
            this.BtnXML_View.Text = "XML";
            this.BtnXML_View.UseVisualStyleBackColor = true;
            this.BtnXML_View.Click += new System.EventHandler(this.BtnXml_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 1055);
            this.Controls.Add(this.BtnSelect_View);
            this.Controls.Add(this.BtnXML_View);
            this.Controls.Add(this.BtnSelect_Table);
            this.Controls.Add(this.BtnXML_Table);
            this.Controls.Add(this.BtnQuery);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LbProcedureParameters);
            this.Controls.Add(this.TbProcedure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbProcedures);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbViewColumns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbViews);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbTableColumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbTables);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.ListBox LbTables;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbTableColumns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LbViews;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LbViewColumns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LbProcedures;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbProcedure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LbProcedureParameters;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.Button BtnXML_Table;
        private System.Windows.Forms.Button BtnSelect_Table;
        private System.Windows.Forms.Button BtnSelect_View;
        private System.Windows.Forms.Button BtnXML_View;
    }
}

