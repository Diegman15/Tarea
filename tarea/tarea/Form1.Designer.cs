namespace tarea
{
    partial class Form1
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
            this.LbName = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.BtLogin = new System.Windows.Forms.Button();
            this.BtExit = new System.Windows.Forms.Button();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Location = new System.Drawing.Point(88, 69);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(43, 13);
            this.LbName.TabIndex = 0;
            this.LbName.Text = "Usuario";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Location = new System.Drawing.Point(88, 135);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(61, 13);
            this.LbPassword.TabIndex = 1;
            this.LbPassword.Text = "Contraseña";
            // 
            // BtLogin
            // 
            this.BtLogin.Location = new System.Drawing.Point(542, 261);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(132, 42);
            this.BtLogin.TabIndex = 2;
            this.BtLogin.Text = "Iniciar sesión";
            this.BtLogin.UseVisualStyleBackColor = true;
            // 
            // BtExit
            // 
            this.BtExit.Location = new System.Drawing.Point(153, 258);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(153, 45);
            this.BtExit.TabIndex = 3;
            this.BtExit.Text = "Salir";
            this.BtExit.UseVisualStyleBackColor = true;
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(392, 46);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(192, 20);
            this.TbName.TabIndex = 4;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(392, 117);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(188, 20);
            this.TbPassword.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbName);
            this.Name = "Form1";
            this.Text = "Avengers Assamble - Iniciar sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Button BtLogin;
        private System.Windows.Forms.Button BtExit;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbPassword;
    }
}

