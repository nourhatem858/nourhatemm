using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Page
    {
        fEntities1 cc = new fEntities1();

        public search()
        {
            InitializeComponent();
            dg.ItemsSource = cc.userrs.ToList();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            userr u = new userr();
            u = cc.userrs.First(x => x.city == city.Text);
            dg.ItemsSource = cc.userrs.Where(x => x.city == city.Text).Select(x => new {u.phone,u.u_id,u.u_age,u.city,u.name}).ToList();

        }
    }
}
