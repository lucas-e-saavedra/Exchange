
namespace WinFormsApp1
{
    partial class FormWallet
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
            this.gv_wallet = new System.Windows.Forms.DataGridView();
            this.input_direccion = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbSeleccion = new System.Windows.Forms.GroupBox();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.input_Depositar = new System.Windows.Forms.TextBox();
            this.input_Extraer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_wallet)).BeginInit();
            this.gbSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_wallet
            // 
            this.gv_wallet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_wallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_wallet.Location = new System.Drawing.Point(13, 13);
            this.gv_wallet.Name = "gv_wallet";
            this.gv_wallet.RowTemplate.Height = 25;
            this.gv_wallet.Size = new System.Drawing.Size(667, 210);
            this.gv_wallet.TabIndex = 0;
            this.gv_wallet.SelectionChanged += new System.EventHandler(this.gv_wallet_SelectionChanged);
            // 
            // input_direccion
            // 
            this.input_direccion.Location = new System.Drawing.Point(13, 279);
            this.input_direccion.Name = "input_direccion";
            this.input_direccion.PlaceholderText = "Direccion";
            this.input_direccion.Size = new System.Drawing.Size(408, 23);
            this.input_direccion.TabIndex = 1;
            this.input_direccion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.input_direccion_MouseDoubleClick);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(346, 308);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Agregar";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gbSeleccion
            // 
            this.gbSeleccion.Controls.Add(this.input_Extraer);
            this.gbSeleccion.Controls.Add(this.input_Depositar);
            this.gbSeleccion.Controls.Add(this.btnExtraer);
            this.gbSeleccion.Controls.Add(this.btnDepositar);
            this.gbSeleccion.Location = new System.Drawing.Point(480, 229);
            this.gbSeleccion.Name = "gbSeleccion";
            this.gbSeleccion.Size = new System.Drawing.Size(200, 110);
            this.gbSeleccion.TabIndex = 5;
            this.gbSeleccion.TabStop = false;
            this.gbSeleccion.Text = "Seleccionar Cuenta";
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
            // input_Depositar
            // 
            this.input_Depositar.Location = new System.Drawing.Point(89, 23);
            this.input_Depositar.Name = "input_Depositar";
            this.input_Depositar.Size = new System.Drawing.Size(100, 23);
            this.input_Depositar.TabIndex = 2;
            // 
            // input_Extraer
            // 
            this.input_Extraer.Location = new System.Drawing.Point(88, 54);
            this.input_Extraer.Name = "input_Extraer";
            this.input_Extraer.Size = new System.Drawing.Size(100, 23);
            this.input_Extraer.TabIndex = 3;
            // 
            // FormWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 351);
            this.Controls.Add(this.gbSeleccion);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.input_direccion);
            this.Controls.Add(this.gv_wallet);
            this.Name = "FormWallet";
            this.Text = "FormWallet";
            this.Load += new System.EventHandler(this.FormWallet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_wallet)).EndInit();
            this.gbSeleccion.ResumeLayout(false);
            this.gbSeleccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_wallet;
        private System.Windows.Forms.TextBox input_direccion;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gbSeleccion;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox input_Extraer;
        private System.Windows.Forms.TextBox input_Depositar;
    }
}