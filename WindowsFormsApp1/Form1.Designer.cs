namespace WindowsFormsApp1
{
    partial class Przeglądarka_zdjęć
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Przeglądarka_zdjęć));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijZdjęcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeOPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maksymalizacjaOknaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimalizacjaOknaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dopasujZdjęcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tylkoZdjęcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeOProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDol = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonZdjNastep = new System.Windows.Forms.Button();
            this.buttonZdjPoprze = new System.Windows.Forms.Button();
            this.panelGora = new System.Windows.Forms.Panel();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.textBoxInfoFile = new System.Windows.Forms.TextBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonF_Open = new System.Windows.Forms.Button();
            this.panelOther = new System.Windows.Forms.Panel();
            this.buttonExitOther = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonOdswiez = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDol.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelGora.SuspendLayout();
            this.panelFiles.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelOther.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1030, 55);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Tag = "MainePanel";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Wybierz plik obrazu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zamknijZdjęcieToolStripMenuItem,
            this.informacjeOPlikuToolStripMenuItem,
            this.toolStripSeparator1,
            this.zamknijToolStripMenuItem,
            this.testToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zamknijZdjęcieToolStripMenuItem
            // 
            this.zamknijZdjęcieToolStripMenuItem.Name = "zamknijZdjęcieToolStripMenuItem";
            this.zamknijZdjęcieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.zamknijZdjęcieToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.zamknijZdjęcieToolStripMenuItem.Text = "Zamknij zdjęcie";
            this.zamknijZdjęcieToolStripMenuItem.Click += new System.EventHandler(this.zamknijZdjęcieToolStripMenuItem_Click);
            // 
            // informacjeOPlikuToolStripMenuItem
            // 
            this.informacjeOPlikuToolStripMenuItem.Name = "informacjeOPlikuToolStripMenuItem";
            this.informacjeOPlikuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.informacjeOPlikuToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.informacjeOPlikuToolStripMenuItem.Text = "Informacje o pliku";
            this.informacjeOPlikuToolStripMenuItem.Click += new System.EventHandler(this.informacjeOPlikuToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij program";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.testToolStripMenuItem.Text = "Otwórz inaczej";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maksymalizacjaOknaToolStripMenuItem,
            this.minimalizacjaOknaToolStripMenuItem,
            this.dopasujZdjęcieToolStripMenuItem,
            this.sizeModeToolStripMenuItem,
            this.tylkoZdjęcieToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.obrocToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // maksymalizacjaOknaToolStripMenuItem
            // 
            this.maksymalizacjaOknaToolStripMenuItem.Name = "maksymalizacjaOknaToolStripMenuItem";
            this.maksymalizacjaOknaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.maksymalizacjaOknaToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.maksymalizacjaOknaToolStripMenuItem.Text = "Maksymalizacja okna";
            this.maksymalizacjaOknaToolStripMenuItem.Click += new System.EventHandler(this.maksymalizacjaOknaToolStripMenuItem_Click);
            // 
            // minimalizacjaOknaToolStripMenuItem
            // 
            this.minimalizacjaOknaToolStripMenuItem.Name = "minimalizacjaOknaToolStripMenuItem";
            this.minimalizacjaOknaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.minimalizacjaOknaToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.minimalizacjaOknaToolStripMenuItem.Text = "Minimalizacja okna";
            this.minimalizacjaOknaToolStripMenuItem.Click += new System.EventHandler(this.minimalizacjaOknaToolStripMenuItem_Click);
            // 
            // dopasujZdjęcieToolStripMenuItem
            // 
            this.dopasujZdjęcieToolStripMenuItem.CheckOnClick = true;
            this.dopasujZdjęcieToolStripMenuItem.Name = "dopasujZdjęcieToolStripMenuItem";
            this.dopasujZdjęcieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dopasujZdjęcieToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.dopasujZdjęcieToolStripMenuItem.Text = "Dopasuj zdjęcie";
            this.dopasujZdjęcieToolStripMenuItem.ToolTipText = "Dopasuj obraz do rozmiaru okna pragramu";
            this.dopasujZdjęcieToolStripMenuItem.Click += new System.EventHandler(this.dopasujZdjęcieToolStripMenuItem_Click);
            // 
            // sizeModeToolStripMenuItem
            // 
            this.sizeModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.stretchImageToolStripMenuItem,
            this.autoSizeToolStripMenuItem,
            this.centerImageToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.sizeModeToolStripMenuItem.Name = "sizeModeToolStripMenuItem";
            this.sizeModeToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.sizeModeToolStripMenuItem.Text = "SizeMode";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // stretchImageToolStripMenuItem
            // 
            this.stretchImageToolStripMenuItem.Name = "stretchImageToolStripMenuItem";
            this.stretchImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stretchImageToolStripMenuItem.Text = "StretchImage";
            this.stretchImageToolStripMenuItem.Click += new System.EventHandler(this.stretchImageToolStripMenuItem_Click);
            // 
            // autoSizeToolStripMenuItem
            // 
            this.autoSizeToolStripMenuItem.Name = "autoSizeToolStripMenuItem";
            this.autoSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoSizeToolStripMenuItem.Text = "AutoSize";
            this.autoSizeToolStripMenuItem.Click += new System.EventHandler(this.autoSizeToolStripMenuItem_Click);
            // 
            // centerImageToolStripMenuItem
            // 
            this.centerImageToolStripMenuItem.Name = "centerImageToolStripMenuItem";
            this.centerImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.centerImageToolStripMenuItem.Text = "CenterImage";
            this.centerImageToolStripMenuItem.Click += new System.EventHandler(this.centerImageToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // tylkoZdjęcieToolStripMenuItem
            // 
            this.tylkoZdjęcieToolStripMenuItem.Name = "tylkoZdjęcieToolStripMenuItem";
            this.tylkoZdjęcieToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.tylkoZdjęcieToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.tylkoZdjęcieToolStripMenuItem.Text = "Tylko zdjęcie";
            this.tylkoZdjęcieToolStripMenuItem.Click += new System.EventHandler(this.tylkoZdjęcieToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.resetToolStripMenuItem.Text = "Reset ustawień";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // obrocToolStripMenuItem
            // 
            this.obrocToolStripMenuItem.Name = "obrocToolStripMenuItem";
            this.obrocToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.obrocToolStripMenuItem.Text = "Obróć";
            this.obrocToolStripMenuItem.Click += new System.EventHandler(this.obrocToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjeOProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // informacjeOProgramieToolStripMenuItem
            // 
            this.informacjeOProgramieToolStripMenuItem.Name = "informacjeOProgramieToolStripMenuItem";
            this.informacjeOProgramieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.informacjeOProgramieToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.informacjeOProgramieToolStripMenuItem.Text = "Informacje o programie";
            this.informacjeOProgramieToolStripMenuItem.Click += new System.EventHandler(this.informacjeOProgramieToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 55);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1030, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panelDol
            // 
            this.panelDol.Controls.Add(this.panel2);
            this.panelDol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDol.Location = new System.Drawing.Point(0, 481);
            this.panelDol.Name = "panelDol";
            this.panelDol.Size = new System.Drawing.Size(1030, 55);
            this.panelDol.TabIndex = 2;
            this.panelDol.Tag = "MainePanel";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonZdjNastep);
            this.panel3.Controls.Add(this.buttonZdjPoprze);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panelGora);
            this.panel3.Controls.Add(this.panelDol);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 536);
            this.panel3.TabIndex = 3;
            // 
            // buttonZdjNastep
            // 
            this.buttonZdjNastep.BackColor = System.Drawing.Color.Transparent;
            this.buttonZdjNastep.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonZdjNastep.FlatAppearance.BorderSize = 0;
            this.buttonZdjNastep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonZdjNastep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZdjNastep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZdjNastep.ForeColor = System.Drawing.Color.White;
            this.buttonZdjNastep.Location = new System.Drawing.Point(981, 44);
            this.buttonZdjNastep.Name = "buttonZdjNastep";
            this.buttonZdjNastep.Size = new System.Drawing.Size(49, 437);
            this.buttonZdjNastep.TabIndex = 6;
            this.buttonZdjNastep.Text = ">";
            this.buttonZdjNastep.UseVisualStyleBackColor = false;
            this.buttonZdjNastep.Visible = false;
            // 
            // buttonZdjPoprze
            // 
            this.buttonZdjPoprze.BackColor = System.Drawing.Color.Transparent;
            this.buttonZdjPoprze.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonZdjPoprze.FlatAppearance.BorderSize = 0;
            this.buttonZdjPoprze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonZdjPoprze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZdjPoprze.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZdjPoprze.ForeColor = System.Drawing.Color.White;
            this.buttonZdjPoprze.Location = new System.Drawing.Point(0, 44);
            this.buttonZdjPoprze.Name = "buttonZdjPoprze";
            this.buttonZdjPoprze.Size = new System.Drawing.Size(49, 437);
            this.buttonZdjPoprze.TabIndex = 5;
            this.buttonZdjPoprze.Text = "<";
            this.buttonZdjPoprze.UseVisualStyleBackColor = false;
            this.buttonZdjPoprze.Visible = false;
            // 
            // panelGora
            // 
            this.panelGora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelGora.Controls.Add(this.menuStrip1);
            this.panelGora.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGora.Location = new System.Drawing.Point(0, 0);
            this.panelGora.Name = "panelGora";
            this.panelGora.Size = new System.Drawing.Size(1030, 44);
            this.panelGora.TabIndex = 4;
            this.panelGora.Tag = "MainePanel";
            // 
            // panelFiles
            // 
            this.panelFiles.Controls.Add(this.buttonOdswiez);
            this.panelFiles.Controls.Add(this.textBoxInfoFile);
            this.panelFiles.Controls.Add(this.panelLeft);
            this.panelFiles.Controls.Add(this.buttonF_Open);
            this.panelFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFiles.Location = new System.Drawing.Point(0, 0);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(1030, 536);
            this.panelFiles.TabIndex = 5;
            // 
            // textBoxInfoFile
            // 
            this.textBoxInfoFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textBoxInfoFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxInfoFile.ForeColor = System.Drawing.Color.White;
            this.textBoxInfoFile.Location = new System.Drawing.Point(390, 384);
            this.textBoxInfoFile.Multiline = true;
            this.textBoxInfoFile.Name = "textBoxInfoFile";
            this.textBoxInfoFile.ReadOnly = true;
            this.textBoxInfoFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInfoFile.Size = new System.Drawing.Size(640, 152);
            this.textBoxInfoFile.TabIndex = 3;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.listView1);
            this.panelLeft.Controls.Add(this.flowLayoutPanel2);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(390, 536);
            this.panelLeft.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.Color.Black;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 17);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(390, 519);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 410;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podgląd folderu Zdjęcia";
            // 
            // buttonF_Open
            // 
            this.buttonF_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonF_Open.ForeColor = System.Drawing.Color.White;
            this.buttonF_Open.Location = new System.Drawing.Point(420, 17);
            this.buttonF_Open.Name = "buttonF_Open";
            this.buttonF_Open.Size = new System.Drawing.Size(132, 40);
            this.buttonF_Open.TabIndex = 2;
            this.buttonF_Open.Text = "Otwórz plik";
            this.buttonF_Open.UseVisualStyleBackColor = true;
            this.buttonF_Open.Click += new System.EventHandler(this.buttonF_Open_Click);
            // 
            // panelOther
            // 
            this.panelOther.Controls.Add(this.buttonExitOther);
            this.panelOther.Controls.Add(this.webBrowser1);
            this.panelOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOther.Location = new System.Drawing.Point(0, 0);
            this.panelOther.Name = "panelOther";
            this.panelOther.Size = new System.Drawing.Size(1030, 536);
            this.panelOther.TabIndex = 5;
            // 
            // buttonExitOther
            // 
            this.buttonExitOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExitOther.Location = new System.Drawing.Point(0, 0);
            this.buttonExitOther.Name = "buttonExitOther";
            this.buttonExitOther.Size = new System.Drawing.Size(1030, 23);
            this.buttonExitOther.TabIndex = 1;
            this.buttonExitOther.Text = "Powrót";
            this.buttonExitOther.UseVisualStyleBackColor = true;
            this.buttonExitOther.Click += new System.EventHandler(this.buttonExitOther_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1030, 536);
            this.webBrowser1.TabIndex = 0;
            // 
            // buttonOdswiez
            // 
            this.buttonOdswiez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOdswiez.ForeColor = System.Drawing.Color.White;
            this.buttonOdswiez.Location = new System.Drawing.Point(420, 81);
            this.buttonOdswiez.Name = "buttonOdswiez";
            this.buttonOdswiez.Size = new System.Drawing.Size(132, 40);
            this.buttonOdswiez.TabIndex = 5;
            this.buttonOdswiez.Text = "Odswież";
            this.buttonOdswiez.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 17);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(390, 519);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(365, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Przeglądarka_zdjęć
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1030, 536);
            this.Controls.Add(this.panelFiles);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelOther);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Przeglądarka_zdjęć";
            this.Text = "Przeglądarka zdjęć";
            this.Load += new System.EventHandler(this.Przeglądarka_zdjęć_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Przeglądarka_zdjęć_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Przeglądarka_zdjęć_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDol.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelGora.ResumeLayout(false);
            this.panelGora.PerformLayout();
            this.panelFiles.ResumeLayout(false);
            this.panelFiles.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelOther.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijZdjęcieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeOProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maksymalizacjaOknaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimalizacjaOknaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeOPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem dopasujZdjęcieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem tylkoZdjęcieToolStripMenuItem;
        private System.Windows.Forms.Panel panelDol;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelGora;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrocToolStripMenuItem;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonF_Open;
        private System.Windows.Forms.TextBox textBoxInfoFile;
        private System.Windows.Forms.Button buttonZdjPoprze;
        private System.Windows.Forms.Button buttonZdjNastep;
        private System.Windows.Forms.Panel panelOther;
        private System.Windows.Forms.Button buttonExitOther;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonOdswiez;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

