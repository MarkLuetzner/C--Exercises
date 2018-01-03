namespace Exercise_p177
{
    partial class Tippspiel
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.richtigLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.falschLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gesamtLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.schwierigkeitProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(856, 132);
            this.listBox1.TabIndex = 0;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.richtigLabel,
            this.falschLabel,
            this.gesamtLabel,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.schwierigkeitProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 110);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // richtigLabel
            // 
            this.richtigLabel.Name = "richtigLabel";
            this.richtigLabel.Size = new System.Drawing.Size(56, 17);
            this.richtigLabel.Text = "Richtig: 0";
            // 
            // falschLabel
            // 
            this.falschLabel.Name = "falschLabel";
            this.falschLabel.Size = new System.Drawing.Size(51, 17);
            this.falschLabel.Text = "Fehler: 0";
            // 
            // gesamtLabel
            // 
            this.gesamtLabel.Name = "gesamtLabel";
            this.gesamtLabel.Size = new System.Drawing.Size(59, 17);
            this.gesamtLabel.Text = "Gesamt: 0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel3.Text = "Trefferquote: 0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(488, 17);
            this.toolStripStatusLabel4.Spring = true;
            this.toolStripStatusLabel4.Text = "Schwierigkeit";
            this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // schwierigkeitProgressBar
            // 
            this.schwierigkeitProgressBar.Maximum = 701;
            this.schwierigkeitProgressBar.Name = "schwierigkeitProgressBar";
            this.schwierigkeitProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // Tippspiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 132);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tippspiel";
            this.Text = "Tippspiel";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel richtigLabel;
        private System.Windows.Forms.ToolStripStatusLabel falschLabel;
        private System.Windows.Forms.ToolStripStatusLabel gesamtLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripProgressBar schwierigkeitProgressBar;
    }
}

