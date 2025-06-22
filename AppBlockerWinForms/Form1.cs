namespace AppBlockerWinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        textBox1.Visible = true;
        textBox1.ReadOnly = false;
        textBox1.Focus();
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        this.Controls.Remove(textBox1);
        textBox1.Dispose();

    }

    private void List_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBox1.Text))
        {
            textBox1.ReadOnly = true;
        }
    }
    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
// GOAL
// Display the functios of the program (rules)
// Display an option for Files or Directorys for the user to pick (provide clear instructions on the difference maybe add a help button)
// (Maybe provide an option for the user to open file explorer instead of just typing path to app)
// 