using System.Collections.Generic;
using System.Linq;

namespace Pets.Models 
{
	public class Owner
	{
		public string Name { get; set; }
		public List<string> Items { get; set; }
		public List<Pet> Pets { get; set; }
		public int Id { get; }
		private static int idCounter = 0;

		public static List<Owner> _instances = new List<Owner>{};

		public Owner(string name)
		{
			Name = name;
			Items = new List<string>{};
			Pets = new List<Pet> { };
			_instances.Add(this);
			idCounter++;
			Id = idCounter;
		}

		public void AddPet(Pet pet)
		{
			Pets.Add(pet);
		}

		public void AddItems(List<string> items)
		{
			Items.AddRange(items);
			Items = Items.Distinct().ToList();
		}

		public static List<Owner> GetAll()
		{
			return _instances;
		}
	}
}