using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000473")]
	internal class GridObjectScriptCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001C4F")]
		private Dictionary<GridScript, GridScriptObjectCache> gridScriptCache = (Dictionary<GridScript, GridScriptObjectCache>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x6001387")]
		[Cpp2IlInjected.Address(RVA = "0x1536D30", Offset = "0x1535730", VA = "0x181536D30")]
		public GridObjectScript GetGridObjectScript(GridScript gridScript, uint gridObjectID)
		{
			//IL_004d: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			Dictionary<GridScript, GridScriptObjectCache> dictionary = gridScriptCache;
			bool flag = default(bool);
			GridScriptObjectCache gridScriptObjectCache = default(GridScriptObjectCache);
			if (!flag)
			{
				Dictionary<uint, WeakReference<GridObjectScript>> dictionary2 = (gridScriptObjectCache.cached = (Dictionary<uint, WeakReference<GridObjectScript>>)(object)new Dictionary<TKey, TValue>());
				gridScriptObjectCache.gridScript = gridScript;
				Dictionary<GridScript, GridScriptObjectCache> dictionary3 = gridScriptCache;
				throw new NullReferenceException();
			}
			Dictionary<uint, WeakReference<GridObjectScript>> cached = gridScriptObjectCache.cached;
			bool flag2 = default(bool);
			if (flag2)
			{
				bool flag3 = default(bool);
				if (flag3)
				{
					throw new NullReferenceException();
				}
				bool flag4 = ((Dictionary<TKey, TValue>)(object)gridScriptObjectCache.cached).Remove((TKey)gridObjectID);
			}
			GridScript gridScript2 = gridScriptObjectCache.gridScript;
			int num = 0;
			GridObjectScript gridObjectScript = default(GridObjectScript);
			if (gridObjectScript != (UnityEngine.Object)num)
			{
				Dictionary<uint, WeakReference<GridObjectScript>> cached2 = gridScriptObjectCache.cached;
				WeakReference<GridObjectScript> weakReference = (WeakReference<GridObjectScript>)(object)new WeakReference<T>((T)(object)gridObjectScript);
				throw new NullReferenceException();
			}
			return gridObjectScript;
		}

		[Cpp2IlInjected.Token(Token = "0x6001388")]
		[Cpp2IlInjected.Address(RVA = "0x1536FF0", Offset = "0x15359F0", VA = "0x181536FF0")]
		public GridObjectScriptCache()
		{
		}
	}
}
