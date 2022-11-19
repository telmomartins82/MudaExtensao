using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MudaExtensao
{
    public partial class MudaExtForm : Form
    {
        private string path;

        public MudaExtForm(string path)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovaExt_KeyDown);
            this.txtNovaExt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovaExt_KeyDown);
            preencheCampos(path);
            this.path = path;
        }

        private void MudaExtForm_Load(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate()
            {
                txtNovaExt.Focus();
                txtNovaExt.SelectAll();
            });
            
        }

        private void preencheCampos(string path)
        {
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                lblFich.Text = fi.Name;
                txtNovaExt.Text = fi.Extension.Length > 0 ? fi.Extension.Substring(1) : "";
            }
            else
            {
                MessageBox.Show("Ficheiro Inexistente!");
                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            string novoPath = Path.ChangeExtension(this.path, txtNovaExt.Text.Length > 0 ? "." + txtNovaExt.Text : "");
            FileInfo fi = new FileInfo(this.path);
            if (fi.Exists)
            {
                try
                {
                    fi.MoveTo(novoPath);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao mudar a extensão: verifique se o ficheiro está a ser usado ou se a nova extensão é válida.", "Mudar Extensão");
                }
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao mudar a extensão: o ficheiro já não existe.", "Mudar Extensão");
                this.Close();
            }
        }
        
            
    

        private void txtNovaExt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.None)
            {
                btOk_Click(sender, null);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape && e.Modifiers == Keys.None)
            {
                this.Close();
            }
        }
    }
}