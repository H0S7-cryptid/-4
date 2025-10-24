using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Практика_4
{
    public class Student
    {
        private readonly string _defaultFirstName = "Unknown_F";
        private readonly string _defaultLastName = "Unknown_L";
        private readonly string _defaultMiddleName = "Unknown_M";
        private readonly DateOnly _defaultBirthDate = new(2001, 1, 1);
        private readonly Int16 _defaultCourse = 1;
        private readonly string _defaultGroupName = "TTT-000";

        private string _firstName;
        private string _lastName;
        private string _middleName;
        private DateOnly _dateOfBirth;
        private Int16 _course;
        private string _groupName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrEmpty(value)) value = _defaultFirstName;
                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrEmpty(value)) value = _defaultLastName;
                _lastName = value;
            }
        }

        public string MiddleName
        {
            get => _middleName;
            set
            {
                if (string.IsNullOrEmpty(value)) value = _defaultMiddleName;
                _middleName = value;
            }
        }

        public DateOnly DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                if (value.Year < _defaultBirthDate.Year) value = _defaultBirthDate;
                _dateOfBirth = value;
            }
        }

        public Int16 Course
        {
            get => _course;
            set
            {
                if (value < 1 || value > 6) value = _defaultCourse;
                _course = value;
            }
        }

        public string GroupName
        {
            get => _groupName;
            set
            {
                if (string.IsNullOrEmpty(value)) value = _defaultGroupName;
                _groupName = value;
            }
                
        }

        public Student()
        {
            FirstName = _defaultFirstName;
            LastName = _defaultLastName;
            MiddleName = _defaultMiddleName;
            DateOfBirth = _defaultBirthDate;
            Course = _defaultCourse;
            GroupName = _defaultGroupName;
        }

        public Student(string firstName, string lastName, string middleName,
            DateOnly date, Int16 course, string groupName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            DateOfBirth = date;
            Course = course;
            GroupName = groupName;
        }

        public override string ToString() => $"{FirstName} {MiddleName} {LastName}, {DateOfBirth}." +
            $" {Course}-й Курс, {GroupName}";
    }
}
