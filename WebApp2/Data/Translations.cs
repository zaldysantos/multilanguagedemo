using System.Linq;

namespace WebApp2.Data
{
    public class Translations
    {
        private static readonly Models.Translation[] TranslationsData = new[]
        {
            new Models.Translation()
            {
                Text = "how_was_blazor",
                Language = "en-US",
                TranslatesTo = "How is Blazor working for you?"
            },
            new Models.Translation()
            {
                Text = "click_me",
                Language = "en-US",
                TranslatesTo = "Click me"
            },
            new Models.Translation()
            {
                Text = "temp_c",
                Language = "en-US",
                TranslatesTo = "Temp. (C)"
            },
            new Models.Translation()
            {
                Text = "temp_f",
                Language = "en-US",
                TranslatesTo = "Temp. (F)"
            },

            new Models.Translation() 
            { 
                Text = "Hello, world!", 
                Language = "ja-JP", 
                TranslatesTo = "こんにちは世界！" 
            },
            new Models.Translation() 
            { 
                Text = "Welcome to your new app.", 
                Language = "ja-JP", 
                TranslatesTo = "新しいアプリへようこそ。" 
            },
            new Models.Translation()
            {
                Text = "how_was_blazor",
                Language = "ja-JP",
                TranslatesTo = "ブレイザーはどうですか？"
            },
            new Models.Translation() 
            { 
                Text = "Home",
                Language = "ja-JP", 
                TranslatesTo = "ホーム" 
            },
            new Models.Translation()
            { 
                Text = "Counter", 
                Language = "ja-JP",
                TranslatesTo = "カウンター" 
            },
            new Models.Translation()
            { 
                Text = "Fetch data", 
                Language = "ja-JP",
                TranslatesTo = "データを取得する" 
            },
            new Models.Translation()
            {
                Text = "Current count",
                Language = "ja-JP",
                TranslatesTo = "現在のカウント"
            },
            new Models.Translation()
            {
                Text = "click_me",
                Language = "ja-JP",
                TranslatesTo = "私をクリック"
            },
            new Models.Translation()
            {
                Text = "Weather forecast",
                Language = "ja-JP",
                TranslatesTo = "天気予報"
            },
            new Models.Translation()
            {
                Text = "Date",
                Language = "ja-JP",
                TranslatesTo = "日"
            },
            new Models.Translation()
            {
                Text = "temp_c",
                Language = "ja-JP",
                TranslatesTo = "温度 (C)"
            },
            new Models.Translation()
            {
                Text = "temp_f",
                Language = "ja-JP",
                TranslatesTo = "温度 (F)"
            },
            new Models.Translation()
            {
                Text = "Summary",
                Language = "ja-JP",
                TranslatesTo = "まとめ"
            },

            new Models.Translation()
            {
                Text = "Hello, world!",
                Language = "ar-SA",
                TranslatesTo = "مرحبا بالعالم!"
            },
            new Models.Translation()
            {
                Text = "Welcome to your new app.",
                Language = "ar-SA",
                TranslatesTo = "مرحبًا بك في تطبيقك الجديد."
            },
            new Models.Translation()
            {
                Text = "how_was_blazor",
                Language = "ar-SA",
                TranslatesTo = "كيف حال بليزر؟"
            },
            new Models.Translation()
            {
                Text = "Home",
                Language = "ar-SA",
                TranslatesTo = "الصفحة الرئيسية"
            },
            new Models.Translation()
            {
                Text = "Counter",
                Language = "ar-SA",
                TranslatesTo = "يعداد"
            },
            new Models.Translation()
            {
                Text = "Fetch data",
                Language = "ar-SA",
                TranslatesTo = "ابحث عن المعلومة"
            },
            new Models.Translation()
            {
                Text = "Current count",
                Language = "ar-SA",
                TranslatesTo = "العد الحالي"
            },
            new Models.Translation()
            {
                Text = "click_me",
                Language = "ar-SA",
                TranslatesTo = "انقر فوق لي"
            },
            new Models.Translation()
            {
                Text = "Weather forecast",
                Language = "ar-SA",
                TranslatesTo = "النشرة الجوية"
            },
            new Models.Translation()
            {
                Text = "Date",
                Language = "ar-SA",
                TranslatesTo = "تاريخ"
            },
            new Models.Translation()
            {
                Text = "temp_c",
                Language = "ar-SA",
                TranslatesTo = "درجة الحرارة (C)"
            },
            new Models.Translation()
            {
                Text = "temp_f",
                Language = "ar-SA",
                TranslatesTo = "درجة الحرارة (F)"
            },
            new Models.Translation()
            {
                Text = "Summary",
                Language = "ar-SA",
                TranslatesTo = "ملخص"
            },
        };

        public static string Translate(string text, string language)
        {
            if (string.IsNullOrWhiteSpace(language)) return text;
            var translation = TranslationsData.AsEnumerable()
                .Where(t => t.Text.Trim().ToUpper().Equals(text.Trim().ToUpper()) 
                    && t.Language.Trim().ToLower().Equals(language.Trim().ToLower()))
                .FirstOrDefault();
            return translation == null ? text : translation.TranslatesTo;
        }
    }
}
