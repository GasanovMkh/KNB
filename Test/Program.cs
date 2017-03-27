using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestBL;

namespace Test
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

            TestForm form = new TestForm();
            MessageService service = new MessageService();
            TestManager manager = new TestManager();
            TestPresenter presenter = new TestPresenter(form, manager, service);
            Application.Run(form);
        }
    }
}
