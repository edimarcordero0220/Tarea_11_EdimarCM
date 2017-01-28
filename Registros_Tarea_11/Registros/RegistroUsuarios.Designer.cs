namespace Registros_Tarea_11.Registros
{
    partial class RegistroUsuarios
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
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(15, 212);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 0;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(64, 15);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(100, 20);
            this.IdtextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(64, 56);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(100, 20);
            this.NombretextBox.TabIndex = 5;
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(64, 110);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.Size = new System.Drawing.Size(100, 20);
            this.ClavetextBox.TabIndex = 6;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(232, 212);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 7;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(113, 212);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 8;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(194, 13);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 9;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 271);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardarbutton);
            this.Name = "RegistroUsuarios";
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
    }
}