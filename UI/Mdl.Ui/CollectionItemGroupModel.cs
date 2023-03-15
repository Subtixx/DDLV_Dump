using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Meta.Collections;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002EB")]
	public class CollectionItemGroupModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000345")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000E2B")]
		public bool IsFirstGroup
		{
			[Cpp2IlInjected.Token(Token = "0x60012E6")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012E7")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000346")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x11"), Cpp2IlInjected.Token(Token = "0x4000E2C")]
		public bool IsLastGroup
		{
			[Cpp2IlInjected.Token(Token = "0x60012E8")]
			[Cpp2IlInjected.Address(RVA = "0x5706D0", Offset = "0x56F0D0", VA = "0x1805706D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012E9")]
			[Cpp2IlInjected.Address(RVA = "0x570700", Offset = "0x56F100", VA = "0x180570700")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000347")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000E2D")]
		public int TotalItems
		{
			[Cpp2IlInjected.Token(Token = "0x60012EA")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012EB")]
			[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000348")]
		public List<CollectionInfo> CollectionInfos
		{
			[Cpp2IlInjected.Token(Token = "0x60012EC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CCollectionInfos_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60012ED")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CCollectionInfos_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000349")]
		public CollectionMenuModel MenuModel
		{
			[Cpp2IlInjected.Token(Token = "0x60012EE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CMenuModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60012EF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CMenuModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034A")]
		public CollectionSetItemData CollectionSetItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60012F0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CCollectionSetItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60012F1")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CCollectionSetItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034B")]
		public List<CollectionItemModel> CollectionItemModels
		{
			[Cpp2IlInjected.Token(Token = "0x60012F2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CCollectionItemModels_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60012F3")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CCollectionItemModels_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (List<CollectionItemModel>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x1700034C")]
		public bool ShowHeader
		{
			[Cpp2IlInjected.Token(Token = "0x60012F4")]
			[Cpp2IlInjected.Address(RVA = "0x1003DB0", Offset = "0x10027B0", VA = "0x181003DB0")]
			get
			{
				if (CollectionSetItemData.submenu_ <= CollectionSubMenu.Crafting)
				{
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012F5")]
		[Cpp2IlInjected.Address(RVA = "0x1003D30", Offset = "0x1002730", VA = "0x181003D30")]
		public CollectionItemGroupModel()
		{
		}
	}
}
