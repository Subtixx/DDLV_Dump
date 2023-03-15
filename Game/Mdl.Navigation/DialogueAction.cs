using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using Mdl.Avatar;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BB0")]
	public abstract class DialogueAction : PlayerAction
	{
		[Cpp2IlInjected.Token(Token = "0x2000BB1")]
		public class SetupData
		{
			[Cpp2IlInjected.Token(Token = "0x1700073E")]
			public PlayerAvatar Avatar
			{
				[Cpp2IlInjected.Token(Token = "0x60035DE")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CAvatar_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60035DF")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CAvatar_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700073F")]
			public Vector3? AvatarPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60035E0")]
				[Cpp2IlInjected.Address(RVA = "0x8FD6D0", Offset = "0x8FC0D0", VA = "0x1808FD6D0")]
				[CompilerGenerated]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[Cpp2IlInjected.Token(Token = "0x60035E1")]
				[Cpp2IlInjected.Address(RVA = "0x997FC0", Offset = "0x9969C0", VA = "0x180997FC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000740")]
			public DialogueTree DialogueTree
			{
				[Cpp2IlInjected.Token(Token = "0x60035E2")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CDialogueTree_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60035E3")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CDialogueTree_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000741")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4004120")]
			public Item CharacterItem
			{
				[Cpp2IlInjected.Token(Token = "0x60035E4")]
				[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60035E5")]
				[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000742")]
			public unsafe Vector3 CharacterPosition
			{
				[Cpp2IlInjected.Token(Token = "0x60035E6")]
				[Cpp2IlInjected.Address(RVA = "0x137EEB0", Offset = "0x137D8B0", VA = "0x18137EEB0")]
				[CompilerGenerated]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[Cpp2IlInjected.Token(Token = "0x60035E7")]
				[Cpp2IlInjected.Address(RVA = "0x137EED0", Offset = "0x137D8D0", VA = "0x18137EED0")]
				[CompilerGenerated]
				set
				{
					//IL_000e: Expected native int or pointer, but got O
					float z = value.z;
					((Vector3*)(IntPtr)_003CCharacterPosition_003Ek__BackingField)->z = z;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000743")]
			public PlayerTask Task
			{
				[Cpp2IlInjected.Token(Token = "0x60035E8")]
				[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
				[CompilerGenerated]
				get
				{
					return _003CTask_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60035E9")]
				[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
				[CompilerGenerated]
				set
				{
					_003CTask_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000744")]
			public List<IResolver> BlackboardResolvers
			{
				[Cpp2IlInjected.Token(Token = "0x60035EA")]
				[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
				[CompilerGenerated]
				get
				{
					return _003CBlackboardResolvers_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60035EB")]
				[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
				[CompilerGenerated]
				set
				{
					_003CBlackboardResolvers_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000745")]
			public Dictionary<string, object> BlackboardValues
			{
				[Cpp2IlInjected.Token(Token = "0x60035EC")]
				[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
				[CompilerGenerated]
				get
				{
					return _003CBlackboardValues_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60035ED")]
				[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
				[CompilerGenerated]
				set
				{
					_003CBlackboardValues_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000746")]
			public Transform CameraToUse
			{
				[Cpp2IlInjected.Token(Token = "0x60035EE")]
				[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
				[CompilerGenerated]
				get
				{
					return _003CCameraToUse_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60035EF")]
				[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
				[CompilerGenerated]
				set
				{
					_003CCameraToUse_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000747")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x60"), Cpp2IlInjected.Token(Token = "0x4004126")]
			public bool UseFade
			{
				[Cpp2IlInjected.Token(Token = "0x60035F0")]
				[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60035F1")]
				[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
				set;
			} = true;


			[Cpp2IlInjected.Token(Token = "0x17000748")]
			public HashSet<GameObject> CullingExceptions
			{
				[Cpp2IlInjected.Token(Token = "0x60035F2")]
				[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
				[CompilerGenerated]
				get
				{
					return _003CCullingExceptions_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60035F3")]
				[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
				[CompilerGenerated]
				set
				{
					_003CCullingExceptions_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000749")]
			public GameObject ItemPreview
			{
				[Cpp2IlInjected.Token(Token = "0x60035F4")]
				[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
				[CompilerGenerated]
				get
				{
					return _003CItemPreview_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60035F5")]
				[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
				[CompilerGenerated]
				set
				{
					_003CItemPreview_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60035F6")]
			[Cpp2IlInjected.Address(RVA = "0x137EEA0", Offset = "0x137D8A0", VA = "0x18137EEA0")]
			public SetupData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004119")]
		public float ExclusionRadius = 5f;

		[Cpp2IlInjected.Token(Token = "0x400411A")]
		public const string DO_ACCEPT = "doAccept";

		[Cpp2IlInjected.Token(Token = "0x400411B")]
		public const string CAN_DO_OPERATION = "canDoOp";

		[Cpp2IlInjected.Token(Token = "0x400411C")]
		public const string COST = "cost";

		[Cpp2IlInjected.Token(Token = "0x60035DC")]
		[Cpp2IlInjected.Address(RVA = "0x162EB70", Offset = "0x162D570", VA = "0x18162EB70")]
		[AsyncStateMachine(typeof(_003CSetupAndRunDialogue_003Ed__5))]
		public Task<IBlackboard> SetupAndRunDialogue(SetupData setup, [Optional] CancellationToken ct, [Optional] List<uint> disabledVOs)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<IBlackboard>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60035DD")]
		[Cpp2IlInjected.Address(RVA = "0x162ECF0", Offset = "0x162D6F0", VA = "0x18162ECF0")]
		protected DialogueAction()
		{
		}
	}
}
