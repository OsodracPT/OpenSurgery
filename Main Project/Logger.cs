using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Main_Project
{
    class Logger
    {
        private static Logger _instance;

        private string filePath;

        //constructor
        private Logger()
        {
            filePath = Directory.GetCurrentDirectory() + "\\logFile";
        }
        //properties
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();

                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            using (StreamWriter streamwriter = new StreamWriter(filePath, true))
            {
                streamwriter.WriteLine(message);
                streamwriter.Close();
            }
        }
    }
}
