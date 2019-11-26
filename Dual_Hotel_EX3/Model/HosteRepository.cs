﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dual_Hotel_EX3.Model
{
    class HosteRepository
    {

        private static hotelEntities dataContext = new hotelEntities();

        public static Hoste getHoste(int IDHoste)
        {
            Hoste h = dataContext.Hostes.Where(x => x.IDHoste == IDHoste).SingleOrDefault();
            return h;
        }

        public static Hoste InsertHoste(Hoste h)
        {

            dataContext.Hostes.Add(h);
            dataContext.SaveChanges();
            return getHoste(h.IDHoste);

        }

    }
}
