using System;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	public class DummyDebugSetPlayerNameToPotato : SetJsonTokenToIfNotEqual
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x116DCA0", Offset = "0x116C6A0", VA = "0x18116DCA0")]
		public DummyDebugSetPlayerNameToPotato()
		{
			JToken jToken = JToken.FromObject("potato");
			base._002Ector();
			((OnlineProfileUpdate)this).Name = "DummyDebugSetPlayerNameToPotato";
			((SearchTokenOnlineProfileUpdate)this).searchToken = "Player.Name";
			base.newValue = jToken;
			throw new NullReferenceException();
		}
	}
}
