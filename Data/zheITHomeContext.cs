using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace zheITHome.Data
{
    public class zheITHomeContext: DbContext
    {
        public zheITHomeContext(  DbContextOptions<zheITHomeContext> options):base(options){

        }

        public DbSet<zheITHome.Models.Article> Article { get; set; }

    }
}
