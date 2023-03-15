using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003BD")]
	public abstract class InputAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400190B")]
		private InputActionValue RawValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400190C")]
		private InputActionValue ModifiedValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400190D")]
		private InputTrigger inputTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400190E")]
		protected bool previousIsActuated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400190F")]
		private InputProvider inputProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001915")]
		private readonly List<InputActionModifier> modifiers = (List<InputActionModifier>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x4001916")]
		private static InputAction _none;

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4001910")]
		public bool IsTriggered
		{
			[Cpp2IlInjected.Token(Token = "0x600101E")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600101F")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x41"), Cpp2IlInjected.Token(Token = "0x4001911")]
		public bool WasTriggered
		{
			[Cpp2IlInjected.Token(Token = "0x6001020")]
			[Cpp2IlInjected.Address(RVA = "0xE3A5E0", Offset = "0xE38FE0", VA = "0x180E3A5E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001021")]
			[Cpp2IlInjected.Address(RVA = "0x11B5150", Offset = "0x11B3B50", VA = "0x1811B5150")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		protected InputProvider InputProvider
		{
			[Cpp2IlInjected.Token(Token = "0x6001028")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return inputProvider;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		public static InputAction None
		{
			[Cpp2IlInjected.Token(Token = "0x600103C")]
			[Cpp2IlInjected.Address(RVA = "0x11B4DD0", Offset = "0x11B37D0", VA = "0x1811B4DD0")]
			get
			{
				//Discarded unreachable code: IL_001e
				InputActionNone none = new InputActionNone();
				InputTriggerNone inputTriggerNone = new InputTriggerNone();
				NoInputProvider noInputProvider = new NoInputProvider();
				_none = none;
				return _none;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event EventHandler OnStarted
		{
			[Cpp2IlInjected.Token(Token = "0x6001022")]
			[Cpp2IlInjected.Address(RVA = "0x11B4BF0", Offset = "0x11B35F0", VA = "0x1811B4BF0")]
			[CompilerGenerated]
			add
			{
				EventHandler onStarted = this.OnStarted;
				Delegate @delegate = Delegate.Combine(onStarted, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onStarted)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001023")]
			[Cpp2IlInjected.Address(RVA = "0x11B4F70", Offset = "0x11B3970", VA = "0x1811B4F70")]
			[CompilerGenerated]
			remove
			{
				EventHandler onStarted = this.OnStarted;
				Delegate @delegate = Delegate.Remove(onStarted, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onStarted)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event EventHandler OnTriggered
		{
			[Cpp2IlInjected.Token(Token = "0x6001024")]
			[Cpp2IlInjected.Address(RVA = "0x11B4D30", Offset = "0x11B3730", VA = "0x1811B4D30")]
			[CompilerGenerated]
			add
			{
				EventHandler onTriggered = this.OnTriggered;
				Delegate @delegate = Delegate.Combine(onTriggered, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTriggered)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001025")]
			[Cpp2IlInjected.Address(RVA = "0x11B50B0", Offset = "0x11B3AB0", VA = "0x1811B50B0")]
			[CompilerGenerated]
			remove
			{
				EventHandler onTriggered = this.OnTriggered;
				Delegate @delegate = Delegate.Remove(onTriggered, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTriggered)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event EventHandler OnStopped
		{
			[Cpp2IlInjected.Token(Token = "0x6001026")]
			[Cpp2IlInjected.Address(RVA = "0x11B4C90", Offset = "0x11B3690", VA = "0x1811B4C90")]
			[CompilerGenerated]
			add
			{
				EventHandler onStopped = this.OnStopped;
				Delegate @delegate = Delegate.Combine(onStopped, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onStopped)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001027")]
			[Cpp2IlInjected.Address(RVA = "0x11B5010", Offset = "0x11B3A10", VA = "0x1811B5010")]
			[CompilerGenerated]
			remove
			{
				EventHandler onStopped = this.OnStopped;
				Delegate @delegate = Delegate.Remove(onStopped, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onStopped)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001029")]
		[Cpp2IlInjected.Address(RVA = "0x11B4B20", Offset = "0x11B3520", VA = "0x1811B4B20")]
		public InputAction(InputTrigger trigger, [Optional] InputProvider provider)
		{
			inputTrigger = trigger;
			this.inputProvider = provider;
			if ((long)this.inputProvider == 0)
			{
				int num = 0;
				InputProvider inputProvider = (this.inputProvider = DefaultInputProvider.Get());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600102A")]
		[Cpp2IlInjected.Address(RVA = "0x11B4940", Offset = "0x11B3340", VA = "0x1811B4940")]
		public void Update(float deltaTime)
		{
			//Discarded unreachable code: IL_008b
			//IL_008a: Expected I4, but got I8
			InputActionValueType valueType = RawValue.ValueType;
			bool flag = IsTriggered;
			InputTrigger inputTrigger = this.inputTrigger;
			WasTriggered = flag;
			if (1L == 0L)
			{
			}
			if (1L == 0L)
			{
			}
			bool flag2 = previousIsActuated;
			bool flag3 = (IsTriggered = inputTrigger.Update(deltaTime, currentIsActuated: true, flag2));
			bool flag4 = IsTriggered;
			bool flag5 = previousIsActuated;
			if ((flag4 && flag5) || !flag5 || this.OnStopped != null)
			{
			}
			if (!IsTriggered || this.OnTriggered != null)
			{
			}
			previousIsActuated = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600102B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void UpdateInputActionValueFromProvider(ref InputActionValue value);

		[Cpp2IlInjected.Token(Token = "0x600102C")]
		[Cpp2IlInjected.Address(RVA = "0x11B46C0", Offset = "0x11B30C0", VA = "0x1811B46C0")]
		private InputProvider CreateDefaultInputProvider()
		{
			int num = 0;
			return DefaultInputProvider.Get();
		}

		[Cpp2IlInjected.Token(Token = "0x600102D")]
		[Cpp2IlInjected.Address(RVA = "0x11B4720", Offset = "0x11B3120", VA = "0x1811B4720")]
		private void InvokeEvents()
		{
			if ((IsTriggered && previousIsActuated) || !previousIsActuated || this.OnStopped != null)
			{
			}
			if (IsTriggered && this.OnTriggered == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600102E")]
		[Cpp2IlInjected.Address(RVA = "0x11B46D0", Offset = "0x11B30D0", VA = "0x1811B46D0")]
		protected bool IsActuated()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600102F")]
		[Cpp2IlInjected.Address(RVA = "0x11B4700", Offset = "0x11B3100", VA = "0x1811B4700")]
		internal InputActionValue GetValue()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001030")]
		[Cpp2IlInjected.Address(RVA = "0x11B46D0", Offset = "0x11B30D0", VA = "0x1811B46D0")]
		public bool GetValueBool()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001031")]
		[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320")]
		public float GetValueFloat()
		{
			InputActionValue modifiedValue = ModifiedValue;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001032")]
		[Cpp2IlInjected.Address(RVA = "0x10680D0", Offset = "0x1066AD0", VA = "0x1810680D0")]
		public Vector2 GetValueVector2()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract float GetValueFloatRaw();

		[Cpp2IlInjected.Token(Token = "0x6001034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract Vector2 GetValueVector2Raw();

		[Cpp2IlInjected.Token(Token = "0x6001035")]
		[Cpp2IlInjected.Address(RVA = "0x11B43E0", Offset = "0x11B2DE0", VA = "0x1811B43E0")]
		public void AddModifier(InputActionModifier modifier)
		{
			//Discarded unreachable code: IL_001c
			if (!((List<T>)(object)modifiers).Contains((T)modifier))
			{
				((List<T>)(object)modifiers).Add((T)modifier);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001036")]
		[Cpp2IlInjected.Address(RVA = "0x11B4810", Offset = "0x11B3210", VA = "0x1811B4810")]
		public bool RemoveModifier(InputActionModifier modifier)
		{
			//Discarded unreachable code: IL_000d
			return ((List<T>)(object)modifiers).Remove((T)modifier);
		}

		[Cpp2IlInjected.Token(Token = "0x6001037")]
		[Cpp2IlInjected.Address(RVA = "0x11B48D0", Offset = "0x11B32D0", VA = "0x1811B48D0")]
		public static void UpdateAll(float deltaTime, params InputAction[] inputActions)
		{
			//Discarded unreachable code: IL_0025
			int num = 0;
			int length = inputActions.Length;
			if (num < length)
			{
				inputActions[num]?.Update(deltaTime);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001038")]
		[Cpp2IlInjected.Address(RVA = "0x11B4660", Offset = "0x11B3060", VA = "0x1811B4660")]
		public static void CancelAll(params InputAction[] inputActions)
		{
			//Discarded unreachable code: IL_0024
			int num = 0;
			int length = inputActions.Length;
			if (num < length)
			{
				inputActions[num]?.Reset();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001039")]
		[Cpp2IlInjected.Address(RVA = "0x11B4870", Offset = "0x11B3270", VA = "0x1811B4870")]
		private void Reset()
		{
			int num = 0;
			Vector2 zero = Vector2.zero;
			int num2 = 0;
			RawValue = (InputActionValue)zero;
			Vector2 vector = (Vector2)(ModifiedValue = (InputActionValue)Vector2.zero);
			IsTriggered = false;
		}

		[Cpp2IlInjected.Token(Token = "0x600103A")]
		[Cpp2IlInjected.Address(RVA = "0x11B4460", Offset = "0x11B2E60", VA = "0x1811B4460")]
		public static bool AnyTriggered(params InputAction[] inputActions)
		{
			int num = 0;
			int length = inputActions.Length;
			if (num < length)
			{
				if (!inputActions[num].IsTriggered)
				{
					num++;
				}
				return true;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600103B")]
		[Cpp2IlInjected.Address(RVA = "0x11B44C0", Offset = "0x11B2EC0", VA = "0x1811B44C0")]
		private void ApplyModifiers(float deltaTime, InputActionValue inValue)
		{
			//Discarded unreachable code: IL_001a
			//IL_000e: Expected O, but got I4
			InputActionValueType valueType = inValue.ValueType;
			ModifiedValue = (InputActionValue)valueType;
			List<InputActionModifier> list = modifiers;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600103D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static InputAction()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
