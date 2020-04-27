namespace XmlForm
{
    partial class MainApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zachetkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.textBoxMarked = new System.Windows.Forms.TextBox();
            this.textBoxFuel = new System.Windows.Forms.TextBox();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.textBoxMarkcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFuelLeft = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxOil = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRemove = new System.Windows.Forms.TextBox();
            this.buttonremove = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(848, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subjectToolStripMenuItem,
            this.nameToolStripMenuItem,
            this.zachetkaToolStripMenuItem,
            this.markToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.subjectToolStripMenuItem.Text = "mark";
            this.subjectToolStripMenuItem.Click += new System.EventHandler(this.Search_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.nameToolStripMenuItem.Text = "owner";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.Search_Click);
            // 
            // zachetkaToolStripMenuItem
            // 
            this.zachetkaToolStripMenuItem.Name = "zachetkaToolStripMenuItem";
            this.zachetkaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.zachetkaToolStripMenuItem.Text = "fuel";
            this.zachetkaToolStripMenuItem.Click += new System.EventHandler(this.Search_Click);
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.markToolStripMenuItem.Text = "power";
            this.markToolStripMenuItem.Click += new System.EventHandler(this.Search_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(556, 27);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(141, 76);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(299, 284);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 47);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(21, 421);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Volume:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Power:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fuel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mark:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 319);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Owner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mark_code:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(119, 316);
            this.textBoxOwner.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(175, 20);
            this.textBoxOwner.TabIndex = 18;
            // 
            // textBoxMarked
            // 
            this.textBoxMarked.Location = new System.Drawing.Point(119, 342);
            this.textBoxMarked.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMarked.Name = "textBoxMarked";
            this.textBoxMarked.Size = new System.Drawing.Size(175, 20);
            this.textBoxMarked.TabIndex = 17;
            // 
            // textBoxFuel
            // 
            this.textBoxFuel.Location = new System.Drawing.Point(119, 366);
            this.textBoxFuel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFuel.Name = "textBoxFuel";
            this.textBoxFuel.Size = new System.Drawing.Size(175, 20);
            this.textBoxFuel.TabIndex = 16;
            // 
            // textBoxPower
            // 
            this.textBoxPower.Location = new System.Drawing.Point(119, 392);
            this.textBoxPower.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(175, 20);
            this.textBoxPower.TabIndex = 15;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(119, 418);
            this.textBoxVolume.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(175, 20);
            this.textBoxVolume.TabIndex = 14;
            // 
            // textBoxMarkcode
            // 
            this.textBoxMarkcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMarkcode.Location = new System.Drawing.Point(119, 288);
            this.textBoxMarkcode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMarkcode.Name = "textBoxMarkcode";
            this.textBoxMarkcode.Size = new System.Drawing.Size(175, 20);
            this.textBoxMarkcode.TabIndex = 13;
            this.textBoxMarkcode.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(21, 445);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Fuel left:";
            // 
            // textBoxFuelLeft
            // 
            this.textBoxFuelLeft.Location = new System.Drawing.Point(119, 442);
            this.textBoxFuelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFuelLeft.Name = "textBoxFuelLeft";
            this.textBoxFuelLeft.Size = new System.Drawing.Size(175, 20);
            this.textBoxFuelLeft.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(21, 469);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Oil:";
            // 
            // textBoxOil
            // 
            this.textBoxOil.Location = new System.Drawing.Point(119, 469);
            this.textBoxOil.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOil.Name = "textBoxOil";
            this.textBoxOil.Size = new System.Drawing.Size(175, 20);
            this.textBoxOil.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(65, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(452, 268);
            this.textBox1.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(426, 300);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Mark_code:";
            // 
            // textBoxRemove
            // 
            this.textBoxRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRemove.Location = new System.Drawing.Point(522, 298);
            this.textBoxRemove.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRemove.Name = "textBoxRemove";
            this.textBoxRemove.Size = new System.Drawing.Size(175, 20);
            this.textBoxRemove.TabIndex = 30;
            // 
            // buttonremove
            // 
            this.buttonremove.Location = new System.Drawing.Point(728, 290);
            this.buttonremove.Name = "buttonremove";
            this.buttonremove.Size = new System.Drawing.Size(92, 37);
            this.buttonremove.TabIndex = 32;
            this.buttonremove.Text = "Remove";
            this.buttonremove.UseVisualStyleBackColor = true;
            this.buttonremove.Click += new System.EventHandler(this.buttonremove_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 508);
            this.Controls.Add(this.buttonremove);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxRemove);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxOil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxFuelLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.textBoxMarked);
            this.Controls.Add(this.textBoxFuel);
            this.Controls.Add(this.textBoxPower);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.textBoxMarkcode);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(472, 305);
            this.Name = "MainApp";
            this.Text = "XmlForm";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zachetkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.TextBox textBoxMarked;
        private System.Windows.Forms.TextBox textBoxFuel;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.TextBox textBoxMarkcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFuelLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxOil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRemove;
        private System.Windows.Forms.Button buttonremove;
    }
}

