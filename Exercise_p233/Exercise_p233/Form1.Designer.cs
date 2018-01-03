namespace Exercise_p233
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
            this.exklusivBox = new System.Windows.Forms.CheckBox();
            this.trockenBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kostenLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(86, 63);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // exklusivBox
            // 
            this.exklusivBox.AutoSize = true;
            this.exklusivBox.Location = new System.Drawing.Point(86, 89);
            this.exklusivBox.Name = "exklusivBox";
            this.exklusivBox.Size = new System.Drawing.Size(100, 17);
            this.exklusivBox.TabIndex = 2;
            this.exklusivBox.Text = "Exklusive Deko";
            this.exklusivBox.UseVisualStyleBackColor = true;
            this.exklusivBox.CheckedChanged += new System.EventHandler(this.dekoCheckBox1_CheckedChanged);
            // 
            // trockenBox
            // 
            this.trockenBox.AutoSize = true;
            this.trockenBox.Location = new System.Drawing.Point(86, 112);
            this.trockenBox.Name = "trockenBox";
            this.trockenBox.Size = new System.Drawing.Size(109, 17);
            this.trockenBox.TabIndex = 3;
            this.trockenBox.Text = "Trockener Abend";
            this.trockenBox.UseVisualStyleBackColor = true;
            this.trockenBox.CheckedChanged += new System.EventHandler(this.trockenerAbendCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kosten";
            // 
            // kostenLabel
            // 
            this.kostenLabel.AutoSize = true;
            this.kostenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kostenLabel.Location = new System.Drawing.Point(130, 135);
            this.kostenLabel.Name = "kostenLabel";
            this.kostenLabel.Size = new System.Drawing.Size(27, 15);
            this.kostenLabel.TabIndex = 5;
            this.kostenLabel.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kostenLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trockenBox);
            this.Controls.Add(this.exklusivBox);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox exklusivBox;
        private System.Windows.Forms.CheckBox trockenBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kostenLabel;
        private System.Windows.Forms.Label label1;
    }
}

