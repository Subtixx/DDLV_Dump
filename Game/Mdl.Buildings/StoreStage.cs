using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Displays;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009D5")]
	public class StoreStage : StoreDisplay
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003653")]
		[SerializeField]
		private Transform _origin;

		[Cpp2IlInjected.Token(Token = "0x17000699")]
		public Transform Origin
		{
			[Cpp2IlInjected.Token(Token = "0x6002DFC")]
			[Cpp2IlInjected.Address(RVA = "0x105FCC0", Offset = "0x105E6C0", VA = "0x18105FCC0")]
			get
			{
				//IL_0010: Expected O, but got I4
				Transform origin = _origin;
				int num = 0;
				if (origin != (Object)num)
				{
					return _origin;
				}
				return base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DFD")]
		[Cpp2IlInjected.Address(RVA = "0x105F980", Offset = "0x105E380", VA = "0x18105F980", Slot = "7")]
		protected override void Start()
		{
			base.Start();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DFE")]
		[Cpp2IlInjected.Address(RVA = "0x105F970", Offset = "0x105E370", VA = "0x18105F970", Slot = "8")]
		protected override void OnDestroy()
		{
			base.OnDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DFF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0", Slot = "9")]
		internal override void Init()
		{
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E00")]
		[Cpp2IlInjected.Address(RVA = "0x105EB40", Offset = "0x105D540", VA = "0x18105EB40", Slot = "10")]
		protected override List<SlotTransform> GetSlotTransforms(DisplayInfo displayInfo)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002E01")]
		[Cpp2IlInjected.Address(RVA = "0x105D5A0", Offset = "0x105BFA0", VA = "0x18105D5A0")]
		public StoreStage()
		{
		}
	}
}
