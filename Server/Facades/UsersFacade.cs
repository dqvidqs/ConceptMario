using Server.Database;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;
using Objects.Models;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace Server.Facades
{
    class UsersFacade : BaseFacade
    {
        public UsersFacade(GameContext context) : base(context)
        {
        }

        public async Task<int> GetLoggedInCount()
        {
            return await Task.FromResult(_context.Users.Where(x => x.status).Count());
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await Task.FromResult(_context.Users);
        }

        public async Task<User> GetUser(User usr)
        {
            var user = _context.Users.FirstOrDefault(x => x.username == usr.username && x.password == usr.password);

            if (user == null)
            {
                throw new Exception("User credentials are not valid");
            }

            user.status = true; // todo: status pakeisti i 'isloggedin' ar kazka pan
            _context.Entry(user).State = EntityState.Modified; // todo: sita tikriausiai reikia istrinti
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task Logout(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                throw new Exception("User doesn't exist");
            }

            if (!user.status)
            {
                throw new Exception("User is not logged in");
            }

            user.status = false;
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<User> CreateUser(User user)
        {
            int id = _context.Users.Count() + 1;
            user.id = id;
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            Inventory inventory = new Inventory(id);
            _context.Inventories.Add(inventory);
            await _context.SaveChangesAsync();

            Character character = new Character(id);
            _context.Characters.Add(character);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}