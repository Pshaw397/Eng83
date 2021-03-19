using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using RadioApp;
using System.Diagnostics;

namespace RadioWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Radio radioPlayer = new Radio();
        public MainWindow()
        {
            InitializeComponent();

            mediaElementCh1.Source = new Uri("http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1_mf_p", UriKind.RelativeOrAbsolute); // BBC Radio 1
            mediaElementCh2.Source = new Uri("http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio2_mf_p", UriKind.RelativeOrAbsolute); // BBC Radio 2
            mediaElementCh3.Source = new Uri("http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio3_mf_p", UriKind.RelativeOrAbsolute); // BBC Radio 3
            mediaElementCh4.Source = new Uri("http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio4_mf_p", UriKind.RelativeOrAbsolute); // BBC Radio 4

        }

        public class RadioControl
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn.Content.ToString() == "Channel 1")
            {
                radioPlayer.Channel = 1;
            }
            if (clickedBtn.Content.ToString() == "Play" & radioPlayer.On == true)
            {
                switch (radioPlayer.Channel)
                {
                    case 1:
                        {
                            mediaElementCh1.Play();
                            break;
                        }
                        // I NEED TO INPUT THE CASES FOR RADIO'S 2-4 AND PUT THE CHANNEL BUTTONS IN
                }
            }

        }

        private void radioOn_Checked(object sender, RoutedEventArgs e)
        {
            if (radioOn.IsChecked == true)
            {
                radioPlayer.TurnOn();
            }
        }

        private void radioOff_Checked(object sender, RoutedEventArgs e)
        {
            if (radioOff.IsChecked == true)
            {
                radioPlayer.TurnOff();
            }
        }
    }
}
