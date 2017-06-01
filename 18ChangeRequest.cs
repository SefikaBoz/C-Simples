# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMSDN
{
    class ChangeRequest : WorkItem
    {
        protected int OriginalItemId { get; set; }
        public ChangeRequest()
        {
            //this.ID = 45;
            //this.Title = "Change Request twest title";
            ////Console.Write(ToString());
        }
        public ChangeRequest(string title, string desc, TimeSpan joblen, int originalId)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.Description = desc;
            this.jobLength = jobLength;
            this.OriginalItemId = originalId;
            
        }
    }
}
