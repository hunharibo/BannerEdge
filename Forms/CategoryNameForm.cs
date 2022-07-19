using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BannerEdge.Forms
{
    public partial class CategoryNameForm : Form
    {
        private Action<string, bool> _callback;
        private bool _isSelection;

        public CategoryNameForm(Action<string, bool> callback, bool isSelection)
        {
            InitializeComponent();
            _callback = callback;
            _isSelection = isSelection;
        }

        private void _okBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_categoryNameTxt.Text))
            {
                Hide();
                Properties.Settings.Default.CategoryName = _categoryNameTxt.Text;
                Properties.Settings.Default.Save();
                if (_callback != null) _callback(_categoryNameTxt.Text, _isSelection);
            }
            else
            {
                MessageBox.Show("Name must not be empty");
            }
        }

        private void CategoryNameForm_Load(object sender, EventArgs e)
        {
            _categoryNameTxt.Text = Properties.Settings.Default.CategoryName;
        }
    }
}
