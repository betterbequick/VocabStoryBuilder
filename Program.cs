using System;
using SplashKitSDK;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace VocabStoryBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            WordList MasterWord = new WordList(20, 5);
            WordList GeneratedWord = new WordList(3, 1);
            WordList SelectedWords = new WordList(3, 1);
            bool in_game = true;

            MasterWord.AddWord(new Verb("ran", "moved quickly on foot", TenseForm.Past));
            MasterWord.AddWord(new Verb("think", "to use your mind to form ideas", TenseForm.Present));
            MasterWord.AddWord(new Verb("swimming", "moving through water", TenseForm.Continuous));
            MasterWord.AddWord(new Verb("built", "constructed something", TenseForm.Past));
            MasterWord.AddWord(new Verb("whisper", "to speak very quietly", TenseForm.Present));

            MasterWord.AddWord(new Adjective("enormous", "extremely large", Description.Size));
            MasterWord.AddWord(new Adjective("ancient", "very old", Description.Age));
            MasterWord.AddWord(new Adjective("crimson", "deep red", Description.Color));
            MasterWord.AddWord(new Adjective("joyful", "feeling great happiness", Description.Feeling));

            MasterWord.AddWord(new Noun("teacher", "a person who helps others learn", false, true, Category.Person));
            MasterWord.AddWord(new Noun("forest", "a large area covered with trees", false, true, Category.Place));
            MasterWord.AddWord(new Noun("lantern", "a portable lamp with a protective case", false, true, Category.Thing));
            MasterWord.AddWord(new Noun("foxes", "wild animals with bushy tails", true, true, Category.Animal));
            MasterWord.AddWord(new Noun("water", "clear liquid that people drink", false, false, Category.Thing));
            
            while (in_game)
            {
                Console.WriteLine("Welcome to the Program!");
                Console.WriteLine("These are your options\n");

                Console.WriteLine("1. Create A Story");
                Console.WriteLine("2. View Words");
                Console.WriteLine("3. Quit");

                string? options = Console.ReadLine();

                if(options == "1")
                {
                    Console.WriteLine("Choose your words!");
                    for(int i = 0; i < 3; i++)
                    {
                        
                        Console.WriteLine("These are your words!");
                        for(int j = 0; j < 3; i++)
                        {
                            GeneratedWord.AddWord(MasterWord.GenerateWord());
                            Console.WriteLine($"{j}: {GeneratedWord.GetWord}");
                        }
                        string? selectWord = Console.ReadLine();;
                        if(selectWord == "1")
                        {
                            SelectedWords.AddWord(GeneratedWord[1]);
                        }
                        else if(selectWord == "2")
                        {
                            SelectedWords.AddWord(GeneratedWord[2]);
                        }
                        else if(selectWord == "3")
                        {
                            SelectedWords.AddWord(GeneratedWord[3]);
                        }

                        GeneratedWord.RemoveWord();
                    }
                }
                else if(options == "2")
                {
                    Console.WriteLine("Option 2");
                }
                else if(options == "3")
                {
                    in_game = false;
                }
            }
        }
    }
}
