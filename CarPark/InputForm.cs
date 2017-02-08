using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarPark
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            this.EntryTimePicker.Value = DateTime.Now;
            this.ExitTimePicker.Value = this.EntryTimePicker.Value;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rate = RateEngine.CalculateRate(this.EntryTimePicker.Value, this.ExitTimePicker.Value);
                this.ResultsBox.AppendText(string.Format("\r\nEntry: {0}\r\nExit: {1}\r\nTotal: {2} - ${3}\r\n", rate.EntryTime, rate.ExitTime, rate.RateType, rate.Amount));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
