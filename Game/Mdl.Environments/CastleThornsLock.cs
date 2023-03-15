using System;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Environments
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200061B")]
	public class CastleThornsLock
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024AE")]
		[SerializeField]
		[ItemID]
		private int _castleItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024AF")]
		[SerializeField]
		private AssetReference _castleThornsAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024B0")]
		[SerializeField]
		private AssetReference _castleThornsAddressStreamable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024B1")]
		public AK.Wwise.Event _lockRemovedSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40024B2")]
		public AK.Wwise.Event _unlockMusic;

		[Cpp2IlInjected.Token(Token = "0x170003D9")]
		public AssetReference CastleThornsAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B1A")]
			[Cpp2IlInjected.Address(RVA = "0x12D8120", Offset = "0x12D6B20", VA = "0x1812D8120")]
			get
			{
				//Discarded unreachable code: IL_0026
				int num = 0;
				if (AreaLocksController.IsStreamingAreaBlockers && _castleThornsAddressStreamable.RuntimeKeyIsValid())
				{
					return _castleThornsAddressStreamable;
				}
				return _castleThornsAddress;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DA")]
		public Item CastleItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001B1B")]
			[Cpp2IlInjected.Address(RVA = "0x12D8900", Offset = "0x12D7300", VA = "0x1812D8900")]
			get
			{
				long num = Convert.ToInt64((uint)_castleItem);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DB")]
		public GameObject CastleThorns
		{
			[Cpp2IlInjected.Token(Token = "0x6001B1C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CCastleThorns_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B1D")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CCastleThorns_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B1E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CastleThornsLock()
		{
		}
	}
}
