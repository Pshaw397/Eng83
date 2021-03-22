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
        List<string> sourceList = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            sourceList.Add("http://stream.live.vc.bbcmedia.co.uk/bbc_radio_one");
            sourceList.Add("http://stream.live.vc.bbcmedia.co.uk/bbc_radio_two");
            sourceList.Add("http://stream.live.vc.bbcmedia.co.uk/bbc_radio_three");
            sourceList.Add(@"D:\Sparta training\C#\Week 2\Radio\Radio_Mini_Project\RadioApp\Music\bensound-sunny.mp3");
            //sourceList.Add("http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio4fm_mf_p");
        }

        public void radioDisplayText(string displayText) => RadioDisplay.Text = displayText;

        public void channelPlay()
        {
            if (radioPlayer.RadioPlaying == true)
            {
                radioDisplayText(radioPlayer.Play());
                mediaElementCh.Source = new Uri(sourceList[radioPlayer.Channel - 1]);
                mediaElementCh.Play();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn.Content.ToString() == "Channel 1" & radioPlayer.On == true)
            {
                radioPlayer.Channel = 1;
                channelPlay();
            }
            else if (clickedBtn.Content.ToString() == "Channel 2" & radioPlayer.On == true)
            {
                radioPlayer.Channel = 2;
                channelPlay();
            }
            else if (clickedBtn.Content.ToString() == "Channel 3" & radioPlayer.On == true)
            {
                radioPlayer.Channel = 3;
                channelPlay();
            }
            else if (clickedBtn.Content.ToString() == "Channel 4" & radioPlayer.On == true)
            {
                radioPlayer.Channel = 4;
                channelPlay();
            }

            if(radioPlayer.RadioPlaying == false & radioPlayer.On == true)
            {
                radioDisplayText($"Channel {radioPlayer.Channel} Selected - Press 'Play' To Start");
            }

            if (clickedBtn.Content.ToString() == "Play" & radioPlayer.On == true)
            {
                radioPlayer.RadioPlaying = true;
                channelPlay();
            }

        }

        private void radio_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioOption = (RadioButton)sender;
            if (radioOption.IsChecked == true & radioOption.Content.ToString() == "Radio On")
            {
                radioPlayer.TurnOn();
                radioDisplayText($"Channel {radioPlayer.Channel} Selected - Press 'Play' To Start");
            }
            else
            {
                radioPlayer.TurnOff();
                mediaElementCh.Stop();
                //radioDisplayText("radio off");
                foreach (var item in sourceList)
                {
                    radioDisplayText(radioPlayer.Play());
                }
            }
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider volSlider = (Slider)sender;
            mediaElementCh.Volume = volSlider.Value / 100;
        }
    }
}
