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

namespace WPF_Design.Controls
{
    /// <summary>
    /// Interaction logic for MessageControl.xaml
    /// </summary>
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }


        public ImageSource MessageImage
        {
            get { return messageImage.Source; }
            set { messageImage.Source = value; }
        }

        public string MessageName
        {
            get { return messageName.Text; }
            set { messageName.Text = value; }
        }

        public string MessageDescription
        {
            get { return messageDescription.Text; }
            set { messageDescription.Text = value; }
        }

        public string MessageDate
        {
            get { return messageDate.Text; }
            set { messageDate.Text = value; }
        }

        public string MessageTime
        {
            get { return messageTime.Text; }
            set { messageTime.Text = value; }
        }





    }
}
