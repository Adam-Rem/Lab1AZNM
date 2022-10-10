namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stoper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(239, 58);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(49, 15);
            this.clock.TabIndex = 0;
            this.clock.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stoper
            // 
            this.stoper.Location = new System.Drawing.Point(201, 76);
            this.stoper.Name = "stoper";
            this.stoper.Size = new System.Drawing.Size(130, 48);
            this.stoper.TabIndex = 1;
            this.stoper.Text = "STOPER";
            this.stoper.UseVisualStyleBackColor = true;
            this.stoper.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 175);
            this.Controls.Add(this.stoper);
            this.Controls.Add(this.clock);
            this.Name = "Form1";
            this.Text = "Clock + Stoper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label clock;
        private System.Windows.Forms.Timer timer1;
        private Button stoper;
    }
}