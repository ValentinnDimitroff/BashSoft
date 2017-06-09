using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public class Launcher
    {
        static void Main()
        {
            //StudentsRepository.InitilizeData();
            //StudentsRepository.GetAllStudentsFromCourse("Unity");
            //StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");

            //Tester.CompareContent(@"C:\test\actual.txt", @"C:\test\expected.txt");
            //IOManager.CreateDirectoryInCurrentFolder("pesho");
            //IOManager.TraverseDirectory(2);
            
            //IOManager.ChangeCurrentDirectoryRelative("..");

            InputReader.StartReadingCommands();
        }
    }
}
