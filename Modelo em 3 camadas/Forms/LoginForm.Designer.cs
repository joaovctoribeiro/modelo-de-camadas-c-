namespace Modelo_em_3_camadas.Forms
{
    partial class LoginForm
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
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(12, 152);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(196, 38);
            this.btn_login.TabIndex = 12;
            this.btn_login.Text = "Logar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(8, 78);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(68, 22);
            this.lb_email.TabIndex = 11;
            this.lb_email.Text = "E-mail:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(12, 103);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(196, 29);
            this.txt_email.TabIndex = 10;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(8, 13);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(66, 22);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "Nome:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(12, 38);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(196, 29);
            this.txt_name.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 206);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.txt_name);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox txt_name;
    }
}