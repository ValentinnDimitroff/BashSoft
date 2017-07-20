namespace BashSoft.Contracts
{
    using System.Collections.Generic;

    public interface Course
    {
        string Name { get; }

        IReadOnlyDictionary<string, Student> StudentsByName { get; }

        void EnrollStudent(Student student);
    }
}



