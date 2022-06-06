
namespace AdministracionClub
{
    partial class FrmPersonaDetalle
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.cmb_sexo = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.ForeColor = System.Drawing.Color.Coral;
            this.lbl_nombre.Location = new System.Drawing.Point(39, 36);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(73, 21);
            this.lbl_nombre.TabIndex = 28;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(129, 36);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(138, 23);
            this.txt_nombre.TabIndex = 33;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_apellido.ForeColor = System.Drawing.Color.Coral;
            this.lbl_apellido.Location = new System.Drawing.Point(39, 84);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(74, 21);
            this.lbl_apellido.TabIndex = 34;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sexo.ForeColor = System.Drawing.Color.Coral;
            this.lbl_sexo.Location = new System.Drawing.Point(39, 132);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(46, 21);
            this.lbl_sexo.TabIndex = 35;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fecha.ForeColor = System.Drawing.Color.Coral;
            this.lbl_fecha.Location = new System.Drawing.Point(39, 178);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(177, 21);
            this.lbl_fecha.TabIndex = 36;
            this.lbl_fecha.Text = "Fecha de nacimiento";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(129, 86);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(138, 23);
            this.txt_apellido.TabIndex = 38;
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Location = new System.Drawing.Point(129, 132);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(121, 23);
            this.cmb_sexo.TabIndex = 39;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(235, 178);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 23);
            this.dtp_fecha.TabIndex = 40;
            // 
            // FrmPersonaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(878, 416);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.cmb_sexo);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "FrmPersonaDetalle";
            this.Text = "FrmPersonaDetalle";
            this.Load += new System.EventHandler(this.FrmPersonaDetalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_nombre;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.Label lbl_apellido;
        public System.Windows.Forms.Label lbl_sexo;
        public System.Windows.Forms.Label lbl_fecha;
        public System.Windows.Forms.TextBox txt_apellido;
        public System.Windows.Forms.ComboBox cmb_sexo;
        public System.Windows.Forms.DateTimePicker dtp_fecha;
    }
}