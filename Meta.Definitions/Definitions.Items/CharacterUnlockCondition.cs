using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005FA")]
	public enum CharacterUnlockCondition
	{
		[Cpp2IlInjected.Token(Token = "0x40020A4")]
		[OriginalName("CharacterUnlockCondition_Purchase")]
		Purchase,
		[Cpp2IlInjected.Token(Token = "0x40020A5")]
		[OriginalName("CharacterUnlockCondition_Automatic")]
		Automatic,
		[Cpp2IlInjected.Token(Token = "0x40020A6")]
		[OriginalName("CharacterUnlockCondition_StoryReward")]
		StoryReward,
		[Cpp2IlInjected.Token(Token = "0x40020A7")]
		[OriginalName("CharacterUnlockCondition_Event")]
		Event,
		[Cpp2IlInjected.Token(Token = "0x40020A8")]
		[OriginalName("CharacterUnlockCondition_Secret")]
		Secret
	}
}
