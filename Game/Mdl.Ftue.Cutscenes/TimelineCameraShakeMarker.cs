using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Timeline;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005CE")]
	public class TimelineCameraShakeMarker : TimelineMarkerBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40023A9")]
		[Space]
		[SerializeField]
		private AnimationCurve traumaCurve = new AnimationCurve();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40023AA")]
		[SerializeField]
		private Vector3 maxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40023AB")]
		[SerializeField]
		private Vector3 maxTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40023AC")]
		[SerializeField]
		private float traumaReduction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40023AD")]
		[SerializeField]
		private float timeMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40023AE")]
		[SerializeField]
		private float trauma;

		[Cpp2IlInjected.Token(Token = "0x170003B4")]
		public float Trauma
		{
			[Cpp2IlInjected.Token(Token = "0x60019DC")]
			[Cpp2IlInjected.Address(RVA = "0xF0A6E0", Offset = "0xF090E0", VA = "0x180F0A6E0")]
			get
			{
				return trauma;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B5")]
		public AnimationCurve TraumaCurve
		{
			[Cpp2IlInjected.Token(Token = "0x60019DD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return traumaCurve;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B6")]
		public Vector3 MaxAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60019DE")]
			[Cpp2IlInjected.Address(RVA = "0x13C8F80", Offset = "0x13C7980", VA = "0x1813C8F80")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B7")]
		public Vector3 MaxTranslation
		{
			[Cpp2IlInjected.Token(Token = "0x60019DF")]
			[Cpp2IlInjected.Address(RVA = "0x13C8FA0", Offset = "0x13C79A0", VA = "0x1813C8FA0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B8")]
		public float TraumaReduction
		{
			[Cpp2IlInjected.Token(Token = "0x60019E0")]
			[Cpp2IlInjected.Address(RVA = "0xCBE930", Offset = "0xCBD330", VA = "0x180CBE930")]
			get
			{
				return traumaReduction;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B9")]
		public float TimeMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60019E1")]
			[Cpp2IlInjected.Address(RVA = "0xE3A5D0", Offset = "0xE38FD0", VA = "0x180E3A5D0")]
			get
			{
				return timeMultiplier;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019E2")]
		[Cpp2IlInjected.Address(RVA = "0x13C8EC0", Offset = "0x13C78C0", VA = "0x1813C8EC0")]
		public unsafe TimelineCameraShakeMarker()
		{
			//IL_0019: Expected F4, but got I8
			//IL_0014: Expected native int or pointer, but got O
			//IL_0025: Expected F4, but got I8
			//IL_0020: Expected native int or pointer, but got O
			ulong num = default(ulong);
			((Vector3*)(IntPtr)maxAngle)->z = (long)num;
			ulong num2 = default(ulong);
			((Vector3*)(IntPtr)maxTranslation)->z = (long)num2;
			traumaReduction = 0.5f;
			timeMultiplier = 15f;
			trauma = 0.3f;
			triggerInEditor = true;
			retroactive = true;
			((Marker)this)._002Ector();
		}
	}
}
