﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Foo
    {
        [Key]
        public int FooID { get; set; }
        public string FooName { get; set; }
    }
}
