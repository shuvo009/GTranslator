using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Threading;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;

namespace GTranslator
{
    public partial class MainPage : PhoneApplicationPage
    {

        DispatcherTimer waitTimer = new DispatcherTimer();
        TimeSpan waitTiameSpan = new TimeSpan(0, 1,0);
        string html = null;
        const string appName = "GTranslate";
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            waitTimer.Tick += new EventHandler(waitTimer_Tick);
             waitTimer.Interval = new TimeSpan(0, 0, 1);
          //  waitTimer.Start();
           
        }

        void waitTimer_Tick(object sender, EventArgs e)
        {
            if (!TimeSpan.Equals(waitTiameSpan,new TimeSpan(0,0,0)))
            {
                waitTiameSpan = waitTiameSpan.Add(new TimeSpan(0, 0, -1));
                this.textBlockWait.Text = string.Format("Wait : {0}", waitTiameSpan);
            }
            else
            {
                waitTimer.Stop();
            }
        }
        private void ButtonTranslate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                if (this.ListBoxFrom.SelectedItems.Count > 0 && this.ListBoxTo.SelectedItems.Count > 0)
                {
                    if (!String.IsNullOrWhiteSpace(this.TextBoxFrom.Text) && !String.IsNullOrEmpty(this.TextBoxFrom.Text))
                    {
                        this.ButtonTranslate.IsEnabled = false;
                        this.TranslateGoogle(this.TextBoxFrom.Text, (ListBoxFrom.SelectedItem as LanguagesAndCode).code, (ListBoxTo.SelectedItem as LanguagesAndCode).code);
                    }
                    else
                    {
                        MessageBox.Show("Please enter some text.", appName, MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Please select Languages.", appName, MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Internet connection error !", appName, MessageBoxButton.OK);
            }
        }

        private void TextBoxFrom_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
        	// TODO: Add event handler implementation here.
        }

        public void TranslateGoogle(string text, string fromCulture, string toCulture)
        {
            fromCulture = fromCulture.ToLower();
            toCulture = toCulture.ToLower();
            string url = string.Format(@"http://translate.google.com/translate_a/t?client=j&text={0}&hl=en&sl={1}&tl={2}", HttpUtility.UrlEncode(text), fromCulture, toCulture);
            try
            {
                WebClient web = new WebClient();
                web.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0";
                web.Headers[HttpRequestHeader.AcceptCharset] = "UTF-8";
                web.Encoding = Encoding.UTF8;
                web.DownloadStringCompleted += new System.Net.DownloadStringCompletedEventHandler(web_DownloadStringCompleted);
                web.DownloadStringAsync(new Uri(url));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, appName, MessageBoxButton.OK);
            }
        }

        private void web_DownloadStringCompleted(object sender, System.Net.DownloadStringCompletedEventArgs e)
        {
            try
            {
                html = e.Result;
                if (html != null)
                {
                    string result = Regex.Match(html, "trans\":(\".*?\"),\"", RegexOptions.IgnoreCase).Groups[1].Value;
                    if (string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Unable to Translate.", appName, MessageBoxButton.OK);
                    }
                    TextBoxTo.Text = result.Substring(1, result.LastIndexOf('"') - 1);
                }
                else
                {
                    MessageBox.Show("Unable to Translate.", appName, MessageBoxButton.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, appName, MessageBoxButton.OK);
            }
            finally
            {
                this.ButtonTranslate.IsEnabled = true;
            }
        }
    }
}