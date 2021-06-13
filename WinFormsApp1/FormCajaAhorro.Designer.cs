
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
            ((System.ComponentModel.ISupportInitialize)(this.gv_CajaAhorro)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_CajaAhorro
            // 
            this.gv_CajaAhorro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_CajaAhorro.Location = new System.Drawing.Point(12, 12);
            this.gv_CajaAhorro.Name = "gv_CajaAhorro";
            this.gv_CajaAhorro.RowTemplate.Height = 25;
            this.gv_CajaAhorro.Size = new System.Drawing.Size(620, 228);
            this.gv_CajaAhorro.TabIndex = 0;
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
            // FormCajaAhorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 339);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.input_cuit);
            this.Controls.Add(this.input_cbu);
            this.Controls.Add(this.gv_CajaAhorro);
            this.Name = "FormCajaAhorro";
            this.Text = "FormCajaAhorro";
            this.Load += new System.EventHandler(this.FormCajaAhorro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_CajaAhorro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_CajaAhorro;
        private System.Windows.Forms.TextBox input_cbu;
        private System.Windows.Forms.TextBox input_cuit;
        private System.Windows.Forms.Button btnNew;
    }
}