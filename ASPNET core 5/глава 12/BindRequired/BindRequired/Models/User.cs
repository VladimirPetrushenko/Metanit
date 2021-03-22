using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BindRequired.Models
{
    public class User
    {
        public int Id { get; set; }
        [BindRequired]
        public string Name { get; set; }
        [BindingBehavior(BindingBehavior.Optional)]
        public int Age { get; set; }
        [BindNever]
        public bool HasRight { get; set; }
    }
}
