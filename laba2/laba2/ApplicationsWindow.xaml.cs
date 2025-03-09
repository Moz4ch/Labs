using System.Windows;

namespace UniversityManagementSystem
{
    public partial class ApplicationsWindow : Window
    {
        public ApplicationsWindow()
        {
            InitializeComponent();
            LoadApplications();
        }

        private void LoadApplications()
        {
            ApplicationsListView.ItemsSource = ApplicationRepository.Applications;
        }

        private void ApproveButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedApplication = ApplicationsListView.SelectedItem as Application;
            if (selectedApplication != null)
            {
                selectedApplication.Status = "Approved";
                LoadApplications();
            }
        }

        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedApplication = ApplicationsListView.SelectedItem as Application;
            if (selectedApplication != null)
            {
                selectedApplication.Status = "Rejected";
                LoadApplications(); 
            }
        }
    }
}