using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000698")]
	public interface ICharacterDialog
	{
		[Cpp2IlInjected.Token(Token = "0x17001377")]
		string GetCharacterDialog
		{
			[Cpp2IlInjected.Token(Token = "0x6004AEA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001378")]
		bool CompleteObjectiveAfterDialogue
		{
			[Cpp2IlInjected.Token(Token = "0x6004AEB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6004AEC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CheckCharacterDialogStatus(MissionStepStatus status);
	}
}
