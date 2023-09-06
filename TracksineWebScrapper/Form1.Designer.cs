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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelMain = new Panel();
            pBoxRefresh = new PictureBox();
            dgwTrial = new DataGridView();
            btnFetchData = new Button();
            lblNoSuchElementOccured = new Label();
            label4 = new Label();
            rBoxError = new RichTextBox();
            lblNumberOfErrors = new Label();
            label3 = new Label();
            lblTotalData = new Label();
            label2 = new Label();
            lblNumberOfPull = new Label();
            lblNamePull = new Label();
            btnScrapeManually = new Button();
            timerMain = new System.Windows.Forms.Timer(components);
            OccuredAt = new DataGridViewTextBoxColumn();
            SlotResult = new DataGridHandler.TextAndImageColumn();
            SpinResult = new DataGridViewImageColumn();
            Multiplier = new DataGridViewTextBoxColumn();
            TotalWinners = new DataGridViewTextBoxColumn();
            TotalPayout = new DataGridViewTextBoxColumn();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwTrial).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.Controls.Add(pBoxRefresh);
            panelMain.Controls.Add(dgwTrial);
            panelMain.Location = new Point(5, 5);
            panelMain.Margin = new Padding(0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(922, 500);
            panelMain.TabIndex = 0;
            // 
            // pBoxRefresh
            // 
            pBoxRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pBoxRefresh.Image = TracksinoWebScraper.Properties.Resources.refresh;
            pBoxRefresh.Location = new Point(883, 0);
            pBoxRefresh.Name = "pBoxRefresh";
            pBoxRefresh.Size = new Size(37, 39);
            pBoxRefresh.TabIndex = 12;
            pBoxRefresh.TabStop = false;
            pBoxRefresh.Visible = false;
            // 
            // dgwTrial
            // 
            dgwTrial.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgwTrial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwTrial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgwTrial.DefaultCellStyle = dataGridViewCellStyle4;
            dgwTrial.Location = new Point(0, 0);
            dgwTrial.Margin = new Padding(0);
            dgwTrial.Name = "dgwTrial";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgwTrial.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgwTrial.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(239, 243, 246);
            dgwTrial.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgwTrial.RowTemplate.Height = 25;
            dgwTrial.Size = new Size(880, 500);
            dgwTrial.TabIndex = 1;
            // 
            // btnFetchData
            // 
            btnFetchData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFetchData.Location = new Point(1036, 450);
            btnFetchData.Name = "btnFetchData";
            btnFetchData.Size = new Size(86, 55);
            btnFetchData.TabIndex = 11;
            btnFetchData.Text = "Fetch Data from DataBase";
            btnFetchData.UseVisualStyleBackColor = true;
            btnFetchData.Click += btnFetchData_Click;
            // 
            // lblNoSuchElementOccured
            // 
            lblNoSuchElementOccured.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNoSuchElementOccured.AutoSize = true;
            lblNoSuchElementOccured.Location = new Point(1094, 92);
            lblNoSuchElementOccured.Name = "lblNoSuchElementOccured";
            lblNoSuchElementOccured.Size = new Size(13, 15);
            lblNoSuchElementOccured.TabIndex = 10;
            lblNoSuchElementOccured.Text = "0";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(950, 92);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 9;
            label4.Text = "NoSuchElement Occured";
            // 
            // rBoxError
            // 
            rBoxError.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            rBoxError.Location = new Point(942, 391);
            rBoxError.Name = "rBoxError";
            rBoxError.Size = new Size(157, 40);
            rBoxError.TabIndex = 8;
            rBoxError.Text = "";
            // 
            // lblNumberOfErrors
            // 
            lblNumberOfErrors.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumberOfErrors.AutoSize = true;
            lblNumberOfErrors.Location = new Point(1095, 64);
            lblNumberOfErrors.Name = "lblNumberOfErrors";
            lblNumberOfErrors.Size = new Size(13, 15);
            lblNumberOfErrors.TabIndex = 6;
            lblNumberOfErrors.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(951, 64);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 5;
            label3.Text = "Number of errors occured";
            // 
            // lblTotalData
            // 
            lblTotalData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalData.AutoSize = true;
            lblTotalData.Location = new Point(1095, 38);
            lblTotalData.Name = "lblTotalData";
            lblTotalData.Size = new Size(13, 15);
            lblTotalData.TabIndex = 4;
            lblTotalData.Text = "0";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(951, 38);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 3;
            label2.Text = "Total data received by far";
            // 
            // lblNumberOfPull
            // 
            lblNumberOfPull.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNumberOfPull.AutoSize = true;
            lblNumberOfPull.Location = new Point(1047, 14);
            lblNumberOfPull.Name = "lblNumberOfPull";
            lblNumberOfPull.Size = new Size(13, 15);
            lblNumberOfPull.TabIndex = 2;
            lblNumberOfPull.Text = "0";
            // 
            // lblNamePull
            // 
            lblNamePull.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNamePull.AutoSize = true;
            lblNamePull.Location = new Point(950, 14);
            lblNamePull.Name = "lblNamePull";
            lblNamePull.Size = new Size(91, 15);
            lblNamePull.TabIndex = 1;
            lblNamePull.Text = "Number of pull:";
            // 
            // btnScrapeManually
            // 
            btnScrapeManually.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnScrapeManually.Cursor = Cursors.Hand;
            btnScrapeManually.Location = new Point(928, 450);
            btnScrapeManually.Name = "btnScrapeManually";
            btnScrapeManually.Size = new Size(86, 55);
            btnScrapeManually.TabIndex = 1;
            btnScrapeManually.Text = "Scrape manually";
            btnScrapeManually.UseVisualStyleBackColor = true;
            btnScrapeManually.Click += btnScrapManually_Click;
            // 
            // timerMain
            // 
            timerMain.Interval = 120000;
            timerMain.Tick += timerMain_Tick;
            // 
            // OccuredAt
            // 
            OccuredAt.HeaderText = "Occured At";
            OccuredAt.MinimumWidth = 146;
            OccuredAt.Name = "OccuredAt";
            // 
            // SlotResult
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SlotResult.DefaultCellStyle = dataGridViewCellStyle3;
            SlotResult.HeaderText = "Slot Result";
            SlotResult.Image = null;
            SlotResult.MinimumWidth = 140;
            SlotResult.Name = "SlotResult";
            SlotResult.Resizable = DataGridViewTriState.True;
            // 
            // SpinResult
            // 
            SpinResult.HeaderText = "SpinResult";
            SpinResult.MinimumWidth = 140;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1134, 511);
            Controls.Add(panelMain);
            Controls.Add(btnFetchData);
            Controls.Add(lblNoSuchElementOccured);
            Controls.Add(btnScrapeManually);
            Controls.Add(label4);
            Controls.Add(lblNamePull);
            Controls.Add(rBoxError);
            Controls.Add(lblNumberOfPull);
            Controls.Add(label2);
            Controls.Add(lblNumberOfErrors);
            Controls.Add(lblTotalData);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Tracksino Web Scraper";
            Load += Form1_Load;
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBoxRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwTrial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMain;
        private Button btnScrapeManually;
        private Label lblNamePull;
        private Label lblNumberOfPull;
        private System.Windows.Forms.Timer timerMain;
        private Label lblTotalData;
        private Label label2;
        private Label lblNumberOfErrors;
        private Label label3;
        private DataGridView dgwTrial;
        private RichTextBox rBoxError;
        private Label lblNoSuchElementOccured;
        private Label label4;
        private Button btnFetchData;
        private PictureBox pBoxRefresh;
        private DataGridViewTextBoxColumn OccuredAt;
        private DataGridHandler.TextAndImageColumn SlotResult;
        private DataGridViewImageColumn SpinResult;
        private DataGridViewTextBoxColumn Multiplier;
        private DataGridViewTextBoxColumn TotalWinners;
        private DataGridViewTextBoxColumn TotalPayout;
    }
}