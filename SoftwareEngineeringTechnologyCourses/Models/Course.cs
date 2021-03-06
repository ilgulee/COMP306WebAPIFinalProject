﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareEngineeringTechnologyCourses.Models
{
    /// <summary>
    /// Represents one specific course
    /// </summary>
    public class Course
    {   
        /// <summary>
        /// Id from SQL
        /// </summary>
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public int Semester { get; set; }
        public bool IsOpen { get; set; }
        public string Description { get; set; }
        public int LectureHours { get; set; }
        public int LabHours { get; set; }   

    }
}