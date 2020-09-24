using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using Club.API.Context;
using Microsoft.EntityFrameworkCore;

namespace Club.API.GraphQlQueries
{
    public class ClubQueries
    {
        private readonly ClubContext _context;
        public ClubQueries(ClubContext context)
        {
            _context = context;
        }

        [UsePaging]
        [UseFiltering]
        public IQueryable<Context.Model.Club> Clubs => _context.Clubs.AsQueryable();

       // [UsePaging]
       // [UseFiltering]
       // public async Task<List<string>> ClubNames()
       // {
       //     return await _context.Clubs.Select(club => club.Name).ToListAsync();
       // }
    }
}