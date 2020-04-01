using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Projekt_1.Data;

namespace Projekt_1
{
    /// <summary>
    /// Logika interakcji dla klasy HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RssInfo rssInfo = new RssInfo();
            this.NavigationService.Navigate(rssInfo);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RssList rssList = new RssList();
            this.NavigationService.Navigate(rssList);
        }

        private void refresh(string nameChanel)
        {
            var chanellink = CRUD.LoadOneKanal(nameChanel).Select(x => x.link).ToString();
            List<XmlItems> xmlItemses = new List<XmlItems>();
            var title = Downloading.DownloadSpecificalyItems.DownloadSpecificaly(chanellink, "title");
            var link = Downloading.DownloadSpecificalyItems.DownloadSpecificaly(chanellink, "link");
            var description = Downloading.DownloadSpecificalyItems.DownloadSpecificaly(chanellink, "description");
            var guid = Downloading.DownloadSpecificalyItems.DownloadSpecificaly(chanellink, "guid");

            for (int j = 1; j < guid.Count(); j++)
            {
                XmlItems xml = new XmlItems(title[j], link[j], description[j], guid[j], Downloading.DownloadHtml.Downloadpage(link[j]));
                xmlItemses.Add(xml);
            }

            Kanaly chanelfilter = CRUD.LoadOneKanal(nameChanel).First();
            Kanaly uChanel = new Kanaly(chanelfilter._id,chanelfilter.Kanal,chanelfilter.link,xmlItemses);
            CRUD.UpdateToKanaly(uChanel,chanelfilter);
        }
    }
}