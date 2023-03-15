using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007E5")]
	public class TaskButtonHolder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E68")]
		public List<NotificationButton> Buttons;

		[Cpp2IlInjected.Token(Token = "0x6003257")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TaskButtonHolder()
		{
		}
	}
}
