using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Missions;
using Mdl.Ui.Widgets;
using Meta;
using Meta.Missions;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000204")]
	public class QuestFilterItem : FilterItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40008DE")]
		[SerializeField]
		private AsyncImage _characterIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40008DF")]
		[SerializeField]
		private AsyncAtlassedIcon _characterAtlassedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40008E1")]
		private ProfileWorld.FilterInfo _filterInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40008E2")]
		[SerializeField]
		private SpriteAtlasImage _questAvailableIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40008E3")]
		[SerializeField]
		private SpriteAtlasImage _questOnGoingIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40008E4")]
		[SerializeField]
		private SpriteAtlasImage _questCompletedIcon;

		[Cpp2IlInjected.Token(Token = "0x1700027B")]
		public Action<ProfileWorld.FilterInfo> OnClickedQuest
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE5")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF50", Offset = "0x7D9950", VA = "0x1807DAF50")]
			[CompilerGenerated]
			get
			{
				return _003COnClickedQuest_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000CE6")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4B0", Offset = "0x7D9EB0", VA = "0x1807DB4B0")]
			[CompilerGenerated]
			internal set
			{
				_003COnClickedQuest_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0xE25BF0", Offset = "0xE245F0", VA = "0x180E25BF0")]
		public void Init(ProfileWorld.FilterInfo filterInfo)
		{
			//Discarded unreachable code: IL_0154
			//IL_005f: Expected O, but got I4
			//IL_008f: Expected O, but got I4
			//IL_00bf: Expected O, but got I4
			//IL_00f7: Expected O, but got I4
			//IL_012f: Expected O, but got I4
			_filterInfo = filterInfo;
			MissionSlot missionSlot = _filterInfo.MissionSlot;
			if (missionSlot == null || missionSlot.Data == null || missionSlot.Data.ownerCharacter_ == 0)
			{
				return;
			}
			int ownerCharacter = missionSlot.Data.OwnerCharacter;
			bool flag = default(bool);
			if (flag && !flag)
			{
				AsyncImage characterIcon = _characterIcon;
				int num = 0;
				if (characterIcon != (UnityEngine.Object)num)
				{
					_characterIcon.gameObject.SetActive(value: true);
					AsyncImage characterIcon2 = _characterIcon;
				}
				AsyncAtlassedIcon characterAtlassedIcon = _characterAtlassedIcon;
				int num2 = 0;
				if (characterAtlassedIcon != (UnityEngine.Object)num2)
				{
					_characterAtlassedIcon.gameObject.SetActive(value: true);
					AsyncAtlassedIcon characterAtlassedIcon2 = _characterAtlassedIcon;
				}
			}
			SpriteAtlasImage questAvailableIcon = _questAvailableIcon;
			int num3 = 0;
			if (questAvailableIcon != (UnityEngine.Object)num3)
			{
				GameObject gameObject = _questAvailableIcon.gameObject;
				bool active = missionSlot.state_ == MissionSlotState.Available;
				gameObject.SetActive(active);
			}
			SpriteAtlasImage questOnGoingIcon = _questOnGoingIcon;
			int num4 = 0;
			if (questOnGoingIcon != (UnityEngine.Object)num4)
			{
				GameObject gameObject2 = _questOnGoingIcon.gameObject;
				bool active2 = missionSlot.state_ == MissionSlotState.OnGoing;
				gameObject2.SetActive(active2);
			}
			SpriteAtlasImage questCompletedIcon = _questCompletedIcon;
			int num5 = 0;
			if (questCompletedIcon != (UnityEngine.Object)num5)
			{
				GameObject gameObject3 = _questCompletedIcon.gameObject;
				bool active3 = missionSlot.state_ == MissionSlotState.Completed;
				gameObject3.SetActive(active3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0xE25FD0", Offset = "0xE249D0", VA = "0x180E25FD0")]
		public void TriggerOnClicked()
		{
			Action<ProfileWorld.FilterInfo> action = OnClickedQuest;
			if (action != null)
			{
				ProfileWorld.FilterInfo filterInfo = _filterInfo;
				action((T)filterInfo);
			}
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0xE26030", Offset = "0xE24A30", VA = "0x180E26030")]
		public QuestFilterItem()
		{
		}
	}
}
