
namespace SecureCodeFull
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExitLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(89, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "FORM1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(89, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "FORM2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(89, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "FORM3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(89, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "FROM4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnExitLogin.BackgroundImage = global::SecureCodeFull.Properties.Resources.SalirButton;
            this.btnExitLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitLogin.FlatAppearance.BorderSize = 0;
            this.btnExitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnExitLogin.Location = new System.Drawing.Point(733, 23);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(44, 50);
            this.btnExitLogin.TabIndex = 10;
            this.btnExitLogin.UseVisualStyleBackColor = false;
            this.btnExitLogin.Click += new System.EventHandler(this.btnExitLogin_Click_1);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(264, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 292);
            this.panel1.TabIndex = 11;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecureCodeFull.Properties.Resources.MAIN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExitLogin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExitLogin;
        private System.Windows.Forms.Panel panel1;
    }
}