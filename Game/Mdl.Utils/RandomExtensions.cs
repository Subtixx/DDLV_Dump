using System;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200079B")]
	public static class RandomExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60021CD")]
		[Cpp2IlInjected.Address(RVA = "0xCB9F70", Offset = "0xCB8970", VA = "0x180CB9F70")]
		public static float NextFloat(this Random rand)
		{
			double num = rand.NextDouble();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021CE")]
		[Cpp2IlInjected.Address(RVA = "0xCB9FA0", Offset = "0xCB89A0", VA = "0x180CB9FA0")]
		public static float Next(this Random rand, float min, float max)
		{
			double num = rand.NextDouble();
			throw new NullReferenceException();
		}
	}
}
