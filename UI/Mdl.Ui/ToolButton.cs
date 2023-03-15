using System;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000592")]
	public class ToolButton : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001EA6")]
		[SerializeField]
		private RadialToolMenu _radialToolMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001EA7")]
		[SerializeField]
		private ImageHelper _iconImageHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001EA8")]
		[SerializeField]
		private GameObject _defaultBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001EA9")]
		[SerializeField]
		private GameObject _highlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001EAA")]
		private Toolbox.ToolType _previousTool;

		[Cpp2IlInjected.Token(Token = "0x170005A3")]
		private Toolbox _toolbox
		{
			[Cpp2IlInjected.Token(Token = "0x600247B")]
			[Cpp2IlInjected.Address(RVA = "0x17F2760", Offset = "0x17F1160", VA = "0x1817F2760")]
			get
			{
				//Discarded unreachable code: IL_0010
				return SystemRoot.Instance._avatar.Toolbox;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600247C")]
		[Cpp2IlInjected.Address(RVA = "0x17F23D0", Offset = "0x17F0DD0", VA = "0x1817F23D0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0076
			UpdateIcon();
			int num = 0;
			UnityEvent<bool> onToolMenuChanged = UiRoot.Instance.Dispatcher.OnToolMenuChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnCurrentToolChanged);
			((UnityEvent<T0>)(object)onToolMenuChanged).RemoveListener((UnityAction<>)(object)unityAction);
			int num2 = 0;
			UnityEvent<bool> onToolMenuChanged2 = UiRoot.Instance.Dispatcher.OnToolMenuChanged;
			UnityAction<bool> unityAction2 = (UnityAction<bool>)(object)new UnityAction<T0>(OnCurrentToolChanged);
			((UnityEvent<T0>)(object)onToolMenuChanged2).AddListener((UnityAction<>)(object)unityAction2);
			Toolbox toolbox = _toolbox;
			EventHandler<Toolbox.ToolType> eventHandler = (EventHandler<Toolbox.ToolType>)(object)new EventHandler<TEventArgs>(OnToolboxChange);
			toolbox.add_CurrentToolChanged((EventHandler<>)(object)eventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x600247D")]
		[Cpp2IlInjected.Address(RVA = "0x17F2590", Offset = "0x17F0F90", VA = "0x1817F2590")]
		private void OnToolboxChange(object sender, Toolbox.ToolType currentTool)
		{
			//Discarded unreachable code: IL_0026
			RadialToolMenu radialToolMenu = _radialToolMenu;
			Toolbox toolbox = _toolbox;
			Toolbox.ToolType previousTool = _previousTool;
			if (toolbox._currentToolType != previousTool)
			{
				UpdateIcon();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600247E")]
		[Cpp2IlInjected.Address(RVA = "0x17F21B0", Offset = "0x17F0BB0", VA = "0x1817F21B0")]
		private void OnCurrentToolChanged(bool arg0)
		{
			//Discarded unreachable code: IL_005a
			//IL_0010: Expected O, but got I4
			RadialToolMenu radialToolMenu = _radialToolMenu;
			int num = 0;
			if (radialToolMenu != (UnityEngine.Object)num)
			{
				RadialToolMenu radialToolMenu2 = _radialToolMenu;
				Toolbox toolbox = _toolbox;
				Toolbox.ToolType previousTool = _previousTool;
				if (toolbox._currentToolType != previousTool)
				{
					UpdateIcon();
				}
				_defaultBg.SetActive(value: true);
				GameObject highlightBg = _highlightBg;
				int active = 0;
				highlightBg.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600247F")]
		[Cpp2IlInjected.Address(RVA = "0x17F25E0", Offset = "0x17F0FE0", VA = "0x1817F25E0")]
		private void UpdateIcon()
		{
			//Discarded unreachable code: IL_0076
			//IL_002c: Expected O, but got I4
			Toolbox.ToolType currentToolType = SystemRoot.Instance._avatar.Toolbox._currentToolType;
			ImageHelper iconImageHelper = _iconImageHelper;
			_previousTool = currentToolType;
			int num = 0;
			if (iconImageHelper != (UnityEngine.Object)num)
			{
				AsyncAtlassedIcon asyncAtlassedIcon = _iconImageHelper.AsyncAtlassedIcon;
				int num2 = 0;
				ImageReferenceHolder imageReference = UiRoot.Instance._imageReference;
				Toolbox.ToolType previousTool = _previousTool;
				UnityEngine.AddressableAssets.AssetReferenceTexture reference = imageReference.GetReference(previousTool);
				asyncAtlassedIcon.SetIconRef(reference);
				_iconImageHelper.SetColorRGB(16777215);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002480")]
		[Cpp2IlInjected.Address(RVA = "0x17F2290", Offset = "0x17F0C90", VA = "0x1817F2290")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0044
			int num = 0;
			UnityEvent<bool> onToolMenuChanged = UiRoot.Instance.Dispatcher.OnToolMenuChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnCurrentToolChanged);
			((UnityEvent<T0>)(object)onToolMenuChanged).RemoveListener((UnityAction<>)(object)unityAction);
			Toolbox toolbox = _toolbox;
			EventHandler<Toolbox.ToolType> eventHandler = (EventHandler<Toolbox.ToolType>)(object)new EventHandler<TEventArgs>(OnToolboxChange);
			toolbox.remove_CurrentToolChanged((EventHandler<>)(object)eventHandler);
		}

		[Cpp2IlInjected.Token(Token = "0x6002481")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ToolButton()
		{
		}
	}
}
