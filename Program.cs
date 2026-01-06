using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace TechWorldGhostGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                PrintHeader();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" [>] Enter the text you want to generate: ");
                Console.ForegroundColor = ConsoleColor.White;
                string userInput = Console.ReadLine();

                // Advanced Conversion: Letters, Numbers, AND Symbols
                string fakeText = TotalTechConvert(userInput);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n [>] Enter folder path: ");
                Console.ForegroundColor = ConsoleColor.White;
                string folderPath = Console.ReadLine();

                string timestamp = DateTime.Now.ToString("HHmmss");
                string fileName = $"output_{timestamp}.txt";
                string fullPath = Path.Combine(folderPath, fileName);

                try
                {
                    if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" [!] Generating Ghost-Character Hash... ");
                    Thread.Sleep(800);

                    // Writing with UTF8 BOM for maximum compatibility
                    File.WriteAllText(fullPath, fakeText, new UTF8Encoding(true));

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DONE!");
                    Console.WriteLine($"\n [SUCCESS] Saved to: {fullPath}");
                    Console.WriteLine("\n [PREVIEW]: " + fakeText);
                    Console.Beep();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n [ERROR] {ex.Message}");
                }

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n [?] Generate another? (y/n): ");
                keepRunning = Console.ReadLine()?.ToLower() == "y";
            }
        }

        static string TotalTechConvert(string input)
        {
            // The ultimate mapping: Letters + Numbers + Tech Symbols
            var map = new Dictionary<char, string>
            {
                // Letters
                {'a',"а"},{'b',"Ь"},{'c',"с"},{'d',"ԁ"},{'e',"е"},{'f',"ｆ"},{'g',"ɡ"},{'h',"𝗁"},{'i',"і"},{'j',"ј"},{'k',"𝗄"},{'l',"ӏ"},{'m',"ｍ"},{'n',"ո"},{'o',"о"},{'p',"р"},{'q',"ԛ"},{'r',"г"},{'s',"ѕ"},{'t',"ｔ"},{'u',"υ"},{'v',"ѵ"},{'w',"ԝ"},{'x',"х"},{'y',"у"},{'z',"ｚ"},
                {'A',"А"},{'B',"В"},{'C',"С"},{'D',"Ꭰ"},{'E',"Е"},{'F',"Ғ"},{'G',"Ԍ"},{'H',"Н"},{'I',"І"},{'J',"Ј"},{'K',"К"},{'L',"ᒪ"},{'M',"М"},{'N',"Ν"},{'O',"О"},{'P',"Р"},{'Q',"Ԛ"},{'R',"Ꮢ"},{'S',"Ѕ"},{'T',"Т"},{'U',"Ս"},{'V',"Ѵ"},{'W',"Ԝ"},{'X',"Х"},{'Y',"Ү"},{'Z',"Ζ"},
                // Numbers
                {'0',"０"},{'1',"１"},{'2',"２"},{'3',"３"},{'4',"４"},{'5',"５"},{'6',"６"},{'7',"７"},{'8',"８"},{'9',"９"},
                // Tech Symbols / Brackets / Logic
                {'{',"｛"},{'}',"｝"},{'[',"［"},{']',"］"},{'(',"（"},{')',"）"},
                {'=',"＝"},{'+',"＋"},{'-',"－"},{'*',"＊"},{'/',"／"},{'%',"％"},
                {'<',"＜"},{'>',"＞"},{'&',"＆"},{'|',"｜"},{'!',"！"},{'?',"？"},
                {':',"："},{';',"；"},{'.',"．"},{',',"，"},{'\'',"＇"},{'"',"＂"},
                {'@',"＠"},{'#',"＃"},{'$',"＄"},{'^',"＾"},{'_',"＿"},{'~',"～"},{'\\',"＼"}
            };

            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                sb.Append(map.ContainsKey(c) ? map[c] : c.ToString());
            }
            return sb.ToString();
        }

        static void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ╔══════════════════════════════════════════════════╗");
            Console.WriteLine(" ║          GHOST GENERATOR 1.0                     ║");
            Console.WriteLine(" ╚══════════════════════════════════════════════════╝");
            Console.ResetColor();
        }
    }
}