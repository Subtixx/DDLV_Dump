using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Characters.Critters;
using Meta;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000516")]
	public class GiftMenuParam : MenuParam
	{
		[Cpp2IlInjected.Token(Token = "0x17000533")]
		public Action<List<GiveItemsToCharacter.Types.ItemGiven>> ResultAction
		{
			[Cpp2IlInjected.Token(Token = "0x6002123")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CResultAction_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002124")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CResultAction_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000534")]
		public ItemFilterData Itemfilter
		{
			[Cpp2IlInjected.Token(Token = "0x6002125")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CItemfilter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002126")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CItemfilter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000535")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4001B72")]
		public int MaxSelectableItems
		{
			[Cpp2IlInjected.Token(Token = "0x6002127")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002128")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000536")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x44"), Cpp2IlInjected.Token(Token = "0x4001B73")]
		public bool MissionGift
		{
			[Cpp2IlInjected.Token(Token = "0x6002129")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E60", Offset = "0xAE0860", VA = "0x180AE1E60")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600212A")]
			[Cpp2IlInjected.Address(RVA = "0xAE1E70", Offset = "0xAE0870", VA = "0x180AE1E70")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000537")]
		public Character Character
		{
			[Cpp2IlInjected.Token(Token = "0x600212B")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CCharacter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600212C")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CCharacter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000538")]
		public Mdl.Characters.Critters.Critter Critter
		{
			[Cpp2IlInjected.Token(Token = "0x600212D")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CCritter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600212E")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			set
			{
				_003CCritter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600212F")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public GiftMenuParam()
		{
			((XmlSchemaNumericFacet)(object)this)._002Ector();
		}
	}
}
