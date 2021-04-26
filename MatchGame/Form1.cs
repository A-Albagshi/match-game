using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchGame
{
    public partial class Form1 : Form
    {
        public int [] generatedNum;
        public List<Label> Labels;
        public Label[] clickedLabelArr;
        public int clickCount = 0;
        public string clicked1="";
        public string clicked2="";
        public Form1()
        {
            InitializeComponent();
            Labels = new List<Label> 
                {label1,label2,label3,label4,label5,label6,label7,label8,label9,label10,label11,label12,label13,label14,label15,label16};
            clickedLabelArr = new Label[] {null, null};
            changeLabelApperance();
            genrateList();

            
        }

        public void changeLabelApperance()
        {
            foreach (var label in Labels)
            {
                label.Font = new Font("Arial", 24, FontStyle.Bold);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.ForeColor = Color.Salmon;
            }
        }

        public void genrateList()
        {
            generatedNum = new int[16];
            Random rnd = new Random();
            int randLabel;
            int genNum;
            int count = 0;

            for (int i = 0; i < generatedNum.Length; i+=2)
            {
                int newNum = rnd.Next(0, 10000);
                generatedNum[i] = newNum;
                generatedNum[i+1] = newNum;
            }
            while(count!=16)
            {
                genNum = rnd.Next(0, generatedNum.Length);
                randLabel = rnd.Next(0, Labels.Count);
                while (generatedNum[genNum]!=-1 && Labels[randLabel].Text=="")
                {
                    Labels[randLabel].Text = generatedNum[genNum].ToString();
                    generatedNum[genNum] = -1;
                    count++;
                }
            }
        }
        

        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            clickCount++;
            if (clicked1=="")
            {
                clicked1 = clickedLabel.Text;
                clickedLabel.Enabled = false;
                clickedLabelArr[0] = clickedLabel;
                clickedLabelArr[0].ForeColor = Color.Black;
            }
            if (clicked2=="" && clickCount>=2)
            {
                clicked2 = clickedLabel.Text;
                clickedLabel.Enabled = false;
                clickedLabelArr[1] = clickedLabel;
                clickedLabelArr[1].ForeColor = Color.Black;
            }

            if (clickCount>=2 && clickedLabelArr[0]!=null &&clickedLabelArr[1]!=null)
            {
                if (clickedLabelArr[0].Text == clickedLabelArr[1].Text)
                {
                    clearClicked(true);
                    
                }
                else
                {
                    Task.Delay(1000).ContinueWith(t =>
                    {
                        wrongPicks();
                        clearClicked();    
                    });
                    
                }
            }
        }

        public void clearClicked(bool win = false)
        {
            if (win)
            {
                clickedLabelArr[0].Visible = false;
                clickedLabelArr[1].Visible = false;    
            }
            clickedLabelArr[0] = null;
            clickedLabelArr[1] = null;

            clicked1 = "";
            clicked2 = "";
            clickCount = 0;
        }

        public void wrongPicks()
        {
            clickedLabelArr[0].Enabled = Enabled;
            clickedLabelArr[1].Enabled = Enabled;
            clickedLabelArr[0].ForeColor = Color.Salmon;
            clickedLabelArr[1].ForeColor = Color.Salmon;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label4_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label5_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label6_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label7_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label8_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label9_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label10_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label11_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label12_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label13_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label14_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label15_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }
        private void label16_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }

        
    }
}