using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            students = new List<Student>();
        }

        public int Capacity { get; set; }
        public int Count => this.students.Count;

        public string RegisterStudent(Student student)
        {
            if (Capacity > students.Count)
            {
                this.students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return $"No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student studentToBeDismissed = this.students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (studentToBeDismissed != null)
            {
                this.students.Remove(studentToBeDismissed);
                return $"Dismissed student {studentToBeDismissed.FirstName} {studentToBeDismissed.LastName}";
            }

            return "Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            Student[] studentsWithThatSubject = this.students.Where(s => s.Subject == subject).ToArray();

            Student studentWithThatSubject = this.students.FirstOrDefault(s => s.Subject == subject);

            if (studentWithThatSubject != null)
            {
                StringBuilder subjectResult = new StringBuilder();
                subjectResult.AppendLine($"Subject: {subject}");
                subjectResult.AppendLine("Students:");
                foreach (var student in studentsWithThatSubject)
                {
                    subjectResult.AppendLine($"{student.FirstName} {student.LastName}");
                }

                return subjectResult.ToString().TrimEnd();
            }

            return $"No students enrolled for the subject";
        }

        public int GetStudentsCount()
        {
            return this.students.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student ourStudent = this.students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            return ourStudent;
        }
    }
}
