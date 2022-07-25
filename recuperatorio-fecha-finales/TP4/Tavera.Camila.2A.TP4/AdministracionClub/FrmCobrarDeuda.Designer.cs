
namespace AdministracionClub
{
    partial class FrmCobrarDeuda
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
            this.txt_deuda = new System.Windows.Forms.TextBox();
            this.btn_cobrar = new System.Windows.Forms.Button();
            this.lbl_deuda = new System.Windows.Forms.Label();
            this.lbl_cobro = new System.Windows.Forms.Label();
            this.txt_ingreso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_deuda
            // 
            this.txt_deuda.Enabled = false;
            this.txt_deuda.Location = new System.Drawing.Point(55, 113);
            this.txt_deuda.Name = "txt_deuda";
            this.txt_deuda.Size = new System.Drawing.Size(138, 23);
            this.txt_deuda.TabIndex = 39;
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
            this.btn_cobrar.Location = new System.Drawing.Point(55, 287);
            this.btn_cobrar.Name = "btn_cobrar";
            this.btn_cobrar.Size = new System.Drawing.Size(113, 31);
            this.btn_cobrar.TabIndex = 52;
            this.btn_cobrar.Text = "Cobrar";
            this.btn_cobrar.UseVisualStyleBackColor = true;
            this.btn_cobrar.Click += new System.EventHandler(this.btn_cobrar_Click);
            // 
            // lbl_deuda
            // 
            this.lbl_deuda.AutoSize = true;
            this.lbl_deuda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_deuda.ForeColor = System.Drawing.Color.Coral;
            this.lbl_deuda.Location = new System.Drawing.Point(55, 74);
            this.lbl_deuda.Name = "lbl_deuda";
            this.lbl_deuda.Size = new System.Drawing.Size(64, 21);
            this.lbl_deuda.TabIndex = 56;
            this.lbl_deuda.Text = "Deuda";
            // 
            // lbl_cobro
            // 
            this.lbl_cobro.AutoSize = true;
            this.lbl_cobro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cobro.ForeColor = System.Drawing.Color.Coral;
            this.lbl_cobro.Location = new System.Drawing.Point(55, 169);
            this.lbl_cobro.Name = "lbl_cobro";
            this.lbl_cobro.Size = new System.Drawing.Size(229, 21);
            this.lbl_cobro.TabIndex = 57;
            this.lbl_cobro.Text = "Ingrese monto que se cobra";
            // 
            // txt_ingreso
            // 
            this.txt_ingreso.Location = new System.Drawing.Point(55, 204);
            this.txt_ingreso.Name = "txt_ingreso";
            this.txt_ingreso.Size = new System.Drawing.Size(138, 23);
            this.txt_ingreso.TabIndex = 58;
            // 
            // FrmCobrarDeuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(381, 420);
            this.Controls.Add(this.txt_ingreso);
            this.Controls.Add(this.lbl_cobro);
            this.Controls.Add(this.lbl_deuda);
            this.Controls.Add(this.btn_cobrar);
            this.Controls.Add(this.txt_deuda);
            this.Name = "FrmCobrarDeuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrando deuda.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCobrarDeuda_FormClosing);
            this.Load += new System.EventHandler(this.FrmCobrarDeuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_deuda;
        public System.Windows.Forms.Button btn_cobrar;
        public System.Windows.Forms.Label lbl_deuda;
        public System.Windows.Forms.Label lbl_cobro;
        public System.Windows.Forms.TextBox txt_ingreso;
    }
}