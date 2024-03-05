
namespace SecureCodeFull
{
    partial class splash
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circProgBar = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "HYPERSPACE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "TRAVELERS";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circProgBar
            // 
            this.circProgBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circProgBar.AnimationSpeed = 500;
            this.circProgBar.BackColor = System.Drawing.Color.Transparent;
            this.circProgBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circProgBar.ForeColor = System.Drawing.Color.Transparent;
            this.circProgBar.InnerColor = System.Drawing.Color.Transparent;
            this.circProgBar.InnerMargin = 2;
            this.circProgBar.InnerWidth = -1;
            this.circProgBar.Location = new System.Drawing.Point(225, 199);
            this.circProgBar.Margin = new System.Windows.Forms.Padding(2);
            this.circProgBar.MarqueeAnimationSpeed = 2500;
            this.circProgBar.Name = "circProgBar";
            this.circProgBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.circProgBar.OuterMargin = -25;
            this.circProgBar.OuterWidth = 26;
            this.circProgBar.ProgressColor = System.Drawing.Color.DarkRed;
            this.circProgBar.ProgressWidth = 15;
            this.circProgBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circProgBar.Size = new System.Drawing.Size(50, 50);
            this.circProgBar.StartAngle = 270;
            this.circProgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circProgBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circProgBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circProgBar.SubscriptText = ".23";
            this.circProgBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circProgBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circProgBar.SuperscriptText = "°C";
            this.circProgBar.TabIndex = 2;
            this.circProgBar.Text = "circularProgressBar1";
            this.circProgBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circProgBar.Value = 100;
            this.circProgBar.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecureCodeFull.Properties.Resources.splashimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 344);
            this.Controls.Add(this.circProgBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "splash";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar circProgBar;
    }
}

