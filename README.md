
# Institute Supervision Setup - ISS

The Institute Supervision Setup Software is a comprehensive management system designed to streamline administrative tasks and enhance efficiency in educational institutions. This software provides robust features for managing student and staff details, attendance tracking, salary calculations, communication, and reporting.


## Features

### Student Management: 
Easily manage student records including personal details, academic information, and attendance records.

### Staff Management: 
Efficiently maintain staff information, including personal details, employment history, and attendance tracking.

### Attendance Tracking: 
Track student and staff attendance with ease using intuitive interfaces and automated processes.

### Dynamic Salary Calculations: 
Automate salary calculations for staff based on attendance, fee collections, exam schedules, and performance results.

### Birthday Wishes: 
Send personalized birthday wishes to students, fostering a positive and engaging atmosphere within the institute.

### Communication: 
Send SMS and WhatsApp messages to students, staff, and parents for important announcements, reminders, and updates.

### Reports: 
Generate comprehensive reports on attendance, salary calculations, fee collections, exam results, and more to facilitate informed decision-making and analysis.


## Requirements

### Operating System: 
Windows (compatible with Windows 7, 8, 10)

### Minimum Hardware Requirements: 
Intel Core i3 processor, 4GB RAM, 500GB HDD
## Prerequisites

Before installing the Institute Supervision Setup Software (ISS), ensure that you have the necessary prerequisites installed. These may include:

### Database: 
- SQL Server 2014
- Microsoft SQL Server Management Studio (SSMS)

### SAP Crystal Reports: 
- SAP Crystal Reports for Visual studio 2015.
- SAP Crystal Reports runtime.

### .Net Framework
- .NET Framework (4.5.2)

Download and install these prerequisites from their respective official websites.
## Installation

### Download Prerequisites:
Before installing the Institute Supervision Setup Software (ISS), ensure that you have the necessary prerequisites installed. 

### 1. Add Database to SQL Server:
- Open SQL Server Management Studio.
- Navigate to "Databases" and select "Add New".
- Choose the option to add a database from your system and select the provided database file (dbSMS).
- Follow the prompts to complete the database addition process.

### 2. Install Institute Supervision Setup (ISS):
- Download the ISS setup file from the provided link.
- Run the setup wizard and proceed with the installation.
- Complete the installation by following the on-screen instructions.
### 3. Initial Setup:
- After successful installation, launch the Institute Supervision Setup Software.
#### Provide the following information:
- Server Name: Your PC name followed by \SQLEXPRESS (e.g., PCNAME\SQLEXPRESS)
- Database Name: dbSMS
- Username: If you specified a username during SQL Server installation, enter it here. Otherwise, leave it blank.
- Password: If you specified a password during SQL Server installation, enter it here. Otherwise, leave it blank and check the "Integrated Security" checkbox.
- Save the settings and restart the application.
### 4. Login:
Upon restarting, the login page will appear.
- Select the default campus name from the dropdown menu.
#### Enter the admin credentials:
- Username: admin
- Password: admin
- Click "Login" to access the software.