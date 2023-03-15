using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000319")]
	public abstract class CollectionTooltipElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700036B")]
		public Dictionary<TextType, string> Texts
		{
			[Cpp2IlInjected.Token(Token = "0x60013EE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CTexts_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013EF")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CTexts_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<TextType, string>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x1700036C")]
		public Dictionary<SpriteType, string> Sprites
		{
			[Cpp2IlInjected.Token(Token = "0x60013F0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CSprites_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013F1")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CSprites_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<SpriteType, string>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x1700036D")]
		public Dictionary<SpriteType, AssetReferenceTexture> References
		{
			[Cpp2IlInjected.Token(Token = "0x60013F2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CReferences_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013F3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CReferences_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<SpriteType, AssetReferenceTexture>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x1700036E")]
		public Dictionary<FloatValueType, float> Floats
		{
			[Cpp2IlInjected.Token(Token = "0x60013F4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CFloats_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013F5")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CFloats_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<FloatValueType, float>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x1700036F")]
		public IItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60013F6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013F7")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013F8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void UpdateDisplay(CollectionTooltipElement view);

		[Cpp2IlInjected.Token(Token = "0x60013F9")]
		[Cpp2IlInjected.Address(RVA = "0x114A3D0", Offset = "0x1148DD0", VA = "0x18114A3D0")]
		protected CollectionTooltipElementModel()
		{
		}
	}
}
