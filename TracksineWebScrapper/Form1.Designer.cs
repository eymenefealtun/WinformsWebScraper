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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgwMain = new DataGridView();
            OccuredAt = new DataGridViewTextBoxColumn();
            SlotResult = new DataGridViewTextBoxColumn();
            SpinResult = new DataGridViewTextBoxColumn();
            Multiplier = new DataGridViewTextBoxColumn();
            TotalWinners = new DataGridViewTextBoxColumn();
            TotalPayout = new DataGridViewTextBoxColumn();
            panelMain = new Panel();
            lblNumberOfPull = new Label();
            lblNamePull = new Label();
            btnGetData = new Button();
            timerMain = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgwMain).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // dgwMain
            // 
            dgwMain.AllowUserToAddRows = false;
            dgwMain.AllowUserToDeleteRows = false;
            dgwMain.AllowUserToOrderColumns = true;
            dgwMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 243, 246);
            dgwMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwMain.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(3, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgwMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgwMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMain.Columns.AddRange(new DataGridViewColumn[] { OccuredAt, SlotResult, SpinResult, Multiplier, TotalWinners, TotalPayout });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgwMain.DefaultCellStyle = dataGridViewCellStyle3;
            dgwMain.EnableHeadersVisualStyles = false;
            dgwMain.GridColor = SystemColors.Control;
            dgwMain.Location = new Point(0, 0);
            dgwMain.Name = "dgwMain";
            dgwMain.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgwMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgwMain.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Padding = new Padding(3, 0, 0, 0);
            dgwMain.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgwMain.RowTemplate.Height = 25;
            dgwMain.Size = new Size(850, 435);
            dgwMain.TabIndex = 0;
            // 
            // OccuredAt
            // 
            OccuredAt.HeaderText = "OccuredAt";
            OccuredAt.Name = "OccuredAt";
            OccuredAt.ReadOnly = true;
            OccuredAt.Width = 138;
            // 
            // SlotResult
            // 
            SlotResult.HeaderText = "SlotResult";
            SlotResult.Name = "SlotResult";
            SlotResult.ReadOnly = true;
            SlotResult.Width = 138;
            // 
            // SpinResult
            // 
            SpinResult.HeaderText = "SpinResult";
            SpinResult.Name = "SpinResult";
            SpinResult.ReadOnly = true;
            SpinResult.Width = 137;
            // 
            // Multiplier
            // 
            Multiplier.HeaderText = "Multiplier";
            Multiplier.Name = "Multiplier";
            Multiplier.ReadOnly = true;
            Multiplier.Width = 138;
            // 
            // TotalWinners
            // 
            TotalWinners.HeaderText = "TotalWinners";
            TotalWinners.Name = "TotalWinners";
            TotalWinners.ReadOnly = true;
            TotalWinners.Width = 138;
            // 
            // TotalPayout
            // 
            TotalPayout.HeaderText = "TotalPayout";
            TotalPayout.Name = "TotalPayout";
            TotalPayout.ReadOnly = true;
            TotalPayout.Width = 138;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.Controls.Add(lblNumberOfPull);
            panelMain.Controls.Add(lblNamePull);
            panelMain.Controls.Add(btnGetData);
            panelMain.Controls.Add(dgwMain);
            panelMain.Location = new Point(1, 30);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1015, 435);
            panelMain.TabIndex = 0;
            // 
            // lblNumberOfPull
            // 
            lblNumberOfPull.AutoSize = true;
            lblNumberOfPull.Location = new Point(952, 14);
            lblNumberOfPull.Name = "lblNumberOfPull";
            lblNumberOfPull.Size = new Size(19, 15);
            lblNumberOfPull.TabIndex = 2;
            lblNumberOfPull.Text = "19";
            // 
            // lblNamePull
            // 
            lblNamePull.AutoSize = true;
            lblNamePull.Location = new Point(855, 14);
            lblNamePull.Name = "lblNamePull";
            lblNamePull.Size = new Size(91, 15);
            lblNamePull.TabIndex = 1;
            lblNamePull.Text = "Number of pull:";
            // 
            // btnGetData
            // 
            btnGetData.Location = new Point(855, 380);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(75, 55);
            btnGetData.TabIndex = 1;
            btnGetData.Text = "Data Cek";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click_1;
            // 
            // timerMain
            // 
            timerMain.Interval = 120000;
            timerMain.Tick += timerMain_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1084, 511);
            Controls.Add(panelMain);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgwMain).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private DataGridView dgwMain;
        private Button btnGetData;
        private DataGridViewTextBoxColumn OccuredAt;
        private DataGridViewTextBoxColumn SlotResult;
        private DataGridViewTextBoxColumn SpinResult;
        private DataGridViewTextBoxColumn Multiplier;
        private DataGridViewTextBoxColumn TotalWinners;
        private DataGridViewTextBoxColumn TotalPayout;
        private Label lblNamePull;
        private Label lblNumberOfPull;
        private System.Windows.Forms.Timer timerMain;
    }
}