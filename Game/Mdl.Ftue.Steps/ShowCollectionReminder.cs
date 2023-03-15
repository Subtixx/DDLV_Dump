using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Ui;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x20005AD")]
	[CreateAssetMenu]
	public class ShowCollectionReminder : FtueStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40022FF")]
		public string reminderStringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002300")]
		public CollectionSubMenu collectionSubMenu;

		[Cpp2IlInjected.Token(Token = "0x600194C")]
		[Cpp2IlInjected.Address(RVA = "0xF4FCD0", Offset = "0xF4E6D0", VA = "0x180F4FCD0", Slot = "4")]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0023
			BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
			string stringID = reminderStringID;
			CollectionSubMenu collectionSubMenu = this.collectionSubMenu;
			_003CInstance_003Ek__BackingField.ShowCollectionReminder(collectionSubMenu, stringID);
			return (Task<FtueResult>)(object)Task.FromResult(result);
		}

		[Cpp2IlInjected.Token(Token = "0x600194D")]
		[Cpp2IlInjected.Address(RVA = "0xF060E0", Offset = "0xF04AE0", VA = "0x180F060E0")]
		public ShowCollectionReminder()
		{
		}
	}
}
