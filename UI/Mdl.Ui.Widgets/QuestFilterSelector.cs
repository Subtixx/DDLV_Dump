using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009AA")]
	public class QuestFilterSelector : FilterItemSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40038EB")]
		[SerializeField]
		private QuestFilterItem _questItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40038ED")]
		private IEnumerable<ProfileWorld.FilterInfo> _missions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40038EE")]
		private bool _isInit;

		[Cpp2IlInjected.Token(Token = "0x17000858")]
		public Action<ProfileWorld.FilterInfo> OnQuestSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003CA3")]
			[Cpp2IlInjected.Address(RVA = "0x975F10", Offset = "0x974910", VA = "0x180975F10")]
			[CompilerGenerated]
			get
			{
				return _003COnQuestSelected_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003CA4")]
			[Cpp2IlInjected.Address(RVA = "0xE269B0", Offset = "0xE253B0", VA = "0x180E269B0")]
			[CompilerGenerated]
			internal set
			{
				_003COnQuestSelected_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CA5")]
		[Cpp2IlInjected.Address(RVA = "0xE26070", Offset = "0xE24A70", VA = "0x180E26070")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0026
			Button.ButtonClickedEvent onClick = _btnToggle.ButtonComponent.m_OnClick;
			UnityAction call = base.OnToggleClickHandler;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CA6")]
		[Cpp2IlInjected.Address(RVA = "0xE26040", Offset = "0xE24A40", VA = "0x180E26040")]
		public void Init(IEnumerable<ProfileWorld.FilterInfo> missions)
		{
			_missions = missions;
			Setup();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CA7")]
		[Cpp2IlInjected.Address(RVA = "0xE26990", Offset = "0xE25390", VA = "0x180E26990")]
		private void Start()
		{
			Setup();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CA8")]
		[Cpp2IlInjected.Address(RVA = "0xE26120", Offset = "0xE24B20", VA = "0x180E26120")]
		private void SelectQuest(ProfileWorld.FilterInfo filterInfo)
		{
			((Action<T>)(object)OnQuestSelected)?.Invoke((T)filterInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CA9")]
		[Cpp2IlInjected.Address(RVA = "0xE26180", Offset = "0xE24B80", VA = "0x180E26180")]
		private void Setup()
		{
			//Discarded unreachable code: IL_0179, IL_0185, IL_018b, IL_0191, IL_019d, IL_01af
			//IL_0059: Expected I4, but got I8
			//IL_00c5: Expected I4, but got I8
			//IL_00ec: Expected O, but got I4
			//IL_0118: Expected O, but got I4
			uint num2 = default(uint);
			ulong num3 = default(ulong);
			Delegate @delegate = default(Delegate);
			GameObject gameObject2 = default(GameObject);
			ulong num4 = default(ulong);
			IEnumerator enumerator = default(IEnumerator);
			bool flag = default(bool);
			TraitFilterItem traitFilterItem = default(TraitFilterItem);
			Transform transform = default(Transform);
			Button button = default(Button);
			Button button2 = default(Button);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				filtersAnchor.gameObject.DestroyAllChildrens();
				IEnumerable<ProfileWorld.FilterInfo> enumerable = (IEnumerable<ProfileWorld.FilterInfo>)ProfileWorld.FilterInfo.EnumSingleFilter((IEnumerable<>)_missions);
				if (enumerable != null)
				{
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_0091;
						}
						num++;
					}
					QuestFilterItem questItemPrefab = _questItemPrefab;
					RectTransform parent = filtersAnchor;
					QuestFilterItem questFilterItem = UnityEngine.Object.Instantiate(questItemPrefab, parent);
					questFilterItem.gameObject.SetActive((byte)num3 != 0);
					Action<ProfileWorld.FilterInfo> _003COnClickedQuest_003Ek__BackingField = questFilterItem.OnClickedQuest;
					Action<ProfileWorld.FilterInfo> b = (Action<ProfileWorld.FilterInfo>)(object)new Action<T>(SelectQuest);
					@delegate = Delegate.Combine(_003COnClickedQuest_003Ek__BackingField, b);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						questFilterItem.OnClickedQuest = (Action<ProfileWorld.FilterInfo>)@delegate;
						goto IL_0091;
					}
					throw new InvalidCastException();
				}
				goto IL_0098;
				IL_0098:
				if (enumerable != null)
				{
				}
				if (num == 0)
				{
					GameObject gameObject = filtersAnchor.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
					gameObject2.SetActive((byte)num4 != 0);
					if (enumerator != null)
					{
						int num5 = 0;
						if (enumerator == null)
						{
							break;
						}
						int num6 = 0;
						if (enumerator == null)
						{
							throw new InvalidCastException();
						}
						int num7 = 0;
						flag = traitFilterItem != (UnityEngine.Object)num7;
						while (!flag)
						{
						}
						traitFilterItem.RefreshSize();
					}
					int num8 = 0;
					if (flag)
					{
					}
					if (num != 0)
					{
						continue;
					}
					int num9 = 0;
					int num10 = 0;
					transform.rotation = (Quaternion)num9;
					Button.ButtonClickedEvent onClick = button.m_OnClick;
					UnityAction call = OnToggleClickHandler;
					onClick.RemoveListener(call);
					Button.ButtonClickedEvent onClick2 = button2.m_OnClick;
					UnityAction call2 = OnToggleClickHandler;
					onClick2.AddListener(call2);
					if (flag2)
					{
						int num11 = 0;
						UiRoot instance = UiRoot.Instance;
						int useKeyboardAsController = 0;
						if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
						{
						}
					}
					return;
				}
				throw new NullReferenceException();
				IL_0091:
				@delegate = (Delegate)(object)((object)@delegate + (object)@delegate);
				goto IL_0098;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CAA")]
		[Cpp2IlInjected.Address(RVA = "0xE269A0", Offset = "0xE253A0", VA = "0x180E269A0")]
		public QuestFilterSelector()
		{
		}
	}
}
