using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Playables;

namespace Mdl.Ftue.Cutscenes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20005FF")]
	public class TimelineVFXBehaviour : PlayableBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400245A")]
		public VFXAction vfxAction;

		[Cpp2IlInjected.Token(Token = "0x170003CF")]
		public GameObject TargetObject
		{
			[Cpp2IlInjected.Token(Token = "0x6001A8B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CTargetObject_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A8C")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CTargetObject_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D0")]
		public TimelineVFXTrack VFXTrack
		{
			[Cpp2IlInjected.Token(Token = "0x6001A8D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CVFXTrack_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001A8E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CVFXTrack_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A8F")]
		[Cpp2IlInjected.Address(RVA = "0x13D19B0", Offset = "0x13D03B0", VA = "0x1813D19B0", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
			switch (vfxAction)
			{
			case VFXAction.Remove:
			{
				ParticleSystem[] componentsInChildren2 = TargetObject.GetComponentsInChildren<ParticleSystem>();
				int num2 = 0;
				int length2 = componentsInChildren2.Length;
				if (num2 < length2)
				{
					ParticleSystem particleSystem2 = componentsInChildren2[num2];
					int stopBehavior = 0;
					int withChildren2 = 0;
					particleSystem2.Stop((byte)withChildren2 != 0, (ParticleSystemStopBehavior)stopBehavior);
					num2++;
				}
				GameObject gameObject = TargetObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				return;
			}
			default:
				return;
			case VFXAction.Stop:
			{
				ParticleSystem[] componentsInChildren = TargetObject.GetComponentsInChildren<ParticleSystem>();
				int num = 0;
				int length = componentsInChildren.Length;
				while (num >= length)
				{
				}
				ParticleSystem particleSystem = componentsInChildren[num];
				int withChildren = 0;
				particleSystem.Stop((byte)withChildren != 0, ParticleSystemStopBehavior.StopEmitting);
				num++;
				break;
			}
			case VFXAction.Start:
				break;
			}
			TargetObject.SetActive(value: true);
			ParticleSystem[] componentsInChildren3 = TargetObject.GetComponentsInChildren<ParticleSystem>();
			int num3 = 0;
			int length3 = componentsInChildren3.Length;
			while (num3 >= length3)
			{
			}
			ParticleSystem particleSystem3 = componentsInChildren3[num3];
			if (!particleSystem3.isPlaying)
			{
				particleSystem3.Play();
			}
			num3++;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A90")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public TimelineVFXBehaviour()
		{
		}
	}
}
