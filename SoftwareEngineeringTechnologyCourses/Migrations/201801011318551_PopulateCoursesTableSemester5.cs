namespace SoftwareEngineeringTechnologyCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCoursesTableSemester5 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
              "VALUES ('CNET-329','Business and ICT','Progress Campus', 5, 1, " +
              "'This course provides the learner with an overview of the role that networked technologies and information systems play in business operations in the early 21st Century. Material is presented in the context of ICT and web-based, architecture and e-commerce. The basic structure and internal functions of business will be reviewed, followed by an examination of the development of business systems and their integration namely enterprise resource planning systems (ERP), customer relationship management systems (CRM), supply chain management systems (SCM) and business intelligence (BI) and the role these systems play in supporting business functions and management decision making. Security and controls on the internet will be discussed. These concepts will be applied through assessment of team-driven case studies in-class and the written analysis of a business case for a real life company marketing a product or service.'," +
              "2,1)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-231','Software Development Project I','Progress Campus', 5, 1, " +
                "'This is the capstone course for Software Engineering Technician program and the first software development project course for all software engineering technology programs. The students are required to work in teams to design, implement, and document an application or a component for a hypothetical organization. This enables the student to simulate the activities of a software developer in the computer industry.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-303','Java EE Programming','Progress Campus', 5, 1, " +
                "'This course builds on Java Programming, COMP228, and covers Java EE APIs. Coursework emphasizes distributed objects, Java Web applications and Java enterprise applications for deployment to Java Application Servers. The course also covers using the Java Persistence API in Java SE and Java EE environments. Hands-on exercises use Eclipse and Wildfly 10.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-306','API Engineering and Cloud Computing','Progress Campus', 5, 1, " +
                "'Building on .NET programming and database courses, this course expose the students to the cloud computing and API technology. Coursework will emphasize how to develop/publish scalable application on Microsoft Azure as well as how to develop/deploy/consume RESTful APIs and ASP.NET Web API. Students will also explore the details of cloud components, such as Azure SQL database, Azure storage, Azure App services, Azure cloud services, Azure Webjobs, Azure Service Fabric and Azure API management service.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-307','Software Security','Progress Campus', 5, 1, " +
                "'Students enrolled in Software Security will learn how to build secure software by becoming familiar with current software security principles. Students will also examine common application security flaws, and understand how to integrate security with design, development, testing and deployment phases of the software development life cycle. COMP307 addresses the ever-growing security concerns that IT organizations face regarding their deployed software applications. Students will also learn how to implement security strategies currently used to mitigate the security risks associated with web applications and social networking.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-309','Data Warehousing and Data Mining in HCIS','Progress Campus', 5, 1, " +
                "'Businesses face a number of problems when attempting to analyze their data. Data warehousing techniques allow organizations to extract data from disparate data sources and transform it into actionable information. Data warehousing is an important foundation for business intelligence (BI). By building on the previous database and programming courses, this course covers basic data warehousing and data mining concepts and tools that can be used to create and manage data warehousing and data mining systems. Coursework will emphasize the use of data warehousing and data mining techniques in health care information systems.'," +
                "2,2)");
        }
        
        public override void Down()
        {
        }
    }
}
