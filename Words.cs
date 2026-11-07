using SplashKitSDK;
using System;
namespace VocabStoryBuilder{
    public enum TenseForm
    {
        Past,
        Present,
        Continuous
    }
    public enum Description
    {
        Size,
        Feeling,
        Age,
        Color,
    }
    public enum Category
    {
        Person,
        Place,
        Thing, 
        Animal
    }
        

    public abstract class Word
    {
        private string _letters;
        private string _meaning;

        public Word(string letters, string meaning)
        {
            _letters = letters;
            _meaning = meaning;
        }

        public string LETTERS{
            get {return _letters;}
            set {_letters = value;}
        }

        public string MEANING{
            get {return _meaning;}
            set {_meaning = value;}
        }

        public abstract void displayWord();
    }

    public class Adjective : Word
    {

        private Description _description;

        public Adjective(string letters, string meaning, Description description) : base(letters, meaning)
        {
            _description = description;
        }

        public override void displayWord()
        {
            Console.WriteLine($"{LETTERS}: {MEANING}");
        }
    }

    public class Verb : Word
    {
        private TenseForm _tenseForm;

        public Verb(string letters, string meaning, TenseForm tenseForm) : base(letters, meaning)
        {
            _tenseForm = tenseForm;
        }
        public override void displayWord()
        {
            Console.WriteLine($"{LETTERS}: {MEANING}");
        }
    }

    public class Noun : Word
    {
        private bool _isPlural;
        private bool _isCountable;
        private Category _category;

        public Noun(string letters, string meaning, bool isPlural, bool isCOuntable, Category category) : base(letters, meaning)
        {
            _isPlural =isPlural;
            _isCountable = isCOuntable;
            _category = category;
        }

        public override void displayWord()
        {
            Console.WriteLine($"{LETTERS}: {MEANING}");
        }
    }
}
