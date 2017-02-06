namespace Registros_Tarea_11.Consultas
{
    partial class ConsultarUsuario
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
            this.components = new System.ComponentModel.Container();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.FiltrardataGridView = new System.Windows.Forms.DataGridView();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FiltrardataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(343, 5);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 0;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Location = new System.Drawing.Point(15, 287);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 23);
            this.Imprimirbutton.TabIndex = 1;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filtrar";
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Location = new System.Drawing.Point(69, 15);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarcomboBox.TabIndex = 5;
            // 
            // FiltrardataGridView
            // 
            this.FiltrardataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FiltrardataGridView.Location = new System.Drawing.Point(15, 131);
            this.FiltrardataGridView.Name = "FiltrardataGridView";
            this.FiltrardataGridView.Size = new System.Drawing.Size(471, 150);
            this.FiltrardataGridView.TabIndex = 6;
            this.FiltrardataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(127, 81);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(88, 20);
            this.DesdedateTimePicker.TabIndex = 7;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastadateTimePicker.Location = new System.Drawing.Point(279, 80);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(78, 20);
            this.HastadateTimePicker.TabIndex = 8;
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(228, 12);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(100, 20);
            this.BuscartextBox.TabIndex = 9;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 322);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.FiltrardataGridView);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "ConsultarUsuario";
            this.Text = "ConsultarUsuario";
            this.Load += new System.EventHandler(this.ConsultarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FiltrardataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.DataGridView FiltrardataGridView;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}