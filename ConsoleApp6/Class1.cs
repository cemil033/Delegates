using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class DocProgram
    {
        virtual public  void OpenDoc()
        {
            Console.WriteLine("Doc opened");
        }
        virtual public void EditDoc()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }
        virtual public void SaveDoc()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }
    public class ProDocProgram : DocProgram
    {
        public override void OpenDoc()
        {
            Console.WriteLine("Doc opened");
        }
        public override sealed void EditDoc()
        {
            Console.WriteLine("Document Edited");
        }

        public override void SaveDoc()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");

        }
    }
    public class ExpertDocProgram : ProDocProgram
    {
        public override void OpenDoc()
        {
            base.OpenDoc();
        }

        public override void SaveDoc()
        {
            Console.WriteLine("Doc saved in pdf format");
        }
        public void EditDoc()
        {
            Console.WriteLine("Doc edited");
        }
    }
}
