using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A62")]
	public class MyVector2
	{
		[Cpp2IlInjected.Token(Token = "0x17000EC7")]
		public double X
		{
			[Cpp2IlInjected.Token(Token = "0x60059DD")]
			[Cpp2IlInjected.Address(RVA = "0x1083830", Offset = "0x1082230", VA = "0x181083830")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000EC8")]
		public double Y
		{
			[Cpp2IlInjected.Token(Token = "0x60059DE")]
			[Cpp2IlInjected.Address(RVA = "0x1395420", Offset = "0x1393E20", VA = "0x181395420")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60059DF")]
		[Cpp2IlInjected.Address(RVA = "0x13953E0", Offset = "0x1393DE0", VA = "0x1813953E0")]
		public MyVector2(double x, double y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60059E0")]
		[Cpp2IlInjected.Address(RVA = "0x1395310", Offset = "0x1393D10", VA = "0x181395310")]
		public static double Distance(MyVector2 value1, MyVector2 value2)
		{
			int num = 0;
			throw new NullReferenceException();
		}
	}
}
