
namespace PrimeiraAplicação
{
    partial class Atualizar_Informações
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
            this.label2 = new System.Windows.Forms.Label();
            this.textAtualizar = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNomeAtualizar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNumeroAtualizar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(116, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // textAtualizar
            // 
            this.textAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAtualizar.Location = new System.Drawing.Point(158, 72);
            this.textAtualizar.Multiline = true;
            this.textAtualizar.Name = "textAtualizar";
            this.textAtualizar.Size = new System.Drawing.Size(345, 25);
            this.textAtualizar.TabIndex = 2;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.Red;
            this.btnAtualizar.Location = new System.Drawing.Point(79, 258);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(117, 48);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(89, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // textNomeAtualizar
            // 
            this.textNomeAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeAtualizar.Location = new System.Drawing.Point(158, 116);
            this.textNomeAtualizar.Multiline = true;
            this.textNomeAtualizar.Name = "textNomeAtualizar";
            this.textNomeAtualizar.Size = new System.Drawing.Size(345, 26);
            this.textNomeAtualizar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(49, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sobrenome";
            // 
            // textNumeroAtualizar
            // 
            this.textNumeroAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeroAtualizar.Location = new System.Drawing.Point(158, 165);
            this.textNumeroAtualizar.Multiline = true;
            this.textNumeroAtualizar.Name = "textNumeroAtualizar";
            this.textNumeroAtualizar.Size = new System.Drawing.Size(345, 26);
            this.textNumeroAtualizar.TabIndex = 7;
            // 
            // Atualizar_Informações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textNumeroAtualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNomeAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.textAtualizar);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Atualizar_Informações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar_Informações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Atualizar_Informações_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAtualizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNomeAtualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNumeroAtualizar;
    }
}