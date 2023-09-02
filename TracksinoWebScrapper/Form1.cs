using HtmlAgilityPack;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TracksinoWebScrapper
{
    public partial class Form1 : Form
    {

        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();



        }



        private async void AnotherStack()
        {
            string subject1 = "test";
            string subject2 = "StackOverFlow";

            Dictionary<string, string> parameters = new Dictionary<string, string>()
            {
            { "Subject1", subject1 },
            { "Subject2", subject2 }
             };


            try
            {
                string result = await PostHTTPRequestAsync("https://tracksino.com/crazytime", parameters);
                tboxMain.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private static async Task<string> PostHTTPRequestAsync(string url, Dictionary<string, string> data)
        {

            using (HttpContent formContent = new FormUrlEncodedContent(data))
            using (HttpResponseMessage response = await client.PostAsync(url, formContent).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }
        private  void button1_Click(object sender, EventArgs e)
        {


            //string url = "https://tracksino.com/crazytime";
            //var httpClient = new HttpClient();

            //var html = httpClient.GetStringAsync(url).Result;
            //var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            //htmlDocument.LoadHtml(html);


            SeleniumTrial();





        }
        private void SeleniumTrial()
        {
            // the URL of the target Wikipedia page
            string url = "https://tracksino.com/crazytime";

            // to initialize the Chrome Web Driver in headless mode
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            var driver = new ChromeDriver();

            // connecting to the target web page
            //driver.Navigate().GoToUrl(url);
            driver.Navigate().GoToUrl(url);


            var nodes = driver.FindElements(By.XPath("//table[@class='table b-table table-striped table-bordered']"));

            var asd = driver.FindElement(By.Id("spin-history"));

            var item = asd.FindElement(By.XPath("//tbody")).Text;

            var formattedResult = Regex.Split(item, "\r\n|\r|\n");

            string[] finalResult = new string[10];
            int j = 0;
            for (int i = 0; i < finalResult.Length; i++)
            {
                finalResult[i] = formattedResult[j] + " " + formattedResult[j + 1];
                j += 2;
            }

            List<SpinHistory> spinHistories = new List<SpinHistory>();

            for (int i = 0; i < finalResult.Length; i++)
            {
                string[] splittedValue = finalResult[i].Split(' ');
                spinHistories.Add(new SpinHistory()
                {
                    OccuredAt = GetArrayValueFromArrayString(finalResult[i]),
                    SlotResult = finalResult[i].Split(' ')[4],
                    //SpinResult = finalResult[i].Split(' ')[5],
                    Multiplier = finalResult[i].Split(' ')[5],
                    TotalWinners = finalResult[i].Split(' ')[6],
                    TotalPayout = finalResult[i].Split(' ')[7],
                });

            }

            dataGridView1.DataSource = spinHistories;

        }
        private string GetArrayValueFromArrayString(string value)
        {
            string[] temp = value.Split(' ').Take(4).ToArray();

            StringBuilder anotherTemp = new StringBuilder();

            for (int i = 0; i < temp.Length; i++)
                anotherTemp.Append(temp[i] + " ");

            return anotherTemp.ToString().TrimEnd();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}