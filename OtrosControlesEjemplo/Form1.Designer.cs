namespace OtrosControlesEjemplo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boton1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkboxChocolate = new System.Windows.Forms.CheckBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.labelColorFav = new System.Windows.Forms.Label();
            this.botonPerfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.boton1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.boton1.Location = new System.Drawing.Point(159, 409);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(105, 37);
            this.boton1.TabIndex = 6;
            this.boton1.Text = "Agregar";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(40, 247);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 156);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(170, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(42, 18);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(28, 66);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(70, 16);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = "FechaNac";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // checkboxChocolate
            // 
            this.checkboxChocolate.AutoSize = true;
            this.checkboxChocolate.Location = new System.Drawing.Point(170, 110);
            this.checkboxChocolate.Name = "checkboxChocolate";
            this.checkboxChocolate.Size = new System.Drawing.Size(94, 20);
            this.checkboxChocolate.TabIndex = 2;
            this.checkboxChocolate.Text = "Chocolate?";
            this.checkboxChocolate.UseVisualStyleBackColor = true;
            this.checkboxChocolate.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboColor
            // 
            this.comboColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Location = new System.Drawing.Point(170, 152);
            this.comboColor.MaximumSize = new System.Drawing.Size(248, 0);
            this.comboColor.MinimumSize = new System.Drawing.Size(248, 0);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(248, 24);
            this.comboColor.TabIndex = 3;
            this.comboColor.SelectedIndexChanged += new System.EventHandler(this.comboColor_SelectedIndexChanged);
            // 
            // labelColorFav
            // 
            this.labelColorFav.AutoSize = true;
            this.labelColorFav.Location = new System.Drawing.Point(12, 160);
            this.labelColorFav.Name = "labelColorFav";
            this.labelColorFav.Size = new System.Drawing.Size(86, 16);
            this.labelColorFav.TabIndex = 8;
            this.labelColorFav.Text = "Color favorito";
            this.labelColorFav.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // botonPerfil
            // 
            this.botonPerfil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonPerfil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonPerfil.Location = new System.Drawing.Point(170, 205);
            this.botonPerfil.Name = "botonPerfil";
            this.botonPerfil.Size = new System.Drawing.Size(146, 23);
            this.botonPerfil.TabIndex = 4;
            this.botonPerfil.Text = "Ver Perfil";
            this.botonPerfil.UseVisualStyleBackColor = false;
            this.botonPerfil.Click += new System.EventHandler(this.botonPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(490, 478);
            this.Controls.Add(this.botonPerfil);
            this.Controls.Add(this.labelColorFav);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.checkboxChocolate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.boton1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkboxChocolate;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.Label labelColorFav;
        private System.Windows.Forms.Button botonPerfil;
    }
}

