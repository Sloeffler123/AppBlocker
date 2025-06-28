using AppBlockerWinForms;
using AppBlockerRunApplication;
using static AppBlockerWinForms.Form1;
namespace AppBlockerCalendarWinForms
{
    public class Calendar
    {
        public enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        public static void ShowCalendarElements(Control tableLayout, List<string> days, string times, Control timesTableLayout, string blockName, Panel sundayPanel, Panel mondayPanel, Panel tuesdayPanel, Panel wednesdayPanel, Panel thursdayPanel, Panel fridayPanel, Panel saturdayPanel)
        {
            

            // loop through each day in the table layout
            foreach (Control ctrl in tableLayout.Controls)
            {
          
                // loop through each day that was stated inside the json file
                foreach (var day in days)
                {
                    // if they match go into that column and place a textbox
                    if (day == ctrl.Text)
                    { 
                        (int firstLocationY, int sizeY) location = ShowCalendarTimesElements(timesTableLayout, times);
                        
                        var sizeY = location.sizeY;
                        var firstLocationY = location.firstLocationY;

                        TextBox blockTextBox = new();
                        
                        blockTextBox.Multiline = true;
                        blockTextBox.Text = blockName;
                        blockTextBox.Location = new Point(3, firstLocationY);
                        blockTextBox.Size = new Size(128, sizeY);
                        blockTextBox.Enabled = false;
                        blockTextBox.TextAlign = HorizontalAlignment.Center;
                        var correctPanel = FindCorrectPanel(day, sundayPanel, mondayPanel, tuesdayPanel, wednesdayPanel, thursdayPanel, fridayPanel, saturdayPanel);
                        var panelName = $"{ctrl.Text}Panel";
                        correctPanel.Controls.Add(blockTextBox);
                    }
                }
            }
        }
        // find time the user input and compare it to the table layout panel
        public static Panel FindCorrectPanel(string day, Panel sundayPanel, Panel mondayPanel, Panel tuesdayPanel, Panel wednesdayPanel, Panel thursdayPanel, Panel fridayPanel, Panel saturdayPanel)
        {
            string name = "Panel";
            switch (day)
            {
                case "Sunday":
                    return sundayPanel;

                case "Monday":
                    return mondayPanel;

                case "Tuesday":
                    return tuesdayPanel;

                case "Wednesday":
                    return wednesdayPanel;

                case "Thursday":
                    return thursdayPanel;

                case "Friday":
                    return fridayPanel;

                case "Saturday":
                    return saturdayPanel;

                default:
                    MessageBox.Show("Find correct panel did not work");
                    return sundayPanel;
            }
        }
        public static string[] SplitTimes(string times)
        {
            return times.Split("-");
        }
        public static string[] SplitDays(string days)
        {
            return days.Split("-");
        }

        // loop through the enum and compare the days from split days to fill in the gaps
        public static List<string> LoopThroughEnumToFindMatchingDays(string[] daysSplit)
        {
            bool triggered = false;
            List<string> daysList = new();
            foreach (string days in Enum.GetNames(typeof(Days)))
            {
                
                if (days == daysSplit[0])
                {
                    triggered = true;
                    daysList.Add(days);
                }
                else if (days == daysSplit[1])
                {
                    daysList.Add(days);
                    break;
                }
                else if (triggered)
                {
                    daysList.Add(days);
                }
            }
            return daysList;
        }
        public static (int, int) ShowCalendarTimesElements(Control tableLayout, string times)
        {
            var splitTimes = SplitTimes(times);

            // need to sort the control list here to get correct order
            List<Control> correctOrder = new();
            foreach (Control ctrl in tableLayout.Controls)
            {
                correctOrder.Add(ctrl);
            }
            // sort the correct order
            var sortedList = correctOrder.OrderBy(c => c.Name).ToList();

            int firstYCoord = 0;
            int counter = 0;
            bool triggered = false;

            foreach (var ctrl in sortedList)
            {
                
                if (ctrl.Text == splitTimes[0])
                {
                    triggered = true;
                    counter += 1;
                    firstYCoord = ctrl.Location.Y;
                }
                else if (ctrl.Text == splitTimes[1])
                {
                    counter += 1;
                    break;
                }
                else if (triggered)
                {
                    counter += 1;
                }
            }
            // default size starts at 23
            return (firstYCoord, counter * 30 - 4);
        }
    }
}