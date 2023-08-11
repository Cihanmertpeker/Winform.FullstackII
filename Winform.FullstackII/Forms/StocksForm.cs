using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform.FullstackII.Forms
{
    public class StocksForm
    {
        public StocksForm(string userFullname, string text)
        {
            UserFullname = userFullname;
            Text = text;
        }

        public string UserFullname { get; }
        public string Text { get; }
    }
}
