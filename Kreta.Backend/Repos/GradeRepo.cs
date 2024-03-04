﻿using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class GradeRepo<TDbContext> : RepositoryBase<TDbContext, Grade>, IGradeRepo
        where TDbContext : DbContext
    {
        public GradeRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {

        }
    }
}
