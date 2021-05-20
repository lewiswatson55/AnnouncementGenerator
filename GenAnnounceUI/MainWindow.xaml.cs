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
using GenAnnounce;

namespace GenAnnounceUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void twt_submit_click(object sender, RoutedEventArgs e)
        {
            GenAnnounce.Post newPost = new GenAnnounce.Post(twt_title.Text, twt_when.Text, twt_where.Text, twt_what.Text, twt_emoji.Text);
            //string messageToShow = $"Title: {newPost.Title}\nWhere: {newPost.Where}\nWhen: {newPost.When}\nWhat: {newPost.What}\nEmoji: {newPost.Emoji}";
            //MessageBox.Show(messageToShow, "Post Information");
            twt_out.Text = newPost.GenerateTwt();
        }

        private void twt_clear_click(object sender, RoutedEventArgs e)
        {

            twt_out.Text = "";
            //MessageBox.Show($"Output field has been cleared.", "Clear");

        }
    }
}
