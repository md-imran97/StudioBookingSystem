﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioBookingSystem.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task SaveChanges();
    }
}
