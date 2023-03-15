using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BF5")]
	internal class TalkActionData : IPlayerTaskData
	{
		[Cpp2IlInjected.Token(Token = "0x1700074C")]
		public DialogueTree DialogueTree
		{
			[Cpp2IlInjected.Token(Token = "0x600369F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CDialogueTree_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60036A0")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CDialogueTree_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700074D")]
		public IBlackboard Blackboard
		{
			[Cpp2IlInjected.Token(Token = "0x60036A1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CBlackboard_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60036A2")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CBlackboard_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700074E")]
		public string Step
		{
			[Cpp2IlInjected.Token(Token = "0x60036A3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CStep_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60036A4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CStep_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036A5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public TalkActionData()
		{
		}
	}
}
