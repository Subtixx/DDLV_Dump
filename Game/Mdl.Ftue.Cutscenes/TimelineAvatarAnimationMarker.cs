using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Timeline;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005CD")]
	public class TimelineAvatarAnimationMarker : TimelineMarkerBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40023A8")]
		[SerializeField]
		private CharacterAnimation animationTrigger;

		[Cpp2IlInjected.Token(Token = "0x170003B2")]
		public CharacterAnimation AnimationTrigger
		{
			[Cpp2IlInjected.Token(Token = "0x60019D9")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get
			{
				return animationTrigger;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B3")]
		public new PropertyName id
		{
			[Cpp2IlInjected.Token(Token = "0x60019DA")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019DB")]
		[Cpp2IlInjected.Address(RVA = "0x13C8D70", Offset = "0x13C7770", VA = "0x1813C8D70")]
		public TimelineAvatarAnimationMarker()
		{
			triggerInEditor = true;
			retroactive = true;
			((Marker)this)._002Ector();
		}
	}
}
