using Lab4Library;
using System;
using System.Windows.Forms;

namespace Lab4WindowsForms
{
    public partial class FormNewList : Form
    {
        public FormNewList()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string listName = textBoxListName.Text.ToLower();

            string txt = textBoxLanguages.Text;
            string[] languages = txt.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            Wordlist newList = new Wordlist(listName, languages);
            newList.Save();

            Close();
        }
    }
}
