using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DE;

namespace DeFurry
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Euler A = Euler(1, 2, 3, 4);
            Imp_Euler B = Imp_Euler(1,2,3,4);
            RK C = RK(1,2,3,4);
        }
    }
}
