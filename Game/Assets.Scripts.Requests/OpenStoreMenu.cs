using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[Category("Mdl/Request")]
	[Icon("Dialogue", false, "")]
	[Description("Open a store menu in which player can buy items.\nItemType: type of items available in the list.\nShowBasicCollection: whether or not the menu will show a basic collection of items for the specified type.\nShowOwnedItems: whether or not the menu will show items owned by the player for the specified type.\nShowOngoingMissionItems: whether or not the menu will show items related to an active quest for the specified type.")]
	public class OpenStoreMenu : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		[RequiredField]
		public BBParameter<ItemType> ItemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public BBParameter<bool> ShowBasicCollection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		public BBParameter<bool> ShowOwnedItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public BBParameter<bool> ShowOngoingMissionItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private BBParameter<CancellationTokenSource> cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private System.Threading.Tasks.Task response;

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xF06CB0", Offset = "0xF056B0", VA = "0x180F06CB0", Slot = "13")]
		protected override void OnExecute()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xF07250", Offset = "0xF05C50", VA = "0x180F07250", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_001c
			if (response.IsCompleted)
			{
				EndAction(success: true);
			}
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xF071E0", Offset = "0xF05BE0", VA = "0x180F071E0", Slot = "16")]
		protected override void OnStop()
		{
			//Discarded unreachable code: IL_0017
			((object)this)._002Ector();
			((CancellationTokenSource)((BBParameter<T>)(object)cts).value).Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xF072A0", Offset = "0xF05CA0", VA = "0x180F072A0")]
		public OpenStoreMenu()
		{
			//Discarded unreachable code: IL_0019, IL_002c, IL_003f
			BBParameter<ItemType> bBParameter = (ItemType = (BBParameter<ItemType>)(object)new BBParameter<T>());
			BBParameter<bool> bBParameter2 = (BBParameter<bool>)(object)new BBParameter<T>();
			throw new NullReferenceException();
		}
	}
}
