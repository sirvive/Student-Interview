using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Coding : Form
    {
        public Coding()
        {
            InitializeComponent();
        }

// 
// Main Button
//
        public void button2_Click(object sender, EventArgs e)
        {
            StartPosition:
            int x = 1;
            if (x >= 1)

            StudentName();
            InterviewQ();
            
            DialogResult dr;

            dr = MessageBox.Show("Do you want to ask another student a question?", "Confirm Deletion", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                goto StartPosition;
            }
            else
            {
                MessageBox.Show("Thank you for using Cohort 3's Student|Interview Program");
            }
        }
//
// Student Names
//
        public string StudentName()
        {
            Random random = new Random();
            string[] Cohort3 = { "Adam", "Brad", "Bryan", "Danil",
                "David", "Dinesh", "Eric", "Oriana",
                "Jacob B.", "Jake","Tyler", "James P.", "Jared", "Joshua",
                "Keshav", "Martin", "Michael", "Mykal",
                "Omar", "Peter" , "Regina" , "Renata" , "Rob" ,
                   "Sheldon", "Tae", "Thomas", "Twokoko", "Zach"};

            string output = Cohort3[random.Next(Cohort3.Length)];
            MessageBox.Show(output);
            return Cohort3[random.Next(Cohort3.Length)];
        
        }

//
// Interview Questions
//

       
        public string InterviewQ()
        {
                Random random = new Random();
                string[] Question = { "Tell me about yourself. " , "What are you known for?" , "What is your reputation? ",
                "What is your personal brand? " , "Why do you do what you do?" , "What are your strength? " ,
                "What motivates you? ", "How do people benefit by working with you?" };
            string output = Question[random.Next(Question.Length)];
            MessageBox.Show(output);
            return Question[random.Next(Question.Length)];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
