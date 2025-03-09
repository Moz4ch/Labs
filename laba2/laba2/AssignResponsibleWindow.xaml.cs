using System.Windows;

namespace UniversityManagementSystem
{
    public partial class AssignResponsibleWindow : Window
    {
        public AssignResponsibleWindow()
        {
            InitializeComponent();
            ApplicationsComboBox.ItemsSource = ApplicationRepository.Applications;
        }

        private void AssignButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedApplication = ApplicationsComboBox.SelectedItem as Application;
            if (selectedApplication != null && !string.IsNullOrWhiteSpace(ResponsibleTextBox.Text))
            {
                selectedApplication.ResponsiblePerson = ResponsibleTextBox.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите заявку и укажите ответственное лицо");
            }
        }
    }
}