namespace theQuest
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
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.batImage = new System.Windows.Forms.PictureBox();
            this.ghostImage = new System.Windows.Forms.PictureBox();
            this.redPotionImageBar = new System.Windows.Forms.PictureBox();
            this.bluePotionImageBar = new System.Windows.Forms.PictureBox();
            this.maceImageBar = new System.Windows.Forms.PictureBox();
            this.bowImageBar = new System.Windows.Forms.PictureBox();
            this.swordImageBar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attackDownButton = new System.Windows.Forms.Button();
            this.attackRightButton = new System.Windows.Forms.Button();
            this.attackUpButton = new System.Windows.Forms.Button();
            this.attackLeftButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.swordImage = new System.Windows.Forms.PictureBox();
            this.bluePotionImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionImageBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionImageBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceImageBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowImageBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordImageBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // playerImage
            // 
            this.playerImage.BackColor = System.Drawing.Color.Transparent;
            this.playerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerImage.Cursor = System.Windows.Forms.Cursors.No;
            this.playerImage.Image = ((System.Drawing.Image)(resources.GetObject("playerImage.Image")));
            this.playerImage.Location = new System.Drawing.Point(107, 77);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(51, 48);
            this.playerImage.TabIndex = 0;
            this.playerImage.TabStop = false;
            // 
            // batImage
            // 
            this.batImage.BackColor = System.Drawing.Color.Transparent;
            this.batImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.batImage.Image = ((System.Drawing.Image)(resources.GetObject("batImage.Image")));
            this.batImage.Location = new System.Drawing.Point(164, 77);
            this.batImage.Name = "batImage";
            this.batImage.Size = new System.Drawing.Size(51, 48);
            this.batImage.TabIndex = 1;
            this.batImage.TabStop = false;
            // 
            // ghostImage
            // 
            this.ghostImage.BackColor = System.Drawing.Color.Transparent;
            this.ghostImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ghostImage.Image = ((System.Drawing.Image)(resources.GetObject("ghostImage.Image")));
            this.ghostImage.Location = new System.Drawing.Point(221, 77);
            this.ghostImage.Name = "ghostImage";
            this.ghostImage.Size = new System.Drawing.Size(51, 48);
            this.ghostImage.TabIndex = 2;
            this.ghostImage.TabStop = false;
            this.ghostImage.Click += new System.EventHandler(this.ghostImage_Click);
            // 
            // redPotionImageBar
            // 
            this.redPotionImageBar.BackColor = System.Drawing.Color.Transparent;
            this.redPotionImageBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.redPotionImageBar.Image = ((System.Drawing.Image)(resources.GetObject("redPotionImageBar.Image")));
            this.redPotionImageBar.Location = new System.Drawing.Point(300, 320);
            this.redPotionImageBar.Name = "redPotionImageBar";
            this.redPotionImageBar.Size = new System.Drawing.Size(51, 48);
            this.redPotionImageBar.TabIndex = 4;
            this.redPotionImageBar.TabStop = false;
            this.redPotionImageBar.Click += new System.EventHandler(this.redPotionImageBar_Click);
            // 
            // bluePotionImageBar
            // 
            this.bluePotionImageBar.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionImageBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bluePotionImageBar.Image = ((System.Drawing.Image)(resources.GetObject("bluePotionImageBar.Image")));
            this.bluePotionImageBar.Location = new System.Drawing.Point(243, 320);
            this.bluePotionImageBar.Name = "bluePotionImageBar";
            this.bluePotionImageBar.Size = new System.Drawing.Size(51, 48);
            this.bluePotionImageBar.TabIndex = 5;
            this.bluePotionImageBar.TabStop = false;
            this.bluePotionImageBar.Click += new System.EventHandler(this.bluePotionImageBar_Click);
            // 
            // maceImageBar
            // 
            this.maceImageBar.BackColor = System.Drawing.Color.Transparent;
            this.maceImageBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maceImageBar.Image = ((System.Drawing.Image)(resources.GetObject("maceImageBar.Image")));
            this.maceImageBar.Location = new System.Drawing.Point(186, 320);
            this.maceImageBar.Name = "maceImageBar";
            this.maceImageBar.Size = new System.Drawing.Size(51, 48);
            this.maceImageBar.TabIndex = 6;
            this.maceImageBar.TabStop = false;
            this.maceImageBar.Click += new System.EventHandler(this.maceImageBar_Click);
            // 
            // bowImageBar
            // 
            this.bowImageBar.BackColor = System.Drawing.Color.Transparent;
            this.bowImageBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bowImageBar.Image = ((System.Drawing.Image)(resources.GetObject("bowImageBar.Image")));
            this.bowImageBar.Location = new System.Drawing.Point(129, 320);
            this.bowImageBar.Name = "bowImageBar";
            this.bowImageBar.Size = new System.Drawing.Size(51, 48);
            this.bowImageBar.TabIndex = 7;
            this.bowImageBar.TabStop = false;
            this.bowImageBar.Click += new System.EventHandler(this.bowImageBar_Click);
            // 
            // swordImageBar
            // 
            this.swordImageBar.BackColor = System.Drawing.Color.Transparent;
            this.swordImageBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swordImageBar.Image = ((System.Drawing.Image)(resources.GetObject("swordImageBar.Image")));
            this.swordImageBar.Location = new System.Drawing.Point(72, 320);
            this.swordImageBar.Name = "swordImageBar";
            this.swordImageBar.Size = new System.Drawing.Size(51, 48);
            this.swordImageBar.TabIndex = 8;
            this.swordImageBar.TabStop = false;
            this.swordImageBar.Click += new System.EventHandler(this.swordImageBar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.moveDownButton);
            this.groupBox1.Controls.Add(this.moveRightButton);
            this.groupBox1.Controls.Add(this.moveUpButton);
            this.groupBox1.Controls.Add(this.moveLeftButton);
            this.groupBox1.Location = new System.Drawing.Point(354, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(35, 50);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(28, 23);
            this.moveDownButton.TabIndex = 3;
            this.moveDownButton.Text = "↓";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(53, 24);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(28, 23);
            this.moveRightButton.TabIndex = 2;
            this.moveRightButton.Text = "→";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(36, 0);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(28, 23);
            this.moveUpButton.TabIndex = 1;
            this.moveUpButton.Text = "↑";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(19, 25);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(28, 23);
            this.moveLeftButton.TabIndex = 0;
            this.moveLeftButton.Text = "←";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.attackDownButton);
            this.groupBox2.Controls.Add(this.attackRightButton);
            this.groupBox2.Controls.Add(this.attackUpButton);
            this.groupBox2.Controls.Add(this.attackLeftButton);
            this.groupBox2.Location = new System.Drawing.Point(445, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 73);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // attackDownButton
            // 
            this.attackDownButton.Location = new System.Drawing.Point(35, 50);
            this.attackDownButton.Name = "attackDownButton";
            this.attackDownButton.Size = new System.Drawing.Size(28, 23);
            this.attackDownButton.TabIndex = 3;
            this.attackDownButton.Text = "↓";
            this.attackDownButton.UseVisualStyleBackColor = true;
            this.attackDownButton.Click += new System.EventHandler(this.attackDownButton_Click);
            // 
            // attackRightButton
            // 
            this.attackRightButton.Location = new System.Drawing.Point(53, 24);
            this.attackRightButton.Name = "attackRightButton";
            this.attackRightButton.Size = new System.Drawing.Size(28, 23);
            this.attackRightButton.TabIndex = 2;
            this.attackRightButton.Text = "→";
            this.attackRightButton.UseVisualStyleBackColor = true;
            this.attackRightButton.Click += new System.EventHandler(this.attackRightButton_Click);
            // 
            // attackUpButton
            // 
            this.attackUpButton.Location = new System.Drawing.Point(36, 0);
            this.attackUpButton.Name = "attackUpButton";
            this.attackUpButton.Size = new System.Drawing.Size(28, 23);
            this.attackUpButton.TabIndex = 1;
            this.attackUpButton.Text = "↑";
            this.attackUpButton.UseVisualStyleBackColor = true;
            this.attackUpButton.Click += new System.EventHandler(this.attackUpButton_Click);
            // 
            // attackLeftButton
            // 
            this.attackLeftButton.Location = new System.Drawing.Point(19, 25);
            this.attackLeftButton.Name = "attackLeftButton";
            this.attackLeftButton.Size = new System.Drawing.Size(28, 23);
            this.attackLeftButton.TabIndex = 0;
            this.attackLeftButton.Text = "←";
            this.attackLeftButton.UseVisualStyleBackColor = true;
            this.attackLeftButton.Click += new System.EventHandler(this.attackLeftButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.21622F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.78378F));
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(358, 245);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(148, 56);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(64, 43);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(35, 13);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghoul";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(64, 28);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(35, 13);
            this.ghostHitPoints.TabIndex = 5;
            this.ghostHitPoints.Text = "label6";
            this.ghostHitPoints.Click += new System.EventHandler(this.ghostHitPoints_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghost";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(64, 14);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(0, 13);
            this.batHitPoints.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bat";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(64, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(35, 13);
            this.playerHitPoints.TabIndex = 1;
            this.playerHitPoints.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // swordImage
            // 
            this.swordImage.BackColor = System.Drawing.Color.Transparent;
            this.swordImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swordImage.Image = ((System.Drawing.Image)(resources.GetObject("swordImage.Image")));
            this.swordImage.Location = new System.Drawing.Point(278, 77);
            this.swordImage.Name = "swordImage";
            this.swordImage.Size = new System.Drawing.Size(51, 48);
            this.swordImage.TabIndex = 12;
            this.swordImage.TabStop = false;
            // 
            // bluePotionImage
            // 
            this.bluePotionImage.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bluePotionImage.Image = ((System.Drawing.Image)(resources.GetObject("bluePotionImage.Image")));
            this.bluePotionImage.Location = new System.Drawing.Point(335, 77);
            this.bluePotionImage.Name = "bluePotionImage";
            this.bluePotionImage.Size = new System.Drawing.Size(51, 48);
            this.bluePotionImage.TabIndex = 13;
            this.bluePotionImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 397);
            this.Controls.Add(this.bluePotionImage);
            this.Controls.Add(this.swordImage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.swordImageBar);
            this.Controls.Add(this.bowImageBar);
            this.Controls.Add(this.maceImageBar);
            this.Controls.Add(this.bluePotionImageBar);
            this.Controls.Add(this.redPotionImageBar);
            this.Controls.Add(this.ghostImage);
            this.Controls.Add(this.batImage);
            this.Controls.Add(this.playerImage);
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionImageBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionImageBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceImageBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowImageBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordImageBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.PictureBox batImage;
        private System.Windows.Forms.PictureBox ghostImage;
        private System.Windows.Forms.PictureBox redPotionImageBar;
        private System.Windows.Forms.PictureBox bluePotionImageBar;
        private System.Windows.Forms.PictureBox maceImageBar;
        private System.Windows.Forms.PictureBox bowImageBar;
        private System.Windows.Forms.PictureBox swordImageBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button attackDownButton;
        private System.Windows.Forms.Button attackRightButton;
        private System.Windows.Forms.Button attackUpButton;
        private System.Windows.Forms.Button attackLeftButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox swordImage;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bluePotionImage;
    }
}

