using System;
using System.Diagnostics;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000035")]
public class PerformanceTests : MonoBehaviour
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class nested
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public class nested2
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000038")]
			public class neste3
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public float value;

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public neste3()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public float value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public neste3 _nested3;

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public nested2()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public float value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public nested2 _nested2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public bool bool1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
		public bool DirectMethod()
		{
			return bool1;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public nested()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private delegate bool MathAction();

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public int NumIterations = 10000000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private string report = "";

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public bool field;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public nested Nested;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public float value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public bool bool1;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA157F0", Offset = "0xA141F0", VA = "0x180A157F0")]
	public bool DirectMethod()
	{
		return bool1;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2F1C840", Offset = "0x2F1B240", VA = "0x182F1C840")]
	private void Start()
	{
		//Discarded unreachable code: IL_0111
		Stopwatch stopwatch = new Stopwatch();
		StopwatchExtensions.TestFunction testFunction = delegate
		{
			//Discarded unreachable code: IL_0019
			PerformanceTests performanceTests10 = this;
			int num15 = 0;
			int numIterations6 = performanceTests10.NumIterations;
			if (num15 < numIterations6)
			{
				num15++;
			}
		};
		long num = stopwatch.RunTest(testFunction);
		MathAction ma = Nested.DirectMethod;
		StopwatchExtensions.TestFunction testFunction2 = delegate
		{
			//Discarded unreachable code: IL_003e, IL_0043, IL_004a, IL_0050, IL_0056, IL_005b, IL_0068, IL_007f, IL_0086, IL_008b, IL_0090, IL_009d, IL_00b4, IL_00c5
			PerformanceTests performanceTests9 = this;
			int num11 = 0;
			int numIterations5 = performanceTests9.NumIterations;
			if (num11 < numIterations5)
			{
				Delegate[] delegates = ((MulticastDelegate)ma).delegates;
				int num12 = 0;
				if (delegates != null)
				{
				}
				uint num13 = default(uint);
				int num14 = default(int);
				if (num13 != 0)
				{
					num14 = 0;
					throw new ExecutionEngineException();
				}
				num11++;
				performanceTests9.bool1 = (byte)num14 != 0;
			}
		};
		long num2 = stopwatch.RunTest(testFunction2);
		string text = default(string);
		MonoBehaviour.print("Delegated Method: " + text);
		StopwatchExtensions.TestFunction testFunction3 = delegate
		{
			//Discarded unreachable code: IL_0020
			PerformanceTests performanceTests7 = this;
			int num10 = 0;
			int numIterations4 = performanceTests7.NumIterations;
			if (num10 < numIterations4)
			{
				PerformanceTests performanceTests8 = this;
				num10++;
			}
		};
		long num3 = stopwatch.RunTest(testFunction3);
		string text2 = default(string);
		MonoBehaviour.print("Direct Method: " + text2);
		StopwatchExtensions.TestFunction testFunction4 = delegate
		{
			//Discarded unreachable code: IL_0034
			PerformanceTests performanceTests5 = this;
			int num9 = 0;
			int numIterations3 = performanceTests5.NumIterations;
			if (num9 < numIterations3)
			{
				bool flag3 = performanceTests5.Nested.bool1;
				num9++;
				performanceTests5.bool1 = flag3;
				PerformanceTests performanceTests6 = this;
			}
		};
		long num4 = stopwatch.RunTest(testFunction4);
		string text3 = default(string);
		MonoBehaviour.print("Nested Direct Method: " + text3);
		StopwatchExtensions.TestFunction testFunction5 = delegate
		{
			//Discarded unreachable code: IL_0034
			PerformanceTests performanceTests3 = this;
			int num8 = 0;
			int numIterations2 = performanceTests3.NumIterations;
			if (num8 < numIterations2)
			{
				bool flag2 = performanceTests3.Nested.bool1;
				num8++;
				performanceTests3.bool1 = flag2;
				PerformanceTests performanceTests4 = this;
			}
		};
		long num5 = stopwatch.RunTest(testFunction5);
		string text4 = default(string);
		MonoBehaviour.print("Nested Direct field verification: " + text4);
		StopwatchExtensions.TestFunction testFunction6 = delegate
		{
			//Discarded unreachable code: IL_0034
			PerformanceTests performanceTests = this;
			int num7 = 0;
			int numIterations = performanceTests.NumIterations;
			if (num7 < numIterations)
			{
				bool flag = performanceTests.Nested.bool1;
				num7++;
				performanceTests.bool1 = flag;
				PerformanceTests performanceTests2 = this;
			}
		};
		long num6 = stopwatch.RunTest(testFunction6);
		string text5 = default(string);
		MonoBehaviour.print("Nested Direct field verification: " + text5);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2F1C780", Offset = "0x2F1B180", VA = "0x182F1C780")]
	private void OnGUI()
	{
		//IL_0024: Expected O, but got I4
		int num = 0;
		int width = Screen.width;
		int num2 = 0;
		int height = Screen.height;
		int num3 = 0;
		string text = report;
		string text2 = GUI.TextArea((Rect)num3, text);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F1CBD0", Offset = "0x2F1B5D0", VA = "0x182F1CBD0")]
	public PerformanceTests()
	{
	}//IL_000d: Expected I4, but got I8

}
