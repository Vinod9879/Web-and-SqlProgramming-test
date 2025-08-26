using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hacks
{
    public static class WordRepository
    {
        public static List<Word> Words = new List<Word>() { new Word { EnglishWord = "a", Translation = "first word" }, new Word { EnglishWord = "b", Translation = "second word" }, new Word { EnglishWord = "c", Translation = "third word" } };
        public class Word
        {
            public string EnglishWord { get; set; }
            public string Translation { get; set; }
        }

    }
}