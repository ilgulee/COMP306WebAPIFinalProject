namespace SoftwareEngineeringTechnologyCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCoursesTableSemester2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
              "VALUES ('COMP-122','Introduction to Database Concepts','Progress Campus', 2, 1, " +
              "'This course introduces students to relational database concepts, as related to personal, client server, and enterprise database systems. Topics will include data types, table structure, and relationships, data access queries using QBE grid and SQL, normalization, and database security. These concepts will be reinforced using Microsoft Access for lab work and group term project. Oracle will also be briefly introduced and used for queries. Microsoft Visio will be used as the diagramming tool to create ERDs.'," +
              "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-123','Programming 2','Progress Campus', 2, 1, " +
                "'In Programming II, students will learn the fundamentals of object-oriented programming (OOP) concepts including data abstraction, inheritance and polymorphism. Students will learn to design, code and document object-oriented programs. The concepts in COMP123 will be presented using both Console and Windows-based application.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-125','Software Engineering Methodologies 1','Progress Campus', 2, 1, " +
                "'Client-Side Web Development is the second course in a sequence of courses (COMP213, COMP125, COMP229, and a range of?elective advanced web courses) designed to teach students all the important current concepts and?technologies related to developing powerful Internet applications.?In this course the student will learn how to use both basic JavaScript syntax and its more advanced features like OOP, DOM, touch and mobile interfaces, Ajax, jQuery to build professional quality web applications.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-225','College Communications 2','Progress Campus', 2, 1, " +
                "'This project-based course emphasizes Business Analysis. Students are introduced to Software Development methodologies and Development Cycle (SDLC) namely Agile, Unified Process and SCRUM. Business and Users Requirements analysis employ UML standards in illustrating workflows and Use Cases through Activity diagrams and Use Cases diagrams. The Domain class model is also covered. Information systems context and examples are drawn from real life cases in business, health and games. Students will work in groups in a 3-part project in which introductory concepts in Project Management are covered.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-301','Unix/Linux Operating Systems','Progress Campus', 2, 1, " +
                "'This course covers basic operating system concepts using Linux. Coursework emphasizes File management, UNIX utilities and developing scripts. Students will be introduced to basic system administration, BASH scripting, PHP programming and web development on a Linux operating system.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('MATH-185','Discrete Mathematics','Progress Campus', 2, 1, " +
                "'This is a first-year mathematics course in discrete mathematics. Through classroom instruction, students will study the fundamental mathematics required to solve related problems encountered in computer systems. As well, students will be introduced to combinatorics and probability. Students will also be familiarized with various concepts in mathematical logic.'," +
                "2,1)");
        }
        
        public override void Down()
        {
        }
    }
}
