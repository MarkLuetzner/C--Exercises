namespace Exercise_p332
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
            this.beschreibung = new System.Windows.Forms.TextBox();
            this.hierhinGehen = new System.Windows.Forms.Button();
            this.ausgänge = new System.Windows.Forms.ComboBox();
            this.durchTürGehen = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beschreibung
            // 
            this.beschreibung.Location = new System.Drawing.Point(3, 3);
            this.beschreibung.Multiline = true;
            this.beschreibung.Name = "beschreibung";
            this.beschreibung.Size = new System.Drawing.Size(278, 183);
            this.beschreibung.TabIndex = 0;
            // 
            // hierhinGehen
            // 
            this.hierhinGehen.Location = new System.Drawing.Point(3, 193);
            this.hierhinGehen.Name = "hierhinGehen";
            this.hierhinGehen.Size = new System.Drawing.Size(129, 23);
            this.hierhinGehen.TabIndex = 1;
            this.hierhinGehen.Text = "Hierhin gehen";
            this.hierhinGehen.UseVisualStyleBackColor = true;
            this.hierhinGehen.Click += new System.EventHandler(this.hierhinGehen_Click);
            // 
            // ausgänge
            // 
            this.ausgänge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ausgänge.FormattingEnabled = true;
            this.ausgänge.Location = new System.Drawing.Point(138, 194);
            this.ausgänge.Name = "ausgänge";
            this.ausgänge.Size = new System.Drawing.Size(143, 21);
            this.ausgänge.TabIndex = 2;
            // 
            // durchTürGehen
            // 
            this.durchTürGehen.Location = new System.Drawing.Point(3, 226);
            this.durchTürGehen.Name = "durchTürGehen";
            this.durchTürGehen.Size = new System.Drawing.Size(278, 23);
            this.durchTürGehen.TabIndex = 3;
            this.durchTürGehen.Text = "Durch die Tür gehen";
            this.durchTürGehen.UseVisualStyleBackColor = true;
            this.durchTürGehen.Click += new System.EventHandler(this.durchTürGehen_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(3, 256);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(278, 23);
            this.check.TabIndex = 4;
            this.check.Text = "Check!";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(3, 286);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(278, 23);
            this.hide.TabIndex = 5;
            this.hide.Text = "Hide!";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 324);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.check);
            this.Controls.Add(this.durchTürGehen);
            this.Controls.Add(this.ausgänge);
            this.Controls.Add(this.hierhinGehen);
            this.Controls.Add(this.beschreibung);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox beschreibung;
        private System.Windows.Forms.Button hierhinGehen;
        private System.Windows.Forms.ComboBox ausgänge;
        private System.Windows.Forms.Button durchTürGehen;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button hide;
    }
}

