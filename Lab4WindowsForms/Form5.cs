using Lab4Library;
using System;
using System.Windows.Forms;

namespace Lab4WindowsForms
{
    public partial class Form5 : Form
    {
        public Wordlist ListToPractice { get; set; }
        private Word word;
        private int correct = 0;
        private int wordsPracticed = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonEndPractice_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                NewWord();
            }
        }

        private void NewWord()
        {
            string input = textBoxInput.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show($"You have to submit a translation in the textbox");
            }
            else if (input == word.Translations[word.ToLanguage])
            {
                correct++;
                wordsPracticed++;
            }
            else if (input != word.Translations[word.ToLanguage])
            {
                MessageBox.Show($"The correct answer was {word.Translations[word.ToLanguage]}");
                wordsPracticed++;
            }

            labelResult.Text = $"{correct} out of {wordsPracticed} correct";
        }

        private void GetWordAndUpdateLable()
        {
            word = ListToPractice.GetWordToPractice();
            labelTranslations.Text = $"Translate '{word.Translations[word.FromLanguage]}' to {ListToPractice.Languages[word.ToLanguage]}";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            GetWordAndUpdateLable();
        }

        private void labelResult_TextChanged(object sender, EventArgs e)
        {
            GetWordAndUpdateLable();
            textBoxInput.Text = "";
        }
    }
}
