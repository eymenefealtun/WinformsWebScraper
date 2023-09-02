using Microsoft.EntityFrameworkCore.Query.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using TracksineWebScrapper.Business;
using TracksineWebScrapper.Entities;

namespace TracksineWebScrapper
{
    public partial class Form1 : Form
    {

        string _url = "https://tracksino.com/crazytime";
        EfSpinHistory _efSpinHistory;
        EfSpinHistoryModel _efSpinHistoryModel;
        ChromeDriver _chromeDriver;
        ChromeOptions _chromeOptions;
        ChromeDriverService _chromeDriverService;
        SpinHistoryModel[] _last10Spin = new SpinHistoryModel[10];
        Random _random = new Random();
        int _numberOfPull = 0;

        public Form1()
        {
            InitializeComponent();

            EfSpinHistory efTracksine = new EfSpinHistory();
            EfSpinHistoryModel efSpinHistoryModel = new EfSpinHistoryModel();
            _efSpinHistory = efTracksine;
            _efSpinHistoryModel = efSpinHistoryModel;


            HandleDatagrid();
            HandleSelenium();

            TimerTick();

            timerMain.Start();
        }
        private void SetLastTenValue()
        {
            _last10Spin = null;
            _last10Spin = _efSpinHistory.GetAll().OrderByDescending(x => x.Id).Take(10).Select(x => new SpinHistoryModel
            {
                OccuredAt = x.OccuredAt,
                SlotResult = x.SlotResult,
                SpinResult = x.SpinResult,
                Multiplier = x.Multiplier,
                TotalWinners = x.TotalWinners,
                TotalPayout = x.TotalPayout
            }).ToArray();
        }
        private void HandleDatagrid()
        {

            #region design
            dgwMain.AutoGenerateColumns = false;
            dgwMain.Columns["OccuredAt"].DataPropertyName = "OccuredAt";
            dgwMain.Columns["SlotResult"].DataPropertyName = "SlotResult";
            dgwMain.Columns["SpinResult"].DataPropertyName = "SpinResult";
            dgwMain.Columns["Multiplier"].DataPropertyName = "Multiplier";
            dgwMain.Columns["TotalWinners"].DataPropertyName = "TotalWinners";
            dgwMain.Columns["TotalPayout"].DataPropertyName = "TotalPayout";

            dgwMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwMain.ColumnHeadersHeight = 30;
            //this.dgwMain.RowHeadersWidth = 120;

            #endregion

            dgwMain.DataSource = _efSpinHistoryModel.GetAllRaw();

            SetLastTenValue();

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

            //try
            //{

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
                        SpinResult = currentRow.FindElement(By.XPath("td[3]")).FindElement(By.XPath("center")).FindElement(By.XPath("i")).GetAttribute("class").Split('-')[2],
                        Multiplier = currentRow.FindElement(By.XPath("td[4]")).Text,
                        TotalWinners = Convert.ToDecimal(currentRow.FindElement(By.XPath("td[5]")).Text),
                        TotalPayout = currentRow.FindElement(By.XPath("td[6]")).Text,
                    };

                    if (!IsAddedBefore(currentSpinHistory))
                        spinHistories.Add(currentSpinHistory);

                }


                _chromeDriver.Close();
                _chromeDriver.Quit();


                _efSpinHistory.AddRange(spinHistories);
                dgwMain.DataSource = _efSpinHistoryModel.GetAllRaw();

                //MessageBox.Show("Data cekildi");


                SetLastTenValue();


            //}
            //catch (Exception exception)
            //{
            //    _chromeDriver.Quit();
            //    MessageBox.Show(exception.Message);
            //}

        }

        private bool IsAddedBefore(SpinHistory spinHistory)
        {
            bool isAdded = false;

            for (int i = 0; i < _last10Spin.Count(); i++)
            {
                if (_last10Spin[i].OccuredAt == spinHistory.OccuredAt
                   && _last10Spin[i].SlotResult == spinHistory.SlotResult
                   && _last10Spin[i].SpinResult == spinHistory.SpinResult
                   && _last10Spin[i].Multiplier == spinHistory.Multiplier
                   && _last10Spin[i].TotalWinners == spinHistory.TotalWinners
                   && _last10Spin[i].TotalPayout == spinHistory.TotalPayout)
                {

                    isAdded = true;
                    break;
                }
            }

            return isAdded;
        }
        private void btnGetData_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            RunScrapping();
            Cursor.Current = null;
        }

        private void TimerTick()
        {
            RunScrapping();

            _numberOfPull++;
            timerMain.Interval = 120000 + GetRandomValue();
            lblNumberOfPull.Text = _numberOfPull.ToString();
        }
        private void timerMain_Tick(object sender, EventArgs e)
        {
            TimerTick();
        }


        private int GetRandomValue()
        {
            int positive = _random.Next(0, 20000); //20 second +
            int negative = _random.Next(0, 10000); //10 second -

            return Random1Over2() ? positive : negative;
        }

        private bool Random1Over2()
        {
            int value = _random.Next(0, 10);
            return value < 4 ? false : true;
        }



    }
}
