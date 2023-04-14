namespace WindowsFormsApp1
{
    partial class CringeForm 
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CringeForm));
            this.materialScrollBar1 = new MaterialSkin.Controls.MaterialScrollBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Reservations = new System.Windows.Forms.TabPage();
            this.Salle = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TestBtn = new System.Windows.Forms.Button();
            this.TextBoxNPlat = new System.Windows.Forms.TextBox();
            this.TextBoxDPPlat = new System.Windows.Forms.TextBox();
            this.TextBoxPPlat = new System.Windows.Forms.TextBox();
            this.ComboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Plat = new System.Windows.Forms.TabPage();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton6 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton5 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton4 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.Commande = new System.Windows.Forms.TabPage();
            this.Dashboard = new System.Windows.Forms.TabPage();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialDrawer2 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialDrawer3 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialDrawer4 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialDrawer6 = new MaterialSkin.Controls.MaterialDrawer();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.Fournisseur = new MaterialSkin.Controls.MaterialTabControl();
            this.Carte = new System.Windows.Forms.TabPage();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Plat.SuspendLayout();
            this.materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Dashboard.SuspendLayout();
            this.Fournisseur.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialScrollBar1
            // 
            this.materialScrollBar1.Depth = 0;
            this.materialScrollBar1.Location = new System.Drawing.Point(798, 52);
            this.materialScrollBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialScrollBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialScrollBar1.Name = "materialScrollBar1";
            this.materialScrollBar1.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Vertical;
            this.materialScrollBar1.ScrollbarSize = 8;
            this.materialScrollBar1.Size = new System.Drawing.Size(8, 444);
            this.materialScrollBar1.TabIndex = 4;
            this.materialScrollBar1.Text = "materialScrollBar1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(428, 411);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "Test";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-cutlery-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-delivery-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-home-page-32.png");
            this.imageList1.Images.SetKeyName(3, "icons8-marketing-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-plate-32.png");
            this.imageList1.Images.SetKeyName(5, "icons8-timeline-week-32.png");
            this.imageList1.Images.SetKeyName(6, "icons8-plus-math-30.png");
            this.imageList1.Images.SetKeyName(7, "FR_PSVY_fr_menu_9172.png");
            this.imageList1.Images.SetKeyName(8, "icons8-sofa-50.png");
            this.imageList1.Images.SetKeyName(9, "icons8-restaurant-menu-64.png");
            // 
            // Reservations
            // 
            this.Reservations.ImageKey = "icons8-timeline-week-32.png";
            this.Reservations.Location = new System.Drawing.Point(4, 39);
            this.Reservations.Name = "Reservations";
            this.Reservations.Padding = new System.Windows.Forms.Padding(3);
            this.Reservations.Size = new System.Drawing.Size(874, 797);
            this.Reservations.TabIndex = 6;
            this.Reservations.Text = "Reservations";
            this.Reservations.UseVisualStyleBackColor = true;
            // 
            // Salle
            // 
            this.Salle.ImageKey = "icons8-sofa-50.png";
            this.Salle.Location = new System.Drawing.Point(4, 39);
            this.Salle.Name = "Salle";
            this.Salle.Padding = new System.Windows.Forms.Padding(3);
            this.Salle.Size = new System.Drawing.Size(874, 797);
            this.Salle.TabIndex = 5;
            this.Salle.Text = "Salle";
            this.Salle.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.DeleteBtn);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.ComboBoxCategorie);
            this.tabPage4.Controls.Add(this.TextBoxPPlat);
            this.tabPage4.Controls.Add(this.TextBoxDPPlat);
            this.tabPage4.Controls.Add(this.TextBoxNPlat);
            this.tabPage4.Controls.Add(this.TestBtn);
            this.tabPage4.ImageKey = "icons8-delivery-32.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(874, 797);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Fournisseur";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // TestBtn
            // 
            this.TestBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TestBtn.Location = new System.Drawing.Point(0, 774);
            this.TestBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(874, 23);
            this.TestBtn.TabIndex = 0;
            this.TestBtn.Text = "TestBtn";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // TextBoxNPlat
            // 
            this.TextBoxNPlat.Location = new System.Drawing.Point(284, 110);
            this.TextBoxNPlat.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxNPlat.Name = "TextBoxNPlat";
            this.TextBoxNPlat.Size = new System.Drawing.Size(76, 20);
            this.TextBoxNPlat.TabIndex = 1;
            // 
            // TextBoxDPPlat
            // 
            this.TextBoxDPPlat.Location = new System.Drawing.Point(423, 110);
            this.TextBoxDPPlat.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxDPPlat.Name = "TextBoxDPPlat";
            this.TextBoxDPPlat.Size = new System.Drawing.Size(76, 20);
            this.TextBoxDPPlat.TabIndex = 2;
            // 
            // TextBoxPPlat
            // 
            this.TextBoxPPlat.Location = new System.Drawing.Point(565, 110);
            this.TextBoxPPlat.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPPlat.Name = "TextBoxPPlat";
            this.TextBoxPPlat.Size = new System.Drawing.Size(76, 20);
            this.TextBoxPPlat.TabIndex = 3;
            // 
            // ComboBoxCategorie
            // 
            this.ComboBoxCategorie.FormattingEnabled = true;
            this.ComboBoxCategorie.Location = new System.Drawing.Point(681, 110);
            this.ComboBoxCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxCategorie.Name = "ComboBoxCategorie";
            this.ComboBoxCategorie.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxCategorie.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 184);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 362);
            this.dataGridView1.TabIndex = 5;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(694, 278);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(56, 19);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "button1";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "prix";
            // 
            // Plat
            // 
            this.Plat.Controls.Add(this.materialFloatingActionButton4);
            this.Plat.Controls.Add(this.materialCard4);
            this.Plat.Controls.Add(this.materialFloatingActionButton5);
            this.Plat.Controls.Add(this.materialCard5);
            this.Plat.Controls.Add(this.materialFloatingActionButton6);
            this.Plat.Controls.Add(this.materialCard6);
            this.Plat.ImageKey = "icons8-cutlery-32.png";
            this.Plat.Location = new System.Drawing.Point(4, 39);
            this.Plat.Margin = new System.Windows.Forms.Padding(2);
            this.Plat.Name = "Plat";
            this.Plat.Size = new System.Drawing.Size(874, 797);
            this.Plat.TabIndex = 2;
            this.Plat.Text = "Plat";
            this.Plat.UseVisualStyleBackColor = true;
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.materialCard6.Controls.Add(this.materialLabel11);
            this.materialCard6.Controls.Add(this.materialLabel12);
            this.materialCard6.Controls.Add(this.pictureBox6);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(57, 39);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard6.Size = new System.Drawing.Size(168, 122);
            this.materialCard6.TabIndex = 14;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.FR_PSVY_fr_menu_9172;
            this.pictureBox6.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(169, 125);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(13, 11);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(87, 19);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "Pizza based";
            this.materialLabel12.UseWaitCursor = true;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(133, 93);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(28, 19);
            this.materialLabel11.TabIndex = 1;
            this.materialLabel11.Text = "18€";
            // 
            // materialFloatingActionButton6
            // 
            this.materialFloatingActionButton6.Depth = 0;
            this.materialFloatingActionButton6.Icon = global::WindowsFormsApp1.Properties.Resources.icons8_plus_math_30;
            this.materialFloatingActionButton6.ImageKey = "icons8-plus-math-30.png";
            this.materialFloatingActionButton6.ImageList = this.imageList1;
            this.materialFloatingActionButton6.Location = new System.Drawing.Point(212, 81);
            this.materialFloatingActionButton6.Margin = new System.Windows.Forms.Padding(2);
            this.materialFloatingActionButton6.Mini = true;
            this.materialFloatingActionButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton6.Name = "materialFloatingActionButton6";
            this.materialFloatingActionButton6.Size = new System.Drawing.Size(30, 32);
            this.materialFloatingActionButton6.TabIndex = 13;
            this.materialFloatingActionButton6.Text = "materialFloatingActionButton6";
            this.materialFloatingActionButton6.UseVisualStyleBackColor = false;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.materialCard5.Controls.Add(this.materialLabel9);
            this.materialCard5.Controls.Add(this.materialLabel10);
            this.materialCard5.Controls.Add(this.pictureBox5);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(280, 39);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard5.Size = new System.Drawing.Size(168, 122);
            this.materialCard5.TabIndex = 16;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.FR_PSVY_fr_menu_9172;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(169, 125);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(13, 11);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(87, 19);
            this.materialLabel10.TabIndex = 0;
            this.materialLabel10.Text = "Pizza based";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(133, 93);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(28, 19);
            this.materialLabel9.TabIndex = 1;
            this.materialLabel9.Text = "18€";
            // 
            // materialFloatingActionButton5
            // 
            this.materialFloatingActionButton5.Depth = 0;
            this.materialFloatingActionButton5.Icon = global::WindowsFormsApp1.Properties.Resources.icons8_plus_math_30;
            this.materialFloatingActionButton5.ImageKey = "icons8-plus-math-30.png";
            this.materialFloatingActionButton5.ImageList = this.imageList1;
            this.materialFloatingActionButton5.Location = new System.Drawing.Point(437, 81);
            this.materialFloatingActionButton5.Margin = new System.Windows.Forms.Padding(2);
            this.materialFloatingActionButton5.Mini = true;
            this.materialFloatingActionButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton5.Name = "materialFloatingActionButton5";
            this.materialFloatingActionButton5.Size = new System.Drawing.Size(30, 32);
            this.materialFloatingActionButton5.TabIndex = 15;
            this.materialFloatingActionButton5.Text = "materialFloatingActionButton5";
            this.materialFloatingActionButton5.UseVisualStyleBackColor = false;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.materialCard4.Controls.Add(this.materialLabel7);
            this.materialCard4.Controls.Add(this.materialLabel8);
            this.materialCard4.Controls.Add(this.pictureBox4);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(515, 39);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard4.Size = new System.Drawing.Size(168, 122);
            this.materialCard4.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.FR_PSVY_fr_menu_9172;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(169, 125);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(13, 11);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(87, 19);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "Pizza based";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(133, 93);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(28, 19);
            this.materialLabel7.TabIndex = 1;
            this.materialLabel7.Text = "18€";
            // 
            // materialFloatingActionButton4
            // 
            this.materialFloatingActionButton4.Depth = 0;
            this.materialFloatingActionButton4.Icon = global::WindowsFormsApp1.Properties.Resources.icons8_plus_math_30;
            this.materialFloatingActionButton4.ImageKey = "icons8-plus-math-30.png";
            this.materialFloatingActionButton4.ImageList = this.imageList1;
            this.materialFloatingActionButton4.Location = new System.Drawing.Point(673, 86);
            this.materialFloatingActionButton4.Margin = new System.Windows.Forms.Padding(2);
            this.materialFloatingActionButton4.Mini = true;
            this.materialFloatingActionButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton4.Name = "materialFloatingActionButton4";
            this.materialFloatingActionButton4.Size = new System.Drawing.Size(30, 32);
            this.materialFloatingActionButton4.TabIndex = 17;
            this.materialFloatingActionButton4.Text = "materialFloatingActionButton4";
            this.materialFloatingActionButton4.UseVisualStyleBackColor = false;
            // 
            // Commande
            // 
            this.Commande.ImageKey = "icons8-plate-32.png";
            this.Commande.Location = new System.Drawing.Point(4, 39);
            this.Commande.Margin = new System.Windows.Forms.Padding(2);
            this.Commande.Name = "Commande";
            this.Commande.Padding = new System.Windows.Forms.Padding(2);
            this.Commande.Size = new System.Drawing.Size(874, 797);
            this.Commande.TabIndex = 1;
            this.Commande.Text = "Prise de commande";
            this.Commande.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.Dashboard.Controls.Add(this.elementHost1);
            this.Dashboard.Controls.Add(this.materialDrawer6);
            this.Dashboard.Controls.Add(this.materialDrawer4);
            this.Dashboard.Controls.Add(this.materialDrawer3);
            this.Dashboard.Controls.Add(this.materialDrawer2);
            this.Dashboard.Controls.Add(this.materialDrawer1);
            this.Dashboard.ImageKey = "icons8-home-page-32.png";
            this.Dashboard.Location = new System.Drawing.Point(4, 39);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(2);
            this.Dashboard.Size = new System.Drawing.Size(874, 797);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-188, 31);
            this.materialDrawer1.Margin = new System.Windows.Forms.Padding(2);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(188, 98);
            this.materialDrawer1.TabIndex = 0;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // materialDrawer2
            // 
            this.materialDrawer2.AutoHide = false;
            this.materialDrawer2.AutoShow = false;
            this.materialDrawer2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.FR_PSVY_fr_menu_9172;
            this.materialDrawer2.BackgroundWithAccent = false;
            this.materialDrawer2.BaseTabControl = null;
            this.materialDrawer2.Depth = 0;
            this.materialDrawer2.HighlightWithAccent = true;
            this.materialDrawer2.IndicatorWidth = 0;
            this.materialDrawer2.IsOpen = false;
            this.materialDrawer2.Location = new System.Drawing.Point(-188, 110);
            this.materialDrawer2.Margin = new System.Windows.Forms.Padding(2);
            this.materialDrawer2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer2.Name = "materialDrawer2";
            this.materialDrawer2.ShowIconsWhenHidden = false;
            this.materialDrawer2.Size = new System.Drawing.Size(188, 98);
            this.materialDrawer2.TabIndex = 2;
            this.materialDrawer2.Text = "materialDrawer2";
            this.materialDrawer2.UseColors = false;
            // 
            // materialDrawer3
            // 
            this.materialDrawer3.AutoHide = false;
            this.materialDrawer3.AutoShow = false;
            this.materialDrawer3.BackgroundWithAccent = false;
            this.materialDrawer3.BaseTabControl = null;
            this.materialDrawer3.Depth = 0;
            this.materialDrawer3.HighlightWithAccent = true;
            this.materialDrawer3.IndicatorWidth = 0;
            this.materialDrawer3.IsOpen = false;
            this.materialDrawer3.Location = new System.Drawing.Point(-188, 110);
            this.materialDrawer3.Margin = new System.Windows.Forms.Padding(2);
            this.materialDrawer3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer3.Name = "materialDrawer3";
            this.materialDrawer3.ShowIconsWhenHidden = false;
            this.materialDrawer3.Size = new System.Drawing.Size(188, 98);
            this.materialDrawer3.TabIndex = 3;
            this.materialDrawer3.Text = "materialDrawer3";
            this.materialDrawer3.UseColors = false;
            // 
            // materialDrawer4
            // 
            this.materialDrawer4.AutoHide = false;
            this.materialDrawer4.AutoShow = false;
            this.materialDrawer4.BackgroundWithAccent = false;
            this.materialDrawer4.BaseTabControl = null;
            this.materialDrawer4.Depth = 0;
            this.materialDrawer4.HighlightWithAccent = true;
            this.materialDrawer4.IndicatorWidth = 0;
            this.materialDrawer4.IsOpen = false;
            this.materialDrawer4.Location = new System.Drawing.Point(-188, 40);
            this.materialDrawer4.Margin = new System.Windows.Forms.Padding(2);
            this.materialDrawer4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer4.Name = "materialDrawer4";
            this.materialDrawer4.ShowIconsWhenHidden = false;
            this.materialDrawer4.Size = new System.Drawing.Size(188, 98);
            this.materialDrawer4.TabIndex = 4;
            this.materialDrawer4.Text = "materialDrawer4";
            this.materialDrawer4.UseColors = false;
            // 
            // materialDrawer6
            // 
            this.materialDrawer6.AutoHide = false;
            this.materialDrawer6.AutoShow = false;
            this.materialDrawer6.BackgroundWithAccent = false;
            this.materialDrawer6.BaseTabControl = null;
            this.materialDrawer6.Depth = 0;
            this.materialDrawer6.HighlightWithAccent = true;
            this.materialDrawer6.IndicatorWidth = 0;
            this.materialDrawer6.IsOpen = false;
            this.materialDrawer6.Location = new System.Drawing.Point(-188, 138);
            this.materialDrawer6.Margin = new System.Windows.Forms.Padding(2);
            this.materialDrawer6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer6.Name = "materialDrawer6";
            this.materialDrawer6.ShowIconsWhenHidden = false;
            this.materialDrawer6.Size = new System.Drawing.Size(188, 98);
            this.materialDrawer6.TabIndex = 7;
            this.materialDrawer6.Text = "materialDrawer6";
            this.materialDrawer6.UseColors = false;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(214, 37);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(2);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(316, 304);
            this.elementHost1.TabIndex = 8;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.pieChart1;
            // 
            // Fournisseur
            // 
            this.Fournisseur.Controls.Add(this.Dashboard);
            this.Fournisseur.Controls.Add(this.Commande);
            this.Fournisseur.Controls.Add(this.Plat);
            this.Fournisseur.Controls.Add(this.tabPage4);
            this.Fournisseur.Controls.Add(this.Salle);
            this.Fournisseur.Controls.Add(this.Reservations);
            this.Fournisseur.Controls.Add(this.Carte);
            this.Fournisseur.Depth = 0;
            this.Fournisseur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fournisseur.ImageList = this.imageList1;
            this.Fournisseur.Location = new System.Drawing.Point(2, 52);
            this.Fournisseur.Margin = new System.Windows.Forms.Padding(2);
            this.Fournisseur.MouseState = MaterialSkin.MouseState.HOVER;
            this.Fournisseur.Multiline = true;
            this.Fournisseur.Name = "Fournisseur";
            this.Fournisseur.SelectedIndex = 0;
            this.Fournisseur.Size = new System.Drawing.Size(882, 840);
            this.Fournisseur.TabIndex = 7;
            // 
            // Carte
            // 
            this.Carte.ImageKey = "icons8-restaurant-menu-64.png";
            this.Carte.Location = new System.Drawing.Point(4, 39);
            this.Carte.Name = "Carte";
            this.Carte.Padding = new System.Windows.Forms.Padding(3);
            this.Carte.Size = new System.Drawing.Size(874, 797);
            this.Carte.TabIndex = 7;
            this.Carte.Text = "Carte";
            this.Carte.UseVisualStyleBackColor = true;
            // 
            // CringeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.logoResto;
            this.ClientSize = new System.Drawing.Size(886, 894);
            this.Controls.Add(this.Fournisseur);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialScrollBar1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.Fournisseur;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CringeForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Plat.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Dashboard.ResumeLayout(false);
            this.Fournisseur.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage Reservations;
        private System.Windows.Forms.TabPage Salle;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ComboBoxCategorie;
        private System.Windows.Forms.TextBox TextBoxPPlat;
        private System.Windows.Forms.TextBox TextBoxDPPlat;
        private System.Windows.Forms.TextBox TextBoxNPlat;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.TabPage Plat;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton4;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton5;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton6;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TabPage Commande;
        private System.Windows.Forms.TabPage Dashboard;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.PieChart pieChart1;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer6;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer4;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer3;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer2;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialTabControl Fournisseur;
        private System.Windows.Forms.TabPage Carte;
    }
}

