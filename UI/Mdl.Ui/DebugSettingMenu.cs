using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Gameloft.Common;
using Google.Protobuf.Reflection;
using Mdl.Platform;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using Meta.Util;
using Rewired;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003EB")]
	public class DebugSettingMenu : Menu
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001338")]
		[SerializeField]
		private GameObject _prefabCheckBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001339")]
		[SerializeField]
		private GameObject _prefabSelectionBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400133A")]
		[SerializeField]
		private GameObject _prefabInputText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400133B")]
		[SerializeField]
		private GameObject _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400133C")]
		[SerializeField]
		private GameObject _mcContentHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400133D")]
		[SerializeField]
		private ScrollRect _mcScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400133E")]
		[SerializeField]
		private Slider _mcContentScaleSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400133F")]
		[SerializeField]
		private TextBase _tfVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001340")]
		[SerializeField]
		private GameObject _btnConfirm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001341")]
		private Rewired.Player _player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001342")]
		private MenuStack _menuStack;

		[Cpp2IlInjected.Token(Token = "0x60018EA")]
		[Cpp2IlInjected.Address(RVA = "0x1555E90", Offset = "0x1554890", VA = "0x181555E90", Slot = "25")]
		public override void OnPush(MenuStack stack, MenuParam param)
		{
			//Discarded unreachable code: IL_0031
			_menuStack = stack;
			base.OnPush(stack, param);
			int num = 0;
			if (!PlatformUtils.IsPCPlayer())
			{
				_mcContentScaleSlider.value = 0.5f;
			}
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x60018EB")]
		[Cpp2IlInjected.Address(RVA = "0x1554030", Offset = "0x1552A30", VA = "0x181554030", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_005c
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num2 = 0;
				if (!EventSystem.current.m_SelectionGuard)
				{
					Slider mcContentScaleSlider = _mcContentScaleSlider;
					int num3 = ((mcContentScaleSlider.interactable = false) ? 1 : 0);
					FocusNavigation component = GetComponent<FocusNavigation>();
					FocusNavigationElement component2 = _btnConfirm.GetComponent<FocusNavigationElement>();
					component.SetFocus(component2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018EC")]
		[Cpp2IlInjected.Address(RVA = "0x1554140", Offset = "0x1552B40", VA = "0x181554140", Slot = "27")]
		public override void OnFocusIn()
		{
			//IL_0216: Expected I4, but got O
			string text = default(string);
			uint num4 = default(uint);
			bool flag = default(bool);
			DebugSettingSelectionBox component = default(DebugSettingSelectionBox);
			string text4 = default(string);
			EnumDescriptor enumDescriptor = default(EnumDescriptor);
			string text6 = default(string);
			string text7 = default(string);
			string text8 = default(string);
			string text9 = default(string);
			string empty3 = default(string);
			string text10 = default(string);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			string text12 = default(string);
			string empty5 = default(string);
			string text13 = default(string);
			Action action2 = default(Action);
			string text15 = default(string);
			Action<DebugSettingSelectionBox, object, bool> action3 = default(Action<DebugSettingSelectionBox, object, bool>);
			string text17 = default(string);
			while (true)
			{
				int num = 0;
				base.OnFocusIn();
				TextBase tfVersion = _tfVersion;
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				Gameloft.Common.Version _003CVersion_003Ek__BackingField = _003CInstance_003Ek__BackingField.Version;
				int build = _003CInstance_003Ek__BackingField.Version.version.build;
				string buildType = _003CInstance_003Ek__BackingField.Version.buildType;
				string text3 = (tfVersion.Text = "Version: " + text);
				int num2 = 0;
				DebugSettings settings = DebugSettings.Settings;
				int num3 = 0;
				if (DebugSettings.Descriptor.Fields.InDeclarationOrder() == null)
				{
					continue;
				}
				if (num < (int)num4)
				{
					num += num;
					if (num == (int)num4)
					{
						goto IL_0117;
					}
					num++;
				}
				if (!flag || flag)
				{
				}
				GameObject prefabSelectionBox = _prefabSelectionBox;
				Transform parent = _mcContent.transform;
				component = UnityEngine.Object.Instantiate(prefabSelectionBox, parent).GetComponent<DebugSettingSelectionBox>();
				component.name = text4;
				TextBase tfLabel = component._tfLabel;
				string text5 = (tfLabel.Text = string.Empty);
				List<string> list = (List<string>)(object)Enumerable.ToList<string>((IEnumerable<>)(object)Enum.GetNames(enumDescriptor.ClrType));
				Action action = OnSizeChanged;
				component.RefreshData((List<>)(object)list, action);
				text6 = action.ToString();
				if (text6 == null)
				{
					text7 = string.Empty;
					goto IL_0117;
				}
				goto IL_011e;
				IL_011e:
				component._selectedString = text6;
				TextBase tfSelected = component._tfSelected;
				GameObject prefabInputText = _prefabInputText;
				Transform parent2 = _mcContent.transform;
				DebugSettingInputText inputText2 = UnityEngine.Object.Instantiate(prefabInputText, parent2).GetComponent<DebugSettingInputText>();
				inputText2.name = text8;
				TextBase tfLabel2 = inputText2._tfLabel;
				string empty2 = string.Empty;
				int num5 = 0;
				tfLabel2.Text = empty2;
				InputField tfInput = inputText2._tfInput;
				if (text9 == null)
				{
					empty3 = string.Empty;
				}
				tfInput.text = empty3;
				DebugSettingInputText debugSettingInputText = inputText2;
				DebugSettingInputText.ValueChanged valueChanged = delegate(string value)
				{
					//Discarded unreachable code: IL_000d
					inputText2.Text = value;
				};
				GameObject prefabCheckBox = _prefabCheckBox;
				Transform parent3 = _mcContent.transform;
				DebugSettingCheckBox component2 = UnityEngine.Object.Instantiate(prefabCheckBox, parent3).GetComponent<DebugSettingCheckBox>();
				component2.name = text10;
				TextBase tfLabel3 = component2._tfLabel;
				int num6 = 0;
				string text11 = text10;
				component2._isSelected = (byte)(int)text11 != 0;
				GameObject mcSelected = component2._mcSelected;
				if (flag2)
				{
					break;
				}
				if (!flag3)
				{
					if (!flag4)
					{
						GameObject prefabInputText2 = _prefabInputText;
						Transform parent4 = _mcContent.transform;
						DebugSettingInputText inputText = UnityEngine.Object.Instantiate(prefabInputText2, parent4).GetComponent<DebugSettingInputText>();
						inputText.name = text12;
						TextBase tfLabel4 = inputText._tfLabel;
						string empty4 = string.Empty;
						int num7 = 0;
						tfLabel4.Text = empty4;
						DebugSettingInputText debugSettingInputText2 = inputText;
						if ((object)typeof(string).TypeHandle != null && (object)typeof(string).TypeHandle == null)
						{
							continue;
						}
						InputField tfInput2 = debugSettingInputText2._tfInput;
						if ((object)typeof(string).TypeHandle == null)
						{
							empty5 = string.Empty;
						}
						tfInput2.text = empty5;
						DebugSettingInputText debugSettingInputText3 = inputText;
						DebugSettingInputText.ValueChanged value2 = delegate(string value)
						{
							//Discarded unreachable code: IL_000d
							inputText.Text = value;
						};
						debugSettingInputText3.OnValueChanged += value2;
						GameObject prefabSelectionBox2 = _prefabSelectionBox;
						Transform parent5 = _mcContent.transform;
						DebugSettingSelectionBox component3 = UnityEngine.Object.Instantiate(prefabSelectionBox2, parent5).GetComponent<DebugSettingSelectionBox>();
						component3.name = text13;
						TextBase tfLabel5 = component3._tfLabel;
						string text14 = (tfLabel5.Text = string.Empty);
						List<string> list2 = (List<string>)(object)new List<T>();
						((List<T>)(object)list2).Add((T)"NoOverride");
						int num8 = 0;
						string[] names = QualitySettings.names;
						((List<T>)(object)list2).AddRange((IEnumerable<>)(object)names);
						action2 = OnSizeChanged;
						component3.RefreshData((List<>)(object)list2, action2);
						if (action2 != null && action2 == null)
						{
							continue;
						}
						if (action2 == null)
						{
						}
						component3._selectedString = (string)(object)action2;
						TextBase tfSelected2 = component3._tfSelected;
					}
					GameObject prefabSelectionBox3 = _prefabSelectionBox;
					Transform parent6 = _mcContent.transform;
					DebugSettingSelectionBox component4 = UnityEngine.Object.Instantiate(prefabSelectionBox3, parent6).GetComponent<DebugSettingSelectionBox>();
					object obj = action2.Clone();
					component4.name = text15;
					TextBase tfLabel6 = component4._tfLabel;
					string text16 = (tfLabel6.Text = string.Empty);
					action3 = (Action<DebugSettingSelectionBox, object, bool>)(object)new Action<T1, T2, T3>(OnOnlineChoicesToggled);
					component4._dataRefreshSource = action2;
					component4._onBoxClicked = action3;
					MethodInfo method_info = ((Delegate)action2).method_info;
					if (action3 != null && action3 == null)
					{
						continue;
					}
					if (action3 == null)
					{
					}
					component4._selectedString = (string)(object)action3;
					TextBase tfSelected3 = component4._tfSelected;
				}
				int num9 = 0;
				List<string> profileSlotChoices = (List<string>)(object)DebugSettings.GetProfileSlotChoices(Application.platform == RuntimePlatform.Android);
				GameObject prefabSelectionBox4 = _prefabSelectionBox;
				Transform parent7 = _mcContent.transform;
				DebugSettingSelectionBox component5 = UnityEngine.Object.Instantiate(prefabSelectionBox4, parent7).GetComponent<DebugSettingSelectionBox>();
				object obj2 = action3.Clone();
				component5.name = text17;
				TextBase tfLabel7 = component5._tfLabel;
				string text18 = (tfLabel7.Text = string.Empty);
				Action action4 = OnSizeChanged;
				component5.RefreshData((List<>)(object)profileSlotChoices, action4);
				if (action4 == null || action4 != null)
				{
					if (action4 == null)
					{
					}
					component5._selectedString = (string)(object)action4;
					TextBase tfSelected4 = component5._tfSelected;
					break;
				}
				continue;
				IL_0117:
				text7 += text7;
				goto IL_011e;
			}
			Transform transform = _mcContent.transform;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60018ED")]
		[Cpp2IlInjected.Address(RVA = "0x1555A40", Offset = "0x1554440", VA = "0x181555A40", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut: true, (byte)animate2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60018EE")]
		[Cpp2IlInjected.Address(RVA = "0x1553590", Offset = "0x1551F90", VA = "0x181553590")]
		public void OnConfirmClicked()
		{
			//Discarded unreachable code: IL_0220, IL_0226, IL_022c, IL_0232, IL_0238, IL_023e, IL_0244, IL_024a, IL_0250, IL_0256, IL_025c, IL_0262, IL_0268, IL_026e, IL_0274, IL_027a, IL_0280, IL_0286, IL_028c, IL_0292, IL_0298, IL_029e, IL_02a4, IL_02aa, IL_02b0, IL_02b6, IL_02bc, IL_02c2, IL_02c8, IL_02d4
			string text = default(string);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			FieldDescriptor fieldDescriptor2 = default(FieldDescriptor);
			FieldDescriptor fieldDescriptor3 = default(FieldDescriptor);
			bool flag5 = default(bool);
			DebugSettings settings2 = default(DebugSettings);
			Client client = default(Client);
			Client.InitialLoginCompleted value = default(Client.InitialLoginCompleted);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				DebugSettings settings = DebugSettings.Settings;
				int num3 = 0;
				MessageDescriptor descriptor = DebugSettings.Descriptor;
				IEnumerator enumerator = _mcContent.transform.GetEnumerator();
				if (enumerator != null)
				{
					if (enumerator == null)
					{
					}
					int num4 = 0;
					if (enumerator == null)
					{
						break;
					}
					char[] array = new char[1];
					array[0] = '_';
					string[] array2 = text.Split(array);
					int length = array2.Length;
					IEnumerable<string> enumerable = (IEnumerable<string>)Enumerable.Take<string>((IEnumerable<>)(object)array2, length);
					string text2 = string.Join("_", (IEnumerable<>)enumerable);
					if (!flag)
					{
						if (!flag2)
						{
							while (!flag3)
							{
							}
							FieldType fieldType = descriptor.FindFieldByName(text2).fieldType;
							if (fieldType != FieldType.String)
							{
								while (fieldType != FieldType.Int32)
								{
								}
								while (!flag4)
								{
								}
								IFieldAccessor accessor = descriptor.FindFieldByName(text2).accessor;
							}
							IFieldAccessor accessor2 = descriptor.FindFieldByName(text2).accessor;
						}
						FieldDescriptor fieldDescriptor = descriptor.FindFieldByName(text2);
						if (fieldDescriptor.fieldType != FieldType.Enum)
						{
							IFieldAccessor accessor3 = descriptor.FindFieldByName(text2).accessor;
						}
						IFieldAccessor accessor4 = fieldDescriptor2.accessor;
						Type clrType = fieldDescriptor.EnumType.ClrType;
					}
					IFieldAccessor accessor5 = fieldDescriptor3.accessor;
				}
				if (flag5)
				{
				}
				if (num == 0)
				{
					int num5 = 0;
					if (!DebugSettings.Settings.usePortraitScreenOnly_)
					{
						int num6 = 0;
						Screen.autorotateToPortrait = DebugSettings.Settings.allowPortraitScreen_;
						int num7 = 0;
						settings2 = DebugSettings.Settings;
					}
					Screen.autorotateToPortrait = true;
					int num8 = 0;
					Screen.autorotateToPortraitUpsideDown = true;
					Screen.autorotateToLandscapeLeft = (byte)num8 != 0;
					Screen.autorotateToLandscapeRight = (byte)num8 != 0;
					string password_ = settings2.password_;
					string language_ = settings.language_;
					int num9 = 0;
					DebugSettings.Save();
					int num10 = 0;
					if (!UILocalStorage.Load())
					{
						int num11 = 0;
						bool flag6 = UILocalStorage.Save();
					}
					client.OnInitialLoginCompleted += value;
					int num12 = 0;
					RedirectionManager redirection = UiRoot.Instance.Redirection;
					int num13 = 0;
					bool useIngameDebug_ = DebugSettings.Settings.useIngameDebug_;
					redirection.ToggleIngameDebug(useIngameDebug_).FireAndForgetTask();
					int num14 = 0;
					if (DebugSettings.Settings.graphicQuality_ != "NoOverride")
					{
						int num15 = 0;
						GraphicSettings.InitializeGraphicQuality(DebugSettings.Settings.graphicQuality_);
					}
					int num16 = 0;
					if (DebugSettings.Settings.forceBacktraceOn_)
					{
						BackTraceInitializer.Instance.InitializeBacktrace();
					}
					int num17 = 0;
					DebugSettings.Dispatcher.RaiseOnConfirm();
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60018EF")]
		[Cpp2IlInjected.Address(RVA = "0x1555A50", Offset = "0x1554450", VA = "0x181555A50")]
		private void OnInitialLoginCompleted(Profile profile, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0067
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client.InitialLoginCompleted value = OnInitialLoginCompleted;
			metaClient.OnInitialLoginCompleted -= value;
			int num = 0;
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = SystemRoot.Instance.MetaClient.profile.gameInfo_.created_.ToDateTime();
			TimeSpan timeSpan = default(TimeSpan);
			if (utcNow - dateTime < timeSpan)
			{
				int num2 = 0;
				FakeData.Instance.ResetFakeProgress();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018F0")]
		[Cpp2IlInjected.Address(RVA = "0x1555FA0", Offset = "0x15549A0", VA = "0x181555FA0")]
		private void OnSizeChanged()
		{
			//Discarded unreachable code: IL_0029
			//IL_0028: Expected O, but got I4
			_mcContent.GetComponentInChildren<VerticalLayoutGroup>().CalculateLayoutInputVertical();
			Transform transform = _mcContent.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			LayoutRebuilder.MarkLayoutForRebuild((RectTransform)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60018F1")]
		[Cpp2IlInjected.Address(RVA = "0x1555D80", Offset = "0x1554780", VA = "0x181555D80")]
		[AsyncStateMachine(typeof(_003COnOnlineChoicesToggled_003Ed__18))]
		private void OnOnlineChoicesToggled(DebugSettingSelectionBox selectionBox, object source, bool isOpened)
		{
			int num = 0;
			int num2 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60018F2")]
		[Cpp2IlInjected.Address(RVA = "0x1555CB0", Offset = "0x15546B0", VA = "0x181555CB0")]
		[AsyncStateMachine(typeof(_003COnOnlineChoiceChanged_003Ed__19))]
		private void OnOnlineChoiceChanged(string itemText, object itemData)
		{
			int num = 0;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		[Cpp2IlInjected.Token(Token = "0x60018F3")]
		[Cpp2IlInjected.Address(RVA = "0x1555F20", Offset = "0x1554920", VA = "0x181555F20")]
		public void OnScaleValueChanged()
		{
			//Discarded unreachable code: IL_001b
			float value = _mcContentScaleSlider.value;
			Transform transform = _mcContentHolder.transform;
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60018F4")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public DebugSettingMenu()
		{
		}
	}
}
