using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Mdl.InputSystem;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C1F")]
	internal abstract class BaseHoldBehaviour : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004391")]
		public string inputName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004392")]
		public InteractPreviewData InteractPreviewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004394")]
		private InputAction holdInputAction;

		[Cpp2IlInjected.Token(Token = "0x4004395")]
		protected static readonly (GridPosition gridDirection, Vector3 unityDirection)[] directions;

		[Cpp2IlInjected.Token(Token = "0x17000756")]
		public PlayerTaskDefinition PlayerTaskDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6003726")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CPlayerTaskDefinition_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003727")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			protected set
			{
				_003CPlayerTaskDefinition_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003728")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool CanUseOn(GameObject go, PlayerTaskDefinition playerTaskDefinition);

		[Cpp2IlInjected.Token(Token = "0x6003729")]
		[Cpp2IlInjected.Address(RVA = "0x163B130", Offset = "0x1639B30", VA = "0x18163B130", Slot = "5")]
		public virtual void Init(PlayerTask initialTask)
		{
			//IL_000d: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			if ((object)initialTask != null)
			{
			}
			int num = 0;
			PlayerTaskDefinition = (PlayerTaskDefinition)num;
			string input = inputName;
			InputTriggerDown trigger = new InputTriggerDown();
			int num2 = default(int);
			InputActionBool inputActionBool = new InputActionBool(input, trigger, (InputProvider)num2);
			num2 = 0;
			holdInputAction = inputActionBool;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600372A")]
		[Cpp2IlInjected.Address(RVA = "0x163AE70", Offset = "0x1639870", VA = "0x18163AE70", Slot = "6")]
		public virtual bool DoUpdate(float dt)
		{
			//Discarded unreachable code: IL_0031
			InputAction[] array;
			InputAction inputAction;
			do
			{
				array = new InputAction[1];
				inputAction = holdInputAction;
			}
			while (inputAction != null && array == null);
			array[0] = inputAction;
			InputAction.UpdateAll(dt, array);
			return holdInputAction.IsTriggered;
		}

		[Cpp2IlInjected.Token(Token = "0x600372B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public virtual void End()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600372C")]
		[Cpp2IlInjected.Address(RVA = "0x163AF80", Offset = "0x1639980", VA = "0x18163AF80")]
		protected static int GetGridDirectionIndex(Vector3 direction)
		{
			//Discarded unreachable code: IL_0034
			int num = 0;
			(GridPosition, Vector3)[] array = directions;
			if (1 < array.Length)
			{
				(GridPosition, Vector3)[] array2 = directions;
				float z = direction.z;
				(GridPosition, Vector3)[] array3 = directions;
				num += 2;
				float z2 = direction.z;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x600372D")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		protected BaseHoldBehaviour()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600372E")]
		[Cpp2IlInjected.Address(RVA = "0x163B200", Offset = "0x1639C00", VA = "0x18163B200")]
		static BaseHoldBehaviour()
		{
			//Discarded unreachable code: IL_00bb
			//IL_002c: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_008b: Expected O, but got I4
			//IL_00aa: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			(GridPosition, Vector3)[] array = new(GridPosition, Vector3)[4];
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Vector3 right = Vector3.right;
			int num4 = 0;
			float z = right.z;
			int num5 = 0;
			((ValueTuple<, >[])(object)array)[0] = (ValueTuple<, >)num4;
			((ValueTuple<, >[])(object)array)[2] = (ValueTuple<, >)num5;
			Vector3 back = Vector3.back;
			int num6 = 0;
			float z2 = back.z;
			int num7 = 0;
			int num8 = 0;
			((ValueTuple<, >[])(object)array)[2] = (ValueTuple<, >)num6;
			((ValueTuple<, >[])(object)array)[4] = (ValueTuple<, >)num7;
			int num9 = 0;
			Vector3 left = Vector3.left;
			int num10 = 0;
			float z3 = left.z;
			int num11 = 0;
			((ValueTuple<, >[])(object)array)[5] = (ValueTuple<, >)num10;
			((ValueTuple<, >[])(object)array)[7] = (ValueTuple<, >)num11;
			Vector3 forward = Vector3.forward;
			int num12 = 0;
			float z4 = forward.z;
			int num13 = 0;
			((ValueTuple<, >[])(object)array)[7] = (ValueTuple<, >)num12;
			((ValueTuple<, >[])(object)array)[9] = (ValueTuple<, >)num13;
			directions = array;
		}
	}
}
