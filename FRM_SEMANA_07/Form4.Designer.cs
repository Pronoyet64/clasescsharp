
namespace FRM_SEMANA_07
{
    partial class frmOperaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultdo = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.rbtSumar = new System.Windows.Forms.RadioButton();
            this.rbtRestar = new System.Windows.Forms.RadioButton();
            this.rbtMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbtDividir = new System.Windows.Forms.RadioButton();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2:";
            // 
            // lblResultdo
            // 
            this.lblResultdo.AutoSize = true;
            this.lblResultdo.ForeColor = System.Drawing.Color.Blue;
            this.lblResultdo.Location = new System.Drawing.Point(43, 159);
            this.lblResultdo.Name = "lblResultdo";
            this.lblResultdo.Size = new System.Drawing.Size(49, 13);
            this.lblResultdo.TabIndex = 2;
            this.lblResultdo.Text = "Resultdo";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(105, 44);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(148, 20);
            this.txtNumero1.TabIndex = 3;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(345, 44);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(148, 20);
            this.txtNumero2.TabIndex = 4;
            // 
            // rbtSumar
            // 
            this.rbtSumar.AutoSize = true;
            this.rbtSumar.Location = new System.Drawing.Point(46, 106);
            this.rbtSumar.Name = "rbtSumar";
            this.rbtSumar.Size = new System.Drawing.Size(55, 17);
            this.rbtSumar.TabIndex = 5;
            this.rbtSumar.TabStop = true;
            this.rbtSumar.Text = "Sumar";
            this.rbtSumar.UseVisualStyleBackColor = true;
            // 
            // rbtRestar
            // 
            this.rbtRestar.AutoSize = true;
            this.rbtRestar.Location = new System.Drawing.Point(175, 106);
            this.rbtRestar.Name = "rbtRestar";
            this.rbtRestar.Size = new System.Drawing.Size(56, 17);
            this.rbtRestar.TabIndex = 6;
            this.rbtRestar.TabStop = true;
            this.rbtRestar.Text = "Restar";
            this.rbtRestar.UseVisualStyleBackColor = true;
            // 
            // rbtMultiplicar
            // 
            this.rbtMultiplicar.AutoSize = true;
            this.rbtMultiplicar.Location = new System.Drawing.Point(302, 106);
            this.rbtMultiplicar.Name = "rbtMultiplicar";
            this.rbtMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rbtMultiplicar.TabIndex = 7;
            this.rbtMultiplicar.TabStop = true;
            this.rbtMultiplicar.Text = "Multiplicar";
            this.rbtMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbtDividir
            // 
            this.rbtDividir.AutoSize = true;
            this.rbtDividir.Location = new System.Drawing.Point(439, 106);
            this.rbtDividir.Name = "rbtDividir";
            this.rbtDividir.Size = new System.Drawing.Size(54, 17);
            this.rbtDividir.TabIndex = 8;
            this.rbtDividir.TabStop = true;
            this.rbtDividir.Text = "Dividir";
            this.rbtDividir.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(365, 135);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(128, 37);
            this.btnProcesar.TabIndex = 9;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 208);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.rbtDividir);
            this.Controls.Add(this.rbtMultiplicar);
            this.Controls.Add(this.rbtRestar);
            this.Controls.Add(this.rbtSumar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblResultdo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOperaciones";
            this.Text = "Operaciones";
            this.Load += new System.EventHandler(this.frmOperaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultdo;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.RadioButton rbtSumar;
        private System.Windows.Forms.RadioButton rbtRestar;
        private System.Windows.Forms.RadioButton rbtMultiplicar;
        private System.Windows.Forms.RadioButton rbtDividir;
        private System.Windows.Forms.Button btnProcesar;
    }
}