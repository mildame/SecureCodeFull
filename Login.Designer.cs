
namespace SecureCodeFull
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnExitLogin = new System.Windows.Forms.Button();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblBenvingut = new System.Windows.Forms.Label();
            this.lblUserData = new System.Windows.Forms.Label();
            this.lblComunicating = new System.Windows.Forms.Label();
            this.timerLoadNext = new System.Windows.Forms.Timer(this.components);
            this.timerFlash = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnExitLogin.BackgroundImage = global::SecureCodeFull.Properties.Resources.SalirButton;
            this.btnExitLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExitLogin.FlatAppearance.BorderSize = 0;
            this.btnExitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnExitLogin.Location = new System.Drawing.Point(107, 501);
            this.btnExitLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(73, 76);
            this.btnExitLogin.TabIndex = 9;
            this.btnExitLogin.UseVisualStyleBackColor = false;
            this.btnExitLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.BackColor = System.Drawing.Color.White;
            this.txtBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUser.Location = new System.Drawing.Point(240, 240);
            this.txtBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(250, 22);
            this.txtBoxUser.TabIndex = 1;

            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(240, 283);
            this.txtBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.Size = new System.Drawing.Size(249, 22);
            this.txtBoxPass.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(115, 241);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(72, 31);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPass.Location = new System.Drawing.Point(107, 284);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(79, 31);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Code";
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Transparent;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValidar.Location = new System.Drawing.Point(343, 330);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(148, 39);
            this.btnValidar.TabIndex = 5;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;

            // 
            // lblBenvingut
            // 
            this.lblBenvingut.AutoSize = true;
            this.lblBenvingut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenvingut.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBenvingut.Location = new System.Drawing.Point(191, 395);
            this.lblBenvingut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBenvingut.Name = "lblBenvingut";
            this.lblBenvingut.Size = new System.Drawing.Size(180, 25);
            this.lblBenvingut.TabIndex = 6;
            this.lblBenvingut.Text = "aaaaaaaaaaaaaa";
            // 
            // lblUserData
            // 
            this.lblUserData.AutoSize = true;
            this.lblUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserData.Location = new System.Drawing.Point(191, 432);
            this.lblUserData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserData.Name = "lblUserData";
            this.lblUserData.Size = new System.Drawing.Size(64, 25);
            this.lblUserData.TabIndex = 7;
            this.lblUserData.Text = "label1";
            // 
            // lblComunicating
            // 
            this.lblComunicating.AutoSize = true;
            this.lblComunicating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComunicating.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComunicating.Location = new System.Drawing.Point(191, 490);
            this.lblComunicating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComunicating.Name = "lblComunicating";
            this.lblComunicating.Size = new System.Drawing.Size(64, 25);
            this.lblComunicating.TabIndex = 8;
            this.lblComunicating.Text = "label1";
            this.lblComunicating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLoadNext
            // 
            this.timerLoadNext.Tick += new System.EventHandler(this.timerLoadNext_Tick);
            // 
            // timerFlash
            // 
            this.timerFlash.Interval = 400;
            this.timerFlash.Tick += new System.EventHandler(this.timerFlash_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecureCodeFull.Properties.Resources.login3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1365, 709);
            this.Controls.Add(this.lblComunicating);
            this.Controls.Add(this.lblUserData);
            this.Controls.Add(this.lblBenvingut);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.btnExitLogin);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Code";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitLogin;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblBenvingut;
        private System.Windows.Forms.Label lblUserData;
        private System.Windows.Forms.Label lblComunicating;
        private System.Windows.Forms.Timer timerLoadNext;
        private System.Windows.Forms.Timer timerFlash;
    }
}

