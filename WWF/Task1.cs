using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WWF
{

    internal class WorkWitFiles
    {
        public void DeleteUnisingFiles()
        {

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Folder");
            var rootDir = new DirectoryInfo(path);

            if (!rootDir.Exists) throw new Exception("Папка не существует");
            Console.WriteLine("Папки: ");

            var dirs = rootDir.GetDirectories();

            foreach (var dir in dirs)
            {
                Console.WriteLine(dir.FullName);
                Console.WriteLine();

            }

            var files = rootDir.GetFiles("*", SearchOption.AllDirectories);
            var filesForDeleting = new List<string>();

            foreach (var file in files)
            {
                Console.WriteLine();
                Console.WriteLine(file.FullName);

                if (HowLongAgoUsed(rootDir))
                {
                    filesForDeleting.Add(file.FullName);
                }

            }
            PrintItems.ConfirmDeleting(filesForDeleting);


        }

        private bool HowLongAgoUsed(DirectoryInfo rootDir)
        {
            var span = TimeSpan.FromMinutes(30);
            return DateTime.Now - rootDir.LastAccessTime > span;
        }
    }
}
