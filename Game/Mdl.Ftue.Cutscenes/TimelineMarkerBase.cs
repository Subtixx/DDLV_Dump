using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005CF")]
	public class TimelineMarkerBase : Marker, INotification, INotificationOptionProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40023AF")]
		[SerializeField]
		public bool triggerInEditor = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40023B0")]
		[SerializeField]
		public bool emitOnce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x40023B1")]
		[SerializeField]
		public bool retroactive = true;

		[Cpp2IlInjected.Token(Token = "0x170003BA")]
		public PropertyName id
		{
			[Cpp2IlInjected.Token(Token = "0x60019E3")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003BB")]
		NotificationFlags INotificationOptionProvider.flags
		{
			[Cpp2IlInjected.Token(Token = "0x60019E4")]
			[Cpp2IlInjected.Address(RVA = "0x13CF310", Offset = "0x13CDD10", VA = "0x1813CF310", Slot = "10")]
			get
			{
				bool flag = emitOnce;
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019E5")]
		[Cpp2IlInjected.Address(RVA = "0x13C8D70", Offset = "0x13C7770", VA = "0x1813C8D70")]
		public TimelineMarkerBase()
		{
		}
	}
}
