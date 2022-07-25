
namespace AdministracionClub
{
    partial class FrmOpcionesEmpleados
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
            this.btn_operativo = new System.Windows.Forms.Button();
            this.btn_deportivos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_operativo
            // 
            this.btn_operativo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_operativo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_operativo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_operativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_operativo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_operativo.ForeColor = System.Drawing.Color.Coral;
            this.btn_operativo.Location = new System.Drawing.Point(12, 61);
            this.btn_operativo.Name = "btn_operativo";
            this.btn_operativo.Size = new System.Drawing.Size(326, 69);
            this.btn_operativo.TabIndex = 29;
            this.btn_operativo.Text = "Operativo";
            this.btn_operativo.UseVisualStyleBackColor = true;
            this.btn_operativo.Click += new System.EventHandler(this.btn_operativo_Click);
            // 
            // btn_deportivos
            // 
            this.btn_deportivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_deportivos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_deportivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_deportivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deportivos.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deportivos.ForeColor = System.Drawing.Color.Coral;
            this.btn_deportivos.Location = new System.Drawing.Point(12, 153);
            this.btn_deportivos.Name = "btn_deportivos";
            this.btn_deportivos.Size = new System.Drawing.Size(326, 69);
            this.btn_deportivos.TabIndex = 30;
            this.btn_deportivos.Text = "Deportivos";
            this.btn_deportivos.UseVisualStyleBackColor = true;
            this.btn_deportivos.Click += new System.EventHandler(this.btn_deportivos_Click);
            // 
            // FrmOpcionesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(350, 297);
            this.Controls.Add(this.btn_deportivos);
            this.Controls.Add(this.btn_operativo);
            this.Name = "FrmOpcionesEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_operativo;
        public System.Windows.Forms.Button btn_deportivos;
    }
}