using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.RewiredConsts;
using Meta.Util;
using Rewired;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200020E")]
	[CreateAssetMenu]
	public class ShortcutDefinition : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000909")]
		[Space]
		[SerializeField]
		[Space(15f)]
		[ActionIdProperty(typeof(Mdl.RewiredConsts.Action))]
		public int RewiredActionId = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400090A")]
		public InputActionEventType[] RewiredActionEventTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400090B")]
		public ControlType ControlType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400090C")]
		public RedirectionType RedirectionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400090D")]
		[Space]
		public string StringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400090E")]
		public string LabelStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400090F")]
		public string SpriteName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000910")]
		public ShortcutIndicator.VisualType IndicatorVisualType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000911")]
		public bool HideVisual;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000912")]
		public Vector2 Offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000913")]
		public float IconRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000914")]
		[Space]
		public bool IgnoreActiveInHierarchy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x4000915")]
		public bool PopAllAboveHud;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x4000916")]
		public bool KillCurrentMenuAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5F")]
		[Cpp2IlInjected.Token(Token = "0x4000917")]
		public bool UseFadeInOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000918")]
		public float FadeInOutDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000919")]
		[Space]
		public bool UseParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400091A")]
		public ShortcutParam Param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400091B")]
		[Space]
		public List<ShortcutDefinition> Alts;

		[Cpp2IlInjected.Token(Token = "0x1700027E")]
		public ShortcutDefinition Self
		{
			[Cpp2IlInjected.Token(Token = "0x6000D06")]
			[Cpp2IlInjected.Address(RVA = "0x15EB010", Offset = "0x15E9A10", VA = "0x1815EB010")]
			get
			{
				//Discarded unreachable code: IL_005f
				//IL_005b: Expected O, but got I4
				int num = 0;
				if (Application.isPlaying)
				{
					int num2 = 0;
					ControlType controlType;
					if ((controlType = UiRoot.Instance.GetCurrentController(useKeyboardAsController: true)) != ControlType)
					{
						List<ShortcutDefinition> alts = Alts;
						Predicate<ShortcutDefinition> predicate = (Predicate<ShortcutDefinition>)(object)(Predicate<T>)delegate(ShortcutDefinition x)
						{
							//Discarded unreachable code: IL_0011
							ControlType controlType2 = controlType;
							return x.ControlType == controlType2;
						};
						ShortcutDefinition shortcutDefinition = (ShortcutDefinition)((List<T>)(object)alts).Find((Predicate<>)(object)predicate);
						int num3 = 0;
						bool flag = shortcutDefinition != (UnityEngine.Object)num3;
					}
				}
				return this;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027F")]
		public bool IsAlt
		{
			[Cpp2IlInjected.Token(Token = "0x6000D07")]
			[Cpp2IlInjected.Address(RVA = "0x15EAFA0", Offset = "0x15E99A0", VA = "0x1815EAFA0")]
			get
			{
				List<ShortcutDefinition> alts = Alts;
				if (alts == null)
				{
					int num = 0;
				}
				ShortcutDefinition self = Self;
				return ((List<T>)(object)alts).Contains((T)self);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D08")]
		[Cpp2IlInjected.Address(RVA = "0x15EAEE0", Offset = "0x15E98E0", VA = "0x1815EAEE0")]
		public unsafe ShortcutDefinition()
		{
			//Discarded unreachable code: IL_006c
			//IL_0010: Expected I4, but got I8
			//IL_0021: Expected I4, but got I8
			//IL_0033: Expected I4, but got I8
			//IL_004c: Expected F4, but got I4
			//IL_0047: Expected native int or pointer, but got O
			InputActionEventType[] array = new InputActionEventType[1];
			array[0] = InputActionEventType.ButtonJustPressed;
			RewiredActionEventTypes = array;
			int num = 0;
			ControlType = ControlType.Xbox360;
			Offset = Vector2.zero;
			((Vector2*)(IntPtr)Offset)->y = 0f;
			PopAllAboveHud = true;
			UseFadeInOut = true;
			FadeInOutDuration = 0.25f;
			base._002Ector();
		}
	}
}
