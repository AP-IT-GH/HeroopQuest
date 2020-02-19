using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace src_HeroopQuest
{
    class HulpKlasse
    {//Bron: https://stackoverflow.com/questions/20534318/make-console-writeline-wrap-words-instead-of-letters
        public static void WordWrap(string paragraph, int leftconsole, int rightconsole, int startleft, int starttop, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(startleft, starttop);
            paragraph = new Regex(@" {2,}").Replace(paragraph.Trim(), @" ");
            var left = Console.CursorLeft; var top = Console.CursorTop; var lines = new List<string>();
            for (var i = 0; paragraph.Length > 0; i++)
            {
                lines.Add(paragraph.Substring(0, Math.Min(Console.WindowWidth-rightconsole-leftconsole, paragraph.Length)));
                var length = lines[i].LastIndexOf(" ", StringComparison.Ordinal);
                if (length > 0) lines[i] = lines[i].Remove(length);
                paragraph = paragraph.Substring(Math.Min(lines[i].Length + 1, paragraph.Length));
                Console.SetCursorPosition(left+leftconsole, top + i); Console.SetCursorPosition(leftconsole,top+i); Console.WriteLine(lines[i]);
            }
            Console.ResetColor();
        }
    }
}
