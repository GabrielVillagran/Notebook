namespace BlocDeNotas
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.busqueda = new System.Windows.Forms.Button();
            this.searchStr = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.respuesta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // busqueda
            // 
            this.busqueda.Location = new System.Drawing.Point(41, 48);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(100, 24);
            this.busqueda.TabIndex = 0;
            this.busqueda.Text = "Buscar";
            this.busqueda.UseVisualStyleBackColor = true;
            this.busqueda.Click += new System.EventHandler(this.busqueda_Click);
            // 
            // searchStr
            // 
            this.searchStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStr.Location = new System.Drawing.Point(12, 12);
            this.searchStr.Name = "searchStr";
            this.searchStr.Size = new System.Drawing.Size(281, 20);
            this.searchStr.TabIndex = 1;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(158, 48);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(100, 24);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // respuesta
            // 
            this.respuesta.Location = new System.Drawing.Point(12, 84);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(281, 20);
            this.respuesta.TabIndex = 3;
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 116);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.searchStr);
            this.Controls.Add(this.busqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancelar;
        public System.Windows.Forms.Button busqueda;
        public System.Windows.Forms.TextBox searchStr;
        public System.Windows.Forms.TextBox respuesta;
    }
}