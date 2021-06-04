namespace HOLD_AND_WRITE
{
    partial class HoldAndWrite
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Проекты");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Сведения");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Персонажи");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Места");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Предметы");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Корзина");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoldAndWrite));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Notepad = new System.Windows.Forms.RichTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simSunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segoeUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.FrontSizeNumb = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRegular = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStrip = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.treeView1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 843);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(4, 4);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "projects";
            treeNode1.Text = "Проекты";
            treeNode1.ToolTipText = "Папка с папками книг.";
            treeNode2.Name = "research";
            treeNode2.Text = "Сведения";
            treeNode2.ToolTipText = "Вспомогательные материалы";
            treeNode3.Name = "characters";
            treeNode3.Text = "Персонажи";
            treeNode3.ToolTipText = "Каталог персонажей";
            treeNode4.Name = "places";
            treeNode4.Text = "Места";
            treeNode4.ToolTipText = "Локации, встречающиеся в проектах";
            treeNode5.Name = "items";
            treeNode5.Text = "Предметы";
            treeNode5.ToolTipText = "Каталог предметов";
            treeNode6.Name = "trash";
            treeNode6.Text = "Корзина";
            treeNode6.ToolTipText = "Удалёные файлы";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(368, 808);
            this.treeView1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1373, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(368, 843);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.toolStrip1);
            this.flowLayoutPanel3.Controls.Add(this.Notepad);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(377, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(996, 843);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.FrontSizeNumb,
            this.toolStripButton4,
            this.toolStripButtonRegular,
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripButtonStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(287, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Notepad
            // 
            this.Notepad.Location = new System.Drawing.Point(4, 31);
            this.Notepad.Margin = new System.Windows.Forms.Padding(4);
            this.Notepad.Name = "Notepad";
            this.Notepad.Size = new System.Drawing.Size(983, 777);
            this.Notepad.TabIndex = 1;
            this.Notepad.Text = "";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesNewRomanToolStripMenuItem,
            this.impactToolStripMenuItem,
            this.simSunToolStripMenuItem,
            this.segoeUIToolStripMenuItem});
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(71, 24);
            this.toolStripButton1.Text = "Шрифт";
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem.Click += new System.EventHandler(this.Front_TimesNewRoman);
            // 
            // impactToolStripMenuItem
            // 
            this.impactToolStripMenuItem.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.impactToolStripMenuItem.Name = "impactToolStripMenuItem";
            this.impactToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.impactToolStripMenuItem.Text = "Impact";
            this.impactToolStripMenuItem.Click += new System.EventHandler(this.Front_Impact);
            // 
            // simSunToolStripMenuItem
            // 
            this.simSunToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simSunToolStripMenuItem.Name = "simSunToolStripMenuItem";
            this.simSunToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.simSunToolStripMenuItem.Text = "SimSun";
            this.simSunToolStripMenuItem.Click += new System.EventHandler(this.Front_SimSim);
            // 
            // segoeUIToolStripMenuItem
            // 
            this.segoeUIToolStripMenuItem.Name = "segoeUIToolStripMenuItem";
            this.segoeUIToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.segoeUIToolStripMenuItem.Text = "Segoe UI";
            this.segoeUIToolStripMenuItem.Click += new System.EventHandler(this.Front_Standart);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "<";
            this.toolStripButton2.Click += new System.EventHandler(this.ReduceFrontSize);
            // 
            // FrontSizeNumb
            // 
            this.FrontSizeNumb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FrontSizeNumb.Image = ((System.Drawing.Image)(resources.GetObject("FrontSizeNumb.Image")));
            this.FrontSizeNumb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FrontSizeNumb.Name = "FrontSizeNumb";
            this.FrontSizeNumb.Size = new System.Drawing.Size(29, 24);
            this.FrontSizeNumb.Text = "12";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = ">";
            this.toolStripButton4.Click += new System.EventHandler(this.IncreaseFrontSize);
            // 
            // toolStripButtonRegular
            // 
            this.toolStripButtonRegular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRegular.Image = global::HOLD_AND_WRITE.Properties.Resources.bold;
            this.toolStripButtonRegular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRegular.Name = "toolStripButtonRegular";
            this.toolStripButtonRegular.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonRegular.Text = "Обычный шрифт";
            this.toolStripButtonRegular.Click += new System.EventHandler(this.RegularFront);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBold.Image = global::HOLD_AND_WRITE.Properties.Resources.bold3;
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonBold.Text = "Жирный шрифт";
            this.toolStripButtonBold.Click += new System.EventHandler(this.BoldFront);
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonItalic.Image = global::HOLD_AND_WRITE.Properties.Resources.italic;
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonItalic.Text = "Курсив";
            this.toolStripButtonItalic.Click += new System.EventHandler(this.ItalicFront);
            // 
            // toolStripButtonStrip
            // 
            this.toolStripButtonStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStrip.Image = global::HOLD_AND_WRITE.Properties.Resources.strip;
            this.toolStripButtonStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStrip.Name = "toolStripButtonStrip";
            this.toolStripButtonStrip.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonStrip.Text = "Нижнее подчеркивание";
            this.toolStripButtonStrip.Click += new System.EventHandler(this.StripFront);
            // 
            // HoldAndWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1741, 843);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoldAndWrite";
            this.Text = "Держись и пиши";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton FrontSizeNumb;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButtonRegular;
        private System.Windows.Forms.ToolStripButton toolStripButtonItalic;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStrip;
        private System.Windows.Forms.RichTextBox Notepad;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simSunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segoeUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
    }
}

