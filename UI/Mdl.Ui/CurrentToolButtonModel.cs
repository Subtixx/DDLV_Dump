using System;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Mdl.Avatar;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200058E")]
	public class CurrentToolButtonModel : CustomButtonModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001E95")]
		private bool _isInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E96")]
		private Toolbox _toolbox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E97")]
		private CustomButton _button;

		[Cpp2IlInjected.Token(Token = "0x6002459")]
		[Cpp2IlInjected.Address(RVA = "0x111AD50", Offset = "0x1119750", VA = "0x18111AD50", Slot = "4")]
		public unsafe override void Init(CustomButton button)
		{
			//Discarded unreachable code: IL_01ab
			//IL_003b: Expected O, but got I4
			if (!_isInitialized)
			{
				_button = button;
				((TemplateButton)button).IgnoreHighlightWhenSelected = true;
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				CurseSystem system = SystemRoot.Instance.GetSystem<CurseSystem>();
				Toolbox toolbox = _toolbox;
				int num = 0;
				if (toolbox == (UnityEngine.Object)num)
				{
					Toolbox toolbox2 = (_toolbox = _003CInstance_003Ek__BackingField._avatar.Toolbox);
				}
				Toolbox toolbox3 = _toolbox;
				EventHandler<Toolbox.ToolType> eventHandler = (EventHandler<Toolbox.ToolType>)(object)new EventHandler<TEventArgs>(OnCurrentToolChanged);
				toolbox3.remove_CurrentToolChanged((EventHandler<>)(object)eventHandler);
				Toolbox toolbox4 = _toolbox;
				EventHandler<Toolbox.ToolType> eventHandler2 = (EventHandler<Toolbox.ToolType>)(object)new EventHandler<TEventArgs>(OnCurrentToolChanged);
				toolbox4.add_CurrentToolChanged((EventHandler<>)(object)eventHandler2);
				EventHandler<bool> eventHandler3 = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(OnLimboStateChanged);
				system.remove_LimboStateChanged((EventHandler<>)(object)eventHandler3);
				EventHandler<bool> eventHandler4 = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(OnLimboStateChanged);
				system.add_LimboStateChanged((EventHandler<>)(object)eventHandler4);
				RelaxingBehaviour _003CRelaxingBehaviour_003Ek__BackingField = _003CInstance_003Ek__BackingField._avatar.RelaxingBehaviour;
				EventHandler value = OnRelaxingStateChanged;
				_003CRelaxingBehaviour_003Ek__BackingField.RelaxingStateChangedEvent -= value;
				RelaxingBehaviour _003CRelaxingBehaviour_003Ek__BackingField2 = _003CInstance_003Ek__BackingField._avatar.RelaxingBehaviour;
				EventHandler value2 = OnRelaxingStateChanged;
				_003CRelaxingBehaviour_003Ek__BackingField2.RelaxingStateChangedEvent += value2;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = _003CInstance_003Ek__BackingField.MetaClient.Dispatcher;
				ProfileEventDispatcher.ToolAdded value3 = OnToolAdded;
				_003CDispatcher_003Ek__BackingField.OnToolAdded -= value3;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = _003CInstance_003Ek__BackingField.MetaClient.Dispatcher;
				ProfileEventDispatcher.ToolAdded value4 = OnToolAdded;
				_003CDispatcher_003Ek__BackingField2.OnToolAdded += value4;
				int num2 = 0;
				UnityEvent<bool> onToolMenuChanged = UiRoot.Instance.Dispatcher.OnToolMenuChanged;
				UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(this, (IntPtr)__ldftn(CurrentToolButtonModel.OnCurrentToolChanged));
				((UnityEvent<T0>)(object)onToolMenuChanged).RemoveListener((UnityAction<>)(object)unityAction);
				int num3 = 0;
				UnityEvent<bool> onToolMenuChanged2 = UiRoot.Instance.Dispatcher.OnToolMenuChanged;
				UnityAction<bool> unityAction2 = (UnityAction<bool>)(object)new UnityAction<T0>(this, (IntPtr)__ldftn(CurrentToolButtonModel.OnCurrentToolChanged));
				((UnityEvent<T0>)(object)onToolMenuChanged2).AddListener((UnityAction<>)(object)unityAction2);
				_isInitialized = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600245A")]
		[Cpp2IlInjected.Address(RVA = "0x111B6E0", Offset = "0x111A0E0", VA = "0x18111B6E0", Slot = "5")]
		public override void UpdateDisplay()
		{
			//Discarded unreachable code: IL_0055
			if (_isInitialized)
			{
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				CurseSystem system = SystemRoot.Instance.GetSystem<CurseSystem>();
				CustomButton button = _button;
				if (profile.player_.HasHudApparition(16384u))
				{
					int num = 0;
				}
				int isActivated = ((button.IsInteractable = false) ? 1 : 0);
				button.IsActivated = (byte)isActivated != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600245B")]
		[Cpp2IlInjected.Address(RVA = "0x111B2F0", Offset = "0x1119CF0", VA = "0x18111B2F0")]
		private void OnToolAdded(Item toolItem)
		{
			if (_isInitialized)
			{
				bool isDebug = ((ServerLiveopsDataFilesLoader)(object)this).IsDebug;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600245C")]
		[Cpp2IlInjected.Address(RVA = "0x111B2F0", Offset = "0x1119CF0", VA = "0x18111B2F0")]
		private void OnCurrentToolChanged(object sender, Toolbox.ToolType e)
		{
			if (_isInitialized)
			{
				bool isDebug = ((ServerLiveopsDataFilesLoader)(object)this).IsDebug;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600245D")]
		[Cpp2IlInjected.Address(RVA = "0x111B2F0", Offset = "0x1119CF0", VA = "0x18111B2F0")]
		private void OnLimboStateChanged(object sender, bool e)
		{
			if (_isInitialized)
			{
				bool isDebug = ((ServerLiveopsDataFilesLoader)(object)this).IsDebug;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600245E")]
		[Cpp2IlInjected.Address(RVA = "0x111B2F0", Offset = "0x1119CF0", VA = "0x18111B2F0")]
		private void OnRelaxingStateChanged(object sender, EventArgs e)
		{
			if (_isInitialized)
			{
				bool isDebug = ((ServerLiveopsDataFilesLoader)(object)this).IsDebug;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600245F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnCurrentToolChanged(bool isOpened)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002460")]
		[Cpp2IlInjected.Address(RVA = "0x111B310", Offset = "0x1119D10", VA = "0x18111B310", Slot = "6")]
		public unsafe override void Release()
		{
			//Discarded unreachable code: IL_00f6
			//IL_0024: Expected O, but got I4
			//IL_0064: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_00f5: Expected O, but got I4
			if (_isInitialized)
			{
				int num = 0;
				_isInitialized = false;
				UiRoot instance = UiRoot.Instance;
				int num2 = 0;
				if (instance != (UnityEngine.Object)num2)
				{
					int num3 = 0;
					UnityEvent<bool> onToolMenuChanged = UiRoot.Instance.Dispatcher.OnToolMenuChanged;
					UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(this, (IntPtr)__ldftn(CurrentToolButtonModel.OnCurrentToolChanged));
					((UnityEvent<T0>)(object)onToolMenuChanged).RemoveListener((UnityAction<>)(object)unityAction);
				}
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				int num4 = 0;
				if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num4)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = _003CInstance_003Ek__BackingField.MetaClient.Dispatcher;
					ProfileEventDispatcher.ToolAdded value = OnToolAdded;
					_003CDispatcher_003Ek__BackingField.OnToolAdded -= value;
					EventHandler<Toolbox.ToolType> eventHandler = (EventHandler<Toolbox.ToolType>)(object)new EventHandler<TEventArgs>(OnCurrentToolChanged);
					CurseSystem system = _003CInstance_003Ek__BackingField.GetSystem<CurseSystem>();
					EventHandler<bool> eventHandler2 = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(OnLimboStateChanged);
					system.remove_LimboStateChanged((EventHandler<>)(object)eventHandler2);
					RelaxingBehaviour _003CRelaxingBehaviour_003Ek__BackingField = _003CInstance_003Ek__BackingField._avatar.RelaxingBehaviour;
					EventHandler value2 = OnRelaxingStateChanged;
					_003CRelaxingBehaviour_003Ek__BackingField.RelaxingStateChangedEvent -= value2;
					int num5 = 0;
					_button = (CustomButton)num5;
					_toolbox = (Toolbox)num5;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002461")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CurrentToolButtonModel()
		{
			int isOpened = 0;
			OnCurrentToolChanged((byte)isOpened != 0);
		}
	}
}
