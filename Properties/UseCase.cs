using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_helper
{
    class UseCase : Element
    {
        private string summary;
        private string actors;
        private string assumptions;
        private string description;
        private string exceptions;
        private string result;

        public string Summary
        {
            get { return summary; }
            set { summary = value; }
        }
        public string Actors
        {
            get { return actors; }
            set { actors = value; }
        }
        public string Assumptions
        {
            get { return assumptions; }
            set { assumptions = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Exceptions
        {
            get { return exceptions; }
            set { exceptions = value; }
        }
        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        public UseCase(int x1, int y1, int x2, int y2, string name) : base(x1, y1, x2, y2, name)
        {
            /*
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x1 + width;
            this.y2 = y1 + height;
            this.name = name;
            */
            type = "UseCase";
            summary = "";
            actors = "";
            assumptions = "";
            description = "";
            exceptions = "";
            result = "";
        }
        //methods
        public List<string> getProperties()
        {
            List<string> returnList = new List<string>();
            returnList.Add(name);
            returnList.Add(summary);
            returnList.Add(actors);
            returnList.Add(assumptions);
            returnList.Add(description);
            returnList.Add(exceptions);
            returnList.Add(result);
            return returnList;
        }
    }
}
