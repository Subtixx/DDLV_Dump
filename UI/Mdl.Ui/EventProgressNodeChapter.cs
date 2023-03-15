using System;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Mdl.Missions;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200046A")]
	[ExecuteInEditMode]
	public class EventProgressNodeChapter : EventProgressNodeBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001667")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001668")]
		[SerializeField]
		private TextBase _tfState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001669")]
		[SerializeField]
		private GameObject _mcLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400166A")]
		[SerializeField]
		private GameObject _mcCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400166B")]
		[SerializeField]
		private Image _mcOutline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400166C")]
		[SerializeField]
		private AsyncAtlassedIcon _mcPortrait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400166D")]
		[SerializeField]
		private GameObject _mcPurchase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400166E")]
		[SerializeField]
		[Space]
		[ItemID]
		private int _character = (int)Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400166F")]
		private CharacterItemData _characterItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001670")]
		public EventChapterModel Model;

		[Cpp2IlInjected.Token(Token = "0x170004AE")]
		public CharacterItemData CharacterItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001C81")]
			[Cpp2IlInjected.Address(RVA = "0x1401BD0", Offset = "0x14005D0", VA = "0x181401BD0")]
			get
			{
				//Discarded unreachable code: IL_0027
				int num = 0;
				if ((object)typeof(Item).TypeHandle != null)
				{
					int character = _character;
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					CharacterItemData characterItemData = default(CharacterItemData);
					_characterItemData = characterItemData;
					return characterItemData;
				}
				return _characterItemData;
			}
			[Cpp2IlInjected.Token(Token = "0x6001C82")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			set
			{
				_characterItemData = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C83")]
		[Cpp2IlInjected.Address(RVA = "0x1401600", Offset = "0x1400000", VA = "0x181401600", Slot = "5")]
		public override void RefreshDisplay()
		{
			int num = 0;
			if (Application.isPlaying && (long)Model != 0)
			{
				Item _003CCharacterItem_003Ek__BackingField = Model.CharacterItem;
				CharacterItemData characterItemData = default(CharacterItemData);
				_characterItemData = characterItemData;
				Transform transform = base.transform;
				EventChapterModel model = Model;
				Vector2 _003CNodePosition_003Ek__BackingField = model.NodePosition;
				float y = model.NodePosition.y;
				int num2 = 0;
				TextBase tfTitle = _tfTitle;
				int num3 = 0;
				if ((object)typeof(Item).TypeHandle != null)
				{
					int character = _character;
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					CharacterItemData characterItemData2 = default(CharacterItemData);
					_characterItemData = characterItemData2;
				}
				string text = (tfTitle.StringID = _characterItemData.displayName_);
				CharacterItemData characterItemData3 = _characterItemData;
				AsyncAtlassedIcon mcPortrait = _mcPortrait;
				string iconAddress_ = characterItemData3.iconAddress_;
				bool flag = mcPortrait.SetIcon(iconAddress_);
				EventChapterModel.State state = Model.GetState();
				GameObject mcPurchase = _mcPurchase;
				int num4 = (int)state;
				if ((Model.IsPremium ? 1 : 0) == num2)
				{
				}
				bool active = num4 == 1;
				mcPurchase.SetActive(active);
				GameObject mcLocked = _mcLocked;
				bool active2 = num4 == 0;
				mcLocked.SetActive(active2);
				GameObject mcCompleted = _mcCompleted;
				bool active3 = num4 == 2;
				mcCompleted.SetActive(active3);
				Image mcOutline = _mcOutline;
				if (num4 == 0)
				{
					int num5 = 0;
				}
				Color white = Color.white;
				TextBase tfState = _tfState;
				if (num4 != 1)
				{
					float b = ((UnityEngine.UI.Graphic)_tfState.TextComponent).m_Color.b;
					throw new NullReferenceException();
				}
				tfState.StringID = "event.chapter_welcome_label";
				TextMeshProUGUI textComponent = _tfState.TextComponent;
				Color white2 = Color.white;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C84")]
		[Cpp2IlInjected.Address(RVA = "0x1401150", Offset = "0x13FFB50", VA = "0x181401150", Slot = "4")]
		public override int GetStateValue()
		{
			EventChapterModel model = Model;
			if (model != null)
			{
				EventChapterModel.State state = model.GetState();
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C85")]
		[Cpp2IlInjected.Address(RVA = "0x14012A0", Offset = "0x13FFCA0", VA = "0x1814012A0")]
		public void OnClicked()
		{
			//Discarded unreachable code: IL_007e
			//IL_007b: Expected O, but got I4
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			CharacterItemData characterItemData = _characterItemData;
			ProfileWorld world_ = profile.world_;
			int iD = characterItemData.ID;
			Character character2 = default(Character);
			Character character = character2;
			if ((long)character != 0)
			{
				int num = 0;
				UiRoot.Instance._menuStack.Pop();
				var vars = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
				{
					OnComplete = (_003COnComplete_003Ej__TPar)(TweenDelegate)delegate
					{
						//Discarded unreachable code: IL_0023
						//IL_0022: Expected O, but got I4
						//IL_0022: Expected O, but got I4
						GoBehaviourSystem system = SystemRoot.Instance.GetSystem<GoBehaviourSystem>();
						int num3 = 0;
						Character character3 = character;
						int num4 = 0;
						system.GoRedirect(GoBehavior.TalkToCharacter, character3, (byte)num4 != 0, (MissionSlot)num3, (Nullable<>)num3);
					}
				};
				int num2 = 0;
				TweenMax tweenMax = TweenMax.To(this, 1f, vars, int.MinValue, num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C86")]
		[Cpp2IlInjected.Address(RVA = "0x14014F0", Offset = "0x13FFEF0", VA = "0x1814014F0")]
		public void OnPurchaseClicked()
		{
			//Discarded unreachable code: IL_001c
			int num = 0;
			if (UiRoot.Instance._menuStack.Top == null)
			{
			}
			int num2 = 0;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C87")]
		[Cpp2IlInjected.Address(RVA = "0x1401170", Offset = "0x13FFB70", VA = "0x181401170")]
		public void OnCheatClicked()
		{
			//Discarded unreachable code: IL_0053
			//IL_003f: Expected I8, but got I4
			int num = 0;
			MegaEventData megaEventData = FakeData.Instance.MegaEventData;
			if (megaEventData != null)
			{
				RepeatedField<MegaEventChapterData> chapters_ = megaEventData.chapters_;
				Predicate<MegaEventChapterData> predicate = (Predicate<MegaEventChapterData>)(object)(Predicate<T>)delegate(MegaEventChapterData x)
				{
					//Discarded unreachable code: IL_001b
					string name_ = x.name_;
					string _003CName_003Ek__BackingField = Model.Name;
					return string.Equals(name_, _003CName_003Ek__BackingField);
				};
				Duration openDelay_ = ((RepeatedField<>)(object)chapters_).Find<MegaEventChapterData>((Predicate<>)(object)predicate).openDelay_;
				int num2 = 0;
				openDelay_.Seconds = num2;
				int num3 = 0;
				UiRoot.Instance._menuStack.Pop();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C88")]
		[Cpp2IlInjected.Address(RVA = "0x1401B60", Offset = "0x1400560", VA = "0x181401B60")]
		public EventProgressNodeChapter()
		{
		}//IL_000d: Expected I4, but got O

	}
}
