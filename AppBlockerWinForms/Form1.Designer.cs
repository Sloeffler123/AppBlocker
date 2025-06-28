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
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        fileSystemWatcher1 = new FileSystemWatcher();
        tabPage1 = new TabPage();
        panel1 = new Panel();
        tableLayoutPanel3 = new TableLayoutPanel();
        textBox11 = new TextBox();
        textBox12 = new TextBox();
        textBox13 = new TextBox();
        textBox14 = new TextBox();
        textBox15 = new TextBox();
        textBox16 = new TextBox();
        textBox17 = new TextBox();
        textBox18 = new TextBox();
        tableLayoutPanel4 = new TableLayoutPanel();
        textBox19 = new TextBox();
        textBox20 = new TextBox();
        textBox21 = new TextBox();
        textBox22 = new TextBox();
        textBox23 = new TextBox();
        textBox24 = new TextBox();
        textBox25 = new TextBox();
        textBox26 = new TextBox();
        textBox27 = new TextBox();
        textBox29 = new TextBox();
        textBox30 = new TextBox();
        textBox31 = new TextBox();
        textBox32 = new TextBox();
        textBox33 = new TextBox();
        textBox34 = new TextBox();
        textBox35 = new TextBox();
        textBox36 = new TextBox();
        textBox37 = new TextBox();
        textBox38 = new TextBox();
        textBox39 = new TextBox();
        textBox40 = new TextBox();
        textBox41 = new TextBox();
        textBox42 = new TextBox();
        textBox43 = new TextBox();
        textBox28 = new TextBox();
        panel2 = new Panel();
        Help = new TabPage();
        textBox3 = new TextBox();
        textBox2 = new TextBox();
        label2 = new Label();
        label1 = new Label();
        Dashboard = new TabPage();
        flowLayoutPanel1 = new FlowLayoutPanel();
        AddButton = new Button();
        ActiveBlocks = new Label();
        Tabs = new TabControl();
        ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
        tabPage1.SuspendLayout();
        panel1.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        Help.SuspendLayout();
        Dashboard.SuspendLayout();
        Tabs.SuspendLayout();
        SuspendLayout();
        // 
        // fileSystemWatcher1
        // 
        fileSystemWatcher1.EnableRaisingEvents = true;
        fileSystemWatcher1.SynchronizingObject = this;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(panel1);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1063, 443);
        tabPage1.TabIndex = 4;
        tabPage1.Text = "Calendar";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.AutoScroll = true;
        panel1.Controls.Add(tableLayoutPanel3);
        panel1.Location = new Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(1056, 401);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.AutoScroll = true;
        tableLayoutPanel3.ColumnCount = 8;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.644471F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.4302549F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.5696955F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.1953573F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2889423F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2404938F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.23209F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.398694F));
        tableLayoutPanel3.Controls.Add(textBox11, 7, 0);
        tableLayoutPanel3.Controls.Add(textBox12, 6, 0);
        tableLayoutPanel3.Controls.Add(textBox13, 5, 0);
        tableLayoutPanel3.Controls.Add(textBox14, 4, 0);
        tableLayoutPanel3.Controls.Add(textBox15, 3, 0);
        tableLayoutPanel3.Controls.Add(textBox16, 2, 0);
        tableLayoutPanel3.Controls.Add(textBox17, 1, 0);
        tableLayoutPanel3.Controls.Add(textBox18, 0, 0);
        tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
        tableLayoutPanel3.Controls.Add(panel2, 1, 1);
        tableLayoutPanel3.Location = new Point(4, -3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 3.44387746F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 96.55612F));
        tableLayoutPanel3.Size = new Size(1049, 784);
        tableLayoutPanel3.TabIndex = 1;
        // 
        // textBox11
        // 
        textBox11.Enabled = false;
        textBox11.Location = new Point(907, 3);
        textBox11.Multiline = true;
        textBox11.Name = "textBox11";
        textBox11.Size = new Size(139, 21);
        textBox11.TabIndex = 6;
        textBox11.Text = "Saturday";
        textBox11.TextAlign = HorizontalAlignment.Center;
        // 
        // textBox12
        // 
        textBox12.Enabled = false;
        textBox12.Location = new Point(769, 3);
        textBox12.Multiline = true;
        textBox12.Name = "textBox12";
        textBox12.Size = new Size(132, 21);
        textBox12.TabIndex = 5;
        textBox12.Text = "Friday";
        textBox12.TextAlign = HorizontalAlignment.Center;
        // 
        // textBox13
        // 
        textBox13.Enabled = false;
        textBox13.Location = new Point(631, 3);
        textBox13.Multiline = true;
        textBox13.Name = "textBox13";
        textBox13.Size = new Size(132, 21);
        textBox13.TabIndex = 4;
        textBox13.Text = "Thursday";
        textBox13.TextAlign = HorizontalAlignment.Center;
        // 
        // textBox14
        // 
        textBox14.Enabled = false;
        textBox14.Location = new Point(492, 3);
        textBox14.Multiline = true;
        textBox14.Name = "textBox14";
        textBox14.Size = new Size(133, 21);
        textBox14.TabIndex = 3;
        textBox14.Text = "Wednesday";
        textBox14.TextAlign = HorizontalAlignment.Center;
        // 
        // textBox15
        // 
        textBox15.Enabled = false;
        textBox15.Location = new Point(354, 3);
        textBox15.Multiline = true;
        textBox15.Name = "textBox15";
        textBox15.Size = new Size(132, 21);
        textBox15.TabIndex = 2;
        textBox15.Text = "Tuesday";
        textBox15.TextAlign = HorizontalAlignment.Center;
        // 
        // textBox16
        // 
        textBox16.Enabled = false;
        textBox16.Location = new Point(212, 3);
        textBox16.Multiline = true;
        textBox16.Name = "textBox16";
        textBox16.Size = new Size(135, 21);
        textBox16.TabIndex = 1;
        textBox16.Text = "Monday";
        textBox16.TextAlign = HorizontalAlignment.Center;
        // 
        // textBox17
        // 
        textBox17.Enabled = false;
        textBox17.Location = new Point(72, 3);
        textBox17.Multiline = true;
        textBox17.Name = "textBox17";
        textBox17.Size = new Size(134, 21);
        textBox17.TabIndex = 0;
        textBox17.Text = "Sunday";
        textBox17.TextAlign = HorizontalAlignment.Center;
        // 
        // textBox18
        // 
        textBox18.Enabled = false;
        textBox18.Location = new Point(3, 3);
        textBox18.Multiline = true;
        textBox18.Name = "textBox18";
        textBox18.Size = new Size(63, 21);
        textBox18.TabIndex = 7;
        textBox18.Text = "Times";
        textBox18.TextAlign = HorizontalAlignment.Center;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.AutoScroll = true;
        tableLayoutPanel4.ColumnCount = 1;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel4.Controls.Add(textBox19, 0, 0);
        tableLayoutPanel4.Controls.Add(textBox20, 0, 1);
        tableLayoutPanel4.Controls.Add(textBox21, 0, 2);
        tableLayoutPanel4.Controls.Add(textBox22, 0, 3);
        tableLayoutPanel4.Controls.Add(textBox23, 0, 4);
        tableLayoutPanel4.Controls.Add(textBox24, 0, 5);
        tableLayoutPanel4.Controls.Add(textBox25, 0, 6);
        tableLayoutPanel4.Controls.Add(textBox26, 0, 7);
        tableLayoutPanel4.Controls.Add(textBox27, 0, 8);
        tableLayoutPanel4.Controls.Add(textBox29, 0, 10);
        tableLayoutPanel4.Controls.Add(textBox30, 0, 11);
        tableLayoutPanel4.Controls.Add(textBox31, 0, 12);
        tableLayoutPanel4.Controls.Add(textBox32, 0, 13);
        tableLayoutPanel4.Controls.Add(textBox33, 0, 14);
        tableLayoutPanel4.Controls.Add(textBox34, 0, 15);
        tableLayoutPanel4.Controls.Add(textBox35, 0, 16);
        tableLayoutPanel4.Controls.Add(textBox36, 0, 17);
        tableLayoutPanel4.Controls.Add(textBox37, 0, 18);
        tableLayoutPanel4.Controls.Add(textBox38, 0, 19);
        tableLayoutPanel4.Controls.Add(textBox39, 0, 20);
        tableLayoutPanel4.Controls.Add(textBox40, 0, 21);
        tableLayoutPanel4.Controls.Add(textBox41, 0, 22);
        tableLayoutPanel4.Controls.Add(textBox42, 0, 23);
        tableLayoutPanel4.Controls.Add(textBox43, 0, 24);
        tableLayoutPanel4.Controls.Add(textBox28, 0, 9);
        tableLayoutPanel4.Location = new Point(3, 30);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 25;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.02144766F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.02144766F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.155496F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.155496F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.289544F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.289544F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.155496F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.02144766F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 3.88739944F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.02144766F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.155496F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.02144766F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 3.88739944F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.155496F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.155496F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 3.88739944F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.02144766F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 3.75335121F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 3.75335121F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 3.75335121F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 3.75335121F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 4.289544F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 3.88739944F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 3.75335121F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 2.81501341F));
        tableLayoutPanel4.Size = new Size(63, 746);
        tableLayoutPanel4.TabIndex = 8;
        // 
        // textBox19
        // 
        textBox19.Enabled = false;
        textBox19.Location = new Point(3, 3);
        textBox19.Name = "textBox19";
        textBox19.Size = new Size(57, 23);
        textBox19.TabIndex = 0;
        textBox19.Text = "00:00";
        // 
        // textBox20
        // 
        textBox20.Enabled = false;
        textBox20.Location = new Point(3, 33);
        textBox20.Name = "textBox20";
        textBox20.Size = new Size(57, 23);
        textBox20.TabIndex = 1;
        textBox20.Text = "01:00";
        // 
        // textBox21
        // 
        textBox21.Enabled = false;
        textBox21.Location = new Point(3, 63);
        textBox21.Name = "textBox21";
        textBox21.Size = new Size(57, 23);
        textBox21.TabIndex = 2;
        textBox21.Text = "02:00";
        // 
        // textBox22
        // 
        textBox22.Enabled = false;
        textBox22.Location = new Point(3, 94);
        textBox22.Name = "textBox22";
        textBox22.Size = new Size(57, 23);
        textBox22.TabIndex = 3;
        textBox22.Text = "03:00";
        // 
        // textBox23
        // 
        textBox23.Enabled = false;
        textBox23.Location = new Point(3, 125);
        textBox23.Name = "textBox23";
        textBox23.Size = new Size(57, 23);
        textBox23.TabIndex = 4;
        textBox23.Text = "04:00";
        // 
        // textBox24
        // 
        textBox24.Enabled = false;
        textBox24.Location = new Point(3, 157);
        textBox24.Name = "textBox24";
        textBox24.Size = new Size(57, 23);
        textBox24.TabIndex = 5;
        textBox24.Text = "05:00";
        // 
        // textBox25
        // 
        textBox25.Enabled = false;
        textBox25.Location = new Point(3, 189);
        textBox25.Name = "textBox25";
        textBox25.Size = new Size(57, 23);
        textBox25.TabIndex = 6;
        textBox25.Text = "06:00";
        // 
        // textBox26
        // 
        textBox26.Enabled = false;
        textBox26.Location = new Point(3, 220);
        textBox26.Name = "textBox26";
        textBox26.Size = new Size(57, 23);
        textBox26.TabIndex = 7;
        textBox26.Text = "07:00";
        // 
        // textBox27
        // 
        textBox27.Enabled = false;
        textBox27.Location = new Point(3, 250);
        textBox27.Name = "textBox27";
        textBox27.Size = new Size(57, 23);
        textBox27.TabIndex = 8;
        textBox27.Text = "08:00";
        // 
        // textBox29
        // 
        textBox29.Enabled = false;
        textBox29.Location = new Point(3, 309);
        textBox29.Name = "textBox29";
        textBox29.Size = new Size(57, 23);
        textBox29.TabIndex = 10;
        textBox29.Text = "10:00";
        // 
        // textBox30
        // 
        textBox30.Enabled = false;
        textBox30.Location = new Point(3, 340);
        textBox30.Name = "textBox30";
        textBox30.Size = new Size(57, 23);
        textBox30.TabIndex = 11;
        textBox30.Text = "11:00";
        // 
        // textBox31
        // 
        textBox31.Enabled = false;
        textBox31.Location = new Point(3, 370);
        textBox31.Name = "textBox31";
        textBox31.Size = new Size(57, 23);
        textBox31.TabIndex = 12;
        textBox31.Text = "12:00";
        // 
        // textBox32
        // 
        textBox32.Enabled = false;
        textBox32.Location = new Point(3, 399);
        textBox32.Name = "textBox32";
        textBox32.Size = new Size(57, 23);
        textBox32.TabIndex = 13;
        textBox32.Text = "13:00";
        // 
        // textBox33
        // 
        textBox33.Enabled = false;
        textBox33.Location = new Point(3, 430);
        textBox33.Name = "textBox33";
        textBox33.Size = new Size(57, 23);
        textBox33.TabIndex = 14;
        textBox33.Text = "14:00";
        // 
        // textBox34
        // 
        textBox34.Enabled = false;
        textBox34.Location = new Point(3, 461);
        textBox34.Name = "textBox34";
        textBox34.Size = new Size(57, 23);
        textBox34.TabIndex = 15;
        textBox34.Text = "15:00";
        // 
        // textBox35
        // 
        textBox35.Enabled = false;
        textBox35.Location = new Point(3, 490);
        textBox35.Name = "textBox35";
        textBox35.Size = new Size(57, 23);
        textBox35.TabIndex = 16;
        textBox35.Text = "16:00";
        // 
        // textBox36
        // 
        textBox36.Enabled = false;
        textBox36.Location = new Point(3, 520);
        textBox36.Name = "textBox36";
        textBox36.Size = new Size(57, 23);
        textBox36.TabIndex = 17;
        textBox36.Text = "17:00";
        // 
        // textBox37
        // 
        textBox37.Enabled = false;
        textBox37.Location = new Point(3, 548);
        textBox37.Name = "textBox37";
        textBox37.Size = new Size(57, 23);
        textBox37.TabIndex = 18;
        textBox37.Text = "18:00";
        // 
        // textBox38
        // 
        textBox38.Enabled = false;
        textBox38.Location = new Point(3, 576);
        textBox38.Name = "textBox38";
        textBox38.Size = new Size(57, 23);
        textBox38.TabIndex = 19;
        textBox38.Text = "19:00";
        // 
        // textBox39
        // 
        textBox39.Enabled = false;
        textBox39.Location = new Point(3, 604);
        textBox39.Name = "textBox39";
        textBox39.Size = new Size(57, 23);
        textBox39.TabIndex = 20;
        textBox39.Text = "20:00";
        // 
        // textBox40
        // 
        textBox40.Enabled = false;
        textBox40.Location = new Point(3, 632);
        textBox40.Name = "textBox40";
        textBox40.Size = new Size(57, 23);
        textBox40.TabIndex = 21;
        textBox40.Text = "21:00";
        // 
        // textBox41
        // 
        textBox41.Enabled = false;
        textBox41.Location = new Point(3, 664);
        textBox41.Name = "textBox41";
        textBox41.Size = new Size(57, 23);
        textBox41.TabIndex = 22;
        textBox41.Text = "22:00";
        // 
        // textBox42
        // 
        textBox42.Enabled = false;
        textBox42.Location = new Point(3, 693);
        textBox42.Name = "textBox42";
        textBox42.Size = new Size(57, 23);
        textBox42.TabIndex = 23;
        textBox42.Text = "23:00";
        // 
        // textBox43
        // 
        textBox43.Enabled = false;
        textBox43.Location = new Point(3, 721);
        textBox43.Name = "textBox43";
        textBox43.Size = new Size(57, 23);
        textBox43.TabIndex = 24;
        textBox43.Text = "24:00";
        // 
        // textBox28
        // 
        textBox28.Enabled = false;
        textBox28.Location = new Point(3, 279);
        textBox28.Name = "textBox28";
        textBox28.Size = new Size(57, 23);
        textBox28.TabIndex = 9;
        textBox28.Text = "09:00";
        // 
        // panel2
        // 
        panel2.Location = new Point(72, 30);
        panel2.Name = "panel2";
        panel2.Size = new Size(134, 746);
        panel2.TabIndex = 9;
        // 
        // Help
        // 
        Help.Controls.Add(textBox3);
        Help.Controls.Add(textBox2);
        Help.Controls.Add(label2);
        Help.Controls.Add(label1);
        Help.Location = new Point(4, 24);
        Help.Name = "Help";
        Help.Size = new Size(1063, 443);
        Help.TabIndex = 3;
        Help.Text = "Help";
        Help.UseVisualStyleBackColor = true;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(407, 37);
        textBox3.Multiline = true;
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(212, 306);
        textBox3.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(3, 37);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(198, 138);
        textBox2.TabIndex = 2;
        textBox2.Text = resources.GetString("textBox2.Text");
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
        // Dashboard
        // 
        Dashboard.Controls.Add(flowLayoutPanel1);
        Dashboard.Controls.Add(AddButton);
        Dashboard.Controls.Add(ActiveBlocks);
        Dashboard.Location = new Point(4, 24);
        Dashboard.Name = "Dashboard";
        Dashboard.Padding = new Padding(3);
        Dashboard.Size = new Size(1063, 443);
        Dashboard.TabIndex = 0;
        Dashboard.Text = "Blocks";
        Dashboard.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel1.Location = new Point(6, 55);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(739, 382);
        flowLayoutPanel1.TabIndex = 5;
        flowLayoutPanel1.WrapContents = false;
        // 
        // AddButton
        // 
        AddButton.Location = new Point(751, 55);
        AddButton.Name = "AddButton";
        AddButton.Size = new Size(75, 23);
        AddButton.TabIndex = 3;
        AddButton.Text = "Add";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButton_Click;
        // 
        // ActiveBlocks
        // 
        ActiveBlocks.AutoSize = true;
        ActiveBlocks.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ActiveBlocks.Location = new Point(267, 12);
        ActiveBlocks.Name = "ActiveBlocks";
        ActiveBlocks.Size = new Size(198, 40);
        ActiveBlocks.TabIndex = 0;
        ActiveBlocks.Text = "Active Blocks";
        // 
        // Tabs
        // 
        Tabs.Controls.Add(Dashboard);
        Tabs.Controls.Add(Help);
        Tabs.Controls.Add(tabPage1);
        Tabs.Location = new Point(92, 12);
        Tabs.Name = "Tabs";
        Tabs.SelectedIndex = 0;
        Tabs.Size = new Size(1071, 471);
        Tabs.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1163, 591);
        Controls.Add(Tabs);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
        tabPage1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel3.PerformLayout();
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        Help.ResumeLayout(false);
        Help.PerformLayout();
        Dashboard.ResumeLayout(false);
        Dashboard.PerformLayout();
        Tabs.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private FileSystemWatcher fileSystemWatcher1;
    private TabControl Tabs;
    private TabPage Dashboard;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button AddButton;
    private Label ActiveBlocks;
    private TabPage Help;
    private TextBox textBox3;
    private TextBox textBox2;
    private Label label2;
    private Label label1;
    private TabPage tabPage1;
    private Panel panel1;
    private TableLayoutPanel tableLayoutPanel3;
    private TextBox textBox11;
    private TextBox textBox12;
    private TextBox textBox13;
    private TextBox textBox14;
    private TextBox textBox15;
    private TextBox textBox16;
    private TextBox textBox17;
    private TextBox textBox18;
    private TableLayoutPanel tableLayoutPanel4;
    private TextBox textBox19;
    private TextBox textBox20;
    private TextBox textBox21;
    private TextBox textBox22;
    private TextBox textBox23;
    private TextBox textBox24;
    private TextBox textBox25;
    private TextBox textBox26;
    private TextBox textBox27;
    private TextBox textBox29;
    private TextBox textBox30;
    private TextBox textBox31;
    private TextBox textBox32;
    private TextBox textBox33;
    private TextBox textBox34;
    private TextBox textBox35;
    private TextBox textBox36;
    private TextBox textBox37;
    private TextBox textBox38;
    private TextBox textBox39;
    private TextBox textBox40;
    private TextBox textBox41;
    private TextBox textBox42;
    private TextBox textBox28;
    private TextBox textBox43;
    private Panel panel2;
}
