using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAircondition
{
    public partial class D_ReplyControl : UserControl
    {
        public static  string ReplyContent { get; set; }
        public D_ReplyControl()
        {
            InitializeComponent();
            textBox1.Text = ReplyContent;
        }
    }
}
