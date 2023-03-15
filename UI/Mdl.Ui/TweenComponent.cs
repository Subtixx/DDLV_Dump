using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000203")]
	public class TweenComponent : MonoBehaviour, IHasTween
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40008DC")]
		public UnityEvent[] OnCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40008DD")]
		public TweenDefinition[] TweenDefs;

		[Cpp2IlInjected.Token(Token = "0x6000CDC")]
		[Cpp2IlInjected.Address(RVA = "0x3F11990", Offset = "0x3F10390", VA = "0x183F11990", Slot = "4")]
		public void PlayTween(int index)
		{
			//Discarded unreachable code: IL_0088
			//IL_0050: Expected I4, but got I8
			TweenDefinition[] tweenDefs = TweenDefs;
			if (tweenDefs.Length > index)
			{
				TweenDefinition tweenDefinition = tweenDefs[index];
				GameObject target = tweenDefinition.Target;
				float duration = tweenDefinition.Duration;
				TweenLiteArgs args = new TweenLiteArgs(tweenDefinition, this);
				bool isBackward = tweenDefinition.IsBackward;
				GameObject target2 = tweenDefinition.Target;
				TweenLite tweenLite = default(TweenLite);
				tweenLite._tagNum = int.MinValue;
				tweenLite._target = target;
				tweenLite._args = args;
				tweenLite.Duration = duration;
				tweenLite._isBackward = isBackward;
				if ((object)target2 == null)
				{
				}
				tweenLite._cancellationToken = target2;
				tweenLite.Start();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDD")]
		[Cpp2IlInjected.Address(RVA = "0x3F11B00", Offset = "0x3F10500", VA = "0x183F11B00", Slot = "5")]
		public void PlayTweens(string indexes)
		{
			//Discarded unreachable code: IL_0034
			char[] array = indexes.ToCharArray();
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				char c = array[num];
				int index = 0;
				double numericValue = char.GetNumericValue(c);
				PlayTween(index);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDE")]
		[Cpp2IlInjected.Address(RVA = "0x3F113D0", Offset = "0x3F0FDD0", VA = "0x183F113D0", Slot = "6")]
		public void PlayTweenAll()
		{
			//Discarded unreachable code: IL_00b0
			//IL_0062: Expected I4, but got I8
			//IL_0073: Expected I4, but got I8
			TweenDefinition[] tweenDefs = TweenDefs;
			int num = 0;
			if (num >= tweenDefs.Length)
			{
				return;
			}
			if (tweenDefs.Length > num)
			{
				TweenDefinition tweenDefinition = tweenDefs[num];
				GameObject target = tweenDefinition.Target;
				float duration = tweenDefinition.Duration;
				TweenLiteArgs args = new TweenLiteArgs(tweenDefinition, this);
				bool isBackward = tweenDefinition.IsBackward;
				GameObject target2 = tweenDefinition.Target;
				TweenLite tweenLite = default(TweenLite);
				tweenLite._tagNum = int.MinValue;
				tweenLite._tagNum = int.MinValue;
				tweenLite._target = target;
				tweenLite._args = args;
				tweenLite.Duration = duration;
				tweenLite._isBackward = isBackward;
				if ((object)target2 == null)
				{
				}
				tweenLite._cancellationToken = target2;
				tweenLite.Start();
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDF")]
		[Cpp2IlInjected.Address(RVA = "0x3F11580", Offset = "0x3F0FF80", VA = "0x183F11580", Slot = "7")]
		public void PlayTweenSequence(string indexes)
		{
			//Discarded unreachable code: IL_0142
			//IL_001d: Expected O, but got I4
			//IL_0032: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			//IL_005c: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			//IL_00df: Expected I4, but got I8
			char[] array = indexes.ToCharArray();
			TweenSequence tweenSequence = default(TweenSequence);
			List<ITween> list = (tweenSequence._tweens = (List<ITween>)(object)new List<T>());
			int num = 0;
			tweenSequence.OnComplete = (TweenDelegate)num;
			tweenSequence.Repeat = num;
			tweenSequence._useYoyo = (byte)num != 0;
			tweenSequence.OnCompleteParam = num;
			tweenSequence.OnStart = (TweenDelegate)num;
			tweenSequence.OnStartParam = num;
			tweenSequence.OnUpdate = (TweenDelegate)num;
			tweenSequence.OnUpdateParam = num;
			tweenSequence.OnRepeat = (TweenDelegate)num;
			tweenSequence.OnRepeatParam = num;
			tweenSequence.CancellationToken = num;
			int length = array.Length;
			if (num < length)
			{
				char c = array[num];
				double numericValue = char.GetNumericValue(c);
				TweenDefinition tweenDefinition = TweenDefs[(uint)c];
				GameObject target = tweenDefinition.Target;
				float duration = tweenDefinition.Duration;
				TweenLiteArgs args = new TweenLiteArgs(tweenDefinition, this);
				TweenDefinition tweenDefinition2 = TweenDefs[(uint)c];
				bool isBackward = tweenDefinition2.IsBackward;
				GameObject target2 = tweenDefinition2.Target;
				ulong num2 = default(ulong);
				TweenLite tween = new TweenLite(target, duration, args, isBackward, (int)num2, target2);
				tweenSequence.Add(tween);
				num++;
			}
			if (!tweenSequence._isStarted)
			{
				List<ITween> tweens = tweenSequence._tweens;
				int num3 = 0;
				tweenSequence._isStarted = true;
				tweenSequence.RepeatCount = num3;
				tweenSequence._currentIndex = num3;
				tweenSequence.IsInPeace = (byte)num3 != 0;
				tweenSequence._isUpdateFrame = false;
				tweenSequence._isCompleted = false;
				TweenMax.Add(tweenSequence);
				ITween tween2 = Enumerable.First<ITween>((IEnumerable<>)tweenSequence._tweens);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE0")]
		[Cpp2IlInjected.Address(RVA = "0x3F11380", Offset = "0x3F0FD80", VA = "0x183F11380", Slot = "8")]
		public void OnComplete(int index)
		{
			//Discarded unreachable code: IL_0024
			UnityEvent[] onCompleted = OnCompleted;
			if (onCompleted.Length > index)
			{
				onCompleted[index]?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE1")]
		[Cpp2IlInjected.Address(RVA = "0x3F11210", Offset = "0x3F0FC10", VA = "0x183F11210", Slot = "9")]
		public void Kill(int index)
		{
			//Discarded unreachable code: IL_0022
			TweenDefinition[] tweenDefs = TweenDefs;
			if (tweenDefs.Length > index)
			{
				TweenMax.KillAllByCancelationToken(tweenDefs[index].Target);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE2")]
		[Cpp2IlInjected.Address(RVA = "0x3F112B0", Offset = "0x3F0FCB0", VA = "0x183F112B0")]
		public void Kill(string indexes)
		{
			//Discarded unreachable code: IL_0034
			char[] array = indexes.ToCharArray();
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				char c = array[num];
				int index = 0;
				double numericValue = char.GetNumericValue(c);
				Kill(index);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE3")]
		[Cpp2IlInjected.Address(RVA = "0x3F11140", Offset = "0x3F0FB40", VA = "0x183F11140")]
		public void KillAll()
		{
			//Discarded unreachable code: IL_003f
			TweenDefinition[] tweenDefs = TweenDefs;
			int num = 0;
			if (num < tweenDefs.Length)
			{
				TweenDefinition[] tweenDefs2 = TweenDefs;
				if (tweenDefs2.Length > num)
				{
					TweenMax.KillAllByCancelationToken(tweenDefs2[num].Target);
				}
				TweenDefinition[] tweenDefs3 = TweenDefs;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE4")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TweenComponent()
		{
		}
	}
}
