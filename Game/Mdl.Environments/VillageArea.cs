using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Scene;
using Mdl.Grid;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x20006A0")]
	public class VillageArea : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002732")]
		[SerializeField]
		private VillageAreaType _areaType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002733")]
		[SerializeField]
		private List<VillageAreaLock> _entryPoints = (List<VillageAreaLock>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002734")]
		private GridScript _gridScript;

		[Cpp2IlInjected.Token(Token = "0x1700041F")]
		public VillageAreaType AreaType
		{
			[Cpp2IlInjected.Token(Token = "0x6001D60")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return _areaType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000420")]
		public List<VillageAreaLock> EntryPoints
		{
			[Cpp2IlInjected.Token(Token = "0x6001D61")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _entryPoints;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000421")]
		public GridScript GridScript
		{
			[Cpp2IlInjected.Token(Token = "0x6001D62")]
			[Cpp2IlInjected.Address(RVA = "0xD47150", Offset = "0xD45B50", VA = "0x180D47150")]
			get
			{
				//IL_0010: Expected O, but got I4
				GridScript gridScript = _gridScript;
				int num = 0;
				if (gridScript == (Object)num)
				{
					GridScript gridScript2 = (_gridScript = GetComponent<GridScript>());
				}
				return _gridScript;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D63")]
		[Cpp2IlInjected.Address(RVA = "0xD46FE0", Offset = "0xD459E0", VA = "0x180D46FE0")]
		private void Start()
		{
			//Discarded unreachable code: IL_000c
			List<VillageAreaLock> entryPoints = _entryPoints;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D64")]
		[Cpp2IlInjected.Address(RVA = "0xD470D0", Offset = "0xD45AD0", VA = "0x180D470D0")]
		public VillageArea()
		{
		}
	}
}
