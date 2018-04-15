using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wtow.Domain;

namespace Wtow.Grabber.Infrastructure
{
    public static class ConvertExtensions
    {
        public static TitleType ToTitleType(this string type)
        {
            switch (type.ToLower())
            {
                case "movie":
                case "feature":
                    return TitleType.Feature;
                case "episode":
                    return TitleType.Episode;
                case "season":
                    return TitleType.Season;
                case "series":
                    return TitleType.Series;
                case "short":
                    return TitleType.Short;
            }

            return TitleType.Other;
        }

        public static DateTime? ToDateTime(this string value)
        {
            DateTime output;
            if (DateTime.TryParse(value, out output))
                return output;

            return null;
        }

        public static float ToFloat(this string value)
        {
            float output;
            if (float.TryParse(value, out output))
                return output;

            return 0;
        }
    }
}
