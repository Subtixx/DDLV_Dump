using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004F8")]
	public class PresentBoxPhase1 : MonoBehaviour, IPresentBoxPhase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001A90")]
		private bool _idleStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001A91")]
		public float IntroParam1_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001A92")]
		public float IntroParam1_ScaleX = 0.6f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4001A93")]
		public float IntroParam1_ScaleY = 0.6f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001A94")]
		[Space]
		public float IntroTopParam1_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001A95")]
		public float IntroTopParam1_Y = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001A96")]
		[Space]
		public float IntroParam2_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001A97")]
		public float IntroParam2_Y = -20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001A98")]
		public float IntroParam2_ScaleX = 0.85f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001A99")]
		public float IntroParam2_ScaleY = 1.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001A9A")]
		public eEaseType IntroParam2_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4001A9B")]
		[Space]
		public float IntroParam3_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001A9C")]
		public float IntroParam3_Y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4001A9D")]
		public float IntroParam3_ScaleX = 1.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001A9E")]
		public float IntroParam3_ScaleY = 0.85f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001A9F")]
		public eEaseType IntroParam3_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001AA0")]
		[Space]
		public float IntroGlowParam1_Duration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4001AA1")]
		public float IntroGlowParam1_ScaleX = 2.15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001AA2")]
		public float IntroGlowParam1_ScaleY = 2.15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4001AA3")]
		public float IntroGlowParam1_Alpha = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001AA4")]
		[Space]
		public float IntroGlowParam2_Duration = 15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4001AA5")]
		[Space]
		public float Idle1Param1_Duration = 0.35f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001AA6")]
		public float Idle1Param1_Delay = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4001AA7")]
		public float Idle1Param1_ScaleX = 1.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001AA8")]
		public float Idle1Param1_ScaleY = 0.95f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4001AA9")]
		public float Idle1Param1_Y = -10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001AAA")]
		public eEaseType Idle1Param1_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4001AAB")]
		public float Idle1TopParam1_Duration = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001AAC")]
		public float Idle1TopParam1_ScaleY = 1.03f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4001AAD")]
		public eEaseType Idle1TopParam1_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001AAE")]
		[Space]
		public float Idle1Param2_Duration = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4001AAF")]
		public float Idle1Param2_ScaleX = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001AB0")]
		public float Idle1Param2_ScaleY = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4001AB1")]
		public float Idle1Param2_Y = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001AB2")]
		public eEaseType Idle1Param2_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4001AB3")]
		public float Idle1TopParam2_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001AB4")]
		public float Idle1TopParam2_ScaleY = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4001AB5")]
		public float Idle1TopParam2_Y = 25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001AB6")]
		public eEaseType Idle1TopParam2_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4001AB7")]
		[Space]
		public float Idle1Param3_Duration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001AB8")]
		public float Idle1Param3_Y;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4001AB9")]
		public float Idle1Param3_ScaleX = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001ABA")]
		public float Idle1Param3_ScaleY = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4001ABB")]
		public eEaseType Idle1Param3_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001ABC")]
		[Space]
		public float Idle2Param1_Duration = 0.35f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4001ABD")]
		public float Idle2Param1_ScaleX = 0.99f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001ABE")]
		public float Idle2Param1_ScaleY = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4001ABF")]
		public float Idle2Param1_Alpha = 0.9f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001AC0")]
		public eEaseType Idle2Param1_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4001AC1")]
		[Space]
		public float Idle2Param2_Duration = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001AC2")]
		public float Idle2Param2_ScaleX = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4001AC3")]
		public float Idle2Param2_ScaleY = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001AC4")]
		public float Idle2Param2_Alpha = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4001AC5")]
		public eEaseType Idle2Param2_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001AC6")]
		[Space]
		public float OutroTopParam1_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4001AC7")]
		public float OutroTopParam1_Y = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001AC8")]
		public float OutroTopParam1_ScaleY = 0.85f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4001AC9")]
		[Space]
		public float OutroBottomParam1_Duration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001ACA")]
		public float OutroBottomParam1_ScaleY = 1.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001ACC")]
		[SerializeField]
		[Space]
		private List<Texture2D> _textures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001ACD")]
		[SerializeField]
		private GameObject _mcTop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001ACE")]
		[SerializeField]
		private RawImage _mcTopImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001ACF")]
		[SerializeField]
		private GameObject _mcTop2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001AD0")]
		[SerializeField]
		private RawImage _mcTopImage2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001AD1")]
		[SerializeField]
		private GameObject _mcBottom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4001AD2")]
		[SerializeField]
		private RawImage _mcBottomImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4001AD3")]
		[SerializeField]
		private GameObject _mcGlow;

		[Cpp2IlInjected.Token(Token = "0x1700051A")]
		public PresentItems PresentItems
		{
			[Cpp2IlInjected.Token(Token = "0x600205E")]
			[Cpp2IlInjected.Address(RVA = "0x738AB0", Offset = "0x7374B0", VA = "0x180738AB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return _003CPresentItems_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600205F")]
			[Cpp2IlInjected.Address(RVA = "0xE18EE0", Offset = "0xE178E0", VA = "0x180E18EE0", Slot = "5")]
			[CompilerGenerated]
			set
			{
				_003CPresentItems_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700051B")]
		public GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6002060")]
			[Cpp2IlInjected.Address(RVA = "0x8CA490", Offset = "0x8C8E90", VA = "0x1808CA490", Slot = "6")]
			get
			{
				return base.gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002061")]
		[Cpp2IlInjected.Address(RVA = "0xE18B50", Offset = "0xE17550", VA = "0x180E18B50", Slot = "7")]
		public void RefreshData(int boxIndex)
		{
			//Discarded unreachable code: IL_0045
			List<Texture2D> textures = _textures;
			RawImage mcTopImage = _mcTopImage;
			int num = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			List<Texture2D> textures2 = _textures;
			RawImage mcTopImage2 = _mcTopImage2;
			int num2 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			RawImage mcBottomImage = _mcBottomImage;
			List<Texture2D> textures3 = _textures;
			int num3 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002062")]
		[Cpp2IlInjected.Address(RVA = "0xE17A60", Offset = "0xE16460", VA = "0x180E17A60", Slot = "8")]
		public void PlayIdle([Optional] Action onComplete)
		{
			//Discarded unreachable code: IL_0137
			//IL_002e: Expected O, but got I4
			//IL_0064: Expected O, but got I4
			//IL_009a: Expected O, but got I4
			//IL_00af: Expected O, but got I4
			//IL_00c6: Expected O, but got I4
			//IL_012f: Expected O, but got I4
			//IL_012f: Expected O, but got I4
			onComplete?.Invoke();
			GameObject gameObject = base.gameObject;
			int num = 0;
			Transform transform = gameObject.transform;
			if ((object)transform != null)
			{
			}
			int num2 = 0;
			Vector2 one = Vector2.one;
			transform.localScale = (Vector3)num;
			int num3 = 0;
			Vector2 zero = Vector2.zero;
			GameObject mcTop = _mcTop;
			int num4 = 0;
			Transform transform2 = mcTop.transform;
			if ((object)transform2 != null)
			{
			}
			int num5 = 0;
			Vector2 one2 = Vector2.one;
			transform2.localScale = (Vector3)num4;
			int num6 = 0;
			Vector2 zero2 = Vector2.zero;
			GameObject mcBottom = _mcBottom;
			int num7 = 0;
			Transform transform3 = mcBottom.transform;
			if ((object)transform3 != null)
			{
			}
			int num8 = 0;
			Vector2 one3 = Vector2.one;
			transform3.localScale = (Vector3)num7;
			int num9 = 0;
			Vector2 zero3 = Vector2.zero;
			int num10 = 0;
			if (!(this == (UnityEngine.Object)num10))
			{
				GameObject gameObject2 = base.gameObject;
				int num11 = 0;
				if (!(gameObject2 == (UnityEngine.Object)num11) && base.gameObject.activeSelf)
				{
					GameObject target = base.gameObject;
					float idle1Param1_Delay = Idle1Param1_Delay;
					var vars = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
					{
						OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(PlayIdle1Step1)
					};
					GameObject cancellationToken = base.gameObject;
					TweenMax tweenMax = TweenMax.To(target, idle1Param1_Delay, vars, int.MinValue, cancellationToken);
				}
			}
			if (!_idleStarted)
			{
				int num12 = 0;
				int num13 = 0;
				PlayIdle2Step1((ITween)num13, num12);
			}
			_idleStarted = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002063")]
		[Cpp2IlInjected.Address(RVA = "0xE173D0", Offset = "0xE15DD0", VA = "0x180E173D0")]
		private void PlayIdle1()
		{
			//Discarded unreachable code: IL_006b
			//IL_0009: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			int num = 0;
			if (!(this == (UnityEngine.Object)num))
			{
				GameObject gameObject = base.gameObject;
				int num2 = 0;
				if (!(gameObject == (UnityEngine.Object)num2) && base.gameObject.activeSelf)
				{
					GameObject target = base.gameObject;
					float idle1Param1_Delay = Idle1Param1_Delay;
					var vars = (_003C_003Ef__AnonymousType7<TweenDelegate>)(object)new
					{
						OnComplete = (_003COnComplete_003Ej__TPar)new TweenDelegate(PlayIdle1Step1)
					};
					GameObject cancellationToken = base.gameObject;
					TweenMax tweenMax = TweenMax.To(target, idle1Param1_Delay, vars, int.MinValue, cancellationToken);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002064")]
		[Cpp2IlInjected.Address(RVA = "0xE16B20", Offset = "0xE15520", VA = "0x180E16B20")]
		private void PlayIdle1Step1([Optional] ITween tween, [Optional] object param)
		{
			//Discarded unreachable code: IL_00ae
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			//IL_008f: Expected O, but got I4
			//IL_008f: Expected O, but got I4
			int num = 0;
			if (!(this == (UnityEngine.Object)num))
			{
				GameObject gameObject = base.gameObject;
				int num2 = 0;
				if (!(gameObject == (UnityEngine.Object)num2) && base.gameObject.activeSelf)
				{
					GameObject target = base.gameObject;
					float idle1Param1_Y = Idle1Param1_Y;
					eEaseType idle1Param1_Ease = Idle1Param1_Ease;
					TweenDelegate tweenDelegate = PlayIdle1Step2;
					int num3 = 0;
					GameObject cancellationToken = base.gameObject;
					_003C_003Ef__AnonymousType12<float, float, float, eEaseType, TweenDelegate> vars = default(_003C_003Ef__AnonymousType12<float, float, float, eEaseType, TweenDelegate>);
					TweenMax tweenMax = TweenMax.To(target, idle1Param1_Y, vars, int.MinValue, cancellationToken);
					GameObject mcTop = _mcTop;
					eEaseType idle1TopParam1_Ease = Idle1TopParam1_Ease;
					var vars2 = (_003C_003Ef__AnonymousType13<float, eEaseType>)(object)new
					{
						ScaleY = (_003CScaleY_003Ej__TPar)num3,
						Ease = (_003CEase_003Ej__TPar)idle1TopParam1_Ease
					};
					GameObject cancellationToken2 = base.gameObject;
					TweenMax tweenMax2 = TweenMax.To(mcTop, idle1Param1_Y, vars2, int.MinValue, cancellationToken2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002065")]
		[Cpp2IlInjected.Address(RVA = "0xE16E00", Offset = "0xE15800", VA = "0x180E16E00")]
		private void PlayIdle1Step2(ITween tween, object param)
		{
			//Discarded unreachable code: IL_0084, IL_00dd
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			//IL_009e: Expected I4, but got F4
			//IL_00be: Expected O, but got I4
			//IL_00be: Expected O, but got F4
			//IL_00be: Expected O, but got I4
			//IL_00be: Expected O, but got I4
			int num = 0;
			if (!(this == (UnityEngine.Object)num))
			{
				GameObject gameObject = base.gameObject;
				int num2 = 0;
				if (!(gameObject == (UnityEngine.Object)num2) && base.gameObject.activeSelf)
				{
					GameObject target = base.gameObject;
					float idle1Param2_Y = Idle1Param2_Y;
					eEaseType idle1Param2_Ease = Idle1Param2_Ease;
					TweenDelegate tweenDelegate = PlayIdle1Step3;
					GameObject cancellationToken = base.gameObject;
					_003C_003Ef__AnonymousType12<float, float, float, eEaseType, TweenDelegate> vars = default(_003C_003Ef__AnonymousType12<float, float, float, eEaseType, TweenDelegate>);
					TweenMax tweenMax = TweenMax.To(target, idle1Param2_Y, vars, int.MinValue, cancellationToken);
					GameObject mcTop = _mcTop;
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002066")]
		[Cpp2IlInjected.Address(RVA = "0xE17170", Offset = "0xE15B70", VA = "0x180E17170")]
		private void PlayIdle1Step3(ITween tween, object param)
		{
			//Discarded unreachable code: IL_008b
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_006c: Expected O, but got F4
			//IL_006c: Expected O, but got I4
			int num = 0;
			if (this == (UnityEngine.Object)num)
			{
				return;
			}
			GameObject gameObject = base.gameObject;
			int num2 = 0;
			if (gameObject == (UnityEngine.Object)num2 || !base.gameObject.activeSelf)
			{
				return;
			}
			TweenDelegate onComplete = delegate
			{
				//Discarded unreachable code: IL_0038
				//IL_0009: Expected O, but got I4
				//IL_001c: Expected O, but got I4
				//IL_0036: Expected O, but got I4
				int num5 = 0;
				if (this != (UnityEngine.Object)num5)
				{
					GameObject gameObject2 = base.gameObject;
					int num6 = 0;
					if (gameObject2 != (UnityEngine.Object)num6 && base.gameObject.activeSelf)
					{
						int num7 = 0;
						PlayIdle((Action)num7);
					}
				}
			};
			int num3 = 0;
			int num4 = 0;
			GameObject target = base.gameObject;
			float idle1Param3_Y = Idle1Param3_Y;
			eEaseType idle1Param3_Ease = Idle1Param3_Ease;
			var vars = (_003C_003Ef__AnonymousType12<float, float, float, eEaseType, TweenDelegate>)(object)new
			{
				Y = (_003CY_003Ej__TPar)num4,
				ScaleX = (_003CScaleX_003Ej__TPar)0f,
				ScaleY = (_003CScaleY_003Ej__TPar)num3,
				Ease = (_003CEase_003Ej__TPar)idle1Param3_Ease,
				OnComplete = (_003COnComplete_003Ej__TPar)onComplete
			};
			GameObject cancellationToken = base.gameObject;
			TweenMax tweenMax = TweenMax.To(target, idle1Param3_Y, vars, int.MinValue, cancellationToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6002067")]
		[Cpp2IlInjected.Address(RVA = "0xE17A50", Offset = "0xE16450", VA = "0x180E17A50")]
		private void PlayIdle2()
		{
			//IL_000c: Expected O, but got I4
			//IL_000c: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			PlayIdle2Step1((ITween)num2, num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002068")]
		[Cpp2IlInjected.Address(RVA = "0xE175B0", Offset = "0xE15FB0", VA = "0x180E175B0")]
		private void PlayIdle2Step1([Optional] ITween tween, [Optional] object param)
		{
			//Discarded unreachable code: IL_006e
			//IL_0009: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			int num = 0;
			if (!(this == (UnityEngine.Object)num))
			{
				GameObject gameObject = base.gameObject;
				int num2 = 0;
				if (!(gameObject == (UnityEngine.Object)num2) && base.gameObject.activeSelf)
				{
					GameObject mcTop = _mcTop2;
					float idle2Param1_ScaleX = Idle2Param1_ScaleX;
					eEaseType idle2Param1_Ease = Idle2Param1_Ease;
					TweenDelegate tweenDelegate = PlayIdle2Step2;
					GameObject cancellationToken = base.gameObject;
					_003C_003Ef__AnonymousType16<float, float, float, eEaseType, TweenDelegate> vars = default(_003C_003Ef__AnonymousType16<float, float, float, eEaseType, TweenDelegate>);
					TweenMax tweenMax = TweenMax.To(mcTop, idle2Param1_ScaleX, vars, int.MinValue, cancellationToken);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002069")]
		[Cpp2IlInjected.Address(RVA = "0xE17800", Offset = "0xE16200", VA = "0x180E17800")]
		private void PlayIdle2Step2([Optional] ITween tween, [Optional] object param)
		{
			//Discarded unreachable code: IL_006e
			//IL_0009: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			int num = 0;
			if (!(this == (UnityEngine.Object)num))
			{
				GameObject gameObject = base.gameObject;
				int num2 = 0;
				if (!(gameObject == (UnityEngine.Object)num2) && base.gameObject.activeSelf)
				{
					GameObject mcTop = _mcTop2;
					float idle2Param2_ScaleX = Idle2Param2_ScaleX;
					eEaseType idle2Param2_Ease = Idle2Param2_Ease;
					TweenDelegate tweenDelegate = PlayIdle2Step1;
					GameObject cancellationToken = base.gameObject;
					_003C_003Ef__AnonymousType16<float, float, float, eEaseType, TweenDelegate> vars = default(_003C_003Ef__AnonymousType16<float, float, float, eEaseType, TweenDelegate>);
					TweenMax tweenMax = TweenMax.To(mcTop, idle2Param2_ScaleX, vars, int.MinValue, cancellationToken);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600206A")]
		[Cpp2IlInjected.Address(RVA = "0xE18560", Offset = "0xE16F60", VA = "0x180E18560", Slot = "9")]
		public void PlayIntro([Optional] Action onComplete)
		{
			//Discarded unreachable code: IL_008c
			//IL_0010: Expected O, but got I4
			PresentItems presentItems = PresentItems;
			int num = 0;
			if (presentItems != (UnityEngine.Object)num)
			{
				GameObject gameObject = PresentItems.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			if ((object)base.gameObject.transform != null)
			{
			}
			if ((object)_mcTop.transform != null)
			{
			}
			if ((object)_mcBottom.transform != null)
			{
			}
			GameObject target = base.gameObject;
			float introParam1_Duration = IntroParam1_Duration;
			float introParam1_ScaleY = IntroParam1_ScaleY;
			TweenDelegate tweenDelegate = PlayIntroStep1;
			_003C_003Ef__AnonymousType17<float, float, float, float, TweenDelegate, Action> vars = default(_003C_003Ef__AnonymousType17<float, float, float, float, TweenDelegate, Action>);
			TweenMax tweenMax = TweenMax.To(target, introParam1_Duration, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x600206B")]
		[Cpp2IlInjected.Address(RVA = "0xE17E40", Offset = "0xE16840", VA = "0x180E17E40")]
		private void PlayIntroStep1(ITween tween, object param)
		{
			//Discarded unreachable code: IL_0065
			//IL_0009: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			int num = 0;
			if (!(this == (UnityEngine.Object)num))
			{
				GameObject gameObject = base.gameObject;
				int num2 = 0;
				if (!(gameObject == (UnityEngine.Object)num2) && base.gameObject.activeSelf)
				{
					GameObject target = base.gameObject;
					float introParam2_Y = IntroParam2_Y;
					eEaseType introParam2_Ease = IntroParam2_Ease;
					TweenDelegate tweenDelegate = PlayIntroStep2;
					_003C_003Ef__AnonymousType18<float, float, float, eEaseType, TweenDelegate, object> vars = default(_003C_003Ef__AnonymousType18<float, float, float, eEaseType, TweenDelegate, object>);
					TweenMax tweenMax = TweenMax.To(target, introParam2_Y, vars, int.MinValue, this);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600206C")]
		[Cpp2IlInjected.Address(RVA = "0xE18090", Offset = "0xE16A90", VA = "0x180E18090")]
		private void PlayIntroStep2(ITween tween, object param)
		{
			//Discarded unreachable code: IL_0065
			//IL_0009: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			int num = 0;
			if (!(this == (UnityEngine.Object)num))
			{
				GameObject gameObject = base.gameObject;
				int num2 = 0;
				if (!(gameObject == (UnityEngine.Object)num2) && base.gameObject.activeSelf)
				{
					GameObject target = base.gameObject;
					float introParam3_Y = IntroParam3_Y;
					eEaseType introParam2_Ease = IntroParam2_Ease;
					TweenDelegate tweenDelegate = PlayIntroStep3;
					_003C_003Ef__AnonymousType18<float, float, float, eEaseType, TweenDelegate, object> vars = default(_003C_003Ef__AnonymousType18<float, float, float, eEaseType, TweenDelegate, object>);
					TweenMax tweenMax = TweenMax.To(target, introParam3_Y, vars, int.MinValue, this);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600206D")]
		[Cpp2IlInjected.Address(RVA = "0xE182E0", Offset = "0xE16CE0", VA = "0x180E182E0")]
		private void PlayIntroStep3(ITween tween, object param)
		{
			//Discarded unreachable code: IL_0090
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			int num = 0;
			if (this == (UnityEngine.Object)num)
			{
				return;
			}
			GameObject gameObject = base.gameObject;
			int num2 = 0;
			if (!(gameObject == (UnityEngine.Object)num2))
			{
				GameObject gameObject2 = base.gameObject;
				int num3 = 0;
				if (gameObject2.activeSelf)
				{
					GameObject mcTop = _mcTop;
					float introTopParam1_Y = IntroTopParam1_Y;
					var vars = (_003C_003Ef__AnonymousType19<float, int, bool>)(object)new
					{
						Y = (_003CY_003Ej__TPar)num3,
						Repeat = (_003CRepeat_003Ej__TPar)1,
						UseYoyo = (_003CUseYoyo_003Ej__TPar)1
					};
					TweenMax tweenMax = TweenMax.To(mcTop, introTopParam1_Y, vars, int.MinValue, this);
					GameObject target = base.gameObject;
					TweenDelegate tweenDelegate = FinishIntro;
					_003C_003Ef__AnonymousType20<int, float, float, TweenDelegate, object> vars2 = default(_003C_003Ef__AnonymousType20<int, float, float, TweenDelegate, object>);
					TweenMax tweenMax2 = TweenMax.To(target, 0.1f, vars2, int.MinValue, this);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600206E")]
		[Cpp2IlInjected.Address(RVA = "0xE16950", Offset = "0xE15350", VA = "0x180E16950")]
		private void FinishIntro(ITween tween, object param)
		{
			if (param != null && param == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600206F")]
		[Cpp2IlInjected.Address(RVA = "0xE18910", Offset = "0xE17310", VA = "0x180E18910", Slot = "10")]
		public void PlayOutro([Optional] Action onComplete)
		{
			//Discarded unreachable code: IL_0035, IL_0073
			TweenDelegate tweenDelegate = delegate
			{
				//Discarded unreachable code: IL_0023
				TweenMax.KillAllByCancelationToken(base.gameObject);
				onComplete?.Invoke();
			};
			GameObject mcBottom = _mcBottom;
			float outroBottomParam1_ScaleY = OutroBottomParam1_ScaleY;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002070")]
		[Cpp2IlInjected.Address(RVA = "0xE16A10", Offset = "0xE15410", VA = "0x180E16A10", Slot = "11")]
		public void PlayFullSequence([Optional] Action onComplete)
		{
			//Discarded unreachable code: IL_003d
			Action IdleEnded = delegate
			{
				//Discarded unreachable code: IL_0016
				PresentBoxPhase1 presentBoxPhase2 = this;
				Action onComplete4 = onComplete;
				presentBoxPhase2.PlayOutro(onComplete4);
			};
			Action onComplete2 = delegate
			{
				//Discarded unreachable code: IL_0016
				PresentBoxPhase1 presentBoxPhase = this;
				Action onComplete3 = IdleEnded;
				presentBoxPhase.PlayIdle(onComplete3);
			};
			PlayIntro(onComplete2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002071")]
		[Cpp2IlInjected.Address(RVA = "0xE169B0", Offset = "0xE153B0", VA = "0x180E169B0")]
		private void OnDestroy()
		{
			TweenMax.KillAllByCancelationToken(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002072")]
		[Cpp2IlInjected.Address(RVA = "0xE18D40", Offset = "0xE17740", VA = "0x180E18D40")]
		public PresentBoxPhase1()
		{
		}
	}
}
