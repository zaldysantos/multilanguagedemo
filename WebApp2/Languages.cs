using System.Collections.Generic;

namespace WebApp2
{
    public class Languages
    {
        public static readonly Dictionary<string, string>
            Names = new Dictionary<string, string>()
            {
                { "en-US", "English (USA)" },
                { "ja-JP", "Japanese (日本)" },
                { "ar-SA", "Arabic (عربي)" },
            };

        public static readonly Dictionary<string, string>
            TextDirections = new Dictionary<string, string>()
            {
                { "en-US", "ltr" },
                { "ja-JP", "ltr" },
                { "ar-SA", "rtl" },
            };
    }
}
