using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200048C")]
	internal class GridTilesetObjectCache : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001CD3")]
		private readonly List<GridTilesetObject> cache = (List<GridTilesetObject>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000287")]
		public IEnumerable<GridTilesetObject> Cache
		{
			[Cpp2IlInjected.Token(Token = "0x6001437")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				List<GridTilesetObject> list = cache;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001438")]
		[Cpp2IlInjected.Address(RVA = "0x1545F10", Offset = "0x1544910", VA = "0x181545F10")]
		public void Add(GridTilesetObject gridTilesetObject)
		{
			//Discarded unreachable code: IL_000d
			((List<T>)(object)cache).Add((T)gridTilesetObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6001439")]
		[Cpp2IlInjected.Address(RVA = "0x1545F70", Offset = "0x1544970", VA = "0x181545F70")]
		public void Remove(GridTilesetObject gridTilesetObject)
		{
			//Discarded unreachable code: IL_000e
			bool flag = ((List<T>)(object)cache).Remove((T)gridTilesetObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600143A")]
		[Cpp2IlInjected.Address(RVA = "0x1545FD0", Offset = "0x15449D0", VA = "0x181545FD0")]
		public GridTilesetObjectCache()
		{
		}
	}
}
