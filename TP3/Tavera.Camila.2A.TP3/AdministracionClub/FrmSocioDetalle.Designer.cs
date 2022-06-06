
namespace AdministracionClub
{
    partial class FrmSocioDetalle
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
            this.lbl_cuota = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_cuota = new System.Windows.Forms.TextBox();
            this.lbl_apagar = new System.Windows.Forms.Label();
            this.txt_apagar = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cobrar = new System.Windows.Forms.Button();
            this.chb_federado = new System.Windows.Forms.CheckBox();
            this.gbox_deportes = new System.Windows.Forms.GroupBox();
            this.chbox_voley = new System.Windows.Forms.CheckBox();
            this.chbox_futbol = new System.Windows.Forms.CheckBox();
            this.chbox_handball = new System.Windows.Forms.CheckBox();
            this.chbox_basket = new System.Windows.Forms.CheckBox();
            this.btn_baja = new System.Windows.Forms.Button();
            this.gbox_deportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cuota
            // 
            this.lbl_cuota.AutoSize = true;
            this.lbl_cuota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cuota.ForeColor = System.Drawing.Color.Coral;
            this.lbl_cuota.Location = new System.Drawing.Point(39, 287);
            this.lbl_cuota.Name = "lbl_cuota";
            this.lbl_cuota.Size = new System.Drawing.Size(130, 21);
            this.lbl_cuota.TabIndex = 41;
            this.lbl_cuota.Text = "Cuota mensual";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(158, 237);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(121, 23);
            this.cmb_categoria.TabIndex = 42;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_categoria.ForeColor = System.Drawing.Color.Coral;
            this.lbl_categoria.Location = new System.Drawing.Point(39, 239);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(91, 21);
            this.lbl_categoria.TabIndex = 43;
            this.lbl_categoria.Text = "Categoria";
            // 
            // txt_cuota
            // 
            this.txt_cuota.Enabled = false;
            this.txt_cuota.Location = new System.Drawing.Point(194, 285);
            this.txt_cuota.Name = "txt_cuota";
            this.txt_cuota.Size = new System.Drawing.Size(138, 23);
            this.txt_cuota.TabIndex = 44;
            // 
            // lbl_apagar
            // 
            this.lbl_apagar.AutoSize = true;
            this.lbl_apagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_apagar.ForeColor = System.Drawing.Color.Coral;
            this.lbl_apagar.Location = new System.Drawing.Point(39, 337);
            this.lbl_apagar.Name = "lbl_apagar";
            this.lbl_apagar.Size = new System.Drawing.Size(76, 21);
            this.lbl_apagar.TabIndex = 45;
            this.lbl_apagar.Text = "A pagar";
            // 
            // txt_apagar
            // 
            this.txt_apagar.Enabled = false;
            this.txt_apagar.Location = new System.Drawing.Point(141, 335);
            this.txt_apagar.Name = "txt_apagar";
            this.txt_apagar.Size = new System.Drawing.Size(138, 23);
            this.txt_apagar.TabIndex = 46;
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
            this.btn_guardar.Location = new System.Drawing.Point(170, 407);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(109, 31);
            this.btn_guardar.TabIndex = 52;
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
            this.btn_cancelar.Location = new System.Drawing.Point(308, 407);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(109, 31);
            this.btn_cancelar.TabIndex = 53;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_cobrar
            // 
            this.btn_cobrar.AutoSize = true;
            this.btn_cobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cobrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cobrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cobrar.ForeColor = System.Drawing.Color.Coral;
            this.btn_cobrar.Location = new System.Drawing.Point(445, 407);
            this.btn_cobrar.Name = "btn_cobrar";
            this.btn_cobrar.Size = new System.Drawing.Size(109, 31);
            this.btn_cobrar.TabIndex = 54;
            this.btn_cobrar.Text = "Cobrar";
            this.btn_cobrar.UseVisualStyleBackColor = true;
            this.btn_cobrar.Click += new System.EventHandler(this.btn_cobrar_Click);
            // 
            // chb_federado
            // 
            this.chb_federado.AutoSize = true;
            this.chb_federado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chb_federado.ForeColor = System.Drawing.Color.Coral;
            this.chb_federado.Location = new System.Drawing.Point(323, 33);
            this.chb_federado.Name = "chb_federado";
            this.chb_federado.Size = new System.Drawing.Size(112, 25);
            this.chb_federado.TabIndex = 55;
            this.chb_federado.Text = "FEDERADO";
            this.chb_federado.UseVisualStyleBackColor = true;
            this.chb_federado.CheckedChanged += new System.EventHandler(this.chb_federado_CheckedChanged);
            // 
            // gbox_deportes
            // 
            this.gbox_deportes.Controls.Add(this.chbox_voley);
            this.gbox_deportes.Controls.Add(this.chbox_futbol);
            this.gbox_deportes.Controls.Add(this.chbox_handball);
            this.gbox_deportes.Controls.Add(this.chbox_basket);
            this.gbox_deportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbox_deportes.ForeColor = System.Drawing.Color.Coral;
            this.gbox_deportes.Location = new System.Drawing.Point(530, 86);
            this.gbox_deportes.Name = "gbox_deportes";
            this.gbox_deportes.Size = new System.Drawing.Size(200, 207);
            this.gbox_deportes.TabIndex = 56;
            this.gbox_deportes.TabStop = false;
            this.gbox_deportes.Text = "Deportes";
            // 
            // chbox_voley
            // 
            this.chbox_voley.AutoSize = true;
            this.chbox_voley.ForeColor = System.Drawing.Color.White;
            this.chbox_voley.Location = new System.Drawing.Point(33, 142);
            this.chbox_voley.Name = "chbox_voley";
            this.chbox_voley.Size = new System.Drawing.Size(71, 25);
            this.chbox_voley.TabIndex = 3;
            this.chbox_voley.Text = "Voley";
            this.chbox_voley.UseVisualStyleBackColor = true;
            // 
            // chbox_futbol
            // 
            this.chbox_futbol.AutoSize = true;
            this.chbox_futbol.ForeColor = System.Drawing.Color.White;
            this.chbox_futbol.Location = new System.Drawing.Point(33, 108);
            this.chbox_futbol.Name = "chbox_futbol";
            this.chbox_futbol.Size = new System.Drawing.Size(78, 25);
            this.chbox_futbol.TabIndex = 2;
            this.chbox_futbol.Text = "Futbol";
            this.chbox_futbol.UseVisualStyleBackColor = true;
            // 
            // chbox_handball
            // 
            this.chbox_handball.AutoSize = true;
            this.chbox_handball.ForeColor = System.Drawing.Color.White;
            this.chbox_handball.Location = new System.Drawing.Point(33, 77);
            this.chbox_handball.Name = "chbox_handball";
            this.chbox_handball.Size = new System.Drawing.Size(100, 25);
            this.chbox_handball.TabIndex = 1;
            this.chbox_handball.Text = "Handball";
            this.chbox_handball.UseVisualStyleBackColor = true;
            // 
            // chbox_basket
            // 
            this.chbox_basket.AutoSize = true;
            this.chbox_basket.ForeColor = System.Drawing.Color.White;
            this.chbox_basket.Location = new System.Drawing.Point(33, 41);
            this.chbox_basket.Name = "chbox_basket";
            this.chbox_basket.Size = new System.Drawing.Size(80, 25);
            this.chbox_basket.TabIndex = 0;
            this.chbox_basket.Text = "Basket";
            this.chbox_basket.UseVisualStyleBackColor = true;
            // 
            // btn_baja
            // 
            this.btn_baja.AutoSize = true;
            this.btn_baja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_baja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_baja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_baja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_baja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_baja.ForeColor = System.Drawing.Color.Coral;
            this.btn_baja.Location = new System.Drawing.Point(589, 407);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(109, 31);
            this.btn_baja.TabIndex = 57;
            this.btn_baja.Text = "Dar baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // FrmSocioDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.gbox_deportes);
            this.Controls.Add(this.chb_federado);
            this.Controls.Add(this.btn_cobrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_apagar);
            this.Controls.Add(this.lbl_apagar);
            this.Controls.Add(this.txt_cuota);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.lbl_cuota);
            this.Name = "FrmSocioDetalle";
            this.Text = "FrmSocioDetalle";
            this.Load += new System.EventHandler(this.FrmSocioDetalle_Load);
            this.Controls.SetChildIndex(this.dtp_fecha, 0);
            this.Controls.SetChildIndex(this.lbl_nombre, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.lbl_apellido, 0);
            this.Controls.SetChildIndex(this.lbl_sexo, 0);
            this.Controls.SetChildIndex(this.lbl_fecha, 0);
            this.Controls.SetChildIndex(this.txt_apellido, 0);
            this.Controls.SetChildIndex(this.cmb_sexo, 0);
            this.Controls.SetChildIndex(this.lbl_cuota, 0);
            this.Controls.SetChildIndex(this.cmb_categoria, 0);
            this.Controls.SetChildIndex(this.lbl_categoria, 0);
            this.Controls.SetChildIndex(this.txt_cuota, 0);
            this.Controls.SetChildIndex(this.lbl_apagar, 0);
            this.Controls.SetChildIndex(this.txt_apagar, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.btn_cobrar, 0);
            this.Controls.SetChildIndex(this.chb_federado, 0);
            this.Controls.SetChildIndex(this.gbox_deportes, 0);
            this.Controls.SetChildIndex(this.btn_baja, 0);
            this.gbox_deportes.ResumeLayout(false);
            this.gbox_deportes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_cuota;
        public System.Windows.Forms.ComboBox cmb_categoria;
        public System.Windows.Forms.Label lbl_categoria;
        public System.Windows.Forms.TextBox txt_cuota;
        public System.Windows.Forms.Label lbl_apagar;
        public System.Windows.Forms.TextBox txt_apagar;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.Button btn_cobrar;
        private System.Windows.Forms.CheckBox chb_federado;
        private System.Windows.Forms.GroupBox gbox_deportes;
        private System.Windows.Forms.CheckBox chbox_voley;
        private System.Windows.Forms.CheckBox chbox_futbol;
        private System.Windows.Forms.CheckBox chbox_handball;
        private System.Windows.Forms.CheckBox chbox_basket;
        public System.Windows.Forms.Button btn_baja;
    }
}