using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Objects.Models;

namespace ConceptMario
{
	class HttpAdapter
	{
		static string page = "http://localhost:60951/api/";
		static HttpClient client = new HttpClient();

		public async Task<Gun[]> GetGuns()
		{
			HttpResponseMessage response = await client.GetAsync(page + "Guns/");
			string data = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<Gun[]>(data);

			return result;
		}

		public async Task<Character> GetTeammate(int id)
		{
			HttpResponseMessage response = await client.GetAsync(page + "characters/" + id.ToString());
			string data = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<Character>(data);

			return result;
		}

		public async Task UpdateCharacter(int id, Character character)
		{
			HttpResponseMessage response = await client.PutAsync(page + "characters/" + id.ToString(),
				new StringContent(JsonConvert.SerializeObject(character), Encoding.UTF8, "application/json"));
		}

		public async Task<User> Login(string username, string password)
		{
			User user = new User();
			user.password = password;
			user.username = username;
			HttpResponseMessage response = await client.PutAsync(page + "users",
				new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));
			string data = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<User>(data);
			return result;
		}

		public async Task Logout(int userId)
		{
			HttpResponseMessage response = await client.GetAsync(page + "users/logout/" + userId.ToString());
		}

		public async Task<User> Register(string username, string password)
		{
			User user = new User();
			user.password = password;
			user.username = username;
			HttpResponseMessage response = await client.PostAsync(page + "users",
				new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json"));
			string data = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<User>(data);
			return result;
		}

		public async Task<Inventory> GetInventory(int userId)
		{
			HttpResponseMessage response = await client.GetAsync(page + "inventories/"+userId.ToString());
			string data = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<Inventory>(data);
			return result;
		}

		public async Task<string> GetLoggedUsers()
		{
			HttpResponseMessage response = await client.GetAsync(page + "users/logged");
			var result = await response.Content.ReadAsStringAsync();

			return result;
		}

		public async Task<Room> StartMatchmaking(int userId)
		{
			HttpResponseMessage response = await client.PostAsync(page + "rooms",
				new StringContent(JsonConvert.SerializeObject(new MyClass {id = userId}), Encoding.UTF8,"application/json"));
			string data = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<Room>(data);
			return result;
		}

		public async Task StopMatchmaking(int roomId)
		{
			HttpResponseMessage response =await client.DeleteAsync(page + "rooms/" + roomId.ToString());
			string data = await response.Content.ReadAsStringAsync();
		}

		public async Task<Room> GetRoom(int userId)
		{
			HttpResponseMessage response = await client.GetAsync(page + "rooms/" + userId.ToString());
			string data = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<Room>(data);
			return result;
		}
	}
}