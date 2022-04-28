
namespace laboratorio004
{
    partial class TelaPrincipal
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.tbxnum = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(149, 60);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(103, 15);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "digite um numero";
            // 
            // lblresultado
            // 
            this.lblresultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblresultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblresultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblresultado.Location = new System.Drawing.Point(149, 134);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(190, 77);
            this.lblresultado.TabIndex = 1;
            this.lblresultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblresultado.Click += new System.EventHandler(this.lblresultado_Click);
            // 
            // tbxnum
            // 
            this.tbxnum.Location = new System.Drawing.Point(149, 95);
            this.tbxnum.Name = "tbxnum";
            this.tbxnum.Size = new System.Drawing.Size(100, 23);
            this.tbxnum.TabIndex = 2;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(264, 94);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 240);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.tbxnum);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lbltitulo);
            this.KeyPreview = true;
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Calculo Quadrado";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaPrincipal_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox tbxnum;
        private System.Windows.Forms.Button btncalcular;
    }
}

