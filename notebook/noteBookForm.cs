using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace notebook
{
    public partial class noteBookForm : Form
    {
        static string aplicationPath = Application.StartupPath;
        string connectionString = @"Data Source=(localDB)\MSSQLLocalDB;AttachDbFilename=" + 
            aplicationPath + 
            "\\notebookDB.mdf;Integrated Security =True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader dataReader;

        //Список всех записей
        List<Entry> entryList = new List<Entry>();

        //Список всех заметок
        List<Entry> noteList = new List<Entry>();

        //Список всех планов
        List<Entry> planList = new List<Entry>();

        string printString = "";

        public noteBookForm()
        {
            InitializeComponent();
        }

        //Обновление списка записей из БД
        private void UpdateListEntries()
        {
            command = new SqlCommand("SELECT * FROM Entry", connection);
            dataReader = command.ExecuteReader();

            entryList.Clear();
            while (dataReader.Read())
            {
                entryList.Add(new Entry(dataReader[1].ToString(), dataReader[2].ToString(), dataReader[4].ToString(), Boolean.Parse(dataReader[3].ToString())));
            }

            dataReader.Close();
        }

        //Обновление списка заметок из списка записей
        private void UpdateListNotes()
        {
            noteList.Clear();
            UpdateListEntries();

            //Заполнение списка заметок из списка записей
            for (int i = 0; i < entryList.Count; i++)
            {
                if (!entryList[i].noteOrPlan)
                    noteList.Add(entryList[i]);
            }

            //Сортировка заметок соответственно выбранной опции
            if (sortListBoxNotesNameRBtn.Checked)
            {
                noteList = SortNameEntries(noteList);
            }
            else if (sortListBoxNotesDateRBtn.Checked)
            {
                noteList = SortDateEntries(noteList);
            }
        }

        //Обновление списка планов из списка записей
        private void UpdateListPlans()
        {
            planList.Clear();
            UpdateListEntries();

            //Заполнение списка планов из списка записей
            for (int i = 0; i < entryList.Count; i++)
            {
                if (entryList[i].noteOrPlan)
                    planList.Add(entryList[i]);
            }

            //Сортировка планов соответственно выбранной опции
            if (sortListBoxPlansNameRBtn.Checked)
            {
                planList = SortNameEntries(planList);
            }
            else if (sortListBoxPlansDateRBtn.Checked)
            {
                planList = SortDateEntries(planList);
            }
        }

        //Сортировка записей по имени
        private List<Entry> SortNameEntries(List<Entry> entriesList)
        {
            //Заполнение списка имен записей и его сортировка
            List<string> namesEntries = new List<string>();
            for (int i = 0; i < entriesList.Count; i++)
            {
                namesEntries.Add(entriesList[i].name);
            }
            namesEntries.Sort();

            //Заполнение списка записей соответственно отсортированному списку имен записей
            List<Entry> sortedEntriesList = new List<Entry>();
            int indexEntry = 0;
            for (int i = 0; i < namesEntries.Count; i++)
            {
                for (int j = 0; j < entriesList.Count; j++)
                {
                    if (namesEntries[i] == entriesList[j].name)
                    {
                        indexEntry = j;
                        break;
                    }
                }
                sortedEntriesList.Add(entriesList[indexEntry]);
            }

            return sortedEntriesList;
        }

        //Сортировка записей по дате
        private List<Entry> SortDateEntries(List<Entry> entriesList)
        {
            //Заполнение списков индексами записей с пустыми и непустыми датами
            List<int> indexesEmptyDateEntries = new List<int>();
            List<int> indexesNotEmptyDateEntries = new List<int>();
            for (int i = 0; i < entriesList.Count; i++)
            {
                if (entriesList[i].date == "  -  -")
                {
                    indexesEmptyDateEntries.Add(i);
                }
                else
                {
                    indexesNotEmptyDateEntries.Add(i);
                }
            }

            //Заполнение части массива с именами и датами записей записями с непустыми датами
            string[,] namesDatesEntries = new string[entriesList.Count, 2];
            for (int i = 0; i < indexesNotEmptyDateEntries.Count; i++)
            {
                namesDatesEntries[i, 0] = entriesList[indexesNotEmptyDateEntries[i]].name;
                namesDatesEntries[i, 1] = entriesList[indexesNotEmptyDateEntries[i]].date;
            }

            //Сортировка массива с именами и датами записей по дате
            int yearsVerifable,
            monthesVerifable,
            daysVerifiable,
            sumYearsMonthesVerifiable,
            yearsChecking,
            monthesChecking,
            daysChecking,
            sumYearsMonthesChecking;
            string nameBoofer, dateBoofer;
            for (int i = 0; i < indexesNotEmptyDateEntries.Count; i++)
            {
                for (int j = i + 1; j < indexesNotEmptyDateEntries.Count; j++)
                {
                    yearsVerifable = Int32.Parse(namesDatesEntries[i, 1].Substring(6, 4));
                    monthesVerifable = Int32.Parse(namesDatesEntries[i, 1].Substring(3, 2));
                    daysVerifiable = Int32.Parse(namesDatesEntries[i, 1].Substring(0, 2));
                    sumYearsMonthesVerifiable = yearsVerifable + monthesVerifable;

                    yearsChecking = Int32.Parse(namesDatesEntries[j, 1].Substring(6, 4));
                    monthesChecking = Int32.Parse(namesDatesEntries[j, 1].Substring(3, 2));
                    daysChecking = Int32.Parse(namesDatesEntries[j, 1].Substring(0, 2));
                    sumYearsMonthesChecking = yearsChecking + monthesChecking;

                    if (sumYearsMonthesChecking < sumYearsMonthesVerifiable || 
                        (sumYearsMonthesChecking == sumYearsMonthesVerifiable && daysChecking < daysVerifiable))
                    {
                        nameBoofer = namesDatesEntries[j, 0];
                        dateBoofer = namesDatesEntries[j, 1];

                        namesDatesEntries[j, 0] = namesDatesEntries[i, 0];
                        namesDatesEntries[j, 1] = namesDatesEntries[i, 1];

                        namesDatesEntries[i, 0] = nameBoofer;
                        namesDatesEntries[i, 1] = dateBoofer;
                    }
                }
            }

            //Заполнение части массива с именами и датами записей записями с пустыми датами
            int lastIndexNoEmpty = indexesNotEmptyDateEntries.Count;
            for (int i = 0; i < indexesEmptyDateEntries.Count; i++)
            {
                namesDatesEntries[lastIndexNoEmpty, 0] = entriesList[indexesEmptyDateEntries[i]].name;
                namesDatesEntries[lastIndexNoEmpty, 1] = entriesList[indexesEmptyDateEntries[i]].date;
                lastIndexNoEmpty++;
            }

            //Заполнение списка записей соответственно отсортированному массиву с именами и датами записей
            List<Entry> sortedEntriesList = new List<Entry>();
            int indexEntry = 0;
            for (int i = 0; i < (namesDatesEntries.Length / 2); i++)
            {
                for (int j = 0; j < entriesList.Count; j++)
                {
                    if (namesDatesEntries[i, 0] == entriesList[j].name)
                    {
                        indexEntry = j;
                        break;
                    }
                }
                sortedEntriesList.Add(entriesList[indexEntry]);
            }

            return sortedEntriesList;
        }

        //Вывод записей в интерфейс
        private void OutputEntries(List<Entry> entriesList, ListBox listBox, TextBox textBox)
        {
            listBox.Items.Clear();

            //Добавление элементов в список
            for (int i = 0; i < entriesList.Count; i++)
            {
                listBox.Items.Add(entriesList[i].name);
            }

            //Выставление активного элемента
            for (int i = 0; i < entriesList.Count; i++)
            {
                if (listBox.Items.Count > 0)
                {
                    if (listBox.Items[i].ToString() == textBox.Text)
                    {
                        listBox.SelectedIndex = i;
                        break;
                    }
                    else if (i == entriesList.Count - 1)
                    {
                        listBox.SelectedIndex = entriesList.Count - 1;
                        break;
                    }
                }
            }
        }

        //Вывод заметок в интерфейс
        private void OutputNotes()
        {
            UpdateListNotes();
            OutputEntries(noteList, listBoxNotes, textNameNote);
        }

        //Вывод планов в интерфейс
        private void OutputPlans()
        {
            UpdateListPlans();
            OutputEntries(planList, listBoxPlans, textNamePlan);

            listBoxPoints.SelectedIndex = listBoxPoints.Items.Count - 1;
        }

        //Сохранение записи в БД
        private void SaveEntryToDB(Entry entry)
        {
            command = new SqlCommand("INSERT INTO Entry (name_entry, date_entry, note_or_plan, text_entry)" +
            "VALUES ('" + entry.name + "', '" + entry.date + "', " + Convert.ToInt32(entry.noteOrPlan) + ", '" + entry.text + "')", connection);
            command.ExecuteNonQuery();
        }

        //Редактирование записей
        private void ChangeEntry(Entry entry, string previousName)
        {
            //Получение id записи из БД
            command = new SqlCommand("SELECT id_entry FROM Entry WHERE name_entry = '" + previousName + "' AND note_or_plan = " + Convert.ToInt32(entry.noteOrPlan), connection);
            string idEntry = command.ExecuteScalar().ToString();

            //Редактирование записи в БД
            command = new SqlCommand("UPDATE Entry SET name_entry = '" + entry.name + "', date_entry = '" + entry.date + "',  text_entry = '" + entry.text + "' WHERE id_entry = '" + idEntry + "'", connection);
            command.ExecuteNonQuery();
        }

        //Удаление записей
        private void DeleteEntry(Entry entry)
        {
            command = new SqlCommand("DELETE FROM Entry WHERE name_entry = '" + entry.name + "' AND note_or_plan = " + Convert.ToInt32(entry.noteOrPlan), connection);
            command.ExecuteNonQuery();
        }

        //Разделение пунктов плана из единого текста
        private List<string> SplittingTextIntoPoints(string text)
        {
            string[] list = text.Split('|');

            List<string> notEmptyStrings = new List<string>();
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != "")
                    notEmptyStrings.Add(UnescapeSplitSymbol(list[i]));
            }

            return notEmptyStrings;
        }

        //Сбор единого текста из пунктов плана
        private string AssemblingTextFromPoints(ListBox.ObjectCollection list)
        {
            string resultString = "";
            for (int i = 0; i < list.Count; i++)
            {
                resultString += EscapeSplitSymbol(list[i].ToString()) + "|";
            }
            return resultString;
        }

        //Скрытие разделительного символа
        private string EscapeSplitSymbol(string str)
        {
            str.Replace("|", "{splitSymbol}");
            return str;
        }

        //Возвращение разделительного символа
        private string UnescapeSplitSymbol(string str)
        {
            str.Replace("{splitSymbol}", "|");
            return str;
        }

        //Изменение шрифта объектов коллекции
        private void ChangeFont(Control.ControlCollection collection)
        {
            foreach (Control obj in collection)
            {
                if (obj.GetType() == typeof(TextBox) ||
                    obj.GetType() == typeof(ComboBox))
                    obj.Font = new Font(textsFontNameText.Text, (float)Convert.ToDouble(textsFontSize.Text), GraphicsUnit.Pixel);
                else
                    obj.Font = new Font(generalFontNameText.Text, (float)Convert.ToDouble(generalFontSize.Text), GraphicsUnit.Pixel);
            }
        }

        //Изменение шрифта на всей форме
        private void ChangeFontEverywhere()
        {
            ChangeFont(splitContainerNotes.Panel1.Controls);
            ChangeFont(splitContainerNotes.Panel2.Controls);
            ChangeFont(nameNoteBox.Controls);
            ChangeFont(dateNoteBox.Controls);
            ChangeFont(splitContainerPlans.Panel1.Controls);
            ChangeFont(splitContainerPlans.Panel2.Controls);
            ChangeFont(namePlanBox.Controls);
            ChangeFont(datePlanBox.Controls);
            ChangeFont(settings.Controls);
            ChangeFont(fontSettingsBox.Controls);
            ChangeFont(sortSettingsBox.Controls);
            ChangeFont(sortNotesSettingsRBtnsPanel.Controls);
            ChangeFont(sortPlansSettingsRBtnsPanel.Controls);

            //Изменение шрифта у ненаследующих элементов
            mainMenu.Font = new Font(generalFontNameText.Text, (float)Convert.ToDouble(generalFontSize.Text), GraphicsUnit.Pixel);
            mainTextNote.Font = new Font(textsFontNameText.Text, (float)Convert.ToDouble(textsFontSize.Text), GraphicsUnit.Pixel);
            listBoxNotes.Font = new Font(textsFontNameText.Text, (float)Convert.ToDouble(textsFontSize.Text), GraphicsUnit.Pixel);
            listBoxPoints.Font = new Font(textsFontNameText.Text, (float)Convert.ToDouble(textsFontSize.Text), GraphicsUnit.Pixel);
            listBoxPlans.Font = new Font(textsFontNameText.Text, (float)Convert.ToDouble(textsFontSize.Text), GraphicsUnit.Pixel);
        }

        //Преобразование строки числа с точкой
        private string ToDoubleWithComma(string number)
        {
            if (number.Contains("."))
                return number.Replace('.', ',');
            else
                return number;
        }

        //Проверка текста на наличие апострофа, тире, кавычек, слеша
        private void ValidatingTextSymbols(Control control)
        {
            if (control.Text.Contains("'") || control.Text.Contains("\"") || control.Text.Contains("-") || control.Text.Contains("/"))
            {
                MessageBox.Show("Текст не должен содержать следующих символов:" +
                    " апостроф, тире, кавычки, слеш", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                control.Text = control.Text.Replace("'", "");
                control.Text = control.Text.Replace("\"", "");
                control.Text = control.Text.Replace("-", "");
                control.Text = control.Text.Replace("/", "");
            }
        }

        //Проверка текста в текстовых полях на пробелы
        private bool ValidatingTextSpaces(string str)
        {
            if (str.Contains(" "))
            {
                int counterSpaces = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                        counterSpaces++;
                }

                if (counterSpaces == str.Length)
                    return false;
                else
                    return true;
            }
            else
                return true;
        }

        //Проверка корректности ввода даты
        private void IsDateCorrect(MaskedTextBox textBoxDate)
        {
            //Преобразование строки из MaskedTextBox
            string dateClear = textBoxDate.Text.Replace(" ", "").Replace("-", ".");

            DateTime resultDate;

            if (!(dateClear.Length == 2 || (dateClear.Length == 10 && DateTime.TryParse(dateClear, out resultDate))))
            {
                MessageBox.Show("Некорректно введена дата!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDate.Clear();
            }
        }

        //Проверка ListBox на наличие элементов
        private bool IsListEmpty(ListBox listBox)
        {
            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("Список уже пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
                
        }

        //Поиск совпадений в списке записей с текущим именем
        private List<object> SearchSimilarEntries(List<Entry> entriesList, TextBox textBox)
        {
            List<object> resultList = new List<object>();

            for (int i = 0; i < entriesList.Count; i++)
            {
                if (entriesList[i].name == textBox.Text)
                {
                    resultList.Add(i);
                    resultList.Add(true);
                    return resultList;
                }
            }
            resultList.Add(-1);
            resultList.Add(false);
            return resultList;
        }

        //Очистка полей заметки
        private void ClearNote()
        {
            textNameNote.Clear();
            textDateNote.Clear();
            mainTextNote.Clear();
        }

        //Очистка полей плана
        private void ClearPlan()
        {
            textNamePlan.Clear();
            textDatePlan.Clear();
            listBoxPoints.Items.Clear();
        }

        //Сохранение записи
        private void SaveEntry(List<Entry> entriesList, ListBox listBox, TextBox textBoxName, MaskedTextBox textBoxDate, string text)
        {
            if (textBoxName.Text.Length == 0 || !ValidatingTextSpaces(textBoxName.Text))
            {
                MessageBox.Show("Некорректно введено имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Clear();
            }
            else
            {
                if (listBox.SelectedIndex == -1)
                {
                    if (Convert.ToBoolean(SearchSimilarEntries(entriesList, textBoxName)[1]))
                        MessageBox.Show("Запись с таким именем уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (mainTabs.SelectedIndex == 0)
                        {
                            SaveEntryToDB(new Entry(textBoxName.Text, textBoxDate.Text, text, false));
                            OutputNotes();
                        }
                        else if (mainTabs.SelectedIndex == 1)
                        {
                            SaveEntryToDB(new Entry(textBoxName.Text, textBoxDate.Text, text, true));
                            OutputPlans();
                        }
                    }
                }
                else
                {
                    if (Convert.ToBoolean(SearchSimilarEntries(entriesList, textBoxName)[1]) &&
                        Convert.ToInt32(SearchSimilarEntries(entriesList, textBoxName)[0]) != listBox.SelectedIndex)
                        MessageBox.Show("Запись с таким именем уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (mainTabs.SelectedIndex == 0)
                        {
                            ChangeEntry(new Entry(textBoxName.Text, textBoxDate.Text, text, false), listBoxNotes.SelectedItem.ToString());
                            OutputNotes();
                        }
                        else if (mainTabs.SelectedIndex == 1)
                        {
                            ChangeEntry(new Entry(textBoxName.Text, textBoxDate.Text, text, true), listBoxPlans.SelectedItem.ToString());
                            OutputPlans();
                        }
                    }
                }
            }
        }

        //Копирование записи
        private void CopyEntry(TextBox textBoxName, MaskedTextBox textBoxDate, string text)
        {
            if (textBoxName.Text.Length > 0)
            {
                if (textBoxDate.Text == "  -  -")
                    Clipboard.SetText(textBoxName.Text + ": " + text);
                else
                    Clipboard.SetText(textBoxName.Text + ", " + textBoxDate.Text + ": " + text);

                MessageBox.Show("Скопировано!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Запись должна иметь имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void saveNoteButton_Click(object sender, EventArgs e)
        {
            SaveEntry(noteList, listBoxNotes, textNameNote, textDateNote, mainTextNote.Text);
        }
        
        private void savePlanButton_Click(object sender, EventArgs e)
        {
            SaveEntry(planList, listBoxPlans, textNamePlan, textDatePlan, AssemblingTextFromPoints(listBoxPoints.Items));
        }

        private void textDataNote_Leave(object sender, EventArgs e)
        {
            IsDateCorrect(textDateNote);
        }

        private void textDatePlan_Leave(object sender, EventArgs e)
        {
            IsDateCorrect(textDatePlan);
        }

        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < noteList.Count; i++)
            {
                if (listBoxNotes.SelectedIndex > -1 && noteList[i].name == listBoxNotes.SelectedItem.ToString())
                {
                    textNameNote.Text = noteList[i].name;
                    textDateNote.Text = noteList[i].date;
                    mainTextNote.Text = noteList[i].text;
                }
            }
        }

        private void listBoxPlans_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPoints.Items.Clear();

            for (int i = 0; i < planList.Count; i++)
            {
                if (listBoxPlans.SelectedIndex > -1 && planList[i].name == listBoxPlans.SelectedItem.ToString())
                {
                    textNamePlan.Text = planList[i].name;
                    textDatePlan.Text = planList[i].date;
                    List<string> points = SplittingTextIntoPoints(planList[i].text);
                    for (int j = 0; j < points.Count; j++)
                        listBoxPoints.Items.Add(points[j]);
                }
            }

            listBoxPoints.SelectedIndex = listBoxPoints.Items.Count - 1;
        }

        private void createNewNoteBtn_Click(object sender, EventArgs e)
        {
            listBoxNotes.SelectedIndex = -1;
            ClearNote();
        }

        private void createNewPlanBtn_Click(object sender, EventArgs e)
        {
            listBoxPlans.SelectedIndex = -1;
            ClearPlan();
        }

        private void clearNoteBtn_Click(object sender, EventArgs e)
        {
            ClearNote();
        }

        private void clearPlanBtn_Click(object sender, EventArgs e)
        {
            ClearPlan();
        }

        private void deleteListBoxNotesBtn_Click(object sender, EventArgs e)
        {
            if (IsListEmpty(listBoxNotes))
            {
                DeleteEntry(noteList[listBoxNotes.SelectedIndex]);
                ClearNote();
                OutputNotes();
            }
        }

        private void deleteListBoxPlansBtn_Click(object sender, EventArgs e)
        {
            if(IsListEmpty(listBoxPlans))
            {
                DeleteEntry(planList[listBoxPlans.SelectedIndex]);
                ClearPlan();
                OutputPlans();
            }
        }

        private void sortListBoxNotesNameRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sortListBoxNotesNameRBtn.Checked)
                OutputNotes();
        }

        private void sortListBoxNotesDateRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sortListBoxNotesDateRBtn.Checked)
                OutputNotes();
        }

        private void sortListBoxPlansNameRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sortListBoxPlansNameRBtn.Checked)
                OutputPlans();
        }

        private void sortListBoxPlansDateRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sortListBoxPlansDateRBtn.Checked)
                OutputPlans();
        }

        private void copyNoteBtn_Click(object sender, EventArgs e)
        {
            CopyEntry(textNameNote, textDateNote, mainTextNote.Text);
        }

        private void copyPlanBtn_Click(object sender, EventArgs e)
        {
            CopyEntry(textNamePlan, textDatePlan, AssemblingTextFromPoints(listBoxPoints.Items));
        }

        private void applySettingsBtn_Click(object sender, EventArgs e)
        {
            generalFontSize.Text = ToDoubleWithComma(generalFontSize.Text);
            textsFontSize.Text = ToDoubleWithComma(textsFontSize.Text);

            double result;
            if (!double.TryParse(generalFontSize.Text, out result) || !double.TryParse(textsFontSize.Text, out result))
            {
                MessageBox.Show("Некорректно введен размер шрифта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Convert.ToDouble(generalFontSize.Text) < 10 ||
                    Convert.ToDouble(generalFontSize.Text) > 14 ||
                    Convert.ToDouble(textsFontSize.Text) < 10 ||
                    Convert.ToDouble(textsFontSize.Text) > 14)
                {
                    MessageBox.Show("Введено недопустимое значение размера шрифта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ChangeFontEverywhere();

                    command = new SqlCommand("UPDATE Settings SET setting_value = '" + generalFontNameText.Text + 
                        "' WHERE setting_name = 'generalFontNameText'", connection);
                    command.ExecuteNonQuery();

                    command = new SqlCommand("UPDATE Settings SET setting_value = '" + textsFontNameText.Text +
                        "' WHERE setting_name = 'textsFontNameText'", connection);
                    command.ExecuteNonQuery();

                    command = new SqlCommand("UPDATE Settings SET setting_value = '" + generalFontSize.Text +
                        "' WHERE setting_name = 'generalFontSize'", connection);
                    command.ExecuteNonQuery();

                    command = new SqlCommand("UPDATE Settings SET setting_value = '" + textsFontSize.Text +
                        "' WHERE setting_name = 'textsFontSize'", connection);
                    command.ExecuteNonQuery();

                    command = new SqlCommand("UPDATE Settings SET setting_value = '" + sortNotesDateSettingsRBtn.Checked.ToString() +
                        "' WHERE setting_name = 'sortNotesDateSettingsRBtn'", connection);
                    command.ExecuteNonQuery();

                    command = new SqlCommand("UPDATE Settings SET setting_value = '" + sortPlansDateSettingsRBtn.Checked.ToString() +
                        "' WHERE setting_name = 'sortPlansDateSettingsRBtn'", connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void createNewPointBtn_Click(object sender, EventArgs e)
        {
            createNewPoint createNewPointForm = new createNewPoint(generalFontNameText.Text, generalFontSize.Text, textsFontNameText.Text, textsFontSize.Text);
            createNewPointForm.Owner = this;
            createNewPointForm.ShowDialog();
        }

        private void deletePointBtn_Click(object sender, EventArgs e)
        {
            if (IsListEmpty(listBoxPoints))
            {
                listBoxPoints.Items.RemoveAt(listBoxPoints.SelectedIndex);
                listBoxPoints.SelectedIndex = listBoxPoints.Items.Count - 1;
            }
        }

        private void createNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTabs.SelectedIndex = 0;
            listBoxNotes.SelectedIndex = -1;
            ClearNote();
        }

        private void createPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTabs.SelectedIndex = 1;
            listBoxPlans.SelectedIndex = -1;
            ClearPlan();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTabs.SelectedIndex == 0)
                SaveEntry(noteList, listBoxNotes, textNameNote, textDateNote, mainTextNote.Text);
            else if (mainTabs.SelectedIndex == 1)
                SaveEntry(planList, listBoxPlans, textNamePlan, textDatePlan, AssemblingTextFromPoints(listBoxPoints.Items));
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Волков Никита Александрович\nГруппа: ИСП 32-18", "О разработчике", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Обработчик события печати
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printString, new Font("Times New Roman", 14), Brushes.Black, 0, 0);
        }

        //Печать данных текущей выбранной записи
        private void PrintEntry(TextBox textBoxName, MaskedTextBox textBoxDate, string text)
        {
            //Документ для печати
            PrintDocument printDocument = new PrintDocument();

            //Обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            //Диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            //Установка объекта печати для его настройки
            printDialog.Document = printDocument;

            if (textBoxName.Text.Length > 0)
            {
                if (textBoxDate.Text == "  -  -")
                    printString = textBoxName.Text + ": " + text;
                else
                    printString = textBoxName.Text + ", " + textBoxDate.Text + ": " + text;

                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print();
            }
            else
                MessageBox.Show("Запись должна иметь имя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTabs.SelectedIndex == 0)
                PrintEntry(textNameNote, textDateNote, mainTextNote.Text);
            else if (mainTabs.SelectedIndex == 1)
                PrintEntry(textNamePlan, textDatePlan, AssemblingTextFromPoints(listBoxPoints.Items));
        }

        private void textNameNote_TextChanged(object sender, EventArgs e)
        {
            ValidatingTextSymbols(textNameNote);
        }

        private void mainTextNote_TextChanged(object sender, EventArgs e)
        {
            ValidatingTextSymbols(mainTextNote);
        }

        private void textNamePlan_TextChanged(object sender, EventArgs e)
        {
            ValidatingTextSymbols(textNamePlan);
        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Введение\n" +
                "Областью применения программы является повседневная жизнь. Она служит для создания заметок и/или планов, " +
                "которые потом можно просматривать и редактировать. Для использования необходимо обладать лишь стандартными " +
                "навыками обращения с компьютером.Будущему пользователю необходимо ознакомиться с настоящим руководством.\n" +
                "2. Назначение и условия применения программного обеспечения\n" +
                "Программное средство подходит для автоматизации планирования различных видов задач, " +
                "систематизации какой - либо информации.Его следует применять, когда необходимо что - либо запомнить " +
                "или спланировать.\n" +
                "3. Подготовка к работе\n" +
                "Программное средство содержит исполняемый файл приложения и базу данных для сохранения информации о " +
                "созданных заметках и планах. Поставляется на различных запоминающий устройствах.\n" +
                "Для корректной работы программы на компьютер следует установить MS SQL Server 2016 и .Net Framework 4.5. " +
                "Загружать данное программное средство следует копированием файлов с запоминающего устройства на компьютер.\n" +
                "Для проверки работоспособности программы необходимо ее запустить. Если программа запустилась, и отобразился " +
                "интерфейс, можно считать ее работоспособной.\n" +
                "4. Описание операций\n" +
                "Программное средство обладает функциями создания заметки с указанием названия, даты и самого текста, " +
                "создания плана с указанием названия, даты и пунктов плана, сортировки как заметок, так и планов по " +
                "названию или дате, сохранения всех созданных заметок и планов, печати выбранной заметки или плана, " +
                "настройки основного шрифта приложения и шрифта текстовых полей, настройки сортировки заметок и планов " +
                "при запуске приложения.\n" +
                "Сохранение заметок и планов осуществляется в базу данных.", "О разработчике", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void noteBookForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 15350)
                    MessageBox.Show("База данных не подключена!\nБез подключения к базе данных приложение не может нормально функционировать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Необходимо обновление localdb!\nБез базы данных приложение не может нормально функционировать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }


            command = new SqlCommand("SELECT * FROM Settings", connection);
            dataReader = command.ExecuteReader();

            //Выставление настроек при запуске
            while (dataReader.Read())
            {
                //Основной шрифт
                if (dataReader[1].ToString() == "generalFontNameText")
                    generalFontNameText.Text = dataReader[2].ToString();

                //Шрифт текстов
                if (dataReader[1].ToString() == "textsFontNameText")
                    textsFontNameText.Text = dataReader[2].ToString();

                //Размер основного текста
                if (dataReader[1].ToString() == "generalFontSize")
                    generalFontSize.Text = dataReader[2].ToString();

                //Размер шрифта текстов
                if (dataReader[1].ToString() == "textsFontSize")
                    textsFontSize.Text = dataReader[2].ToString();

                //Сортировка заметок в настройках
                if (dataReader[1].ToString() == "sortNotesSettingsRBtn")
                {
                    if (!Convert.ToBoolean(dataReader[2]))
                        sortNotesNameSettingsRBtn.Checked = true;
                    else
                        sortNotesDateSettingsRBtn.Checked = true;
                }

                //Сортировка планов в настройках
                if (dataReader[1].ToString() == "sortPlansSettingsRBtn")
                {
                    if (!Convert.ToBoolean(dataReader[2]))
                        sortPlansNameSettingsRBtn.Checked = true;
                    else
                        sortPlansDateSettingsRBtn.Checked = true;
                }
            }
            dataReader.Close();

            //Сортировка заметок на панели заметок
            if (sortNotesNameSettingsRBtn.Checked)
                sortListBoxNotesNameRBtn.Checked = true;
            else if (sortNotesDateSettingsRBtn.Checked)
                sortListBoxNotesDateRBtn.Checked = true;

            //Сортировка планов на панели планов
            if (sortPlansNameSettingsRBtn.Checked)
                sortListBoxPlansNameRBtn.Checked = true;
            else if (sortPlansDateSettingsRBtn.Checked)
                sortListBoxPlansDateRBtn.Checked = true;

            ChangeFontEverywhere();

            UpdateListNotes();
            UpdateListPlans();
        }

        private void noteBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void generalFontNameText_TextChanged(object sender, EventArgs e)
        {
            ValidatingTextSymbols(generalFontNameText);
        }

        private void textsFontNameText_TextChanged(object sender, EventArgs e)
        {
            ValidatingTextSymbols(textsFontNameText);
        }
    }

    class Entry
    {
        public string name { get; set; }
        public string date { get; set; }
        public string text { get; set; }
        public bool noteOrPlan { get; set; }

        public Entry(string name, string date, string text, bool noteOrPlan)
        {
            this.name = name;
            this.date = date;
            this.text = text;
            this.noteOrPlan = noteOrPlan;
        }
    }
}
