using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Motion;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ftue.Cutscenes.Clips
{
	[Cpp2IlInjected.Token(Token = "0x200060A")]
	public class CutsceneFade : CutsceneClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002476")]
		public Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002477")]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002478")]
		public Color startColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002479")]
		public Color endColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400247A")]
		public EasingType easingFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400247B")]
		private Tween<Color> _fadeEffect;

		[Cpp2IlInjected.Token(Token = "0x6001ABB")]
		[Cpp2IlInjected.Address(RVA = "0x1110C50", Offset = "0x110F650", VA = "0x181110C50")]
		public void Play()
		{
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABC")]
		[Cpp2IlInjected.Address(RVA = "0x1111C30", Offset = "0x1110630", VA = "0x181111C30", Slot = "4")]
		public unsafe override bool Play(float elapsed)
		{
			//IL_0026: Expected O, but got I4
			Tween<Color> fadeEffect = _fadeEffect;
			if (fadeEffect == null)
			{
				Color color = endColor;
				Color color2 = startColor;
				int num = default(int);
				Tween<Color>.InterpolationFunction interpolationFunction = (Tween<Color>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Color, Color, float, Color>*/)(&Color.Lerp));
				num = 0;
				EasingFunction easingFunction = EasingUtil.EasingFunction(this.easingFunction);
				Tween<Color> tween = (_fadeEffect = (Tween<Color>)(object)new Tween<T>(elapsed, (T)color2, (T)color, (Tween<>.InterpolationFunction)(object)interpolationFunction, easingFunction));
				Tween<Color> fadeEffect2 = _fadeEffect;
				Tween<Color>.UpdateEventHandler updateEventHandler = (Tween<Color>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateFadeEffect);
				((Tween<T>)(object)fadeEffect2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
				Tween<Color> fadeEffect3 = _fadeEffect;
			}
			int reverse = 0;
			if (((Tween<T>)(object)fadeEffect).Play(elapsed, (byte)reverse != 0))
			{
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABD")]
		[Cpp2IlInjected.Address(RVA = "0x1111E70", Offset = "0x1110870", VA = "0x181111E70", Slot = "5")]
		public override void Stop()
		{
			//IL_003d: Expected O, but got I8
			Image image = this.image;
			Color color2 = (image.color = endColor);
			Tween<Color> fadeEffect = _fadeEffect;
			if (fadeEffect != null)
			{
				Tween<Color>.UpdateEventHandler updateEventHandler = (Tween<Color>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateFadeEffect);
				((Tween<T>)(object)fadeEffect).remove_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			}
			_fadeEffect = (Tween<Color>)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void Pause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void Resume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC0")]
		[Cpp2IlInjected.Address(RVA = "0x1111F70", Offset = "0x1110970", VA = "0x181111F70")]
		private void UpdateFadeEffect(Color color, float progress)
		{
			//Discarded unreachable code: IL_0008
			Image image = this.image;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC1")]
		[Cpp2IlInjected.Address(RVA = "0x1111B80", Offset = "0x1110580", VA = "0x181111B80")]
		private void OnDestroy()
		{
			Tween<Color> fadeEffect = _fadeEffect;
			if (fadeEffect != null)
			{
				Tween<Color>.UpdateEventHandler updateEventHandler = (Tween<Color>.UpdateEventHandler)(object)new Tween<T>.UpdateEventHandler(UpdateFadeEffect);
				((Tween<T>)(object)fadeEffect).remove_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AC2")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CutsceneFade()
		{
		}
	}
}
