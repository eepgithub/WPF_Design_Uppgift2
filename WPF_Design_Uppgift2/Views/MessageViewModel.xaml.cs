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
    /// Interaction logic for MessageViewModel.xaml
    /// </summary>
    public partial class MessageViewModel : UserControl
    {
        public MessageViewModel()
        {
            InitializeComponent();
        }

        private void message1_Click(object sender, RoutedEventArgs e)
        {
            subject.Text = "Meddelandeämne här uppe";
            from.Text = "Jens Gustafsson";
            to.Text = "Emil Pettersson";
            body.Text = "Väldigt långt meddelande här mail mail ett långt mail här med mycket text. Väldigt långt meddelande här mail mail ett långt mail här med mycket text.";
        }

        private void message2_Click(object sender, RoutedEventArgs e)
        {
            subject.Text = "Ämnesrad";
            from.Text = "Christoffer Nyman";
            to.Text = "Emil Pettersson";
            body.Text = "Hej det här är ett mail. Hej det här är ett mail. Hej det här är ett mail. Hej det här är ett mail.";
        }

        private void message3_Click(object sender, RoutedEventArgs e)
        {
            subject.Text = "Ämne";
            from.Text = "Alexander Fransson";
            to.Text = "Emil Pettersson";
            body.Text = "Detta är ett testmail hejhej!";
        }
    }
}
