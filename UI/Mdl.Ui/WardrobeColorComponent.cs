using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000785")]
	[RequiredAllNotNull]
	public class WardrobeColorComponent : ColorComponent
	{
		[Cpp2IlInjected.Token(Token = "0x170006C8")]
		public List<ClothingItemData> Items
		{
			[Cpp2IlInjected.Token(Token = "0x6003011")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CItems_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003012")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CItems_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003013")]
		[Cpp2IlInjected.Address(RVA = "0x14E3B20", Offset = "0x14E2520", VA = "0x1814E3B20", Slot = "4")]
		protected override void OnColorDataHandler(ListBase.ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003014")]
		[Cpp2IlInjected.Address(RVA = "0x14E3D40", Offset = "0x14E2740", VA = "0x1814E3D40")]
		public WardrobeColorComponent()
		{
		}
	}
}
