using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab4Library
{
    public class Wordlist
    {
        private List<Word> words;
        public static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Lab4");
        public string Name { get; }
        public string[] Languages { get; }

        public Wordlist(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
            words = new List<Word>();
        }

        public static string[] GetLists()
        {
            string[] listNames = Directory.GetFiles(path);
            string[] listNamesNoExtension = new string[listNames.Length];

            for (int i = 0; i < listNames.Length; i++)
            {
                listNamesNoExtension[i] += Path.GetFileNameWithoutExtension(listNames[i]);
            }

            return listNamesNoExtension;
        }

        public static Wordlist LoadList(string name)
        {
            string[] languages;

            string fileName = $@"{path}\{name}.dat";
            var fs = new FileStream(fileName, FileMode.Open);

            using (StreamReader reader = new StreamReader(fs))
            {
                languages = reader.ReadLine().TrimEnd(';').Split(';');
                Wordlist newList = new Wordlist(name, languages);

                while(!reader.EndOfStream)
                {
                    string[] translations = reader.ReadLine().TrimEnd(';').Split(';');
                    newList.Add(translations);
                }

                return newList;
            }
        }

        public void Save()
        {
            string fileName = $@"{path}\{Name}.dat";
            var fs = new FileStream(fileName, FileMode.Create);

            using(StreamWriter writer = new StreamWriter(fs))
            {
                foreach (string language in Languages)
                {
                    writer.Write($"{language};");
                }

                foreach (Word word in words)
                {
                    writer.WriteLine();

                    foreach (string translation in word.Translations)
                    {
                        writer.Write($"{translation};");
                    }
                }
            }
        }

        public void Add(params string[] translations)
        {
            if(translations.Length != Languages.Length)
            {
                throw new ArgumentException("You didn't submit correct number of translations");
            }
            else
            {
                words.Add(new Word(translations));
            }
        }

        public bool Remove(int translation, string word)
        {
            bool result = false;

            foreach (Word wordObject in words)
            {
                if (wordObject.Translations[translation] == word)
                {
                    words.Remove(wordObject);

                    result = true;
                    break;
                }
            }

            return result;
        }

        public int Count()
        {
            int numOfWords = words.Count();

            return numOfWords;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            List<Word> sortedListOfWords = words.OrderBy(word => word.Translations[sortByTranslation]).ToList();

            foreach (Word word in sortedListOfWords)
            {
                showTranslations(word.Translations);
            }
        }
        
        public Word GetWordToPractice()
        {
            int num1 = RandomNumber();
            int num2 = RandomNumber();
            bool loop = false;

            while (!loop)
            {
                if (num1 == num2)
                {
                    num2 = RandomNumber();
                }
                else
                {
                    loop = true;
                }
            }

            Word word = new Word(num1, num2, words[RandomTranslation()].Translations);

            return word;
        }

        public int RandomNumber()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, (Languages.Length));

            return random;
        }

        public int RandomTranslation()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, (words.Count));

            return random;
        }
    }
}
