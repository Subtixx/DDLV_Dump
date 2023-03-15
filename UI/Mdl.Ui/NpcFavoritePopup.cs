using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000527")]
	public class NpcFavoritePopup : Menu
	{
		[Cpp2IlInjected.Token(Token = "0x2000528")]
		public class NpcFavoritePopupParam : MenuParam
		{
			[Cpp2IlInjected.Token(Token = "0x1700053D")]
			public Character Character
			{
				[Cpp2IlInjected.Token(Token = "0x600218E")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CCharacter_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600218F")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CCharacter_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002190")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public NpcFavoritePopupParam()
			{
				((XmlSchemaNumericFacet)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001BC9")]
		[SerializeField]
		private NpcFavoritePanel _mcFavorites;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001BCA")]
		private NpcFavoritePopupParam _param;

		[Cpp2IlInjected.Token(Token = "0x6002186")]
		[Cpp2IlInjected.Address(RVA = "0x12A08E0", Offset = "0x129F2E0", VA = "0x1812A08E0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_002b
			((object)this)._002Ector();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CharacterPreferredItemDiscover value = OnCharacterFavoriteChanged;
			_003CDispatcher_003Ek__BackingField.OnCharacterPreferredItemDiscover += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002187")]
		[Cpp2IlInjected.Address(RVA = "0x12A0A10", Offset = "0x129F410", VA = "0x1812A0A10", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_002b
			base.UnregisterFocusedListeners();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CharacterPreferredItemDiscover value = OnCharacterFavoriteChanged;
			_003CDispatcher_003Ek__BackingField.OnCharacterPreferredItemDiscover -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6002188")]
		[Cpp2IlInjected.Address(RVA = "0x12A07B0", Offset = "0x129F1B0", VA = "0x1812A07B0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			base.OnPush(stack, param);
			if (param == null)
			{
			}
			int num = 0;
			_param = (NpcFavoritePopupParam)param;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002189")]
		[Cpp2IlInjected.Address(RVA = "0x12A0710", Offset = "0x129F110", VA = "0x1812A0710", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_003b
			base.OnFocusIn();
			NpcFavoritePopupParam param = _param;
			NpcFavoritePanel mcFavorites = _mcFavorites;
			Character _003CCharacter_003Ek__BackingField = param.Character;
			mcFavorites.RefreshDisplay(_003CCharacter_003Ek__BackingField);
			_mcFavorites.GetComponent<SlidingPanel>().Show(andOpen: true);
			base.IsDataUpToDate = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600218A")]
		[Cpp2IlInjected.Address(RVA = "0x12A0860", Offset = "0x129F260", VA = "0x1812A0860", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__7))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__7 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__7(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600218B")]
		[Cpp2IlInjected.Address(RVA = "0x12A0670", Offset = "0x129F070", VA = "0x1812A0670")]
		private void OnCharacterFavoriteChanged(Character character, int preferredIndex, PreferredItemStatus newStatus)
		{
			//Discarded unreachable code: IL_002e
			if (_param.Character == character)
			{
				Transform child = _mcFavorites._mcItemsContent.GetChild(preferredIndex);
				if ((object)child != null && (object)child.GetComponent<NpcFavoriteItem>() == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600218C")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public NpcFavoritePopup()
		{
		}
	}
}
