using Microsoft.AspNetCore.Mvc;
using Server.Database;

namespace Server.Facades
{
    public class BaseFacade 
    {
        protected readonly GameContext _context;

        public BaseFacade(GameContext context)
        {
            _context = context;
        }
    }
}