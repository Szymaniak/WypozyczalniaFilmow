﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WypozyczalniaFilmowa.Models
{
    public class DodawanieViewModel
    {
        public Film Film { get; set; }
        public IFormFile Plakat { get; set; }

        public List<Kategoria> Kategorie { get; set; }
    }
}
