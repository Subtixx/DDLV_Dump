using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using PlayFab.ProfilesModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	public class EntityKeyComparer : IEqualityComparer<EntityKey>
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x102E150", Offset = "0x102CB50", VA = "0x18102E150", Slot = "4")]
		public bool Equals(EntityKey x, EntityKey y)
		{
			string _003CType_003Ek__BackingField = x.Type;
			string _003CId_003Ek__BackingField = x.Id;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x102E1B0", Offset = "0x102CBB0", VA = "0x18102E1B0", Slot = "5")]
		public int GetHashCode(EntityKey obj)
		{
			string _003CId_003Ek__BackingField = obj.Id;
			object obj2 = ((ICloneable)(obj.Type + "/" + _003CId_003Ek__BackingField)).Clone();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public EntityKeyComparer()
		{
		}
	}
}
