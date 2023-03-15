using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x200098D")]
	public class IngredientTypeFilter : Filter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003868")]
		public Sprite filterIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400386A")]
		public Item IngredientType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400386B")]
		internal string displayName = "";

		[Cpp2IlInjected.Token(Token = "0x17000848")]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6003C14")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CIconAddress_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C15")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CIconAddress_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000849")]
		public override int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6003C16")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40", Slot = "5")]
			get
			{
				Item ingredientType = IngredientType;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700084A")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003C17")]
			[Cpp2IlInjected.Address(RVA = "0xD22B70", Offset = "0xD21570", VA = "0x180D22B70", Slot = "6")]
			get
			{
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700084B")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003C18")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "7")]
			get
			{
				return displayName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700084C")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003C19")]
			[Cpp2IlInjected.Address(RVA = "0xD22B40", Offset = "0xD21540", VA = "0x180D22B40", Slot = "8")]
			get
			{
				Color blue = Color.blue;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C1A")]
		[Cpp2IlInjected.Address(RVA = "0xD22990", Offset = "0xD21390", VA = "0x180D22990")]
		public IngredientTypeFilter()
		{
			((BattlePassReward)(object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C1B")]
		[Cpp2IlInjected.Address(RVA = "0xD229E0", Offset = "0xD213E0", VA = "0x180D229E0")]
		public IngredientTypeFilter(DynamicFilterItemData data, int order = 0)
		{
			//Discarded unreachable code: IL_0047
			((BattlePassReward)(object)this)._002Ector();
			string name = data.Name;
			base.Order = order;
			string name2 = data.Name;
			string name3 = data.Name;
			Item item = (IngredientType = ItemDatabase.Instance.GetItem(ItemType.Tag, name3));
		}

		[Cpp2IlInjected.Token(Token = "0x6003C1C")]
		[Cpp2IlInjected.Address(RVA = "0xD22880", Offset = "0xD21280", VA = "0x180D22880", Slot = "9")]
		public override bool Retains(object item)
		{
			//IL_000e: Expected I4, but got O
			if ((object)typeof(Item).TypeHandle == null)
			{
				return (byte)(int)typeof(Item).TypeHandle != 0;
			}
			if ((object)typeof(Item).TypeHandle != null)
			{
				return true;
			}
			return true;
		}
	}
}
