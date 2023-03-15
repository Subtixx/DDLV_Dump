using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using Meta.Missions;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[Category("Mdl/Request")]
	[Icon("Dialogue", false, "")]
	[Description("Plays animation of giving an item (All options are optional)\nFakeItem: A fake give animation (No inventory changes + Support NpcDiscussion)\nFakeAmount: A fake give amount (A value <= 0 will display 1)\nItemIndex: To display a specific item from ItemsToGive (-1 to display all items)\nItemIndexes: Comma separated index list for ItemsToGive (ItemIndex must be set to -1)\nSkipAnimation: Give without animation\nACTOR: The person who GIVE the item, normally it's not Instigator")]
	public class GiveItem : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public BBParameter<Item> FakeItem = (BBParameter<Item>)(object)new BBParameter<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public BBParameter<int> FakeAmount = (BBParameter<int>)(object)new BBParameter<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public BBParameter<int> ItemIndex = (BBParameter<int>)(object)new BBParameter<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public BBParameter<string> ItemIndexes = (BBParameter<string>)(object)new BBParameter<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public BBParameter<bool> SkipAnimation = (BBParameter<bool>)(object)new BBParameter<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private bool isFake;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private System.Threading.Tasks.Task giveAnimationTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		private int FakeAmountValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x8CD190", Offset = "0x8CBB90", VA = "0x1808CD190")]
			get
			{
				//Discarded unreachable code: IL_000e, IL_001a
				//IL_000c: Expected I4, but got O
				//IL_001a: Expected I4, but got O
				int num = (int)((BBParameter<T>)(object)FakeAmount).value;
				return 1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x8CD200", Offset = "0x8CBC00", VA = "0x1808CD200", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_0069
				//IL_0053: Expected O, but got I4
				Item value = (Item)((BBParameter<T>)(object)FakeItem).value;
				bool flag = default(bool);
				if (flag)
				{
					int fakeAmountValue = FakeAmountValue;
					Item value2 = (Item)((BBParameter<T>)(object)FakeItem).value;
					char[] array = new char[1];
					array[0] = '!';
					string text = default(string);
					string arg = ((IEnumerable<>)(object)text.Split(array)).Last<string>();
					string text2 = $"\nFake: {fakeAmountValue} x {arg}";
					string text3 = "GiveItem" + text2;
				}
				return "GiveItem";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFB0", Offset = "0x8CA9B0", VA = "0x1808CBFB0", Slot = "13")]
		protected override void OnExecute()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x8CCDA0", Offset = "0x8CB7A0", VA = "0x1808CCDA0", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_0050
			//IL_0021: Expected I4, but got I8
			//IL_005c: Expected I4, but got I8
			((object)this)._002Ector();
			System.Threading.Tasks.Task task = giveAnimationTask;
			if (task != null)
			{
				if (!task.IsCompletedSuccessfully())
				{
					return;
				}
				ulong num = default(ulong);
				EndAction((byte)num != 0);
				if (!isFake && ((NodeCanvas.Framework.Task)this)._blackboard != null)
				{
					string giveItemAniDoneBB = MissionStep.GiveItemAniDoneBB;
					int num2 = 0;
					uint num3 = default(uint);
					if (num2 < (int)num3)
					{
						num2 += num2;
						num2++;
					}
				}
			}
			else
			{
				ulong num4 = default(ulong);
				EndAction((byte)num4 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x8CCD70", Offset = "0x8CB770", VA = "0x1808CCD70", Slot = "16")]
		protected override void OnStop()
		{
			//Discarded unreachable code: IL_0012
			((object)this)._002Ector();
			cts.Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8CD000", Offset = "0x8CBA00", VA = "0x1808CD000")]
		public GiveItem()
		{
		}
	}
}
