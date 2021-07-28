using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Orders.Controllers;

namespace Integrations.API.ApplicationParts
{
	internal class IntegrationsAPIFeatureProvider : IApplicationFeatureProvider<IntegrationsAPIFeatures>
	{
		public void PopulateFeature(IEnumerable<ApplicationPart> parts, IntegrationsAPIFeatures feature)
		{
			feature.Controllers.Add(typeof(OrdersController).GetTypeInfo());
		}
	}
}