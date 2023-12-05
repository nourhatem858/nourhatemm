using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forgett.xaml
    /// </summary>
    public partial class forgett : Page
    {
        fEntities1 cc = new fEntities1();

        public forgett()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr u = new userr();
            u = cc.userrs.First(x => x.phone == phone.Text);
            if (pass.Text==confirm.Text)
            {
                u.u_password = pass.Text;

            }
            else
            {
                MessageBox.Show("wrong in input");
            }
            cc.userrs.AddOrUpdate(u);
            cc.SaveChanges();
            sign_in s = new sign_in();
            this.NavigationService.Navigate(s);
        }
    }
}
