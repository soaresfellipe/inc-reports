using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inc_reports
{
    public class Incident
    {
        private int id;
        private string incidentNumber;
        private char severity;
        private string assignee;
        private string assignement;
        private string status;
        private DateTime openTime;
        private DateTime updateTime;
        private DateTime resolveTime;
        private DateTime closeTime;
        private DateTime reopenTime;
        private bool slaBreached;
        private string vendorTicket;

        // Getters and Setters
        public int id { get; set; }
        public string incidentNumber { get; set; }
        public char severity { get; set; }
        public string assignee { get; set; }
        public string assignement { get; set; }
        public string status { get; set; }
        public DateTime openTime { get; set; }
        public DateTime updateTime { get; set; }
        public DateTime resolveTime { get; set; }
        public DateTime closeTime { get; set; }
        public DateTime reopenTime { get; set; }
        public bool slaBreached { get; set; }
        public string vendorTicket { get; set; }

    }
}
