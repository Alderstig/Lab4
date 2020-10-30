using Lab4Library;
using System;
using System.Windows.Forms;

namespace Lab4WindowsForms
{
    public partial class Form2 : Form
    {
        public Wordlist ShowLanguages { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void listBox_WordLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox langaugeBox = listBoxLanguages;

            if (listBoxWordLists.SelectedItem != null)
            {
                string SelectedItem = listBoxWordLists.SelectedItem.ToString();
                ShowLanguages = Wordlist.LoadList(SelectedItem);

                langaugeBox.Items.Clear();

                foreach (var language in ShowLanguages.Languages)
                {
                    langaugeBox.Items.Add(language);
                }

                labelwordCount.Text = ShowLanguages.Count().ToString();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonNewList_Click(object sender, EventArgs e)
        {
            FormNewList createNeWList = new FormNewList();
            createNeWList.ShowDialog();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            ListBox wordsListBox = listBoxWordLists;
            labelwordCount.Text = "0";
            wordsListBox.Items.Clear();

            string[] lists = Wordlist.GetLists();

            if (lists.Length == 0)
            {
                listBoxWordLists.Items.Add("No lists have been added");
            }
            else
            {
                foreach (string list in lists)
                {
                    wordsListBox.Items.Add(list);
                }
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
