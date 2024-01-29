using paitentsRegistration.patientRegDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace paitentsRegistration
{
    public partial class UserRegPage : Page
    {
        authorization_dataTableAdapter authData = new authorization_dataTableAdapter();
        rolesTableAdapter roles = new rolesTableAdapter();
        public UserRegPage()
        {
            InitializeComponent();
            roleCb.ItemsSource = roles.GetData();
            roleCb.DisplayMemberPath = "роль";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object rl = (roleCb.SelectedItem as DataRowView).Row[0];
            if (roleCb.SelectedItem != null && loginTbx.Text != "" && passwordTbx.Text != "")
            {
                authData.InsertQuery(loginTbx.Text, passwordTbx.Text, (int)rl);
                UserRegFrame.Content = new PatientsPage();
            }
            else MessageBox.Show("неправильно заполнены поля");
        }
    }
}
