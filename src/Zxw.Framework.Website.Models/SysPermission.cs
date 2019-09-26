﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Zxw.Framework.NetCore.DbContextCore;
using Zxw.Framework.NetCore.Models;

namespace Zxw.Framework.Website.Models
{
    [DbContext(typeof(SqlServerDbContext))]
    [Table("SysPermission")]
    public class SysPermission:BaseModel<string>
    {
        [Key]
        [Column("SysPermissionId")]
        [MaxLength(36)]
        public override string Id { get; set; }


    }
}
