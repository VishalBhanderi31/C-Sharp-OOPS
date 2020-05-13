using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOPS
{
    //its like a power-point application

    class Program
    {
        static void Main(string[] args)
        {
            //Test Inheritance
            //var text = new Text {Width = 10f}; // Here we use ObjectInitializer to use Width property
            //text.Copy();


            //Test Composition
            /*var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();*/

            //AccessModifier Check

            //ConstructorInheritance

            //var car = new Car("XYZ1234");

            //Upcasting and Downcasting
            //var textOne = new TextOne();
            //Shape shape = textOne;

            var stack = new Stack();
            const int startPoint = 1;
            const int endPoint = 5;


            for (var i = startPoint; i <= endPoint; i++)
            {
                stack.Push(i);
            }

            stack.Clear();
            

            for (var j = startPoint; j <= endPoint; j++)
            {
                Console.WriteLine(stack.Pop());
            }

            stack.Push(0);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
