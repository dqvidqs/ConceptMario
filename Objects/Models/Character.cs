using System;

namespace Objects.Models
{
	public class Character
	{
		public int id { get; set; }
		public int x { get; set; }
		public int y { get; set; }
		public int fk_user { get; set; }
		public int fk_inventory { get; set; }
		public Nullable<int> fk_ability { get; set; }

        public Character()
        {

        }

        public Character(int id)
        {
            this.id = id;
            fk_user = id;
            fk_inventory = id;
            x = 25;
            y = 25;
        }
	}
}
