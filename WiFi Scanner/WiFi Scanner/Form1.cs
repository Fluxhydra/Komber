using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SimpleWifi;

// Might need to add WLAN Check for more WiFi functions

namespace WiFi_Scanner
{
    public partial class title : Form
    {
        private static Wifi wifi;
        public title()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            myList.Items.Clear();
            wifi = new Wifi();
            List<AccessPoint> aps = wifi.GetAccessPoints();
            var counter = 1;
            foreach (AccessPoint ap in aps)
            {
                ListViewItem lvItem = new ListViewItem(counter.ToString());
                lvItem.SubItems.Add(ap.Name);
                lvItem.SubItems.Add(ap.SignalStrength + "%");
                myList.Items.Add(lvItem);
                counter++;
            }
        }
    }
}