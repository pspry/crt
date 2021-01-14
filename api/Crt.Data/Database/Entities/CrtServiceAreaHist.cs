﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Crt.Data.Database.Entities
{
    public partial class CrtServiceAreaHist
    {
        public long ServiceAreaHistId { get; set; }
        public decimal ServiceAreaId { get; set; }
        public decimal ServiceAreaNumber { get; set; }
        public string ServiceAreaName { get; set; }
        public decimal DistrictId { get; set; }
        public DateTime EffectiveDateHist { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? EndDateHist { get; set; }
        public long ConcurrencyControlNumber { get; set; }
        public string DbAuditCreateUserid { get; set; }
        public DateTime DbAuditCreateTimestamp { get; set; }
        public string DbAuditLastUpdateUserid { get; set; }
        public DateTime DbAuditLastUpdateTimestamp { get; set; }
    }
}
