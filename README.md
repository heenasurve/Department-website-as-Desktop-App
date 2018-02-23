# Department-website-as-Desktop-App
Consumed a REST Service in C# to build a Windows Desktop Application using Windows Forms. 
I built the desktop app experience as an alternative to the conventional website experience for the department website.

The following sections of the API have been consumed:
	1. About
			Description
			Quote
			QuoteAuthor
	2. Degrees - all child nodes and their fields
			Undergraduate 
			Graduate
				Their description and the concentrations
	3. Minors 
			Title
			Description
			Courses for each minor
	4. Employment 
			Degree Statitics
			Employers
			Careers
			Cooptable
			Employment table
			MAP
	5. People - 
			Faculty
			Staff
				includes all information except their facebook and twitter pages
	6. Research
			By InterestArea
			By faculty
	7. Resources
			Study Abroad
			Student Services
			Tutors and Lab information
			Student Ambassadors
			Forms
			Coop Enrollment
	8. News
			By Quarter
			By Year
			Older
	9. Footer
			Social
			Quick Links
			Copyright
			News
	10. Contact Form
	

Where all of this data lies/shows up:

	1. About Tab
			All the data from the About section of the API 
			The news button opens up a popup with all the news
			All the data from the Footer section of the API is accessible on clicking buttons under the News button
			The social data from the Footer section is also on this page
			The Contact form is also accessible from here
			
	2. Degrees and Minors  Tab
			Undergraduate Degrees - clicking on the course buttons on the left displays the description and concentrations on the right
			Graduate Degrees - clicking on the course buttons on the left displays the description and concentrations on the right
			Graduate Advanced Certificates - Displays all available
			Minors - data from the Minors section of the API shows up here
				Clicking on a minor on the left displays its description on the right along with the courses on the bottom right
				Each of these course links is clickable - course information shows up in a window
	
	3. Employment Tab
			Shows all of the data from the Employment section of the API
			The button on the bottom right that reads "Where our students work !" opens up the map on being clicked
	
	4.People Tab
			The left panel first shows buttons with all the Faculty members 
			The 2 buttons on the top load up faculty members or staff members on being clicked
			Clicking on a button with a faculty/staff member displays more details about that person on the right
	
	5.Research Tab
			The left panel first shows buttons with all the research/interest areas
			The 2 buttons on the top load up interest areas or faculty members on being clicked
			Clicking on a button with a interest area/faculty member displays the corresponding list of publications
			
	6. Resources Tab
			The 5 buttons rendered on the top open up popups 
			Clicking on:
				Study Abroad displays a separate window for each place returned by the API
				Forms displays a popup with garduate and undergraduate forms
					As of when this project is submitted - the first  2 grad forms and the 1st undergrad form are downloaded/displayed- the other redirect to the IST website - the form URL is probably not updated
				Advising opens up a popup that has a tabbed pane with all data from the API
				Student Ambassadors and Coop Enrollment - open up windows with corresponding information and links
				Tutoring and lab information is on the Resources page itself
	
				
			
		
		
		
