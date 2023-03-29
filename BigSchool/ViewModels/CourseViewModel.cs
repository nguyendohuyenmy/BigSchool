﻿using BigSchool.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            string dateTimeString = string.Format("{0} {1}", Date, Time);
            return DateTime.ParseExact(dateTimeString, "dd/MM/yyyy H:mm", CultureInfo.InvariantCulture);
        }
    }
}