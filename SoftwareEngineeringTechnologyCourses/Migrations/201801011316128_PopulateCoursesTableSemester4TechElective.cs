namespace SoftwareEngineeringTechnologyCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCoursesTableSemester4TechElective : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-387','Clinical Workflow and IT Solutions','Progress Campus', 4, 1, " +
                "'This course is a survey of fundamental concepts and activities on clinical workflow and information technology solution as applied to health care and electronic health records. Topics include but are not limited to EHR systems, Management of information in Healthcare organizations, and Project Management for health IT delivery.'," +
                "1,2)");
            Sql("INSERT INTO Courses (Code, Title, Location, Semester, IsOpen, Description, LectureHours, LabHours)" +
                "VALUES ('COMP-397','Web Game Programming','Progress Campus', 4, 1, " +
                "'This course will cover a basic understanding of the tools and development methodologies used for creating industry standard Web Games. The course has a hands-on, programming and development approach and it uses some of the best HTML5/JavaScript game engines currently available. Concepts of game state, game logic, user input, sprite animation, primitive artificial intelligence will be taught via hands-on examples. The games built will cover a variety of 2D game genres and game mechanics.'," +
                "0,0)");

        }

        public override void Down()
        {
        }
    }
}
