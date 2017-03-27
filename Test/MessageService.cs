using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Test
{
    public interface IMessageService
    {
        void ShowError(string message);
        void ShowResult(string message);
    }
    public class MessageService : IMessageService
    {
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Choose answer.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowResult(string message)
        {
            MessageBox.Show(message, "Result: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
