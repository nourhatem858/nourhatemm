using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for sign_up.xaml
    /// </summary>
    public partial class sign_up : Page
    {
        userr i = new userr();
        fEntities1 cc = new fEntities1();


        public sign_up()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void com_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void user_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(pass.Text, @"^(?=.*[a-z]) (?=.*/d)(?=.*[!@#$%^&*()_].+$") && phone.Text.Length == 11 && age.Text.Length < 12 )
            {
                i.name = user.Text;

                i.u_password = pass.Text;


                i.phone = phone.Text;





                int c = int.Parse(age.Text);
                i.u_age = c;

            }
            if (com.SelectedIndex == 0)
            {
                userr i = new userr();
                i.gender = "f";
            }
            else
            {
                userr i = new userr();
                i.gender = "m";
            }
            if (city.SelectedIndex == 0)
            {
                i.city = "cario";
            }
            else if (city.SelectedIndex == 1)
            {
                i.city = "giza";

            }
            else if (city.SelectedIndex == 2)
            {
                i.city = "moifia";
            }
            else if (city.SelectedIndex == 3)
            {
                i.city = "mansora";
            }
            else
            {
                i.city = "6 october";
            }

            cc.userrs.Add(i);
            cc.SaveChanges();
            sign_in sign = new sign_in();
            this.NavigationService.Navigate(sign);

        }
    }
}
