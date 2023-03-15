using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Navigation;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000792")]
	public class OpenUIAlertPlayerTaskData : MonoBehaviour, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B4D")]
		[StringId(false)]
		public string stringID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B4E")]
		public AK.Wwise.Event popupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B4F")]
		public AK.Wwise.Event closePopupSfx;

		[Cpp2IlInjected.Token(Token = "0x600219C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public OpenUIAlertPlayerTaskData()
		{
		}
	}
}
