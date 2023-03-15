using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Definitions;
using Definitions.Character;
using Definitions.Items;
using Mdl.Systems;
using Meta;
using Meta.Missions;
using Meta.Online;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees.Gameloft.Flux
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public class FluxStatement : IStatement, IFluxStatement
	{
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public static readonly string EmptyAnimation;

		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public static readonly ReadOnlyCollection<string> NpcAnimationsList;

		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public static readonly ReadOnlyCollection<string> AvatarAnimationsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private string _text = string.Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		[SerializeField]
		private string _comment = string.Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private string _category = string.Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		[SerializeField]
		private AudioClip _audio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		[SerializeField]
		private string _locId = string.Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[SerializeField]
		private string _meta = string.Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		[SerializeField]
		private int _flagIsOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		[SerializeField]
		private int _flagIsOff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		[SerializeField]
		private int _xpIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		[SerializeField]
		private bool _autoSkip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		[SerializeField]
		private bool _isLore;

		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private static List<int> xpMappping;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public string text
		{
			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
			get
			{
				return _text;
			}
			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			set
			{
				_text = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public string comment
		{
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _comment;
			}
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				_comment = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public AudioClip audio
		{
			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "5")]
			get
			{
				return _audio;
			}
			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			set
			{
				_audio = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public string locId
		{
			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _locId;
			}
			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				_locId = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public string meta
		{
			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "6")]
			get
			{
				return _meta;
			}
			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			set
			{
				_meta = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public int flagIsOn
		{
			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return _flagIsOn;
			}
			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x70BFE0", Offset = "0x70A9E0", VA = "0x18070BFE0")]
			set
			{
				_flagIsOn = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public int flagIsOff
		{
			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x70CB70", Offset = "0x70B570", VA = "0x18070CB70")]
			get
			{
				return _flagIsOff;
			}
			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x70CF70", Offset = "0x70B970", VA = "0x18070CF70")]
			set
			{
				_flagIsOff = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public int xpIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get
			{
				return _xpIndex;
			}
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set
			{
				_xpIndex = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public int xp
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x145D840", Offset = "0x145C240", VA = "0x18145D840", Slot = "7")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public bool AutoSkip
		{
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x70CA70", Offset = "0x70B470", VA = "0x18070CA70", Slot = "9")]
			get
			{
				return _autoSkip;
			}
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x70CE60", Offset = "0x70B860", VA = "0x18070CE60")]
			set
			{
				_autoSkip = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public bool IsLore
		{
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0xD2FCE0", Offset = "0xD2E6E0", VA = "0x180D2FCE0")]
			get
			{
				return _isLore;
			}
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x145D940", Offset = "0x145C340", VA = "0x18145D940")]
			set
			{
				_isLore = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public string choiceID
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return _003CchoiceID_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			set
			{
				_003CchoiceID_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x145C410", Offset = "0x145AE10", VA = "0x18145C410")]
		private unsafe static void InitXpMapping()
		{
			//IL_0077: Expected O, but got I4
			//IL_0080: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_009e: Expected O, but got I4
			//IL_00a7: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			int num = 0;
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			bool flag = _003CInstance_003Ek__BackingField.TryGet("Friendship", out *(Friendship*)num);
			if (flag && num != 0)
			{
				if (!flag || _003CInstance_003Ek__BackingField != null)
				{
				}
				bool flag2 = num == 1;
				if (num != (flag2 ? 1 : 0))
				{
					int num2 = default(int);
					if ((long)(IntPtr)_003CInstance_003Ek__BackingField < 0L)
					{
						num2++;
					}
					if (num2 == 1)
					{
						Regex _003CReProtoName_003Ek__BackingField = _003CInstance_003Ek__BackingField.ReProtoName;
						int num3 = default(int);
						if (num3 == 0)
						{
							RegexRunnerFactory factory = _003CReProtoName_003Ek__BackingField.factory;
							List<int> emptyAnimation = default(List<int>);
							EmptyAnimation = (string)(object)emptyAnimation;
							return;
						}
					}
				}
			}
			Debug.LogError("CharacterFriendship.xlsx.json contain invalid information about DialogueXP, should be a list like [-8, -4, -2, 0, 2, 4, 8]");
			List<int> list = (List<int>)(object)new List<T>();
			uint num4 = default(uint);
			((List<T>)(object)list).Add((T)num4);
			uint num5 = default(uint);
			((List<T>)(object)list).Add((T)num5);
			uint num6 = default(uint);
			((List<T>)(object)list).Add((T)num6);
			int num7 = 0;
			((List<T>)(object)list).Add((T)num7);
			uint num8 = default(uint);
			((List<T>)(object)list).Add((T)num8);
			uint num9 = default(uint);
			((List<T>)(object)list).Add((T)num9);
			uint num10 = default(uint);
			((List<T>)(object)list).Add((T)num10);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x145C870", Offset = "0x145B270", VA = "0x18145C870")]
		public bool IsUsingFlags()
		{
			while (_flagIsOn <= 0)
			{
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x145C860", Offset = "0x145B260", VA = "0x18145C860")]
		public bool IsUsingFlagOn()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x145C040", Offset = "0x145AA40", VA = "0x18145C040")]
		public string GetFlagOnName()
		{
			return GetItemDisplayName(_flagIsOn);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x145C850", Offset = "0x145B250", VA = "0x18145C850")]
		public bool IsUsingFlagOff()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x145BFE0", Offset = "0x145A9E0", VA = "0x18145BFE0")]
		public string GetFlagOffName()
		{
			return GetItemDisplayName(_flagIsOff);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x145D680", Offset = "0x145C080", VA = "0x18145D680")]
		public FluxStatement()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x145D750", Offset = "0x145C150", VA = "0x18145D750")]
		public FluxStatement(string text)
		{
			_text = text;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x145D450", Offset = "0x145BE50", VA = "0x18145D450")]
		public FluxStatement(string text, string locId)
		{
			_text = text;
			_locId = locId;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x145D570", Offset = "0x145BF70", VA = "0x18145D570")]
		public FluxStatement(string text, AudioClip audio)
		{
			_text = text;
			_audio = audio;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x145D1D0", Offset = "0x145BBD0", VA = "0x18145D1D0")]
		public FluxStatement(string text, AudioClip audio, string meta)
		{
			_text = text;
			_audio = audio;
			_meta = meta;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x145D300", Offset = "0x145BD00", VA = "0x18145D300")]
		public FluxStatement(string text, AudioClip audio, string locId, string meta)
		{
			//IL_0065: Expected O, but got I4
			_text = text;
			_audio = audio;
			_locId = locId;
			_meta = (string)0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x145B910", Offset = "0x145A310", VA = "0x18145B910")]
		public FluxStatement BlackboardReplace(IBlackboard bb, [Optional] MissionSlot slot, bool checkText = false)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x145C210", Offset = "0x145AC10", VA = "0x18145C210")]
		public FluxStatement InitChoice(IBlackboard bb, string DID, int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "3")]
		public override string ToString()
		{
			return _text;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x145C0A0", Offset = "0x145AAA0", VA = "0x18145C0A0")]
		public static string GetItemDisplayName(int itemId)
		{
			//Discarded unreachable code: IL_002c
			int num = 0;
			if (itemId == 0)
			{
				return "(None)";
			}
			long num2 = Convert.ToInt64((uint)itemId);
			bool flag = default(bool);
			if (flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			}
			string value = default(string);
			bool flag2 = string.IsNullOrEmpty(value);
			return "(Missing)";
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x145BE40", Offset = "0x145A840", VA = "0x18145BE40")]
		public bool CheckDialogueFlag()
		{
			Client metaClient = SystemRoot.Instance.MetaClient;
			int num = _flagIsOn;
			Profile profile = metaClient.profile;
			if (num != 0)
			{
				ProfileWorld world_ = profile.world_;
				long num2 = Convert.ToInt64((uint)num);
				bool flag = default(bool);
				if (!flag)
				{
					goto IL_0054;
				}
			}
			int num3 = _flagIsOff;
			if (num3 != 0)
			{
				ProfileWorld world_2 = profile.world_;
				long num4 = Convert.ToInt64((uint)num3);
				bool flag2 = default(bool);
				if (flag2)
				{
					goto IL_0054;
				}
			}
			goto IL_0057;
			IL_0054:
			int num5 = 0;
			goto IL_0057;
			IL_0057:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x145C890", Offset = "0x145B290", VA = "0x18145C890")]
		static FluxStatement()
		{
			ReadOnlyCollection<string> emptyAnimation2 = default(ReadOnlyCollection<string>);
			string[] array2;
			while (true)
			{
				EmptyAnimation = "- Empty -";
				string[] array = new string[12];
				string emptyAnimation = EmptyAnimation;
				if (emptyAnimation != null && array == null)
				{
					continue;
				}
				array[0] = emptyAnimation;
				if ("Angry" != null && "Angry" == null)
				{
					continue;
				}
				array[1] = "Angry";
				if ("Confused" != null && "Confused" == null)
				{
					continue;
				}
				array[2] = "Confused";
				if ("Happy" != null && "Happy" == null)
				{
					continue;
				}
				array[3] = "Happy";
				if ("Sad" != null && "Sad" == null)
				{
					continue;
				}
				array[4] = "Sad";
				if ("Laughing" != null && "Laughing" == null)
				{
					continue;
				}
				array[5] = "Laughing";
				if ("Interact" != null && "Interact" == null)
				{
					continue;
				}
				array[6] = "Interact";
				if ("Give" != null && "Give" == null)
				{
					continue;
				}
				array[7] = "Give";
				if ("Hello" != null && "Hello" == null)
				{
					continue;
				}
				array[8] = "Hello";
				if ("Discussion" != null && "Discussion" == null)
				{
					continue;
				}
				array[9] = "Discussion";
				if ("Collect" != null && "Collect" == null)
				{
					continue;
				}
				array[10] = "Collect";
				if ("Celebrate" != null && "Celebrate" == null)
				{
					continue;
				}
				array[11] = "Celebrate";
				EmptyAnimation = (string)(object)emptyAnimation2;
				array2 = new string[7];
				string emptyAnimation3 = EmptyAnimation;
				if (emptyAnimation3 != null && array2 == null)
				{
					continue;
				}
				array2[0] = emptyAnimation3;
				if ("Collect" != null && "Collect" == null)
				{
					continue;
				}
				array2[1] = "Collect";
				if ("Discussion" != null && "Discussion" == null)
				{
					continue;
				}
				array2[2] = "Discussion";
				if ("Interact" != null && "Interact" == null)
				{
					continue;
				}
				array2[3] = "Interact";
				if ("Hello" != null && "Hello" == null)
				{
					continue;
				}
				array2[4] = "Hello";
				if ("Give" == null || "Give" != null)
				{
					array2[5] = "Give";
					if ("Happy" == null || "Happy" != null)
					{
						break;
					}
				}
			}
			array2[6] = "Happy";
			ReadOnlyCollection<string> emptyAnimation4 = default(ReadOnlyCollection<string>);
			EmptyAnimation = (string)(object)emptyAnimation4;
			throw new NullReferenceException();
		}
	}
}
