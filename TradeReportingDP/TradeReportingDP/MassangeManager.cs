using System;
using System.Drawing;
using System.Windows.Forms;

namespace TradeReportingDP
{
    internal class MassangeManager
    {
        static Timer TimerMassenge = new Timer();
        static Label Labels;
        static ToolStripLabel ToolLabels;
        private static void TimerMassange_Tick(object sender, EventArgs e)
        {
            if(Labels == null)
                ToolLabels.Visible = false;
            else
                Labels.Visible = false;
            TimerMassenge.Enabled = false;
            TimerMassenge.Tick -= TimerMassange_Tick;
        }
        public static void Massange(Label label, string text, Color color)
        {
            Labels = label;

            label.ForeColor = color;
            label.Text = text;
            label.Visible = true;

            if (TimerMassenge.Enabled)
            {
                TimerMassenge.Enabled = false;
                TimerMassenge.Tick -= TimerMassange_Tick;
            }

            TimerMassenge.Tick += TimerMassange_Tick;
            TimerMassenge.Interval = 5000; // default
            TimerMassenge.Enabled = true;
        }
        public static void Massange(ToolStripLabel label, string text, Color color)
        {
            ToolLabels = label;

            label.ForeColor = color;
            label.Text = text;
            label.Visible = true;

            if (TimerMassenge.Enabled)
            {
                TimerMassenge.Enabled = false;
                TimerMassenge.Tick -= TimerMassange_Tick;
            }

            TimerMassenge.Tick += TimerMassange_Tick;
            TimerMassenge.Interval = 5000; // default
            TimerMassenge.Enabled = true;
        }

        public static void Massange(ref Label label, string text, Color color, int interval)
        {
            Labels = label;

            label.ForeColor = color;
            label.Text = text;
            label.Visible = true;

            if (TimerMassenge.Enabled)
            {
                TimerMassenge.Enabled = false;
                TimerMassenge.Tick -= TimerMassange_Tick;
            }

            TimerMassenge.Tick += TimerMassange_Tick;
            TimerMassenge.Interval = interval; 
            TimerMassenge.Enabled = true;
        }
    }
}
