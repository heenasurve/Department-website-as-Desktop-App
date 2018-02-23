using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_ISTAtRIT
{
    public partial class NewsPage : Form
    {
        string jsonNews;
        News news;
        public NewsPage()
        {
            InitializeComponent();
            jsonNews = getRestData("/news/");
            news = JToken.Parse(jsonNews).ToObject<News>();

        }
        #region getRestData - Returns the requested API information as a string
        private string getRestData(string uri)
        {
            string baseurl = "http://ist.rit.edu/api";
            //connect to API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseurl + uri);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responsestream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responsestream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }

            }
            catch (WebException webEx)
            {
                WebResponse error = webEx.Response;
                using (Stream responsestream = error.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responsestream, Encoding.UTF8);
                    string errorText = reader.ReadToEnd();
                    Console.WriteLine(errorText);
                }
                throw;
            }

        }
        #endregion

        private void News_Load(object sender, EventArgs e)
        {
            List<Quarter> news_for_quarter = news.quarter;
            newsRTB.Text = "";
            foreach (var news_item in news_for_quarter)
            {
                newsRTB.Text += "Date: " + news_item.date;
                newsRTB.Text += "\nTitle: " + news_item.title;
                if (news_item.description != "")
                {
                    newsRTB.Text += "\nDescription: " + news_item.description + "\n\n";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Quarter> news_for_quarter = news.quarter;
            newsRTB.Text = "";
            foreach (var news_item in news_for_quarter)
            {
                newsRTB.Text += "Date: " + news_item.date;
                newsRTB.Text += "\nTitle: " + news_item.title;
                if (news_item.description != "")
                {
                    newsRTB.Text += "\nDescription: " + news_item.description + "\n\n";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Year> news_for_year = news.year;
            newsRTB.Text = "";
            foreach (var news_item in news_for_year)
            {
                newsRTB.Text += "Date: " + news_item.date;
                newsRTB.Text += "\nTitle: " + news_item.title;
                if (news_item.description != "")
                {
                    newsRTB.Text += "\nDescription: " + news_item.description + "\n\n";
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Older> older_news = news.older;
            newsRTB.Text = "";
            foreach (var news_item in older_news)
            {
                newsRTB.Text += "Date: " + news_item.date;
                newsRTB.Text += "\nTitle: " + news_item.title;
                newsRTB.Text += "\nDescription: " + news_item.description + "\n\n";

            }
        }
    }

}
