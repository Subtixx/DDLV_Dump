using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000631")]
	public abstract class MapItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002281")]
		[SerializeField]
		public GameObject PinVisual;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002282")]
		internal Action<MapItem> OnMapItemClicked;

		[Cpp2IlInjected.Token(Token = "0x17000615")]
		internal virtual bool IsPinned
		{
			[Cpp2IlInjected.Token(Token = "0x600285B")]
			[Cpp2IlInjected.Address(RVA = "0x117D4D0", Offset = "0x117BED0", VA = "0x18117D4D0", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_000c
				return PinVisual.activeSelf;
			}
			[Cpp2IlInjected.Token(Token = "0x600285C")]
			[Cpp2IlInjected.Address(RVA = "0x117D770", Offset = "0x117C170", VA = "0x18117D770", Slot = "5")]
			set
			{
				//Discarded unreachable code: IL_000d
				PinVisual.SetActive(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600285D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		internal abstract void CopyTo(MapItem target);

		[Cpp2IlInjected.Token(Token = "0x600285E")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected MapItem()
		{
		}
	}
}
