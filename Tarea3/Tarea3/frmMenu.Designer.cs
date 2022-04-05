
namespace Tarea3
{
    partial class frmMenu
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
            this.btnRegistrarClientes = new System.Windows.Forms.Button();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarClientes
            // 
            this.btnRegistrarClientes.Location = new System.Drawing.Point(12, 21);
            this.btnRegistrarClientes.Name = "btnRegistrarClientes";
            this.btnRegistrarClientes.Size = new System.Drawing.Size(247, 23);
            this.btnRegistrarClientes.TabIndex = 0;
            this.btnRegistrarClientes.Text = "Registrar clientes";
            this.btnRegistrarClientes.UseVisualStyleBackColor = true;
            this.btnRegistrarClientes.Click += new System.EventHandler(this.btnRegistrarClientes_Click);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(12, 68);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(247, 23);
            this.btnAnalizar.TabIndex = 1;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 120);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.btnRegistrarClientes);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarClientes;
        private System.Windows.Forms.Button btnAnalizar;
    }
}