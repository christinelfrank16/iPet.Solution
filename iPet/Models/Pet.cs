using System.Collections.Generic;

namespace Pets.Models
{
	public abstract class Pet
	{
		public string Name { get; set; }
		public static List<string> NeedsList { get; set; }
		public string Type { get; set; }
		public static List<string> Characteristics { get; set; }
		
	}
}