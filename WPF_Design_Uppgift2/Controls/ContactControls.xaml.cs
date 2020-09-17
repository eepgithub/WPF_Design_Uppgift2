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
using WPF_Design_Uppgift2.Models;
using WPF_Design_Uppgift2.Views;

namespace WPF_Design.Controls
{
    /// <summary>
    /// Interaction logic for ContactControls.xaml
    /// </summary>
    public partial class ContactControls : UserControl
    {
        public ContactControls()
        {
            InitializeComponent();
        }

        public ImageSource ContactImage
        {
            get { return contactImage.Source; }
            set { contactImage.Source = value; }
        }

        public string ContactName
        {
            get { return contactName.Text; }
            set { contactName.Text = value; }
        }


        public string ContactRole
        {
            get { return contactRole.Text; }
            set { contactRole.Text = value; }
        }

    }   
}
