using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Filer
    {
        public Filer()
        {

        }
        public void save(Report report)
        {
            String text = report.getfirstN()+";"+report.getlastN()+";"+report.getid()+";"+report.getProgram()+";"+report.getLocation()+";"+report.getTime()+";"+report.getDescription()+"\n";
            System.IO.File.AppendAllText("..\\..\\..\\Resources\\output.txt", text);
        }

        public List<Report> load()
        {
            List<Report> list = new List<Report>();
            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\..\\Resources\\output.txt");

                line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    String[] arr = line.Split(';');
                    list.Add(new Report(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]));
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return list;
        }
    }
}
