namespace CreacionBotones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnGuargdar = new System.Windows.Forms.Button();
            this.btmLimpiar = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elemento 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(110, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(309, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.White;
            this.txtEdad.Location = new System.Drawing.Point(110, 91);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(309, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // btnGuargdar
            // 
            this.btnGuargdar.BackColor = System.Drawing.Color.LightBlue;
            this.btnGuargdar.Location = new System.Drawing.Point(31, 341);
            this.btnGuargdar.Name = "btnGuargdar";
            this.btnGuargdar.Size = new System.Drawing.Size(77, 33);
            this.btnGuargdar.TabIndex = 8;
            this.btnGuargdar.Text = "Guardar";
            this.btnGuargdar.UseVisualStyleBackColor = false;
            this.btnGuargdar.Click += new System.EventHandler(this.btnGuargdar_Click);
            // 
            // btmLimpiar
            // 
            this.btmLimpiar.BackColor = System.Drawing.Color.Firebrick;
            this.btmLimpiar.Location = new System.Drawing.Point(186, 341);
            this.btmLimpiar.Name = "btmLimpiar";
            this.btmLimpiar.Size = new System.Drawing.Size(81, 34);
            this.btmLimpiar.TabIndex = 9;
            this.btmLimpiar.Text = "Limpiar";
            this.btmLimpiar.UseVisualStyleBackColor = false;
            this.btmLimpiar.Click += new System.EventHandler(this.btmLimpiar_Click);
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.GridColor = System.Drawing.Color.MediumTurquoise;
            this.Grilla.Location = new System.Drawing.Point(31, 139);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(603, 184);
            this.Grilla.TabIndex = 10;
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.PowderBlue;
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(834, 41);
            this.MenuTitulo.TabIndex = 11;
            this.MenuTitulo.Text = "menuStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(380, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "WELCOME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(200, 50);
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.btmLimpiar);
            this.Controls.Add(this.btnGuargdar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuTitulo);
            this.MainMenuStrip = this.MenuTitulo;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnGuargdar;
        private System.Windows.Forms.Button btmLimpiar;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.Label label4;
    }
}

