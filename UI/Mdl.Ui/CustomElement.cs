using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	public class CustomElement : MonoBehaviour, IHasText, IHasSpriteURI, IHasFloatValue, IHasUIntValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public CustomButton CustomButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public RectTransform Items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public UnityEvent OnRefreshDisplay;

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public CustomeElementModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A8F")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		public Dictionary<UIntValueType, int> Ints
		{
			[Cpp2IlInjected.Token(Token = "0x6000A90")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CInts_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A91")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CInts_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<UIntValueType, int>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public Dictionary<TextType, string> Texts
		{
			[Cpp2IlInjected.Token(Token = "0x6000A92")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CTexts_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A93")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CTexts_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<TextType, string>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public Dictionary<SpriteType, string> Sprites
		{
			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CSprites_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CSprites_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<SpriteType, string>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public Dictionary<FloatValueType, float> Floats
		{
			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CFloats_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CFloats_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<FloatValueType, float>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x111D4E0", Offset = "0x111BEE0", VA = "0x18111D4E0", Slot = "8")]
		public virtual void RefreshDisplay()
		{
			Model?.UpdateDisplay(this);
			OnRefreshDisplay?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x111D2A0", Offset = "0x111BCA0", VA = "0x18111D2A0", Slot = "4")]
		public string GetText(TextType textType)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_001a
			Dictionary<TextType, string> dictionary = Texts;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x111D330", Offset = "0x111BD30", VA = "0x18111D330", Slot = "5")]
		public string GetURI(SpriteType spriteType)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_001a
			Dictionary<SpriteType, string> dictionary = Sprites;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x111D3C0", Offset = "0x111BDC0", VA = "0x18111D3C0", Slot = "6")]
		public float GetValue(FloatValueType valueType)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_001a
			Dictionary<FloatValueType, float> dictionary = Floats;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x111D450", Offset = "0x111BE50", VA = "0x18111D450", Slot = "7")]
		public int GetValue(UIntValueType valueType)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_001a, IL_001c
			Dictionary<UIntValueType, int> dictionary = Ints;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x111D520", Offset = "0x111BF20", VA = "0x18111D520")]
		public void Release()
		{
			//Discarded unreachable code: IL_0008
			CustomeElementModel customeElementModel = Model;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x111D550", Offset = "0x111BF50", VA = "0x18111D550")]
		public CustomElement()
		{
		}
	}
}
