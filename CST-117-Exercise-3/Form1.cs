using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Exercise_3
{
    public partial class marsConversionForm : Form
    {
        // Calculations provided by the National Schools Observatory at https://www.schoolsobservatory.org/discover/quick/weight
        private const String MARS_WEIGHT_TEXT = "Your weight on Mars: ";
        private const Double EARTH_SURFACE_GRAVITY = 1.0;
        private const Double MARS_SURFACE_GRAVITY = 0.38;


        public marsConversionForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Double earthWeight = double.Parse(this.earthWeightTextBox.Text);
            Double marsWeight = convertWeight(earthWeight);
            changeMarsWeightLabel(marsWeight);
        }

        private double convertWeight(double earthWeight)
        {
            // Weight = Mass x Surface Gravity
            double mass = earthWeight / EARTH_SURFACE_GRAVITY;
            return mass * MARS_SURFACE_GRAVITY;
        }
        private void changeMarsWeightLabel(double marsWeight)
        {
            String newText = MARS_WEIGHT_TEXT + marsWeight.ToString();
            marsWeightLabel.Text = newText;
        }

        private void marsConversionForm_Load(object sender, EventArgs e)
        {
            marsWeightLabel.Text = MARS_WEIGHT_TEXT;
        }
    }
}
