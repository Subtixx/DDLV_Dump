using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Missions;
using Mdl.Systems;
using Meta;
using Meta.Missions;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000624")]
	public class MapBuildingItem : MapItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002230")]
		public GameObject Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002231")]
		public Item Item = Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002232")]
		public GoBehavior GoBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002233")]
		public GameObject QuestMarker;

		[Cpp2IlInjected.Token(Token = "0x17000607")]
		public Character MetaCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6002817")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CMetaCharacter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002818")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CMetaCharacter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000608")]
		internal override bool IsPinned
		{
			[Cpp2IlInjected.Token(Token = "0x6002819")]
			[Cpp2IlInjected.Address(RVA = "0xFAFFE0", Offset = "0xFAE9E0", VA = "0x180FAFFE0", Slot = "4")]
			get
			{
				return base.IsPinned;
			}
			[Cpp2IlInjected.Token(Token = "0x600281A")]
			[Cpp2IlInjected.Address(RVA = "0xFAFFF0", Offset = "0xFAE9F0", VA = "0x180FAFFF0", Slot = "5")]
			set
			{
				GoBehaviourSystem system;
				bool flag = default(bool);
				do
				{
					base.IsPinned = value;
					system = SystemRoot.Instance.GetSystem<GoBehaviourSystem>();
					if (value)
					{
						Item trailTarget = system.trailTarget;
						if (flag)
						{
							Item item2 = (system.TrailTarget = Item);
						}
						return;
					}
				}
				while ((object)system.trailTarget == null);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600281B")]
		[Cpp2IlInjected.Address(RVA = "0xFAFDE0", Offset = "0xFAE7E0", VA = "0x180FAFDE0")]
		internal void RefreshDisplay()
		{
			//Discarded unreachable code: IL_002b
			GoBehaviourSystem system = SystemRoot.Instance.GetSystem<GoBehaviourSystem>();
			bool flag = default(bool);
			if (flag && (object)system.trailTarget != null)
			{
				((Action<T>)(object)OnMapItemClicked)?.Invoke((T)this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600281C")]
		[Cpp2IlInjected.Address(RVA = "0xFAFD90", Offset = "0xFAE790", VA = "0x180FAFD90", Slot = "7")]
		public virtual void OnClicked()
		{
			((Action<T>)(object)OnMapItemClicked)?.Invoke((T)this);
		}

		[Cpp2IlInjected.Token(Token = "0x600281D")]
		[Cpp2IlInjected.Address(RVA = "0xFAFD20", Offset = "0xFAE720", VA = "0x180FAFD20", Slot = "6")]
		internal override void CopyTo(MapItem target)
		{
			GameObject pinVisual = PinVisual;
			GameObject pinVisual2 = target.PinVisual;
			bool activeSelf = pinVisual.activeSelf;
			pinVisual2.SetActive(activeSelf);
			Action<MapItem> action = (target.OnMapItemClicked = OnMapItemClicked);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600281E")]
		[Cpp2IlInjected.Address(RVA = "0xFAFF70", Offset = "0xFAE970", VA = "0x180FAFF70")]
		public MapBuildingItem()
		{
		}
	}
}
