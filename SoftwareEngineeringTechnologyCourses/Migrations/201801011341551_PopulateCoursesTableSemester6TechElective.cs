namespace SoftwareEngineeringTechnologyCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCoursesTableSemester6TechElective : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
              "VALUES ('COMP-305','Game Programming 1','Progress Campus', 6, 1, " +
              "'Computer games are now one of the most popular forms of entertainment. Developing games and simulations is among the most challenging and interesting forms of programming. This course will explore the concepts and techniques of game programming and design. Coursework emphasizes comprehensive game development topics, including 3D graphics and sound. Students will learn how to develop 2D and 3D games using C# and Unity.'," +
              "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-317','Software Quality Assurance and Test Management','Progress Campus', 6, 1, " +
                "'In SQA and Test Management students will learn about software quality assurance and its importance in managing software testing and software quality. This course explores the activities and the challenges faced by test managers and how these challenges can be handled. The course topics explore topics for understanding the reasons for testing at several points during development. ?Learners will review articles reflecting industry experience and become aware of test and quality assurance practices as documented by IEEE and other associations. The course will explore the use of automated tools. ?The course assigned readings using practical industry articles will assist the use of practical examples. Definitions and theory is mostly based on industry accepted quality and testing practices Tool automation will be covered, and learner will have a project on tools that will require a class presentation.'," +
                "0,0)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-381','Tools, Algorithms and Methods for HCIS','Progress Campus', 6, 1, " +
                "'This course explores contemporary health informatics tools, algorithms and methods. Coursework emphasizes the use of HL7 as a standard for exchanging information between medical applications, the use of BI tools such as Crystal Reports and SAS for analyzing and manipulating health care data, and open source EMR software.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-382','Computer Techniques in Medical Imaging','Progress Campus', 6, 1, " +
                "'COMP382 introduces the students in the Health Informatics diploma program to the concepts involved in medical image processing. This course takes a practical approach to covering the main topics involved in the field of computer processing of medical images. First it explains core concepts related to digital images manipulation in the medical field and then it follows up with examples processed in a freely available software package. The course includes lectures, demos and discussions of the fundamental principles of segmentation, classification, registration, restoration and visualisation involved in medical image processing, followed by labs and practical assignments that re - enforce the understanding and familiarity of the students with these concepts.Special attention is given to best practices that apply to each topic covered by the course.Taught concepts are further explored and practiced through a sequence of relevant case studies.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-383',' Data Security and Privacy Policies in HCIS','Progress Campus', 6, 1, " +
                "'This course introduces the student to the issues of storing and transmitting patient information safely. The student will learn the different technologies available for encryption and signing of electronic transmissions. In the later part of the course the student will be exposed to the privacy legislations in use in Ontario and Canada. The student will also be exposed to how other jurisdictions in North America and Europe have tackled the privacy quandary.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-384','Telehealth','Progress Campus', 6, 1, " +
                "'In Telehealth, students will learn the fundamental concepts and standards involved in the successful implementation of telehealth programs. These programs rely on various communication and information technology systems to improve health care delivery by facilitating greater access to services and more efficient communication practices. In COMP384, students will explore the different types of telehealth applications, as well as the legal and regulatory considerations involved in implementing a telehealth solution. Topics covered will include an introduction to the different services targeted by telehealth initiatives and emphasis will be placed on the unique challenges, relevant industry standards and the specific information technology needs of different telehealth programs to date (i.e. teleradiology, telesurgery, telepathology, telecardiology, teledermatology, teleconsultation, teleophthalmology, telehomecare, etcetera). The course will use various methods of knowledge delivery to aid the students in understanding telehealth concepts, applications and its relevance to health care and health informatics. Teaching methods will include lectures, demos, discussions, labs, practical assignments and case studies.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-392 ','Advanced Graphics','Progress Campus', 6, 1, " +
                "'In Advanced Graphics, students learn the core computer graphics concepts that are commonly used in building modern computer games. Different 2D and 3D graphics techniques are explained and applied to building working examples of features that are very popular in todays fast expanding games industry. The course includes lectures, demos and discussions of the fundamentals of graphics for game developers, followed by labs and programming assignments that re - enforce the understanding and familiarity of the students with these concepts.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
              "VALUES ('COMP-396','Game Programming 2','Progress Campus', 6, 1, " +
              "'In Game Programming 2, students will learn, using the Unity3D framework, topics such as Finite State Machines (FSMs), Artificial Intelligence (AI), Particle Systems (PS), and Multi-Player Networked Games (MPNGs). FSMs and AI are used to build a game state engine that adds realistic (intelligent) motion to gaming objects. Particle Systems are introduced in COMP396 as backdrops to games that have common properties. Finally, an introduction to Multi-Player Networked Gaming is presented.'," +
              "2,2)");
        }
        
        public override void Down()
        {
        }
    }
}
