using Mini_projekat_2___Entity_Framework_MVVM.Model;
using Mini_projekat_2___Entity_Framework_MVVM.ViewModel;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Mini_projekat_2___Entity_Framework_MVVM.View
{
    /// <summary>
    /// Interaction logic for AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        AddPageViewModel addPageViewModel = new AddPageViewModel();

        public AddPage()
        {
            InitializeComponent();
            CoursesListBox.ItemsSource = addPageViewModel.GetCourses();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var course = new List<Course>();
            foreach (Course item in CoursesListBox.SelectedItems)
            {
                course.Add(item);
            }

            var result = addPageViewModel.AddStudent(new Student
            {
                sFirstName = sFirstName.Text,
                sLastName = sLastName.Text,
                Address = new Address
                {
                    Address1 = Address1.Text,
                    City = City.Text,
                    Country = Country.Text
                },
            }, course);

            if (result != 0)
            {
                MessageBox.Show("Added Sucessfully.");
            }
            else
            {
                MessageBox.Show("Unable to add Record");
            }
        }
    }
}
