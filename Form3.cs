using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace CS18_Troll
{

    /// Summary description for Logging.

    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void logEvent()
        {
            Form1 childForm = new Form1();
            childForm.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是一个巨魔");
            Logsomeshit();
        }

        private void Logsomeshit()
        {
            string sSource;
            string sLog;
            string sEvent;

            sSource = "Dark Army Data Exfiltrator 中国人民解放军";
            sLog = "Application";
            sEvent = "You stupid měiguó rén";

            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);

            EventLog.WriteEntry(sSource, sEvent);
            EventLog.WriteEntry(sSource, sEvent,
            EventLogEntryType.Warning, 667);
        }
    }
}
