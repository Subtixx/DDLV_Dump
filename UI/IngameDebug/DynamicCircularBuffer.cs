using Cpp2IlInjected;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class DynamicCircularBuffer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private T[] arr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private int startIndex;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x400027C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x14969B0", Offset = "0x14953B0", VA = "0x1814969B0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x1496AB0", Offset = "0x14954B0", VA = "0x181496AB0")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1496940", Offset = "0x1495340", VA = "0x181496940")]
		public DynamicCircularBuffer(int initialCapacity = 2)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1496480", Offset = "0x1494E80", VA = "0x181496480")]
		public void Add(T value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1496740", Offset = "0x1495140", VA = "0x181496740")]
		public T RemoveFirst()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x14967E0", Offset = "0x14951E0", VA = "0x1814967E0")]
		public T RemoveLast()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
