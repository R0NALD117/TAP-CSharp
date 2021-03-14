
namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_in = new System.Windows.Forms.TextBox();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.txt_out = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(757, 48);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(116, 30);
            this.btn_aceptar.TabIndex = 0;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_in
            // 
            this.txt_in.Location = new System.Drawing.Point(367, 52);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(384, 22);
            this.txt_in.TabIndex = 1;
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto.Location = new System.Drawing.Point(26, 45);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(315, 29);
            this.lbl_texto.TabIndex = 2;
            this.lbl_texto.Text = "Introduzca texto a agregar";
            this.lbl_texto.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_out
            // 
            this.txt_out.Location = new System.Drawing.Point(31, 84);
            this.txt_out.Multiline = true;
            this.txt_out.Name = "txt_out";
            this.txt_out.Size = new System.Drawing.Size(842, 370);
            this.txt_out.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(402, 473);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Limpiar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 508);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_out);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.txt_in);
            this.Controls.Add(this.btn_aceptar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Mi Ventana con botón";
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_in;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.TextBox txt_out;
        private System.Windows.Forms.Button btn_clear;
    }
}

