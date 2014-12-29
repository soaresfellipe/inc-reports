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
        private String incidentNumber;
        private char severity;
        private String assignee;
        private String assignement;
        private String status;
        private DateTime openTime;
        private DateTime updateTime;
        private DateTime resolvedTime;
        private DateTime closeTime;
        private DateTime reopenTime;
        private bool slaBreached;
        private String vendorTicket;
    }
}
