using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using TracksineWebScrapper.Business;
using TracksineWebScrapper.DataGridHandler;
using TracksineWebScrapper.Entities;
using TracksineWebScrapper.Entities.Models;
using TracksineWebScrapper.Utility;

namespace TracksineWebScrapper
{
    public partial class Form1 : Form
    {

        string _url = "https://tracksino.com/crazytime";
        public EfSpinHistory _efSpinHistory;
        EfMainModel _efMainModel;
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

            #region Creating instances
            Utilities utilities = new Utilities(this);
            _efSpinHistory = new EfSpinHistory();
            _efMainModel = new EfMainModel();
            _stringBuilder = new StringBuilder();
            #endregion

            lblNumberOfErrors.Text = _numberOfErrors.ToString();
            lblNoSuchElementOccured.Text = _noSuchElementError.ToString();

            HandleDatagrid();
            HandleSelenium();


        }

        private void HandleDatagrid()
        {

            dgwTrial.AutoGenerateColumns = false;
            dgwTrial.Columns["OccuredAt"].DataPropertyName = "OccuredAt";
            dgwTrial.Columns["SlotResult"].DataPropertyName = "SlotResultText";
            //dgwTrial.Columns["SlotResult"].DataPropertyName = "SlotResultImage";
            dgwTrial.Columns["SpinResult"].DataPropertyName = "SpinResult";
            dgwTrial.Columns["Multiplier"].DataPropertyName = "Multiplier";
            dgwTrial.Columns["TotalWinners"].DataPropertyName = "TotalWinners";
            dgwTrial.Columns["TotalPayout"].DataPropertyName = "TotalPayout";
            dgwTrial.RowTemplate.Height = 55;
            dgwTrial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgwTrial.ColumnHeadersHeight = 40;
            dgwTrial.GridColor = Color.LightGray;

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
                List<MainModel> mainModels = new List<MainModel>();


                var rows = rowGroup.FindElements(By.XPath("tr"));

                for (int i = rows.Count; i >= 1; i--)
                {
                    var currentRow = rowGroup.FindElement(By.XPath($"tr[{i}]"));

                    var currentSpinHistory = new SpinHistory()
                    {
                        OccuredAt = currentRow.FindElement(By.XPath("td[1]")).Text,
                        SlotResultImageId = Utilities.GetIconIdAccordingToItsText(currentRow.FindElement(By.XPath("td[2]")).FindElement(By.XPath("span")).FindElement(By.XPath("i")).GetAttribute("class").Split('-')[3]),
                        SlotResultText = currentRow.FindElement(By.XPath("td[2]")).Text,
                        SpinResultId = Utilities.GetIdFromStringForSpin((currentRow.FindElement(By.XPath("td[3]")).FindElement(By.XPath("center")).FindElement(By.XPath("i")).GetAttribute("class").Split('-')[2])),
                        Multiplier = currentRow.FindElement(By.XPath("td[4]")).Text,
                        TotalWinners = int.Parse(currentRow.FindElement(By.XPath("td[5]")).FindElement(By.XPath("span")).Text, NumberStyles.AllowThousands),
                        TotalPayout = currentRow.FindElement(By.XPath("td[6]")).Text,
                    };



                    if (!Utilities.IsAddedBefore(currentSpinHistory))
                    {
                        spinHistories.Add(currentSpinHistory);

                        mainModels.Add(new MainModel()
                        {
                            Id = currentSpinHistory.Id,
                            OccuredAt = currentSpinHistory.OccuredAt,
                            SlotResultImage = Utilities.GetSlotResultImageByteFromIconId(currentSpinHistory.SlotResultImageId),
                            SlotResultText = currentSpinHistory.SlotResultText,
                            SpinResultImage = Utilities.GetSpinResultImageByteFromIconId(currentSpinHistory.SpinResultId),
                            Multiplier = currentSpinHistory.Multiplier,
                            TotalWinners = currentSpinHistory.TotalWinners,
                            TotalPayout = currentSpinHistory.TotalPayout,
                        });

                    }
                }

                // close driver
                _chromeDriver.Close();
                _chromeDriver.Quit();


                // Inert into db
                _efSpinHistory.AddRange(spinHistories);

                // Updating DataGridView
                for (int i = 0; i < mainModels.Count(); i++)
                {
                    #region Insert
                    dgwTrial.Rows.Insert(0, mainModels[i].OccuredAt,
                        mainModels[i].SlotResultText,
                        mainModels[i].SpinResultImage,
                        mainModels[i].Multiplier,
                        mainModels[i].TotalWinners,
                        mainModels[i].TotalPayout);
                    SetImagesToDataGridView(0, mainModels[i]);
                    #endregion
                }


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
                Thread.Sleep(4000);
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
            timerMain.Interval = 120000 + Utilities.GetRandomValue(-10, 20); // 2 minutes and plus random
            lblNumberOfPull.Text = _numberOfPull.ToString();
            lblTotalData.Text = _efSpinHistory.GetAll().Count().ToString();
            Cursor.Current = null;
        }

        private void btnFetchData_Click(object sender, EventArgs e)
        {
            PullValuesFromDatabase();
        }

        private void btnScrapManually_Click(object sender, EventArgs e)
        {
            TimerTick();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            TimerTick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            PullValuesFromDatabase();
            SetTimerInterval(5, 0, 0); // for initial pull
            timerMain.Start();

        }

        private void SetTimerInterval(int second, int positiveSecond, int negativeSecond)
        {
            timerMain.Interval = second * 1000;
        }

        private void PullValuesFromDatabase()
        {
            var list = _efMainModel.GetDataGridData();
            for (int i = 0; i < list.Count(); i++)
            {
                dgwTrial.Rows.Add();
                int rowIndex = dgwTrial.RowCount - 1;
                DataGridViewRow r = dgwTrial.Rows[rowIndex];
                r.Cells["OccuredAt"].Value = list[i].OccuredAt;
                r.Cells["SlotResult"].Value = list[i].SlotResultText;
                r.Cells["SpinResult"].Value = list[i].SpinResultImage;
                r.Cells["Multiplier"].Value = list[i].Multiplier;
                r.Cells["TotalWinners"].Value = list[i].TotalWinners;
                r.Cells["TotalPayout"].Value = list[i].TotalPayout;
                SetImagesToDataGridView(rowIndex, list[i]);
            }
        }
        
        private void SetImagesToDataGridView(int rowIndex, MainModel model)
        {
            ((TextAndImageCell)dgwTrial.Rows[rowIndex].Cells[1]).Image = Utilities.ByteArrayToImage(model.SlotResultImage);
        }


    }
}
