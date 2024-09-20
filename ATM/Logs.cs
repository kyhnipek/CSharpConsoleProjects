using System.IO;

namespace ATM
{
    class Logs
    {

        public static void WriteLog(string type, string message)
        {
            try
            {
                string fileName = "EOD_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                StreamWriter sw = new StreamWriter(fileName, true);
                sw.WriteLine(DateTime.Now + ", " + type + ", " + message);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: " + e.Message);
            }
        }
        public static void ReadLog()
        {
            Utils.Seperator();
            String line;
            try
            {
                string fileName = "EOD_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
                StreamReader sr = new StreamReader(fileName);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Menu.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: " + e.Message);
            }
        }
    }
}