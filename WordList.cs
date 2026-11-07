using SplashKitSDK;
using System;
namespace VocabStoryBuilder{
    class WordList
    {
        private int _max;
        private int _min;
        private List<Word> _words;

        public int Max
        {
            get{return _max;}
            set{_max = value;}
        }

        public int Min
        {
            get{return _min;}
            set{_min = value;}
        }

        public Word this[int i]
        {
            get {return _words[i];}
        }

        public WordList(int max, int min)
        {
            _max = max;
            _min = min;
            _words = new List<Word>();
        }

        public void AddWord(Word words)
        {
            _words.Add(words);
        }

        public void RemoveWord()
        {
            _words.Clear();
        }

        public Word GenerateWord()
        {
            int randomNum = Random.Shared.Next(1, _words.Count());
            return _words[randomNum];
        }

        public Word GetWord(int i)
        {
            return _words[i];
        }
    }
}
