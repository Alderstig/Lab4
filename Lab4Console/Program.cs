using System;
using System.IO;
using System.Linq;
using Lab4Library;

namespace Lab4Console
{
    class Program
    {
        public static string[] Lists { get; set; }
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Use any of the following parameters:");
                Console.WriteLine($"-lists");
                Console.WriteLine($"-new < listName > < language 1 > < language 2 > .. < langauge n > ");
                Console.WriteLine($"-add < listName > ");
                Console.WriteLine($"-remove < listName > < language > < word 1 > < word 2 > .. < word n > ");
                Console.WriteLine($"-words < listname > < sortByLanguage > ");
                Console.WriteLine($"-count < listName > ");
                Console.WriteLine($"-practice < listName > ");
            }
            else
            {
                foreach (var arg in args)
                {
                    arg.ToLower();
                }

                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Lab4");
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                string s = args[0];

                switch (s)
                {
                    case "-lists":
                        Lists = Wordlist.GetLists();

                        if (Lists.Length == 0)
                        {
                            Console.WriteLine("No lists have been added");
                        }
                        else
                        {
                            foreach (string list in Lists)
                            {
                                Console.WriteLine(list);
                            }
                        }

                        break;

                    case "-new":
                        string message = "A list must contain a name and at least two languages";

                        if (args.Length <= 3)
                        {
                            Console.WriteLine(message);

                            break;
                        }
                        else
                        {
                            Wordlist newList = new Wordlist(args[1], paramsArrNew(args));
                            newList.Save();

                            goto case "-add";
                        }

                    case "-add":
                        Lists = Wordlist.GetLists();

                        if (Lists.Length == 0)
                        {
                            Console.WriteLine("No lists have been added");
                        }
                        else if (!Lists.Contains(args[1]))
                        {
                            Console.WriteLine($"No list with listname '{args[1]}' could be found");
                        }
                        else
                        {
                            Wordlist addtranslations = Wordlist.LoadList(args[1]);

                            int count = 0;
                            bool loop = true;

                            Console.WriteLine();
                            Console.WriteLine("Press enter (empty line) to stop input of words");
                            Console.WriteLine();

                            while (loop)
                            {
                                string[] translation = new string[addtranslations.Languages.Length];

                                Console.Write($"Add a new word in '{addtranslations.Languages[0]}': ");
                                string firstWord = Console.ReadLine();
                                if (string.IsNullOrEmpty(firstWord))
                                {
                                    loop = false;
                                }
                                else
                                {
                                    translation[0] += firstWord;

                                    for (int i = 1; i < addtranslations.Languages.Length; i++)
                                    {
                                        Console.Write($"Translate '{firstWord}' to '{addtranslations.Languages[i]}': ");
                                        string newWord = Console.ReadLine();
                                        if (string.IsNullOrEmpty(newWord))
                                        {
                                            loop = false;
                                        }
                                        else
                                        {
                                            translation[i] += newWord;
                                        }
                                    }

                                    addtranslations.Add(translation);
                                    translation = null;
                                }

                                count++;
                            }

                            Console.WriteLine();
                            Console.WriteLine($"{count} words was added to '{args[1]}'");
                            Console.WriteLine();

                            addtranslations.Save();
                        }

                        break;

                    case "-remove":
                        Lists = Wordlist.GetLists();

                        if (Lists.Length == 0)
                        {
                            Console.WriteLine("No lists have been added");
                        }
                        else if (args.Length < 4)
                        {
                            Console.WriteLine("The 'remove-command' requires a listname, a language and at least one word to remove");
                        }
                        else if (!Lists.Contains(args[1]))
                        {
                            Console.WriteLine($"No list with listname '{args[1]}' could be found");
                        }
                        else
                        {
                            Wordlist removeWord = Wordlist.LoadList(args[1]);

                            if (!removeWord.Languages.Contains(args[2]))
                            {
                                Console.WriteLine($"'{args[1]}' did not contain the language 'args[2]'");
                            }
                            else
                            {
                                int val = 0;
                                string[] words = paramsArrRemove(args);

                                foreach (string word in words)
                                {
                                    for (int i = 0; i < removeWord.Languages.Length; i++)
                                    {
                                        if (removeWord.Languages[i] == args[2]) val = i;
                                    }

                                    if (removeWord.Remove(val, word))
                                    {
                                        Console.WriteLine($"{word} has been removed");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{word} has not been removed because it didn't exist in given list");
                                    }

                                    removeWord.Save();
                                }
                            }
                        }

                        break;

                    case "-words":
                        Lists = Wordlist.GetLists();

                        if (Lists.Length == 0)
                        {
                            Console.WriteLine("No lists have been added");
                        }
                        else if (args.Length <= 1)
                        {
                            Console.WriteLine("The 'words-command' requires at least a listname");
                        }
                        else if (!Lists.Contains(args[1]))
                        {
                            Console.WriteLine($"No list with listname '{args[1]}' could be found");
                        }
                        else
                        {
                            Wordlist listWords = Wordlist.LoadList(args[1]);

                            Action<string[]> showTranslations = (translations) =>
                            {
                                foreach (string translation in translations)
                                {
                                    Console.Write($"{translation,-20}");
                                }

                                Console.WriteLine();
                            };

                            if (args.Length == 3 && listWords.Languages.Contains(args[2]))
                            {
                                foreach (string language in listWords.Languages)
                                {
                                    Console.Write($"{language,-20}");
                                }

                                Console.WriteLine();
                                int num = Array.IndexOf(listWords.Languages, args[2]);
                                listWords.List(num, showTranslations);
                            }
                            else if (args.Length == 2)
                            {
                                foreach (string language in listWords.Languages)
                                {
                                    Console.Write($"{language,-20}");
                                }

                                Console.WriteLine();
                                listWords.List(0, showTranslations);
                            }
                            else if (!listWords.Languages.Contains(args[2]))
                            {
                                Console.WriteLine($"'{listWords.Name}' doesn't contain any words in '{args[2]}'");
                            }
                        }

                        break;

                    case "-count":
                        Lists = Wordlist.GetLists();

                        if (Lists.Length == 0)
                        {
                            Console.WriteLine("No lists have been added");
                        }
                        else if (args.Length <= 1)
                        {
                            Console.WriteLine("The 'count-command' requires at least a listname");
                        }
                        else if (!Lists.Contains(args[1]))
                        {
                            Console.WriteLine($"No list with listname '{args[1]}' could be found");
                        }
                        else
                        {
                            Wordlist numOfWordsInLanguage = Wordlist.LoadList(args[1]);
                            Console.WriteLine($"The number of words in your list {args[1]} is :{numOfWordsInLanguage.Count()}");
                        }

                        break;

                    case "-practice":
                        Lists = Wordlist.GetLists();

                        if (Lists.Length == 0)
                        {
                            Console.WriteLine("No lists have been added");
                        }
                        else if (args.Length <= 1)
                        {
                            Console.WriteLine("The 'practice-command' requires at least a listname");
                        }
                        else if (!Lists.Contains(args[1]))
                        {
                            Console.WriteLine($"No list with listname '{args[1]}' could be found");
                        }
                        else
                        {
                            Wordlist practiceWords = Wordlist.LoadList(args[1]);

                            int correctAnswer = 0;
                            int wordsPracticed = 0;

                            while (true)
                            {
                                Word word = practiceWords.GetWordToPractice();
                                string[] strArr = word.Translations;
                                string input = "";

                                Console.WriteLine();
                                Console.Write($"Translate {word.Translations[word.FromLanguage]} to {practiceWords.Languages[word.ToLanguage]}: ");
                                input = Console.ReadLine().ToLower();

                                if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                                {
                                    break;
                                }

                                if (input == word.Translations[word.ToLanguage])
                                {
                                    Console.WriteLine("correct answer");
                                    correctAnswer++;
                                    wordsPracticed++;
                                }
                                else if (input != word.Translations[word.ToLanguage] && !string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
                                {
                                    Console.WriteLine("incorrect answer");
                                    wordsPracticed++;
                                }
                            }

                            Console.WriteLine("\nPractice has been ended");
                            Console.WriteLine($"\nYou practiced {wordsPracticed} words in total");
                            Console.WriteLine($"You got {correctAnswer} out of {wordsPracticed} correct answers");
                        }

                        break;

                    default:
                        Console.WriteLine("There was something wrong with your command");

                        break;
                }
            }
        }

        public static string[] paramsArrNew(string[] args)
        {
            string[] newString = new string[args.Length - 2];

            for (int i = 2; i < args.Length; i++)
            {
                newString[i - 2] += args[i];
            }

            return newString;
        }

        public static string[] paramsArrRemove(string[] args)
        {
            string[] newString = new string[args.Length - 3];

            for (int i = 3; i < args.Length; i++)
            {
                newString[i - 3] += args[i];
            }

            return newString;
        }
    }
}
