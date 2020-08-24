using System;

namespace AlemdarLabs.Spotify.Extensions
{
    public static class IntegerExtensions
    {
        public static string SecondsToTime(this int value)
        {
            if (value is int intValue)
            {
                var seconds = TimeSpan.FromSeconds(intValue);

                return $"{seconds:mm\\:ss}";
            }

            return string.Empty;
        }
    }
}
