using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swap_day3_task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int x = 5, y = 10;
            x = x ^ y ^ (y = x);
            Console.WriteLine("After Swapping values " + "of x and y are " + x + y);
        }
    }
}
