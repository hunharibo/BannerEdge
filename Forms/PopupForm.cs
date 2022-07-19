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
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();
        }

        public void SetProgress(int progress, string progressText)
        {
            _progessBar.Value = progress;
            _progressLbl.Text = progressText;
        }
    }
}
