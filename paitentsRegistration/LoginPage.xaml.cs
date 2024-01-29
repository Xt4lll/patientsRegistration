using paitentsRegistration.patientRegDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class LoginPage : Page
    {
        authorization_dataTableAdapter authData = new authorization_dataTableAdapter();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var allData = authData.GetData().Rows;
            for (int i = 0; i < allData.Count; i++)
            {
                if (allData[i][1].ToString() == loginTbx.Text && allData[i][2].ToString() == passwordTbx.Password)
                {
                    string role = allData[i][3].ToString();
                    string login = allData[i][1].ToString();
                    var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    File.WriteAllText($"{desktop}\\role.txt", role);
                    File.WriteAllText($"{desktop}\\login.txt", login);
                    loginFrame.Content = new PatientsPage();
                    return;
                }
            }
            MessageBox.Show("ошибка: неверный логин или пароль");
        }
    }
}
