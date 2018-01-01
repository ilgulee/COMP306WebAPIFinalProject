namespace SoftwareEngineeringTechnologyCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCoursesTableSemester3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
              "VALUES ('COMP-214','Advanced Database Concepts','Progress Campus', 3, 1, " +
              "'This course is intended to expand students knowledge of business database systems. The course starts with introducing students to the steps required to install an Oracle 10g database and developer system. Then, it expands on the students knowledge of SQL by introducing more complex syntax than that covered in the first database course, as well introducing Oracle Form Builder and Report Builder utilities to create applications. Topics covered include SQL functions to manipulate numbers, dates, and character strings, grouping, conversion and transformation functions, advanced queries, advanced data and table manipulation commands, basic oracle security, PL/SQL triggers, functions, procedures, and packages, an introduction to Oracle Form Builder, and an introduction to Oracle report builder.'," +
              "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-228','Java Programming','Progress Campus', 3, 1, " +
                "'Building on fundamentals of Object-Oriented programming, this course covers Component-based Application Development and Database Connectivity using the Java programming language. Coursework emphasizes how to create complex GUI applications with Java programming language, interacting with the databases using JDBC, and Java collections framework.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-229','Web Application Development','Progress Campus', 3, 1, " +
                "'Adv. Web Application Development is the second course in a sequence of courses, following COMP213 and COMP 125 and preceding a range of advanced elective Web applications and Web services courses, designed to teach students all the important current concepts and technologies related to developing powerful Internet enterprise applications. In this third Web course the student will learn how to develop advanced Web applications that interact with databases.The major topics covered in COMP229 are server - side scripting using ASP.NET, developing multi-tier Web applications that connect to client-server databases to retrieve business information and display the results in various browsers, securing and deploying complex data-driven application on production servers. Students will be introduced to ASP.NET MVC Framework.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-246','Object Oriented Software Engineering','Progress Campus', 3, 1, " +
                "'This course builds on COMP225 Software Engineering Methodologies I. Students will continue to develop the problem solving skills required of a Systems Analyst through the analysis and design of business, health and gaming systems. The course emphasizes the iterative and incremental nature of the software development process best illustrated by Agile Modelling and Unified Process techniques currently being practised. The project work is critical as it follows the OOAD phases of inception, elaboration, construction and transition and it provides hands-on training, prototyping and testing of OO models developed by the student group. The essential requirements over the phases include: A requirements model/business model, use case model, business logic model, data models along with component and deployment diagrams; all of which will enhance the learning experience. All diagrams are UML-based and a Visual Modelling CaseTool is used extensively to prepare such diagrams. Students will also use a project management tool in managing the deliverables. This course provides the necessary preparation for a software development project.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('ENGL-253','Advanced Business Communications','Progress Campus', 3, 1, " +
                "'ENGL-253 is a senior level English course that explores the written and oral communication tasks that people in accounting and related fields encounter at work. It is intended for students who have mastered basic essay-writing skills (COMM-170 level). Its emphasis is on the strategies and formats that lead to effective communication: writing the solution, packaging the solution, and presenting the solution. Writing formats studied include letters, memoranda and reports. Instruction and practice in informal and formal public speaking are also provided. Students are presented with problem-solving tasks that will yield a variety of products : identifying problems, framing potential solutions, resolving problems, and presenting the results of their research in clear and effective ways.'," +
                "3,0)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('GNED-500','Global Citizenship: From Social Analysis to Social Action','Progress Campus', 3, 1, " +
                "'Global citizenship provides students with an opportunity to gain the knowledge and skills required to live and work in a world that is globally interconnected. Students will examine and critically analyze social problems, gain an understanding of identity and values, develop an awareness of media conglomeration, power, and control, and investigate issues of equality and equity using different perspectives to develop a plan for social action that will bring about positive change. This course allows students to develop a sound understanding of what it means to be a global citizen, both personally and professionally, and the ways in which they can make a contribution to an equitable society and world.'," +
                "3,0)");
        }
        
        public override void Down()
        {
        }
    }
}
