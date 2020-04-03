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
    /// Logika interakcji dla klasy RssList.xaml
    /// </summary>
    public partial class RssList : Page
    {

        public RssList()
        {
            InitializeComponent();
            GetData();
        }



        public void GetData()
        {

            var dr = CRUD.LoadKanaly().Select(x => x.Kanal).ToList();

            for (int i = 0; i < dr.Count(); i++)
            {
                peopleListBox.Items.Add(dr[i]);
            }


        }

        public static string SelectedItem()
        {
            var se = new RssList();
            var str = se.peopleListBox.SelectedItem.ToString();
            return str;
        }

        public void GetTiltle()
        {
            try
            {
                peopleListBox2.Items.Clear();
                var str = peopleListBox.SelectedItem.ToString();
                var dr = CRUD.LoadOneKanal(str).First();
                var ch = dr.item.Select(x => x.Title).ToList();
                for (int i = 0; i < ch.Count(); i++)
                {
                    peopleListBox2.Items.Add(ch[i]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Wybierz kanał do wyświetlenia");
            }
           
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            GetTiltle();
        }
        public void refresh()
        {
            try
            {
                string nameChanel = peopleListBox.SelectedItem.ToString();

                var chanellink = CRUD.LoadOneKanal(nameChanel).Select(x => x.link).First().ToString();
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
                Kanaly uChanel = new Kanaly(chanelfilter._id, chanelfilter.Kanal, chanelfilter.link, xmlItemses);
                CRUD.UpdateToKanaly(uChanel, chanelfilter);

            }
            catch (Exception e)
            {
                MessageBox.Show("Wybierz kanał do odświeżenia");
            }
         
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            refresh();
        }
        public void GetArticle()
        {
            try
            {
                var str = peopleListBox2.SelectedItem.ToString();
                var ch = CRUD.LoadArticle(peopleListBox.SelectedItem.ToString(), str);
                Articlelist articlelist = new Articlelist();
                articlelist.textBox.Text = ch;
               
                //ArticleViewModel articleView= new ArticleViewModel();
                //articleView.Text = ch;
                //(articlelist.textBox).GetBindingExpression().UpdateSource();
                this.NavigationService.Navigate(articlelist);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Wybierz artykuł");
            }

        }

        private void Buton_click1(object sender, RoutedEventArgs e)
        {
            GetArticle();

        }

    }

    class ArticleViewModel
    {
        public string Text { get; set; }

    }
}
