﻿
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.depositarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaAhorroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositarToolStripMenuItem,
            this.extraerToolStripMenuItem,
            this.transferirToolStripMenuItem,
            this.cajaAhorroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // depositarToolStripMenuItem
            // 
            this.depositarToolStripMenuItem.Name = "depositarToolStripMenuItem";
            this.depositarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.depositarToolStripMenuItem.Text = "Depositar";
            this.depositarToolStripMenuItem.Click += new System.EventHandler(this.depositarToolStripMenuItem_Click);
            // 
            // extraerToolStripMenuItem
            // 
            this.extraerToolStripMenuItem.Name = "extraerToolStripMenuItem";
            this.extraerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.extraerToolStripMenuItem.Text = "Extraer";
            this.extraerToolStripMenuItem.Click += new System.EventHandler(this.extraerToolStripMenuItem_Click);
            // 
            // transferirToolStripMenuItem
            // 
            this.transferirToolStripMenuItem.Name = "transferirToolStripMenuItem";
            this.transferirToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.transferirToolStripMenuItem.Text = "Transferir";
            this.transferirToolStripMenuItem.Click += new System.EventHandler(this.transferirToolStripMenuItem_Click);
            // 
            // cajaAhorroToolStripMenuItem
            // 
            this.cajaAhorroToolStripMenuItem.Name = "cajaAhorroToolStripMenuItem";
            this.cajaAhorroToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.cajaAhorroToolStripMenuItem.Text = "CajaAhorro";
            this.cajaAhorroToolStripMenuItem.Click += new System.EventHandler(this.cajaAhorroToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 490);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem depositarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaAhorroToolStripMenuItem;
    }
}

