using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000A9D")]
	public enum SaveOnExitPolicyType
	{
		[Cpp2IlInjected.Token(Token = "0x4002985")]
		[OriginalName("Default")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4002986")]
		[OriginalName("NoSaveOnExit")]
		NoSaveOnExit,
		[Cpp2IlInjected.Token(Token = "0x4002987")]
		[OriginalName("OnPause")]
		OnPause,
		[Cpp2IlInjected.Token(Token = "0x4002988")]
		[OriginalName("OnFocusOut")]
		OnFocusOut,
		[Cpp2IlInjected.Token(Token = "0x4002989")]
		[OriginalName("OnQuit")]
		OnQuit,
		[Cpp2IlInjected.Token(Token = "0x400298A")]
		[OriginalName("SwitchExitRequest")]
		SwitchExitRequest
	}
}
