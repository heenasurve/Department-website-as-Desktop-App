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
    public partial class Places_StudyAbroad : Form
    {
        public Places_StudyAbroad(string name,string description)
        {
            InitializeComponent();
            Label label_name = new Label();
            label_name.Text = name;           
            label_name.ForeColor = Color.OrangeRed;

            RichTextBox label_desc = new RichTextBox();
            label_desc.ReadOnly = true;
            label_desc.BackColor = Color.White;
            label_desc.ForeColor = Color.Orange;
            label_desc.Width = 1000;
            label_desc.Height = 300;
            label_desc.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            label_desc.WordWrap = true; 
            label_desc.Text = description;


            placesFlowPanel.Controls.Add(label_name);
            placesFlowPanel.Controls.Add(label_desc);
        }
    }
}
