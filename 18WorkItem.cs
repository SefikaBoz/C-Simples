# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMSDN
{
    class WorkItem
    {
        private static int currentId;
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan jobLength { get; set; }

        public WorkItem()
        {
            ID = 0;
            Title = "Default Title";
            Description = "Default Description";
            jobLength = new TimeSpan();
        }
        public WorkItem(string title, string desc, TimeSpan joblen)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.Description = desc;
            this.jobLength = joblen;
        }
        // constructor is called one time, automatically

        static WorkItem()
        {
            currentId = 0;
        }

        protected int GetNextId()
        {
            return currentId++;
        }
        public void Update(string title, TimeSpan joblen)
        {
            this.Title = title;
            this.jobLength = joblen;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} ", this.ID, this.Title);
        }
    }
}
