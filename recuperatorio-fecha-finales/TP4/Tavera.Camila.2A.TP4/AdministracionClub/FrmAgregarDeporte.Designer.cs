
namespace AdministracionClub
{
    partial class FrmAgregarDeporte
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
            this.cmb_deportes = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cmb_sexo = new System.Windows.Forms.ComboBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_deporte = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmb_deportes
            // 
            this.cmb_deportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_deportes.FormattingEnabled = true;
            this.cmb_deportes.Location = new System.Drawing.Point(128, 44);
            this.cmb_deportes.Name = "cmb_deportes";
            this.cmb_deportes.Size = new System.Drawing.Size(191, 23);
            this.cmb_deportes.TabIndex = 0;
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
            this.btn_agregar.Location = new System.Drawing.Point(101, 221);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(113, 31);
            this.btn_agregar.TabIndex = 51;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Location = new System.Drawing.Point(128, 93);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(112, 23);
            this.cmb_sexo.TabIndex = 52;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sexo.ForeColor = System.Drawing.Color.Coral;
            this.lbl_sexo.Location = new System.Drawing.Point(41, 95);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(46, 21);
            this.lbl_sexo.TabIndex = 53;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_deporte
            // 
            this.lbl_deporte.AutoSize = true;
            this.lbl_deporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_deporte.ForeColor = System.Drawing.Color.Coral;
            this.lbl_deporte.Location = new System.Drawing.Point(30, 46);
            this.lbl_deporte.Name = "lbl_deporte";
            this.lbl_deporte.Size = new System.Drawing.Size(75, 21);
            this.lbl_deporte.TabIndex = 54;
            this.lbl_deporte.Text = "Deporte";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_categoria.ForeColor = System.Drawing.Color.Coral;
            this.lbl_categoria.Location = new System.Drawing.Point(30, 154);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(91, 21);
            this.lbl_categoria.TabIndex = 55;
            this.lbl_categoria.Text = "Categoria";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(128, 152);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(121, 23);
            this.cmb_categoria.TabIndex = 56;
            // 
            // FrmAgregarDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(380, 319);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_deporte);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.cmb_sexo);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cmb_deportes);
            this.Name = "FrmAgregarDeporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar equipo";
            this.Load += new System.EventHandler(this.FrmAgregarDeporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_deportes;
        public System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cmb_sexo;
        public System.Windows.Forms.Label lbl_sexo;
        public System.Windows.Forms.Label lbl_deporte;
        public System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ComboBox cmb_categoria;
    }
}