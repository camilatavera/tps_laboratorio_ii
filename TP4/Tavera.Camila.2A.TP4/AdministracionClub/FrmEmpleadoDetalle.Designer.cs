using Bibloteca;
namespace AdministracionClub
{
    partial class FrmEmpleadoDetalle<T> 
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
            this.chbox_deportes = new System.Windows.Forms.GroupBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.lst_deportes = new System.Windows.Forms.ListBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_sueldo = new System.Windows.Forms.TextBox();
            this.lbl_area = new System.Windows.Forms.Label();
            this.cmb_area = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.chbox_deportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbox_deportes
            // 
            this.chbox_deportes.Controls.Add(this.btn_agregar);
            this.chbox_deportes.Controls.Add(this.btn_borrar);
            this.chbox_deportes.Controls.Add(this.lst_deportes);
            this.chbox_deportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbox_deportes.ForeColor = System.Drawing.Color.Coral;
            this.chbox_deportes.Location = new System.Drawing.Point(469, 36);
            this.chbox_deportes.Name = "chbox_deportes";
            this.chbox_deportes.Size = new System.Drawing.Size(280, 260);
            this.chbox_deportes.TabIndex = 52;
            this.chbox_deportes.TabStop = false;
            this.chbox_deportes.Text = "Deportes";
            // 
            // btn_agregar
            // 
            this.btn_agregar.AutoSize = true;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar.ForeColor = System.Drawing.Color.Coral;
            this.btn_agregar.Location = new System.Drawing.Point(143, 202);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(113, 31);
            this.btn_agregar.TabIndex = 50;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.AutoSize = true;
            this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_borrar.ForeColor = System.Drawing.Color.Coral;
            this.btn_borrar.Location = new System.Drawing.Point(28, 202);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(109, 31);
            this.btn_borrar.TabIndex = 49;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // lst_deportes
            // 
            this.lst_deportes.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_deportes.FormattingEnabled = true;
            this.lst_deportes.ItemHeight = 20;
            this.lst_deportes.Location = new System.Drawing.Point(28, 37);
            this.lst_deportes.Name = "lst_deportes";
            this.lst_deportes.Size = new System.Drawing.Size(228, 124);
            this.lst_deportes.TabIndex = 48;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_categoria.ForeColor = System.Drawing.Color.Coral;
            this.lbl_categoria.Location = new System.Drawing.Point(39, 238);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(62, 21);
            this.lbl_categoria.TabIndex = 53;
            this.lbl_categoria.Text = "Sueldo";
            // 
            // txt_sueldo
            // 
            this.txt_sueldo.Enabled = false;
            this.txt_sueldo.Location = new System.Drawing.Point(107, 236);
            this.txt_sueldo.Name = "txt_sueldo";
            this.txt_sueldo.Size = new System.Drawing.Size(138, 23);
            this.txt_sueldo.TabIndex = 54;
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_area.ForeColor = System.Drawing.Color.Coral;
            this.lbl_area.Location = new System.Drawing.Point(39, 291);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(49, 21);
            this.lbl_area.TabIndex = 55;
            this.lbl_area.Text = "Area";
            // 
            // cmb_area
            // 
            this.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_area.FormattingEnabled = true;
            this.cmb_area.Location = new System.Drawing.Point(107, 291);
            this.cmb_area.Name = "cmb_area";
            this.cmb_area.Size = new System.Drawing.Size(121, 23);
            this.cmb_area.TabIndex = 56;
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
            this.btn_guardar.Location = new System.Drawing.Point(217, 373);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(109, 31);
            this.btn_guardar.TabIndex = 57;
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
            this.btn_cancelar.Location = new System.Drawing.Point(384, 373);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(109, 31);
            this.btn_cancelar.TabIndex = 59;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // FrmEmpleadoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cmb_area);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.txt_sueldo);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.chbox_deportes);
            this.Name = "FrmEmpleadoDetalle";
            this.Text = "Area";
            this.Load += new System.EventHandler(this.FrmEmpleadoDetalle_Load);
            this.Controls.SetChildIndex(this.dtp_fecha, 0);
            this.Controls.SetChildIndex(this.chbox_deportes, 0);
            this.Controls.SetChildIndex(this.lbl_categoria, 0);
            this.Controls.SetChildIndex(this.lbl_nombre, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.lbl_apellido, 0);
            this.Controls.SetChildIndex(this.lbl_sexo, 0);
            this.Controls.SetChildIndex(this.lbl_fecha, 0);
            this.Controls.SetChildIndex(this.txt_apellido, 0);
            this.Controls.SetChildIndex(this.cmb_sexo, 0);
            this.Controls.SetChildIndex(this.txt_sueldo, 0);
            this.Controls.SetChildIndex(this.lbl_area, 0);
            this.Controls.SetChildIndex(this.cmb_area, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.chbox_deportes.ResumeLayout(false);
            this.chbox_deportes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox chbox_deportes;
        public System.Windows.Forms.Button btn_agregar;
        public System.Windows.Forms.Button btn_borrar;
        public System.Windows.Forms.Label lbl_categoria;
        public System.Windows.Forms.TextBox txt_sueldo;
        public System.Windows.Forms.Label lbl_area;
        public System.Windows.Forms.ComboBox cmb_area;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ListBox lst_deportes;
    }
}