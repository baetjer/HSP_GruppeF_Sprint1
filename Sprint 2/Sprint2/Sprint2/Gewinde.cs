using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class Gewinde
    {
        int input_gewinde = 0;


        public void test_gewinde()
        {
            try
            {
                input_gewinde = Convert.ToInt32(Console.ReadLine());
                while ((input_gewinde != 0) && (input_gewinde != 1))
                {
                    Console.WriteLine("Falsche Eingabe, bitte wählen Sie nochmal.");
                    input_gewinde = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Falsche Eingabe");
                test_gewinde();
            }
        }

        public int getInput_Gewinde()
        {
            return input_gewinde;
        }

        
    }
}
