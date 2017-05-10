namespace GoldRush
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.QuarryBox = new System.Windows.Forms.PictureBox();
            this.RepairShopBox = new System.Windows.Forms.PictureBox();
            this.BonusBox = new System.Windows.Forms.PictureBox();
            this.MineBox = new System.Windows.Forms.PictureBox();
            this.CorporationBox = new System.Windows.Forms.PictureBox();
            this.PromBox = new System.Windows.Forms.PictureBox();
            this.textGold = new System.Windows.Forms.TextBox();
            this.textMoney = new System.Windows.Forms.TextBox();
            this.textLv = new System.Windows.Forms.TextBox();
            this.panelMine = new System.Windows.Forms.Panel();
            this.progressBrigMan = new System.Windows.Forms.ProgressBar();
            this.progressDripMan = new System.Windows.Forms.ProgressBar();
            this.progressShaftMan = new System.Windows.Forms.ProgressBar();
            this.ImgBrigMan = new System.Windows.Forms.PictureBox();
            this.ImgDripMan = new System.Windows.Forms.PictureBox();
            this.ImgShaftMan = new System.Windows.Forms.PictureBox();
            this.clousePanelMine = new System.Windows.Forms.Button();
            this.panelQuarry = new System.Windows.Forms.Panel();
            this.clousePanelQuarry = new System.Windows.Forms.Button();
            this.ImgTruck = new System.Windows.Forms.PictureBox();
            this.ImgExcovator = new System.Windows.Forms.PictureBox();
            this.panelCorporation = new System.Windows.Forms.Panel();
            this.clousePanelCorporation = new System.Windows.Forms.Button();
            this.ImgWeight = new System.Windows.Forms.PictureBox();
            this.ImgComputer = new System.Windows.Forms.PictureBox();
            this.desktop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerShaftMan = new System.Windows.Forms.Timer(this.components);
            this.timerDripMan = new System.Windows.Forms.Timer(this.components);
            this.timerBrigMan = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QuarryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairShopBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BonusBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MineBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorporationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromBox)).BeginInit();
            this.panelMine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBrigMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDripMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgShaftMan)).BeginInit();
            this.panelQuarry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgExcovator)).BeginInit();
            this.panelCorporation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgComputer)).BeginInit();
            this.desktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuarryBox
            // 
            this.QuarryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuarryBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuarryBox.BackgroundImage")));
            this.QuarryBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuarryBox.Image = ((System.Drawing.Image)(resources.GetObject("QuarryBox.Image")));
            this.QuarryBox.Location = new System.Drawing.Point(194, 181);
            this.QuarryBox.Name = "QuarryBox";
            this.QuarryBox.Size = new System.Drawing.Size(444, 195);
            this.QuarryBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.QuarryBox.TabIndex = 1;
            this.QuarryBox.TabStop = false;
            this.QuarryBox.DoubleClick += new System.EventHandler(this.QuarryBox_DoubleClick);
            this.QuarryBox.MouseLeave += new System.EventHandler(this.QuarryBox_MouseLeave);
            this.QuarryBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QuarryBox_MouseMove);
            // 
            // RepairShopBox
            // 
            this.RepairShopBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepairShopBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RepairShopBox.BackgroundImage")));
            this.RepairShopBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RepairShopBox.Image = ((System.Drawing.Image)(resources.GetObject("RepairShopBox.Image")));
            this.RepairShopBox.Location = new System.Drawing.Point(111, 181);
            this.RepairShopBox.Name = "RepairShopBox";
            this.RepairShopBox.Size = new System.Drawing.Size(83, 53);
            this.RepairShopBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RepairShopBox.TabIndex = 2;
            this.RepairShopBox.TabStop = false;
            this.RepairShopBox.MouseLeave += new System.EventHandler(this.RepairShopBox_MouseLeave);
            this.RepairShopBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RepairShopBox_MouseMove);
            // 
            // BonusBox
            // 
            this.BonusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BonusBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BonusBox.BackgroundImage")));
            this.BonusBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BonusBox.Image = ((System.Drawing.Image)(resources.GetObject("BonusBox.Image")));
            this.BonusBox.Location = new System.Drawing.Point(407, 340);
            this.BonusBox.Name = "BonusBox";
            this.BonusBox.Size = new System.Drawing.Size(44, 63);
            this.BonusBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BonusBox.TabIndex = 3;
            this.BonusBox.TabStop = false;
            this.BonusBox.MouseLeave += new System.EventHandler(this.BonusBox_MouseLeave);
            this.BonusBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BonusBox_MouseMove);
            // 
            // MineBox
            // 
            this.MineBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MineBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MineBox.BackgroundImage")));
            this.MineBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MineBox.Image = ((System.Drawing.Image)(resources.GetObject("MineBox.Image")));
            this.MineBox.Location = new System.Drawing.Point(727, 201);
            this.MineBox.Name = "MineBox";
            this.MineBox.Size = new System.Drawing.Size(96, 110);
            this.MineBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MineBox.TabIndex = 4;
            this.MineBox.TabStop = false;
            this.MineBox.DoubleClick += new System.EventHandler(this.MineBox_DoubleClick);
            this.MineBox.MouseLeave += new System.EventHandler(this.MineBox_MouseLeave);
            this.MineBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MineBox_MouseMove);
            // 
            // CorporationBox
            // 
            this.CorporationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CorporationBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CorporationBox.BackgroundImage")));
            this.CorporationBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CorporationBox.Image = ((System.Drawing.Image)(resources.GetObject("CorporationBox.Image")));
            this.CorporationBox.Location = new System.Drawing.Point(0, 272);
            this.CorporationBox.Name = "CorporationBox";
            this.CorporationBox.Size = new System.Drawing.Size(229, 197);
            this.CorporationBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CorporationBox.TabIndex = 5;
            this.CorporationBox.TabStop = false;
            this.CorporationBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CorporationBox_MouseClick);
            this.CorporationBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CorporationBox_MouseDoubleClick);
            this.CorporationBox.MouseLeave += new System.EventHandler(this.CorporationBox_MouseLeave);
            this.CorporationBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CorporationBox_MouseMove);
            // 
            // PromBox
            // 
            this.PromBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PromBox.BackgroundImage")));
            this.PromBox.Image = ((System.Drawing.Image)(resources.GetObject("PromBox.Image")));
            this.PromBox.Location = new System.Drawing.Point(685, 367);
            this.PromBox.Name = "PromBox";
            this.PromBox.Size = new System.Drawing.Size(147, 101);
            this.PromBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PromBox.TabIndex = 12;
            this.PromBox.TabStop = false;
            this.PromBox.MouseLeave += new System.EventHandler(this.PromBox_MouseLeave);
            this.PromBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PromBox_MouseMove);
            // 
            // textGold
            // 
            this.textGold.BackColor = System.Drawing.SystemColors.Highlight;
            this.textGold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGold.Enabled = false;
            this.textGold.Location = new System.Drawing.Point(305, 3);
            this.textGold.Name = "textGold";
            this.textGold.ReadOnly = true;
            this.textGold.ShortcutsEnabled = false;
            this.textGold.Size = new System.Drawing.Size(65, 13);
            this.textGold.TabIndex = 6;
            // 
            // textMoney
            // 
            this.textMoney.BackColor = System.Drawing.SystemColors.Highlight;
            this.textMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMoney.Enabled = false;
            this.textMoney.Location = new System.Drawing.Point(399, 3);
            this.textMoney.MaxLength = 9;
            this.textMoney.Name = "textMoney";
            this.textMoney.ReadOnly = true;
            this.textMoney.ShortcutsEnabled = false;
            this.textMoney.Size = new System.Drawing.Size(65, 13);
            this.textMoney.TabIndex = 7;
            // 
            // textLv
            // 
            this.textLv.BackColor = System.Drawing.SystemColors.Highlight;
            this.textLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLv.Enabled = false;
            this.textLv.Location = new System.Drawing.Point(229, 3);
            this.textLv.Name = "textLv";
            this.textLv.ReadOnly = true;
            this.textLv.ShortcutsEnabled = false;
            this.textLv.Size = new System.Drawing.Size(22, 13);
            this.textLv.TabIndex = 8;
            // 
            // panelMine
            // 
            this.panelMine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMine.BackgroundImage")));
            this.panelMine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMine.Controls.Add(this.progressBrigMan);
            this.panelMine.Controls.Add(this.progressDripMan);
            this.panelMine.Controls.Add(this.progressShaftMan);
            this.panelMine.Controls.Add(this.ImgBrigMan);
            this.panelMine.Controls.Add(this.ImgDripMan);
            this.panelMine.Controls.Add(this.ImgShaftMan);
            this.panelMine.Controls.Add(this.clousePanelMine);
            this.panelMine.Location = new System.Drawing.Point(179, 28);
            this.panelMine.Name = "panelMine";
            this.panelMine.Size = new System.Drawing.Size(500, 375);
            this.panelMine.TabIndex = 9;
            this.panelMine.Visible = false;
            // 
            // progressBrigMan
            // 
            this.progressBrigMan.Location = new System.Drawing.Point(54, 153);
            this.progressBrigMan.Name = "progressBrigMan";
            this.progressBrigMan.Size = new System.Drawing.Size(116, 10);
            this.progressBrigMan.TabIndex = 6;
            this.progressBrigMan.Visible = false;
            // 
            // progressDripMan
            // 
            this.progressDripMan.Location = new System.Drawing.Point(245, 89);
            this.progressDripMan.Name = "progressDripMan";
            this.progressDripMan.Size = new System.Drawing.Size(57, 10);
            this.progressDripMan.TabIndex = 5;
            this.progressDripMan.Visible = false;
            // 
            // progressShaftMan
            // 
            this.progressShaftMan.Location = new System.Drawing.Point(310, 89);
            this.progressShaftMan.Name = "progressShaftMan";
            this.progressShaftMan.Size = new System.Drawing.Size(86, 10);
            this.progressShaftMan.Step = 1;
            this.progressShaftMan.TabIndex = 4;
            this.progressShaftMan.Visible = false;
            // 
            // ImgBrigMan
            // 
            this.ImgBrigMan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgBrigMan.BackgroundImage")));
            this.ImgBrigMan.Image = ((System.Drawing.Image)(resources.GetObject("ImgBrigMan.Image")));
            this.ImgBrigMan.Location = new System.Drawing.Point(54, 170);
            this.ImgBrigMan.Name = "ImgBrigMan";
            this.ImgBrigMan.Size = new System.Drawing.Size(116, 87);
            this.ImgBrigMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgBrigMan.TabIndex = 3;
            this.ImgBrigMan.TabStop = false;
            this.ImgBrigMan.Click += new System.EventHandler(this.ImgBrigMan_Click);
            this.ImgBrigMan.MouseLeave += new System.EventHandler(this.ImgBrigMan_MouseLeave);
            this.ImgBrigMan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgBrigMan_MouseMove);
            // 
            // ImgDripMan
            // 
            this.ImgDripMan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgDripMan.BackgroundImage")));
            this.ImgDripMan.Image = ((System.Drawing.Image)(resources.GetObject("ImgDripMan.Image")));
            this.ImgDripMan.Location = new System.Drawing.Point(245, 105);
            this.ImgDripMan.Name = "ImgDripMan";
            this.ImgDripMan.Size = new System.Drawing.Size(57, 87);
            this.ImgDripMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgDripMan.TabIndex = 2;
            this.ImgDripMan.TabStop = false;
            this.ImgDripMan.Click += new System.EventHandler(this.ImgDripMan_Click);
            this.ImgDripMan.MouseLeave += new System.EventHandler(this.ImgDripMan_MouseLeave);
            this.ImgDripMan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgDripMan_MouseMove);
            // 
            // ImgShaftMan
            // 
            this.ImgShaftMan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgShaftMan.BackgroundImage")));
            this.ImgShaftMan.Image = ((System.Drawing.Image)(resources.GetObject("ImgShaftMan.Image")));
            this.ImgShaftMan.Location = new System.Drawing.Point(310, 105);
            this.ImgShaftMan.Name = "ImgShaftMan";
            this.ImgShaftMan.Size = new System.Drawing.Size(86, 87);
            this.ImgShaftMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgShaftMan.TabIndex = 1;
            this.ImgShaftMan.TabStop = false;
            this.ImgShaftMan.Click += new System.EventHandler(this.ImgShaftMan_Click);
            this.ImgShaftMan.MouseLeave += new System.EventHandler(this.ImgShaftMan_MouseLeave);
            this.ImgShaftMan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgShaftMan_MouseMove);
            // 
            // clousePanelMine
            // 
            this.clousePanelMine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clousePanelMine.BackgroundImage")));
            this.clousePanelMine.Location = new System.Drawing.Point(470, 0);
            this.clousePanelMine.Name = "clousePanelMine";
            this.clousePanelMine.Size = new System.Drawing.Size(30, 30);
            this.clousePanelMine.TabIndex = 0;
            this.clousePanelMine.UseVisualStyleBackColor = true;
            this.clousePanelMine.Click += new System.EventHandler(this.clousePanelMine_Click);
            // 
            // panelQuarry
            // 
            this.panelQuarry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelQuarry.BackgroundImage")));
            this.panelQuarry.Controls.Add(this.clousePanelQuarry);
            this.panelQuarry.Controls.Add(this.ImgTruck);
            this.panelQuarry.Controls.Add(this.ImgExcovator);
            this.panelQuarry.Location = new System.Drawing.Point(194, 429);
            this.panelQuarry.Name = "panelQuarry";
            this.panelQuarry.Size = new System.Drawing.Size(330, 202);
            this.panelQuarry.TabIndex = 10;
            this.panelQuarry.Visible = false;
            // 
            // clousePanelQuarry
            // 
            this.clousePanelQuarry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clousePanelQuarry.BackgroundImage")));
            this.clousePanelQuarry.Location = new System.Drawing.Point(301, -1);
            this.clousePanelQuarry.Name = "clousePanelQuarry";
            this.clousePanelQuarry.Size = new System.Drawing.Size(30, 30);
            this.clousePanelQuarry.TabIndex = 2;
            this.clousePanelQuarry.UseVisualStyleBackColor = true;
            this.clousePanelQuarry.Click += new System.EventHandler(this.clousePanelQuarry_Click);
            // 
            // ImgTruck
            // 
            this.ImgTruck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgTruck.BackgroundImage")));
            this.ImgTruck.Image = ((System.Drawing.Image)(resources.GetObject("ImgTruck.Image")));
            this.ImgTruck.Location = new System.Drawing.Point(17, 113);
            this.ImgTruck.Name = "ImgTruck";
            this.ImgTruck.Size = new System.Drawing.Size(174, 80);
            this.ImgTruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgTruck.TabIndex = 1;
            this.ImgTruck.TabStop = false;
            this.ImgTruck.MouseLeave += new System.EventHandler(this.ImgTruck_MouseLeave);
            this.ImgTruck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgTruck_MouseMove);
            // 
            // ImgExcovator
            // 
            this.ImgExcovator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgExcovator.BackgroundImage")));
            this.ImgExcovator.Image = ((System.Drawing.Image)(resources.GetObject("ImgExcovator.Image")));
            this.ImgExcovator.Location = new System.Drawing.Point(62, 19);
            this.ImgExcovator.Name = "ImgExcovator";
            this.ImgExcovator.Size = new System.Drawing.Size(245, 129);
            this.ImgExcovator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgExcovator.TabIndex = 0;
            this.ImgExcovator.TabStop = false;
            this.ImgExcovator.MouseLeave += new System.EventHandler(this.ImgExcovator_MouseLeave);
            this.ImgExcovator.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgExcovator_MouseMove);
            // 
            // panelCorporation
            // 
            this.panelCorporation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCorporation.BackgroundImage")));
            this.panelCorporation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCorporation.Controls.Add(this.clousePanelCorporation);
            this.panelCorporation.Controls.Add(this.ImgWeight);
            this.panelCorporation.Controls.Add(this.ImgComputer);
            this.panelCorporation.Location = new System.Drawing.Point(558, 448);
            this.panelCorporation.Name = "panelCorporation";
            this.panelCorporation.Size = new System.Drawing.Size(640, 480);
            this.panelCorporation.TabIndex = 11;
            this.panelCorporation.Visible = false;
            // 
            // clousePanelCorporation
            // 
            this.clousePanelCorporation.Location = new System.Drawing.Point(594, 17);
            this.clousePanelCorporation.Name = "clousePanelCorporation";
            this.clousePanelCorporation.Size = new System.Drawing.Size(30, 30);
            this.clousePanelCorporation.TabIndex = 2;
            this.clousePanelCorporation.UseVisualStyleBackColor = true;
            this.clousePanelCorporation.Click += new System.EventHandler(this.clousePanelCorporation_Click);
            // 
            // ImgWeight
            // 
            this.ImgWeight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgWeight.BackgroundImage")));
            this.ImgWeight.Image = ((System.Drawing.Image)(resources.GetObject("ImgWeight.Image")));
            this.ImgWeight.Location = new System.Drawing.Point(129, 221);
            this.ImgWeight.Name = "ImgWeight";
            this.ImgWeight.Size = new System.Drawing.Size(60, 70);
            this.ImgWeight.TabIndex = 1;
            this.ImgWeight.TabStop = false;
            this.ImgWeight.MouseLeave += new System.EventHandler(this.ImgWeight_MouseLeave);
            this.ImgWeight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgWeight_MouseMove);
            // 
            // ImgComputer
            // 
            this.ImgComputer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgComputer.BackgroundImage")));
            this.ImgComputer.Image = ((System.Drawing.Image)(resources.GetObject("ImgComputer.Image")));
            this.ImgComputer.Location = new System.Drawing.Point(255, 145);
            this.ImgComputer.Name = "ImgComputer";
            this.ImgComputer.Size = new System.Drawing.Size(158, 168);
            this.ImgComputer.TabIndex = 0;
            this.ImgComputer.TabStop = false;
            this.ImgComputer.MouseLeave += new System.EventHandler(this.ImgComputer_MouseLeave);
            this.ImgComputer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgComputer_MouseMove);
            // 
            // desktop
            // 
            this.desktop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("desktop.BackgroundImage")));
            this.desktop.Controls.Add(this.panel1);
            this.desktop.Location = new System.Drawing.Point(759, 383);
            this.desktop.Name = "desktop";
            this.desktop.Size = new System.Drawing.Size(800, 450);
            this.desktop.TabIndex = 3;
            this.desktop.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(27, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 365);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // timerShaftMan
            // 
            this.timerShaftMan.Tick += new System.EventHandler(this.timerShaftMan_Tick);
            // 
            // timerDripMan
            // 
            this.timerDripMan.Tick += new System.EventHandler(this.timerDripMan_Tick);
            // 
            // timerBrigMan
            // 
            this.timerBrigMan.Tick += new System.EventHandler(this.timerBrigMan_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 471);
            this.Controls.Add(this.desktop);
            this.Controls.Add(this.panelCorporation);
            this.Controls.Add(this.panelQuarry);
            this.Controls.Add(this.panelMine);
            this.Controls.Add(this.textLv);
            this.Controls.Add(this.textMoney);
            this.Controls.Add(this.textGold);
            this.Controls.Add(this.PromBox);
            this.Controls.Add(this.CorporationBox);
            this.Controls.Add(this.MineBox);
            this.Controls.Add(this.BonusBox);
            this.Controls.Add(this.RepairShopBox);
            this.Controls.Add(this.QuarryBox);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuarryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepairShopBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BonusBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MineBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorporationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromBox)).EndInit();
            this.panelMine.ResumeLayout(false);
            this.panelMine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBrigMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDripMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgShaftMan)).EndInit();
            this.panelQuarry.ResumeLayout(false);
            this.panelQuarry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgExcovator)).EndInit();
            this.panelCorporation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgComputer)).EndInit();
            this.desktop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox QuarryBox;
        private System.Windows.Forms.PictureBox RepairShopBox;
        private System.Windows.Forms.PictureBox BonusBox;
        private System.Windows.Forms.PictureBox MineBox;
        private System.Windows.Forms.PictureBox CorporationBox;
        private System.Windows.Forms.PictureBox PromBox;
        private System.Windows.Forms.TextBox textGold;
        private System.Windows.Forms.TextBox textMoney;
        private System.Windows.Forms.TextBox textLv;
        private System.Windows.Forms.Panel panelMine;
        private System.Windows.Forms.Button clousePanelMine;
        private System.Windows.Forms.PictureBox ImgShaftMan;
        private System.Windows.Forms.PictureBox ImgDripMan;
        private System.Windows.Forms.PictureBox ImgBrigMan;
        private System.Windows.Forms.Panel panelQuarry;
        private System.Windows.Forms.PictureBox ImgTruck;
        private System.Windows.Forms.PictureBox ImgExcovator;
        private System.Windows.Forms.Button clousePanelQuarry;
        private System.Windows.Forms.Panel panelCorporation;
        private System.Windows.Forms.PictureBox ImgWeight;
        private System.Windows.Forms.PictureBox ImgComputer;
        private System.Windows.Forms.Button clousePanelCorporation;
        private System.Windows.Forms.Panel desktop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerShaftMan;
        private System.Windows.Forms.Timer timerDripMan;
        private System.Windows.Forms.Timer timerBrigMan;
        private System.Windows.Forms.ProgressBar progressShaftMan;
        private System.Windows.Forms.ProgressBar progressBrigMan;
        private System.Windows.Forms.ProgressBar progressDripMan;
    }
}

