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

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            List<Person> listOfPersons = new List<Person>() { };
            Window2 win2 = new Window2();

        public MainWindow()
        {
            
            InitializeComponent();
            listOfPersons.Add(new Person("Fabian", "Hohenzollern")); 
            listOfPersons.Add(new Person("Konrad", "Von Saponatheim")); 
            listOfPersons.Add(new Person("Chu", "Li"));
            ComboBox.ItemsSource = listOfPersons;

            //this.Background = new SolidColorBrush(Color.Red);
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {FirstNameText.Text}");
            if (win2 != null)
            {
                win2 = new Window2();
                win2.Show();
            } else
            {
                win2.Show();
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
