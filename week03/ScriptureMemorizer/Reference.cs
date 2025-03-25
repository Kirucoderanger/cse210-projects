using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Reference
{
    public class ReferenceTracker
    {
        private static List<string> refernces = new List<string>
        {
        "Matthew 7 24 ",
        "Matthew 7 25 ",
        "1 Corinthians 13:4, 7–8",
        "1 John 4:18",
        "1 Peter 1:22",
        "Luke 6:35",
        "Leviticus 19:34",
        "John 13:34­–35",
        "Luke 12:6–7",
        "John 3:16",
        "Matthew 22:37–38",
        "John 14:15",
        "1 Nephi 4:6",
        "2 Nephi 32:5 ",
        "Moroni 10 5",
        "3 Nephi 28:11",
        "Moses 1 31",
        "Doctrine and Covenants 27:15",
        "Doctrine and Covenants 42:48",
        "Doctrine and Covenants 45:39",
        "Doctrine and Covenants 64:10",
        "Doctrine and Covenants 82:3",
        "Doctrine and Covenants 82:10",
        "Doctrine and Covenants 88:15",
        "Doctrine and Covenants 97:21",
        "Doctrine and Covenants 130:22",
        "Doctrine and Covenants 137:10",
        "Articles of Faith 1",
        "Articles of Faith 2",
        "Articles of Faith 3",
        "Articles of Faith 4",
        "Articles of Faith 5",
        "Articles of Faith 6",
        "Articles of Faith 7",
        "Articles of Faith 8",
        "Articles of Faith 9",
        "Articles of Faith 10",
        "Articles of Faith 11",
        "Articles of Faith 12",
        "Articles of Faith 13"

        };

        public static string ReferncePicker(int index)
        {
            if (index >= 0 && index < refernces.Count)
            {
                return refernces[index];
            }
            return "Invalid index";
        }

    }

}