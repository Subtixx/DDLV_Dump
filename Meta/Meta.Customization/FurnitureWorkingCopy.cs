using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010F6")]
	public class FurnitureWorkingCopy
	{
		[Cpp2IlInjected.Token(Token = "0x17001830")]
		public Furniture Data
		{
			[Cpp2IlInjected.Token(Token = "0x6008A41")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A42")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001831")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6008A43")]
			[Cpp2IlInjected.Address(RVA = "0x180AD20", Offset = "0x1809720", VA = "0x18180AD20")]
			get
			{
				Furniture furniture = Data;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001832")]
		public FurnitureItem FurnitureItem
		{
			[Cpp2IlInjected.Token(Token = "0x6008A44")]
			[Cpp2IlInjected.Address(RVA = "0x180ACC0", Offset = "0x18096C0", VA = "0x18180ACC0")]
			get
			{
				Furniture furniture = Data;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A45")]
		[Cpp2IlInjected.Address(RVA = "0x180AB00", Offset = "0x1809500", VA = "0x18180AB00")]
		public int CurrentDesign()
		{
			//Discarded unreachable code: IL_000c
			return Data.currentDesign_;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A46")]
		[Cpp2IlInjected.Address(RVA = "0x10E0D90", Offset = "0x10DF790", VA = "0x1810E0D90")]
		public void SetCurrentDesign(int design)
		{
			//Discarded unreachable code: IL_000d
			Data.currentDesign_ = design;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A47")]
		[Cpp2IlInjected.Address(RVA = "0x180AB20", Offset = "0x1809520", VA = "0x18180AB20")]
		public FurnitureWorkingCopy(FurnitureWorkingCopy source)
		{
			Furniture furniture = source.Data;
			Furniture furniture2 = default(Furniture);
			furniture2.OnConstruction();
			uint num = (furniture2.id_ = furniture.id_);
			int num2 = (furniture2.furnitureItem_ = furniture.furnitureItem_);
			int num3 = (furniture2.currentDesign_ = furniture.currentDesign_);
			UnknownFieldSet unknownFieldSet = (furniture2._unknownFields = UnknownFieldSet.Clone(furniture._unknownFields));
			Data = furniture2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A48")]
		[Cpp2IlInjected.Address(RVA = "0x180ABE0", Offset = "0x18095E0", VA = "0x18180ABE0")]
		public FurnitureWorkingCopy(IFurniture source)
		{
			//IL_0013: Expected I4, but got O
			//IL_001a: Expected I4, but got O
			//IL_0021: Expected I4, but got O
			Furniture furniture = default(Furniture);
			furniture.OnConstruction();
			furniture.id_ = (uint)(int)furniture;
			furniture.furnitureItem_ = (int)furniture;
			furniture.currentDesign_ = (int)furniture;
			UnknownFieldSet unknownFields = default(UnknownFieldSet);
			furniture._unknownFields = unknownFields;
			Data = furniture;
			throw new NullReferenceException();
		}
	}
}
