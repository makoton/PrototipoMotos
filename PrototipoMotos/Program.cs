using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrototipoMotos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*te gusta el pico?*/
            string cambio = "este es un cambio de prueba para Git";
        }
    }
}
