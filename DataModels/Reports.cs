using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementSystem.DataModels
{
    [PrimaryKey(nameof(ReportId))]
    public class Reports
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public string InCharge { get; set; }
        public DateTime DateFinished { get; set; }
    }
}
