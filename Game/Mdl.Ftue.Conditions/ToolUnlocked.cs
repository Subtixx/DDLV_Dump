using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000619")]
	[CreateAssetMenu]
	public class ToolUnlocked : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40024A6")]
		[ItemID]
		public int tool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40024A7")]
		private Client client;

		[Cpp2IlInjected.Token(Token = "0x6001B0E")]
		[Cpp2IlInjected.Address(RVA = "0x13D6760", Offset = "0x13D5160", VA = "0x1813D6760", Slot = "4")]
		protected override void _Init(Client client)
		{
			//Discarded unreachable code: IL_003e
			this.client = client;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
			ProfileEventDispatcher.ToolAdded value = OnToolAdded;
			_003CDispatcher_003Ek__BackingField.OnToolAdded -= value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = client.Dispatcher;
			ProfileEventDispatcher.ToolAdded value2 = OnToolAdded;
			_003CDispatcher_003Ek__BackingField2.OnToolAdded += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B0F")]
		[Cpp2IlInjected.Address(RVA = "0x13D6850", Offset = "0x13D5250", VA = "0x1813D6850", Slot = "5")]
		protected override bool _IsTrue()
		{
			//Discarded unreachable code: IL_0026
			long num = Convert.ToInt64((uint)tool);
			ProfilePlayer player_ = client.profile.player_;
			bool flag = default(bool);
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B10")]
		[Cpp2IlInjected.Address(RVA = "0x8B3070", Offset = "0x8B1A70", VA = "0x1808B3070")]
		private void OnToolAdded(Item toolItem)
		{
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B11")]
		[Cpp2IlInjected.Address(RVA = "0x13D66C0", Offset = "0x13D50C0", VA = "0x1813D66C0", Slot = "6")]
		protected override void _CleanUp()
		{
			//Discarded unreachable code: IL_0027
			Client client = this.client;
			if (client != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
				ProfileEventDispatcher.ToolAdded value = OnToolAdded;
				_003CDispatcher_003Ek__BackingField.OnToolAdded -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B12")]
		[Cpp2IlInjected.Address(RVA = "0x8B32A0", Offset = "0x8B1CA0", VA = "0x1808B32A0")]
		public ToolUnlocked()
		{
		}
	}
}
