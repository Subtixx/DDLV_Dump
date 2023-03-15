using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x200098C")]
	public class RarityFilter : Filter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003866")]
		public Sprite filterIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003867")]
		private int? rarity;

		[Cpp2IlInjected.Token(Token = "0x17000844")]
		public override int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6003C0E")]
			[Cpp2IlInjected.Address(RVA = "0xF35550", Offset = "0xF33F50", VA = "0x180F35550", Slot = "5")]
			get
			{
				//IL_0009: Expected O, but got I8
				int num = 0;
				ulong num2 = default(ulong);
				rarity = (int?)(object)num2;
				int result = default(int);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000845")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003C0F")]
			[Cpp2IlInjected.Address(RVA = "0xF355E0", Offset = "0xF33FE0", VA = "0x180F355E0", Slot = "6")]
			get
			{
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000846")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003C10")]
			[Cpp2IlInjected.Address(RVA = "0xF35520", Offset = "0xF33F20", VA = "0x180F35520", Slot = "7")]
			get
			{
				return "menu.wardrobe_filter_rarity";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000847")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003C11")]
			[Cpp2IlInjected.Address(RVA = "0xF354F0", Offset = "0xF33EF0", VA = "0x180F354F0", Slot = "8")]
			get
			{
				Color yellow = Color.yellow;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C12")]
		[Cpp2IlInjected.Address(RVA = "0xF35440", Offset = "0xF33E40", VA = "0x180F35440")]
		public RarityFilter(TierFilterItemData data, int order = 0)
		{
			//IL_000d: Expected O, but got I8
			((BattlePassReward)(object)this)._002Ector();
			ulong num = default(ulong);
			rarity = (int?)(object)num;
			base.Order = order;
			base.Group = "Rarity";
		}

		[Cpp2IlInjected.Token(Token = "0x6003C13")]
		[Cpp2IlInjected.Address(RVA = "0xF353B0", Offset = "0xF33DB0", VA = "0x180F353B0", Slot = "9")]
		public override bool Retains(object item)
		{
			//IL_000e: Expected I4, but got O
			if ((object)typeof(IHasRarity).TypeHandle == null)
			{
				return (byte)(int)typeof(IHasRarity).TypeHandle != 0;
			}
			int? num = rarity;
			return (object)typeof(IHasRarity).TypeHandle == (object)num;
		}
	}
}
