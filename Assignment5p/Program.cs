using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5p
{
    static class Program
    {
        public static Splashform splashForm;
        public static Startform startForm;
       public static SelectForm selectForm;
      /*  public static Product selectedProduct;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm; */
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
          /*  productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();*/

            Application.Run(splashForm);
    
        }
    }
}
