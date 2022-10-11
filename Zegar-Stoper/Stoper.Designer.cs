namespace Zegar_Stoper
{
    partial class Stoper
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
            this.components = new System.ComponentModel.Container();
            this.stoper1 = new System.Windows.Forms.Label();
            this.startb = new System.Windows.Forms.Button();
            this.stopb = new System.Windows.Forms.Button();
            this.resetb = new System.Windows.Forms.Button();
            this.timers = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // stoper1
            // 
            this.stoper1.AutoSize = true;
            this.stoper1.Font = new System.Drawing.Font("Castellar", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoper1.Location = new System.Drawing.Point(124, 68);
            this.stoper1.Name = "stoper1";
            this.stoper1.Size = new System.Drawing.Size(214, 48);
            this.stoper1.TabIndex = 1;
            this.stoper1.Text = "00:00:00";
            this.stoper1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stoper1.UseWaitCursor = true;
            // 
            // startb
            // 
            this.startb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startb.Location = new System.Drawing.Point(79, 174);
            this.startb.Name = "startb";
            this.startb.Size = new System.Drawing.Size(94, 42);
            this.startb.TabIndex = 2;
            this.startb.Text = "START";
            this.startb.UseVisualStyleBackColor = true;
            this.startb.Click += new System.EventHandler(this.startb_Click);
            // 
            // stopb
            // 
            this.stopb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopb.Location = new System.Drawing.Point(179, 174);
            this.stopb.Name = "stopb";
            this.stopb.Size = new System.Drawing.Size(94, 42);
            this.stopb.TabIndex = 3;
            this.stopb.Text = "STOP";
            this.stopb.UseVisualStyleBackColor = true;
            this.stopb.Click += new System.EventHandler(this.stopb_Click);
            // 
            // resetb
            // 
            this.resetb.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetb.Location = new System.Drawing.Point(279, 174);
            this.resetb.Name = "resetb";
            this.resetb.Size = new System.Drawing.Size(94, 42);
            this.resetb.TabIndex = 4;
            this.resetb.Text = "RESET";
            this.resetb.UseVisualStyleBackColor = true;
            this.resetb.Click += new System.EventHandler(this.resetb_Click);
            // 
            // timers
            // 
            this.timers.Tick += new System.EventHandler(this.timers_Tick);
            // 
            // Stoper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 309);
            this.Controls.Add(this.resetb);
            this.Controls.Add(this.stopb);
            this.Controls.Add(this.startb);
            this.Controls.Add(this.stoper1);
            this.Name = "Stoper";
            this.Text = "Stoper";
            this.Load += new System.EventHandler(this.Stoper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stoper1;
        private System.Windows.Forms.Button startb;
        private System.Windows.Forms.Button stopb;
        private System.Windows.Forms.Button resetb;
        private System.Windows.Forms.Timer timers;
    }
}