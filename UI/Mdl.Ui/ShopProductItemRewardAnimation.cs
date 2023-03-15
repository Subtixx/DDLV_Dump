using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000700")]
	public class ShopProductItemRewardAnimation : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027E6")]
		private RectTransform _mcContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40027E7")]
		private RectTransform _mcSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40027E8")]
		private RectTransform _mcTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40027E9")]
		private RectTransform _mcImageRt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40027EA")]
		private Vector2 _sourcePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40027EB")]
		private Vector2 _targetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40027EC")]
		[SerializeField]
		private AsyncImage _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40027ED")]
		[SerializeField]
		private Image _mcGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40027EE")]
		[Space]
		public float Step1Param1_Duration = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40027EF")]
		public float Step1Param1_ScaleX = 0.9f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40027F0")]
		public float Step1Param1_ScaleY = 0.9f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40027F1")]
		public eEaseType Step1Param1_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40027F2")]
		[Space]
		public float Step2Param1_Duration = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40027F3")]
		public float Step2Param1_Delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40027F4")]
		public float Step2Param1_ScaleX = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40027F5")]
		public float Step2Param1_ScaleY = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40027F6")]
		public eEaseType Step2Param1_Ease = eEaseType.BACK_OUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40027F7")]
		[Space]
		public float Step3Param1_Duration = 0.05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40027F8")]
		public float Step3Param1_Delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40027F9")]
		public float Step3Param1_ScaleX = 1.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40027FA")]
		public eEaseType Step3Param1_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40027FB")]
		public float Step3Param2_Duration = 0.05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40027FC")]
		public float Step3Param2_Delay = 0.05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40027FD")]
		public float Step3Param2_ScaleY = 1.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40027FE")]
		public eEaseType Step3Param2_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40027FF")]
		public float Step3Param3_Duration = 0.15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002800")]
		public float Step3Param3_Delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4002801")]
		public float Step3Param3_Y = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002802")]
		public eEaseType Step3Param3_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4002803")]
		public float Step3Param4_Duration = 0.15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002804")]
		public float Step3Param4_Delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4002805")]
		public float Step3Param4_AlphaStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002806")]
		public float Step3Param4_AlphaEnd = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4002807")]
		public eEaseType Step3Param4_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002808")]
		public float Step3Param5_Duration = 0.15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4002809")]
		public float Step3Param5_Delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400280A")]
		public Color Step3Param5_ColorStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400280B")]
		public Color Step3Param5_ColorEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400280C")]
		public int Step3Param5_Repeat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400280D")]
		public bool Step3Param5_UseYoyo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
		[Cpp2IlInjected.Token(Token = "0x400280E")]
		public eEaseType Step3Param5_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400280F")]
		[Space]
		public float Step4Param1_Duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4002810")]
		public float Step4Param1_Delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002811")]
		public float Step4Param1_Width;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4002812")]
		public float Step4Param1_Height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002813")]
		public eEaseType Step4Param1_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4002814")]
		public float Step4Param2_Duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4002815")]
		public float Step4Param2_Delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4002816")]
		public float Step4Param2_RotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4002817")]
		public eEaseType Step4Param2_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4002818")]
		public float Step4Param3_Duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4002819")]
		public float Step4Param3_Delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400281A")]
		public eEaseType Step4Param3_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400281B")]
		public float Step5Param1_Duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x400281C")]
		public float Step5Param1_Delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400281D")]
		public Color Step5Param1_ColorStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400281E")]
		public Color Step5Param1_ColorEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400281F")]
		public int Step5Param1_Repeat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4002820")]
		public bool Step5Param1_UseYoyo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14D")]
		[Cpp2IlInjected.Token(Token = "0x4002821")]
		public eEaseType Step1Param5_Ease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4002822")]
		private Action _callback;

		[Cpp2IlInjected.Token(Token = "0x6002C9E")]
		[Cpp2IlInjected.Address(RVA = "0x1437780", Offset = "0x1436180", VA = "0x181437780")]
		private void OnDisable()
		{
			TweenMax.KillAllByCancelationToken(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C9F")]
		[Cpp2IlInjected.Address(RVA = "0x1438A90", Offset = "0x1437490", VA = "0x181438A90")]
		public void SetData(ItemReward reward, RectTransform source, RectTransform target, RectTransform container, [Optional] Action callback)
		{
			//Discarded unreachable code: IL_004d
			//IL_0007: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			_mcContainer = (RectTransform)0;
			_mcSource = source;
			_mcTarget = target;
			_callback = (Action)0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = reward.Item;
			Transform transform = _mcImage.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			_mcImageRt = (RectTransform)num;
			AsyncImage mcImage = _mcImage;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CA0")]
		[Cpp2IlInjected.Address(RVA = "0x14388E0", Offset = "0x14372E0", VA = "0x1814388E0")]
		private unsafe void Reset()
		{
			//Discarded unreachable code: IL_0091
			//IL_0035: Expected F4, but got I4
			//IL_0030: Expected native int or pointer, but got O
			//IL_0052: Expected F4, but got I4
			//IL_004d: Expected native int or pointer, but got O
			RectTransform mcContainer = _mcContainer;
			Vector2 sourcePosition = RectTransformUtilities.SwitchToRectTransform(_mcSource, mcContainer);
			RectTransform mcContainer2 = _mcContainer;
			RectTransform mcTarget = _mcTarget;
			_sourcePosition = sourcePosition;
			((Vector2*)(IntPtr)_sourcePosition)->y = 0f;
			Vector2 vector = (_targetPosition = RectTransformUtilities.SwitchToRectTransform(mcTarget, mcContainer2));
			((Vector2*)(IntPtr)_targetPosition)->y = 0f;
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			float z = Vector3.zero.z;
			RectTransform mcSource = _mcSource;
			Transform transform2 = GetComponentInChildren<AsyncImage>().transform;
			Vector2 sizeDelta = _mcSource.sizeDelta;
		}

		[Cpp2IlInjected.Token(Token = "0x6002CA1")]
		[Cpp2IlInjected.Address(RVA = "0x1438580", Offset = "0x1436F80", VA = "0x181438580")]
		public unsafe void Play()
		{
			//Discarded unreachable code: IL_00cd
			//IL_003b: Expected F4, but got I4
			//IL_0036: Expected native int or pointer, but got O
			//IL_0058: Expected F4, but got I4
			//IL_0053: Expected native int or pointer, but got O
			TweenMax.KillAllByCancelationToken(this);
			RectTransform mcContainer = _mcContainer;
			Vector2 sourcePosition = RectTransformUtilities.SwitchToRectTransform(_mcSource, mcContainer);
			RectTransform mcContainer2 = _mcContainer;
			RectTransform mcTarget = _mcTarget;
			_sourcePosition = sourcePosition;
			((Vector2*)(IntPtr)_sourcePosition)->y = 0f;
			Vector2 vector = (_targetPosition = RectTransformUtilities.SwitchToRectTransform(mcTarget, mcContainer2));
			((Vector2*)(IntPtr)_targetPosition)->y = 0f;
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			float z = Vector3.zero.z;
			RectTransform mcSource = _mcSource;
			Transform transform2 = GetComponentInChildren<AsyncImage>().transform;
			Vector2 sizeDelta = _mcSource.sizeDelta;
			GameObject target = _mcSource.gameObject;
			float step1Param1_ScaleX = Step1Param1_ScaleX;
			TweenDelegate tweenDelegate = PlayStep2;
			_003C_003Ef__AnonymousType33<float, float, eEaseType, TweenDelegate> vars = default(_003C_003Ef__AnonymousType33<float, float, eEaseType, TweenDelegate>);
			TweenMax tweenMax = TweenMax.To(target, step1Param1_ScaleX, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CA2")]
		[Cpp2IlInjected.Address(RVA = "0x14377E0", Offset = "0x14361E0", VA = "0x1814377E0")]
		private void PlayStep1()
		{
			//Discarded unreachable code: IL_0031
			GameObject target = _mcSource.gameObject;
			float step1Param1_ScaleX = Step1Param1_ScaleX;
			TweenDelegate tweenDelegate = PlayStep2;
			_003C_003Ef__AnonymousType33<float, float, eEaseType, TweenDelegate> vars = default(_003C_003Ef__AnonymousType33<float, float, eEaseType, TweenDelegate>);
			TweenMax tweenMax = TweenMax.To(target, step1Param1_ScaleX, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CA3")]
		[Cpp2IlInjected.Address(RVA = "0x1437960", Offset = "0x1436360", VA = "0x181437960")]
		private void PlayStep2(ITween tween, object param)
		{
			//Discarded unreachable code: IL_0039
			GameObject target = _mcSource.gameObject;
			float step2Param1_Delay = Step2Param1_Delay;
			eEaseType step2Param1_Ease = Step2Param1_Ease;
			TweenDelegate tweenDelegate = PlayStep3;
			_003C_003Ef__AnonymousType34<float, float, float, eEaseType, TweenDelegate> vars = default(_003C_003Ef__AnonymousType34<float, float, float, eEaseType, TweenDelegate>);
			TweenMax tweenMax = TweenMax.To(target, step2Param1_Delay, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CA4")]
		[Cpp2IlInjected.Address(RVA = "0x1437B00", Offset = "0x1436500", VA = "0x181437B00")]
		private void PlayStep3(ITween tween, object param)
		{
			//Discarded unreachable code: IL_0107
			//IL_0026: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_0082: Expected O, but got I8
			//IL_0082: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			float z = Vector3.one.z;
			float step3Param4_AlphaStart = Step3Param4_AlphaStart;
			((RectTransform)num).SetAlpha(step3Param4_AlphaStart);
			Image mcGradient = _mcGradient;
			Color color = (mcGradient.color = Step3Param5_ColorStart);
			GameObject target = base.gameObject;
			eEaseType step3Param1_Ease = Step3Param1_Ease;
			_003C_003Ef__AnonymousType35<float, float, int, bool, eEaseType> anon = default(_003C_003Ef__AnonymousType35<float, float, int, bool, eEaseType>);
			TweenMax tweenMax = TweenMax.To(target, step3Param4_AlphaStart, anon, int.MinValue, this);
			int num2 = 0;
			GameObject target2 = base.gameObject;
			eEaseType step3Param2_Ease = Step3Param2_Ease;
			ulong num3 = default(ulong);
			var vars = (_003C_003Ef__AnonymousType36<float, float, int, bool, eEaseType>)(object)new
			{
				Delay = (_003CDelay_003Ej__TPar)num2,
				ScaleY = (_003CScaleY_003Ej__TPar)anon,
				Repeat = (_003CRepeat_003Ej__TPar)1,
				UseYoyo = (_003CUseYoyo_003Ej__TPar)num3,
				Ease = (_003CEase_003Ej__TPar)step3Param2_Ease
			};
			TweenMax tweenMax2 = TweenMax.To(target2, step3Param4_AlphaStart, vars, int.MinValue, this);
			GameObject target3 = base.gameObject;
			TweenDelegate tweenDelegate = PlayStep4;
			_003C_003Ef__AnonymousType37<float, float, eEaseType, TweenDelegate> vars2 = default(_003C_003Ef__AnonymousType37<float, float, eEaseType, TweenDelegate>);
			TweenMax tweenMax3 = TweenMax.To(target3, step3Param4_AlphaStart, vars2, int.MinValue, this);
			_003C_003Ef__AnonymousType38<float, float, eEaseType> vars3 = default(_003C_003Ef__AnonymousType38<float, float, eEaseType>);
			TweenMax tweenMax4 = TweenMax.To(base.gameObject, step3Param4_AlphaStart, vars3, int.MinValue, this);
			Image mcGradient2 = _mcGradient;
			Color step3Param5_ColorEnd = Step3Param5_ColorEnd;
			bool step3Param5_UseYoyo = Step3Param5_UseYoyo;
			eEaseType step3Param5_Ease = Step3Param5_Ease;
			_003C_003Ef__AnonymousType39<float, Color, int, bool, eEaseType> vars4 = default(_003C_003Ef__AnonymousType39<float, Color, int, bool, eEaseType>);
			TweenMax tweenMax5 = TweenMax.To(mcGradient2, step3Param4_AlphaStart, vars4, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CA5")]
		[Cpp2IlInjected.Address(RVA = "0x1437FF0", Offset = "0x14369F0", VA = "0x181437FF0")]
		private void PlayStep4(ITween tween, object param)
		{
			//Discarded unreachable code: IL_008f
			GameObject target = _mcImageRt.gameObject;
			float step4Param1_Delay = Step4Param1_Delay;
			eEaseType step4Param1_Ease = Step4Param1_Ease;
			int num = 0;
			_003C_003Ef__AnonymousType40<float, float, float, eEaseType> vars = default(_003C_003Ef__AnonymousType40<float, float, float, eEaseType>);
			TweenMax tweenMax = TweenMax.To(target, step4Param1_Delay, vars, int.MinValue, this);
			GameObject target2 = base.gameObject;
			float step4Param2_Delay = Step4Param2_Delay;
			_003C_003Ef__AnonymousType41<float, Quaternion, eEaseType> vars2 = default(_003C_003Ef__AnonymousType41<float, Quaternion, eEaseType>);
			TweenMax tweenMax2 = TweenMax.To(target2, step4Param2_Delay, vars2, int.MinValue, this);
			GameObject target3 = base.gameObject;
			Vector2 targetPosition = _targetPosition;
			float y = _targetPosition.y;
			TweenDelegate tweenDelegate = PlayStep5;
			_003C_003Ef__AnonymousType42<float, Vector3, eEaseType, TweenDelegate> vars3 = default(_003C_003Ef__AnonymousType42<float, Vector3, eEaseType, TweenDelegate>);
			TweenMax tweenMax3 = TweenMax.To(target3, step4Param2_Delay, vars3, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CA6")]
		[Cpp2IlInjected.Address(RVA = "0x1438310", Offset = "0x1436D10", VA = "0x181438310")]
		private void PlayStep5(ITween tween, object param)
		{
			//Discarded unreachable code: IL_006e
			_callback?.Invoke();
			Image mcGradient = _mcGradient;
			Color color = (mcGradient.color = Step5Param1_ColorStart);
			Image mcGradient2 = _mcGradient;
			float step5Param1_Delay = Step5Param1_Delay;
			Color step5Param1_ColorEnd = Step5Param1_ColorEnd;
			bool step5Param1_UseYoyo = Step5Param1_UseYoyo;
			eEaseType step3Param5_Ease = Step3Param5_Ease;
			TweenDelegate tweenDelegate = PlayStep6;
			_003C_003Ef__AnonymousType43<float, Color, int, bool, eEaseType, TweenDelegate> vars = default(_003C_003Ef__AnonymousType43<float, Color, int, bool, eEaseType, TweenDelegate>);
			TweenMax tweenMax = TweenMax.To(mcGradient2, step5Param1_Delay, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CA7")]
		[Cpp2IlInjected.Address(RVA = "0x1438520", Offset = "0x1436F20", VA = "0x181438520")]
		private void PlayStep6(ITween tween, object param)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CA8")]
		[Cpp2IlInjected.Address(RVA = "0x1438C50", Offset = "0x1437650", VA = "0x181438C50")]
		public ShopProductItemRewardAnimation()
		{
			//IL_004c: Expected I4, but got I8
			//IL_00d0: Expected I4, but got I8
			//IL_010d: Expected I4, but got I8
			//IL_0122: Expected I4, but got I8
			//IL_013c: Expected I4, but got I8
			Color white = Color.white;
			Step3Param5_Repeat = -1;
			Step3Param5_UseYoyo = true;
			Step4Param1_Duration = 0.5f;
			Step4Param1_Width = 80f;
			Step4Param1_Height = 80f;
			Step4Param2_Duration = 0.5f;
			Step4Param2_Ease = eEaseType.BACK_IN;
			Step4Param3_Duration = 1f;
			Step4Param3_Ease = eEaseType.BACK_IN;
			Step5Param1_Duration = 0.1f;
			Color white2 = Color.white;
			Step5Param1_Repeat = 5;
			Step5Param1_UseYoyo = true;
			base._002Ector();
		}
	}
}
