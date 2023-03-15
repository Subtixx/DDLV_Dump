using Cpp2IlInjected;
using PlayFab.CloudScriptModels;
using PlayFab.Internal;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public class ExecuteFunctionResult<T> : PlayFabResultCommon
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public FunctionExecutionError Error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public int ExecutionTimeMilliseconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public string FunctionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public T FunctionResult;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public bool? FunctionResultTooLarge;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x188E140", Offset = "0x188CB40", VA = "0x18188E140")]
		public ExecuteFunctionResult()
		{
		}//Discarded unreachable code: IL_0007

	}
}
