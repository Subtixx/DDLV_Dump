using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Missions
{
	[Cpp2IlInjected.Token(Token = "0x200025A")]
	public enum MissionStepType
	{
		[Cpp2IlInjected.Token(Token = "0x400095C")]
		[OriginalName("StepGameplay")]
		StepGameplay,
		[Cpp2IlInjected.Token(Token = "0x400095D")]
		[OriginalName("StepItem")]
		StepItem,
		[Cpp2IlInjected.Token(Token = "0x400095E")]
		[OriginalName("StepWaiting")]
		StepWaiting,
		[Cpp2IlInjected.Token(Token = "0x400095F")]
		[OriginalName("StepInventory")]
		StepInventory
	}
}
