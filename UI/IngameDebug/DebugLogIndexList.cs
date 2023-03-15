using Cpp2IlInjected;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class DebugLogIndexList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private int[] indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private int size;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public int this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x112F960", Offset = "0x112E360", VA = "0x18112F960")]
			get
			{
				//Discarded unreachable code: IL_000d
				return indices[index];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x112F900", Offset = "0x112E300", VA = "0x18112F900")]
		public DebugLogIndexList()
		{
			//IL_001e: Expected I4, but got I8
			int[] array = (indices = new int[64]);
			size = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x112F850", Offset = "0x112E250", VA = "0x18112F850")]
		public void Add(int index)
		{
			//Discarded unreachable code: IL_002d
			int[] array = indices;
			int num = size;
			if (num == array.Length)
			{
			}
			int num2 = (size = num + 1);
			num2 = num;
			array[0] = index;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x112F8F0", Offset = "0x112E2F0", VA = "0x18112F8F0")]
		public void Clear()
		{
			//IL_0009: Expected I4, but got I8
			size = 0;
		}
	}
}
