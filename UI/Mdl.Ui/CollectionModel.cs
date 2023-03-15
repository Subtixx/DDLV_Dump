using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002F3")]
	public class CollectionModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000E5E")]
		public CollectionSubMenu CollectionItemTab;

		[Cpp2IlInjected.Token(Token = "0x17000356")]
		public List<CollectionItemGroupModel> CollectionGroupModels
		{
			[Cpp2IlInjected.Token(Token = "0x6001329")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CCollectionGroupModels_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600132A")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CCollectionGroupModels_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (List<CollectionItemGroupModel>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x600132B")]
		[Cpp2IlInjected.Address(RVA = "0x11464D0", Offset = "0x1144ED0", VA = "0x1811464D0")]
		public CollectionModel()
		{
		}
	}
}
