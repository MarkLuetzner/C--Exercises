namespace Exercise_p240
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.kostenLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trockenBox = new System.Windows.Forms.CheckBox();
            this.exklusivBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zuLangLabel = new System.Windows.Forms.Label();
            this.kostenGeburtstag = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kuchenText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exklusiverGeburtstag = new System.Windows.Forms.CheckBox();
            this.anzahlGeburtstag = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anzahlGeburtstag)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(261, 249);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.kostenLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.trockenBox);
            this.tabPage1.Controls.Add(this.exklusivBox);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(253, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Abendessen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // kostenLabel
            // 
            this.kostenLabel.AutoSize = true;
            this.kostenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kostenLabel.Location = new System.Drawing.Point(110, 159);
            this.kostenLabel.Name = "kostenLabel";
            this.kostenLabel.Size = new System.Drawing.Size(27, 15);
            this.kostenLabel.TabIndex = 11;
            this.kostenLabel.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kosten";
            // 
            // trockenBox
            // 
            this.trockenBox.AutoSize = true;
            this.trockenBox.Location = new System.Drawing.Point(66, 136);
            this.trockenBox.Name = "trockenBox";
            this.trockenBox.Size = new System.Drawing.Size(109, 17);
            this.trockenBox.TabIndex = 9;
            this.trockenBox.Text = "Trockener Abend";
            this.trockenBox.UseVisualStyleBackColor = true;
            this.trockenBox.CheckedChanged += new System.EventHandler(this.trockenBox_CheckedChanged);
            // 
            // exklusivBox
            // 
            this.exklusivBox.AutoSize = true;
            this.exklusivBox.Location = new System.Drawing.Point(66, 113);
            this.exklusivBox.Name = "exklusivBox";
            this.exklusivBox.Size = new System.Drawing.Size(100, 17);
            this.exklusivBox.TabIndex = 8;
            this.exklusivBox.Text = "Exklusive Deko";
            this.exklusivBox.UseVisualStyleBackColor = true;
            this.exklusivBox.CheckedChanged += new System.EventHandler(this.exklusivBox_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(66, 87);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.zuLangLabel);
            this.tabPage2.Controls.Add(this.kostenGeburtstag);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.kuchenText);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.exklusiverGeburtstag);
            this.tabPage2.Controls.Add(this.anzahlGeburtstag);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(253, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geburtstagsfeier";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zuLangLabel
            // 
            this.zuLangLabel.AutoSize = true;
            this.zuLangLabel.Location = new System.Drawing.Point(121, 129);
            this.zuLangLabel.Name = "zuLangLabel";
            this.zuLangLabel.Size = new System.Drawing.Size(47, 13);
            this.zuLangLabel.TabIndex = 7;
            this.zuLangLabel.Text = "Zu Lang";
            this.zuLangLabel.TextChanged += new System.EventHandler(this.kuchenText_TextChanged);
            // 
            // kostenGeburtstag
            // 
            this.kostenGeburtstag.AutoSize = true;
            this.kostenGeburtstag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kostenGeburtstag.Location = new System.Drawing.Point(98, 173);
            this.kostenGeburtstag.Name = "kostenGeburtstag";
            this.kostenGeburtstag.Size = new System.Drawing.Size(27, 15);
            this.kostenGeburtstag.TabIndex = 6;
            this.kostenGeburtstag.Text = "filler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kosten";
            // 
            // kuchenText
            // 
            this.kuchenText.Location = new System.Drawing.Point(53, 146);
            this.kuchenText.Name = "kuchenText";
            this.kuchenText.Size = new System.Drawing.Size(100, 20);
            this.kuchenText.TabIndex = 4;
            this.kuchenText.TextChanged += new System.EventHandler(this.kuchenText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kuchentext";
            // 
            // exklusiverGeburtstag
            // 
            this.exklusiverGeburtstag.AutoSize = true;
            this.exklusiverGeburtstag.Location = new System.Drawing.Point(53, 105);
            this.exklusiverGeburtstag.Name = "exklusiverGeburtstag";
            this.exklusiverGeburtstag.Size = new System.Drawing.Size(126, 17);
            this.exklusiverGeburtstag.TabIndex = 2;
            this.exklusiverGeburtstag.Text = "Exklusive Dekoration";
            this.exklusiverGeburtstag.UseVisualStyleBackColor = true;
            this.exklusiverGeburtstag.CheckedChanged += new System.EventHandler(this.exklusiverGeburtstag_CheckedChanged);
            // 
            // anzahlGeburtstag
            // 
            this.anzahlGeburtstag.Location = new System.Drawing.Point(53, 78);
            this.anzahlGeburtstag.Name = "anzahlGeburtstag";
            this.anzahlGeburtstag.Size = new System.Drawing.Size(120, 20);
            this.anzahlGeburtstag.TabIndex = 1;
            this.anzahlGeburtstag.ValueChanged += new System.EventHandler(this.anzahlGeburtstag_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personenanzahl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(260, 248);
            this.Controls.Add(this.tabControl1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "Party-Planer 2.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anzahlGeburtstag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kostenLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox trockenBox;
        private System.Windows.Forms.CheckBox exklusivBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label zuLangLabel;
        private System.Windows.Forms.Label kostenGeburtstag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kuchenText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox exklusiverGeburtstag;
        private System.Windows.Forms.NumericUpDown anzahlGeburtstag;
        private System.Windows.Forms.Label label3;
    }
}

