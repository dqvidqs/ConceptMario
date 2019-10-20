using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptMario.Models
{
	class Character
	{
		public int id { get; set; }
		public int x { get; set; }
		public int y { get; set; }
		public int fk_user { get; set; }
		public int fk_inventory { get; set; }
		public Nullable<int> fk_ability { get; set; }
	}
}
