using System.Collections.Generic;
using System.Linq;

namespace Pets.Models 
{
	public class Owner
	{
		public string Name { get; set; }
		public List<string> Items { get; set; }
		public List<Pet> Pets { get; set; }

		public static List<Owner> _instances = new List<Owner>{};

		public Owner(string name)
		{
			Name = name;
			Items = new List<string>{};
			Pets = new List<Pet> { };
			_instances.Add(this);
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
	}
}