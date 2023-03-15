using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x2000985")]
	public abstract class Filter : IEquatable<Filter>
	{
		[Cpp2IlInjected.Token(Token = "0x17000820")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400384F")]
		public int Order
		{
			[Cpp2IlInjected.Token(Token = "0x6003BCE")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003BCF")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000821")]
		public abstract int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6003BD0")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000822")]
		public abstract string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003BD1")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000823")]
		public abstract string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003BD2")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000824")]
		public abstract Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003BD3")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000825")]
		public string Group
		{
			[Cpp2IlInjected.Token(Token = "0x6003BD4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CGroup_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003BD5")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CGroup_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003BD6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract bool Retains(object item);

		[Cpp2IlInjected.Token(Token = "0x6003BD7")]
		[Cpp2IlInjected.Address(RVA = "0x1536C40", Offset = "0x1535640", VA = "0x181536C40", Slot = "2")]
		public override int GetHashCode()
		{
			return ID;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BD8")]
		[Cpp2IlInjected.Address(RVA = "0x1536B40", Offset = "0x1535540", VA = "0x181536B40", Slot = "10")]
		public virtual bool Equals(Filter other)
		{
			if ((object)other != null)
			{
				int iD = other.ID;
				int iD2 = ID;
				return iD == iD2;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BD9")]
		[Cpp2IlInjected.Address(RVA = "0x1536BA0", Offset = "0x15355A0", VA = "0x181536BA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				int num = 0;
				if (obj != null)
				{
					int iD = ID;
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BDA")]
		[Cpp2IlInjected.Address(RVA = "0x1536C60", Offset = "0x1535660", VA = "0x181536C60")]
		public static bool operator ==(in Filter lhs, in Filter rhs)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BDB")]
		[Cpp2IlInjected.Address(RVA = "0x1536C90", Offset = "0x1535690", VA = "0x181536C90")]
		public static bool operator !=(in Filter lhs, in Filter rhs)
		{
			//Discarded unreachable code: IL_0002
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003BDC")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected Filter()
		{
		}
	}
}
