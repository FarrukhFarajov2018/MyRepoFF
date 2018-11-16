using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherHome
{
    class DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened \"Base\" ");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions ");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }

    }

    class ProDocumentProgram : DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened \"Derived\" ");
        }
        sealed public override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }

    }

    class ExpertDocument : ProDocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened \"Derived2\"");
        }
        //public override void EditDocument()//ERROR
        //{
        //	Console.WriteLine("Document Edited");
        //}
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }

    }

    enum KeyW
    {
        basic = 1,
        pro = 2,
        expert = 3
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter keyword to create object you want");
            Console.WriteLine();
            Console.WriteLine("Please enter 1 to create basic object for class DocumentProgram");
            Console.WriteLine();
            Console.WriteLine("Please enter 2 to create pro object for class ProDocumentProgram");
            Console.WriteLine();
            Console.WriteLine("Please enter 3 to create expert object for class ExpertDocument");
            Console.WriteLine();

            int number = Convert.ToInt32(Console.ReadLine());

            KeyW keyword = (KeyW)number;

            switch (keyword)
            {
                case KeyW.basic:
                    {
                        Console.Clear();
                        DocumentProgram Mybasic = new DocumentProgram();

                        Console.WriteLine();
                        Console.WriteLine("Object is created and Methods of DocumentProgram CLASS are called: ");
                        Console.WriteLine();
                        Console.WriteLine();

                        Mybasic.OpenDocument();
                        Console.WriteLine();

                        Mybasic.EditDocument();
                        Console.WriteLine();

                        Mybasic.SaveDocument();
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    break;
                case KeyW.pro:
                    {
                        ProDocumentProgram Mypro = new ProDocumentProgram();

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Object is created and Methods of ProDocumentProgram CLASS are " +
                                          "called as DOWNCAST or plain way: ");
                        Console.WriteLine();
                        Console.WriteLine();

                        Mypro.OpenDocument();
                        Console.WriteLine();

                        Mypro.EditDocument();
                        Console.WriteLine();

                        Mypro.SaveDocument();
                        Console.WriteLine();

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Methods of ProDocumentProgram CLASS are called as UPCAST way: ");
                        Console.WriteLine();
                        Console.WriteLine();

                        DocumentProgram BaseforPro = new ProDocumentProgram();

                        BaseforPro.OpenDocument();
                        Console.WriteLine();

                        BaseforPro.EditDocument();
                        Console.WriteLine();

                        BaseforPro.SaveDocument();
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    break;
                case KeyW.expert:
                    {
                        ExpertDocument Myexpert = new ExpertDocument();

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Object is created and Methods of ExpertDocument CLASS are " +
                                          "called as DOWNCAST or plain way: ");
                        Console.WriteLine();
                        Console.WriteLine();

                        Myexpert.OpenDocument();
                        Console.WriteLine();

                        Myexpert.EditDocument();
                        Console.WriteLine();

                        Myexpert.SaveDocument();
                        Console.WriteLine();

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Methods of ExpertDocument CLASS are called as UPCAST way: ");
                        Console.WriteLine();
                        Console.WriteLine();

                        DocumentProgram BaseforExpert = new ExpertDocument();

                        BaseforExpert.OpenDocument();
                        Console.WriteLine();

                        BaseforExpert.EditDocument();
                        Console.WriteLine();

                        BaseforExpert.SaveDocument();
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }








        }
    }
}
