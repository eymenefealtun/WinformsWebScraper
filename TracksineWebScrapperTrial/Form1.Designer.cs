namespace TracksineWebScrapperTrial
{
    partial class Form1
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.tboxRich = new System.Windows.Forms.RichTextBox();
            this.dgwMain = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(781, 409);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 56);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Data Cek";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // tboxRich
            // 
            this.tboxRich.Location = new System.Drawing.Point(788, 279);
            this.tboxRich.Name = "tboxRich";
            this.tboxRich.Size = new System.Drawing.Size(68, 32);
            this.tboxRich.TabIndex = 1;
            this.tboxRich.Text = "";
            // 
            // dgwMain
            // 
            this.dgwMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgwMain.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMain.Location = new System.Drawing.Point(13, 12);
            this.dgwMain.Name = "dgwMain";
            this.dgwMain.RowHeadersVisible = false;
            this.dgwMain.RowHeadersWidth = 51;
            this.dgwMain.Size = new System.Drawing.Size(668, 466);
            this.dgwMain.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMain.Controls.Add(this.dgwMain);
            this.pnlMain.Controls.Add(this.tboxRich);
            this.pnlMain.Controls.Add(this.btnGetData);
            this.pnlMain.Location = new System.Drawing.Point(-1, 9);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(868, 481);
            this.pnlMain.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.pnlMain);
            this.Name = "Form1";
            this.Text = "TracksineScrapper";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.RichTextBox tboxRich;
        private System.Windows.Forms.DataGridView dgwMain;
        private System.Windows.Forms.Panel pnlMain;
    }
}

