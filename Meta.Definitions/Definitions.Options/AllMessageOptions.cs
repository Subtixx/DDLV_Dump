using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x20007A3")]
	public enum AllMessageOptions
	{
		[Cpp2IlInjected.Token(Token = "0x400264B")]
		[OriginalName("AllMessageOptions_None")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400264C")]
		[OriginalName("AllMessageOptions_MessageCustomEditor")]
		MessageCustomEditor = 52000,
		[Cpp2IlInjected.Token(Token = "0x400264D")]
		[OriginalName("AllMessageOptions_MessageCustomEditorField")]
		MessageCustomEditorField = 52001,
		[Cpp2IlInjected.Token(Token = "0x400264E")]
		[OriginalName("AllMessageOptions_MessageEditorStyleOverride")]
		MessageEditorStyleOverride = 52002,
		[Cpp2IlInjected.Token(Token = "0x400264F")]
		[OriginalName("AllMessageOptions_MessageParentEnumOption")]
		MessageParentEnumOption = 52003,
		[Cpp2IlInjected.Token(Token = "0x4002650")]
		[OriginalName("AllMessageOptions_TransactionPriority")]
		TransactionPriority = 52004
	}
}
