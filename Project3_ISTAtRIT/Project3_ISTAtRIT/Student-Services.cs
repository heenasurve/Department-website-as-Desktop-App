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
    public partial class Student_Services : Form
    {
        public Student_Services(string description, string faqlink, string faculty_adv_desc, List<AdvisorInformation> prof_advisors, List<MinorAdvisorInformation> minor_advisors)
        {
            InitializeComponent();
            AdvisingDescRTB.Text = description;
            AdvisingFaqLink.Text = "Click Here !";
            string url = faqlink;
            //AdvisingFaqLink.LinkClicked += faqLinkClicked;
            AdvisingFaqLink.LinkClicked += (sender, EventArgs) => { faqLinkClicked(sender, EventArgs,faqlink); };

            facultyAdvRTB.Text = faculty_adv_desc;

            foreach (var advisor in prof_advisors)
            {
                professionAdvisorsRTB.Text += advisor.name + "\n" + advisor.department + "\n" + advisor.email + "\n\n";
            }

            foreach (var advisor in minor_advisors)
            {
                minorAdvisorsRTB.Text += advisor.title + "\n" + advisor.advisor + "\n" + advisor.email + "\n\n";
            }


        }

        private void faqLinkClicked(object sender, LinkLabelLinkClickedEventArgs eventArgs, string faqlink)
        {
            System.Diagnostics.Process.Start(faqlink);
        }

    }
}
