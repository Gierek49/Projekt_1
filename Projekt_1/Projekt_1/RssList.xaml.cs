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
       
        
    }
}
