using Cpp2IlInjected;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class CircularBuffer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private T[] arr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private int startIndex;

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x4000279")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x14969B0", Offset = "0x14953B0", VA = "0x1814969B0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x1496940", Offset = "0x1495340", VA = "0x181496940")]
		public CircularBuffer(int capacity)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x3329B80", Offset = "0x3328580", VA = "0x183329B80")]
		public void Add(T value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
