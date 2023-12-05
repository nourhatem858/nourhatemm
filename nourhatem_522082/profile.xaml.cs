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
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        fEntities1 cc = new fEntities1();

        public profile()
        {
            InitializeComponent();
            sign_in s = new sign_in();
            userr u = new userr();
            dp.ItemsSource = cc.userrs.Where(x => x.phone == s.phone.Text).Select(x => new { u.name, u.u_id, u.u_age, u.city }).ToList();

        }

        private void dp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
                //u.u_password == s.pass.Text && u.name==s.user.Text&&u.phone==s.phone.Text&&u.u_age==f && u.city ==s.city.Text )
            //{
            //    string x = u.u_password;
            //    pass.Password = x;

            //    string c = u.name;
            //    user.Text= c;

            //    string v = u.phone;
            //    phone.Text = v;

            //    string b = u.city;
            //    city.Text = b;

            //    string m = u.gender;
            //    gender.Text = m;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sign_in s = new sign_in();
            this.NavigationService.Navigate(s);
        }

        private void user_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dp_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
