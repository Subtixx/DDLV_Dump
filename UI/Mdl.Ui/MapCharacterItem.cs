using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Missions;
using Gameloft.Localization.Core;
using Mdl.Characters;
using Mdl.Missions;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000625")]
	[RequiredAllNotNull]
	[RequireComponent(typeof(BaseButton))]
	public class MapCharacterItem : MapItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002235")]
		private Meta.Character _character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002236")]
		[SerializeField]
		private AsyncAtlassedIcon _portrait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002237")]
		[SerializeField]
		private GameObject _mcInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002238")]
		[SerializeField]
		private GameObject _mcIconSleeping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002239")]
		[SerializeField]
		private GameObject _mcIconAtHome;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400223A")]
		[SerializeField]
		private GameObject _mcIconAtRestaurant;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400223B")]
		[SerializeField]
		private SpriteAtlasImage _portraitBackgroundRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400223C")]
		[SerializeField]
		private SpriteAtlasImage _portraitBackgroundQuestAvailable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400223D")]
		[SerializeField]
		private SpriteAtlasImage _portraitBackgroundQuestOnGoing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400223E")]
		[SerializeField]
		private SpriteAtlasImage _portraitBackgroundQuestCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400223F")]
		[SerializeField]
		private GameObject _questMarkerHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002240")]
		[SerializeField]
		private SpriteAtlasImage _questAvailableIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002241")]
		[SerializeField]
		private SpriteAtlasImage _questOnGoingIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002242")]
		[SerializeField]
		private SpriteAtlasImage _questCompletedIcon;

		[Cpp2IlInjected.Token(Token = "0x17000609")]
		public GameObject Portrait
		{
			[Cpp2IlInjected.Token(Token = "0x600281F")]
			[Cpp2IlInjected.Address(RVA = "0xFB1190", Offset = "0xFAFB90", VA = "0x180FB1190")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _portrait.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700060A")]
		internal unsafe override bool IsPinned
		{
			[Cpp2IlInjected.Token(Token = "0x6002820")]
			[Cpp2IlInjected.Address(RVA = "0xFAFFE0", Offset = "0xFAE9E0", VA = "0x180FAFFE0", Slot = "4")]
			get
			{
				return base.IsPinned;
			}
			[Cpp2IlInjected.Token(Token = "0x6002821")]
			[Cpp2IlInjected.Address(RVA = "0xFB11B0", Offset = "0xFAFBB0", VA = "0x180FB11B0", Slot = "5")]
			set
			{
				//Discarded unreachable code: IL_005b
				Item item;
				GoBehaviourSystem system;
				do
				{
					base.IsPinned = value;
					item = _character.base_.Item;
					system = SystemRoot.Instance.GetSystem<GoBehaviourSystem>();
					if (value)
					{
						if (*(Item*)system.trailTarget != *(Item*)item)
						{
							system.TrailTarget = item;
						}
						return;
					}
				}
				while (!(*(Item*)system.trailTarget == *(Item*)item));
				Item item2 = (system.TrailTarget = Item.Invalid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002822")]
		[Cpp2IlInjected.Address(RVA = "0xFB0BC0", Offset = "0xFAF5C0", VA = "0x180FB0BC0")]
		public void RefreshData(CharacterManager.CharacterInstance instance)
		{
			//Discarded unreachable code: IL_01e0
			Meta.Character character = (_character = instance.MetaCharacter);
			AsyncAtlassedIcon portrait = _portrait;
			string iconAddress_ = character.Data.iconAddress_;
			bool flag = portrait.SetIcon(iconAddress_);
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			Item item = character.base_.Item;
			bool active = default(bool);
			_mcInactive.SetActive(active);
			_mcIconSleeping.SetActive(active);
			Profile profile = SystemRoot.Instance.Client.Profile;
			bool active2 = instance.Active;
			Item item2 = character.base_.Item;
			GameObject mcIconAtHome = _mcIconAtHome;
			ScheduleType scheduleType = default(ScheduleType);
			int num = (int)scheduleType;
			if (active2)
			{
			}
			if (scheduleType <= ScheduleType.Outdoor)
			{
			}
			bool active3 = num == 8;
			mcIconAtHome.SetActive(active3);
			GameObject mcIconAtRestaurant = _mcIconAtRestaurant;
			if (!active2)
			{
			}
			mcIconAtRestaurant.SetActive(active3);
			Item item3 = character.base_.Item;
			GameObject questMarkerHolder = _questMarkerHolder;
			MissionSlotState missionSlotState = default(MissionSlotState);
			int num2 = (int)missionSlotState;
			bool active4 = missionSlotState != MissionSlotState.Invalid;
			questMarkerHolder.SetActive(active4);
			GameObject gameObject = _questAvailableIcon.gameObject;
			bool active5 = num2 == 1;
			gameObject.SetActive(active5);
			GameObject gameObject2 = _questOnGoingIcon.gameObject;
			bool active6 = num2 == 2;
			gameObject2.SetActive(active6);
			GameObject gameObject3 = _questCompletedIcon.gameObject;
			bool active7 = num2 == 3;
			gameObject3.SetActive(active7);
			GameObject gameObject4 = _portraitBackgroundRegular.gameObject;
			bool active8 = num2 == 0;
			gameObject4.SetActive(active8);
			_portraitBackgroundQuestAvailable.gameObject.SetActive(active5);
			_portraitBackgroundQuestOnGoing.gameObject.SetActive(active6);
			_portraitBackgroundQuestCompleted.gameObject.SetActive(active7);
			GoBehaviourSystem system2 = SystemRoot.Instance.GetSystem<GoBehaviourSystem>();
			Item trailTarget = system2.trailTarget;
			bool flag2 = default(bool);
			if (flag2)
			{
				Item trailTarget2 = system2.trailTarget;
				if ((object)_character.base_.Item != null)
				{
					((Action<T>)(object)OnMapItemClicked)?.Invoke((T)this);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002823")]
		[Cpp2IlInjected.Address(RVA = "0xFB0870", Offset = "0xFAF270", VA = "0x180FB0870")]
		public void OnClicked()
		{
			//Discarded unreachable code: IL_005e
			//IL_008b: Expected I4, but got I8
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			Item item = _character.base_.Item;
			bool flag = default(bool);
			if (!flag)
			{
				((Action<T>)(object)OnMapItemClicked)?.Invoke((T)this);
				return;
			}
			Localizator _003CLocalizator_003Ek__BackingField = SystemRoot.Instance._localizationManager.Localizator;
			Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			CharacterItemData data = _character.Data;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002824")]
		[Cpp2IlInjected.Address(RVA = "0xFB0790", Offset = "0xFAF190", VA = "0x180FB0790", Slot = "6")]
		internal override void CopyTo(MapItem target)
		{
			//Discarded unreachable code: IL_0037
			if ((object)target != null)
			{
				int num = 0;
				if ((object)target != null)
				{
					GameObject pinVisual = PinVisual;
					GameObject pinVisual2 = target.PinVisual;
					bool activeSelf = pinVisual.activeSelf;
					pinVisual2.SetActive(activeSelf);
					Action<MapItem> action = (target.OnMapItemClicked = OnMapItemClicked);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002825")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public MapCharacterItem()
		{
		}
	}
}
