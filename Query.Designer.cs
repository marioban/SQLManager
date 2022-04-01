namespace SQLManager
{
    partial class Query
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
            this.CbDatabase = new System.Windows.Forms.ComboBox();
            this.TbQuery = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.TcResMes = new System.Windows.Forms.TabControl();
            this.TpResults = new System.Windows.Forms.TabPage();
            this.TbResults = new System.Windows.Forms.TextBox();
            this.TpMessages = new System.Windows.Forms.TabPage();
            this.TbMessages = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TcResMes.SuspendLayout();
            this.TpResults.SuspendLayout();
            this.TpMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            // 
            // CbDatabase
            // 
            this.CbDatabase.FormattingEnabled = true;
            this.CbDatabase.Location = new System.Drawing.Point(127, 47);
            this.CbDatabase.Name = "CbDatabase";
            this.CbDatabase.Size = new System.Drawing.Size(211, 24);
            this.CbDatabase.TabIndex = 1;
            // 
            // TbQuery
            // 
            this.TbQuery.Location = new System.Drawing.Point(40, 116);
            this.TbQuery.Multiline = true;
            this.TbQuery.Name = "TbQuery";
            this.TbQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbQuery.Size = new System.Drawing.Size(1029, 345);
            this.TbQuery.TabIndex = 2;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(994, 69);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 41);
            this.BtnExecute.TabIndex = 3;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // TcResMes
            // 
            this.TcResMes.Controls.Add(this.TpResults);
            this.TcResMes.Controls.Add(this.TpMessages);
            this.TcResMes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TcResMes.Location = new System.Drawing.Point(0, 489);
            this.TcResMes.Name = "TcResMes";
            this.TcResMes.SelectedIndex = 0;
            this.TcResMes.Size = new System.Drawing.Size(1108, 411);
            this.TcResMes.TabIndex = 4;
            // 
            // TpResults
            // 
            this.TpResults.Controls.Add(this.TbResults);
            this.TpResults.Location = new System.Drawing.Point(4, 25);
            this.TpResults.Name = "TpResults";
            this.TpResults.Padding = new System.Windows.Forms.Padding(3);
            this.TpResults.Size = new System.Drawing.Size(1100, 382);
            this.TpResults.TabIndex = 0;
            this.TpResults.Text = "Results";
            this.TpResults.UseVisualStyleBackColor = true;
            // 
            // TbResults
            // 
            this.TbResults.Location = new System.Drawing.Point(0, 0);
            this.TbResults.Multiline = true;
            this.TbResults.Name = "TbResults";
            this.TbResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbResults.Size = new System.Drawing.Size(1097, 379);
            this.TbResults.TabIndex = 0;
            // 
            // TpMessages
            // 
            this.TpMessages.Controls.Add(this.TbMessages);
            this.TpMessages.Location = new System.Drawing.Point(4, 25);
            this.TpMessages.Name = "TpMessages";
            this.TpMessages.Padding = new System.Windows.Forms.Padding(3);
            this.TpMessages.Size = new System.Drawing.Size(1100, 382);
            this.TpMessages.TabIndex = 1;
            this.TpMessages.Text = "Messages";
            this.TpMessages.UseVisualStyleBackColor = true;
            // 
            // TbMessages
            // 
            this.TbMessages.Location = new System.Drawing.Point(0, 0);
            this.TbMessages.Multiline = true;
            this.TbMessages.Name = "TbMessages";
            this.TbMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbMessages.Size = new System.Drawing.Size(1104, 386);
            this.TbMessages.TabIndex = 0;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(885, 69);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(93, 41);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 900);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TcResMes);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.TbQuery);
            this.Controls.Add(this.CbDatabase);
            this.Controls.Add(this.label1);
            this.Name = "Query";
            this.Text = "Query";
            this.TcResMes.ResumeLayout(false);
            this.TpResults.ResumeLayout(false);
            this.TpResults.PerformLayout();
            this.TpMessages.ResumeLayout(false);
            this.TpMessages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDatabase;
        private System.Windows.Forms.TextBox TbQuery;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.TabControl TcResMes;
        private System.Windows.Forms.TabPage TpResults;
        private System.Windows.Forms.TextBox TbResults;
        private System.Windows.Forms.TabPage TpMessages;
        private System.Windows.Forms.TextBox TbMessages;
        private System.Windows.Forms.Button BtnClear;
    }
}