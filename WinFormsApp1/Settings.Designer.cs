using System.ComponentModel;

namespace WinFormsApp1;

partial class Settings
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        this.button1 = new System.Windows.Forms.Button();
        
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(700, 520);
        this.BackgroundImage = Image.FromFile(@"C:\Users\User\RiderProjects\WinFormsApp1\WinFormsApp1\UI\qd.jpg");
        this.BackgroundImageLayout = ImageLayout.Stretch;
        this.Text = "设置";
    }
    private Button button1;
    #endregion
}