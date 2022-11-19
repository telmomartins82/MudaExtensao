namespace MudaExtensao
{
    partial class MudaExtForm
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
            this.lblFich = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovaExt = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFich
            // 
            this.lblFich.AutoSize = true;
            this.lblFich.Location = new System.Drawing.Point(6, 9);
            this.lblFich.Name = "lblFich";
            this.lblFich.Size = new System.Drawing.Size(47, 13);
            this.lblFich.TabIndex = 4;
            this.lblFich.Text = "Ficheiro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nova ext:";
            // 
            // txtNovaExt
            // 
            this.txtNovaExt.Location = new System.Drawing.Point(65, 33);
            this.txtNovaExt.MaxLength = 15;
            this.txtNovaExt.Name = "txtNovaExt";
            this.txtNovaExt.Size = new System.Drawing.Size(92, 20);
            this.txtNovaExt.TabIndex = 5;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(38, 77);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(55, 26);
            this.btOk.TabIndex = 7;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(142, 77);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(65, 26);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // MudaExtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 115);
            this.ControlBox = false;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNovaExt);
            this.Controls.Add(this.lblFich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MudaExtForm";
            this.ShowIcon = false;
            this.Text = "Muda Extensão by Juggernaut";
            this.Load += new System.EventHandler(this.MudaExtForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNovaExt;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}

