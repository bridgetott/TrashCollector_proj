using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorProj.Models
{
    [Authorize(Roles = "Customer")]
    public class CustomersController : Controller
    {
    }
}
