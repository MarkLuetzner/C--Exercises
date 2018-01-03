namespace Exercise_p202
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dekoCheckBox = new System.Windows.Forms.CheckBox();
            this.trockenCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kostenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(38, 103);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personenanzahl";
            // 
            // dekoCheckBox
            // 
            this.dekoCheckBox.AutoSize = true;
            this.dekoCheckBox.Location = new System.Drawing.Point(41, 130);
            this.dekoCheckBox.Name = "dekoCheckBox";
            this.dekoCheckBox.Size = new System.Drawing.Size(126, 17);
            this.dekoCheckBox.TabIndex = 2;
            this.dekoCheckBox.Text = "Exklusive Dekoration";
            this.dekoCheckBox.UseVisualStyleBackColor = true;
            this.dekoCheckBox.CheckedChanged += new System.EventHandler(this.dekoCheckBox_CheckedChanged);
            // 
            // trockenCheckBox
            // 
            this.trockenCheckBox.AutoSize = true;
            this.trockenCheckBox.Location = new System.Drawing.Point(41, 154);
            this.trockenCheckBox.Name = "trockenCheckBox";
            this.trockenCheckBox.Size = new System.Drawing.Size(109, 17);
            this.trockenCheckBox.TabIndex = 3;
            this.trockenCheckBox.Text = "Trockener Abend";
            this.trockenCheckBox.UseVisualStyleBackColor = true;
            this.trockenCheckBox.CheckedChanged += new System.EventHandler(this.trockenCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kosten";
            // 
            // kostenLabel
            // 
            this.kostenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kostenLabel.Location = new System.Drawing.Point(150, 186);
            this.kostenLabel.Name = "kostenLabel";
            this.kostenLabel.Size = new System.Drawing.Size(100, 23);
            this.kostenLabel.TabIndex = 5;
            this.kostenLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.kostenLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trockenCheckBox);
            this.Controls.Add(this.dekoCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Abendessen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox dekoCheckBox;
        private System.Windows.Forms.CheckBox trockenCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kostenLabel;
    }
}

