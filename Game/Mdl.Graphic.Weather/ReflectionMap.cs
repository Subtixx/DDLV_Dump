using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Graphic.Weather
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000501")]
	public class ReflectionMap : IKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F8F")]
		[SerializeField]
		private float _time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4001F90")]
		[SerializeField]
		private float _duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F91")]
		public AssetReference cubemap;

		[Cpp2IlInjected.Token(Token = "0x170002E1")]
		public float time
		{
			[Cpp2IlInjected.Token(Token = "0x6001641")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDD0", Offset = "0x8EC7D0", VA = "0x1808EDDD0", Slot = "4")]
			get
			{
				return _time;
			}
			[Cpp2IlInjected.Token(Token = "0x6001642")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDE0", Offset = "0x8EC7E0", VA = "0x1808EDDE0", Slot = "5")]
			set
			{
				_time = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E2")]
		public float duration
		{
			[Cpp2IlInjected.Token(Token = "0x6001643")]
			[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F2000", VA = "0x1807F3600", Slot = "6")]
			get
			{
				return _duration;
			}
			[Cpp2IlInjected.Token(Token = "0x6001644")]
			[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F2010", VA = "0x1807F3610", Slot = "7")]
			set
			{
				_duration = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001645")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ReflectionMap()
		{
		}
	}
}
