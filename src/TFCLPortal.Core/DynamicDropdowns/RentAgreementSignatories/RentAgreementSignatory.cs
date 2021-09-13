﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TFCLPortal.DynamicDropdowns.RentAgreementSignatories
{
    //NEW DROPDOWN API Addition Table Reference

    [Table("RentAgreementSignatory")]
    public class RentAgreementSignatory : AuditedEntity<Int32>
    {
        public string Name { get; set; }
    }
}

