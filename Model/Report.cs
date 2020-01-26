using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{   
    public class Report    {
        private String firstName;
        private String lastName;
        private String icesiId;
        private String program;
        private String theftLocation;
        private String timeOfTheft;
        private String descriptionOfTheft;

       public Report(String firstN, String lastN, String id, String program, String location, String time, String description)
        {
            firstName = firstN;
            lastName = lastN;
            icesiId = id;
            this.program = program;
            theftLocation = location;
            timeOfTheft = time;
            descriptionOfTheft = description;
        }

        static void Main()
        {
        }

        public String getfirstN()
        {
            return this.firstName;
        }

        public String getlastN()
        {
            return this.lastName;
        }

        public String getid()
        {
            return this.icesiId;
        }

        public String getProgram()
        {
            return this.program;
        }

        public String getLocation()
        {
            return this.theftLocation;
        }

        public String getTime()
        {
            return this.timeOfTheft;
        }
        public String getDescription()
        {
            return this.descriptionOfTheft;
        }
    }
}
