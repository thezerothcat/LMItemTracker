using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMItemTracker
{
    class SettingsBackup
    {
        int backgroundColor { get; }
        int textColor { get; }
        int formWidth { get; }
        int formHeight { get; }
        bool alwaysOnTop { get; }
        bool showLastItem { get; }
        bool showAmmoCount { get; }
        bool showDeathCount { get; }

        public SettingsBackup()
        {
            backgroundColor = Properties.Settings.Default.BackgroundColor.ToArgb();
            textColor = Properties.Settings.Default.TextColor.ToArgb();
            formWidth = Properties.Settings.Default.FormWidth;
            formHeight = Properties.Settings.Default.FormHeight;
            showLastItem = Properties.Settings.Default.ShowLastItem;
            alwaysOnTop = Properties.Settings.Default.AlwaysOnTop;
            showAmmoCount = Properties.Settings.Default.ShowAmmoCount;
            showDeathCount = Properties.Settings.Default.ShowDeathCount;
        }

        public void RestoreSettings()
        {
            Properties.Settings.Default.BackgroundColor = System.Drawing.Color.FromArgb(backgroundColor);
            Properties.Settings.Default.TextColor = System.Drawing.Color.FromArgb(textColor);
            Properties.Settings.Default.FormWidth = formWidth;
            Properties.Settings.Default.FormHeight = formHeight;
            Properties.Settings.Default.AlwaysOnTop = alwaysOnTop;
            Properties.Settings.Default.ShowLastItem = showLastItem;
            Properties.Settings.Default.ShowAmmoCount = showAmmoCount;
            Properties.Settings.Default.ShowDeathCount = showDeathCount;
        }
    }
}
