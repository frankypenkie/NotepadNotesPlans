using System;
using System.Drawing;
using System.Windows.Forms;

namespace notebook
{
    public partial class createNewPoint : Form
    {
        string generalFontName = "";
        string generalFontSize = "";
        string textsFontName = "";
        string textsFontSize = "";

        public createNewPoint(string generalFontName, string generalFontSize, string textsFontName, string textsFontSize)
        {
            this.generalFontName = generalFontName;
            this.generalFontSize = generalFontSize;
            this.textsFontName = textsFontName;
            this.textsFontSize = textsFontSize;

            InitializeComponent();
        }

        private void createNewPoint_Load(object sender, EventArgs e)
        {
            namePointBox.Font = new Font(generalFontName, (float)Convert.ToDouble(generalFontSize), GraphicsUnit.Pixel);
            savePointButton.Font = new Font(generalFontName, (float)Convert.ToDouble(generalFontSize), GraphicsUnit.Pixel);
            textNamePoint.Font = new Font(textsFontName, (float)Convert.ToDouble(textsFontSize), GraphicsUnit.Pixel);
            textNamePoint.Select();
        }

        private void savePointButton_Click(object sender, EventArgs e)
        {
            noteBookForm notebookFormOwner = this.Owner as noteBookForm;
            ListBox listBoxPointsOwner = (notebookFormOwner.Controls["mainTabs"].
                    Controls["plans"].
                    Controls["splitContainerPlans"].
                    Controls[0].
                    Controls["pointsPlanBox"].
                    Controls["listBoxPoints"] as ListBox);

            if (textNamePoint.Text == "" || textNamePoint.Text.Contains("{splitSymbol}"))
                MessageBox.Show("Некорректно введено название!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                listBoxPointsOwner.Items.Add(textNamePoint.Text);
                listBoxPointsOwner.SelectedIndex = listBoxPointsOwner.Items.Count - 1;
            }
        }

        private void textNamePoint_TextChanged(object sender, EventArgs e)
        {
            if (textNamePoint.Text.Contains("'") || textNamePoint.Text.Contains("\"") || textNamePoint.Text.Contains("-") || textNamePoint.Text.Contains("/"))
            {
                MessageBox.Show("Текст не должен содержать следующих символов:" +
                    " апостроф, тире, кавычки, слеш", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNamePoint.Text = textNamePoint.Text.Replace("'", "");
                textNamePoint.Text = textNamePoint.Text.Replace("\"", "");
                textNamePoint.Text = textNamePoint.Text.Replace("-", "");
                textNamePoint.Text = textNamePoint.Text.Replace("/", "");
            }
        }
    }
}
