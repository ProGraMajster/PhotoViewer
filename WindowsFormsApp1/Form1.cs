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
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Przeglądarka_zdjęć : Form
    {
        string[] args = Environment.GetCommandLineArgs();
        int zakrs_args;
        bool fullwindow = false;

        string path_to_file;

        string floder_zdj;

        Image zdjecie;
        Image imageP;
        public Przeglądarka_zdjęć()
        {
            InitializeComponent();
            ShowpanelFiles();
        }

        ImageList imageList1;
        public void ShowpanelFiles()
        {
            listView1.Items.Clear();
            imageList1 = new ImageList();
            /*
            string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                imageList.Images.Add(Icon.ExtractAssociatedIcon(file));
                ListViewItem item = new ListViewItem(fileName);
                item.Tag = file;
                listView1.Items.Add(Path.GetFileName(fileName), imageList.Images.Count - 1);
            }
            */
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));

            
            DirGetFile(dir);
            dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            DirGetFile(dir);
            string download = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
            dir = new DirectoryInfo(download);
            DirGetFile(dir);
            listView1.SmallImageList = imageList1;
            panelFiles.Visible = true;
            panelFiles.BringToFront();
        }

        public void DirGetFile(System.IO.DirectoryInfo directory)
        {
            ListViewGroup listViewGroup = new ListViewGroup();
            listViewGroup.Header = directory.FullName;
            listView1.Groups.Add(listViewGroup);
            ListViewItem item;
            // For each file in the c:\ directory, create a ListViewItem
            // and set the icon to the icon extracted from the file.
            foreach (System.IO.FileInfo file in directory.GetFiles("*.png"))
            {
                // Set a default icon for the file.
                Image iconForFile;
                // Check to see if the image collection contains an image
                // for this extension, using the extension as a key.
                if (!imageList1.Images.ContainsKey(file.Extension))
                {
                    // If not, add the image to the image list.
                    iconForFile = System.Drawing.Image.FromFile(file.FullName);
                    imageList1.Images.Add(file.Extension, iconForFile);
                    item = new ListViewItem(file.Name, file.Extension, listViewGroup);
                }
                item = new ListViewItem(file.Name ,listViewGroup);
                item.Tag = file.FullName;
                item.ImageKey = file.Extension;
                listViewGroup.ListView.Items.Add(item);
            }

            foreach (System.IO.FileInfo file in directory.GetFiles("*.bmp"))
            {
                // Set a default icon for the file.
                Image iconForFile;

                // Check to see if the image collection contains an image
                // for this extension, using the extension as a key.
                if (!imageList1.Images.ContainsKey(file.Extension))
                {
                    // If not, add the image to the image list.
                    iconForFile = System.Drawing.Image.FromFile(file.FullName);
                    imageList1.Images.Add(file.Extension, iconForFile);
                }
                item = new ListViewItem(file.Name, file.Extension, listViewGroup);
                item.Tag = file.FullName;
                item.ImageKey = file.Extension;
                listViewGroup.ListView.Items.Add(item);
            }

            foreach (System.IO.FileInfo file in directory.GetFiles("*.jpg"))
            {
                // Set a default icon for the file.
                Icon iconForFile;
                // Check to see if the image collection contains an image
                // for this extension, using the extension as a key.
                if (!imageList1.Images.ContainsKey(file.Extension))
                {
                    // If not, add the image to the image list.
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                    imageList1.Images.Add(file.Extension, iconForFile);
                }
                item = new ListViewItem(file.Name, 1, listViewGroup);
                item.Tag = file.FullName;
                item.ImageKey = file.Extension;
                listViewGroup.ListView.Items.Add(item);
            }

            foreach (System.IO.FileInfo file in directory.GetFiles("*.jpeg"))
            {
                // Set a default icon for the file.
                Icon iconForFile;

                // Check to see if the image collection contains an image
                // for this extension, using the extension as a key.
                if (!imageList1.Images.ContainsKey(file.Extension))
                {
                    // If not, add the image to the image list.
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                    imageList1.Images.Add(file.Extension, iconForFile);
                }
                item = new ListViewItem(file.Name, 1, listViewGroup);
                item.Tag = file.FullName;
                item.ImageKey = file.Extension;
                listViewGroup.ListView.Items.Add(item);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Pokaż okno dialogowe Otwórz plik.Jeśli użytkownik kliknie OK, załaduj plik
            // obraz wybrany przez użytkownika.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                path_to_file = openFileDialog1.FileName;
                zdjecie = pictureBox1.Image;
            }
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Pokaż okno dialogowe koloru. Jeśli użytkownik kliknie OK, zmień plik
            // Tło kontrolki PictureBox na kolor wybrany przez użytkownika.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Zamknij formularz.
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Wyczyść obraz.
            pictureBox1.Image = null;
            panelFiles.Show();
        }

        bool stan_kl = false;
        private void Przeglądarka_zdjęć_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11 && fullwindow == false && stan_kl == false)
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                menuStrip1.Visible = false;
                panelDol.Visible = false;
                panelGora.Visible = false;
                fullwindow = true;
                stan_kl = true;
            }

            if (e.KeyCode == Keys.F11 && fullwindow == true && stan_kl == false)
            {
                this.TopMost = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                fullwindow = false;
                panelDol.Visible = true;
                panelGora.Visible = true;
                menuStrip1.Visible = true;
            }
        }

        private void Przeglądarka_zdjęć_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11 && stan_kl == true)
            {
                stan_kl = false;
            }
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                path_to_file = openFileDialog1.FileName;
                zdjecie = pictureBox1.Image;
                floder_zdj = openFileDialog1.SafeFileName;
                int zmienna = floder_zdj.Length;
                floder_zdj = openFileDialog1.FileName;
                //int zmienna_2 = floder_zdj.Length;
                //int wynik = zmienna_2 - zmienna;
                floder_zdj.Substring(floder_zdj.Length - zmienna);
                //MessageBox.Show(floder_zdj);
            }
        }

        private void zamknijZdjęcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            Application.DoEvents();
            panelFiles.Show();
            panelFiles.BringToFront();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informacjeOProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ProductName + Environment.NewLine +
                Application.ProductVersion + Environment.NewLine +
                "ProGraMajster(Kiko)" + Environment.NewLine, "Informacje o programie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Przeglądarka_zdjęć_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < args.Length; i++)
            {
                zakrs_args = i;
            }

            if (zakrs_args >= 1)
            {
                if (args[1].EndsWith(".jpg") || args[1].EndsWith(".png") || args[1].EndsWith(".bmp"))
                {
                    pictureBox1.Load(args[1]);
                    path_to_file = args[1];
                    panel3.BringToFront();
                }
            }

            if(zakrs_args >= 2)
            {
                if (args[2].EndsWith("-openimage"))
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Load(openFileDialog1.FileName);
                        path_to_file = openFileDialog1.FileName;
                        panel3.BringToFront();
                    }
                }
                else if (args[2].EndsWith("-max"))
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else if (args[2].EndsWith("-min"))
                {
                    this.WindowState = FormWindowState.Minimized;
                }
            }
        }

        private void maksymalizacjaOknaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimalizacjaOknaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void informacjeOPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(path_to_file))
            {
                string fileCreatedDate = File.GetCreationTime(path_to_file).ToString();
                string zmienna = zdjecie.Size.Width.ToString();
                zmienna += " x" + zdjecie.Size.Height.ToString();
                MessageBox.Show("Ścieżka do pliku: " + path_to_file + Environment.NewLine +
                    "Plik utworzono: " + fileCreatedDate + Environment.NewLine + zmienna,
                    "Informacje o pliku", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Błąd: Nie załadowano żadnego pliku",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dopasujZdjęcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void stretchImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void autoSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void centerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void tylkoZdjęcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDol.Visible = false;
            panelGora.Visible = false;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDol.Visible = true;
            panelGora.Visible = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        int zdj_obr = 0;

        private void obrocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zdj_obr++;
            if (zdjecie != null)
            {
                if(zdj_obr == 0)
                {
                    zdjecie.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                }
                else if(zdj_obr == 1)
                {
                    zdjecie.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if (zdj_obr == 2)
                {
                    zdjecie.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                else if (zdj_obr == 3)
                {
                    zdjecie.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                else if (zdj_obr == 4)
                {   
                    zdjecie.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    zdj_obr = 0;
                }
                pictureBox1.Image = zdjecie;
            }
        }

        int KlikC = 0;
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            KlikC++;
            if (KlikC == 0)
            {
                listView1.Sorting = SortOrder.None;
            }
            else if (KlikC == 1)
            {
                listView1.Sorting = SortOrder.Ascending;
            }
            else if (KlikC == 2)
            {
                listView1.Sorting = SortOrder.Descending;
            }
            else if (KlikC > 2)
            {
                listView1.Sorting = SortOrder.None;
                KlikC = 0;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                path += "\\" + listView1.SelectedItems[0].Text;
                textBoxInfoFile.Text = "";
                FileInfo finfo = new FileInfo(path);
                textBoxInfoFile.Text += finfo.Name + Environment.NewLine;
                textBoxInfoFile.Text += finfo.FullName + Environment.NewLine;
                textBoxInfoFile.Text += finfo.Extension + Environment.NewLine;
                textBoxInfoFile.Text += finfo.DirectoryName + Environment.NewLine;
                textBoxInfoFile.Text += finfo.Directory + Environment.NewLine;
                textBoxInfoFile.Text += finfo.Attributes.ToString() + Environment.NewLine;
                textBoxInfoFile.Text += finfo.CreationTime.ToString() + Environment.NewLine;
                textBoxInfoFile.Text += finfo.CreationTimeUtc + Environment.NewLine;
                textBoxInfoFile.Text += finfo.LastAccessTime + Environment.NewLine;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonF_Open_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                try
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                    pictureBox1.Load(listView1.SelectedItems[0].Tag.ToString());
                    //MessageBox.Show(listView1.SelectedItems[0].Text);
                    panelFiles.Hide();
                    path_to_file = path;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        bool flag_Poprze = false;
        bool flag_Nastep = false;
        int zmiennaKurX = Control.MousePosition.X;
        int zmiennaKurY = Control.MousePosition.Y;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            zmiennaKurX = e.X;
            zmiennaKurY = e.Y;
            if(flag_Poprze == true)
            {
                if (zmiennaKurX <= buttonZdjPoprze.Size.Width)
                {
                    buttonZdjPoprze.Show();
                }
                else
                {
                    buttonZdjPoprze.Hide();
                }
            }

            if(flag_Nastep == true)
            {
                if (zmiennaKurX >= buttonZdjNastep.Location.X)
                {
                    buttonZdjNastep.Show();
                }
                else
                {
                    buttonZdjNastep.Hide();
                }
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelOther.Show();
            panelOther.BringToFront();
            webBrowser1.Url = new Uri(path_to_file);
        }

        private void buttonExitOther_Click(object sender, EventArgs e)
        {
            panelOther.Hide();
        }
    }
}
