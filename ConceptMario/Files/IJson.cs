using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Objects.Models;

namespace ConceptMario
{
	interface IJson
	{
		Task<Gun[]> GetGuns();


		Task<Character> GetTeammate(int id);


		Task UpdateCharacter(int id, Character character);


		Task<User> Login(string username, string password);


		Task Logout(int userId);


		Task<User> Register(string username, string password);


		Task<Inventory> GetInventory(int userId);


		Task<string> GetLoggedUsers();


		Task<Room> StartMatchmaking(int userId);

		Task StopMatchmaking(int roomId);


		Task<Room> GetRoom(int userId);

	}
}
