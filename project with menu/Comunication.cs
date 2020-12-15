using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    class Comunication
    {
        public static string testName;
        public static int nivel;
        public static int punctajTest1 = 0;
        public static int punctajTest2 = 0;
        public static int punctajTest3 = 0;
        public static int speedBlob;
        public static void setPunctaj()
        {
            switch (testName)
            {
                case "test1.txt":
                    punctajTest1++;
                    break;
                case "test2.txt":
                    punctajTest2++;
                    break;
                default:
                    punctajTest3++;
                    break;
            }
        }
    }
}
