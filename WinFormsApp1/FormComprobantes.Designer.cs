
namespace WinFormsApp1
{
    partial class FormComprobantes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Transferencias = new System.Windows.Forms.RadioButton();
            this.rb_Depositos = new System.Windows.Forms.RadioButton();
            this.rb_Extracciones = new System.Windows.Forms.RadioButton();
            this.gv_Operaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Operaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Transferencias);
            this.groupBox1.Controls.Add(this.rb_Depositos);
            this.groupBox1.Controls.Add(this.rb_Extracciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cuenta";
            // 
            // rb_Transferencias
            // 
            this.rb_Transferencias.AutoSize = true;
            this.rb_Transferencias.Location = new System.Drawing.Point(186, 22);
            this.rb_Transferencias.Name = "rb_Transferencias";
            this.rb_Transferencias.Size = new System.Drawing.Size(99, 19);
            this.rb_Transferencias.TabIndex = 3;
            this.rb_Transferencias.TabStop = true;
            this.rb_Transferencias.Text = "Transferencias";
            this.rb_Transferencias.UseVisualStyleBackColor = true;
            this.rb_Transferencias.CheckedChanged += new System.EventHandler(this.rb_Transferencias_CheckedChanged);
            // 
            // rb_Depositos
            // 
            this.rb_Depositos.AutoSize = true;
            this.rb_Depositos.Location = new System.Drawing.Point(6, 22);
            this.rb_Depositos.Name = "rb_Depositos";
            this.rb_Depositos.Size = new System.Drawing.Size(77, 19);
            this.rb_Depositos.TabIndex = 2;
            this.rb_Depositos.TabStop = true;
            this.rb_Depositos.Text = "Depositos";
            this.rb_Depositos.UseVisualStyleBackColor = true;
            this.rb_Depositos.CheckedChanged += new System.EventHandler(this.rb_Depositos_CheckedChanged);
            // 
            // rb_Extracciones
            // 
            this.rb_Extracciones.AutoSize = true;
            this.rb_Extracciones.Location = new System.Drawing.Point(89, 22);
            this.rb_Extracciones.Name = "rb_Extracciones";
            this.rb_Extracciones.Size = new System.Drawing.Size(91, 19);
            this.rb_Extracciones.TabIndex = 0;
            this.rb_Extracciones.TabStop = true;
            this.rb_Extracciones.Text = "Extracciones";
            this.rb_Extracciones.UseVisualStyleBackColor = true;
            this.rb_Extracciones.CheckedChanged += new System.EventHandler(this.rb_Extracciones_CheckedChanged);
            // 
            // gv_Operaciones
            // 
            this.gv_Operaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_Operaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Operaciones.Location = new System.Drawing.Point(12, 78);
            this.gv_Operaciones.Name = "gv_Operaciones";
            this.gv_Operaciones.RowTemplate.Height = 25;
            this.gv_Operaciones.Size = new System.Drawing.Size(1016, 360);
            this.gv_Operaciones.TabIndex = 3;
            // 
            // FormComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.gv_Operaciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormComprobantes";
            this.Text = "FormComprobantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Operaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Transferencias;
        private System.Windows.Forms.RadioButton rb_Depositos;
        private System.Windows.Forms.RadioButton rb_Extracciones;
        private System.Windows.Forms.DataGridView gv_Operaciones;
    }
}