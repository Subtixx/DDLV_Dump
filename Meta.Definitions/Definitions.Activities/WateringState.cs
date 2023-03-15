using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x20008B9")]
	public enum WateringState
	{
		[Cpp2IlInjected.Token(Token = "0x4002ACB")]
		[OriginalName("WateringState_Watered")]
		Watered,
		[Cpp2IlInjected.Token(Token = "0x4002ACC")]
		[OriginalName("WateringState_Drying")]
		Drying,
		[Cpp2IlInjected.Token(Token = "0x4002ACD")]
		[OriginalName("WateringState_Dying")]
		Dying
	}
}
