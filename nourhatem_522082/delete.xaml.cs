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

namespace nourhatem_522082
{
    /// <summary>
    /// Interaction logic for delete.xaml
    /// </summary>
    public partial class delete : Page
    {
        fEntities1 cc = new fEntities1();

        public delete()
        {
            InitializeComponent();
            dg.ItemsSource = cc.userrs.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            userr u = new userr();
            u = cc.userrs.First(x => x.phone == phone.Text);
            u = cc.userrs.Remove(u);
        }
    }
}
