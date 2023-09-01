using HtmlAgilityPack;
using System.Drawing;
using System.Windows.Forms;

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
        private async void button1_Click(object sender, EventArgs e)
        {


            string url = "https://tracksino.com/crazytime";
            var httpClient = new HttpClient();

            var html = httpClient.GetStringAsync(url).Result;
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);








        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}