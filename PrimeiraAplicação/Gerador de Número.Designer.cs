
namespace PrimeiraAplicação
{
    partial class Gerador_de_Número
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerador_de_Número));
            this.Gerador = new System.Windows.Forms.Button();
            this.NuInt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NuDouble = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gerador
            // 
            this.Gerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gerador.ForeColor = System.Drawing.Color.Red;
            this.Gerador.Location = new System.Drawing.Point(306, 99);
            this.Gerador.Name = "Gerador";
            this.Gerador.Size = new System.Drawing.Size(139, 53);
            this.Gerador.TabIndex = 0;
            this.Gerador.Text = "Gerar Número";
            this.Gerador.UseVisualStyleBackColor = true;
            this.Gerador.Click += new System.EventHandler(this.Gerador_Click);
            // 
            // NuInt
            // 
            this.NuInt.AutoSize = true;
            this.NuInt.BackColor = System.Drawing.Color.White;
            this.NuInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuInt.Location = new System.Drawing.Point(118, 254);
            this.NuInt.Name = "NuInt";
            this.NuInt.Size = new System.Drawing.Size(193, 31);
            this.NuInt.TabIndex = 1;
            this.NuInt.Text = "Número Inteiro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 2;
            // 
            // NuDouble
            // 
            this.NuDouble.AutoSize = true;
            this.NuDouble.BackColor = System.Drawing.Color.White;
            this.NuDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuDouble.Location = new System.Drawing.Point(438, 254);
            this.NuDouble.Name = "NuDouble";
            this.NuDouble.Size = new System.Drawing.Size(203, 31);
            this.NuDouble.TabIndex = 3;
            this.NuDouble.Text = "Número Double";
            // 
            // Gerador_de_Número
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NuDouble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NuInt);
            this.Controls.Add(this.Gerador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gerador_de_Número";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador_de_Número";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gerador_de_Número_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gerador;
        private System.Windows.Forms.Label NuInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NuDouble;
    }
}