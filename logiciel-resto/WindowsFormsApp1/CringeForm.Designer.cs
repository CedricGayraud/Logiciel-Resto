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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.materialDrawer6 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialDrawer4 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialDrawer3 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialDrawer2 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialFloatingActionButton4 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.materialFloatingActionButton5 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.materialFloatingActionButton6 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Planning = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // materialScrollBar1
            // 
            this.materialScrollBar1.Depth = 0;
            this.materialScrollBar1.Location = new System.Drawing.Point(1064, 64);
            this.materialScrollBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialScrollBar1.Name = "materialScrollBar1";
            this.materialScrollBar1.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Vertical;
            this.materialScrollBar1.Size = new System.Drawing.Size(10, 546);
            this.materialScrollBar1.TabIndex = 4;
            this.materialScrollBar1.Text = "materialScrollBar1";
            // 
            // contextMenuStrip1
            // 
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
            this.materialButton1.Location = new System.Drawing.Point(571, 506);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.Planning);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1068, 503);
            this.materialTabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.elementHost1);
            this.tabPage1.Controls.Add(this.materialDrawer6);
            this.tabPage1.Controls.Add(this.materialDrawer4);
            this.tabPage1.Controls.Add(this.materialDrawer3);
            this.tabPage1.Controls.Add(this.materialDrawer2);
            this.tabPage1.Controls.Add(this.materialDrawer1);
            this.tabPage1.ImageKey = "icons8-home-page-32.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1060, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(285, 46);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(421, 374);
            this.elementHost1.TabIndex = 8;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.pieChart1;
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
            this.materialDrawer6.Location = new System.Drawing.Point(-250, 170);
            this.materialDrawer6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer6.Name = "materialDrawer6";
            this.materialDrawer6.ShowIconsWhenHidden = false;
            this.materialDrawer6.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer6.TabIndex = 7;
            this.materialDrawer6.Text = "materialDrawer6";
            this.materialDrawer6.UseColors = false;
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
            this.materialDrawer4.Location = new System.Drawing.Point(-250, 49);
            this.materialDrawer4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer4.Name = "materialDrawer4";
            this.materialDrawer4.ShowIconsWhenHidden = false;
            this.materialDrawer4.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer4.TabIndex = 4;
            this.materialDrawer4.Text = "materialDrawer4";
            this.materialDrawer4.UseColors = false;
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
            this.materialDrawer3.Location = new System.Drawing.Point(-250, 136);
            this.materialDrawer3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer3.Name = "materialDrawer3";
            this.materialDrawer3.ShowIconsWhenHidden = false;
            this.materialDrawer3.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer3.TabIndex = 3;
            this.materialDrawer3.Text = "materialDrawer3";
            this.materialDrawer3.UseColors = false;
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
            this.materialDrawer2.Location = new System.Drawing.Point(-250, 135);
            this.materialDrawer2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer2.Name = "materialDrawer2";
            this.materialDrawer2.ShowIconsWhenHidden = false;
            this.materialDrawer2.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer2.TabIndex = 2;
            this.materialDrawer2.Text = "materialDrawer2";
            this.materialDrawer2.UseColors = false;
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
            this.materialDrawer1.Location = new System.Drawing.Point(-250, 38);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer1.TabIndex = 0;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "icons8-plate-32.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1060, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Menu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialFloatingActionButton4);
            this.tabPage3.Controls.Add(this.materialCard4);
            this.tabPage3.Controls.Add(this.materialFloatingActionButton5);
            this.tabPage3.Controls.Add(this.materialCard5);
            this.tabPage3.Controls.Add(this.materialFloatingActionButton6);
            this.tabPage3.Controls.Add(this.materialCard6);
            this.tabPage3.ImageKey = "icons8-cutlery-32.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1060, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Plat";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton4
            // 
            this.materialFloatingActionButton4.Depth = 0;
            this.materialFloatingActionButton4.Icon = global::WindowsFormsApp1.Properties.Resources.icons8_plus_math_30;
            this.materialFloatingActionButton4.ImageKey = "icons8-plus-math-30.png";
            this.materialFloatingActionButton4.ImageList = this.imageList1;
            this.materialFloatingActionButton4.Location = new System.Drawing.Point(897, 106);
            this.materialFloatingActionButton4.Mini = true;
            this.materialFloatingActionButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton4.Name = "materialFloatingActionButton4";
            this.materialFloatingActionButton4.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButton4.TabIndex = 17;
            this.materialFloatingActionButton4.Text = "materialFloatingActionButton4";
            this.materialFloatingActionButton4.UseVisualStyleBackColor = false;
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
            this.materialCard4.Location = new System.Drawing.Point(687, 48);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(224, 150);
            this.materialCard4.TabIndex = 18;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(177, 115);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(28, 19);
            this.materialLabel7.TabIndex = 1;
            this.materialLabel7.Text = "18€";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(17, 14);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(87, 19);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "Pizza based";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.FR_PSVY_fr_menu_9172;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(225, 154);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // materialFloatingActionButton5
            // 
            this.materialFloatingActionButton5.Depth = 0;
            this.materialFloatingActionButton5.Icon = global::WindowsFormsApp1.Properties.Resources.icons8_plus_math_30;
            this.materialFloatingActionButton5.ImageKey = "icons8-plus-math-30.png";
            this.materialFloatingActionButton5.ImageList = this.imageList1;
            this.materialFloatingActionButton5.Location = new System.Drawing.Point(583, 106);
            this.materialFloatingActionButton5.Mini = true;
            this.materialFloatingActionButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton5.Name = "materialFloatingActionButton5";
            this.materialFloatingActionButton5.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButton5.TabIndex = 15;
            this.materialFloatingActionButton5.Text = "materialFloatingActionButton5";
            this.materialFloatingActionButton5.UseVisualStyleBackColor = false;
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
            this.materialCard5.Location = new System.Drawing.Point(373, 48);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(224, 150);
            this.materialCard5.TabIndex = 16;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(177, 115);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(28, 19);
            this.materialLabel9.TabIndex = 1;
            this.materialLabel9.Text = "18€";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(17, 14);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(87, 19);
            this.materialLabel10.TabIndex = 0;
            this.materialLabel10.Text = "Pizza based";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.FR_PSVY_fr_menu_9172;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(225, 154);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // materialFloatingActionButton6
            // 
            this.materialFloatingActionButton6.Depth = 0;
            this.materialFloatingActionButton6.Icon = global::WindowsFormsApp1.Properties.Resources.icons8_plus_math_30;
            this.materialFloatingActionButton6.ImageKey = "icons8-plus-math-30.png";
            this.materialFloatingActionButton6.ImageList = this.imageList1;
            this.materialFloatingActionButton6.Location = new System.Drawing.Point(283, 100);
            this.materialFloatingActionButton6.Mini = true;
            this.materialFloatingActionButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton6.Name = "materialFloatingActionButton6";
            this.materialFloatingActionButton6.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButton6.TabIndex = 13;
            this.materialFloatingActionButton6.Text = "materialFloatingActionButton6";
            this.materialFloatingActionButton6.UseVisualStyleBackColor = false;
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
            this.materialCard6.Location = new System.Drawing.Point(76, 48);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(224, 150);
            this.materialCard6.TabIndex = 14;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(177, 115);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(28, 19);
            this.materialLabel11.TabIndex = 1;
            this.materialLabel11.Text = "18€";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(17, 14);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(87, 19);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "Pizza based";
            this.materialLabel12.UseWaitCursor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.FR_PSVY_fr_menu_9172;
            this.pictureBox6.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(225, 154);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.ImageKey = "icons8-delivery-32.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1060, 460);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Fournisseur";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Planning
            // 
            this.Planning.ImageKey = "icons8-timeline-week-32.png";
            this.Planning.Location = new System.Drawing.Point(4, 39);
            this.Planning.Name = "Planning";
            this.Planning.Size = new System.Drawing.Size(1060, 460);
            this.Planning.TabIndex = 4;
            this.Planning.Text = "Planning";
            this.Planning.UseVisualStyleBackColor = true;
            // 
            // CringeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.logoResto;
            this.ClientSize = new System.Drawing.Size(1074, 570);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialScrollBar1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "CringeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage Planning;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer2;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer6;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer4;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer3;
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
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.PieChart pieChart1;
    }
}

