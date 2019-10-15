using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        RefrigeratorClass refrigerator = new RefrigeratorClass();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            refrigerator.maxWeight =Convert.ToDouble(maxWeightTakeTextBox.Text);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            refrigerator.itemNo =Convert.ToDouble(itemTextBox.Text);
            refrigerator.weight= Convert.ToDouble(weightTextBox.Text);
            if (refrigerator.maxWeight > refrigerator.CurretWeight()) 
            {
                currentWeightTextBox.Text = refrigerator.CurretWeight().ToString();
               remainingWeightTextBox.Text = refrigerator.Remain().ToString();
            }
            else
            {
                MessageBox.Show("It Become more than MAx Weight");
                return;
            }

        }
    }
}
