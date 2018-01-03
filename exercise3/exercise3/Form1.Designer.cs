namespace exercise3
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
            this.textÄndern = new System.Windows.Forms.Button();
            this.checkAktivieren = new System.Windows.Forms.CheckBox();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textÄndern
            // 
            this.textÄndern.AutoSize = true;
            this.textÄndern.Location = new System.Drawing.Point(28, 12);
            this.textÄndern.Name = "textÄndern";
            this.textÄndern.Size = new System.Drawing.Size(196, 23);
            this.textÄndern.TabIndex = 0;
            this.textÄndern.Text = "Label bei aktivierter Checkbox ändern";
            this.textÄndern.UseVisualStyleBackColor = true;
            this.textÄndern.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkAktivieren
            // 
            this.checkAktivieren.AutoSize = true;
            this.checkAktivieren.Location = new System.Drawing.Point(310, 16);
            this.checkAktivieren.Name = "checkAktivieren";
            this.checkAktivieren.Size = new System.Drawing.Size(150, 17);
            this.checkAktivieren.TabIndex = 1;
            this.checkAktivieren.Text = "Label-Änderung aktivieren";
            this.checkAktivieren.UseVisualStyleBackColor = true;
            this.checkAktivieren.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(180, 59);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(168, 13);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "Button betätigen um text zu sehen";
            this.labelText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 92);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.checkAktivieren);
            this.Controls.Add(this.textÄndern);
            this.Name = "Form1";
            this.Text = "Meine Desktop-Anwendung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button textÄndern;
        private System.Windows.Forms.CheckBox checkAktivieren;
        private System.Windows.Forms.Label labelText;
    }
}

