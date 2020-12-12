using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOfNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            try
            {
                //grabs user's input
                string userInput = InputTextBox.Text;

                //isolates commas from the string
                char[] commas = { ',' };

                //creates a string array of the numbers the user typed
                string[] numberStrArray = userInput.Split(commas);

                //converts the string array into an int array
                int[] numbers = Array.ConvertAll(numberStrArray, int.Parse);

                //sorts the int array in ascending order
                //note: I wasn't consistently getting the correct total
                //unless the numbers were sorted like this
                Array.Sort(numbers);

                //creates a int variable to hold the total
                //and temporarily set its value to 0
                int total = 0;

                //bool list to check if items are true or false
                List<bool> visited = new List<bool>();
 
                for (int index = 0; index < numbers.Length; index++)
                {
                    visited.Add(false);
                }

                //index is set back to 0 in this for loop
                for (int index = 0; index < numbers.Length; index++)
                {
                    if (visited[index] == true)
                    {
                        //passes control to code below
                        continue;
                    }

                    //to grab numbers that occurr only once
                    int count = 1;

                    for (int index2 = index + 1; index2 < numbers.Length; index2++)
                    {
                        if (numbers[index] == numbers[index2])
                        {
                            count++;

                            //sets indexed element(s) to true
                            visited.Insert(index2, true);
                        }
                    }

                    if (count == 1)
                    {
                        total += numbers[index];
                    }

                }

                //converts total to string for easy display
                string totalDisplay = total.ToString();
                ResultLabel.Text = totalDisplay;
            }
            catch
            {
                //displays error text if user input is not valid
                ResultLabel.Text = "Invalid input.";
            }
        }
    }
}
