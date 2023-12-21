using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PrimeNumberSqrt
{
    public partial class Form1 : Form
    {
        private SynchronizationContext UISync;

        public Form1()
        {
            InitializeComponent();
            UISync = SynchronizationContext.Current; /* Initialize UI Sync Method */
        }

        private void AppendTextToLog(string text)
        {
            StringBuilder sb = new StringBuilder(text);
            sb.Append("\r\n");
            UISync.Send((doing) =>
            {
                LogRTBox.AppendText("-> " + sb.ToString());
                LogRTBox.ScrollToCaret();
            }, null);
        }

        private void CheckNumber_Click(object sender, EventArgs e)
        {
            bool isPriNum = true;
            uint checkNum;
            if (uint.TryParse(EnterNumber.Text, out checkNum))
            {
                uint tesCount = 1;
                if (checkNum % 2 == 0) // First check if it is a multiple of 2.
                {
                    isPriNum = false;
                }                
                else if (checkNum % 3 == 0) // Second check if it is a multiple of 3.
                {
                    tesCount++;
                    isPriNum = false;
                }
                else // Not checking multiples of 2 and 3.
                {
                    tesCount++;
                    for (uint i = 5, gap = 2; i <= Math.Sqrt(checkNum); i += gap, gap = 6 - gap)
                    {
                        tesCount++;
                        // Start dividing by 5, adding 2 or 4 each time until reach the square root.
                        if (checkNum % i == 0)
                        {
                            isPriNum = false;
                            break;
                        }
                    }
                }

                if (checkNum < 2)
                {
                    AppendTextToLog("Error! Prime number must >= 2.");
                    AnalysisTimes.Text = "";
                    YesCBox.Checked = false;
                    NoCBox.Checked = false;
                }
                else if (isPriNum)
                {
                    AppendTextToLog("(" + checkNum.ToString() + ")" + " is a prime number.");
                    AppendTextToLog("Analysis times: " + tesCount);
                    AnalysisTimes.Text = tesCount.ToString();
                    YesCBox.Checked = true;
                    NoCBox.Checked = false;
                }
                else
                {
                    AppendTextToLog("(" + checkNum.ToString() + ")" + " not a prime number.");
                    AppendTextToLog("Analysis times: " + tesCount);
                    AnalysisTimes.Text = tesCount.ToString();
                    YesCBox.Checked = false;
                    NoCBox.Checked = true;
                }
            }
            else
            {
                AppendTextToLog("Error! Not a positive integer.");
                AnalysisTimes.Text = "";
                YesCBox.Checked = false;
                NoCBox.Checked = false;
            }
        }

        private void ClearField_Click(object sender, EventArgs e)
        {
            EnterNumber.Text = "";
            AnalysisTimes.Text = "";
            YesCBox.Checked = false;
            NoCBox.Checked = false;
        }
    }
}