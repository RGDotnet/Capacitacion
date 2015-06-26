using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionArmagedon.CodeMaid
{
    class CodeMaidSpadeAfter
    {
        private string Property1 { get; set; }
        private string Property2 { get; set; }
        private int Property3 { get; set; }
        public CodeMaidSpadeAfter(string[] args, int number)
        {
            Property1 = args[0];
            Property2 = args[1];
            Property3 = Convert.ToInt32(args[2]);
            var bar = Math.Acos(Convert.ToDouble(number)) * Property3;
            if (bar > 0)
            {
                //TODO: place logic here
            }
            else
            {
                PileOPoo(args);
            }
        }
        public CodeMaidSpadeAfter(string[] args)
        {

        }

        private bool PileOPoo(string[] args)
        {
            foreach (var bar in args)
            {
                if (bar == "Something")
                {
                    return true != false;
                }
                else if (bar == "AnotherThing")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false != (true != false);
        }

        internal void ComplexMethod() //Ahora ya no es tan complejo.
        {

            while (!Property3.Equals(5000))
            {
                for (int i = 0; i < 10000; i++)
                {
                    //Método Refactorizado
                    SwitchI(i);
                }
            }
        }

        private void SwitchI(int i)
        {
            switch (i)
            {
                case 0: break;
                case 1:
                    //Método Refactorizado
                    LettersStringList();
                    break;
                case 2:
                    //Método Refactorizado
                    DoWhilePileOPoo();
                    break;
                case 3:
                    //Metodo Refactorizado
                    IterateOverJ();
                    break;
                case 4:
                    //Método Refactorizado
                    Matrix3By3();
                    break;
                default:
                    //Método Refactorizado
                    LettersStringList();

                    //Método Refactorizado
                    DoWhilePileOPoo();

                    //Metodo Refactorizado
                    IterateOverJ();

                    //Método Refactorizado
                    Matrix3By3();
                    break;
            }
        }

        private static void Matrix3By3()
        {
            for (int l = 0; l < 100; l++)
            {
                for (int j = 0; j < 100; j++)
                {
                    for (int k = 0; k < 100; k++)
                    {

                    }
                }
            }
        }

        private static void IterateOverJ()
        {
            for (int j = 0; j < -1; j++)
            {
                while (true)
                {
                    if (j == 0)
                    {
                    }
                    else if (j < -1)
                    {
                        break;
                    }
                    else
                    {
                    }
                }
            }
        }

        private void DoWhilePileOPoo()
        {
            do
            {

            }
            while (PileOPoo(new string[] { }));
        }

        private static void LettersStringList()
        {
            List<string> stringlist = new List<string>();

            foreach (string letters in stringlist)
            {

            }
        }
    }
}
