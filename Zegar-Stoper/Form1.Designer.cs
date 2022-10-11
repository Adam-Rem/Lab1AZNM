namespace Zegar_Stoper
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zegar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stoper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zegar
            // 
            this.zegar.AutoSize = true;
            this.zegar.Font = new System.Drawing.Font("Castellar", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zegar.Location = new System.Drawing.Point(181, 69);
            this.zegar.Name = "zegar";
            this.zegar.Size = new System.Drawing.Size(214, 48);
            this.zegar.TabIndex = 0;
            this.zegar.Text = "00:00:00";
            this.zegar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.zegar.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stoper
            // 
            this.stoper.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stoper.Location = new System.Drawing.Point(189, 160);
            this.stoper.Name = "stoper";
            this.stoper.Size = new System.Drawing.Size(206, 30);
            this.stoper.TabIndex = 1;
            this.stoper.Text = "STOPER";
            this.stoper.UseVisualStyleBackColor = true;
            this.stoper.Click += new System.EventHandler(this.stoper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.stoper);
            this.Controls.Add(this.zegar);
            this.Name = "Form1";
            this.Text = "Zegar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zegar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stoper;
    }
}

