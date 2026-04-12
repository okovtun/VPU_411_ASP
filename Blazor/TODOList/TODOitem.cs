using System.ComponentModel.DataAnnotations;

namespace TODOList
{
	public class TODOitem
	{
		public string Title { get; set; }
		public bool DONE { get; set; }
		public override bool Equals(object? other)
		{
			return this.Title.Equals((other as TODOitem).Title);
		}
	}
}
