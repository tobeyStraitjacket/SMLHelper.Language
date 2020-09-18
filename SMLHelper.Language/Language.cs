using SMLHelper.V2.Handlers;
using System.Collections.Generic;

namespace SMLHelper
{
    internal static class Language
    {
        public static string Get(string id) => global::Language.main.Get(id);
        public static void Set(string id, string value) => LanguageHandler.Main.SetLanguageLine(id, value);
        public static string Set(Dictionary<string, string> dictionary)
        {
            foreach (var entry in dictionary)
                Set(entry.Key, entry.Value);
        }
    }
}
