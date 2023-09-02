namespace TracksineWebScrapper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new Panel();
            btnGetData = new Button();
            dgwMain = new DataGridView();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMain).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.Controls.Add(btnGetData);
            panelMain.Controls.Add(dgwMain);
            panelMain.Location = new Point(12, 30);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(719, 453);
            panelMain.TabIndex = 0;
            // 
            // btnGetData
            // 
            btnGetData.Location = new Point(620, 383);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(75, 55);
            btnGetData.TabIndex = 1;
            btnGetData.Text = "Data Cek";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click_1;
            // 
            // dgwMain
            // 
            dgwMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMain.Location = new Point(12, 5);
            dgwMain.Name = "dgwMain";
            dgwMain.RowHeadersVisible = false;
            dgwMain.RowTemplate.Height = 25;
            dgwMain.Size = new Size(602, 433);
            dgwMain.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 511);
            Controls.Add(panelMain);
            Name = "Form1";
            Text = "Form1";
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private DataGridView dgwMain;
        private Button btnGetData;
    }
}