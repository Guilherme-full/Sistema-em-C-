
namespace PrimeiraAplicação
{
    partial class Calculadora
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
            this.btnAdição = new System.Windows.Forms.Button();
            this.btnSubtração = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.BtnDivisão = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdição
            // 
            this.btnAdição.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdição.ForeColor = System.Drawing.Color.Red;
            this.btnAdição.Location = new System.Drawing.Point(92, 166);
            this.btnAdição.Name = "btnAdição";
            this.btnAdição.Size = new System.Drawing.Size(104, 40);
            this.btnAdição.TabIndex = 0;
            this.btnAdição.Text = "Adição";
            this.btnAdição.UseVisualStyleBackColor = true;
            this.btnAdição.Click += new System.EventHandler(this.btnAdição_Click);
            // 
            // btnSubtração
            // 
            this.btnSubtração.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtração.ForeColor = System.Drawing.Color.Red;
            this.btnSubtração.Location = new System.Drawing.Point(265, 166);
            this.btnSubtração.Name = "btnSubtração";
            this.btnSubtração.Size = new System.Drawing.Size(93, 40);
            this.btnSubtração.TabIndex = 1;
            this.btnSubtração.Text = "Subtração";
            this.btnSubtração.UseVisualStyleBackColor = true;
            this.btnSubtração.Click += new System.EventHandler(this.btnSubtração_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.Color.Red;
            this.btnMulti.Location = new System.Drawing.Point(421, 166);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(114, 40);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "Multiplicação";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // BtnDivisão
            // 
            this.BtnDivisão.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivisão.ForeColor = System.Drawing.Color.Red;
            this.BtnDivisão.Location = new System.Drawing.Point(594, 166);
            this.BtnDivisão.Name = "BtnDivisão";
            this.BtnDivisão.Size = new System.Drawing.Size(100, 40);
            this.BtnDivisão.TabIndex = 3;
            this.BtnDivisão.Text = "Divisão";
            this.BtnDivisão.UseVisualStyleBackColor = true;
            this.BtnDivisão.Click += new System.EventHandler(this.BtnDivisão_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDivisão);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSubtração);
            this.Controls.Add(this.btnAdição);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calculadora_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdição;
        private System.Windows.Forms.Button btnSubtração;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button BtnDivisão;
    }
}