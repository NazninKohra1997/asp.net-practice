﻿using Demo.Domain;
using Demo.Domain.Entities;
using Demo.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        CourseRepository courses { get; }
    }
}
