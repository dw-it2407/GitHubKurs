using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitHubKurs.Model;

namespace GitHubKurs.Data
{
	public class CoffeeShopDataProvider
	{
		public IEnumerable<CoffeeShop> LoadShops()
		{
			return new CoffeeShop[]
				{
					new CoffeeShop("FT",20),
					new CoffeeShop("Frankfurt",54),
					new CoffeeShop("Mannheim",47),
				};
		}
	}
}
