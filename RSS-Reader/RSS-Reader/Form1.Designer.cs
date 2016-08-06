namespace RSS_Reader
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCanal = new System.Windows.Forms.TextBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.linkLabelLiga = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBoxCanal
            // 
            this.textBoxCanal.Location = new System.Drawing.Point(13, 13);
            this.textBoxCanal.Name = "textBoxCanal";
            this.textBoxCanal.Size = new System.Drawing.Size(274, 20);
            this.textBoxCanal.TabIndex = 0;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(293, 13);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(96, 48);
            this.buttonActualizar.TabIndex = 1;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(13, 40);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(274, 21);
            this.comboBoxItems.TabIndex = 2;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(13, 68);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.Size = new System.Drawing.Size(376, 133);
            this.textBoxContenido.TabIndex = 3;
            // 
            // linkLabelLiga
            // 
            this.linkLabelLiga.AutoSize = true;
            this.linkLabelLiga.Location = new System.Drawing.Point(13, 208);
            this.linkLabelLiga.Name = "linkLabelLiga";
            this.linkLabelLiga.Size = new System.Drawing.Size(28, 13);
            this.linkLabelLiga.TabIndex = 4;
            this.linkLabelLiga.TabStop = true;
            this.linkLabelLiga.Text = "Ir a: ";
            this.linkLabelLiga.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLiga_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 231);
            this.Controls.Add(this.linkLabelLiga);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.textBoxCanal);
            this.Name = "Form1";
            this.Text = "Lector RSS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCanal;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.LinkLabel linkLabelLiga;
    }
}

