
namespace AdministracionClub
{
    partial class FrmPersonas<T,U>  
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
            this.lst_personas = new System.Windows.Forms.ListBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_personas
            // 
            this.lst_personas.FormattingEnabled = true;
            this.lst_personas.ItemHeight = 15;
            this.lst_personas.Location = new System.Drawing.Point(49, 33);
            this.lst_personas.Name = "lst_personas";
            this.lst_personas.Size = new System.Drawing.Size(800, 364);
            this.lst_personas.TabIndex = 0;
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
            this.btn_agregar.Location = new System.Drawing.Point(442, 413);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(168, 31);
            this.btn_agregar.TabIndex = 55;
            this.btn_agregar.Text = "Agregar nuevo";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_abrir
            // 
            this.btn_abrir.AutoSize = true;
            this.btn_abrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_abrir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_abrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_abrir.ForeColor = System.Drawing.Color.Coral;
            this.btn_abrir.Location = new System.Drawing.Point(243, 413);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(168, 31);
            this.btn_abrir.TabIndex = 56;
            this.btn_abrir.Text = "Abrir";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // FrmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(900, 478);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lst_personas);
            this.Name = "FrmPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.FrmPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_personas;
        public System.Windows.Forms.Button btn_agregar;
        public System.Windows.Forms.Button btn_abrir;
    }
}