using System.Collections.Generic;

namespace Pets.Models
{
	public abstract class Pet
	{
		public string Name { get; set; }
		public static List<string> NeedsList { get; set; }
		public string Type { get; set; }
		public List<string> Characteristics { get; set; }
		public string Blurb {get; set; }
		public string ImageLink { get; set; }
		
	}
}