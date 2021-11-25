
namespace AppLauncher.ALGenCallsSabNetSrv
{
    partial class FrmPrincCallSabNet
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincCallSabNet));
            this.label9 = new System.Windows.Forms.Label();
            this.txtCSharpInvok = new System.Windows.Forms.TextBox();
            this.txtDbOwner = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServName = new System.Windows.Forms.TextBox();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEntityOption = new System.Windows.Forms.TextBox();
            this.tlStripOptions = new System.Windows.Forms.ToolStrip();
            this.tlStrpSalir = new System.Windows.Forms.ToolStripButton();
            this.tlsButExecute = new System.Windows.Forms.ToolStripButton();
            this.tlStripOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "C# Call";
            // 
            // txtCSharpInvok
            // 
            this.txtCSharpInvok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCSharpInvok.Location = new System.Drawing.Point(-4, 128);
            this.txtCSharpInvok.Multiline = true;
            this.txtCSharpInvok.Name = "txtCSharpInvok";
            this.txtCSharpInvok.Size = new System.Drawing.Size(962, 418);
            this.txtCSharpInvok.TabIndex = 31;
            // 
            // txtDbOwner
            // 
            this.txtDbOwner.Location = new System.Drawing.Point(578, 35);
            this.txtDbOwner.Name = "txtDbOwner";
            this.txtDbOwner.Size = new System.Drawing.Size(357, 22);
            this.txtDbOwner.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Service name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Owner:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtServName
            // 
            this.txtServName.Location = new System.Drawing.Point(117, 35);
            this.txtServName.Name = "txtServName";
            this.txtServName.Size = new System.Drawing.Size(333, 22);
            this.txtServName.TabIndex = 24;
            // 
            // txtEntityName
            // 
            this.txtEntityName.Location = new System.Drawing.Point(117, 73);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(333, 22);
            this.txtEntityName.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Entity Option:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Entity Name:";
            // 
            // txtEntityOption
            // 
            this.txtEntityOption.Location = new System.Drawing.Point(578, 73);
            this.txtEntityOption.Name = "txtEntityOption";
            this.txtEntityOption.Size = new System.Drawing.Size(357, 22);
            this.txtEntityOption.TabIndex = 26;
            // 
            // tlStripOptions
            // 
            this.tlStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStrpSalir,
            this.tlsButExecute});
            this.tlStripOptions.Location = new System.Drawing.Point(0, 0);
            this.tlStripOptions.Name = "tlStripOptions";
            this.tlStripOptions.Size = new System.Drawing.Size(963, 25);
            this.tlStripOptions.TabIndex = 33;
            this.tlStripOptions.Text = "toolStrip1";
            // 
            // tlStrpSalir
            // 
            this.tlStrpSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlStrpSalir.Image = ((System.Drawing.Image)(resources.GetObject("tlStrpSalir.Image")));
            this.tlStrpSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlStrpSalir.Name = "tlStrpSalir";
            this.tlStrpSalir.Size = new System.Drawing.Size(23, 22);
            this.tlStrpSalir.Text = "toolStripButton1";
            this.tlStrpSalir.ToolTipText = "Salir";
            this.tlStrpSalir.Click += new System.EventHandler(this.tlStrpSalir_Click);
            // 
            // tlsButExecute
            // 
            this.tlsButExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsButExecute.Image = ((System.Drawing.Image)(resources.GetObject("tlsButExecute.Image")));
            this.tlsButExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsButExecute.Name = "tlsButExecute";
            this.tlsButExecute.Size = new System.Drawing.Size(23, 22);
            this.tlsButExecute.Text = "toolStripButton2";
            this.tlsButExecute.ToolTipText = "Do Process";
            this.tlsButExecute.Click += new System.EventHandler(this.tlsButExecute_Click);
            // 
            // FrmPrincCallSabNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 548);
            this.Controls.Add(this.tlStripOptions);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCSharpInvok);
            this.Controls.Add(this.txtDbOwner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtServName);
            this.Controls.Add(this.txtEntityName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEntityOption);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincCallSabNet";
            this.Text = "Form1";
            this.tlStripOptions.ResumeLayout(false);
            this.tlStripOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCSharpInvok;
        private System.Windows.Forms.TextBox txtDbOwner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServName;
        private System.Windows.Forms.TextBox txtEntityName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEntityOption;
        private System.Windows.Forms.ToolStrip tlStripOptions;
        private System.Windows.Forms.ToolStripButton tlStrpSalir;
        private System.Windows.Forms.ToolStripButton tlsButExecute;
    }
}

