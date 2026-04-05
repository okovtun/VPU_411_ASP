using System.Numerics;

namespace Blazor.Components.Pages
{
	//partial показывает, что в этом файле реализована только часть класса,
	//и ввесь класс описан в нескольки файлах.
	public partial class Factorial
	{
		int n;
		BigInteger factorial;
		void Calculate()
		{
			factorial = 1;
			for (int i = 1; i <= n; i++)
			{
				factorial *= i;
			}
		}
	}
}
