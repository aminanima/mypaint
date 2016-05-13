namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hexagon = new System.Windows.Forms.Button();
            this.octagon = new System.Windows.Forms.Button();
            this.trapezoid = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button13 = new System.Windows.Forms.Button();
            this.Eraser = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Pencil = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.star = new System.Windows.Forms.Button();
            this.romb = new System.Windows.Forms.Button();
            this.cube = new System.Windows.Forms.Button();
            this.hexagon2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.toolStripSeparator3,
            this.openToolStripMenuItem,
            this.toolStripSeparator4,
            this.saveToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createToolStripMenuItem.BackgroundImage")));
            this.createToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createToolStripMenuItem.Text = "New";
            this.createToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createToolStripMenuItem.Click += new System.EventHandler(this.Create_click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.BackgroundImage")));
            this.openToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open ";
            this.openToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.BackgroundImage")));
            this.saveToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save_click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripSeparator2});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.clearToolStripMenuItem.Text = "Clear ";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(101, 6);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.hexagon2);
            this.panel1.Controls.Add(this.cube);
            this.panel1.Controls.Add(this.romb);
            this.panel1.Controls.Add(this.star);
            this.panel1.Controls.Add(this.hexagon);
            this.panel1.Controls.Add(this.octagon);
            this.panel1.Controls.Add(this.trapezoid);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.Eraser);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.Triangle);
            this.panel1.Controls.Add(this.Rectangle);
            this.panel1.Controls.Add(this.Ellipse);
            this.panel1.Controls.Add(this.Line);
            this.panel1.Controls.Add(this.Pencil);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 434);
            this.panel1.TabIndex = 1;
            // 
            // hexagon
            // 
            this.hexagon.Location = new System.Drawing.Point(264, 57);
            this.hexagon.Name = "hexagon";
            this.hexagon.Size = new System.Drawing.Size(75, 23);
            this.hexagon.TabIndex = 4;
            this.hexagon.Text = "hexagon";
            this.hexagon.UseVisualStyleBackColor = true;
            this.hexagon.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // octagon
            // 
            this.octagon.Location = new System.Drawing.Point(181, 57);
            this.octagon.Name = "octagon";
            this.octagon.Size = new System.Drawing.Size(77, 23);
            this.octagon.TabIndex = 25;
            this.octagon.Text = "octagon";
            this.octagon.UseVisualStyleBackColor = true;
            this.octagon.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // trapezoid
            // 
            this.trapezoid.Location = new System.Drawing.Point(344, 57);
            this.trapezoid.Name = "trapezoid";
            this.trapezoid.Size = new System.Drawing.Size(75, 23);
            this.trapezoid.TabIndex = 24;
            this.trapezoid.Text = "trapezoid";
            this.trapezoid.UseVisualStyleBackColor = true;
            this.trapezoid.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Location = new System.Drawing.Point(241, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 38);
            this.button7.TabIndex = 23;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(378, 22);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(24, 23);
            this.button14.TabIndex = 5;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(93, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 329);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            // 
            // button13
            // 
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(344, 22);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(24, 23);
            this.button13.TabIndex = 4;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Eraser
            // 
            this.Eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eraser.BackgroundImage")));
            this.Eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Eraser.Location = new System.Drawing.Point(408, 14);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(39, 38);
            this.Eraser.TabIndex = 22;
            this.Eraser.UseVisualStyleBackColor = true;
            this.Eraser.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.Location = new System.Drawing.Point(694, 23);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(54, 46);
            this.button12.TabIndex = 21;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.ColorDialog_click);
            // 
            // Triangle
            // 
            this.Triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Triangle.BackgroundImage")));
            this.Triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Triangle.Location = new System.Drawing.Point(151, 15);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(39, 38);
            this.Triangle.TabIndex = 20;
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rectangle.BackgroundImage")));
            this.Rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rectangle.Location = new System.Drawing.Point(196, 15);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(39, 38);
            this.Rectangle.TabIndex = 19;
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ellipse.BackgroundImage")));
            this.Ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ellipse.Location = new System.Drawing.Point(106, 15);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(39, 38);
            this.Ellipse.TabIndex = 18;
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // Line
            // 
            this.Line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Line.BackgroundImage")));
            this.Line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Line.Location = new System.Drawing.Point(61, 15);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(39, 38);
            this.Line.TabIndex = 16;
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // Pencil
            // 
            this.Pencil.BackColor = System.Drawing.SystemColors.Control;
            this.Pencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pencil.BackgroundImage")));
            this.Pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pencil.Location = new System.Drawing.Point(16, 15);
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(39, 38);
            this.Pencil.TabIndex = 15;
            this.Pencil.UseVisualStyleBackColor = true;
            this.Pencil.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Aqua;
            this.button8.Location = new System.Drawing.Point(656, 23);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(23, 22);
            this.button8.TabIndex = 10;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Colors_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Blue;
            this.button10.Location = new System.Drawing.Point(511, 23);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(23, 22);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Colors_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lime;
            this.button6.Location = new System.Drawing.Point(627, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 22);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Colors_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(482, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 22);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Colors_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Location = new System.Drawing.Point(598, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 22);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Colors_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(453, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 22);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Colors_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(569, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 22);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Colors_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(540, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 22);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Colors_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel4,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 464);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(837, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel3.Text = "CursorPosition :";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel1.Text = "{X=0;Y=0}";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabel4.Text = "CurrentShape :";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel2.Text = "Pencil";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // star
            // 
            this.star.Location = new System.Drawing.Point(425, 57);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(75, 23);
            this.star.TabIndex = 26;
            this.star.Text = "star";
            this.star.UseVisualStyleBackColor = true;
            this.star.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // romb
            // 
            this.romb.Location = new System.Drawing.Point(506, 57);
            this.romb.Name = "romb";
            this.romb.Size = new System.Drawing.Size(75, 23);
            this.romb.TabIndex = 27;
            this.romb.Text = "romb";
            this.romb.UseVisualStyleBackColor = true;
            this.romb.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // cube
            // 
            this.cube.Location = new System.Drawing.Point(100, 57);
            this.cube.Name = "cube";
            this.cube.Size = new System.Drawing.Size(75, 23);
            this.cube.TabIndex = 28;
            this.cube.Text = "cube";
            this.cube.UseVisualStyleBackColor = true;
            this.cube.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // hexagon2
            // 
            this.hexagon2.Location = new System.Drawing.Point(587, 57);
            this.hexagon2.Name = "hexagon2";
            this.hexagon2.Size = new System.Drawing.Size(75, 23);
            this.hexagon2.TabIndex = 29;
            this.hexagon2.Text = "hexagon2";
            this.hexagon2.UseVisualStyleBackColor = true;
            this.hexagon2.Click += new System.EventHandler(this.Shapes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 489);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyPaint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Pencil;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Eraser;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button hexagon;
        private System.Windows.Forms.Button octagon;
        private System.Windows.Forms.Button trapezoid;
        private System.Windows.Forms.Button cube;
        private System.Windows.Forms.Button romb;
        private System.Windows.Forms.Button star;
        private System.Windows.Forms.Button hexagon2;
    }
}

