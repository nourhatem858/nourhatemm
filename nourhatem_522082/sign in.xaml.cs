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
    /// Interaction logic for sign_in.xaml
    /// </summary>
    public partial class sign_in : Page
    {
        fEntities1 cc = new fEntities1();
        public sign_in()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            userr u = new userr();
            u = cc.userrs.First(x=> x.name==user.Text&&x.u_password==password.Text);
            if (u.name == user.Text && u.u_password == password.Text && u.phone == phone.Text)

            {
                profile p = new profile();
                this.NavigationService.Navigate(p);
            }
            else
            {
                MessageBox.Show("the input is fild");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            forgett f = new forgett();
            this.NavigationService.Navigate(f);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sign_up ss = new sign_up();
            this.NavigationService.Navigate(ss);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            admin_log a = new admin_log();
            this .NavigationService.Navigate(a);
        }
    }
}
