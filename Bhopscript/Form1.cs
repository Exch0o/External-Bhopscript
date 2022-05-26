using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhopscript
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlag, int dx, int dy, int cbuttons, int dwExtraInfo);

        const int mouse3Down = 0x0020;
        const int mouse3up = 0x0040;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread bh = new Thread(BHOP);
            bh.Start();
        }
        private void BHOP()
        {
            while (true)
            {
            if (GetAsyncKeyState(Keys.Space)<0)
                {
                    mouse_event(mouse3Down, 0, 0, 0, 0);
                    Thread.Sleep(9);
                    mouse_event(mouse3up, 0, 0, 0, 0);
                    Thread.Sleep(9);
                   
                }
                Thread.Sleep(10);
            }
        }
    }
}
