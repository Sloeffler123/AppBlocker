namespace AppBlockerWinForms;

public partial class Form1 : Form
{
    private int boxCount = 0;
    private int containterCount = 0;
    public Form1()
    {
        InitializeComponent();
    }
    private void AddButton_Click(object sender, EventArgs e)
    {
        
        Panel container = new Panel();
        container.Width = 736;
        container.Height = 169;
        container.Name = $"containter{containterCount++}";
        container.Location = new Point(3, 3);

        // text for the name of the block 
        TextBox newTextBox1 = new TextBox();
        newTextBox1.TextAlign = HorizontalAlignment.Center;
        newTextBox1.Width = 506;
        newTextBox1.Height = 23;
        newTextBox1.Name = $"textbox1_{boxCount++}";
        newTextBox1.Text = "Block Name (Optional)";
        newTextBox1.Location = new Point(107, 3);

        // text for the time frame
        TextBox newTextBox2 = new TextBox();
        newTextBox2.TextAlign = HorizontalAlignment.Center;
        newTextBox2.Width = 506;
        newTextBox2.Height = 23;
        newTextBox2.Name = $"textbox2_{boxCount++}";
        newTextBox2.Text = "0600-1400";
        newTextBox2.Location = new Point(107, 32);

        // text for the days to apply this block to
        TextBox newTextBox3 = new TextBox();
        newTextBox3.TextAlign = HorizontalAlignment.Center;
        newTextBox3.Width = 506;
        newTextBox3.Height = 23;
        newTextBox3.Name = $"textbox2_{boxCount++}";
        newTextBox3.Text = "Days (EX: Monday-Wednesday)";
        newTextBox3.Location = new Point(107, 61);

        // text for the path of app
        TextBox newTextBox4 = new TextBox();
        newTextBox4.Multiline = true;
        newTextBox4.Width = 506;
        newTextBox4.Height = 76;
        newTextBox4.Name = $"textbox3_{boxCount++}";
        newTextBox4.Text = "EX:C:\\Users\\samlo\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Steam.exe";
        newTextBox4.Location = new Point(107, 90);

        // add save button
        Button saveButton = new Button();
        saveButton.Name = "SaveButton";
        saveButton.Text = "Save";
        saveButton.Location = new Point(640, 3);
        saveButton.Width = 75;
        saveButton.Height = 23;

        // edit button
        Button editButton = new Button();
        editButton.Name = "EditButton";
        editButton.Text = "Edit";
        editButton.Location = new Point(640, 32);
        editButton.Width = 75;
        editButton.Height = 23;
        editButton.Visible = false;

        flowLayoutPanel1.Controls.Add(container);

        container.Controls.Add(newTextBox1);
        container.Controls.Add(newTextBox2);
        container.Controls.Add(newTextBox3);
        container.Controls.Add(newTextBox4);
        container.Controls.Add(saveButton);
        container.Controls.Add(editButton);

    }

}
