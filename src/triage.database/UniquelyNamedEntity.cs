﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triage.database
{
    public class UniquelyNamedEntity
    {
        [Required]
        [Index(IsUnique = true)]
        [StringLength(450)]
        public string Name { get; set; }
    }
}
