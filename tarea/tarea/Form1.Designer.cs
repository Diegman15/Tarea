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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.LbName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.Location = new System.Drawing.Point(88, 69);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(87, 24);
            this.LbName.TabIndex = 0;
            this.LbName.Text = "Usuario";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbPassword.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.Location = new System.Drawing.Point(88, 135);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(127, 24);
            this.LbPassword.TabIndex = 1;
            this.LbPassword.Text = "Contraseña";
            // 
            // BtLogin
            // 
            this.BtLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtLogin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogin.Location = new System.Drawing.Point(390, 287);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(132, 63);
            this.BtLogin.TabIndex = 2;
            this.BtLogin.Text = "Iniciar sesión";
            this.BtLogin.UseVisualStyleBackColor = false;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // BtExit
            // 
            this.BtExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtExit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExit.Location = new System.Drawing.Point(74, 305);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(153, 45);
            this.BtExit.TabIndex = 3;
            this.BtExit.Text = "Salir";
            this.BtExit.UseVisualStyleBackColor = false;
            // 
            // TbName
            // 
            this.TbName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbName.Location = new System.Drawing.Point(371, 61);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(192, 32);
            this.TbName.TabIndex = 4;
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(375, 127);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(188, 32);
            this.TbPassword.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

