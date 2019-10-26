using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ConceptMario.Models;
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
	}
}