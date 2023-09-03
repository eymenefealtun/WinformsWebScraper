using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using TracksineWebScrapper.Business;
using TracksineWebScrapper.Entities;
using TracksineWebScrapper.Entities.Models;
using TracksineWebScrapper.Utility;

namespace TracksineWebScrapper
{
    public partial class Form1 : Form
    {

        string _url = "https://tracksino.com/crazytime";
        public EfSpinHistory _efSpinHistory;
        EfSpinHistoryModel _efSpinHistoryModel;
        EfMainModel _efMainModel;
        EfSpinResultImage _efImage;
        ChromeDriver _chromeDriver;
        ChromeOptions _chromeOptions;
        ChromeDriverService _chromeDriverService;
        public SpinHistoryModel[] _last10Spin = new SpinHistoryModel[10];
        int _numberOfPull = 0;
        int _numberOfErrors = 0;
        int _noSuchElementError = 0;

        StringBuilder _stringBuilder;
        public Form1()
        {
            InitializeComponent();
            Utilities utilities = new Utilities(this);

            EfSpinHistory efTracksine = new EfSpinHistory();
            EfSpinHistoryModel efSpinHistoryModel = new EfSpinHistoryModel();
            EfSpinResultImage efImage = new EfSpinResultImage();
            EfMainModel efMainModel = new EfMainModel();
            _efSpinHistory = efTracksine;
            _efSpinHistoryModel = efSpinHistoryModel;
            _efImage = efImage;
            _efMainModel = efMainModel;

            StringBuilder stringBuilder = new StringBuilder();
            _stringBuilder = stringBuilder;

            lblNumberOfErrors.Text = _numberOfErrors.ToString();
            lblNoSuchElementOccured.Text = _noSuchElementError.ToString();
            HandleDatagrid();
            HandleSelenium();

        }

        private void HandleDatagrid()
        {

            dgwTrial.AutoGenerateColumns = false;
            dgwTrial.Columns["OccuredAt"].DataPropertyName = "OccuredAt";
            //dgwTrial.Columns["SlotResult"].DataPropertyName = "SlotResult";
            dgwTrial.Columns["SlotResult"].DataPropertyName = "SlotResultImage";
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

        private void RunScrapping()
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


                    var temp = currentRow.FindElement(By.XPath("td[2]")).FindElement(By.XPath("span")).FindElement(By.XPath("i")).GetAttribute("class").Split('-')[3];

                    var currentSpinHistory = new SpinHistory()
                    {
                        OccuredAt = currentRow.FindElement(By.XPath("td[1]")).Text,

                        SlotResultImageId = Utilities.GetSlotResultImageId(currentRow.FindElement(By.XPath("td[2]")).FindElement(By.XPath("span")).FindElement(By.XPath("i")).GetAttribute("class").Split('-')[3]),
                        SlotResultText = currentRow.FindElement(By.XPath("td[2]")).Text,

                        SpinResultId = Utilities.GetSpinIconId(currentRow.FindElement(By.XPath("td[3]")).FindElement(By.XPath("center")).FindElement(By.XPath("i")).GetAttribute("class").Split('-')[2]),

                        Multiplier = currentRow.FindElement(By.XPath("td[4]")).Text,
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

                ////MessageBox.Show("Data cekildi");


                Utilities.SetLastTenValue();


            }
            catch (NoSuchElementException exception)
            {
                //This part prevents us from missing any data caused by not loading the HTML.
                //Sometimes, we might be scraping HTML while it is still being uploaded and not entirely done.
                //We wait using 'Thread.Sleep(2000)' in order to get the full HTML, and try to receive adata again.
                //If I don't do this here, I sometimes get an exception as below:
                //
                //no such element: Unable to locate element: {"method":"xpath","selector":"span"}
                //
                _noSuchElementError++;
                lblNoSuchElementOccured.Text = _noSuchElementError.ToString();
                Thread.Sleep(2000);
                TimerTick();
            }
            catch (Exception exception)
            {
                _chromeDriver.Quit();
                _numberOfErrors++;
                lblNumberOfErrors.Text = _numberOfErrors.ToString();
                _stringBuilder.AppendLine(exception.Message);
                rBoxError.Text = _stringBuilder.ToString();
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
