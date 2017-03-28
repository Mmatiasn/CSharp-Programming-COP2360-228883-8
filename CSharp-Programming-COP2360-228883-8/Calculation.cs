namespace CSharp_Programming_COP2360_228883_8
{
    internal static class Calculation
    {
        private static double _speed = -1;
        private static double _time = -1;
        private static string _speedMessage { get; set; }
        private static string _timeMessage { get; set; }
        private static string _traveledMessage { get; set; }
        public static string SpeedTextChanged(string text)
        {
            double value;
            _speed = -1;
            _speedMessage = string.Empty;
            if (double.TryParse(text, out value))
                if (value >= 0)
                    _speed = value;
                else
                    _speedMessage = "Please enter a positive numeric value";
            else
                if (text != string.Empty)
                    _speedMessage = "Please enter a numeric value";                    
            return ReturnMessage(_speedMessage, _timeMessage);
        }

        public static string TimeTextChanged(string text)
        {
            double value;
            _time = -1;
            _timeMessage = string.Empty;
            if (double.TryParse(text, out value))
                if (value >= 0)
                    _time = value;
                else
                    _timeMessage = "Please enter a positive numeric value";
            else
                if (text != string.Empty)
                    _timeMessage = "Please enter a numeric value";
            return ReturnMessage(_timeMessage, _speedMessage);

        }

        private static string ReturnMessage(string current, string other)
        {
            if (_time >= 0 && _speed >= 0 && current == string.Empty && other == string.Empty)
                return string.Concat($"Traveled: {_time * _speed} Miles");
            if (current != string.Empty)
                return current;
            if (other != string.Empty)
                return other;
            else
                return string.Empty;
        }
    }
}
