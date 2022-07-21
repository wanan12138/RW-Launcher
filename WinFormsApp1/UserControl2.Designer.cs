using System.ComponentModel;

namespace WinFormsApp1;

partial class UserControl2
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        //this.label1.Location = new System.Drawing.Point(74, 121);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(700, 520);
        this.label1.TabIndex = 0;
        this.label1.ForeColor = Color.Aqua; //设置字体颜色
        this.label1.BackColor = Color.FromArgb(0,Color.Transparent);
        //this.label1.Text = "芜湖";
        //
        components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Name = "UserControl1";
        this.Size = new System.Drawing.Size(700,520);
        this.BackColor = Color.Transparent;
        this.Controls.Add(this.label1);
        this.ResumeLayout(false);
    }
    public System.Windows.Forms.Label label1;
    #endregion
}