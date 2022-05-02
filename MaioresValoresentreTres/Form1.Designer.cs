
namespace MaioresValoresentreTres
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblvalor1 = new System.Windows.Forms.Label();
            this.lblvalor2 = new System.Windows.Forms.Label();
            this.lblvalor3 = new System.Windows.Forms.Label();
            this.numericUd1 = new System.Windows.Forms.NumericUpDown();
            this.numericUd2 = new System.Windows.Forms.NumericUpDown();
            this.numericUd3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Btncalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUd3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblvalor1
            // 
            this.lblvalor1.AutoSize = true;
            this.lblvalor1.Location = new System.Drawing.Point(118, 126);
            this.lblvalor1.Name = "lblvalor1";
            this.lblvalor1.Size = new System.Drawing.Size(45, 15);
            this.lblvalor1.TabIndex = 0;
            this.lblvalor1.Text = "Valor 1:";
            // 
            // lblvalor2
            // 
            this.lblvalor2.AutoSize = true;
            this.lblvalor2.Location = new System.Drawing.Point(118, 180);
            this.lblvalor2.Name = "lblvalor2";
            this.lblvalor2.Size = new System.Drawing.Size(45, 15);
            this.lblvalor2.TabIndex = 1;
            this.lblvalor2.Text = "Valor 2:";
            // 
            // lblvalor3
            // 
            this.lblvalor3.AutoSize = true;
            this.lblvalor3.Location = new System.Drawing.Point(118, 230);
            this.lblvalor3.Name = "lblvalor3";
            this.lblvalor3.Size = new System.Drawing.Size(45, 15);
            this.lblvalor3.TabIndex = 2;
            this.lblvalor3.Text = "Valor 3:";
            // 
            // numericUd1
            // 
            this.numericUd1.Location = new System.Drawing.Point(194, 118);
            this.numericUd1.Name = "numericUd1";
            this.numericUd1.Size = new System.Drawing.Size(120, 23);
            this.numericUd1.TabIndex = 3;
            // 
            // numericUd2
            // 
            this.numericUd2.Location = new System.Drawing.Point(194, 172);
            this.numericUd2.Name = "numericUd2";
            this.numericUd2.Size = new System.Drawing.Size(120, 23);
            this.numericUd2.TabIndex = 4;
            // 
            // numericUd3
            // 
            this.numericUd3.Location = new System.Drawing.Point(194, 228);
            this.numericUd3.Name = "numericUd3";
            this.numericUd3.Size = new System.Drawing.Size(120, 23);
            this.numericUd3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite Três Valores";
            // 
            // Btncalcular
            // 
            this.Btncalcular.Location = new System.Drawing.Point(177, 306);
            this.Btncalcular.Name = "Btncalcular";
            this.Btncalcular.Size = new System.Drawing.Size(75, 23);
            this.Btncalcular.TabIndex = 7;
            this.Btncalcular.Text = "Calcular";
            this.Btncalcular.UseVisualStyleBackColor = true;
            this.Btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblResultado.Location = new System.Drawing.Point(118, 352);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(196, 78);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.Btncalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUd3);
            this.Controls.Add(this.numericUd2);
            this.Controls.Add(this.numericUd1);
            this.Controls.Add(this.lblvalor3);
            this.Controls.Add(this.lblvalor2);
            this.Controls.Add(this.lblvalor1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sistema de Exibir Maior Valor entre três números";
            ((System.ComponentModel.ISupportInitialize)(this.numericUd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUd3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvalor1;
        private System.Windows.Forms.Label lblvalor2;
        private System.Windows.Forms.Label lblvalor3;
        private System.Windows.Forms.NumericUpDown numericUd1;
        private System.Windows.Forms.NumericUpDown numericUd2;
        private System.Windows.Forms.NumericUpDown numericUd3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btncalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}

