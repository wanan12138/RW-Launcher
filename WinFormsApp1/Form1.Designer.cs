using System.Drawing.Configuration;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.button3 = new System.Windows.Forms.Button();
        this.textbox1 = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label(); //暂时不写
        this.panel1 = new System.Windows.Forms.Panel();
        this.button4 = new System.Windows.Forms.Button();
        this.button5 = new System.Windows.Forms.Button();
        this.button6 = new System.Windows.Forms.Button();
         
        //
        // button1 退出按钮
        //
        this.button1.Name = "button1";
        this.button1.Location = new System.Drawing.Point(970,0);
        this.button1.Size = new System.Drawing.Size(30, 30);
        //this.button1.BackgroundImage = Image.FromFile(@"C:\Users\User\Pictures\wuhu.png");
        this.button1.FlatStyle = FlatStyle.Flat; //样式
        this.button1.ForeColor = Color.Transparent;
        this.button1.ForeColor = Color.DarkOrange; //设置字体颜色
        this.button1.BackColor = Color.Transparent;
        this.button1.FlatAppearance.BorderSize = 0; //去边线
        this.button1.FlatAppearance.MouseOverBackColor = Color.Transparent; //鼠标经过
        this.button1.FlatAppearance.MouseDownBackColor = Color.Transparent; //鼠标按下
        this.button1.Text = "X";
        this.button1.TabIndex = 0;
        this.button1.Click += new System.EventHandler(this.Close);
        //
        // button2 最小化
        //
        this.button2.Name = "button2";
        this.button2.Location = new System.Drawing.Point(940,0);
        this.button2.Size = new System.Drawing.Size(30, 30);
        this.button2.Text = "——";
        this.button2.Click += new System.EventHandler(this.Mini); //绑定事件
        this.button2.TabIndex = 1;
        this.button2.FlatStyle = FlatStyle.Flat; //样式
        this.button2.ForeColor = Color.Transparent;
        this.button2.ForeColor = Color.DarkOrange; //设置字体颜色
        this.button2.BackColor = Color.Transparent;
        this.button2.FlatAppearance.BorderSize = 0; //去边线
        this.button2.FlatAppearance.MouseOverBackColor = Color.Transparent; //鼠标经过
        this.button2.FlatAppearance.MouseDownBackColor = Color.Transparent; //鼠标按下
        // 
        // Button3 开服按钮
        //
        this.button3.Name = "button3";
        this.button3.Location = new System.Drawing.Point(20,150);
        this.button3.Size = new System.Drawing.Size(100, 50);
        this.button3.Text = "开服";
        this.button3.Click += new System.EventHandler(this.OutPutForm_Shown); //绑定事件
        
        this.button3.TabIndex = 2;
        this.button3.FlatStyle = FlatStyle.Flat; //样式
        this.button3.ForeColor = Color.DarkOrange; //设置字体颜色
        this.button3.FlatAppearance.BorderSize = 0; //去边线
        this.button3.BackColor = Color.FromArgb(50,Color.Transparent);
        this.button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(50,Color.Transparent); //鼠标经过
        this.button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(50,Color.Transparent); //鼠标按下
        
        //
        // button4 设置
        //
        this.button4.Name = "button4";
        this.button4.Location = new System.Drawing.Point(20,220);
        this.button4.Size = new System.Drawing.Size(100, 50);
        this.button4.Text = "设置";
        this.button4.Click += new System.EventHandler(this.Settings); //绑定事件
        this.button4.TabIndex = 5;
        this.button4.FlatStyle = FlatStyle.Flat; //样式
        this.button4.ForeColor = Color.DarkOrange; //设置字体颜色
        this.button4.FlatAppearance.BorderSize = 0; //去边线
        this.button4.BackColor = Color.FromArgb(50,Color.Transparent);
        this.button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(50,Color.Transparent); //鼠标经过
        this.button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(50,Color.Transparent); //鼠标按下
        //
        // button5 服务器1 
        //
        this.button5.Name = "button5";
        this.button5.Location = new System.Drawing.Point(870,40);
        this.button5.Size = new System.Drawing.Size(100, 50);
        this.button5.Text = "服务器一号";
        this.button5.Click += new System.EventHandler(this.Show1); //绑定事件
        this.button5.TabIndex = 5;
        this.button5.FlatStyle = FlatStyle.Flat; //样式
        this.button5.ForeColor = Color.DarkOrange; //设置字体颜色
        this.button5.FlatAppearance.BorderSize = 0; //去边线
        this.button5.BackColor = Color.FromArgb(50,Color.Transparent);
        this.button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(50,Color.Transparent); //鼠标经过
        this.button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(50,Color.Transparent); //鼠标按下
        //
        // button6 服务器2
        //
        this.button6.Name = "button5";
        this.button6.Location = new System.Drawing.Point(870,100);
        this.button6.Size = new System.Drawing.Size(100, 50);
        this.button6.Text = "服务器二号";
        this.button6.Click += new System.EventHandler(this.Show2); //绑定事件
        this.button6.TabIndex = 5;
        this.button6.FlatStyle = FlatStyle.Flat; //样式
        this.button6.ForeColor = Color.DarkOrange; //设置字体颜色
        this.button6.FlatAppearance.BorderSize = 0; //去边线
        this.button6.BackColor = Color.FromArgb(50,Color.Transparent);
        this.button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(50,Color.Transparent); //鼠标经过
        this.button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(50,Color.Transparent); //鼠标按下
        //
        // panel1
        //
        this.panel1.Name = "panel1";
        this.panel1.Location = new System.Drawing.Point(150,40);
        this.panel1.TabIndex = 6;
        this.panel1.Size = new System.Drawing.Size(700, 520);
        this.panel1.BackColor = Color.FromArgb(50,Color.Transparent);

        //
        // textbox 容器
        //
        //this.textbox1.Location = new System.Drawing.Point(150,560);
        //this.textbox1.TabIndex = 4;
        //this.textbox1.Name = "textbox1";
        //this.textbox1.Size = new System.Drawing.Size(700,560);
        //this.textbox1.BorderStyle = BorderStyle.None;
        
        //this.textbox1
        //this.textbox1.Multiline = false;
        
        //
        // label1 Console控制台
        //
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(700,520);
        //this.label1.Location = new System.Drawing.Point(150, 40);
        this.label1.TabIndex = 4;
        this.label1.FlatStyle = FlatStyle.Flat;
        this.label1.ForeColor = Color.Aqua; //设置字体颜色
        this.label1.BackColor = Color.FromArgb(0,Color.Transparent);
        //this.label1.FlatAppearance.BorderSize = 0; //去边线 Fuck winform
        //this.textbox1.BackColor = Color.FromArgb(50, Color.Transparent); //fuck winform
        //
        // label2 
        //
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(75,80);
        this.label2.Location = new System.Drawing.Point(30, 30);
        this.label2.TabIndex = 5;
        this.label2.FlatStyle = FlatStyle.Flat;
        //this.label1.ForeColor = Color.Azure; //设置字体颜色
        this.label2.BackgroundImage = Image.FromFile(@"C:\Users\User\RiderProjects\WinFormsApp1\WinFormsApp1\UI\beijing.png");
        this.label2.BackgroundImageLayout = ImageLayout.Stretch;
        this.label2.BackColor = Color.FromArgb(0,Color.Transparent);
        //设置窗口大小
        this.ClientSize = new System.Drawing.Size(1000, 618);
        this.Icon = Icon.ExtractAssociatedIcon(@"C:\Users\User\RiderProjects\WinFormsApp1\WinFormsApp1\UI\Icon.ico");//设置图标
        //设置背景图片
        this.BackgroundImage = Image.FromFile(@"C:\Users\User\RiderProjects\WinFormsApp1\WinFormsApp1\UI\backgroud.jpg");
        this.BackgroundImageLayout = ImageLayout.Stretch;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Text = "RW Launcher"; //设置窗口名称
        //设置窗口为无边框
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Controls.Add(this.button1); //添加进窗口
        this.Controls.Add(this.button2); //添加进窗口
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.button5);
        this.Controls.Add(this.button6);
        //this.Controls.Add(this.textbox1); //添加进窗口
        //this.Controls.Add(this.label1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.panel1);
        this.panel1.Controls.Add(this.label1);
        this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);

    }
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    public System.Windows.Forms.Button button3; //open
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.TextBox textbox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel panel1;
    #endregion
}