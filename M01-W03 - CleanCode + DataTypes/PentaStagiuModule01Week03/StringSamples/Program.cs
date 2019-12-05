using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = " ,";
            string s3 = "World";

            // complile error because strings are imutable
            // s3[0] = 'w';

            // it doesn't change the value of the initial string, but creates
            // a new area in memory where to store the new concatenated strings
            s1 += s2;

            // same as above (third area in memory)
            s1 += s3;

            Debug.Write("Acesta e un mesaj care se afiseaza in Output");
            Debug.WriteLine("Acesta e un mesaj care se afiseaza in Output pe o linie");

            int x = 20;
            Debug.WriteIf((x > 0), "Acesta e un mesaj conditional.");
            Debug.WriteLineIf((x > 0), "Acesta e un mesaj conditional pe o linie.");

            // formatul vechi
            string regularFilePath = "C:\\Users\\Documents\\";
            // nu mai e nevoie de dublarea caracterului '\'
            string verbatimFilePath = @"C:\Users\Documents\";

            // era nevoie de '\r\n' pentru a trece la linia urmatoare
            string regularRows = "Row 1\r\nRow 2\r\nRow 3";
            // putem defini string-ul direct pe mai multe randuri
            string verbatimRows = @"Row
Row2
Row3";

            string emptyString = string.Empty;
            Debug.WriteLine("Stringul gol este: '" + emptyString + "'");

            if (string.IsNullOrEmpty(emptyString))
            {
                Debug.WriteLine("String null sau gol.");
            }
            else
            {
                Debug.WriteLine("Stringul are continut.");
            }

            // compararea stringurilor
            string nameLowerCase = "ion popescu";
            string nameUpperCase = "Ion Popescu";

            // compararea stringurilor - case sensitive
            if (string.Compare(nameLowerCase, nameUpperCase) == 0)
            {
                Debug.WriteLine("Case sensitive: Cele doua string-uri sunt egale");
            }
            else
            {
                Debug.WriteLine("Case sensitive: Cele doua string-uri sunt diferite");
            }

            // compararea stringurilor - case insensitive 
            // ultimul parametru este "ignore case"
            if (string.Compare(nameLowerCase, nameUpperCase, true) == 0)
            {
                Debug.WriteLine("Case insensitive: Cele doua string-uri sunt egale");
            }
            else
            {
                Debug.WriteLine("Case insensitive: Cele doua string-uri sunt diferite");
            }

            string firstName = "Ion";
            string lastName = "Popescu";
            string fullName = string.Concat(firstName, " ", lastName);

            string initialString = "Ana are mere";
            string resultString = initialString.Replace("mere", "pere");
            resultString = initialString.Replace('a', 'e');

            string firstString = "Ana are mere. Maria are mere, dar Ion nu are mere";
            int indexOfM = firstString.IndexOf('M');
            int indexOfMere = firstString.IndexOf("mere");
            int lastIndexOfMere = firstString.LastIndexOf("mere");

            string entireString = "Ana are mere. Maria are mere, dar Ion nu are mere";
            string deletedStringToEnd = entireString.Remove(12);
            string deletedStringPart = entireString.Remove(12, 16);

            string numberList = "12, 7, 24,3,6,13 ,6.0,200";
            string[] splitedStrings = numberList.Split(',');
            foreach (string splitString in splitedStrings)
            {
                try
                {
                    int intValue = int.Parse(splitString);
                    Debug.WriteLine(intValue);
                }
                catch
                {
                    Debug.WriteLine("Could not parse " + splitString + " to int");
                }
            }

            string text = "Ana are mere. Maria are mere, dar Ion nu are mere";

            // case sensitive
            if (text.StartsWith("ana"))
            {
                Debug.WriteLine("Textul incepe cu 'ana'");
            }
            else
            {
                Debug.WriteLine("Textul nu incepe cu 'ana'");
            }

            // case insensitive
            if (text.StartsWith("ana", StringComparison.CurrentCultureIgnoreCase))
            {
                Debug.WriteLine("Textul incepe cu 'ana'");
            }
            else
            {
                Debug.WriteLine("Textul nu incepe cu 'ana'");
            }

            string mixedCaseString = "Ana are mere";
            string lowerCaseString = mixedCaseString.ToLower(); // ana are mere
            string upperCaseString = mixedCaseString.ToUpper(); // ANA ARE MERE

            string fullString = "Ana are mere. Maria are mere, dar Ion nu are mere";
            string searchString = "Mere";

            // case sensitive
            if (fullString.Contains(searchString))
            {
                Debug.WriteLine("Textul contine string-ul cautat");
            }
            else
            {
                Debug.WriteLine("Textul nu contine string-ul cautat");
            }

            // case insensitive
            if (fullString.ToLower().Contains(searchString.ToLower()))
            {
                Debug.WriteLine("Textul contine string-ul cautat");
            }
            else
            {
                Debug.WriteLine("Textul nu contine string-ul cautat");
            }

            string startupString = "Ana are mere. Maria are mere.";
            string substringToEnd = startupString.Substring(14); // Maria are mere.
            string substringPart = startupString.Substring(14, 5); // Maria

            string trimmableString = "  TExt cu spatii   ";
            string trimmedString = trimmableString.Trim(); // 'TExt cu spatii'
            string trimmedStringStart = trimmableString.TrimStart(); // 'TExt cu spatii   '   
            string trimmedStringEnd = trimmableString.TrimEnd(); // '  TExt cu spatii'

            string result = String.Format("{0:0.00}", 123.4567);      // "123.46"
            result = String.Format("{0:0.00}", 123.4);         // "123.40"
            result = String.Format("{0:0.00}", 123.0);         // "123.00"
            result = String.Format("{0:X}", 255);                // "FF"
            result = String.Format("{0:N2}", 123.4567);        // "123.46"
            result = String.Format("{0:N0}", 123.4567);        // "123"
            result = string.Format("{0:yyyy_MM_dd_HH_mm_ss_fff}", DateTime.Now);
            //2013_10_23_13_04_55_388
        }
    }
}
