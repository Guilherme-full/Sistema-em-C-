
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIrParaOlogin = new System.Windows.Forms.Button();
            this.btnIrParaOCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnIrParaOlogin
            // 
            this.btnIrParaOlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIrParaOlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrParaOlogin.ForeColor = System.Drawing.Color.White;
            this.btnIrParaOlogin.Location = new System.Drawing.Point(452, 188);
            this.btnIrParaOlogin.Name = "btnIrParaOlogin";
            this.btnIrParaOlogin.Size = new System.Drawing.Size(99, 39);
            this.btnIrParaOlogin.TabIndex = 1;
            this.btnIrParaOlogin.Text = "Login";
            this.btnIrParaOlogin.UseVisualStyleBackColor = false;
            this.btnIrParaOlogin.Click += new System.EventHandler(this.btnIrParaOlogin_Click);
            // 
            // btnIrParaOCadastro
            // 
            this.btnIrParaOCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIrParaOCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrParaOCadastro.ForeColor = System.Drawing.Color.White;
            this.btnIrParaOCadastro.Location = new System.Drawing.Point(194, 188);
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
            this.label1.Location = new System.Drawing.Point(186, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem Vindo Úsuario";
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIrParaOCadastro);
            this.Controls.Add(this.btnIrParaOlogin);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIrParaOlogin;
        private System.Windows.Forms.Button btnIrParaOCadastro;
        private System.Windows.Forms.Label label1;
    }
}