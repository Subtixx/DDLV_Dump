using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000358")]
	public class ItemSlotModel
	{
		[Cpp2IlInjected.Token(Token = "0x2000359")]
		public class AlternateDataClass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400101A")]
			public string DisplayName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400101B")]
			public string IconAddress;

			[Cpp2IlInjected.Token(Token = "0x6001559")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public AlternateDataClass()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001018")]
		public bool IsForSkinPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001019")]
		public AlternateDataClass AlternateData;

		[Cpp2IlInjected.Token(Token = "0x170003B2")]
		public IItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001554")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001555")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001556")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public virtual void UpdateDisplay(ItemSlot itemSlot)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001557")]
		[Cpp2IlInjected.Address(RVA = "0x1324990", Offset = "0x1323390", VA = "0x181324990", Slot = "5")]
		public virtual void Release(ItemSlot itemSlot)
		{
			//IL_0009: Expected O, but got I8
			ItemData = (IItemData)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001558")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ItemSlotModel()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			UpdateDisplay((ItemSlot)num);
		}
	}
}
