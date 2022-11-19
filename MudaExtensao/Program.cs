using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MudaExtensao
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MudaExtForm(args[0]));
        }
    }
}