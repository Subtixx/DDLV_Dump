using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Timeline;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005D0")]
	public class TimelineDOFPostProcessMarker : TimelineMarkerBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40023B2")]
		[Space]
		[SerializeField]
		private VolumeProfile _postProcessProfile;

		[Cpp2IlInjected.Token(Token = "0x170003BC")]
		public VolumeProfile PostProcessProfile
		{
			[Cpp2IlInjected.Token(Token = "0x60019E6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _postProcessProfile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019E7")]
		[Cpp2IlInjected.Address(RVA = "0x13C8D70", Offset = "0x13C7770", VA = "0x1813C8D70")]
		public TimelineDOFPostProcessMarker()
		{
			triggerInEditor = true;
			retroactive = true;
			((Marker)this)._002Ector();
		}
	}
}
