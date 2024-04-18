using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDanceMAUI.Helper
{
    public class EmojiHelper
    {
        public EmojiHelper() { }

        private static readonly Dictionary<string, string> WeatherStatusToEmojiMap = new Dictionary<string, string>
        {
            {"sunny", "☀️"},
            {"cloudy", "☁️"},
            {"windy", "🌧️"},
            {"rainy", "💨"},
            {"thunderstorm", "⛈️"}
        };

        public static string GetEmojiWeather(string status)
        {
            if (WeatherStatusToEmojiMap.ContainsKey(status))
            {
                return WeatherStatusToEmojiMap[status];
            }
            else
            {
                return "❓";
            }
        }
    }
}
