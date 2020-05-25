using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var r = new Random(); //Our random numbers generator
            int A = r.Next(0, 999999); //The values from what to what numbers we will be using
            int fromBase = 10; // Base10 Decimal
            int toBase = 2; //Base 2 Binary
            int tooBase = 16; // Base16 Hex

            string number = A.ToString(); //Thsi will generate a random number from the values we input.
            string binaryValue = Convert.ToString(Convert.ToInt32(number, 10), 2); //This string will get that number and give a binary value.
            string hexValue = Convert.ToString(Convert.ToInt32(number,10),16); //This string will get that number and give a hex value.
            string decValue = Convert.ToString(Convert.ToInt32(number, 10), 10); //This string will get that number and give a decimal value.
            DecimalDisplay.Text = decValue; //Input in our decimal textbox.
            BinaryDisplay.Text = binaryValue; //Input in our binary textbox.
            HexDisplay.Text = hexValue; //Input in our hex textbox.
        }
    }
}
