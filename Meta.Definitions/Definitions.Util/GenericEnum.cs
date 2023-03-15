using System;
using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	public readonly struct GenericEnum : IEquatable<GenericEnum>, IEquatable<Enum>, IComparable<GenericEnum>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private readonly Type enumType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private readonly int intValue;

		[Cpp2IlInjected.Token(Token = "0x17000324")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000D03")]
			[Cpp2IlInjected.Address(RVA = "0x2F86740", Offset = "0x2F85140", VA = "0x182F86740")]
			get
			{
				//IL_0006: Expected I4, but got O
				return (byte)(int)typeof(Type).TypeHandle != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D04")]
		[Cpp2IlInjected.Address(RVA = "0x1C2D850", Offset = "0x1C2C250", VA = "0x181C2D850")]
		private GenericEnum(Type enumType, int intValue)
		{
			this.enumType = enumType;
			this.intValue = intValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D05")]
		[Cpp2IlInjected.Address(RVA = "0x2F865D0", Offset = "0x2F84FD0", VA = "0x182F865D0")]
		public Enum ToEnum()
		{
			object obj = default(object);
			if (obj == null)
			{
			}
			int num = 0;
			while (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		[Cpp2IlInjected.Address(RVA = "0x2F86490", Offset = "0x2F84E90", VA = "0x182F86490", Slot = "4")]
		public bool Equals(GenericEnum other)
		{
			//IL_0008: Expected I4, but got O
			int num = 0;
			return (byte)(int)typeof(Type).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D07")]
		[Cpp2IlInjected.Address(RVA = "0x2F863A0", Offset = "0x2F84DA0", VA = "0x182F863A0", Slot = "5")]
		public bool Equals(Enum other)
		{
			//Discarded unreachable code: IL_001c
			if ((object)other.GetType() == null)
			{
			}
			int num = intValue;
			int num2 = Convert.ToInt32(other);
			return num == num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D08")]
		[Cpp2IlInjected.Address(RVA = "0x2F862B0", Offset = "0x2F84CB0", VA = "0x182F862B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			if (obj == null || obj != null)
			{
			}
			int num = 0;
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D09")]
		[Cpp2IlInjected.Address(RVA = "0x2F86520", Offset = "0x2F84F20", VA = "0x182F86520", Slot = "2")]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0021
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected I8, but got Unknown
			//IL_001f: Expected I4, but got O
			if ((object)typeof(Type).TypeHandle != null)
			{
				int num = intValue;
				long num2 = typeof(Type).TypeHandle * 31;
				return (int)typeof(Type).TypeHandle;
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0A")]
		[Cpp2IlInjected.Address(RVA = "0x2F86680", Offset = "0x2F85080", VA = "0x182F86680", Slot = "3")]
		public override string ToString()
		{
			//Discarded unreachable code: IL_001a
			if ((object)typeof(Type).TypeHandle != null)
			{
				return ((IFetchable)ToEnum()).Description;
			}
			return "null";
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0B")]
		[Cpp2IlInjected.Address(RVA = "0x2F86130", Offset = "0x2F84B30", VA = "0x182F86130", Slot = "6")]
		public int CompareTo(GenericEnum other)
		{
			if ((object)typeof(Type).TypeHandle == null)
			{
				int num = intValue;
				int result = default(int);
				return result;
			}
			InvalidOperationException ex = new InvalidOperationException("Unable to compare GenericEnums that don't share the same enum type");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0C")]
		[Cpp2IlInjected.Address(RVA = "0x2F867A0", Offset = "0x2F851A0", VA = "0x182F867A0")]
		public static bool operator ==(GenericEnum lhs, GenericEnum rhs)
		{
			//IL_000f: Expected I4, but got O
			if ((object)typeof(Type).TypeHandle != null)
			{
				int num = 0;
			}
			return (byte)(int)typeof(Type).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x2F86830", Offset = "0x2F85230", VA = "0x182F86830")]
		public static bool operator !=(GenericEnum lhs, GenericEnum rhs)
		{
			//IL_000f: Expected I4, but got O
			if ((object)typeof(Type).TypeHandle != null)
			{
				int num = 0;
			}
			return (byte)(int)typeof(Type).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0x1BB6D20", Offset = "0x1BB5720", VA = "0x181BB6D20")]
		public static GenericEnum Create<T>(T enumValue) where T : struct, Enum
		{
			Type typeFromHandle = typeof(Type);
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x2F86210", Offset = "0x2F84C10", VA = "0x182F86210")]
		public static GenericEnum Create(Enum enumValue)
		{
			int num = 0;
			throw new NullReferenceException();
		}
	}
}
