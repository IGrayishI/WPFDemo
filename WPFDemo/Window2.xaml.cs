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
using System.Windows.Shapes;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        string userChoice = "";
        public Window2()
        {
            InitializeComponent();
        }

        private void OptionA_Click(object sender, RoutedEventArgs e)
        {
            userChoice = "A";
        }

        private void OptionB_Click(object sender, RoutedEventArgs e)
        {
            userChoice = "B";
        }

        private void OptionC_Click(object sender, RoutedEventArgs e)
        {
            userChoice = "C";
        }

        private void OptionD_Click(object sender, RoutedEventArgs e)
        {
            userChoice = "D";
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (userChoice != null)
            {
                switch (userChoice)
                {     
                    case "A":
                        break;
                    case "B":
                        break;
                    case "C":
                        break;
                    case "D":
                        break;

                }
            }
        }
    }
}
