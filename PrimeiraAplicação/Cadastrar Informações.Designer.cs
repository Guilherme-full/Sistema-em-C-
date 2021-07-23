
namespace PrimeiraAplicação
{
    partial class Cadastrar_Informações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Informações));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.btnCadastar = new System.Windows.Forms.Button();
            this.pnlCadastrarInfo = new System.Windows.Forms.Panel();
            this.pnlCadastrarInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome";
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(192, 54);
            this.textNome.Multiline = true;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(335, 25);
            this.textNome.TabIndex = 2;
            // 
            // textNumero
            // 
            this.textNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumero.Location = new System.Drawing.Point(192, 115);
            this.textNumero.Multiline = true;
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(335, 26);
            this.textNumero.TabIndex = 3;
            // 
            // btnCadastar
            // 
            this.btnCadastar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastar.ForeColor = System.Drawing.Color.White;
            this.btnCadastar.Location = new System.Drawing.Point(90, 191);
            this.btnCadastar.Name = "btnCadastar";
            this.btnCadastar.Size = new System.Drawing.Size(142, 48);
            this.btnCadastar.TabIndex = 4;
            this.btnCadastar.Text = "Cadastrar";
            this.btnCadastar.UseVisualStyleBackColor = false;
            this.btnCadastar.Click += new System.EventHandler(this.btnCadastar_Click);
            // 
            // pnlCadastrarInfo
            // 
            this.pnlCadastrarInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlCadastrarInfo.Controls.Add(this.btnCadastar);
            this.pnlCadastrarInfo.Controls.Add(this.textNumero);
            this.pnlCadastrarInfo.Controls.Add(this.textNome);
            this.pnlCadastrarInfo.Controls.Add(this.label2);
            this.pnlCadastrarInfo.Controls.Add(this.label1);
            this.pnlCadastrarInfo.Location = new System.Drawing.Point(66, 32);
            this.pnlCadastrarInfo.Name = "pnlCadastrarInfo";
            this.pnlCadastrarInfo.Size = new System.Drawing.Size(702, 320);
            this.pnlCadastrarInfo.TabIndex = 5;
            // 
            // Cadastrar_Informações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCadastrarInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cadastrar_Informações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar_Informações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cadastrar_Informações_FormClosed);
            this.Load += new System.EventHandler(this.Cadastrar_Informações_Load);
            this.pnlCadastrarInfo.ResumeLayout(false);
            this.pnlCadastrarInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Button btnCadastar;
        private System.Windows.Forms.Panel pnlCadastrarInfo;
    }
}