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
            panelMain = new Panel();
            dgwTrial = new DataGridView();
            OccuredAt = new DataGridViewTextBoxColumn();
            SlotResult = new DataGridViewTextBoxColumn();
            SpinResult = new DataGridViewImageColumn();
            Multiplier = new DataGridViewTextBoxColumn();
            TotalWinners = new DataGridViewTextBoxColumn();
            TotalPayout = new DataGridViewTextBoxColumn();
            pBoxTrial = new PictureBox();
            lblNumberOfErrors = new Label();
            label3 = new Label();
            lblTotalData = new Label();
            label2 = new Label();
            lblNumberOfPull = new Label();
            lblNamePull = new Label();
            btnGetData = new Button();
            timerMain = new System.Windows.Forms.Timer(components);
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwTrial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxTrial).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.Controls.Add(dgwTrial);
            panelMain.Controls.Add(pBoxTrial);
            panelMain.Controls.Add(lblNumberOfErrors);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(lblTotalData);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(lblNumberOfPull);
            panelMain.Controls.Add(lblNamePull);
            panelMain.Controls.Add(btnGetData);
            panelMain.Location = new Point(1, 30);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1051, 435);
            panelMain.TabIndex = 0;
            // 
            // dgwTrial
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 243, 246);
            dgwTrial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwTrial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwTrial.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgwTrial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgwTrial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTrial.Columns.AddRange(new DataGridViewColumn[] { OccuredAt, SlotResult, SpinResult, Multiplier, TotalWinners, TotalPayout });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgwTrial.DefaultCellStyle = dataGridViewCellStyle3;
            dgwTrial.Location = new Point(3, 0);
            dgwTrial.Name = "dgwTrial";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgwTrial.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgwTrial.RowHeadersVisible = false;
            dgwTrial.RowTemplate.Height = 25;
            dgwTrial.Size = new Size(823, 432);
            dgwTrial.TabIndex = 1;
            // 
            // OccuredAt
            // 
            OccuredAt.HeaderText = "Occured At";
            OccuredAt.Name = "OccuredAt";
            // 
            // SlotResult
            // 
            SlotResult.HeaderText = "Slot Result";
            SlotResult.Name = "SlotResult";
            // 
            // SpinResult
            // 
            SpinResult.HeaderText = "SpinResult";
            SpinResult.Name = "SpinResult";
            SpinResult.Resizable = DataGridViewTriState.True;
            SpinResult.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Multiplier
            // 
            Multiplier.HeaderText = "Multiplier";
            Multiplier.Name = "Multiplier";
            // 
            // TotalWinners
            // 
            TotalWinners.HeaderText = "Total Winners";
            TotalWinners.Name = "TotalWinners";
            // 
            // TotalPayout
            // 
            TotalPayout.HeaderText = "Total Payout";
            TotalPayout.Name = "TotalPayout";
            // 
            // pBoxTrial
            // 
            pBoxTrial.Location = new Point(869, 126);
            pBoxTrial.Name = "pBoxTrial";
            pBoxTrial.Size = new Size(132, 101);
            pBoxTrial.TabIndex = 7;
            pBoxTrial.TabStop = false;
            // 
            // lblNumberOfErrors
            // 
            lblNumberOfErrors.AutoSize = true;
            lblNumberOfErrors.Location = new Point(1000, 64);
            lblNumberOfErrors.Name = "lblNumberOfErrors";
            lblNumberOfErrors.Size = new Size(19, 15);
            lblNumberOfErrors.TabIndex = 6;
            lblNumberOfErrors.Text = "19";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(856, 64);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 5;
            label3.Text = "Number of errors received";
            // 
            // lblTotalData
            // 
            lblTotalData.AutoSize = true;
            lblTotalData.Location = new Point(1000, 38);
            lblTotalData.Name = "lblTotalData";
            lblTotalData.Size = new Size(19, 15);
            lblTotalData.TabIndex = 4;
            lblTotalData.Text = "19";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(856, 38);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 3;
            label2.Text = "Total data received by far";
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
            btnGetData.Cursor = Cursors.Hand;
            btnGetData.Location = new Point(855, 380);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(102, 55);
            btnGetData.TabIndex = 1;
            btnGetData.Text = "Manuel data çek";
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
            Load += Form1_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwTrial).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxTrial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Button btnGetData;
        private Label lblNamePull;
        private Label lblNumberOfPull;
        private System.Windows.Forms.Timer timerMain;
        private Label lblTotalData;
        private Label label2;
        private Label lblNumberOfErrors;
        private Label label3;
        private PictureBox pBoxTrial;
        private DataGridView dgwTrial;
        private DataGridViewTextBoxColumn OccuredAt;
        private DataGridViewTextBoxColumn SlotResult;
        private DataGridViewImageColumn SpinResult;
        private DataGridViewTextBoxColumn Multiplier;
        private DataGridViewTextBoxColumn TotalWinners;
        private DataGridViewTextBoxColumn TotalPayout;
    }
}