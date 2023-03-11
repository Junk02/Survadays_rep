using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survadays
{
    public class Message
    {
        public Message()
        {
            MessageBox.Show(
                "Создан экземпляр класса Message.",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );
        }

        public static void MethodError(Exception ex, string message)
        {
            MessageBox.Show(
                $"Error: Ошибка в методе {message}.\n-----\n{ex.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
    }
}
