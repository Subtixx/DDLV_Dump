using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using NodeCanvas.DialogueTrees.Gameloft.Flux;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[Description("(Ctrl-Shift-Y) Turn flag ON/OFF")]
	[Icon("Dialogue", false, "")]
	[Category("Mdl")]
	public class SetDialogueFlag : MdlActionTaskAsync, IDataValidation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public BBParameter<ItemFlagFiltering> flag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public BBParameter<bool> active;

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0xF4A3F0", Offset = "0xF48DF0", VA = "0x180F4A3F0", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_004f
				ItemFlagFiltering value = (ItemFlagFiltering)((BBParameter<T>)(object)flag).value;
				BBParameter<bool> bBParameter = active;
				Item item = value.Item;
				if (((BBParameter<T>)(object)bBParameter).value == null)
				{
				}
				string itemDisplayName = FluxStatement.GetItemDisplayName(item.ItemID);
				string prefix = "SetFlag " + "ON" + "\n" + itemDisplayName;
				return AddErrors(prefix);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xF4A1C0", Offset = "0xF48BC0", VA = "0x180F4A1C0", Slot = "18")]
		[AsyncStateMachine(typeof(_003CDoActionAsync_003Ed__4))]
		protected override System.Threading.Tasks.Task DoActionAsync()
		{
			int num = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xF4A2C0", Offset = "0xF48CC0", VA = "0x180F4A2C0")]
		public static string GetInfo(Item _item, bool _active)
		{
			int itemID = _item.ItemID;
			if (!_active)
			{
			}
			string itemDisplayName = FluxStatement.GetItemDisplayName(itemID);
			return "SetFlag " + "ON" + "\n" + itemDisplayName;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xF4A0E0", Offset = "0xF48AE0", VA = "0x180F4A0E0", Slot = "20")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001f
			if (((BBParameter<T>)(object)flag).value != null)
			{
				context.AddInvalidMemberError("Contain invalid items", "flag");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0xF4A390", Offset = "0xF48D90", VA = "0x180F4A390")]
		public SetDialogueFlag()
		{
			BBParameter<> bBParameter = default(BBParameter<>);
			active = (BBParameter<bool>)(object)bBParameter;
			((MdlActionTask)this)._002Ector();
		}
	}
}
