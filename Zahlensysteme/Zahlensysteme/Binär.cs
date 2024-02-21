using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensysteme
{
    public class Binär
    {
        /*
        public string binär(int zahl)
        {
            string binärZahl = "0";

            if (zahl % 64 > 0)
            {
                binärZahl = binärZahl + "1";
                zahl = zahl - 64;
            }
            else
            {
                binärZahl = binärZahl + "0";
            }
            if (zahl % 32 > 0)
            {
                binärZahl = binärZahl + "1";
                zahl = zahl - 32;
            }
            else
            {
                binärZahl = binärZahl + "0";
            }
            if (zahl % 16 > 0)
            {
                binärZahl = binärZahl + "1";
                zahl = zahl - 16;
            }
            else
            {
                binärZahl = binärZahl + "0";
            }
            if (zahl % 8 > 0)
            {
                binärZahl = binärZahl + "1";
                zahl = zahl - 8;
            }
            else
            {
                binärZahl = binärZahl + "0";
            }
            if (zahl % 4 > 0)
            {
                binärZahl = binärZahl + "1";
                zahl = zahl - 4;
            }
            else
            {
                binärZahl = binärZahl + "0";
            }
            if (zahl % 2 > 0)
            {
                binärZahl = binärZahl + "1";
                zahl = zahl - 2;
            }
            else
            {
                binärZahl = binärZahl + "0";
            }
            if (zahl % 1 > 0)
            {
                binärZahl = binärZahl + "1";
                zahl = zahl - 1;
            }
            else
            {
                binärZahl = binärZahl + "0";
            }

            return binärZahl;
        }
            
        */

        public string ConvertToBinary(int zahl)
        {
            StringBuilder binäreZahl = new StringBuilder();

            for (int ziffer = 9; ziffer >= 0; ziffer--)
            {
                int jetztigeZiffer = (int)Math.Pow(2, ziffer);

                if (zahl >= jetztigeZiffer)
                {
                    binäreZahl.Append("1");
                    zahl -= jetztigeZiffer;
                }
                else
                {
                    binäreZahl.Append("0");
                }
            }

            return binäreZahl.ToString();
        }
    }
}
