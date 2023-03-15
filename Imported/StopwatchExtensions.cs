using System.Diagnostics;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class StopwatchExtensions
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate void TestFunction();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3DC2FB0", Offset = "0x3DC19B0", VA = "0x183DC2FB0")]
	public static long RunTest(this Stopwatch stopwatch, TestFunction testFunction)
	{
		//Discarded unreachable code: IL_0019
		stopwatch.Reset();
		stopwatch.Start();
		testFunction();
		return stopwatch.ElapsedMilliseconds;
	}
}
