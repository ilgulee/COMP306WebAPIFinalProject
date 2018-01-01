namespace SoftwareEngineeringTechnologyCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCoursesTableSemester4 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
              "VALUES ('CNET-124','Fundamentals of Computer Networks','Progress Campus', 4, 1, " +
              "'This course introduces the fundamentals of network technologies. Students are exposed to and learn basic network terminology in order to prepare for further courses in networking. Classes cover all the fundamental information behind LANs, WANs and their technologies, including an overview of network devices, the OSI and TCP models of networking and the different topologies used in networking. The Lab classes introduce students to the hands on techniques to install, configure and troubleshoot a physical network environment. Use of the program WireShark in the lab will allow for the examination of broadcast/unicast/multicast traffic, frame and packet structure (relate to OSI and TCP/IP model), three-way handshake, syn-ack, TCP and UDP data flows and sniffing an unencrypted conversation and/or authentication attempts.'," +
              "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-212','Programming 3','Progress Campus', 4, 1, " +
                "'The goal of this course is to enable students, already proficient in OOP, to build robust and more complex, data-driven Windows applications using the .NET languages. Coursework emphasizes data structures and collections in .NET, GUI programming, and database APIs. Entity Framework will be used to access and manipulate the data stored in various database servers. The language of instruction is C#.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-304','Mobile Application Development','Progress Campus', 4, 1, " +
                "'In Wireless Programming, students will gain hands-on experience in developing and deploying mobile applications on the Android platform. Coursework emphasizes how to create advanced Graphical User Interfaces (GUIs), handle events, access remote services, store and retrieve data on the device, display maps, and use other Android APIs. Android Studio will be used to create a variety of mobile applications.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-311','Software Testing and Quality Assurance','Progress Campus', 4, 1, " +
                "'This course explores the goals of quality assurance and quality control activities performed during the life cycle of a software product. It focuses on integrating test processes with agile software development methodologies. Practical exercises give experience of design, specification, execution of tests plus test automation using tools through a mixture of instructor-directed exercises and student research leading to knowledge sharing.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('ELECT','Technical Elective','Progress Campus', 4, 1, " +
                "'Not Available.'," +
                "1,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('MATH-210','Linear Algebra and Statistics','Progress Campus', 4, 1, " +
                "'This course contains topics in Linear Algebra and Statistics. Linear algebra topics include operations with matrices, inverses, determinants, and vectors. Statistics topics include descriptive statistics, probability distributions as well as inferential statistics including hypothesis testing. Students will also use software applications in solving relevant problems.'," +
                "2,2)");
        }
        
        public override void Down()
        {
        }
    }
}
