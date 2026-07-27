// Pasaporte/ID: 143540342 - Anthony Buitrago (Matrícula: 2024-2047)
using System;
using System.Windows.Forms;

namespace HotelZormat
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Marcador anti-IA obligatorio: variable de matrícula del estudiante
            int matricula = 20242047;
            Console.WriteLine("Matrícula Estudiante: " + matricula);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
