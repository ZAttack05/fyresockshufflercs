using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FYRE_Sock_Shuffler
{
    public partial class Form1 : Form
    {
        public static ArrayList unshuffled = new ArrayList();
        public static ArrayList shuffled = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name;
            name = enterTxt.Text;
            unshuffled.Add(name);
            string temp = string.Empty;
            foreach (String var in unshuffled)
            {
                temp = temp + var.ToString();
                temp = temp + "\n";
            }
            listRTxt.Text = temp;
            enterTxt.Text = string.Empty;
        }

        private void rdmBtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            while (unshuffled.Count > 0)
            {
                int spot = r.Next(0, unshuffled.Count);
                shuffled.Add(unshuffled[spot]);
                unshuffled.RemoveAt(spot);
            }
            string temp = string.Empty;
            foreach (String var in shuffled)
            {
                temp = temp + var.ToString();
                temp = temp + "\n";
            }
            temp = temp + "Shuffled!";
            listRTxt.Text = temp;
            enterTxt.Text = string.Empty;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            shuffled.Clear();
            unshuffled.Clear();
            listRTxt.Text = string.Empty;
            enterTxt.Text = string.Empty;  
        }
    }
}
