using System;
using System.Globalization;
using System.Windows.Forms;
using EVEMon.Common;
using EVEMon.Common.Schedule;

namespace EVEMon.Schedule
{
    public partial class ScheduleEditorWindow : EVEMonForm
    {
        public ScheduleEditorWindow()
        {
            InitializeComponent();
        }

        public ScheduleEditorWindow(Settings s)
            : this()
        {
            m_settings = s;
            foreach(ScheduleEntry temp in m_settings.Schedule)
            {
                lbEntries.Items.Add(temp.Title);
            }
        }

        private Settings m_settings;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (EditScheduleEntryWindow f = new EditScheduleEntryWindow())
            {
                DialogResult dr = f.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                m_settings.Schedule.Add(f.ScheduleEntry);
                lbEntries.Items.Add(f.ScheduleEntry.Title);
                m_settings.Save();
            }
        }

        private DateTime currentdate = DateTime.Now;

        private void ScheduleEditorWindow_Load(object sender, EventArgs e)
        {
            nudMonth.Items.Clear();
            string[] monthNames = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            nudMonth.Items.Add(monthNames[0]);
            for (int i = 1; i <= CultureInfo.CurrentCulture.Calendar.GetMonthsInYear(currentdate.Year); i++)
            {
                nudMonth.Items.Add(
                    monthNames[((CultureInfo.CurrentCulture.Calendar.GetMonthsInYear(currentdate.Year)) - i)]);
            }
            nudMonth.Items.Add(monthNames[CultureInfo.CurrentCulture.Calendar.GetMonthsInYear(currentdate.Year) - 1]);
            nudYear.Value = currentdate.Year;
            nudMonth.SelectedIndex = ((nudMonth.Items.Count - 1) - currentdate.Month);
            nudDay.Maximum = CultureInfo.CurrentCulture.Calendar.GetDaysInMonth(currentdate.Year, currentdate.Month) + 1;
            nudDay.Value = currentdate.Day;
            calControl.Date = currentdate;
        }

        private void changedYear(object sender, EventArgs e)
        {
            int oldyearnum = currentdate.Year;
            currentdate = currentdate.AddYears((int) nudYear.Value - currentdate.Year);
            if (currentdate.Month == 2 &&
                (CultureInfo.CurrentCulture.Calendar.IsLeapYear(currentdate.Year) ||
                 CultureInfo.CurrentCulture.Calendar.IsLeapYear(oldyearnum)))
            {
                nudDay.Maximum =
                    CultureInfo.CurrentCulture.Calendar.GetDaysInMonth(currentdate.Year, currentdate.Month) + 1;
                if (CultureInfo.CurrentCulture.Calendar.IsLeapYear(oldyearnum) && nudDay.Value > nudDay.Maximum)
                {
                    nudDay.Value = nudDay.Maximum;
                }
            }
            calControl.Date = currentdate;
        }

        private void changedDay(object sender, EventArgs e)
        {
            bool donex = false;
            bool doney = false;
            if (nudDay.Value == 0)
            {
                if (nudMonth.SelectedIndex == (nudMonth.Items.Count - 2) && nudYear.Value == nudYear.Minimum)
                {
                    nudDay.Value = 1;
                }
                currentdate = currentdate.AddDays((int) nudDay.Value - currentdate.Day);
                nudDay.Maximum =
                    CultureInfo.CurrentCulture.Calendar.GetDaysInMonth(currentdate.Year, currentdate.Month) + 1;
                if (nudDay.Value == 0)
                {
                    nudDay.Value =
                        CultureInfo.CurrentCulture.Calendar.GetDaysInMonth(currentdate.Year, currentdate.Month);
                }
                donex = true;
            }
            else if (!donex && nudDay.Value == nudDay.Maximum)
            {
                if (nudMonth.SelectedIndex == 1 && nudYear.Value == nudYear.Maximum)
                {
                    nudDay.Value =
                        CultureInfo.CurrentCulture.Calendar.GetDaysInMonth(currentdate.Year, currentdate.Month);
                    doney = true;
                }
                else if (!doney)
                {
                    currentdate = currentdate.AddDays((int) nudDay.Value - currentdate.Day);
                    nudDay.Value = 1;
                    nudDay.Maximum =
                        CultureInfo.CurrentCulture.Calendar.GetDaysInMonth(currentdate.Year, currentdate.Month) + 1;
                }
                donex = true;
            }
            else if (!donex)
            {
                currentdate = currentdate.AddDays((int) nudDay.Value - currentdate.Day);
            }
            calControl.Date = currentdate;
            nudYear.Value = currentdate.Year;
            nudMonth.SelectedIndex = (CultureInfo.CurrentCulture.Calendar.GetMonthsInYear(currentdate.Year) -
                                      currentdate.Month) + 1;
        }

        private void changedMonth(object sender, EventArgs e)
        {
            if (nudMonth.SelectedIndex == nudMonth.Items.Count - 1 && nudYear.Value == nudYear.Minimum)
            {
                nudMonth.SelectedIndex = nudMonth.Items.Count - 2;
            }
            if (nudMonth.SelectedIndex == 0 && nudYear.Value == nudYear.Maximum)
            {
                nudMonth.SelectedIndex = 1;
            }
            currentdate =
                currentdate.AddMonths((((nudMonth.Items.Count - 1) - nudMonth.SelectedIndex) - currentdate.Month));
            nudMonth.SelectedIndex = ((nudMonth.SelectedIndex + (nudMonth.Items.Count - 3))%(nudMonth.Items.Count - 2)) +
                                     1;
            if (nudDay.Value > CultureInfo.CurrentCulture.Calendar.GetDaysInMonth(currentdate.Year, currentdate.Month))
            {
                nudDay.Value = CultureInfo.CurrentCulture.Calendar.GetDaysInMonth(currentdate.Year, currentdate.Month);
            }
            nudDay.Maximum = CultureInfo.CurrentCulture.Calendar.GetDaysInMonth(currentdate.Year, currentdate.Month) + 1;
            calControl.Date = currentdate;
            nudYear.Value = currentdate.Year;
        }

        private void tsbDeleteEntry_Click(object sender, EventArgs e)
        {
            if (lbEntries.SelectedIndex != -1)
            {
                int i = -1;
                for (int x = 0; x < m_settings.Schedule.Count && i == -1; x++)
                {
                    if (m_settings.Schedule[x].Title == lbEntries.Items[lbEntries.SelectedIndex].ToString())
                    {
                        i = x;
                    }
                }
                lbEntries.Items.RemoveAt(lbEntries.SelectedIndex);
                m_settings.Schedule.RemoveAt(i);
                m_settings.Save();
            }
        }

        private void lbEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEntries.SelectedIndex != -1)
            {
                ScheduleEntry temp = m_settings.Schedule[lbEntries.SelectedIndex];
                string label_text = "Title: " + temp.Title;
                if (temp.GetType() == typeof(SimpleScheduleEntry))
                {
                    SimpleScheduleEntry x = (SimpleScheduleEntry)temp;
                    label_text = label_text + "\nOne Off Entry\n Start: " + x.StartDateTime + "\n End: " + x.EndDateTime + "\n Expired: " + x.Expired;
                    label_text += "\n\n Options\n  Blocking: " + ((x.ScheduleEntryOptions & ScheduleEntryOptions.Blocking) != 0);
                    label_text += "\n  Silent: " + ((x.ScheduleEntryOptions & ScheduleEntryOptions.Quiet) != 0);
                    label_text += "\n  Uses Eve Time: " + ((x.ScheduleEntryOptions & ScheduleEntryOptions.EVETime) != 0);
                }
                else if (temp.GetType() == typeof(RecurringScheduleEntry))
                {
                    RecurringScheduleEntry x = (RecurringScheduleEntry)temp;
                    label_text = label_text + "\nRecurring Entry:\n Start: " + x.RecurStart + "\n End: " + x.RecurEnd + "\n Frequency: " + x.RecurFrequency;
                    if (x.RecurFrequency == RecurFrequency.Monthly)
                    {
                        label_text = label_text + "\n Day of Month: " + x.RecurDayOfMonth + "\n On Overflow: " + x.OverflowResolution;
                    }
                    else if (x.RecurFrequency == RecurFrequency.Weekly)
                    {
                        label_text = label_text + "\n Day of Week: " + x.RecurDayOfWeek;
                    }
                    label_text = label_text + "\n Start Time: " + TimeSpan.FromSeconds(x.StartSecond).ToString() + "\n End Time: " + TimeSpan.FromSeconds(x.EndSecond).ToString() + "\n Expired: " + x.Expired;
                    label_text += "\n\n Options\n  Blocking: " + ((x.ScheduleEntryOptions & ScheduleEntryOptions.Blocking) != 0);
                    label_text += "\n  Silent: " + ((x.ScheduleEntryOptions & ScheduleEntryOptions.Quiet) != 0);
                    label_text += "\n  Uses Eve Time: " + ((x.ScheduleEntryOptions & ScheduleEntryOptions.EVETime) != 0);
                }
                else
                {
                    // ?? Wha...
                    label_text = "What the Smeg is this?";
                }
                lblEntryDescription.Text = label_text;
            }
            else
            {
                lblEntryDescription.Text = "";
            }
        }

        private void lbEntries_DoubleClick(object sender, EventArgs e)
        {
            if (lbEntries.SelectedIndex != -1)
            {
                ScheduleEntry temp = m_settings.Schedule[lbEntries.SelectedIndex];
                using (EditScheduleEntryWindow f = new EditScheduleEntryWindow())
                {
                    f.ScheduleEntry = temp;
                    DialogResult dr = f.ShowDialog();
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    // need to put something in here to test to see if the item has actually been changed, and if not, simply return
                    int i = -1;
                    for (int x = 0; x < m_settings.Schedule.Count && i == -1; x++)
                    {
                        if (m_settings.Schedule[x].Equals(temp))
                        {
                            i = x;
                        }
                    }
                    lbEntries.Items.RemoveAt(lbEntries.SelectedIndex);
                    m_settings.Schedule.RemoveAt(i);
                    m_settings.Schedule.Add(f.ScheduleEntry);
                    lbEntries.Items.Add(f.ScheduleEntry.Title);
                    m_settings.Save();
                }
            }
        }
    }
}
