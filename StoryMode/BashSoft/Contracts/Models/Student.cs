namespace BashSoft.Contracts
{
    using System.Collections.Generic;

    public interface Student
    {
        string Username { get; }

        IReadOnlyDictionary<string, Course> EnrolledCourses { get; }

        IReadOnlyDictionary<string, double> MarksByCourseName { get; }

        void EnrollInCourse(Course course);

        void SetMarkOnCourse(string courseName, params int[] scores);
    }
}
