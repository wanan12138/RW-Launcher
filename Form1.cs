using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Text;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    [DllImport("user32.dll")] //抄来的
    public static extern bool ReleaseCapture();

    [DllImport("user32.dll")]
    public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

    public const int WM_SYSCOMMAND = 0x0112;
    public const int SC_MOVE = 0xF010;
    public const int HTCAPTION = 0x0002;

    public Form1()
    {
        InitializeComponent();
    }

    private void Close(object sender, EventArgs e)
    {
        this.Close(); //关闭按钮

    }

    private void Mini(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized; //最小化按钮
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
    }

    //乱写的 fuck winform
    //[DllImport("User32.dll ", EntryPoint = "SetParent")]
    //private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
    //[DllImport("user32.dll ", EntryPoint = "ShowWindow")]
    //public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);
    //private void button3_Click(object sender, EventArgs e)
    //{ 
    //Process p = new Process();

    //p.StartInfo.FileName = "run.bat"; 

    //p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;//加上这句效果更好

    //p.Start();
    //System.Threading.Thread.Sleep(170);//加上，100如果效果没有就继续加大

    //SetParent(p.MainWindowHandle, panel1.Handle); //panel1.Handle为要显示外部程序的容器
    //ShowWindow(p.MainWindowHandle, 3);
    //}
    private void OutPutForm_Shown(object sender, EventArgs e)
    {
        Control.CheckForIllegalCrossThreadCalls = false;
        Process p = new Process();
        p.StartInfo.FileName = "run.bat";
        p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
        p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
        p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
        p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
        p.StartInfo.CreateNoWindow = true;//不显示程序窗口
        p.StartInfo.StandardErrorEncoding = Encoding.UTF8;
        p.StartInfo.StandardOutputEncoding = Encoding.UTF8; //fix编码问题
        p.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
        p.Start();//启动程序
        p.BeginOutputReadLine();
    }
    private void OutputHandler(object sendingProcess,DataReceivedEventArgs outLine)
    {
        if (!String.IsNullOrEmpty(outLine.Data))
        {
            StringBuilder sb = new StringBuilder(this.label1.Text); //编码问题
            
            this.label1.Text = sb.AppendLine(outLine.Data).ToString();
            //string utf8_string = Encoding.UTF8.GetString(Encoding.Default.GetBytes(label1.Text));
            //this.label1.Text = utf8_string;


            //this.label1.SelectionStart =this.label1.Text.Length;
            //this.label1.ScrollToCaret();
        }
    }
}