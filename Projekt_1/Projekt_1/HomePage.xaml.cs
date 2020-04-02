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
using static Projekt_1.RssList;

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

       

        
    }
}