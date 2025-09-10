using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    internal partial class RedactForm : Form
    {
        private DictionaryRepository repository_;
        public  void AddThemesToCombobox()
        {
            foreach(var t in repository_.Themes)
            {
                themes_comboBox.Items.Add(t.ThemeName);
            }
        }
        public RedactForm(DictionaryRepository repository)
        {
            InitializeComponent();
            repository_ = repository;
            AddThemesToCombobox();
        }

        private void themes_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theme = themes_comboBox.Text;
                if (theme != null)
            {

            }else
            {
                MessageBox.Show(
                    "Выберите сначала тему!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
