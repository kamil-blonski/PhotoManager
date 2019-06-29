using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoManager
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
			
			IView view = LoggingWindow.getInstance();
			Model.Model model = new Model.Model();
			Presenter presenter = new Presenter(view,model);
			Application.Run((Form)view);
			//Application.Run(LoggingWindow.getInstance());
            //Application.Run(new Form1());
        }
    }
}
