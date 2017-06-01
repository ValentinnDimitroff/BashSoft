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
            //IOManager.TraverseDirectory(@"C:\Local Disc D\Repos\BashSoft\StoryMode");
            //IOManager.ChangeCurrentDirectoryAbsolute(@"C:\Windows");
            //IOManager.TraverseDirectory(@"C:\Windows");
            
            //StudentsRepository.InitilizeData();
            //StudentsRepository.GetAllStudentsFromCourse("Unity");
            //StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");

            //Tester.CompareContent(@"C:\Local Disc D\test\test2.txt", @"C:\Local Disc D\test\test3.txt");
            IOManager.CreateDirectoryInCurrentFolder("pesho");
            IOManager.TraverseDirectory(2);
        }
    }
}
