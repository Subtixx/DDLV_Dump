using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000615")]
	[CreateAssetMenu]
	public class FtueEventComplete : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002497")]
		[ItemID]
		public int ftueEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002498")]
		private Client client;

		[Cpp2IlInjected.Token(Token = "0x6001AF9")]
		[Cpp2IlInjected.Address(RVA = "0x8B3140", Offset = "0x8B1B40", VA = "0x1808B3140", Slot = "4")]
		protected override void _Init(Client client)
		{
			//Discarded unreachable code: IL_003e
			this.client = client;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
			ProfileEventDispatcher.FtueEventComplete value = OnFtueEventComplete;
			_003CDispatcher_003Ek__BackingField.OnFtueEventComplete -= value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = client.Dispatcher;
			ProfileEventDispatcher.FtueEventComplete value2 = OnFtueEventComplete;
			_003CDispatcher_003Ek__BackingField2.OnFtueEventComplete += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AFA")]
		[Cpp2IlInjected.Address(RVA = "0x8B3230", Offset = "0x8B1C30", VA = "0x1808B3230", Slot = "5")]
		protected override bool _IsTrue()
		{
			//Discarded unreachable code: IL_0025
			//IL_0024: Expected O, but got I4
			RepeatedField<int> completedFtueEvents_ = client.profile.player_.completedFtueEvents_;
			int num = ftueEvent;
			return ((RepeatedField<T>)(object)completedFtueEvents_).Contains((T)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AFB")]
		[Cpp2IlInjected.Address(RVA = "0x8B3070", Offset = "0x8B1A70", VA = "0x1808B3070")]
		private void OnFtueEventComplete(Item ftueEventItem)
		{
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AFC")]
		[Cpp2IlInjected.Address(RVA = "0x8B30A0", Offset = "0x8B1AA0", VA = "0x1808B30A0", Slot = "6")]
		protected override void _CleanUp()
		{
			//Discarded unreachable code: IL_0027
			Client client = this.client;
			if (client != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				ProfileEventDispatcher.FtueEventComplete value = OnFtueEventComplete;
				_003CDispatcher_003Ek__BackingField.OnFtueEventComplete -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AFD")]
		[Cpp2IlInjected.Address(RVA = "0x8B32A0", Offset = "0x8B1CA0", VA = "0x1808B32A0")]
		public FtueEventComplete()
		{
		}
	}
}
