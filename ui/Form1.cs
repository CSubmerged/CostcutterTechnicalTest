using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui
{
    public partial class Form1 : Form
    {
        static readonly Database db = new Database();

        public Form1()
        {
            InitializeComponent();
            // It should be possible to select the order number from a list of existing numbers.
            var orderNumbersLength = Form1.db.FetchOrdersCount();
            var orderNumbers = Enumerable.Range(1, orderNumbersLength).Select(n => n.ToString()).ToArray();
            comboBox1.Items.AddRange(orderNumbers);

            // Stop dataGridView duplicating columns
            dataGridView1.AutoGenerateColumns = false;

            // Hide datepicker and ensure default checkbox state is false
            HideDatePicker();
            dateFilterCheckbox.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear current values in datagrid box
            dataGridView1.DataSource = null;
            // Check whether the Order number has been inputted into the combo box
            if (comboBox1.SelectedIndex == -1)
            {
                lblSearch.Text = "Please select an Order Number from the list above";
                return;
            }

            var orderNumber = comboBox1.SelectedIndex + 1;
            lblSearch.Text = "Searching for order number " + orderNumber.ToString();

            var startDate = startDatePicker.Value.ToString("yyyy-MM-dd");

            var orderDetails = dateFilterCheckbox.Checked ? 
                Form1.db.FetchDateFilteredOrderDetails(orderNumber, startDate) :
                Form1.db.FetchOrderDetails(orderNumber);

            if (orderDetails.Count() > 0)
            {
                dataGridView1.DataSource = orderDetails.ToList();
                lblSearch.Text = "Found Order Info for Order Number " + orderNumber.ToString();
            } 
            else
            {
                lblSearch.Text = "Error - Could not find Order Info for Order Number " + orderNumber.ToString();
                lblSearch.Text += dateFilterCheckbox.Checked ? " after " + startDate : "";
            }
        }

        private void dateFilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (dateFilterCheckbox.Checked)
            {
                // Checkbox ticked so need to show date pickers
                ShowDatePicker();
            }
            else
            {
                // Checkbox unticked, hide date pickers
                HideDatePicker();
            }
        }

        private void HideDatePicker()
        {
            startDatePicker.Hide();
            startDateLabel.Hide();
        }

        private void ShowDatePicker()
        {
            startDatePicker.Show();
            startDateLabel.Show();
        }
    }
}
