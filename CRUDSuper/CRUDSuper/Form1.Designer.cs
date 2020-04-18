namespace CRUDSuper
{
    partial class Crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crud));
            this.Registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpoder = new System.Windows.Forms.TextBox();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(12, 183);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 0;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Idsuper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Poder";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(77, 54);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(121, 20);
            this.txtid.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(77, 83);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(121, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtpoder
            // 
            this.txtpoder.Location = new System.Drawing.Point(77, 136);
            this.txtpoder.Name = "txtpoder";
            this.txtpoder.Size = new System.Drawing.Size(121, 20);
            this.txtpoder.TabIndex = 8;
            // 
            // cmbsexo
            // 
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "H",
            "M"});
            this.cmbsexo.Location = new System.Drawing.Point(77, 109);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(121, 21);
            this.cmbsexo.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(235, 96);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(75, 23);
            this.Consultar.TabIndex = 11;
            this.Consultar.Text = "consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(235, 54);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 12;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 259);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbsexo);
            this.Controls.Add(this.txtpoder);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crud";
            this.Text = "CRUD Super";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpoder;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button btneliminar;
    }
}

