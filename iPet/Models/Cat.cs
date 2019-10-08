using System.Collections.Generic;

namespace Pets.Models
{
	public class Cat : Pet
	{
		public static new List<string> NeedsList = new List<string>{"bed", "food dish", "water bowl", "litter box", "scooper", "catnip", "cat food", "toys", "scratching post", "carrying case", "brush"};

		public Cat(string name, List<string> characteristics)
		{
			Name = name;
			Type = "Cat";
			Characteristics = characteristics;
		}
	}
}