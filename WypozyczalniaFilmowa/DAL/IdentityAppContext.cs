using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WypozyczalniaFilmowa.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WypozyczalniaFilmowa.DAL
{ 
    public class IdentityAppContext : IdentityDbContext<AppUser, AppRole, int>
    {
    }
}
