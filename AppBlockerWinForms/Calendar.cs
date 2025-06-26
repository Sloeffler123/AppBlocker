using AppBlockerWinForms;

namespace AppBlockerCalendarWinForms
{
    public class Calendar
    {
        public static void ShowCalendarElements(Control tableLayout)
        {
            foreach (Control ctrl in tableLayout.Controls)
            {
                MessageBox.Show(ctrl.Text);
                if (ctrl.Text == "Friday")
                {
                    TextBox newText = new();
                    
                }
            }
        }
        public static void ShowCalendarTimesElements(Control tableLayout)
        {
            foreach (Control ctrl in tableLayout.Controls)
            {
                MessageBox.Show(ctrl.Text);
                
            }
        }
    }
}