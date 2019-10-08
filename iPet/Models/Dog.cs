using System.Collections.Generic;

namespace Pets.Models
{
	public class Dog : Pet
	{
		public static new List<string> NeedsList = new List<string>{ "bed", "food dish", "water bowl", "dog food", "toys", "brush", "collar", "bone", "leash", "nail clippers" };

		public Dog(string name, List<string> characteristics)
		{
			Name = name;
			Type = "Dog";
			Characteristics = characteristics;
		}
	}
}