using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace _02TaskPerformance1
{
    public partial class CashierWindowQueue : Form
    {
        CustomerViewForm cf;
        public CashierWindowQueue()
        {
            cf = new CustomerViewForm();
            InitializeComponent();
            timer1.Start();
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();

            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void CashierWindowQueue_Load(object sender, EventArgs e)
        {
            cf.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();


            if (CashierClass.CashierQueue.Count == 0)
            {
                MessageBox.Show("Number in Queue List is 0");
            }
            try
            {


                cf.lblQueueNowServing.Text = CashierClass.CashierQueue.Peek();

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Number in Queue List is 0");
                Console.WriteLine(ex);
                timer1.Stop();

            }
            finally
            {
                CashierClass.CashierQueue.Dequeue();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
