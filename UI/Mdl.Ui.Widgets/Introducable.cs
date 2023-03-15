using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009AF")]
	public abstract class Introducable : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003904")]
		public HudApparitionPhases phase;

		[Cpp2IlInjected.Token(Token = "0x6003CBC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract Task Introduce();

		[Cpp2IlInjected.Token(Token = "0x6003CBD")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected Introducable()
		{
		}
	}
}
