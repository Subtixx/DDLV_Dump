using System;
using System.Net;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002E9")]
	public class CollectionItemModel : ItemSlotModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700033B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000E1C")]
		public bool IsInFirstRow
		{
			[Cpp2IlInjected.Token(Token = "0x60012C5")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012C6")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x29"), Cpp2IlInjected.Token(Token = "0x4000E1D")]
		public bool IsInLastRow
		{
			[Cpp2IlInjected.Token(Token = "0x60012C7")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012C8")]
			[Cpp2IlInjected.Address(RVA = "0xDC79B0", Offset = "0xDC63B0", VA = "0x180DC79B0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033D")]
		public Vector2 IconScale
		{
			[Cpp2IlInjected.Token(Token = "0x60012C9")]
			[Cpp2IlInjected.Address(RVA = "0xEFF420", Offset = "0xEFDE20", VA = "0x180EFF420")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x60012CA")]
			[Cpp2IlInjected.Address(RVA = "0xEFF4B0", Offset = "0xEFDEB0", VA = "0x180EFF4B0")]
			[CompilerGenerated]
			set
			{
				_003CIconScale_003Ek__BackingField = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700033E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x4000E1F")]
		public bool IsCollected
		{
			[Cpp2IlInjected.Token(Token = "0x60012CB")]
			[Cpp2IlInjected.Address(RVA = "0xCCE8B0", Offset = "0xCCD2B0", VA = "0x180CCE8B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012CC")]
			[Cpp2IlInjected.Address(RVA = "0xCCE8C0", Offset = "0xCCD2C0", VA = "0x180CCE8C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700033F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4000E20")]
		public int CharLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60012CD")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012CE")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000340")]
		public CollectionMenuModel MenuModel
		{
			[Cpp2IlInjected.Token(Token = "0x60012CF")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CMenuModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60012D0")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			internal set
			{
				_003CMenuModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000341")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x4000E22")]
		public int SetSortPriority
		{
			[Cpp2IlInjected.Token(Token = "0x60012D1")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012D2")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60012D3")]
		[Cpp2IlInjected.Address(RVA = "0x1004EC0", Offset = "0x10038C0", VA = "0x181004EC0", Slot = "4")]
		public override void UpdateDisplay(ItemSlot view)
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			int num = 0;
			if (!(view == (UnityEngine.Object)num))
			{
				RawImage icon = view.Icon;
				int num2 = 0;
				if (icon != (UnityEngine.Object)num2)
				{
					RectTransform rectTransform = view.Icon.rectTransform;
					Vector2 vector = IconScale;
					float y = IconScale.y;
					int num3 = 0;
				}
				bool flag2 = (view.IsActivated = IsCollected);
				UnityEvent[] extraPhases = view.ExtraPhases;
				int length = extraPhases.Length;
				if (!IsCollected)
				{
					throw new NullReferenceException();
				}
				extraPhases[2]?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012D4")]
		[Cpp2IlInjected.Address(RVA = "0x1004DB0", Offset = "0x10037B0", VA = "0x181004DB0", Slot = "5")]
		public override void Release(ItemSlot view)
		{
			//Discarded unreachable code: IL_003f
			//IL_0009: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			int num = 0;
			if (!(view == (UnityEngine.Object)num))
			{
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

		[Cpp2IlInjected.Token(Token = "0x60012D5")]
		[Cpp2IlInjected.Address(RVA = "0x1005040", Offset = "0x1003A40", VA = "0x181005040")]
		public unsafe CollectionItemModel()
		{
			//IL_001b: Expected F4, but got I4
			//IL_0016: Expected native int or pointer, but got O
			//IL_002b: Expected I4, but got I8
			int num = 0;
			IconScale = Vector2.one;
			((Vector2*)(IntPtr)IconScale)->y = 0f;
			CharLevel = -1;
			((EndPoint)(object)this)._002Ector();
		}
	}
}
