using System.Text;
using Cpp2IlInjected;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AB3")]
	public class Crc32
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002AD3")]
		private uint[] table = new uint[256];

		[Cpp2IlInjected.Token(Token = "0x4002AD4")]
		private const uint poly = 3988292384u;

		[Cpp2IlInjected.Token(Token = "0x1700103B")]
		[field: Cpp2IlInjected.Token(Token = "0x4002AD2")]
		public static Crc32 Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6005CFB")]
			[Cpp2IlInjected.Address(RVA = "0x18BCD90", Offset = "0x18BB790", VA = "0x1818BCD90")]
			get;
		} = new Crc32();


		[Cpp2IlInjected.Token(Token = "0x6005CFC")]
		[Cpp2IlInjected.Address(RVA = "0x18BCA10", Offset = "0x18BB410", VA = "0x1818BCA10")]
		public static uint ComputeChecksum(string s)
		{
			//Discarded unreachable code: IL_0013
			int num = 0;
			return ComputeChecksum(Encoding.UTF8.GetBytes(s));
		}

		[Cpp2IlInjected.Token(Token = "0x6005CFD")]
		[Cpp2IlInjected.Address(RVA = "0x18BCA90", Offset = "0x18BB490", VA = "0x1818BCA90")]
		public static uint ComputeChecksum(byte[] bytes)
		{
			//Discarded unreachable code: IL_0021
			Crc32 crc = Instance;
			int num = 0;
			uint[] array = crc.table;
			int length = bytes.Length;
			if (num < length)
			{
				num++;
			}
			return uint.MaxValue;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CFE")]
		[Cpp2IlInjected.Address(RVA = "0x18BCC10", Offset = "0x18BB610", VA = "0x1818BCC10")]
		private Crc32()
		{
			//Discarded unreachable code: IL_0041
			uint[] array = table;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				array[0] = (uint)num;
				num++;
				uint[] array2 = table;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CFF")]
		[Cpp2IlInjected.Address(RVA = "0x18BCBB0", Offset = "0x18BB5B0", VA = "0x1818BCBB0")]
		static Crc32()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
