﻿using System.Collections.Generic;
using System.Reflection;

namespace Fluxor.Modularlization
{
	public interface IModuleLoader
	{
		void Load(IStore store, Assembly assemblyToScan);
		void Load(IStore store, IEnumerable<Assembly> assembliesToScan);
	}
}