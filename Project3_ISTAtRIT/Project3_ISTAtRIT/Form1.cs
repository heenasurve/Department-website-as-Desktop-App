using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//the code for each tab is placed in a region for better readabality
namespace Project3_ISTAtRIT
{
    public partial class Form1 : Form
    {

        #region variables required across form functions
        string jsonDegrees;
        Degree degree; 
        List<Undergraduate> undergrad_degrees;
        List<Graduate> grad_degrees;

        string jsonEmployment;
        Employment employment_data;

        string jsonPeople;
        People people;
        List<Faculty> faculty_members;
        List<Staff> staff_members;
       

        string jsonResearch;
        Research research_data;
        List<ByInterestArea> interest_areas;
        List<ByFaculty> faculty;

        string jsonMinors;
        Minor minors_data;
        List<UgMinor> minors;

        string jsonResources;
        Resource resources;
        StudyAbroad studyAbroad;
        StudentServices studentServices;
        Forms forms;
        StudentAmbassadors studentAmbassadors;
        CoopEnrollment coopEnrollment;
        TutorsAndLabInformation tutoringAndLabInfo;

        Footer footer_data;
        #endregion


        public Form1()
        {
            InitializeComponent();
            
        }

        #region getRestData - Returns the requested API information as a string
        private string getRestData(string uri) //returns REST data given a URL
        {
            string baseurl = "http://ist.rit.edu/api";
            //connect to API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseurl + uri);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responsestream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responsestream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }

            }
            catch (WebException webEx)
            {
                WebResponse error = webEx.Response;
                using (Stream responsestream = error.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responsestream, Encoding.UTF8);
                    string errorText = reader.ReadToEnd();
                    Console.WriteLine(errorText);
                }
                throw;
            }

        }
        #endregion

        #region getAboutData
        private void getAbout() //get data from the About section of the API
        {
            //get About information
            string jsonAbout = getRestData("/about/");
            // get JSON form into an ABout object
            About about = JToken.Parse(jsonAbout).ToObject<About>();
            //display about object information on the form
            aboutSiteRTB.Text = about.title;
            aboutSiteRTB.Text += "\n\n\n"+ about.description + "\n\n";
            aboutSiteRTB.Text += "\"" + about.quote + "\"";
            aboutSiteRTB.Text += "\n~" + about.quoteAuthor;

            //display footer data on the About Page
            getFooterData();
            //Adds button to access contact form on about page
            addLinkToContactForm();
        }

        private void addLinkToContactForm()
        {
            Button quickLink = new Button();
            quickLink.Text = "Contact Us";            
            quickLink.Width = 405;
            quickLink.Height = 70;
            quickLink.BackColor = Color.WhiteSmoke;
            quickLink.ForeColor = Color.OrangeRed;
            quickLink.MouseHover += reserch_area_MouseHover;
            quickLink.MouseLeave += research_area_MouseLeave;
            quickLinksPanel.Controls.Add(quickLink);
            string linkToContactForm = "http://ist.rit.edu/api/contactForm";
            quickLink.Click += (sender, EventArgs) => { quickLinkClicked(sender, EventArgs, linkToContactForm); };
            
        }

        private void getFooterData() //renders buttons for all quicklinks from the footer API, adds social buttons 
        {
            string jsonAbout = getRestData("/footer/");
            footer_data = JToken.Parse(jsonAbout).ToObject<Footer>();

            socialRTB.Text = footer_data.social.tweet + "\n            -" + footer_data.social.by;
          
            facebookBtn.Click += (sender, EventArgs) => { goToTheSocialPage(sender, EventArgs,footer_data.social.facebook); };
            twitterBtn.Click += (sender, EventArgs) => { goToTheSocialPage(sender, EventArgs, footer_data.social.twitter); };

            foreach (var link in footer_data.quickLinks)
            {
                Button quickLink = new Button();
                quickLink.Text =link.title;
                quickLink.Name = link.title;
                quickLink.Width = 405;
                quickLink.Height = 70;
                quickLink.BackColor = Color.WhiteSmoke;
                quickLink.ForeColor = Color.OrangeRed;
                quickLink.MouseHover += reserch_area_MouseHover;
                quickLink.MouseLeave += research_area_MouseLeave;
                quickLink.Click += (sender, EventArgs) => { quickLinkClicked(sender, EventArgs, link.href); };            
                quickLinksPanel.Controls.Add(quickLink);
            }
        }

        private void quickLinkClicked(object sender, EventArgs eventArgs, string href)
        {
            System.Diagnostics.Process.Start(href);
        }

        private void goToTheSocialPage(object sender, EventArgs eventArgs, string socialUrl)
        {
            System.Diagnostics.Process.Start(socialUrl);
        }

      

        private void newsBtn_Click(object sender, EventArgs e)
        {
            var news_page = new NewsPage();
            news_page.Show();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            getAbout();
        }


        #endregion

        #region get And Render Undergraduate Degrees Data
        public void getUnderGraduateProgramData() //gets and assigns degree names to buttons on the form
        {
            jsonDegrees= getRestData("/degrees/");
            degree = JToken.Parse(jsonDegrees).ToObject<Degree>();
            undergrad_degrees = degree.undergraduate;

            ugDegree1.Text = undergrad_degrees[0].title;
            ugDegree2.Text = undergrad_degrees[1].title;
            ugDegree3.Text = undergrad_degrees[2].title;

        }

        private void tabPage1_Enter_1(object sender, EventArgs e)
        {
            getUnderGraduateProgramData();
        }

        
        private void ugDegree1_Click(object sender, EventArgs e)
        {
            undergradConcRTB.Text = "";
            undergradDescRTB.Text = undergrad_degrees[0].description;
            foreach (var concentration in undergrad_degrees[0].concentrations)
            {
                undergradConcRTB.Text += concentration + "\n";
            }
            

        }

        private void ugDegree2_Click(object sender, EventArgs e)
        {
            undergradConcRTB.Text = "";
            undergradDescRTB.Text = undergrad_degrees[1].description;
            foreach (var concentration in undergrad_degrees[1].concentrations)
            {
                undergradConcRTB.Text += concentration + "\n";
            }
        }

        private void ugDegree3_Click(object sender, EventArgs e)
        {
            undergradConcRTB.Text = "";
            undergradDescRTB.Text = undergrad_degrees[2].description;
            foreach (var concentration in undergrad_degrees[2].concentrations)
            {
                undergradConcRTB.Text +=  concentration + "\n" ;
            }
        }

        #endregion

        #region get And Render Graduate Degrees Data 
        private void tabPage7_Enter(object sender, EventArgs e)
        {
            getGraduateProgramData();
        }

        private void getGraduateProgramData() //dynamically creates buttons based on the number of degrees available, puts them on the form and adds event handling capabilities
        {
            grad_degrees = degree.graduate;
            int index = 0;
            foreach (var graddegree in grad_degrees)
            {
                if (!graddegree.degreeName.Equals("graduate advanced certificates")) {
                    Button degButton = new Button();
                    degButton.Text = graddegree.title;
                    degButton.Name = "graddegree_" + index + "";
                    degButton.Width = 231;
                    degButton.Height = 144;
                    degButton.Location = new Point(64, 100 + (index * 180));
                    degButton.BackColor = Color.WhiteSmoke;
                    degButton.ForeColor = Color.OrangeRed;
                    degButton.FlatStyle = FlatStyle.Flat;
                    degButton.MouseHover += reserch_area_MouseHover;
                    degButton.MouseLeave += research_area_MouseLeave;
                    
                    degButton.Click += gradegree_Click;
                    index++;
                    tabPage7.Controls.Add(degButton);
                }
            }

        }
        private void gradegree_Click(object sender, EventArgs e)  //identifies which grad degree has been selected and displays the corresponding information
        {
            string selected_degree = ((Button)sender).Name;
            //Console.WriteLine(selected_degree);
            int found = selected_degree.IndexOf('_');
            string index = selected_degree.Substring(found + 1);
            int i = Int32.Parse(index);
            gradConcRTB.Text = "";
            gradDescRTB.Text = grad_degrees[i].description;
            foreach (var concentration in grad_degrees[i].concentrations)
            {
                gradConcRTB.Text +=  concentration + "\n" ;
            }

        }
       
        private void tabPage8_Enter(object sender, EventArgs e)
        {
            getGraduateAdvancedCertficates();
        }

        private void getGraduateAdvancedCertficates()
        {
            gradAdvCertRTB.Text = "";
            grad_degrees = degree.graduate;
            foreach (var graddegree in grad_degrees)
            {
                if (graddegree.degreeName.Equals("graduate advanced certificates"))
                {
                    foreach (var certificate in graddegree.availableCertificates)
                    {
                        gradAdvCertRTB.Text +=  certificate + "\n" ;
                    } 
                }
            }
        }
        #endregion

        #region get and Render Employment Data 
        private void tabPage3_Enter(object sender, EventArgs e)
        {
            getEmploymentData();
        }

        private void getEmploymentData() //gets and renders all of the data from the employment section of the API
        {
            jsonEmployment = getRestData("/employment/");
            employment_data = JToken.Parse(jsonEmployment).ToObject<Employment>();
            employmentDescLbl.Text = employment_data.introduction.title;

            foreach (var content in employment_data.introduction.content)
            {
                if (content.title.Equals("Employment"))
                {
                    employmentDesc.Text = content.description;
                }
                if(content.title.Equals("Cooperative Education"))
                {
                    coopDesc.Text = content.description;
                }
            }

            //display all employment statistics
            DegreeStatistics degreeStatistics = employment_data.degreeStatistics;
            Color[] colorArray = { Color.BlanchedAlmond, Color.Azure, Color.DarkKhaki, Color.Bisque };
            
            int index = 0;
            if (statisticsPanel.Controls.Count == 0)
            {
                foreach (var stat in degreeStatistics.statistics)
                {
                    Button statButton = new Button();
                    statButton.Text = stat.value + "\n" + stat.description;
                    statButton.Width = 200;
                    statButton.Height = 175;
                    statButton.BackColor = colorArray[index];
                    statisticsPanel.Controls.Add(statButton);
                    index++;
                }
            }


            //employer names
            Employers employers = employment_data.employers;

            employersLbl.Text = employers.title;
            employersRTB.Text = "";
            foreach (var employer in employers.employerNames)
            {
               
               employersRTB.Text += employer + "\n";
            }

            //careers
            Careers coops = employment_data.careers;
            coopsLbl.Text = coops.title;
            coopsRTB.Text = "";
            foreach (var coop in coops.careerNames)
            {
                coopsRTB.Text += coop + "\n";
            }

            //employement and coop tables
            EmploymentTable emp_table = employment_data.employmentTable;
            List <ProfessionalEmploymentInformation> fulltime_positions = emp_table.professionalEmploymentInformation;
            dataGridView_emp.Columns.Add("Employer","Employer");
            dataGridView_emp.Columns.Add("Degree", "Degree");
            dataGridView_emp.Columns.Add("City", "City");
            dataGridView_emp.Columns.Add("Title", "Title");
            dataGridView_emp.Columns.Add("Start Date", "Start Date");
          


            for (var i = 0; i < fulltime_positions.Count; i++)
            {
                dataGridView_emp.Rows.Add();
                dataGridView_emp.Rows[i].Cells[0].Value = fulltime_positions[i].employer;
                dataGridView_emp.Rows[i].Cells[1].Value = fulltime_positions[i].degree;
                dataGridView_emp.Rows[i].Cells[2].Value = fulltime_positions[i].city;
                dataGridView_emp.Rows[i].Cells[3].Value = fulltime_positions[i].title;
                dataGridView_emp.Rows[i].Cells[4].Value = fulltime_positions[i].startDate;

            }

            CoopTable coop_table = employment_data.coopTable;
            List<CoopInformation> coop_positions = coop_table.coopInformation;
            dataGridView_coop.Columns.Add("Employer", "Employer");
            dataGridView_coop.Columns.Add("Degree", "Degree");
            dataGridView_coop.Columns.Add("City", "City");
            dataGridView_coop.Columns.Add("Term", "Term");
          

            for (var i = 0; i < coop_positions.Count; i++)
            {
                dataGridView_coop.Rows.Add();
                dataGridView_coop.Rows[i].Cells[0].Value = coop_positions[i].employer;
                dataGridView_coop.Rows[i].Cells[1].Value = coop_positions[i].degree;
                dataGridView_coop.Rows[i].Cells[2].Value = coop_positions[i].city;
                dataGridView_coop.Rows[i].Cells[3].Value = coop_positions[i].term;
                

            }

    }

        //map
        private void mapBtn_Click(object sender, EventArgs e)
        {
            string url = "https://ist.rit.edu/api/map";
            MapFramePage mapPage = new MapFramePage(url);
            mapPage.Show();
        }


        #endregion

        #region get and render People data
        private void tabPage4_Enter(object sender, EventArgs e)
        {
            getFacultyData(); 
            //((Button)peopleFlowLayout.Controls["faculty_0"]).PerformClick();
        }

        private void getFaculty_Click(object sender, EventArgs e)
        {
            getFacultyData();
        }

        private void getStaff_Click(object sender, EventArgs e)
        {
            getStaffData();
        }

        private void getFacultyData() //gets and renders faculty information
        {
            jsonPeople = getRestData("/people/");
            people = JToken.Parse(jsonPeople).ToObject<People>();


            faculty_members = people.faculty;
            Console.WriteLine("Faulty members : " + people);
            int index = 0;
          
            peopleFlowLayout.Controls.Clear();
            foreach (var faculty in faculty_members)
                {
                    Button button = new Button();
                    button.Text = faculty.name + "\n" + faculty.title;
                    button.Name = "faculty_" + index + "";
                    button.Width = 190;
                    button.Height = 80;
                    button.BackColor = Color.WhiteSmoke;
                    button.ForeColor = Color.OrangeRed;
                    button.MouseHover += reserch_area_MouseHover;
                    button.MouseLeave += research_area_MouseLeave;
                    button.Click += faculty_Click;
                    index++;
                    peopleFlowLayout.Controls.Add(button);
                }
            
        }

        private void faculty_Click(object sender, EventArgs e) //displays available data on clicking a faculty/staff member button
        {
            string selected_faculty = ((Button)sender).Name;
            //Console.WriteLine(selected_degree);
            int found = selected_faculty.IndexOf('_');
            string index = selected_faculty.Substring(found + 1);
            int i = Int32.Parse(index);

            faculty_email.Text = "";
            faculty_contact.Text = "";
            faculty_office.Text = "";
            faculty_website.Text = "";

            peopleImage.Load(faculty_members[i].imagePath);
            faculty_name.Text = faculty_members[i].name;
            faculty_title.Text = faculty_members[i].title;
            if (faculty_members[i].username != "")
            {
                faculty_email.Text = faculty_members[i].username;
            }
         
            if (faculty_members[i].phone != "")
            {
                faculty_contact.Text = faculty_members[i].phone;
            }
            if (faculty_members[i].office != "")
            {
                faculty_office.Text = faculty_members[i].office;
            }
            if(faculty_members[i].website !="")
            {
                faculty_website.Text = faculty_members[i].website;
            }

        }

        private void getStaffData() //gets and renders staff information
        {
            jsonPeople = getRestData("/people/");
            people = JToken.Parse(jsonPeople).ToObject<People>();


            staff_members = people.staff;
            int index = 0;
            peopleFlowLayout.Controls.Clear();
                foreach (var staff in staff_members)
                {
                    Button button = new Button();
                    button.Text = staff.name + "\n" + staff.title;
                    button.Name = "staff_" + index + "";
                    button.Width = 190;
                    button.Height = 80;
                    button.BackColor = Color.WhiteSmoke;
                    button.ForeColor = Color.OrangeRed;
                    button.MouseHover += reserch_area_MouseHover;
                    button.MouseLeave += research_area_MouseLeave;
                    button.Click += staff_Click;
                    index++;
                    peopleFlowLayout.Controls.Add(button);
                }
            
        }

        private void staff_Click(object sender, EventArgs e)
        {
            string selected_staff = ((Button)sender).Name;
            //Console.WriteLine(selected_degree);
            int found = selected_staff.IndexOf('_');
            string index = selected_staff.Substring(found + 1);
            int i = Int32.Parse(index);

            faculty_email.Text = "";
            faculty_contact.Text = "";
            faculty_office.Text = "";
            faculty_website.Text = "";

            peopleImage.Load(staff_members[i].imagePath);
            faculty_name.Text = staff_members[i].name;
            faculty_title.Text = staff_members[i].title;
            if (staff_members[i].username != "")
            {
                faculty_email.Text = staff_members[i].username;
            }
            if (staff_members[i].phone != "")
            {
                faculty_contact.Text = staff_members[i].phone;
            }
            if (staff_members[i].office != "")
            {
                faculty_office.Text = staff_members[i].office;
            }
            if (staff_members[i].website != "")
            {
                faculty_website.Text = staff_members[i].website;
            }

        }
        #endregion

        #region get and Render Research information
        private void tabPage5_Enter(object sender, EventArgs e)
        {
            getResearchDataByInterestArea();
            List<string> citations = interest_areas[0].citations;
            int indexer = 1;
            foreach (var citation in citations)
            {
                listCitations.Items.Add(indexer + "." + citation);
                indexer++;
            }
        }

        private void getByInterestArea_Click(object sender, EventArgs e)
        {
            getResearchDataByInterestArea();
        }

        private void getByFaculty_Click(object sender, EventArgs e)
        {
            getResearchDataByFaculty();
        }
        private void getResearchDataByInterestArea()
        {

            jsonResearch = getRestData("/research/");
            research_data = JToken.Parse(jsonResearch).ToObject<Research>();
            researchFlowLayout.Controls.Clear();
            interest_areas = research_data.byInterestArea;
            int index = 0;
            foreach (var research_area in interest_areas)
            {
                Button button = new Button();
                button.Text = research_area.areaName;
                button.Name = "researcharea_" + index + "";
                button.Width = 250;
                button.Height = 150;
                button.BackColor = Color.WhiteSmoke;
                button.ForeColor = Color.OrangeRed;
                button.MouseHover += reserch_area_MouseHover;
                button.MouseLeave += research_area_MouseLeave;
                button.Click += reserch_area_Click;
                index++;
                researchFlowLayout.Controls.Add(button);                             
            }
            ((Button)researchFlowLayout.Controls["researcharea_0"]).PerformClick();

        }

        private void research_area_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.WhiteSmoke;
        }

        private void reserch_area_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Ivory;
            Cursor cursor = Cursors.Hand;
        }

        private void reserch_area_Click(object sender, EventArgs e)
        {
            string selected_area = ((Button)sender).Name;
            int found = selected_area.IndexOf('_');
            string index = selected_area.Substring(found + 1);
            int i = Int32.Parse(index);
            listCitations.Items.Clear();
            List<string> citations = interest_areas[i].citations;
            int indexer = 1;
            foreach (var citation in citations)
            {
                listCitations.Items.Add(indexer + "." + citation);
                indexer++;
            }
        }

        private void getResearchDataByFaculty()
        {
            jsonResearch = getRestData("/research/");
            research_data = JToken.Parse(jsonResearch).ToObject<Research>();
            researchFlowLayout.Controls.Clear();
            faculty = research_data.byFaculty;
            int index = 0;
            foreach (var fac in faculty)
            {
                Button button = new Button();
                button.Text = fac.facultyName;
                button.Name = "faculty_" + index + "";
                button.Width = 250;
                button.Height = 150;
                button.BackColor = Color.WhiteSmoke;
                button.ForeColor = Color.OrangeRed;
                button.MouseHover += researchFaculty_MouseHover;
                button.MouseLeave += researchFaculty_MouseLeave;
                button.Click += researchFaculty_Click;
                index++;
                researchFlowLayout.Controls.Add(button);
            }

        }

        private void researchFaculty_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.WhiteSmoke;
        }

        private void researchFaculty_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Ivory;
            Cursor cursor = Cursors.Hand;
        }

        private void researchFaculty_Click(object sender, EventArgs e)
        {
            string selected_faculty = ((Button)sender).Name;
            int found = selected_faculty.IndexOf('_');
            string index = selected_faculty.Substring(found + 1);
            int i = Int32.Parse(index);
            listCitations.Items.Clear();
            List<string> citations = faculty[i].citations;
            int indexer = 1;
            foreach (var citation in citations)
            {
                listCitations.Items.Add(indexer + "." + citation);
                indexer++;
            }
        }

        #endregion

        #region get and render Minors Information
        private void tabPage10_Enter(object sender, EventArgs e)
        {
            getMinors();

        }

        private void getMinors()
        {
            jsonMinors = getRestData("/minors/");
            minors_data = JToken.Parse(jsonMinors).ToObject<Minor>();
            minorsFlowLayout.Controls.Clear();
            minors = minors_data.UgMinors;
            int index = 0;
            foreach (var minor in minors)
            {
                Button button = new Button();
                button.Text = minor.title;
                button.Name = "minor_" + index + "";
                button.Width = 250;
                button.Height = 150;
                button.BackColor = Color.WhiteSmoke;
                button.ForeColor = Color.OrangeRed;
                button.MouseHover += reserch_area_MouseHover;
                button.MouseLeave += research_area_MouseLeave;
                button.Click += minor_Click;
                index++;
                minorsFlowLayout.Controls.Add(button);
            }
            minorTitle.Text = minors[0].title;
            minorDesc.Text = minors[0].description;
            List<string> courses = minors[0].courses;
            minorConcFlowLayout.Controls.Clear();
            foreach (var course in courses)
            {
                LinkLabel linkLabel = new LinkLabel();
                linkLabel.Name = course;
                linkLabel.Text = course;
                linkLabel.LinkColor = Color.DarkOrange;
                linkLabel.VisitedLinkColor = Color.BlueViolet;
                linkLabel.LinkClicked += course_LinkClicked;
                minorConcFlowLayout.Controls.Add(linkLabel);

            }
        }

        private void minor_Click(object sender, EventArgs e)
        {
            string selected_minor = ((Button)sender).Name;
            int found = selected_minor.IndexOf('_');
            string index = selected_minor.Substring(found + 1);
            int i = Int32.Parse(index);

            minorTitle.Text = minors[i].title;
            minorDesc.Text = minors[i].description;
            List<string> courses = minors[i].courses;
            minorConcFlowLayout.Controls.Clear();
            foreach (var course in courses)
            {
                LinkLabel linkLabel = new LinkLabel();
                linkLabel.Name = course;
                linkLabel.Text = course;
                linkLabel.LinkColor = Color.DarkOrange;
                linkLabel.VisitedLinkColor = Color.BlueViolet;
                linkLabel.LinkClicked += course_LinkClicked;
                minorConcFlowLayout.Controls.Add(linkLabel);

            }
         
        }

        private void course_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string course = ((LinkLabel)sender).Name;
            string url = "/course/courseID=" + course;
            string course_json = getRestData(url);
            Course course_data = JToken.Parse(course_json).ToObject<Course>();

            //MessageBox.Show(course_data.title+"\n"+course_data.description);
            var course_page = new MinorCourse(course_data.title, course_data.description);
            course_page.Location = new Point(500 , 500);
            course_page.Left = 1000;
            course_page.Top = 800;
            course_page.Show();
        }
        #endregion

        #region get and render Resources Data
        private void tabPage6_Enter(object sender, EventArgs e)
        {
            getResourcesData();
        }

        private void getResourcesData()
        {
            jsonResources = getRestData("/resources/");
            resources = JToken.Parse(jsonResources).ToObject<Resource>();

            if (resourcesFlowPanel.Controls.Count == 0)
            {
                //these functions get the data and then have separate forms that popup when buttons on the Resources page are clicked
                getStudyAbroadInfo();
                getStuddentServices();
                getForms();
                getStudentAmbassadors();
                getCoopEnrollment();
                getTutoringAndLabInfo();
            }
        }

     
        private void getStudyAbroadInfo()
        {
            studyAbroad = resources.studyAbroad;
            Button button = new Button();
            button.Text = studyAbroad.title;
            button.Name = "studyAbroad";
            button.Width = 250;
            button.Height = 150;
            button.BackColor = Color.WhiteSmoke;
            button.ForeColor = Color.OrangeRed;
            button.MouseHover += reserch_area_MouseHover;
            button.MouseLeave += research_area_MouseLeave;
            button.Click += studyAbroadClick;
            resourcesFlowPanel.Controls.Add(button);
        }

        private void studyAbroadClick(object sender, EventArgs e)
        {            
            foreach (var place in studyAbroad.places)
            {
                var places_studyabroad = new Places_StudyAbroad(place.nameOfPlace, place.description);
                places_studyabroad.Show();
            }
        }


        private void getStuddentServices()
        {
            studentServices = resources.studentServices;
            Button button = new Button();
            button.Text = studentServices.title;
            button.Name = "studentServices";
            button.Width = 250;
            button.Height = 150;
            button.BackColor = Color.WhiteSmoke;
            button.ForeColor = Color.OrangeRed;
            button.MouseHover += reserch_area_MouseHover;
            button.MouseLeave += research_area_MouseLeave;
            button.Click += studentServicesClick;
            resourcesFlowPanel.Controls.Add(button);
        }

        private void studentServicesClick(object sender, EventArgs e)
        {
            var student_services = resources.studentServices;

            string advising_desc = student_services.academicAdvisors.description;
            string advising_faq_link = student_services.academicAdvisors.faq.contentHref;
                       
            var faculty_advising_desc = studentServices.facultyAdvisors.description;

            var professional_advisors = studentServices.professonalAdvisors.advisorInformation;

            var ist_minor_advisors = studentServices.istMinorAdvising.minorAdvisorInformation;

            var studentServices_page = new Student_Services(advising_desc, advising_faq_link,faculty_advising_desc,professional_advisors,ist_minor_advisors);
            studentServices_page.Show();

        }
        private void getForms()
        {
            forms = resources.forms;
            Button button = new Button();
            button.Text = "Forms";
            button.Name = "forms";
            button.Width = 250;
            button.Height = 150;
            button.BackColor = Color.WhiteSmoke;
            button.ForeColor = Color.OrangeRed;
            button.MouseHover += reserch_area_MouseHover;
            button.MouseLeave += research_area_MouseLeave;
            button.Click += formsClick;
            resourcesFlowPanel.Controls.Add(button);
           
        }

        private void formsClick(object sender, EventArgs e)
        {
            List<GraduateForm> graduate_forms = forms.graduateForms;
            List<UndergraduateForm> undergraduate_forms = forms.undergraduateForms;
            var ist_forms = new IST_Forms(graduate_forms,undergraduate_forms);
            ist_forms.Show();
        }

        private void getStudentAmbassadors()
        {
            studentAmbassadors = resources.studentAmbassadors;
            Button button = new Button();
            button.Text = "Student Ambasssadors";
            button.Name = "studentAmbassadors";
            button.Width = 250;
            button.Height = 150;
            button.BackColor = Color.WhiteSmoke;
            button.ForeColor = Color.OrangeRed;
            button.MouseHover += reserch_area_MouseHover;
            button.MouseLeave += research_area_MouseLeave;
            button.Click += studentAmbassadorsClick;
            resourcesFlowPanel.Controls.Add(button);
        }

        private void studentAmbassadorsClick(object sender, EventArgs e)
        {
            List<SubSectionContent> contents = studentAmbassadors.subSectionContent;
            string applFormlink = studentAmbassadors.applicationFormLink;
            string note = studentAmbassadors.note;

            var studentAmbassadorsPage = new Student_Ambassadors(contents, applFormlink, note);
            studentAmbassadorsPage.Show();


        }

        private void getCoopEnrollment()
        {
            coopEnrollment = resources.coopEnrollment;
            Button button = new Button();
            button.Text = "Co-op Enrollment";
            button.Name = "coopEnrollment";
            button.Width = 250;
            button.Height = 150;
            button.BackColor = Color.WhiteSmoke;
            button.ForeColor = Color.OrangeRed;
            button.MouseHover += reserch_area_MouseHover;
            button.MouseLeave += research_area_MouseLeave;
            button.Click += coopEnrollmentClick;
            resourcesFlowPanel.Controls.Add(button);
        }

        private void coopEnrollmentClick(object sender, EventArgs e)
        {
            List<EnrollmentInformationContent> enrollmentInfo = coopEnrollment.enrollmentInformationContent;
            string jobzoneGuideLink = coopEnrollment.RITJobZoneGuidelink;

            var coopEnrollementPage = new Coop_Enrollment(enrollmentInfo, jobzoneGuideLink);
            coopEnrollementPage.Show();
        }


        private void getTutoringAndLabInfo()
        {
            tutoringAndLabInfo = resources.tutorsAndLabInformation;
            tutorsDesc.Text = tutoringAndLabInfo.description;
            tutorsLabsScheduleLink.LinkClicked += (sender, EventArgs) => { ScheduleLinkClicked(sender, EventArgs, tutoringAndLabInfo.tutoringLabHoursLink); };

        }

        private void ScheduleLinkClicked(object sender, LinkLabelLinkClickedEventArgs eventArgs, string tutoringLabHoursLink)
        {
            System.Diagnostics.Process.Start(tutoringLabHoursLink);
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void employmentDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void peopleFlowLayout_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void faculty_title_Click(object sender, EventArgs e)
        {

        }

        private void faculty_email_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AboutTab_Click(object sender, EventArgs e)
        {

        }
    }
}
