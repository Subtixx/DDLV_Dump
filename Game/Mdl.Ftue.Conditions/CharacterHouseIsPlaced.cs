using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000611")]
	[CreateAssetMenu]
	public class CharacterHouseIsPlaced : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002490")]
		[ItemID]
		public int character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002491")]
		private CharacterItemData data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002492")]
		private Client client;

		[Cpp2IlInjected.Token(Token = "0x6001AE4")]
		[Cpp2IlInjected.Address(RVA = "0x12DB450", Offset = "0x12D9E50", VA = "0x1812DB450", Slot = "4")]
		protected override void _Init(Client client)
		{
			//Discarded unreachable code: IL_005a
			this.client = client;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			CharacterItemData characterItemData = default(CharacterItemData);
			data = characterItemData;
			if ((long)data != 0)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				ProfileEventDispatcher.GridChanged value = OnGridChanged;
				_003CDispatcher_003Ek__BackingField.OnGridChanged -= value;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = client.Dispatcher;
				ProfileEventDispatcher.GridChanged value2 = OnGridChanged;
				_003CDispatcher_003Ek__BackingField2.OnGridChanged += value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE5")]
		[Cpp2IlInjected.Address(RVA = "0x8B3070", Offset = "0x8B1A70", VA = "0x1808B3070")]
		private void OnGridChanged(IGrid grid, GridChangedOperation operation, GridObject gridObject, bool automatic, [System.Runtime.InteropServices.Optional] GridAddObjectOptions options)
		{
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE6")]
		[Cpp2IlInjected.Address(RVA = "0x12DB610", Offset = "0x12DA010", VA = "0x1812DB610", Slot = "5")]
		protected override bool _IsTrue()
		{
			CharacterItemData characterItemData = data;
			if (characterItemData != null)
			{
				ProfileWorld world_ = client.profile.world_;
				int house = characterItemData.House;
				bool result = default(bool);
				return result;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE7")]
		[Cpp2IlInjected.Address(RVA = "0x12DB3B0", Offset = "0x12D9DB0", VA = "0x1812DB3B0", Slot = "6")]
		protected override void _CleanUp()
		{
			//Discarded unreachable code: IL_0027
			Client client = this.client;
			if (client != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				ProfileEventDispatcher.GridChanged value = OnGridChanged;
				_003CDispatcher_003Ek__BackingField.OnGridChanged -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AE8")]
		[Cpp2IlInjected.Address(RVA = "0x8B32A0", Offset = "0x8B1CA0", VA = "0x1808B32A0")]
		public CharacterHouseIsPlaced()
		{
		}
	}
}
