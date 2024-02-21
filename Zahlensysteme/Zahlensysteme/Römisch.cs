using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensysteme
{
    public class Römisch
    {
        public string römisch(int zahl)
        {
            StringBuilder römischeZahl = new StringBuilder();

            int tausender = zahl / 1000;
            for (int i = 0; i < tausender; i++)
            {
                römischeZahl.Append("M");
            }
            zahl %= 1000;

            if (zahl >= 900)
            {
                römischeZahl.Append("CM");
                zahl -= 900;
            }
            
            if (zahl >= 500)
            {
                römischeZahl.Append("D");
                zahl -= 500;
            }

            if (zahl >= 400)
            {
                römischeZahl.Append("CD");
                zahl -= 400;
            }

            int hunderter = zahl / 100;
            for (int i = 0; i < hunderter; i++)
            {
                römischeZahl.Append("C");
            }
            zahl %= 100;

            if (zahl >= 90)
            {
                römischeZahl.Append("XC");
                zahl -= 90;
            }

            if (zahl >= 50)
            {
                römischeZahl.Append("L");
                zahl -= 50;
            }

            if (zahl >= 40)
            {
                römischeZahl.Append("XL");
                zahl -= 40;
            }

            int zehner = zahl / 10;
            for (int i = 0; i < zehner; i++)
            {
                römischeZahl.Append("X");
            }
            zahl %= 10;

            if (zahl >= 9)
            {
                römischeZahl.Append("IX");
                zahl -= 9;
            }

            if (zahl >= 5)
            {
                römischeZahl.Append("V");
                zahl -= 5;
            }

            if (zahl >= 4)
            {
                römischeZahl.Append("IV");
                zahl -= 4;
            }

            int einer = zahl;
            for (int i = 0; i < einer; i++)
            {
                römischeZahl.Append("I");
            }

            return römischeZahl.ToString();
        }
    }
}
