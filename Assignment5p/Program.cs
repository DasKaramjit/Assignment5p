using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5p
{
    /*
     * Das Karamjit
     * 301108505
     * 23-08-2020
     * This program is about dollar computers
     */
    static class Program
    {
        public static Splashform splashForm;

        public static Startform startForm;

        public static SelectForm selectForm;
        public static ProductInfo productInfoForm;

        

        public static OrderForm orderForm;
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new Splashform();
            startForm = new Startform();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfo();
            orderForm = new OrderForm();

            Application.Run(new Splashform());
        }
    }
}
