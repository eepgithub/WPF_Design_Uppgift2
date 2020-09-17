using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Design_Uppgift2.Views
{
    /// <summary>
    /// Interaction logic for ContactViewModel.xaml
    /// </summary>
    public partial class ContactViewModel : UserControl
    {
        public ContactViewModel()
        {
            InitializeComponent();
        }

        private void Contact1_Click(object sender, RoutedEventArgs e)
        {
            contactName.Text = "Jens Gustafsson";
            email.Text = "Jensgustafsson@email.com";
            number.Text = "123456789";
        }

        private void Contact2_Click(object sender, RoutedEventArgs e)
        {
            contactName.Text = "Isak Pettersson";
            email.Text = "emailadress.com";
            number.Text = "987654321";
        }

        private void Contact3_Click(object sender, RoutedEventArgs e)
        {
            contactName.Text = "Rasmus Lauritsen";
                email.Text = "email@.com";
            number.Text = "123213213213";
        }

        private void Contact4_Click(object sender, RoutedEventArgs e)
        {
            contactName.Text = "Linus Wahlqvist";
            email.Text = "epostadress@mail.com";
            number.Text = "9999999999999";
        }
    }
}
