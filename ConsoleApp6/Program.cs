
public delegate void delegats();
namespace ConsoleApp6 {    
    class Program {
        static void Main(string[] args) {
            delegats deleg;
            DocProgram docs;
            string? t = Console.ReadLine();

            if (t == "basic")
            {
                docs = new DocProgram();
                deleg = new(docs.OpenDoc);
                deleg += docs.EditDoc;
                deleg += docs.SaveDoc;
                deleg.Invoke();
            }
            else if(t == "pro")
            {
                docs = new ProDocProgram();
                deleg = new(docs.OpenDoc);
                deleg += docs.EditDoc;
                deleg += docs.SaveDoc;
                deleg.Invoke();
            }
            else if (t == "expert")
            {
                docs = new ExpertDocProgram();
                deleg = new(docs.OpenDoc);
                deleg += docs.EditDoc;
                deleg += docs.SaveDoc;
                deleg.Invoke();
            }
        }
    }
}