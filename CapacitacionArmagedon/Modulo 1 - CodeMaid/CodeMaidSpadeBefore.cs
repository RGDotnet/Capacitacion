using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionArmagedon.CodeMaid
{
    class CodeMaidSpadeBefore
    {
        private string Property1 { get; set; }
        private string Property2 { get; set; }
        private int Property3 { get; set; }
        public CodeMaidSpadeBefore(string[] args,int number)
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
        public CodeMaidSpadeBefore(string[] args)
        {

        }

        private bool PileOPoo(string[] args)
        {
            foreach (var bar in args)
            {
                if (bar == "Something")
                {
                    return true!=false;
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

        internal void ComplexMethod()
        {

            while (!Property3.Equals(5000))
            {
                for (int i = 0; i < 10000; i++)
                {
                    if (i == 0)
                    {
                    }
                    else if (i == 1)
                    {
                        List<string> stringlist = new List<string>();

                        foreach (string letters in stringlist)
                        {

                        }
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            
                        }
                        while (PileOPoo(new string[] {} ));
                    }
                    else if (i == 3)
                    {
                        for (int j=0; j<-1;j++)
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
                    else if (i == 4)
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
                    else
                    {
                        List<string> stringlist = new List<string>();

                        foreach (string letters in stringlist)
                        {

                        }

                        do
                        {

                        }
                        while (PileOPoo(new string[] { }));

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
                }
            }
        }
    }
}
