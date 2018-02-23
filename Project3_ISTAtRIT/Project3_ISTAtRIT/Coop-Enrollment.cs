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
    public partial class Coop_Enrollment : Form
    {
        public Coop_Enrollment(List<EnrollmentInformationContent> enrollmentInfo, string jobzoneGuide)
        {
            InitializeComponent();
            foreach (var item in enrollmentInfo)
            {
                coopInfoRTB.Text += item.title + ":\n " + item.description + "\n\n";
            }
            coopJobZoneLink.LinkClicked += (sender, EventArgs) => { guideLinkClicked(sender, EventArgs, jobzoneGuide); };
        }

        private void guideLinkClicked(object sender, LinkLabelLinkClickedEventArgs eventArgs, string jobzoneGuide)
        {
            System.Diagnostics.Process.Start(jobzoneGuide);
        }
    }
}
