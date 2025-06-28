using AppBlockerAddFilesToList;
using System.Diagnostics;
using System.Text.Json;
using AppBlockerCalendarWinForms;
using AppBlockerRunApplication;
using static AppBlockerWinForms.Form1;

namespace AppBlockerWinForms;

public partial class Form1 : Form
{
    private int boxCount = 0;
    private int containterCount = 0;
    private int userID = 0;
    public Form1()
    {
        InitializeComponent();
    }
    public class UserData
    {
        public string Blockset { get; set; }
        public string Time { get; set; }
        public string Days { get; set; }
        public string[] Paths { get; set; }
    }
    private void AddButton_Click(object sender, EventArgs e)
    {
        // if containter not filled out and is greater than 1 pass
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
        newTextBox2.Text = "06:00-14:00";
        newTextBox2.Location = new Point(107, 32);

        // text for the days to apply this block to
        TextBox newTextBox3 = new TextBox();
        newTextBox3.TextAlign = HorizontalAlignment.Center;
        newTextBox3.Width = 506;
        newTextBox3.Height = 23;
        newTextBox3.Name = $"textbox3_{boxCount++}";
        newTextBox3.Text = "Monday-Wednesday";
        newTextBox3.Location = new Point(107, 61);

        // text for the path of app
        TextBox newTextBox4 = new TextBox();
        newTextBox4.Multiline = true;
        newTextBox4.Width = 506;
        newTextBox4.Height = 76;
        newTextBox4.Name = $"textbox4_{boxCount++}";
        newTextBox4.Text = "EX:C:\\Users\\samlo\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Steam.exe";
        newTextBox4.Location = new Point(107, 90);

        // add save button
        Button saveButton = new Button();
        saveButton.Name = "SaveButton";
        saveButton.Text = "Save";
        saveButton.Location = new Point(640, 3);
        saveButton.Width = 75;
        saveButton.Height = 23;
        saveButton.Click += SaveButton_Clicked;

        // edit button
        Button editButton = new Button();
        editButton.Name = "EditButton";
        editButton.Text = "Edit";
        editButton.Location = new Point(640, 32);
        editButton.Width = 75;
        editButton.Height = 23;
        editButton.Visible = false;
        editButton.Click += EditButton_Clicked;

        flowLayoutPanel1.Controls.Add(container);

        container.Controls.Add(newTextBox1);
        container.Controls.Add(newTextBox2);
        container.Controls.Add(newTextBox3);
        container.Controls.Add(newTextBox4);
        container.Controls.Add(saveButton);
        container.Controls.Add(editButton);

        var userData = new UserData
        {
            Blockset = newTextBox1.Text,
            Time = newTextBox2.Text,
            Days = newTextBox3.Text,
            Paths = null,
        };
        container.Tag = userData;
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        Button saveButton = sender as Button;

        if (saveButton == null)
        {
            return;
        }
        Panel container = saveButton.Parent as Panel;

        if (container == null)
        {
            return;
        }
        UserData userData = container.Tag as UserData;
        List<TextBox> textBoxes = new();
        foreach (Control ctrl in container.Controls)
        {
            if (ctrl is TextBox tb && tb.Text.Length > 0)
            {
                HandleTextBox(tb, userData, textBoxes);
            }
            else if (ctrl is Button btn && btn.Name == "EditButton")
            {
                btn.Visible = true;
            }
        }
        var execute = MakeJsonFile(userData, textBoxes);
        // write info to calendar tab
        if (execute)
        {
            SaveCalendarTab();
        }
    }
    private void HandleTextBox(TextBox tb, UserData userData, List<TextBox> textBoxesList)
    {
        bool isValid = false;

        if (tb.Name.StartsWith("textbox1_"))
        {
            userData.Blockset = tb.Text.Trim();
            isValid = true;
        }
        else if (tb.Name.StartsWith("textbox2_"))
        {
            isValid = Files.CheckIfTimeFrameValid(tb.Text);
            if (isValid)
            {
                userData.Time = tb.Text.Trim();
            }
            else
            {
                MessageBox.Show("Not correct format (EX: 06:00-14:00)");
            }
        }
        else if (tb.Name.StartsWith("textbox3_"))
        {
            isValid = Files.CheckCorrectDaysFormat(tb.Text);
            if (isValid)
            {
                userData.Days = tb.Text.Trim();
            }
            else
            {
                MessageBox.Show("Not correct format");
            }
        }
        else if (tb.Name.StartsWith("textbox4_"))
        {
            isValid = Files.CheckIfFileOrDirectory(tb.Text.Split());
            if (isValid)
            {
                var newUserData = tb.Text.Split();
                userData.Paths = newUserData;
            }
            else
            {
                MessageBox.Show("Not a valid path");
            }
        }
        if (isValid)
        {
            tb.Enabled = false;
            textBoxesList.Add(tb);
        }
    }
    public string GetJsonFileName()
    {
        return $"user{userID}_data.json";
    }
    public string IncreaseUserID()
    {
        return $"user{userID += 1}_data.json";
    }
    private bool MakeJsonFile(UserData data, List<TextBox> textsList)
    {
        if (CheckIfTextIsEmpty(textsList))
        {
            string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            MessageBox.Show(jsonString, "Data");
            string fileName = IncreaseUserID();
            File.WriteAllText(fileName, jsonString);
            return true;
        }
        return false;
    }
    private bool CheckIfTextIsEmpty(List<TextBox> textBoxesList)
    {
        int count = 0;
        foreach (var textBox in textBoxesList)
        {
            if (textBox.Text.Length != 0 && textBoxesList.Count == 4)
            {
                count += 1;
            }
        }
        return count == 4;
    }
    private void EditButton_Clicked(object sender, EventArgs args)
    {
        Button editButton = sender as Button;

        if (editButton == null)
        {
            return;
        }
        Panel container = editButton.Parent as Panel;

        if (container == null)
        {
            return;
        }
        foreach (Control ctrl in container.Controls)
        {
            if (ctrl is TextBox tb)
            {
                tb.Enabled = true;
            }
            else if (ctrl is Button btn)
            {
                if (btn.Name == "EditButton")
                {
                    btn.Visible = false;
                }
            }
        }
    }

    // use json methods from runapplication
    
    private void SaveCalendarTab()
    {
        // get json time and days
        // compare them to the table layout to find out where the block should go
        // first find the days
        // then find the times
        var jsonFileName = GetJsonFileName();
        using var doc = RunApplication.LoadJson(jsonFileName);
        var root = doc.RootElement;
        var time = RunApplication.GetJsonTimeProperty(root);
        var days = RunApplication.GetJsonDaysProperty(root);
        var blockName = RunApplication.GetJsonBlockNameProperty(root);

        // days list 
        List<string> daysList = Calendar.LoopThroughEnumToFindMatchingDays(Calendar.SplitDays(days));

        Calendar.ShowCalendarElements(tableLayoutPanel3, daysList, time, tableLayoutPanel4, blockName, SundayPanel, MondayPanel, TuesdayPanel, WednesdayPanel, ThursdayPanel, FridayPanel, SaturdayPanel);
    }

    // show calendar elements
    private void button1_Click(object sender, EventArgs e)
    {
        

    }
    // show times table elements
    private void button2_Click(object sender, EventArgs e)
    {
        Calendar.ShowCalendarTimesElements(tableLayoutPanel4, "wednesday-");
    }
}
