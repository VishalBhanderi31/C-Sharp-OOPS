﻿using System.Collections.Generic;
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
            var textOne = new TextOne();
            Shape shape = textOne;






        }
    }
}
