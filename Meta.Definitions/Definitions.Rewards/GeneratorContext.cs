using System;
using Cpp2IlInjected;
using Definitions.Util;

namespace Definitions.Rewards
{
	[Cpp2IlInjected.Token(Token = "0x2000236")]
	public class GeneratorContext : IGeneratorContext
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40008FC")]
		private readonly Random random;

		[Cpp2IlInjected.Token(Token = "0x170004BC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40008FD")]
		public IProfile Profile
		{
			[Cpp2IlInjected.Token(Token = "0x600155F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6001560")]
		[Cpp2IlInjected.Address(RVA = "0x1BE3E30", Offset = "0x1BE2830", VA = "0x181BE3E30")]
		public GeneratorContext(IProfile profile, Random random)
		{
			Profile = profile;
			this.random = random;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001561")]
		[Cpp2IlInjected.Address(RVA = "0x117BCF0", Offset = "0x117A6F0", VA = "0x18117BCF0", Slot = "4")]
		public int Next()
		{
			Random random = this.random;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001562")]
		[Cpp2IlInjected.Address(RVA = "0x2194300", Offset = "0x2192D00", VA = "0x182194300", Slot = "5")]
		public int Next(int max)
		{
			Random random = this.random;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001563")]
		[Cpp2IlInjected.Address(RVA = "0x1030540", Offset = "0x102EF40", VA = "0x181030540", Slot = "6")]
		public int Next(int min, int max)
		{
			Random random = this.random;
			throw new NullReferenceException();
		}
	}
}
