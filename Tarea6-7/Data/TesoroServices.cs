using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea6_7.Data
{
    public class TesoroServices
    {
        private AppDbContext dbContext;
        public TesoroServices(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //get
        public async Task<List<Tesoro>> GetTesorosAsync()
        {
            return await dbContext.Tesoros.ToListAsync();
        }
    }
}
