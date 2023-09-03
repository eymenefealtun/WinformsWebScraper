using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Data.Common;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using TracksineWebScrapper.Business;
using TracksineWebScrapper.Entities;
using TracksineWebScrapper.Utility;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace TracksineWebScrapper
{
    public partial class Form1 : Form
    {

        string _url = "https://tracksino.com/crazytime";
        public EfSpinHistory _efSpinHistory;
        EfSpinHistoryModel _efSpinHistoryModel;
        EfMainModel _efMainModel;
        EfImage _efImage;
        ChromeDriver _chromeDriver;
        ChromeOptions _chromeOptions;
        ChromeDriverService _chromeDriverService;
        public SpinHistoryModel[] _last10Spin = new SpinHistoryModel[10];
        int _numberOfPull = 0;
        int _numberOfErrors = 0;

        public Form1()
        {
            InitializeComponent();
            Utilities utilities = new Utilities(this);

            EfSpinHistory efTracksine = new EfSpinHistory();
            EfSpinHistoryModel efSpinHistoryModel = new EfSpinHistoryModel();
            EfImage efImage = new EfImage();
            EfMainModel efMainModel = new EfMainModel();
            _efSpinHistory = efTracksine;
            _efSpinHistoryModel = efSpinHistoryModel;
            _efImage = efImage;
            _efMainModel = efMainModel;


            lblNumberOfErrors.Text = _numberOfErrors.ToString();

            HandleDatagrid();
            HandleSelenium();

        }

        private void HandleDatagrid()
        {

            dgwTrial.AutoGenerateColumns = false;
            dgwTrial.Columns["OccuredAt"].DataPropertyName = "OccuredAt";
            dgwTrial.Columns["SlotResult"].DataPropertyName = "SlotResult";
            dgwTrial.Columns["SpinResult"].DataPropertyName = "SpinResult";
            dgwTrial.Columns["Multiplier"].DataPropertyName = "Multiplier";
            dgwTrial.Columns["TotalWinners"].DataPropertyName = "TotalWinners";
            dgwTrial.Columns["TotalPayout"].DataPropertyName = "TotalPayout";
            dgwTrial.RowTemplate.Height = 55;
            dgwTrial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgwTrial.ColumnHeadersHeight = 40;
            dgwTrial.GridColor = Color.LightGray;
            dgwTrial.DataSource = _efMainModel.GetDataGridData();

            Utilities.SetLastTenValue();

        }
        private void HandleSelenium()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            _chromeOptions = chromeOptions;

            var chromerDriverService = ChromeDriverService.CreateDefaultService();
            chromerDriverService.HideCommandPromptWindow = true;
            _chromeDriverService = chromerDriverService;

            //kill chromerdriver.exe from taskmanager
            Process[] processes = Process.GetProcessesByName("chromedriver");
            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        private async void RunScrapping()
        {


            _chromeDriver = new ChromeDriver(_chromeDriverService, _chromeOptions);
            _chromeDriver.Navigate().GoToUrl(_url);


            Thread.Sleep(200);

            try
            {

                var rowGroup = _chromeDriver.FindElement(By.XPath("//table[@class='table b-table table-striped table-bordered']")).FindElement(By.XPath("//tbody[@role='rowgroup']"));
                List<SpinHistory> spinHistories = new List<SpinHistory>();
                var rows = rowGroup.FindElements(By.XPath("tr"));

                for (int i = rows.Count; i >= 1; i--)
                {
                    var currentRow = rowGroup.FindElement(By.XPath($"tr[{i}]"));

                    var currentSpinHistory = new SpinHistory()
                    {
                        OccuredAt = currentRow.FindElement(By.XPath("td[1]")).Text,
                        SlotResult = currentRow.FindElement(By.XPath("td[2]")).Text,

                        //SpinResult = Utilities.GetSpinResultFromAbbreviation(currentRow.FindElement(By.XPath("td[3]")).FindElement(By.XPath("center")).FindElement(By.XPath("i")).GetAttribute("class").Split('-')[2]),
                        SpinResult = Utilities.GetSpinIconId(currentRow.FindElement(By.XPath("td[3]")).FindElement(By.XPath("center")).FindElement(By.XPath("i")).GetAttribute("class").Split('-')[2]),



                        Multiplier = currentRow.FindElement(By.XPath("td[4]")).Text,
                        //TotalWinners = Convert.ToDecimal(currentRow.FindElement(By.XPath("td[5]")).Text),
                        //TotalWinners = Convert.ToInt32(currentRow.FindElement(By.XPath("td[5]")).Text),
                        TotalWinners = int.Parse(currentRow.FindElement(By.XPath("td[5]")).FindElement(By.XPath("span")).Text, NumberStyles.AllowThousands),
                        TotalPayout = currentRow.FindElement(By.XPath("td[6]")).Text,
                    };

                    if (!Utilities.IsAddedBefore(currentSpinHistory))
                        spinHistories.Add(currentSpinHistory);

                }


                _chromeDriver.Close();
                _chromeDriver.Quit();


                _efSpinHistory.AddRange(spinHistories);
                dgwTrial.DataSource = _efMainModel.GetDataGridData(); //////////////

                //////MessageBox.Show("Data cekildi");


                Utilities.SetLastTenValue();


            }
            catch (Exception exception)
            {
                _chromeDriver.Quit();
                _numberOfErrors++;
                lblNumberOfErrors.Text = _numberOfErrors.ToString();
                //MessageBox.Show(exception.Message);
            }

        }


        private void TimerTick()
        {
            Cursor.Current = Cursors.WaitCursor;
            RunScrapping();
            _numberOfPull++;
            timerMain.Interval = 120000 + Utilities.GetRandomValue(20000, -10000);
            lblNumberOfPull.Text = _numberOfPull.ToString();
            lblTotalData.Text = _efSpinHistory.GetAll().Count().ToString();
            Cursor.Current = null;
        }

        private void btnGetData_Click_1(object sender, EventArgs e)
        {
            TimerTick();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            TimerTick();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            TimerTick();
            timerMain.Start();
            dgwTrial.DataSource = _efMainModel.GetDataGridData();






        }

    }
}
