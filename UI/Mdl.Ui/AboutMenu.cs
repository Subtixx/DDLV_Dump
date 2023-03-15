using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000692")]
	[RequiredAllNotNull]
	public class AboutMenu : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024EF")]
		[SerializeField]
		private ClientInfo _clientInfo;

		[Cpp2IlInjected.Token(Token = "0x6002A64")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AboutMenu()
		{
		}
	}
}
