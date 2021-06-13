
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
            ((System.ComponentModel.ISupportInitialize)(this.gv_wallet)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_wallet
            // 
            this.gv_wallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_wallet.Location = new System.Drawing.Point(13, 13);
            this.gv_wallet.Name = "gv_wallet";
            this.gv_wallet.RowTemplate.Height = 25;
            this.gv_wallet.Size = new System.Drawing.Size(667, 210);
            this.gv_wallet.TabIndex = 0;
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
            // FormWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 351);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.input_direccion);
            this.Controls.Add(this.gv_wallet);
            this.Name = "FormWallet";
            this.Text = "FormWallet";
            this.Load += new System.EventHandler(this.FormWallet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_wallet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_wallet;
        private System.Windows.Forms.TextBox input_direccion;
        private System.Windows.Forms.Button btnNew;
    }
}