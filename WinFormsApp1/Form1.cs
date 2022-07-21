using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public UserControl1 F1;
    public UserControl2 F2;
    private int A = 1;
    
    //public static string str;
    
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
        F1 = new UserControl1(); //实例化
        F2 = new UserControl2();
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
    
    private void OutPutForm_Shown(object sender, EventArgs e)
    {
        
        Control.CheckForIllegalCrossThreadCalls = false;
        if (A == 1)
        {
            Process p = new Process();
            System.IO.Directory.SetCurrentDirectory(
                @"C:\Users\User\RiderProjects\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\Sever1");
            p.StartInfo.FileName = "run.bat";
            p.StartInfo.UseShellExecute = false; //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true; //接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true; //由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true; //重定向标准错误输出
            p.StartInfo.CreateNoWindow = true; //不显示程序窗口
            p.StartInfo.StandardErrorEncoding = Encoding.UTF8;
            p.StartInfo.StandardOutputEncoding = Encoding.UTF8; //fix编码问题
            p.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            p.Start(); //启动程序
            p.BeginOutputReadLine();
            //this.button3.Click -= new System.EventHandler(this.OutPutForm_Shown);
        }
        if (A == 2)
        {
            Process p = new Process();
            System.IO.Directory.SetCurrentDirectory(
                @"C:\Users\User\RiderProjects\WinFormsApp1\WinFormsApp1\bin\Debug\net6.0-windows\Sever2");
            p.StartInfo.FileName = "run.bat";
            p.StartInfo.UseShellExecute = false; //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true; //接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true; //由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true; //重定向标准错误输出
            p.StartInfo.CreateNoWindow = true; //不显示程序窗口
            p.StartInfo.StandardErrorEncoding = Encoding.UTF8;
            p.StartInfo.StandardOutputEncoding = Encoding.UTF8; //fix编码问题
            p.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            p.Start(); //启动程序
            p.BeginOutputReadLine();
            //this.button3.Click -= new System.EventHandler(this.OutPutForm_Shown);
        }
    }
    private void OutputHandler(object sendingProcess,DataReceivedEventArgs outLine)
    {
        
        if (!String.IsNullOrEmpty(outLine.Data))
        {
            //StringBuilder sb = new StringBuilder(this.label1.Text); //编码问题
            if (A ==1)
            {
                StringBuilder sb = new StringBuilder(this.label1.Text); //编码问题
                this.label1.Text = sb.AppendLine(outLine.Data).ToString();
            }

            if (A == 2)
            {
                StringBuilder sb = new StringBuilder(F2.label1.Text); //编码问题
                F2.label1.Text = sb.AppendLine(outLine.Data).ToString();
            }
        }
    }

    private void Settings(object sender, EventArgs e)
    {
        MessageBox.Show("敬请期待！","设置",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Hand);
    }

    private void Show1(object sender, EventArgs e)
    {
        A = 1;
        panel1.Controls.Clear(); //清空原容器上的控件
        panel1.Controls.Add(this.label1); //将窗体一加入容器panel2
    }

    private void Show2(object sender, EventArgs e)
    {
        A = 2;
        F2.Show();
        panel1.Controls.Clear(); //清空原容器上的控件
        panel1.Controls.Add(F2); //将窗体一加入容器panel2
    }
}