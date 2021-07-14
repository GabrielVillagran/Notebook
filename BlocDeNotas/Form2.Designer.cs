namespace BlocDeNotas
{
    partial class confirma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirma));
            this.label1 = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.noGuardar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Quieres guardar los cambios?";
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(17, 60);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(97, 23);
            this.guardar.TabIndex = 1;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // noGuardar
            // 
            this.noGuardar.Location = new System.Drawing.Point(124, 60);
            this.noGuardar.Name = "noGuardar";
            this.noGuardar.Size = new System.Drawing.Size(95, 23);
            this.noGuardar.TabIndex = 2;
            this.noGuardar.Text = "No guardar";
            this.noGuardar.UseVisualStyleBackColor = true;
            this.noGuardar.Click += new System.EventHandler(this.noGuardar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(225, 60);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(95, 23);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // confirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(344, 111);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.noGuardar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "confirma";
            this.Text = "Bloc de notas";
            this.Load += new System.EventHandler(this.confirma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button noGuardar;
        private System.Windows.Forms.Button cancelar;
    }
}