using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003D7")]
	public class CraftingRecipeItemItemModel : ItemSlotModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000405")]
		public Vector2 IconScale
		{
			[Cpp2IlInjected.Token(Token = "0x600185F")]
			[Cpp2IlInjected.Address(RVA = "0x11067B0", Offset = "0x11051B0", VA = "0x1811067B0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6001860")]
			[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
			[CompilerGenerated]
			set
			{
				_003CIconScale_003Ek__BackingField = value;
			}
		} = (Vector2)1062836634;


		[Cpp2IlInjected.Token(Token = "0x17000406")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x40012E0")]
		public bool IsUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6001861")]
			[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001862")]
			[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000407")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x31"), Cpp2IlInjected.Token(Token = "0x40012E1")]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x6001863")]
			[Cpp2IlInjected.Address(RVA = "0x997D90", Offset = "0x996790", VA = "0x180997D90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001864")]
			[Cpp2IlInjected.Address(RVA = "0x997DC0", Offset = "0x9967C0", VA = "0x180997DC0")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000408")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x32"), Cpp2IlInjected.Token(Token = "0x40012E2")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6001865")]
			[Cpp2IlInjected.Address(RVA = "0x997D80", Offset = "0x996780", VA = "0x180997D80")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001866")]
			[Cpp2IlInjected.Address(RVA = "0x997DB0", Offset = "0x9967B0", VA = "0x180997DB0")]
			internal set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000409")]
		public CraftingRecipeItemData CraftingRecipeItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001867")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CCraftingRecipeItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001868")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CCraftingRecipeItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001869")]
		[Cpp2IlInjected.Address(RVA = "0x1115F40", Offset = "0x1114940", VA = "0x181115F40", Slot = "4")]
		public override void UpdateDisplay(ItemSlot view)
		{
			//Discarded unreachable code: IL_0098
			//IL_0009: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			int num = 0;
			bool flag = view == (UnityEngine.Object)num;
			if (!flag)
			{
				((TemplateButton)view).IgnoreHighlightWhenSelected = flag;
				RawImage icon = view.Icon;
				int num2 = 0;
				if (icon != (UnityEngine.Object)num2)
				{
					RectTransform rectTransform = view.Icon.rectTransform;
					Vector2 vector = IconScale;
					float y = IconScale.y;
					int num3 = 0;
				}
				bool flag3 = (view.IsActivated = IsUnlocked);
				UnityEvent[] extraPhases = view.ExtraPhases;
				if (IsUnlocked)
				{
				}
				extraPhases[1]?.Invoke();
				bool flag5 = (view.IsSelected = IsSelected);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600186A")]
		[Cpp2IlInjected.Address(RVA = "0x1115E20", Offset = "0x1114820", VA = "0x181115E20", Slot = "5")]
		public override void Release(ItemSlot view)
		{
			//Discarded unreachable code: IL_0046
			//IL_0009: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			int num = 0;
			if (!(view == (UnityEngine.Object)num))
			{
				base.Release(view);
				RawImage icon = view.Icon;
				int num2 = 0;
				if (icon != (UnityEngine.Object)num2)
				{
					RectTransform rectTransform = view.Icon.rectTransform;
					float z = Vector3.one.z;
				}
				view.IsActivated = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600186B")]
		[Cpp2IlInjected.Address(RVA = "0x11160E0", Offset = "0x1114AE0", VA = "0x1811160E0")]
		public unsafe CraftingRecipeItemItemModel()
		{
			//IL_000d: Expected O, but got I8
			//IL_0018: Expected native int or pointer, but got O
			((Vector2*)(IntPtr)IconScale)->y = 0.85f;
			((CommonAcl._003C_003Ec__DisplayClass57_0)(object)this)._002Ector();
		}
	}
}
