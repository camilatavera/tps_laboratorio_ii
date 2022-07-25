
namespace AdministracionClub
{
    partial class FrmInicio
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
            this.btn_socios = new System.Windows.Forms.Button();
            this.btn_empleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_socios
            // 
            this.btn_socios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_socios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_socios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_socios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_socios.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_socios.ForeColor = System.Drawing.Color.Coral;
            this.btn_socios.Location = new System.Drawing.Point(78, 130);
            this.btn_socios.Name = "btn_socios";
            this.btn_socios.Size = new System.Drawing.Size(245, 69);
            this.btn_socios.TabIndex = 28;
            this.btn_socios.Text = "Socios";
            this.btn_socios.UseVisualStyleBackColor = true;
            this.btn_socios.Click += new System.EventHandler(this.btn_socios_Click);
            // 
            // btn_empleado
            // 
            this.btn_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_empleado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleado.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_empleado.ForeColor = System.Drawing.Color.Coral;
            this.btn_empleado.Location = new System.Drawing.Point(78, 272);
            this.btn_empleado.Name = "btn_empleado";
            this.btn_empleado.Size = new System.Drawing.Size(245, 69);
            this.btn_empleado.TabIndex = 29;
            this.btn_empleado.Text = "Empleados";
            this.btn_empleado.UseVisualStyleBackColor = true;
            this.btn_empleado.Click += new System.EventHandler(this.btn_empleado_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.btn_empleado);
            this.Controls.Add(this.btn_socios);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_socios;
        public System.Windows.Forms.Button btn_empleado;
    }
}