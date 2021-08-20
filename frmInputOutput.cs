using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MRodriguezACP2_1
{
    public partial class frmInputOutput : Form
    {
        public frmInputOutput()
        {
            InitializeComponent();
        }

        StreamReader sr = new StreamReader("numbers.txt");
        StreamWriter sw = new StreamWriter("grades.txt");
        double[] nums = new double[6];
        double total = 0.0;
        double average = 0.0;

        private void frmInputOutput_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = double.Parse(sr.ReadLine());
                lbxResults.Items.Add(nums[i].ToString());
            }
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                string letterGrade = getLetterGrade(nums[i]);
                sw.WriteLine($"Grade {i + 1}: {nums[i]} = {letterGrade}");
                total += nums[i];                           
            }
            MessageBox.Show("Results added to text file", "Results Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
            average = total / lbxResults.Items.Count;
            sw.WriteLine($"Total Grade: {total}");
            sw.WriteLine($"Avg Grade: {average}");


            sw.Close();
        }

        private string getLetterGrade(double v)
        {
            if (v >= 90)
                return "A";
            else if (v < 90 && v >= 80)
                return "B";
            else if (v < 80 && v >= 70)
                return "C";
            else if (v < 70 && v >= 60)
                return "D";
            else
                return "F";
              
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
