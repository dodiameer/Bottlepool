using System;
using System.Media;
using System.Windows;


namespace Bottlepool
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

        private void livButton_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Bottlepool);
            player.Play();
        }
    }
}
