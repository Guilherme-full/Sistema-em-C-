
namespace PrimeiraAplicação
{
    partial class MultiplicarNumero
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.Mult = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(266, 47);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(188, 30);
            this.text1.TabIndex = 0;
            this.text1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text1_MouseClick);
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);
            this.text1.MouseHover += new System.EventHandler(this.text1_MouseHover);
            // 
            // text2
            // 
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(267, 107);
            this.text2.Multiline = true;
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(187, 30);
            this.text2.TabIndex = 1;
            this.text2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text2_MouseClick);
            this.text2.MouseHover += new System.EventHandler(this.text2_MouseHover);
            // 
            // Mult
            // 
            this.Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mult.ForeColor = System.Drawing.Color.Red;
            this.Mult.Location = new System.Drawing.Point(313, 178);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(98, 43);
            this.Mult.TabIndex = 2;
            this.Mult.Text = "Dividir";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(294, 258);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(135, 43);
            this.Result.TabIndex = 3;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // MultiplicarNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Name = "MultiplicarNumero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divisão";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MultiplicarNumero_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.TextBox Result;
    }
}