
namespace WinFormsApp1
{
    partial class FormDestinoTransferencia
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
            this.gv_CuentasDestino = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_CajaAhorro = new System.Windows.Forms.RadioButton();
            this.rb_Wallet = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CuentasDestino)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_CuentasDestino
            // 
            this.gv_CuentasDestino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_CuentasDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_CuentasDestino.Location = new System.Drawing.Point(13, 78);
            this.gv_CuentasDestino.Name = "gv_CuentasDestino";
            this.gv_CuentasDestino.RowTemplate.Height = 25;
            this.gv_CuentasDestino.Size = new System.Drawing.Size(775, 196);
            this.gv_CuentasDestino.TabIndex = 0;
            this.gv_CuentasDestino.SelectionChanged += new System.EventHandler(this.gv_CuentasDestino_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_CajaAhorro);
            this.groupBox1.Controls.Add(this.rb_Wallet);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cuenta";
            // 
            // rb_CajaAhorro
            // 
            this.rb_CajaAhorro.AutoSize = true;
            this.rb_CajaAhorro.Location = new System.Drawing.Point(6, 22);
            this.rb_CajaAhorro.Name = "rb_CajaAhorro";
            this.rb_CajaAhorro.Size = new System.Drawing.Size(136, 19);
            this.rb_CajaAhorro.TabIndex = 2;
            this.rb_CajaAhorro.TabStop = true;
            this.rb_CajaAhorro.Text = "Caja de Ahorro (ARS)";
            this.rb_CajaAhorro.UseVisualStyleBackColor = true;
            this.rb_CajaAhorro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_Wallet
            // 
            this.rb_Wallet.AutoSize = true;
            this.rb_Wallet.Location = new System.Drawing.Point(148, 22);
            this.rb_Wallet.Name = "rb_Wallet";
            this.rb_Wallet.Size = new System.Drawing.Size(97, 19);
            this.rb_Wallet.TabIndex = 0;
            this.rb_Wallet.TabStop = true;
            this.rb_Wallet.Text = "Billetera (BTC)";
            this.rb_Wallet.UseVisualStyleBackColor = true;
            this.rb_Wallet.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(201, 280);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(373, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormDestinoTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gv_CuentasDestino);
            this.Name = "FormDestinoTransferencia";
            this.Text = "FormDestinoTransferencia";
            ((System.ComponentModel.ISupportInitialize)(this.gv_CuentasDestino)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_CuentasDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_CajaAhorro;
        private System.Windows.Forms.RadioButton rb_Wallet;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}