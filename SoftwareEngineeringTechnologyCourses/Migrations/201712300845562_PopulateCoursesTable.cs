namespace SoftwareEngineeringTechnologyCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCoursesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-100','Programming I','Progress Campus', 1, 1, " +
                "'COMP100 is an introductory course in programming. It includes programming concepts, logic and program structures. It seeks to develop good coding practices and program design. It lays the foundations for the design and development of business applications; these will be tested in the C# .NET environment.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-120','Software Engineering Fundamentals','Progress Campus', 1, 1, " +
                "'This course introduces students to the common terminologies, methodologies, tools, and techniques used in software engineering which form the basis for advanced studies. Roles of teams, risk management, software testing, and software engineering code of ethics and professional practice will also be introduced.'," +
                "2,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-213','Web Interface Design','Progress Campus', 1, 1, " +
                "'Web Interface Design is the first course in a sequence of courses (COMP213, COMP229, and a range of elective advanced web courses) designed to teach students all the important current concepts and technologies related to developing powerful Internet applications. In this first level web course the student will learn how to access the resources of the Internet, use HTML and CSS to publish high-quality Web documents that observe widely accepted design guidelines, and enable web documents to share business data using XML.'," +
                "0,4)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMM-170/COMM-171','College Communications 2','Progress Campus', 1, 1, " +
                "'COMM-170 focuses on the refinement of reading and writing skills. The course emphasizes clear, correct writing based on the process of composing, revising, and editing. It will include a review of sentence structure, grammar, diction, and punctuation. All essays written in the course will be in response to assigned readings. The student will recognize and use a variety of structural and stylistic techniques, analyze audience, purpose, and tone, and develop critical reading and thinking skills. COMM-171 is the ESL equivalent to COMM-170 and is taught by a TESL (Teacher of English as a Second Language) certified professor.'," +
                "3,3)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('GNED-219','The Canadian Workplace Experience','Progress Campus', 1, 1, " +
                "'This course provides students with an opportunity to explore the study of the Canadian workplace as well as the student’s responsibility on both a local and global level. Students will learn to connect the historical factors that have influenced the Canadian workplace with a look at current and future development in Canada and on a global basis. The course identifies the types of businesses in Canada and explains the functions of these workplaces. A review of the trends evident in the Canadian workplace will also be outlined. An emphasis will be placed on current and future workplace environments within Canada and their responsibility globally. Through application and analysis students will have an opportunity to experience, on a personal and professional level, the impact of the Canadian workplace. The contents of this course will be useful for all disciplines as it encompasses the ethical responsibilities of the individual and the community at large. This course will take into consideration the various opportunities that exist for students in the larger corporate world (private/public), the non-profit sector as well as the entrepreneurial arena.'," +
                "3,0)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('MATH-175','Functions and Number Systems','Progress Campus', 1, 1, " +
                "'This is the first part of a one-year sequence in finite/discrete mathematics, taught in the Computer Systems & Networks program. Through classroom instruction and computer-based assignments students study the fundamental mathematics required to solve related problems encountered in computer systems.'," +
                "2,1)");
        }
        
        public override void Down()
        {
        }
    }
}
