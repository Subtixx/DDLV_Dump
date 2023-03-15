using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x2000839")]
	[AttributeUsage(AttributeTargets.Property)]
	public class CheatProperty : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x1700053B")]
		public string DeclarationOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600250B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CDeclarationOrder_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600250C")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CDeclarationOrder_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053C")]
		public string StringArrayProperty
		{
			[Cpp2IlInjected.Token(Token = "0x600250D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CStringArrayProperty_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600250E")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CStringArrayProperty_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700053D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4002DFF")]
		public int DefaultArrayIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600250F")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002510")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set;
		} = -1;


		[Cpp2IlInjected.Token(Token = "0x1700053E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x24"), Cpp2IlInjected.Token(Token = "0x4002E00")]
		public float MinValue
		{
			[Cpp2IlInjected.Token(Token = "0x6002511")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF70", Offset = "0xA7C970", VA = "0x180A7DF70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002512")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF90", Offset = "0xA7C990", VA = "0x180A7DF90")]
			set;
		} = -1f;


		[Cpp2IlInjected.Token(Token = "0x1700053F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4002E01")]
		public float MaxValue
		{
			[Cpp2IlInjected.Token(Token = "0x6002513")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002514")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
			set;
		} = -1f;


		[Cpp2IlInjected.Token(Token = "0x600250A")]
		[Cpp2IlInjected.Address(RVA = "0xA7DEA0", Offset = "0xA7C8A0", VA = "0x180A7DEA0")]
		public CheatProperty([CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
		{
			//Discarded unreachable code: IL_004c
			//IL_0010: Expected I4, but got I8
			string text = file.ToLower();
			int num = 0;
			string text2 = default(string);
			string text3 = (DeclarationOrder = text + "|" + text2);
		}
	}
}
