﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Fluxor.DependencyInjection.DependencyScanners
{
	internal static class MiddlewareClassesDiscovery
	{
		internal static IEnumerable<AssemblyScanSettings> FindMiddlewareLocations(IEnumerable<Assembly> assembliesToScan)
		{
			return assembliesToScan
				.SelectMany(x => GetLoadedTypes(x).Where(t => t.GetInterfaces().Any(i => i == typeof(IMiddleware))))
				.Select(x => new AssemblyScanSettings(x.Assembly, x.Namespace))
				.Distinct()
				.ToArray();
		}
	}
}
