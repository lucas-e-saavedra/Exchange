
namespace WinFormsApp1
{
    partial class FormCajaAhorro
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
            this.gv_CajaAhorro = new System.Windows.Forms.DataGridView();
            this.input_cbu = new System.Windows.Forms.TextBox();
            this.input_cuit = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbSeleccion = new System.Windows.Forms.GroupBox();
            this.nu_Extraer = new System.Windows.Forms.NumericUpDown();
            this.nu_Depositar = new System.Windows.Forms.NumericUpDown();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CajaAhorro)).BeginInit();
            this.gbSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Extraer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Depositar)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_CajaAhorro
            // 
            this.gv_CajaAhorro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_CajaAhorro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_CajaAhorro.Location = new System.Drawing.Point(12, 12);
            this.gv_CajaAhorro.Name = "gv_CajaAhorro";
            this.gv_CajaAhorro.RowTemplate.Height = 25;
            this.gv_CajaAhorro.Size = new System.Drawing.Size(620, 228);
            this.gv_CajaAhorro.TabIndex = 0;
            this.gv_CajaAhorro.SelectionChanged += new System.EventHandler(this.gv_CajaAhorro_SelectionChanged);
            // 
            // input_cbu
            // 
            this.input_cbu.Location = new System.Drawing.Point(13, 246);
            this.input_cbu.Name = "input_cbu";
            this.input_cbu.PlaceholderText = "CBU";
            this.input_cbu.Size = new System.Drawing.Size(229, 23);
            this.input_cbu.TabIndex = 1;
            // 
            // input_cuit
            // 
            this.input_cuit.Location = new System.Drawing.Point(13, 275);
            this.input_cuit.Name = "input_cuit";
            this.input_cuit.PlaceholderText = "CUIT";
            this.input_cuit.Size = new System.Drawing.Size(229, 23);
            this.input_cuit.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(167, 304);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Agregar";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gbSeleccion
            // 
            this.gbSeleccion.Controls.Add(this.nu_Extraer);
            this.gbSeleccion.Controls.Add(this.nu_Depositar);
            this.gbSeleccion.Controls.Add(this.btnExtraer);
            this.gbSeleccion.Controls.Add(this.btnDepositar);
            this.gbSeleccion.Location = new System.Drawing.Point(287, 246);
            this.gbSeleccion.Name = "gbSeleccion";
            this.gbSeleccion.Size = new System.Drawing.Size(200, 133);
            this.gbSeleccion.TabIndex = 4;
            this.gbSeleccion.TabStop = false;
            this.gbSeleccion.Text = "Seleccionar Cuenta";
            // 
            // nu_Extraer
            // 
            this.nu_Extraer.Location = new System.Drawing.Point(89, 52);
            this.nu_Extraer.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nu_Extraer.Name = "nu_Extraer";
            this.nu_Extraer.Size = new System.Drawing.Size(105, 23);
            this.nu_Extraer.TabIndex = 3;
            // 
            // nu_Depositar
            // 
            this.nu_Depositar.Location = new System.Drawing.Point(89, 23);
            this.nu_Depositar.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nu_Depositar.Name = "nu_Depositar";
            this.nu_Depositar.Size = new System.Drawing.Size(105, 23);
            this.nu_Depositar.TabIndex = 2;
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(7, 53);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(75, 23);
            this.btnExtraer.TabIndex = 1;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(7, 23);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 0;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // FormCajaAhorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 391);
            this.Controls.Add(this.gbSeleccion);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.input_cuit);
            this.Controls.Add(this.input_cbu);
            this.Controls.Add(this.gv_CajaAhorro);
            this.Name = "FormCajaAhorro";
            this.Text = "FormCajaAhorro";
            this.Load += new System.EventHandler(this.FormCajaAhorro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_CajaAhorro)).EndInit();
            this.gbSeleccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nu_Extraer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Depositar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_CajaAhorro;
        private System.Windows.Forms.TextBox input_cbu;
        private System.Windows.Forms.TextBox input_cuit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gbSeleccion;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.NumericUpDown nu_Extraer;
        private System.Windows.Forms.NumericUpDown nu_Depositar;
    }
}