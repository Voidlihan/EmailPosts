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
using System.Windows.Shapes;

namespace EmailWithFTP
{
    /// <summary>
    /// Interaction logic for PostList.xaml
    /// </summary>
    public partial class PostList : Window
    {
        public PostList()
        {
            InitializeComponent();
        }

        private void SendNewPost(object sender, RoutedEventArgs e)
        {
            SendPost sendPost = new SendPost();
            sendPost.ShowDialog();
        }
    }
}
