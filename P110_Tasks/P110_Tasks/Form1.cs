using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P110_Tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateSync_Click(object sender, EventArgs e)
        {
            txtResultSync.Text = DoLoopSync().ToString();
        }

        private async void btnCalculateAsync_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.ForeColor = Color.Red;

            long result = await DoLoopAsync();

            label3.Text = "Calculating 2nd loop";

            long result2 = await DoLoopAsync();

            txtResultAsync.Text = (result + result2).ToString();
        }

        private Task<long> DoLoopAsync()
        {
            Task<long> loopTask = Task.Run(() =>
            {
                return DoLoopSync();
            });

            return loopTask;
        }

        private long DoLoopSync()
        {
            long sum = 0;
            for (int i = 0; i < 2000000000; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
