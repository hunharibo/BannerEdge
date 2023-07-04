using BannerEdge.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BannerEdge
{
    public partial class MainForm : Form
    {
        private List<SpritePart> parts;
        private Image image;

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _atlasImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Png image files|*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                _atlasImagePathTxt.Text = ofd.FileName;
                Properties.Settings.Default.AtlasPath = _atlasImagePathTxt.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void _spritesheetXMLBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML files|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _spritesheetXMLPathTxt.Text = ofd.FileName;
                Properties.Settings.Default.XMLPath = _spritesheetXMLPathTxt.Text;
                Properties.Settings.Default.Save();
            }
        }

        private async void _loadImageBtn_click(object sender, EventArgs e)
        {
            if (Utilities.IsValidXMLFile(_spritesheetXMLPathTxt.Text) && Utilities.IsValidPNGFile(_atlasImagePathTxt.Text))
            {
                _searchBoxTxt.Text = "";
                MainPicturePanel.Controls.Clear();
                var popupForm = new PopupForm();
                popupForm.Show();

                var progress = new Progress<int>(value =>
                {
                    popupForm.SetProgress(value, String.Format("Splitting parts: {0}%", value));
                });

                await Task.Run(() => LoadAtlas(progress));
                
                popupForm.Hide();
                
                _resultsListBox.Items.Clear();
                foreach(var item in parts)
                {
                    _resultsListBox.Items.Add(item.Name);
                }
                if(parts.Count > 0)
                {
                    AddMainAtlasToFlowPanel();
                }
                else
                {
                    MessageBox.Show("No matching sprite parts found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid path detected.");
            }
        }

        private void LoadAtlas(IProgress<int> progress)
        {
            image = Bitmap.FromFile(_atlasImagePathTxt.Text);
            var info = new FileInfo(_atlasImagePathTxt.Text);
            var filename = info.Name.Split('.')[0];
            var splits = filename.Split('_');
            var categoryName = "";
            for (int i = 0; i < splits.Length - 1; i++)
            {
                categoryName += splits[i];
                if (i != splits.Length - 2) categoryName += "_";
            }
            var sheetId = splits[splits.Length - 1];
            parts = Utilities.ParseParts(_spritesheetXMLPathTxt.Text, categoryName, sheetId);
            for(int i = 0; i < parts.Count; i++)
            {
                var percentComplete = i * 100 / parts.Count;
                parts[i].SplitFromAtlas(image);
                progress.Report(percentComplete);
            }
            progress.Report(100);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _spritesheetXMLPathTxt.Text = Properties.Settings.Default.XMLPath;
            _atlasImagePathTxt.Text = Properties.Settings.Default.AtlasPath;
            _modulePathTxt.Text = Properties.Settings.Default.ModulePath;
        }

        private void _exportSingleBtn_Click(object sender, EventArgs e)
        {
            if(parts != null && parts.Count > 0 && _resultsListBox.SelectedItems.Count > 0)
            {
                var form = new CategoryNameForm(Export, true);
                form.Show();
            }
            else
            {
                MessageBox.Show("No spriteparts selected.");
            }
        }

        private void _exportAllBtn_Click(object sender, EventArgs e)
        {
            if (parts != null && parts.Count > 0)
            {
                var form = new CategoryNameForm(Export, false);
                form.Show();
            }
            else
            {
                MessageBox.Show("No spriteparts loaded.");
            }
        }

        private void Export(string categoryName, bool isSelection)
        {
            var dir = Properties.Settings.Default.ModulePath;
            var guiDir = dir + "\\GUI\\SpriteParts\\" + categoryName;
            if (!Directory.Exists(guiDir)) Directory.CreateDirectory(guiDir);
            if (isSelection)
            {
                var selectedParts = parts.Where(x => _resultsListBox.SelectedItems.Contains(x.Name));
                foreach(var part in selectedParts)
                {
                    part.Write(guiDir);
                }
            }
            else
            {
                foreach(var part in parts)
                {
                    part.Write(guiDir);
                }
            }
            var configFilePath = dir + "\\GUI\\SpriteParts\\" + "Config.xml";
            var info = new DirectoryInfo(dir + "\\GUI\\SpriteParts\\");
            var directoryNames = info.GetDirectories().Select(x => x.Name);

            if (File.Exists(configFilePath))
            {
                XDocument config = XDocument.Load(configFilePath);
                var list = config.Descendants("SpriteCategory").Select(x => x.Attribute("Name").Value);
                var missingList = directoryNames.Where(x => !list.Contains(x));
                foreach(var item in missingList)
                {
                    XElement e = new XElement("SpriteCategory");
                    e.SetAttributeValue("Name", item);
                    XElement e2 = new XElement("AlwaysLoad");
                    e.Add(e2);
                    config.Root.Add(e);
                }
                config.Save(configFilePath);
            }
            else
            {
                XDocument config = new XDocument();
                XElement e = new XElement("Config");
                foreach(var item in directoryNames)
                {
                    XElement e2 = new XElement("SpriteCategory");
                    e2.SetAttributeValue("Name", item);
                    XElement e3 = new XElement("AlwaysLoad");
                    e2.Add(e3);
                    e.Add(e2);
                }
                config.Add(e);
                config.Save(configFilePath);
            }
            MessageBox.Show("Export complete.");
        }

        private void _resultsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_resultsListBox.SelectedItems.Count == 0) return;
            MainPicturePanel.Controls.Clear();

            var selectedParts = parts.Where(x=>_resultsListBox.SelectedItems.Contains(x.Name));
            foreach(var part in selectedParts)
            {
                AddSelectedSpritePartToFlowPanel(part);
            }
        }

        private void _clearSelectionBtn_Click(object sender, EventArgs e)
        {
            MainPicturePanel.Controls.Clear();
            AddMainAtlasToFlowPanel();
            _resultsListBox.SelectedItems.Clear();
        }

        private void AddMainAtlasToFlowPanel()
        {
            PictureBox pb = new PictureBox();
            pb.Image = image;
            pb.Size = MainPicturePanel.Size;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            MainPicturePanel.Controls.Add(pb);
        }

        private void AddSelectedSpritePartToFlowPanel(SpritePart selectedPart)
        {
            PictureBox pb = new PictureBox();
            pb.Image = selectedPart.Bitmap;
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Size = new Size(250, 250);
            if(selectedPart.Bitmap.Size.Width > pb.Size.Width || selectedPart.Bitmap.Size.Height > pb.Size.Height)
            {
                pb.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pb.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            MainPicturePanel.Controls.Add(pb);
        }

        private void _modulePathBtn_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                _modulePathTxt.Text = dialog.SelectedPath;
                Properties.Settings.Default.ModulePath = _modulePathTxt.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void _searchBoxTxt_TextChanged(object sender, EventArgs e)
        {
            if(parts == null || parts.Count == 0) return;
            
            if(MainPicturePanel.Controls.Count != 1 || MainPicturePanel.Controls[0].Size != MainPicturePanel.Size)
            {
                MainPicturePanel.Controls.Clear();
                AddMainAtlasToFlowPanel();
            }
            if (string.IsNullOrEmpty(_searchBoxTxt.Text))
            {
                _resultsListBox.Items.Clear();
                foreach(var part in parts)
                {
                    _resultsListBox.Items.Add(part.Name);
                }
            }
            else
            {
                _resultsListBox.Items.Clear();
                var list = parts.Where(x => x.Name.ToLower().Contains(_searchBoxTxt.Text.ToLower()));
                foreach(var part in list)
                {
                    _resultsListBox.Items.Add(part.Name);
                }
            }
        }

        private void selectSpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TaleWorlds.TwoDimension.SpriteSheetGenerator.exe|TaleWorlds.TwoDimension.SpriteSheetGenerator.exe";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.PackerExePath = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void _packAtlasBtn_Click(object sender, EventArgs e)
        {
            var filePath = Properties.Settings.Default.PackerExePath;
            if (File.Exists(filePath))
            {
                Process proc = new Process();
                proc.StartInfo = new ProcessStartInfo(filePath);
                proc.StartInfo.WorkingDirectory = Path.GetDirectoryName(filePath);
                proc.EnableRaisingEvents = true;
                proc.Exited += Proc_Exited;
                proc.Start();
            }
            else
            {
                MessageBox.Show("TaleWorlds.TwoDimension.SpriteSheetGenerator.exe not found. Please set the path in the File menu (You must have Bannerlord modding kit installed on Steam.");
            }
        }

        private void Proc_Exited(object sender, EventArgs e)
        {
            var dir = Properties.Settings.Default.ModulePath;
            var modname = dir.Split('\\').Last();
            var spriteDataFilePath = dir + "\\GUI\\" + modname + "SpriteData.xml";

            if (File.Exists(spriteDataFilePath))
            {
                XDocument spriteData = XDocument.Load(spriteDataFilePath);
                var list = spriteData.Descendants("SpriteCategory");
                foreach (var item in list)
                {
                    XElement e2 = new XElement("AlwaysLoad");
                    item.Add(e2);
                }
                spriteData.Save(spriteDataFilePath);
            }
        }
    }
}
