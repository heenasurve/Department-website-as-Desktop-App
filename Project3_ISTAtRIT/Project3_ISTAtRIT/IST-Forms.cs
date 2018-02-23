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
    public partial class IST_Forms : Form
    {
        public IST_Forms(List<GraduateForm> grad_forms, List<UndergraduateForm> undergrad_forms)
        {
            InitializeComponent();
            int i = 0;
            foreach (var grad_form in grad_forms)
            {
                Button button = new Button();
                button.Text = grad_form.formName;
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.WhiteSmoke;
                button.ForeColor = Color.OrangeRed;
                button.MouseHover += button_MouseHover;
                button.MouseLeave += button_MouseLeave;
                button.Width = 200;
                button.Height = 50;
                button.Location = new Point(20, (i * 200)+100);
                i++;

             
                gradFormsFlowPanel.Controls.Add(button);
                button.Click += (sender, EventArgs) => { formClick(sender, EventArgs, grad_form); };
                
            }
            foreach (var undergrad_form in undergrad_forms)
            {
                Button button = new Button();
                button.Text = undergrad_form.formName;
                button.FlatStyle = FlatStyle.Flat;
                button.Width = 200;
                button.Height = 50;
                button.Location = new Point(20, (i * 200) + 50);
                i++;
                undergradFormsFlowPanel.Controls.Add(button);
                button.Click += (sender, EventArgs) => { UndergradFormClick(sender, EventArgs, undergrad_form); };

            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.WhiteSmoke;
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Ivory;
            Cursor cursor = Cursors.Hand;
        }

        private void UndergradFormClick(object sender, EventArgs eventArgs, UndergraduateForm undergrad_form)
        {
            System.Diagnostics.Process.Start("https://ist.rit.edu/" + undergrad_form.href); 
        }

       private void formClick(object sender, EventArgs e, GraduateForm grad_form)
        {
            System.Diagnostics.Process.Start("https://ist.rit.edu/" + grad_form.href);
        }
    }
}
