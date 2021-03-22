using System;
using System.Media;
namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;
        private bool _on = false;

        public int Channel 
        {
            get { return _channel; }
            set 
            {
                if (_on == true & value > 0 & value < 5)
                {
                    _channel = value;
                }
                else if (_on == false)
                {
                    _channel = 1;
                }
            } 
        }
        public bool RadioPlaying { get; set; }

        public bool On { get { return _on; } }

        public string Play()
        {
            if (_on == true)
            {
                return $"Playing channel {Channel}";
            }
            else
            {
                return "Radio is off";
            }
        }

        public void TurnOff()
        {
            _on = false;
            RadioPlaying = false;
        }

        public void TurnOn()
        {
            _channel = 1;
            _on = true;
        }
    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}