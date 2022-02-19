using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;

namespace Stream_Client
{
    /*
    internal static class Extensions
    {
        [DllImport("Kernel32.dll")]
        private static extern bool QueryFullProcessImageName([In] IntPtr hProcess, [In] uint dwFlags, [Out] StringBuilder lpExeName, [In, Out] ref uint lpdwSize);

        public static string GetMainModuleFileName(this Process process, int buffer = 1024)
        {
            var fileNameBuilder = new StringBuilder(buffer);
            uint bufferLength = (uint)fileNameBuilder.Capacity + 1;
            return QueryFullProcessImageName(process.Handle, 0, fileNameBuilder, ref bufferLength) ?
                fileNameBuilder.ToString() :
                null;
        }
    }
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);
        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcesses();
            comboBox1.Items.Clear();
            foreach (Process process in processList)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {

                    StringBuilder className = new StringBuilder(256);
                    //Get the window class name
                    GetClassName(process.MainWindowHandle, className, className.Capacity);


                    comboBox1.Items.Add("[" + Path.GetFileName(process.MainModule.FileName) + "]: " + process.MainWindowTitle);

                    //What needs to be inserted into the json. Includes className so that 
                    Console.WriteLine(process.MainWindowTitle.Replace(":", "#3a") + ":" + className.Replace(":", "#3a") + ":" + Path.GetFileName(process.MainModule.FileName).Replace(":", "#3a"));
                    //Update JSON for the scene and replace the window capture device and the application audio output capture window objects with this.
                    //Then boot the correct batch file.
                }
            }
        }

    }
}
