using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUl
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\users\opilane\source\repos\titpe21\FileSystem";

            //string[] dirs = Directory.GetDirectories(rootPtah, "*", SearchOption.AllDirecories

            //foreach (string dir in dirs) {
            //{
            // Console.WriteLine(dir);
            //}


            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);

            //   foreach (string file in files)
            //   {
            //       //Console.WriteLine(file);
            //       //Console.WriteLine(Path.GetFileName(file));
            //       //Console.WriteLine(Path.GetFileNameWithoutExtensions(file));
            //       //Console.WriteLine(Path.GetFullPath(file));
            //     //var info = new FileInfo(file);
            //
            //     //Console.WriteLine($"{ Path.GetFileName(file)}: { info.Length} bytes");
            // }

            //   string newPath = @"C:\users\opilane\source\repos\titpe21\FileSystem\SubFolderC\SubSubFolderD";
            //   bool directoryExists = Directory.Exists(newPath);

            //  if (directoryExists)
            // {
            //      Console.WriteLine("The directory does not exists");
            // }
            //   else
            //  {
            //      Console.WriteLine("The directory does not exists");
            //      Directory.CreateDirectory(newPath);
            // }


            string[] Files = Directory.GetFiles(rootPath);
            string destinationFolder = @"C:\users\opilane\source\repos\titpe21\FileSystem\SubFolderA\";

            //  foreach (string file in files)
            // {
            //      File.Copy(file, $"{destinationFolder}{ Path.GetFileName(file) }", true);
            // }

            //   for (int i = 0; i < files.Length; i++)
            // {
            //      File.Copy(files[i], $"{destinationFolder}{ i }.txt", true);
            // }

            //  foreach (string file in files)
            // {
            //      File.Move(file, $"{destinationFolder}{ Path.GetFileName(file) }");
            // }

            var files = Directory.GetFiles(rootPath, "*folder*.*", SearchOption.AllDirectories);

            foreach (string file in Files)
            {
                Console.WriteLine(file);
                //Console.WriteLine(Path.GetFileName(file));
                //Console.WriteLine(Path.GetFileNameWithoutExtensions(file));
                //Console.WriteLine(Path.GetFullPath(file));
                //var info = new FileInfo(file);

                //Console.WriteLine($"{ Path.GetFileName(file) }: { info.Length } bytes");

            }
            Console.ReadLine();
        }


    }
}
