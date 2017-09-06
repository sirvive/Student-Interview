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
            string[] Cohort3 = { "Adam", "Brad", "Brandon", "Bryan", "Danil",
                "David", "Dinesh", "Eric", "Oriana",
                "Jacob B.", "Jake", "James", "Jared", "Joshua",
                "Keshav", "Martin", "Mike", "Mykal",
                "Omar", "Peter" , "Regina" , "Renata" , "Rob" ,
                   "Sheldon", "Steven", "Tae", "Tom", "Twokoko", "Tyler", "Zach"};

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
                string[] Question = {
                "Tell me about yourself.",
                "What are you known for?",
                "What is your reputation?",
                "What is your personal brand? ",
                "What do you want to do?",
                "What motivates you? ",
                "How do people benefit by working with you?",
                "What are your strengths? ",
                "What are your weaknesses?",
                "Who is someone you look up to? Why?",
                "Name someone in your career who really made a difference",
                "Are you willing to travel?",
                "How much are you willing to travel?",
                "What's your availability? When can you start work?",
                "How long do you expect to work for this company?",
                "Why do you want to leave your current company?",
                "Why are you looking for a new job?",
                "Why are you leaving the military?",
                "Tell me about a time when you disagreed with your boss. How did you handle it?",
                "How would you handle a disagreement if your boss was wrong?",
                "What do you expect from a supervisor?",
                "If I called your boss right now and asked him what is an area that you could improve on, what would he say?",
                "What are three positive things your last boss would say about you?",
                "What negative thing would your last boss say about you",
                "What was the last book you read for fun?",
                "Tell me about an accomplishment you are most proud of.",
                "What's the most difficult decision you've made in the last two years and how did you come to that decision?",
                "What do you consider your most significant accomplishment?",
                "Why do you believe you are qualified for this position?",
                "Have you ever accomplished something you did think you could?",
                "What do you like or dislike about your current position?",
                "How do you handle pressure?",
                "Good employees can take the initiative and get the job done. Can you describe yourself in terms of this statement?",
                "What is the most difficult aspect about your career?",
                "How have you ever grown or changed over the past few years?",
                "What do you consider your most significant challenge?",
                "What goals have you set recently?",
                "What do you think of your current/past supervisor",
                "What jobs have you held and why did you leave?",
                "What is your management style?",
                "Why did you choose this field of work?",
                "How do you spend your spare time?",
                "What are personal characteristics do you feel are necessary for success in this field?",
                "Do you prefer working with others or by yourself?",
                "What kind of boss do you prefer?",
                "How do you respond to negative feedback?",
                "How do you handle a conflict?",
                "How long do you plan to stay with us?"};


            string output = Question[random.Next(Question.Length)];
            MessageBox.Show(output);
            return Question[random.Next(Question.Length)];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
