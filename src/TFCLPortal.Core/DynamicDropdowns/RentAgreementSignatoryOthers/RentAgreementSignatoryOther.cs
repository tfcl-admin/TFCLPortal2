﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TFCLPortal.DynamicDropdowns.RentAgreementSignatoryOthers
{
    //NEW DROPDOWN API Addition Table Reference

    [Table("RentAgreementSignatoryOther")]
    public class RentAgreementSignatoryOther : AuditedEntity<Int32>
    {
        public string Name { get; set; }
    }
}

