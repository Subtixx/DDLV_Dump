using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000474")]
	internal class GridScriptObjectCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001C50")]
		private GridScript gridScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001C51")]
		private Dictionary<uint, WeakReference<GridObjectScript>> cached = (Dictionary<uint, WeakReference<GridObjectScript>>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x6001389")]
		[Cpp2IlInjected.Address(RVA = "0x153A6D0", Offset = "0x15390D0", VA = "0x18153A6D0")]
		public GridScriptObjectCache(GridScript gridScript)
		{
			this.gridScript = gridScript;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600138A")]
		[Cpp2IlInjected.Address(RVA = "0x153A520", Offset = "0x1538F20", VA = "0x18153A520")]
		public unsafe GridObjectScript GetGridObjectScript(uint gridObjectID)
		{
			//IL_0011: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			Dictionary<uint, WeakReference<GridObjectScript>> dictionary = cached;
			int num = 0;
			if (((Dictionary<TKey, TValue>)(object)dictionary).TryGetValue((TKey)gridObjectID, out *(TValue*)num))
			{
				bool flag = default(bool);
				if (flag)
				{
					throw new NullReferenceException();
				}
				bool flag2 = ((Dictionary<TKey, TValue>)(object)cached).Remove((TKey)gridObjectID);
			}
			GridObjectScript gridObjectScript = gridScript.GetGridObjectScript(gridObjectID);
			int num2 = 0;
			if (gridObjectScript != (UnityEngine.Object)num2)
			{
				Dictionary<uint, WeakReference<GridObjectScript>> dictionary2 = cached;
				WeakReference<GridObjectScript> weakReference = (WeakReference<GridObjectScript>)(object)new WeakReference<T>((T)(object)gridObjectScript);
				throw new NullReferenceException();
			}
			return gridObjectScript;
		}
	}
}
