﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TFCLPortal.DynamicDropdowns.ReasonForNotBeingInteresteds
{ //NEW DROPDOWN API Addition Table Reference

    [Table("ReasonForNotBeingInterested")]
    public class ReasonForNotBeingInterested : AuditedEntity<Int32>
    {
        public string Name { get; set; }
    }
}
