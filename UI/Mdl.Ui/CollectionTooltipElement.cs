using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000329")]
	public class CollectionTooltipElement : MonoBehaviour, IHasText, IHasSpriteURI, IHasFloatValue, IHasTextureReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000F12")]
		public AssetReference[] Assets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000F13")]
		public AssetAddress[] AssetAddresses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000F14")]
		public UnityEvent[] OnPhaseChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000F15")]
		public UnityEvent OnRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000F16")]
		public UnityEvent OnDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000F17")]
		public Image Icon;

		[Cpp2IlInjected.Token(Token = "0x1700037C")]
		public CollectionTooltipElementModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x6001430")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001431")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001432")]
		[Cpp2IlInjected.Address(RVA = "0x11162B0", Offset = "0x1114CB0", VA = "0x1811162B0")]
		private void OnDisable()
		{
			OnDisabled?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001433")]
		[Cpp2IlInjected.Address(RVA = "0x114A900", Offset = "0x1149300", VA = "0x18114A900")]
		public void RefreshDisplay()
		{
			CollectionTooltipElementModel collectionTooltipElementModel = Model;
			if (collectionTooltipElementModel != null)
			{
				collectionTooltipElementModel.UpdateDisplay(this);
				OnRefresh?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001434")]
		[Cpp2IlInjected.Address(RVA = "0x114A720", Offset = "0x1149120", VA = "0x18114A720", Slot = "4")]
		public string GetText(TextType textType)
		{
			//Discarded unreachable code: IL_0018, IL_001c
			CollectionTooltipElementModel collectionTooltipElementModel = Model;
			if (collectionTooltipElementModel != null)
			{
				Dictionary<TextType, string> _003CTexts_003Ek__BackingField = collectionTooltipElementModel.Texts;
				throw new NullReferenceException();
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001435")]
		[Cpp2IlInjected.Address(RVA = "0x114A7C0", Offset = "0x11491C0", VA = "0x18114A7C0", Slot = "5")]
		public string GetURI(SpriteType spriteType)
		{
			//Discarded unreachable code: IL_0012, IL_0016, IL_0024
			Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = Model.Sprites;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001436")]
		[Cpp2IlInjected.Address(RVA = "0x114A860", Offset = "0x1149260", VA = "0x18114A860", Slot = "6")]
		public float GetValue(FloatValueType valueType)
		{
			//Discarded unreachable code: IL_0012, IL_0016, IL_0024
			Dictionary<FloatValueType, float> _003CFloats_003Ek__BackingField = Model.Floats;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001437")]
		[Cpp2IlInjected.Address(RVA = "0x114A680", Offset = "0x1149080", VA = "0x18114A680", Slot = "7")]
		public AssetReferenceTexture GetReference(SpriteType spriteType)
		{
			//Discarded unreachable code: IL_0012, IL_0016, IL_0024
			Dictionary<SpriteType, AssetReferenceTexture> _003CReferences_003Ek__BackingField = Model.References;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001438")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CollectionTooltipElement()
		{
		}
	}
}
