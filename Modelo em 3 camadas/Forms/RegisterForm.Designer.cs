namespace Modelo_em_3_camadas
{
    partial class RegisterForm
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
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_contato = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro.Location = new System.Drawing.Point(16, 233);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(196, 38);
            this.btn_cadastro.TabIndex = 17;
            this.btn_cadastro.Text = "Cadastrar";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(12, 74);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(68, 22);
            this.lb_email.TabIndex = 16;
            this.lb_email.Text = "E-mail:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(16, 99);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(196, 29);
            this.txt_email.TabIndex = 15;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(12, 9);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(66, 22);
            this.lb_name.TabIndex = 14;
            this.lb_name.Text = "Nome:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(16, 34);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(196, 29);
            this.txt_name.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Contato:";
            // 
            // mtb_contato
            // 
            this.mtb_contato.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_contato.Location = new System.Drawing.Point(16, 167);
            this.mtb_contato.Mask = "(00) 00000-0000";
            this.mtb_contato.Name = "mtb_contato";
            this.mtb_contato.Size = new System.Drawing.Size(196, 29);
            this.mtb_contato.TabIndex = 20;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 292);
            this.Controls.Add(this.mtb_contato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.txt_name);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_contato;
    }
}