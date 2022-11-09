namespace Project
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.header = new System.Windows.Forms.PictureBox();
            this.aboutus = new System.Windows.Forms.Button();
            this.ngopictures = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ngo_pic = new System.Windows.Forms.PictureBox();
            this.donate = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ourgoals = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.goals = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.us = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uspictures = new System.Windows.Forms.ImageList(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngo_pic)).BeginInit();
            this.about.SuspendLayout();
            this.goals.SuspendLayout();
            this.us.SuspendLayout();
            this.pic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("header.BackgroundImage")));
            this.header.Location = new System.Drawing.Point(-2, -3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(958, 298);
            this.header.TabIndex = 1;
            this.header.TabStop = false;
            this.header.Click += new System.EventHandler(this.header_Click);
            // 
            // aboutus
            // 
            this.aboutus.BackColor = System.Drawing.Color.White;
            this.aboutus.Location = new System.Drawing.Point(41, 40);
            this.aboutus.Name = "aboutus";
            this.aboutus.Size = new System.Drawing.Size(184, 180);
            this.aboutus.TabIndex = 5;
            this.aboutus.UseVisualStyleBackColor = false;
            this.aboutus.Click += new System.EventHandler(this.button2_Click);
            // 
            // ngopictures
            // 
            this.ngopictures.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ngopictures.ImageStream")));
            this.ngopictures.TransparentColor = System.Drawing.Color.Transparent;
            this.ngopictures.Images.SetKeyName(0, "chippa.png");
            this.ngopictures.Images.SetKeyName(1, "ds.png");
            this.ngopictures.Images.SetKeyName(2, "edhi.jpg");
            this.ngopictures.Images.SetKeyName(3, "jdc.png");
            this.ngopictures.Images.SetKeyName(4, "khidmat.png");
            this.ngopictures.Images.SetKeyName(5, "tcf.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ngo_pic
            // 
            this.ngo_pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngo_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ngo_pic.ImageLocation = "";
            this.ngo_pic.InitialImage = null;
            this.ngo_pic.Location = new System.Drawing.Point(264, 48);
            this.ngo_pic.Name = "ngo_pic";
            this.ngo_pic.Size = new System.Drawing.Size(185, 158);
            this.ngo_pic.TabIndex = 9;
            this.ngo_pic.TabStop = false;
            // 
            // donate
            // 
            this.donate.BackColor = System.Drawing.Color.IndianRed;
            this.donate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donate.Location = new System.Drawing.Point(580, 146);
            this.donate.Name = "donate";
            this.donate.Size = new System.Drawing.Size(174, 34);
            this.donate.TabIndex = 10;
            this.donate.Text = "Donate Now!";
            this.donate.UseVisualStyleBackColor = false;
            this.donate.Click += new System.EventHandler(this.donate_Click);
            // 
            // about
            // 
            this.about.Controls.Add(this.label29);
            this.about.Controls.Add(this.label28);
            this.about.Controls.Add(this.label27);
            this.about.Controls.Add(this.label26);
            this.about.Controls.Add(this.label25);
            this.about.Controls.Add(this.label24);
            this.about.Controls.Add(this.label23);
            this.about.Controls.Add(this.label22);
            this.about.Controls.Add(this.label11);
            this.about.Controls.Add(this.label10);
            this.about.Controls.Add(this.label9);
            this.about.Controls.Add(this.label2);
            this.about.Controls.Add(this.label1);
            this.about.Controls.Add(this.label3);
            this.about.Location = new System.Drawing.Point(-9, 660);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(995, 187);
            this.about.TabIndex = 12;
            this.about.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(507, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Islamabad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(466, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Also find us in:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Email: gnhhead@givenheal.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact: 0311897825";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address: XYZ Road, Clifton, Karachi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "HeadQuarter Branch:";
            // 
            // ourgoals
            // 
            this.ourgoals.AutoSize = true;
            this.ourgoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourgoals.Location = new System.Drawing.Point(403, 17);
            this.ourgoals.Name = "ourgoals";
            this.ourgoals.Size = new System.Drawing.Size(101, 25);
            this.ourgoals.TabIndex = 13;
            this.ourgoals.Text = "Our Goals";
            this.ourgoals.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Collect donations";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Distributing items amongst";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(647, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Keeping track of each";
            // 
            // goals
            // 
            this.goals.Controls.Add(this.pictureBox1);
            this.goals.Controls.Add(this.label21);
            this.goals.Controls.Add(this.label20);
            this.goals.Controls.Add(this.label19);
            this.goals.Controls.Add(this.label18);
            this.goals.Controls.Add(this.label7);
            this.goals.Controls.Add(this.label6);
            this.goals.Controls.Add(this.label5);
            this.goals.Controls.Add(this.ourgoals);
            this.goals.Location = new System.Drawing.Point(24, 254);
            this.goals.Name = "goals";
            this.goals.Size = new System.Drawing.Size(910, 148);
            this.goals.TabIndex = 18;
            this.goals.TabStop = false;
            this.goals.Enter += new System.EventHandler(this.goals_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(647, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 18);
            this.label21.TabIndex = 20;
            this.label21.Text = "given to NGOs";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(647, 104);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 18);
            this.label20.TabIndex = 19;
            this.label20.Text = "donation recieved and";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(348, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(156, 18);
            this.label19.TabIndex = 18;
            this.label19.Text = "NGOs as per the need";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(94, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(130, 18);
            this.label18.TabIndex = 17;
            this.label18.Text = "from willing people";
            // 
            // us
            // 
            this.us.Controls.Add(this.label17);
            this.us.Controls.Add(this.label16);
            this.us.Controls.Add(this.label15);
            this.us.Controls.Add(this.label14);
            this.us.Controls.Add(this.label13);
            this.us.Controls.Add(this.label12);
            this.us.Controls.Add(this.label8);
            this.us.Controls.Add(this.label4);
            this.us.Location = new System.Drawing.Point(24, 413);
            this.us.Name = "us";
            this.us.Size = new System.Drawing.Size(391, 241);
            this.us.TabIndex = 19;
            this.us.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(41, 202);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(234, 22);
            this.label17.TabIndex = 7;
            this.label17.Text = "track their request progress.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(308, 22);
            this.label16.TabIndex = 6;
            this.label16.Text = "donation history. Similarly, NGOs can";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(38, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(287, 22);
            this.label15.TabIndex = 5;
            this.label15.Text = "As a donor, you can also see your ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(40, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(255, 22);
            this.label14.TabIndex = 4;
            this.label14.Text = "provide them the needed items";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(302, 22);
            this.label13.TabIndex = 3;
            this.label13.Text = "NGOs request for donations and we ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(295, 22);
            this.label12.TabIndex = 2;
            this.label12.Text = "till the requests are being procesed.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "and store them in suitable conditions ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "We collect donations from individuals ";
            // 
            // pic
            // 
            this.pic.Controls.Add(this.ngo_pic);
            this.pic.Controls.Add(this.aboutus);
            this.pic.Location = new System.Drawing.Point(447, 413);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(487, 241);
            this.pic.TabIndex = 20;
            this.pic.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(580, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Recieve Donations";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 41);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // uspictures
            // 
            this.uspictures.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("uspictures.ImageStream")));
            this.uspictures.TransparentColor = System.Drawing.Color.Transparent;
            this.uspictures.Images.SetKeyName(0, "download.png");
            this.uspictures.Images.SetKeyName(1, "images.png");
            this.uspictures.Images.SetKeyName(2, "images1.png");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(507, 76);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 16);
            this.label22.TabIndex = 6;
            this.label22.Text = "Lahore";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(507, 109);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 16);
            this.label23.TabIndex = 7;
            this.label23.Text = "Rawalpindi";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(613, 44);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 16);
            this.label24.TabIndex = 8;
            this.label24.Text = "Hyderabad";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(613, 76);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 16);
            this.label25.TabIndex = 9;
            this.label25.Text = "Peshawar";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(613, 109);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 16);
            this.label26.TabIndex = 10;
            this.label26.Text = "Quetta";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(717, 109);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 16);
            this.label27.TabIndex = 11;
            this.label27.Text = "Faislabad";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(717, 76);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 16);
            this.label28.TabIndex = 12;
            this.label28.Text = "Multan";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(717, 44);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(55, 16);
            this.label29.TabIndex = 13;
            this.label29.Text = "Kashmir";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(955, 840);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.us);
            this.Controls.Add(this.goals);
            this.Controls.Add(this.about);
            this.Controls.Add(this.donate);
            this.Controls.Add(this.header);
            this.Name = "main";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngo_pic)).EndInit();
            this.about.ResumeLayout(false);
            this.about.PerformLayout();
            this.goals.ResumeLayout(false);
            this.goals.PerformLayout();
            this.us.ResumeLayout(false);
            this.us.PerformLayout();
            this.pic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox header;
        private System.Windows.Forms.Button aboutus;
        private System.Windows.Forms.ImageList ngopictures;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ngo_pic;
        private System.Windows.Forms.Button donate;
        private System.Windows.Forms.GroupBox about;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ourgoals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox goals;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox us;
        private System.Windows.Forms.GroupBox pic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList uspictures;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
    }
}

