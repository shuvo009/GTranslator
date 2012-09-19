using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace GTranslator
{
    public class ListOfLanguagesAndCode
    {
        public ObservableCollection<LanguagesAndCode> PhoneItemCollection { get; set; }

        public ListOfLanguagesAndCode()
        {
            PhoneItemCollection = new ObservableCollection<LanguagesAndCode>();
            PhoneItemCollection.Add(new LanguagesAndCode { language = "English", code = "en" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Afrikaans", code = "af" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Albanian", code = "sq" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Arabic", code = "ar" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Armenian", code = "hy" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Azerbaijani", code = "az" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Basque", code = "eu" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Belarusian", code = "be" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Bengali", code = "bn" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Bulgarian", code = "bg" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Catalan", code = "ca" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Chinese", code = "zh" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Croatian", code = "hr" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Czech", code = "cs" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Danish", code = "da" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Dutch", code = "nl" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Estonian", code = "et" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Filipino", code = "fil" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Finnish", code = "fi" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "French", code = "fr" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Galician", code = "gl" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Georgian", code = "ka" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "German", code = "de" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Greek", code = "el" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Gujarati", code = "gu" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Haitian", code = "ht" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Creole", code = "bi" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Hebrew", code = "he" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Hindi", code = "hi" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Hungarian", code = "hu" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Icelandic", code = "is" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Indonesian", code = "id" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Irish", code = "ga" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Italian", code = "it" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Japanese", code = "ja" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Kannada", code = "ka" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Korean", code = "ko" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Latin", code = "la" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Latvian", code = "lv" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Lithuanian", code = "It" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Macedonian", code = "mk" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Malay", code = "ms" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Maltese", code = "mt" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Norwegian", code = "no" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Norwegian", code = "nn" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Polish", code = "pl" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Portuguese", code = "pt" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Romanian", code = "ro" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Russian", code = "ru" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Serbian", code = "sr" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Slovak", code = "sk" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Slovenian", code = "sl" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Spanish", code = "es" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Swahili", code = "sw" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Swedish", code = "sv" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Tamil", code = "ta" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Telugu", code = "te" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Thai", code = "th" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Turkish", code = "tr" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Ukrainian", code = "uk" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Urdu", code = "ur" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Vietnamese", code = "vi" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Welsh", code = "la" });
            PhoneItemCollection.Add(new LanguagesAndCode { language = "Yiddish", code = "yi" });
        }

    }

    public class LanguagesAndCode
    {
        public string language { get; set; }
        public string code { get; set; }
    }
}
