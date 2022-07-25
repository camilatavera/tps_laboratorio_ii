using Bibloteca;

namespace AdministracionClub
{
    partial class FrmEmpleadoDetalle<T> where T:Persona
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
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.cmb_sexo = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_sueldo = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.cmb_area = new System.Windows.Forms.ComboBox();
            this.txt_sueldo = new System.Windows.Forms.TextBox();
            this.gbox_deportes = new System.Windows.Forms.GroupBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lst_deportes = new System.Windows.Forms.ListBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gbox_deportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.ForeColor = System.Drawing.Color.Coral;
            this.lbl_nombre.Location = new System.Drawing.Point(55, 30);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(73, 21);
            this.lbl_nombre.TabIndex = 30;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_apellido.ForeColor = System.Drawing.Color.Coral;
            this.lbl_apellido.Location = new System.Drawing.Point(55, 73);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(74, 21);
            this.lbl_apellido.TabIndex = 36;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sexo.ForeColor = System.Drawing.Color.Coral;
            this.lbl_sexo.Location = new System.Drawing.Point(55, 118);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(46, 21);
            this.lbl_sexo.TabIndex = 41;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fecha.ForeColor = System.Drawing.Color.Coral;
            this.lbl_fecha.Location = new System.Drawing.Point(44, 164);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(101, 21);
            this.lbl_fecha.TabIndex = 43;
            this.lbl_fecha.Text = "Nacimiento";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(170, 28);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(138, 23);
            this.txt_nombre.TabIndex = 44;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(170, 73);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(138, 23);
            this.txt_apellido.TabIndex = 45;
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Location = new System.Drawing.Point(170, 116);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(121, 23);
            this.cmb_sexo.TabIndex = 46;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(170, 164);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(194, 23);
            this.dtp_fecha.TabIndex = 47;
            // 
            // lbl_sueldo
            // 
            this.lbl_sueldo.AutoSize = true;
            this.lbl_sueldo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sueldo.ForeColor = System.Drawing.Color.Coral;
            this.lbl_sueldo.Location = new System.Drawing.Point(55, 216);
            this.lbl_sueldo.Name = "lbl_sueldo";
            this.lbl_sueldo.Size = new System.Drawing.Size(62, 21);
            this.lbl_sueldo.TabIndex = 48;
            this.lbl_sueldo.Text = "Sueldo";
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_area.ForeColor = System.Drawing.Color.Coral;
            this.lbl_area.Location = new System.Drawing.Point(57, 263);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(49, 21);
            this.lbl_area.TabIndex = 49;
            this.lbl_area.Text = "Area";
            // 
            // cmb_area
            // 
            this.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_area.FormattingEnabled = true;
            this.cmb_area.Location = new System.Drawing.Point(170, 261);
            this.cmb_area.Name = "cmb_area";
            this.cmb_area.Size = new System.Drawing.Size(121, 23);
            this.cmb_area.TabIndex = 50;
            // 
            // txt_sueldo
            // 
            this.txt_sueldo.Location = new System.Drawing.Point(170, 214);
            this.txt_sueldo.Name = "txt_sueldo";
            this.txt_sueldo.ReadOnly = true;
            this.txt_sueldo.Size = new System.Drawing.Size(138, 23);
            this.txt_sueldo.TabIndex = 51;
            // 
            // gbox_deportes
            // 
            this.gbox_deportes.Controls.Add(this.btn_borrar);
            this.gbox_deportes.Controls.Add(this.btn_agregar);
            this.gbox_deportes.Controls.Add(this.lst_deportes);
            this.gbox_deportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbox_deportes.ForeColor = System.Drawing.Color.Coral;
            this.gbox_deportes.Location = new System.Drawing.Point(439, 30);
            this.gbox_deportes.Name = "gbox_deportes";
            this.gbox_deportes.Size = new System.Drawing.Size(316, 232);
            this.gbox_deportes.TabIndex = 52;
            this.gbox_deportes.TabStop = false;
            this.gbox_deportes.Text = "Deportes";
            // 
            // btn_borrar
            // 
            this.btn_borrar.AutoSize = true;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_borrar.ForeColor = System.Drawing.Color.Coral;
            this.btn_borrar.Location = new System.Drawing.Point(163, 181);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(94, 31);
            this.btn_borrar.TabIndex = 60;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.AutoSize = true;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar.ForeColor = System.Drawing.Color.Coral;
            this.btn_agregar.Location = new System.Drawing.Point(49, 181);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(94, 31);
            this.btn_agregar.TabIndex = 59;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lst_deportes
            // 
            this.lst_deportes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_deportes.FormattingEnabled = true;
            this.lst_deportes.Location = new System.Drawing.Point(20, 28);
            this.lst_deportes.Name = "lst_deportes";
            this.lst_deportes.Size = new System.Drawing.Size(278, 121);
            this.lst_deportes.TabIndex = 0;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSize = true;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_guardar.ForeColor = System.Drawing.Color.Coral;
            this.btn_guardar.Location = new System.Drawing.Point(76, 342);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(94, 31);
            this.btn_guardar.TabIndex = 58;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = true;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.Coral;
            this.btn_cancelar.Location = new System.Drawing.Point(224, 342);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 31);
            this.btn_cancelar.TabIndex = 59;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FrmEmpleadoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.gbox_deportes);
            this.Controls.Add(this.txt_sueldo);
            this.Controls.Add(this.cmb_area);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.lbl_sueldo);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.cmb_sexo);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "FrmEmpleadoDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmpleadoDetalle_FormClosing);
            this.Load += new System.EventHandler(this.FrmEmpleadoDetalle_Load);
            this.gbox_deportes.ResumeLayout(false);
            this.gbox_deportes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_nombre;
        public System.Windows.Forms.Label lbl_apellido;
        public System.Windows.Forms.Label lbl_sexo;
        public System.Windows.Forms.Label lbl_fecha;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.TextBox txt_apellido;
        public System.Windows.Forms.ComboBox cmb_sexo;
        public System.Windows.Forms.DateTimePicker dtp_fecha;
        public System.Windows.Forms.Label lbl_sueldo;
        public System.Windows.Forms.Label lbl_area;
        public System.Windows.Forms.ComboBox cmb_area;
        public System.Windows.Forms.TextBox txt_sueldo;
        private System.Windows.Forms.GroupBox gbox_deportes;
        private System.Windows.Forms.ListBox lst_deportes;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.Button btn_borrar;
        public System.Windows.Forms.Button btn_agregar;
    }
}