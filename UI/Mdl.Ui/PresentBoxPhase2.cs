using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004FB")]
	public class PresentBoxPhase2 : MonoBehaviour, IPresentBoxPhase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001AD9")]
		public float IntroTopParam1_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001ADA")]
		public float IntroTopParam1_ScaleY = 0.85f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001ADB")]
		public eEaseType IntroTopParam1_Ease = eEaseType.BACK_OUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4001ADC")]
		[Space]
		public float IntroBottomParam1_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001ADD")]
		public float IntroBottomParam1_ScaleY = 0.85f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001ADE")]
		public eEaseType IntroBottomParam1_Ease = eEaseType.BACK_OUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001ADF")]
		[Space]
		public float IntroItemsParam1_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001AE0")]
		public float IntroItemsParam1_ScaleX = 0.85f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001AE1")]
		public float IntroItemsParam1_ScaleY = 0.85f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001AE2")]
		[Space]
		public float IdleTopParam1_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001AE3")]
		public float IdleTopParam1_ScaleY = 0.95f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4001AE4")]
		[Space]
		public float IdleBottomParam1_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001AE5")]
		public float IdleBottomParam1_ScaleY = 0.95f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001AE7")]
		[SerializeField]
		[Space]
		private List<Texture2D> _textures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001AE8")]
		[SerializeField]
		private GameObject _mcTop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001AE9")]
		[SerializeField]
		private RawImage _mcTopImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001AEA")]
		[SerializeField]
		private GameObject _mcBottom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001AEB")]
		[SerializeField]
		private RawImage _mcBottomImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001AEC")]
		[SerializeField]
		private GameObject _openingVFX;

		[Cpp2IlInjected.Token(Token = "0x1700051C")]
		public PresentItems PresentItems
		{
			[Cpp2IlInjected.Token(Token = "0x6002079")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return _003CPresentItems_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600207A")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50", Slot = "5")]
			[CompilerGenerated]
			set
			{
				_003CPresentItems_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051D")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x600207B")]
			[Cpp2IlInjected.Address(RVA = "0x8CA490", Offset = "0x8C8E90", VA = "0x1808CA490", Slot = "6")]
			get
			{
				return base.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600207C")]
		[Cpp2IlInjected.Address(RVA = "0xE19700", Offset = "0xE18100", VA = "0x180E19700", Slot = "7")]
		public void RefreshData(int boxIndex)
		{
			//Discarded unreachable code: IL_002d
			List<Texture2D> textures = _textures;
			RawImage mcTopImage = _mcTopImage;
			int num = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			RawImage mcBottomImage = _mcBottomImage;
			List<Texture2D> textures2 = _textures;
			int num2 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x600207D")]
		[Cpp2IlInjected.Address(RVA = "0xE19030", Offset = "0xE17A30", VA = "0x180E19030", Slot = "8")]
		public void PlayIdle([Optional] Action onComplete)
		{
			//Discarded unreachable code: IL_0077
			//IL_0033: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			//IL_0049: Expected I4, but got F4
			//IL_0060: Expected O, but got F4
			//IL_0060: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			TweenDelegate onComplete2 = delegate
			{
				onComplete?.Invoke();
			};
			int num = 0;
			GameObject mcBottom = _mcBottom;
			float idleTopParam1_Duration = IdleTopParam1_Duration;
			var vars = (_003C_003Ef__AnonymousType22<int, bool, float>)(object)new
			{
				Repeat = (_003CRepeat_003Ej__TPar)1,
				UseYoyo = (_003CUseYoyo_003Ej__TPar)1,
				ScaleY = (_003CScaleY_003Ej__TPar)num
			};
			int num2 = 0;
			TweenMax tweenMax = TweenMax.To(mcBottom, idleTopParam1_Duration, vars, 0, num2);
			GameObject mcTop = _mcTop;
			var vars2 = (_003C_003Ef__AnonymousType23<int, bool, float, TweenDelegate>)(object)new
			{
				Repeat = (_003CRepeat_003Ej__TPar)1,
				UseYoyo = (_003CUseYoyo_003Ej__TPar)1,
				ScaleY = (_003CScaleY_003Ej__TPar)-0f,
				OnComplete = (_003COnComplete_003Ej__TPar)onComplete2
			};
			TweenMax tweenMax2 = TweenMax.To(mcTop, idleTopParam1_Duration, vars2, int.MinValue, num2);
		}

		[Cpp2IlInjected.Token(Token = "0x600207E")]
		[Cpp2IlInjected.Address(RVA = "0xE19230", Offset = "0xE17C30", VA = "0x180E19230", Slot = "9")]
		public void PlayIntro([Optional] Action onComplete)
		{
			//Discarded unreachable code: IL_014a
			//IL_001d: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			//IL_00d8: Expected O, but got I4
			//IL_00d8: Expected O, but got I4
			//IL_00ec: Expected O, but got I4
			//IL_010f: Expected O, but got I4
			//IL_010f: Expected O, but got I4
			//IL_0123: Expected O, but got I4
			//IL_0147: Expected O, but got I4
			PresentItems presentItems = PresentItems;
			int num = 0;
			if (presentItems != (UnityEngine.Object)num && !PresentItems.gameObject.activeSelf)
			{
				PresentItems.gameObject.SetActive(value: true);
				PresentItems.PlayIntro();
			}
			TweenDelegate tweenDelegate = delegate
			{
				onComplete?.Invoke();
			};
			Transform transform = PresentItems.transform;
			int num2 = 0;
			GameObject mcTop = _mcTop;
			int num3 = 0;
			Transform transform2 = mcTop.transform;
			if ((object)transform2 != null)
			{
			}
			transform2.localScale = (Vector3)num3;
			GameObject mcBottom = _mcBottom;
			int num4 = 0;
			Transform transform3 = mcBottom.transform;
			if ((object)transform3 != null)
			{
			}
			transform3.localScale = (Vector3)num4;
			int num5 = 0;
			PresentItems presentItems2 = PresentItems;
			int num6 = 0;
			GameObject target = presentItems2.gameObject;
			float introItemsParam1_Duration = IntroItemsParam1_Duration;
			var vars = (_003C_003Ef__AnonymousType24<float, float>)(object)new
			{
				ScaleX = (_003CScaleX_003Ej__TPar)num6,
				ScaleY = (_003CScaleY_003Ej__TPar)num5
			};
			TweenMax tweenMax = TweenMax.To(target, introItemsParam1_Duration, vars, int.MinValue, num2);
			GameObject mcBottom2 = _mcBottom;
			float introBottomParam1_Duration = IntroBottomParam1_Duration;
			eEaseType introTopParam1_Ease = IntroTopParam1_Ease;
			var vars2 = (_003C_003Ef__AnonymousType13<float, eEaseType>)(object)new
			{
				ScaleY = (_003CScaleY_003Ej__TPar)num6,
				Ease = (_003CEase_003Ej__TPar)introTopParam1_Ease
			};
			TweenMax tweenMax2 = TweenMax.To(mcBottom2, introBottomParam1_Duration, vars2, int.MinValue, num2);
			GameObject mcTop2 = _mcTop;
			float introTopParam1_Duration = IntroTopParam1_Duration;
			_003C_003Ef__AnonymousType25<float, eEaseType, TweenDelegate> vars3 = default(_003C_003Ef__AnonymousType25<float, eEaseType, TweenDelegate>);
			TweenMax tweenMax3 = TweenMax.To(mcTop2, introTopParam1_Duration, vars3, int.MinValue, num2);
		}

		[Cpp2IlInjected.Token(Token = "0x600207F")]
		[Cpp2IlInjected.Address(RVA = "0xE196E0", Offset = "0xE180E0", VA = "0x180E196E0", Slot = "10")]
		public void PlayOutro([Optional] Action onComplete)
		{
			onComplete?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002080")]
		[Cpp2IlInjected.Address(RVA = "0xE18EF0", Offset = "0xE178F0", VA = "0x180E18EF0", Slot = "11")]
		public void PlayFullSequence([Optional] Action onComplete)
		{
			//Discarded unreachable code: IL_005b
			Action idleEnded = delegate
			{
				//Discarded unreachable code: IL_0016
				PresentBoxPhase2 presentBoxPhase2 = this;
				Action onComplete4 = onComplete;
				presentBoxPhase2.PlayOutro(onComplete4);
			};
			Action onComplete2 = delegate
			{
				//Discarded unreachable code: IL_0016
				PresentBoxPhase2 presentBoxPhase = this;
				Action onComplete3 = idleEnded;
				presentBoxPhase.PlayIdle(onComplete3);
			};
			PlayIntro(onComplete2);
			GameObject openingVFX = _openingVFX;
			int active = 0;
			openingVFX.SetActive((byte)active != 0);
			_openingVFX.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002081")]
		[Cpp2IlInjected.Address(RVA = "0xE197D0", Offset = "0xE181D0", VA = "0x180E197D0")]
		public void ReplayOpeningVFX()
		{
			//Discarded unreachable code: IL_001d
			GameObject openingVFX = _openingVFX;
			int active = 0;
			openingVFX.SetActive((byte)active != 0);
			_openingVFX.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002082")]
		[Cpp2IlInjected.Address(RVA = "0xE19810", Offset = "0xE18210", VA = "0x180E19810")]
		public PresentBoxPhase2()
		{
		}//IL_0020: Expected I4, but got I8
		//IL_0040: Expected I4, but got I8

	}
}
