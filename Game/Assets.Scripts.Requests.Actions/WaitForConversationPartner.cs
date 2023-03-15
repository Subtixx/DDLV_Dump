using Cpp2IlInjected;
using Mdl.Characters;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[Icon("Dialogue", false, "")]
	[Category("Mdl/Request")]
	public class WaitForConversationPartner : MdlActionTask<Character>
	{
		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xD4C790", Offset = "0xD4B190", VA = "0x180D4C790", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0013
			((object)this)._002Ector();
			base.CharacterComponent.WaitingForConversationPartner = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xD4C790", Offset = "0xD4B190", VA = "0x180D4C790", Slot = "16")]
		protected override void OnStop()
		{
			//Discarded unreachable code: IL_0013
			((object)this)._002Ector();
			base.CharacterComponent.WaitingForConversationPartner = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xD4C7D0", Offset = "0xD4B1D0", VA = "0x180D4C7D0")]
		public WaitForConversationPartner()
		{
			((MdlActionTask<T>)(object)this)._002Ector();
		}
	}
}
