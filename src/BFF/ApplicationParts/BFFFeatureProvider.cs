using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Orders.Controllers;
using Products.Controllers;

namespace BFF.ApplicationParts
{
	internal class BFFFeatureProvider : IApplicationFeatureProvider<BFFFeatures>
	{
		public void PopulateFeature(IEnumerable<ApplicationPart> parts, BFFFeatures feature)
		{
			feature.Controllers.Add(typeof(OrdersController).GetTypeInfo());
			feature.Controllers.Add(typeof(ProductsController).GetTypeInfo());
		}
	}
}