namespace Modelo_em_3_camadas.Forms
{
    partial class MainForm
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
            this.btn_funcionarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_acesso = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_funcionarios
            // 
            this.btn_funcionarios.Location = new System.Drawing.Point(12, 12);
            this.btn_funcionarios.Name = "btn_funcionarios";
            this.btn_funcionarios.Size = new System.Drawing.Size(249, 40);
            this.btn_funcionarios.TabIndex = 0;
            this.btn_funcionarios.Text = "Funcionários";
            this.btn_funcionarios.UseVisualStyleBackColor = true;
            this.btn_funcionarios.Click += new System.EventHandler(this.btn_funcionarios_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lbl_acesso);
            this.panel1.Controls.Add(this.lbl_usuario);
            this.panel1.Location = new System.Drawing.Point(-6, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 61);
            this.panel1.TabIndex = 1;
            // 
            // lbl_acesso
            // 
            this.lbl_acesso.AutoSize = true;
            this.lbl_acesso.Location = new System.Drawing.Point(174, 25);
            this.lbl_acesso.Name = "lbl_acesso";
            this.lbl_acesso.Size = new System.Drawing.Size(35, 13);
            this.lbl_acesso.TabIndex = 3;
            this.lbl_acesso.Text = "label2";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(18, 25);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(35, 13);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "label1";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(156, 188);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(105, 26);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Sair do sistema";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 278);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_funcionarios);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_funcionarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_acesso;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btn_close;
    }
}