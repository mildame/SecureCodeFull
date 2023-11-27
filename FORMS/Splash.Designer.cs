
namespace SecureCodeFull
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.timerLoadScreen = new System.Windows.Forms.Timer(this.components);
            this.progBarSplash = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // timerLoadScreen
            // 
            this.timerLoadScreen.Interval = 300;
            this.timerLoadScreen.Tick += new System.EventHandler(this.timerLoadScreen_Tick);
            // 
            // progBarSplash
            // 
            this.progBarSplash.Location = new System.Drawing.Point(125, 400);
            this.progBarSplash.Name = "progBarSplash";
            this.progBarSplash.Size = new System.Drawing.Size(525, 23);
            this.progBarSplash.TabIndex = 0;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecureCodeFull.Properties.Resources.hyperspae;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progBarSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Splash_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Splash_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Splash_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerLoadScreen;
        private System.Windows.Forms.ProgressBar progBarSplash;
    }
}