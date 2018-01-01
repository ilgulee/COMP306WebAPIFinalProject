namespace SoftwareEngineeringTechnologyCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCoursesTableSemester6 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
              "VALUES ('CNET-307','IT Project Management','Progress Campus', 6, 1, " +
              "'Through this capstone project students will show case the skill sets learned in the program. This course is related to CNET307 (Fundamentals of Project Management), where students plan and prepare for the Technologist Project by research, analysis, planning, costing, scheduling and resolving problems in implementing the project. Students will design a project that fulfills the specifications laid down to accomplish business objectives. They work in a team to handle the various aspects of the project and maintain clear and accurate project related documents which adhere to industry standards. During the implementation process students will go through configuration and troubleshooting exercises, using a systematic approach and diagnostic tools to solve problems. At the end of the course each team must go through hands on demonstration of the project, make an oral presentation and submit a written final report which is clear, concise and free of grammatical errors.'," +
              "2,1)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-308','Emerging Technologies','Progress Campus', 6, 1, " +
                "'This course will examine different emerging technologies in the rapidly changing world of software.Students will gain hands-on experience by using the emerging web development technologies and investigate several emerging tools in other areas of software development. Coursework in COMP308 emphasizes emerging frameworks for front-end development, emerging server-side programming environments, NoSQL databases, and Microservices.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-313','Software Development Project 2','Progress Campus', 6, 1, " +
                "'This is a capstone course for all software engineering technology programs and builds upon COMP231 course. The students are required to work in teams to design and implement a complete application or game for a small company. The project must make use of enterprise tools to build enterprise-level data integration. The project must involve teamwork, oral and written communication skills, problem solving, documentation, and research skills. Teams are allowed to select projects that fit with their specialization. Interactive Gaming students will develop a game, and Health Informatics students will select a project that focuses on health care information systems. Students are encouraged to create their teams in the previous semester.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-321','Systems Integration','Progress Campus', 6, 1, " +
                "'In this course, students will learn the concept of integration as it relates to business processes and information Technology at the Enterprise level. Systems Integration models and concepts of ERPs as cross-functional and process-based systems are demonstrated through software tools such as CRM, SCM, HRM & BI and the Cloud technology. The benefits of these tools are discussed in detail to highlight their effectiveness and efficiency in modern day business operations. UML documentary standards will be adhered to in order to maintain the OO Software Engineering paradigm approach that began in COMP246. Data models are also fundamental requirements. The term projects will center on CRMs and students will engage in the study and walk-through using free download or SaaS of popular ERP Vendor tools such Microsoft Dynamics CRM, Oracle CRM ( Siebel), Salesforce and ZOHO CRM.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('ELECT 2','Technical Elective 2','Progress Campus', 6, 1, " +
                "' '," +
                "0,0)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('EMPS-102','Employment Skills 2','Progress Campus', 6, 1, " +
                "'In Employment Skills 2 students will learn the ability to seek career opportunities and effectively market their knowledge, skills and abilities tailored to these opportunities. Students will identify and catalog work and/or voluntary experience, education and skills as employable assets and leverage these to obtain suitable employment that is consistent with their career plans and goals. This is accomplished by the following strategies: a) Prepare a Curriculum Vitae(CV)/ Resume based on job - research relevant to students respective programs b) Use of Social media c) Prepare a career portfolio d) Attend a simulated / mock job interview scenario e) Active assistance of Centennial College Career Services'," +
                "2,0)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
              "VALUES ('GNED','General Education Elective','Progress Campus', 6, 1, " +
              "'Select an elective course from your area of study.'," +
              "3,0)");
        }
        
        public override void Down()
        {
        }
    }
}
