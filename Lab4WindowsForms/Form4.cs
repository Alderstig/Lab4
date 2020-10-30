using Lab4Library;
using System;
using System.Windows.Forms;

namespace Lab4WindowsForms
{
    public partial class FormAddWord : Form
    {
        public Wordlist Wordlist { get; set; }
        public FormAddWord()
        {
            InitializeComponent();
        }

        private void FormAddword_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (string language in Wordlist.Languages)
            {
                dataGridView1.Rows.Add(language);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] words = new string[dataGridView1.Rows.Count];
            int count = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                words[count] = (string)row.Cells[1].Value;

                count++;
            }

            Wordlist.Add(words);
            Wordlist.Save();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttoncCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
