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
    /// Interaction logic for admin_log.xaml
    /// </summary>
    public partial class admin_log : Page
    {
        fEntities1 cc = new fEntities1();

        public admin_log()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            adminn a = new adminn();
            a = cc.adminns.First(x => x.a_name == user.Text && x.a_password == password.Text);
            if (a.a_name == user.Text && a.a_password == password.Text )

            {
                adminnn ad = new adminnn();
                this.NavigationService.Navigate(ad);
            }
            else
            {
                MessageBox.Show("the input is fild");
            }
        }
    }
}
