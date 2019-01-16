using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortingAlgorithmLibrary;

namespace SortingDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int[] test = new int[] { 5, 3, 2, 2, 1, 6 };

            InsertionSort<int>.Sort(test);

            Console.WriteLine(test);
            //Application.Run(new frmSortDisplay());


        }
    }
}
