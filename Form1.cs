using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class MainForm : Form
    {
        private IDictionaryManager manager;
        private string word;
        private bool changeSide = false;
        private string filePath = "D:\\!Учеба\\C#\\ДЗ\\new\\Словарь txt\\testSmall.txt";
        //  IDictionaryManager manager;
        private DictionaryRepository repository;
        private DictionaryManagerFactory factory = new DictionaryManagerFactory();

        public MainForm()
        {
            InitializeComponent();
            string str = File.ReadAllText(filePath);
            repository = DictionarySerializer.DeserializeDictionary(str);
            left_textBox.Text = repository.LanguageWord;
            right_textBox.Text = repository.LanguageTranslate;
            manager = DictionaryManagerFactory.CreateDictionaryManager(repository);
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            DialogResult rezult = openFileDialog.ShowDialog();
            string str = null;
            if (rezult == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            if (filePath != null)
            {
                str = File.ReadAllText(filePath);
            }
            if (str != null)
            {
                repository = DictionarySerializer.DeserializeDictionary(str);
                left_textBox.Text = repository.LanguageWord;
                right_textBox.Text = repository.LanguageTranslate;
            }
        }

        private void changeLanguage_button_Click(object sender, EventArgs e)
        {
            string temp = left_textBox.Text;
            left_textBox.Text = right_textBox.Text;
            right_textBox.Text = temp;
            if (!changeSide)
            {
                changeSide = true;
            }
            else
            {
                changeSide = false;
            }
        }

        private void showAllMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                // word_richTextBox.Text = manager.ReadFromFile(filePath);
            }
        }

        private void Translate_button_Click(object sender, EventArgs e)
        {
             word = word_richTextBox.Text;
            if (word != null && changeSide == false)
            {
                if (Help.GetListFromString(word).Count == 1)
                {
                    translate_richTextBox.Text = Help.GetStringFromList(manager.GetTranslation(word));
                    // info_StripStatusLabel.Text = $"Тема: {repository.GetThemeNameFromWord(word)}";
                }
                else
                {
                    translate_richTextBox.Text = Help.GetStringFromListSpaced(manager.GetAllTranslations(word));
                    //info_StripStatusLabel.Text = $"Тема: {repository.GetThemeNameFromWord(word)}";
                }
            }
            else
            {
                translate_richTextBox.Text = manager.GetWordByTranslation(word);

            }
        }

        private void addWordMenuItem_Click(object sender, EventArgs e)
        {

            RedactForm redactForm = new RedactForm(repository);
            redactForm.Show();
        }
    }
}
