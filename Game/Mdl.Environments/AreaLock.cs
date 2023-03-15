using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Scene;
using Mdl.Streaming;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Environments
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200061A")]
	public class AreaLock
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024A8")]
		[SerializeField]
		private VillageAreaType _areaType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024A9")]
		[SerializeField]
		private AssetReference _areaThornsAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024AA")]
		[SerializeField]
		private AssetReference _areaThornsAddressStreamable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024AB")]
		[SerializeField]
		private bool playUnlockAreaJingle = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40024AC")]
		[SerializeField]
		private bool playUnlockSfx;

		[Cpp2IlInjected.Token(Token = "0x170003D4")]
		public AssetReference AreaThornsAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B13")]
			[Cpp2IlInjected.Address(RVA = "0xA444D0", Offset = "0xA42ED0", VA = "0x180A444D0")]
			get
			{
				//Discarded unreachable code: IL_0034
				GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
				if ((object)instance != null && instance.ActiveConfig.IsStreamingAreaLocksBigThorns && _areaThornsAddressStreamable.RuntimeKeyIsValid())
				{
					return _areaThornsAddressStreamable;
				}
				return _areaThornsAddress;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D5")]
		public VillageAreaType AreaType
		{
			[Cpp2IlInjected.Token(Token = "0x6001B14")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get
			{
				return _areaType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D6")]
		public GameObject AreaThorns
		{
			[Cpp2IlInjected.Token(Token = "0x6001B15")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CAreaThorns_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B16")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CAreaThorns_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D7")]
		public bool DoPlayUnlockAreaJingle
		{
			[Cpp2IlInjected.Token(Token = "0x6001B17")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return playUnlockAreaJingle;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D8")]
		public bool DoPlayUnlockSfx
		{
			[Cpp2IlInjected.Token(Token = "0x6001B18")]
			[Cpp2IlInjected.Address(RVA = "0xA44560", Offset = "0xA42F60", VA = "0x180A44560")]
			get
			{
				return playUnlockSfx;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B19")]
		[Cpp2IlInjected.Address(RVA = "0xA444C0", Offset = "0xA42EC0", VA = "0x180A444C0")]
		public AreaLock()
		{
		}
	}
}
