using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_ISTAtRIT
{
    public partial class Student_Ambassadors : Form
    {
        public Student_Ambassadors(List<SubSectionContent> contents, string formLink, string note)
        {
            InitializeComponent();
            foreach (var content in contents)
            {
                studentAmbRTB.Text += content.title + ": " + content.description + "\n\n";
            }
            studentAmbNote.Text = note;
        
            studentAmbapplyLink.LinkClicked += (sender, EventArgs) => { applyLinkClicked(sender, EventArgs, formLink); };
        }

        private void applyLinkClicked(object sender, LinkLabelLinkClickedEventArgs eventArgs, string formLink)
        {
            System.Diagnostics.Process.Start(formLink);
        }
    }
}
