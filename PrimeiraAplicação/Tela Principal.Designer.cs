
namespace PrimeiraAplicação
{
    partial class Tela_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            this.btnIrParaOlogin = new System.Windows.Forms.Button();
            this.btnIrParaOCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIrParaOlogin
            // 
            this.btnIrParaOlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIrParaOlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrParaOlogin.ForeColor = System.Drawing.Color.White;
            this.btnIrParaOlogin.Location = new System.Drawing.Point(88, 171);
            this.btnIrParaOlogin.Name = "btnIrParaOlogin";
            this.btnIrParaOlogin.Size = new System.Drawing.Size(110, 39);
            this.btnIrParaOlogin.TabIndex = 1;
            this.btnIrParaOlogin.Text = "Login";
            this.btnIrParaOlogin.UseVisualStyleBackColor = false;
            this.btnIrParaOlogin.Click += new System.EventHandler(this.btnIrParaOlogin_Click);
            // 
            // btnIrParaOCadastro
            // 
            this.btnIrParaOCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIrParaOCadastro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIrParaOCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnIrParaOCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrParaOCadastro.ForeColor = System.Drawing.Color.White;
            this.btnIrParaOCadastro.Location = new System.Drawing.Point(347, 171);
            this.btnIrParaOCadastro.Name = "btnIrParaOCadastro";
            this.btnIrParaOCadastro.Size = new System.Drawing.Size(110, 39);
            this.btnIrParaOCadastro.TabIndex = 2;
            this.btnIrParaOCadastro.Text = "Cadastro";
            this.btnIrParaOCadastro.UseVisualStyleBackColor = false;
            this.btnIrParaOCadastro.Click += new System.EventHandler(this.btnIrParaOCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem Vindo Úsuario";
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnLogin.Controls.Add(this.btnIrParaOlogin);
            this.pnLogin.Controls.Add(this.btnIrParaOCadastro);
            this.pnLogin.Controls.Add(this.label1);
            this.pnLogin.Location = new System.Drawing.Point(107, 12);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(550, 301);
            this.pnLogin.TabIndex = 4;
            this.pnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tela_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tela_Principal_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIrParaOlogin;
        private System.Windows.Forms.Button btnIrParaOCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnLogin;
    }
}