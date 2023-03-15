using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000ADA")]
	public class ActionCookingIngredientTypeEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003C25")]
		[SerializeField]
		[ItemID]
		private int _type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003C26")]
		public Switch switch_obj;

		[Cpp2IlInjected.Token(Token = "0x170006ED")]
		public Item type
		{
			[Cpp2IlInjected.Token(Token = "0x60031FD")]
			[Cpp2IlInjected.Address(RVA = "0xA3C1D0", Offset = "0xA3ABD0", VA = "0x180A3C1D0")]
			get
			{
				long num = Convert.ToInt64((uint)_type);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031FE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ActionCookingIngredientTypeEntry()
		{
		}
	}
}
