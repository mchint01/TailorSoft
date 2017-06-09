using System;

namespace TailorSoft.Business
{
    public static class TimeHelper
    {
        private static readonly TimeZoneInfo IndiaZone =
            TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

        public static DateTime GetCurrentDateTime()
        {
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, IndiaZone);
        }
    }
}
