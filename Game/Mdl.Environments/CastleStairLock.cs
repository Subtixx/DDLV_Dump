using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Mdl.Utils;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Environments
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000624")]
	public class CastleStairLock
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40024E0")]
		[ItemID]
		[SerializeField]
		private int _conditionItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024E1")]
		[SerializeField]
		private AssetReference _stairThornsAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024E2")]
		[SerializeField]
		private AssetReference _stairThornsAddressStreamable;

		[Cpp2IlInjected.Token(Token = "0x170003DF")]
		public Item ConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001B40")]
			[Cpp2IlInjected.Address(RVA = "0x12D80C0", Offset = "0x12D6AC0", VA = "0x1812D80C0")]
			get
			{
				long num = Convert.ToInt64((uint)_conditionItem);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E0")]
		public AssetReference StairThornsAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6001B41")]
			[Cpp2IlInjected.Address(RVA = "0x12D8120", Offset = "0x12D6B20", VA = "0x1812D8120")]
			get
			{
				//Discarded unreachable code: IL_0026
				int num = 0;
				if (AreaLocksController.IsStreamingAreaBlockers && _stairThornsAddressStreamable.RuntimeKeyIsValid())
				{
					return _stairThornsAddressStreamable;
				}
				return _stairThornsAddress;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003E1")]
		public GameObject StairsThorns
		{
			[Cpp2IlInjected.Token(Token = "0x6001B42")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CStairsThorns_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B43")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CStairsThorns_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B44")]
		[Cpp2IlInjected.Address(RVA = "0x12D7EF0", Offset = "0x12D68F0", VA = "0x1812D7EF0")]
		public bool IsUnlocked()
		{
			//Discarded unreachable code: IL_0024
			long num = Convert.ToInt64((uint)_conditionItem);
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B45")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CastleStairLock()
		{
		}
	}
}
