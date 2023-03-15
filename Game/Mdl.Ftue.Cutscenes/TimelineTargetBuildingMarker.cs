using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005D1")]
	public class TimelineTargetBuildingMarker : Marker, INotification
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40023B3")]
		[SerializeField]
		private bool reset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40023B4")]
		[SerializeField]
		private bool useRandomBuilding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x40023B5")]
		[SerializeField]
		private bool onlyUseCurseAffected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x40023B6")]
		[SerializeField]
		private bool ignoreStalls = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40023B7")]
		[SerializeField]
		private bool ignoreWells;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40023B8")]
		[SerializeField]
		[ItemID]
		private List<int> buildingsToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40023B9")]
		[ItemID]
		[SerializeField]
		private int buildingId;

		[Cpp2IlInjected.Token(Token = "0x170003BD")]
		public PropertyName id
		{
			[Cpp2IlInjected.Token(Token = "0x60019E8")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BE")]
		public bool Reset
		{
			[Cpp2IlInjected.Token(Token = "0x60019E9")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return reset;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BF")]
		public bool UseRandom
		{
			[Cpp2IlInjected.Token(Token = "0x60019EA")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get
			{
				return useRandomBuilding;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C0")]
		public int BuildingID
		{
			[Cpp2IlInjected.Token(Token = "0x60019EB")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return buildingId;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C1")]
		public bool OnlyUseCurseAffected
		{
			[Cpp2IlInjected.Token(Token = "0x60019EC")]
			[Cpp2IlInjected.Address(RVA = "0xDC7980", Offset = "0xDC6380", VA = "0x180DC7980")]
			get
			{
				return onlyUseCurseAffected;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C2")]
		public bool IgnoreStalls
		{
			[Cpp2IlInjected.Token(Token = "0x60019ED")]
			[Cpp2IlInjected.Address(RVA = "0xDC7990", Offset = "0xDC6390", VA = "0x180DC7990")]
			get
			{
				return ignoreStalls;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C3")]
		public bool IgnoreWells
		{
			[Cpp2IlInjected.Token(Token = "0x60019EE")]
			[Cpp2IlInjected.Address(RVA = "0xDD7720", Offset = "0xDD6120", VA = "0x180DD7720")]
			get
			{
				return ignoreWells;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003C4")]
		public List<int> BuildingsToIgnore
		{
			[Cpp2IlInjected.Token(Token = "0x60019EF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return buildingsToIgnore;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019F0")]
		[Cpp2IlInjected.Address(RVA = "0x13D0D60", Offset = "0x13CF760", VA = "0x1813D0D60")]
		public TimelineTargetBuildingMarker()
		{
		}
	}
}
