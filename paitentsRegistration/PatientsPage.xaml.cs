using paitentsRegistration.patientRegDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class PatientsPage : Page
    {
        patientsTableAdapter patients = new patientsTableAdapter();
        diagnosisTableAdapter diagnosis = new diagnosisTableAdapter();
        wardTableAdapter ward = new wardTableAdapter();
        authorization_dataTableAdapter auth = new authorization_dataTableAdapter();
        patient_authorizationTableAdapter patient_Authorization = new patient_authorizationTableAdapter();
        public PatientsPage()
        {
            InitializeComponent();
            patientsGrid.ItemsSource = patients.GetData();
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string role = File.ReadAllText($"{desktop}\\role.txt");
            roleTb.Text = $"Роль: {role}";
            string login = File.ReadAllText($"{desktop}\\login.txt");
            var authData = auth.GetData().Rows;
            var patientData = patient_Authorization.GetData().Rows;
            var patientsRows = patients.GetData().Rows;
            for (int i = 0; i < authData.Count; i++)
            {
                if (authData[i][1].ToString() == login)
                {
                    role = authData[i][3].ToString();
                    int id = Convert.ToInt32(authData[i][0]);
                    if (role == "Пользователь")
                    {
                        for (int j = 0; j < patientData.Count; j++)
                        {
                            if (Convert.ToInt32(patientData[j][1]) == id)
                            {
                                id = Convert.ToInt32(patientData[j][0]);
                                patientsGrid.ItemsSource = (System.Collections.IEnumerable)patientsRows[id];
                            }
                        }
                    }
                }
            }
            DiagnosisTbx.ItemsSource = diagnosis.GetData();
            DiagnosisTbx.DisplayMemberPath = "Диагноз";
            WardTbx.ItemsSource = ward.GetData();
            WardTbx.DisplayMemberPath = "Номер палаты";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string role = File.ReadAllText($"{desktop}\\role.txt");
            if (role != "Пользователь")
            {

                object dg = (DiagnosisTbx.SelectedItem as DataRowView)[0];
                object wd = (WardTbx.SelectedItem as DataRowView)[0];
                if (surnameTbx.Text != "" && nameTbx.Text != "" && BirthDateTbx.Text != "" && InsurancePolicyTbx.Text != ""
                    && MedBookTbx.Text != "" && ConditionTbx.Text != "" && DiagnosisTbx.Text != "" && WardTbx.Text != "")
                {
                    patients.InsertQuery(surnameTbx.Text, nameTbx.Text, MiddleNameTbx.Text, ConditionTbx.Text, Convert.ToInt32(MedBookTbx.Text),
                        BirthDateTbx.SelectedDate.ToString(), Convert.ToInt32(InsurancePolicyTbx.Text),
                        (int)dg, (int)wd);
                    patientsGrid.ItemsSource = patients.GetData();
                }
            }
            else MessageBox.Show("недостаточно прав для данного действия");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string role = File.ReadAllText($"{desktop}\\role.txt");
            if (role == "Администратор")
            {
                patientsFrame.Content = new UserRegPage();
            }
            else MessageBox.Show("недостаточно прав для данного действия");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string role = File.ReadAllText($"{desktop}\\role.txt");
            if (role != "Пользователь")
            {
                object dg = (DiagnosisTbx.SelectedItem as DataRowView)[0];
                object wd = (WardTbx.SelectedItem as DataRowView)[0];
                object id = (patientsGrid.SelectedItem as DataRowView)[0];
                if (surnameTbx.Text != "" && nameTbx.Text != "" && BirthDateTbx.Text != "" && InsurancePolicyTbx.Text != ""
                    && MedBookTbx.Text != "" && ConditionTbx.Text != "" && DiagnosisTbx.Text != "" && WardTbx.Text != "")
                {
                    patients.UpdateQuery(surnameTbx.Text, nameTbx.Text, MiddleNameTbx.Text, ConditionTbx.Text, Convert.ToInt32(MedBookTbx.Text),
                        BirthDateTbx.SelectedDate.ToString(), Convert.ToInt32(InsurancePolicyTbx.Text),
                        (int)dg, (int)wd, (int)id);
                    patientsGrid.ItemsSource = patients.GetData();
                }
            }
            else MessageBox.Show("недостаточно прав для данного действия");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string role = File.ReadAllText($"{desktop}\\role.txt");
            object id = (patientsGrid.SelectedItem as DataRowView)[0];
            if (role != "Пользователь")
            {
                patients.DeleteQuery((int)id);
                patientsGrid.ItemsSource = patients.GetData();
            }
            else MessageBox.Show("недостаточно прав для данного действия");
        }

        private void patientsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (patientsGrid.SelectedItem != null)
            {
                object surname = (patientsGrid.SelectedItem as DataRowView)[1];
                object name = (patientsGrid.SelectedItem as DataRowView)[2];
                object middleName = (patientsGrid.SelectedItem as DataRowView)[3];
                object condition = (patientsGrid.SelectedItem as DataRowView)[4];
                object medBook = (patientsGrid.SelectedItem as DataRowView)[5];
                object birthDate = (patientsGrid.SelectedItem as DataRowView)[6];
                object insurancePolicy = (patientsGrid.SelectedItem as DataRowView)[7];
                object diagnosis = (patientsGrid.SelectedItem as DataRowView)[8];
                object ward = (patientsGrid.SelectedItem as DataRowView)[9];

                surnameTbx.Text = surname.ToString();
                nameTbx.Text = name.ToString();
                MiddleNameTbx.Text = middleName.ToString();
                ConditionTbx.Text = condition.ToString();
                MedBookTbx.Text = medBook.ToString();
                BirthDateTbx.Text = birthDate.ToString();
                InsurancePolicyTbx.Text = insurancePolicy.ToString();
                DiagnosisTbx.Text = diagnosis.ToString();
                WardTbx.Text = ward.ToString();
            }
        }
    }
}
