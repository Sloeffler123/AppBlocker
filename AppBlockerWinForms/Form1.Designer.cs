namespace AppBlockerWinForms;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        Calender = new TabPage();
        Dashboard = new TabPage();
        textBox1 = new TextBox();
        DeleteButton = new Button();
        AddButton = new Button();
        List = new ListView();
        ActiveBlocks = new Label();
        Tabs = new TabControl();
        Help = new TabPage();
        label1 = new Label();
        label2 = new Label();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        Dashboard.SuspendLayout();
        Tabs.SuspendLayout();
        Help.SuspendLayout();
        SuspendLayout();
        // 
        // Calender
        // 
        Calender.Location = new Point(4, 24);
        Calender.Name = "Calender";
        Calender.Size = new Size(636, 376);
        Calender.TabIndex = 2;
        Calender.Text = "Calender";
        Calender.UseVisualStyleBackColor = true;
        // 
        // Dashboard
        // 
        Dashboard.Controls.Add(textBox1);
        Dashboard.Controls.Add(DeleteButton);
        Dashboard.Controls.Add(AddButton);
        Dashboard.Controls.Add(List);
        Dashboard.Controls.Add(ActiveBlocks);
        Dashboard.Location = new Point(4, 24);
        Dashboard.Name = "Dashboard";
        Dashboard.Padding = new Padding(3);
        Dashboard.Size = new Size(636, 376);
        Dashboard.TabIndex = 0;
        Dashboard.Text = "Blocks";
        Dashboard.UseVisualStyleBackColor = true;
        Dashboard.Click += tabPage1_Click;
        // 
        // textBox1
        // 
        textBox1.Enabled = false;
        textBox1.Location = new Point(17, 72);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(493, 23);
        textBox1.TabIndex = 5;
        textBox1.Visible = false;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // DeleteButton
        // 
        DeleteButton.Location = new Point(526, 101);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new Size(75, 23);
        DeleteButton.TabIndex = 4;
        DeleteButton.Text = "Delete";
        DeleteButton.UseVisualStyleBackColor = true;
        DeleteButton.Click += DeleteButton_Click;
        // 
        // AddButton
        // 
        AddButton.Location = new Point(526, 55);
        AddButton.Name = "AddButton";
        AddButton.Size = new Size(75, 23);
        AddButton.TabIndex = 3;
        AddButton.Text = "Add";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButton_Click;
        // 
        // List
        // 
        List.Location = new Point(6, 55);
        List.Name = "List";
        List.Size = new Size(516, 315);
        List.TabIndex = 2;
        List.UseCompatibleStateImageBehavior = false;
        List.SelectedIndexChanged += List_SelectedIndexChanged;
        // 
        // ActiveBlocks
        // 
        ActiveBlocks.AutoSize = true;
        ActiveBlocks.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ActiveBlocks.Location = new Point(151, 12);
        ActiveBlocks.Name = "ActiveBlocks";
        ActiveBlocks.Size = new Size(198, 40);
        ActiveBlocks.TabIndex = 0;
        ActiveBlocks.Text = "Active Blocks";
        // 
        // Tabs
        // 
        Tabs.Controls.Add(Dashboard);
        Tabs.Controls.Add(Calender);
        Tabs.Controls.Add(Help);
        Tabs.Location = new Point(53, 12);
        Tabs.Name = "Tabs";
        Tabs.SelectedIndex = 0;
        Tabs.Size = new Size(644, 404);
        Tabs.TabIndex = 3;
        // 
        // Help
        // 
        Help.Controls.Add(textBox3);
        Help.Controls.Add(textBox2);
        Help.Controls.Add(label2);
        Help.Controls.Add(label1);
        Help.Location = new Point(4, 24);
        Help.Name = "Help";
        Help.Size = new Size(636, 376);
        Help.TabIndex = 3;
        Help.Text = "Help";
        Help.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(17, 13);
        label1.Name = "label1";
        label1.Size = new Size(91, 21);
        label1.TabIndex = 0;
        label1.Text = "How To Use";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(407, 13);
        label2.Name = "label2";
        label2.Size = new Size(145, 21);
        label2.TabIndex = 1;
        label2.Text = "Recommended Use";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(3, 37);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(198, 138);
        textBox2.TabIndex = 2;
        textBox2.Text = resources.GetString("textBox2.Text");
        textBox2.TextChanged += textBox2_TextChanged;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(407, 37);
        textBox3.Multiline = true;
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(212, 306);
        textBox3.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(Tabs);
        Name = "Form1";
        Text = "Form1";
        Dashboard.ResumeLayout(false);
        Dashboard.PerformLayout();
        Tabs.ResumeLayout(false);
        Help.ResumeLayout(false);
        Help.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private TabPage Calender;
    private TabPage Dashboard;
    private TabControl Tabs;
    private Label ActiveBlocks;
    private Button DeleteButton;
    private Button AddButton;
    private ListView List;
    private TextBox textBox1;
    private TabPage Help;
    private TextBox textBox3;
    private TextBox textBox2;
    private Label label2;
    private Label label1;
}
