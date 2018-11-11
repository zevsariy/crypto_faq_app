using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALL_LABS.Helpers
{
    public class Log
    {
        private RichTextBox _logger;
        public Log(RichTextBox logger)
        {
            _logger = logger;
        }

        public void WriteLine(string text)
        {
            _logger.Text += $"{text} \r\n";
        }
    }
}
