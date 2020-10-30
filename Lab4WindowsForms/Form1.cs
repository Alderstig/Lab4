using Lab4Library;
using System;
using System.IO;
using System.Windows.Forms;

namespace Lab4WindowsForms
{
    public partial class Form1 : Form
    {
        public Wordlist ActiveList { get; set; }
        public Form1()
        {
            InitializeComponent();

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Lab4");
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setActiveWordListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form2 newform2 = new Form2())
            {
                if (newform2.ShowDialog() == DialogResult.OK)
                {
                    ActiveList = Wordlist.LoadList(newform2.ShowLanguages.Name);
                    dataGridView1.Columns.Clear();

                    foreach (string language in ActiveList.Languages)
                    {
                        dataGridView1.Columns.Add($"column{language}", language);
                    }

                    dataGridView1.Rows.Clear();
                    ActiveList.List(0, ShowTranslations());

                    buttonPractice.Enabled = true;
                    buttonaddWord.Enabled = true;
                }
            }
        }

        private void buttonPractice_Click(object sender, EventArgs e)
        {
            using (Form5 newForm5 = new Form5())
            {
                newForm5.ListToPractice = ActiveList;

                newForm5.ShowDialog();
            }
        }

        private void buttonaddWord_Click(object sender, EventArgs e)
        {
            using (FormAddWord newFormAddWord = new FormAddWord())
            {
                newFormAddWord.Wordlist = ActiveList;

                if (newFormAddWord.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();
                    ActiveList.List(0, ShowTranslations());
                }
            }
        }

        private Action<string[]> ShowTranslations()
        {
            int cellCount = 0;
            int rowCount = 0;

            Action<string[]> showTranslations = (translations) =>
            {
                dataGridView1.Rows.Add();

                foreach (string translation in translations)
                {
                    dataGridView1.Rows[rowCount].Cells[cellCount].Value = translation;

                    cellCount++;
                }

                rowCount++;
                cellCount = 0;
            };

            return showTranslations;
        }

        private void buttondeleteWord_Click(object sender, EventArgs e)
        {
            string selectedWord = dataGridView1.SelectedCells[0].Value.ToString();

            ActiveList.Remove(0, selectedWord);
            ActiveList.Save();

            dataGridView1.Rows.Clear();
            ActiveList.List(0, ShowTranslations());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttondeleteWord.Enabled = true;
        }
    }
}
