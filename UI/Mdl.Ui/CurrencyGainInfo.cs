using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AK.Wwise;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007A2")]
	public class CurrencyGainInfo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002CC2")]
		[SerializeField]
		private RectTransform _coinContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002CC3")]
		[SerializeField]
		private RectTransform _gemContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002CC4")]
		[SerializeField]
		private CanvasGroup _coinsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002CC5")]
		[SerializeField]
		private RectTransform[] _coins;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002CC6")]
		[SerializeField]
		private ParticleSystem[] _coinsEffects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002CC7")]
		[SerializeField]
		private CanvasGroup _gemsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002CC8")]
		[SerializeField]
		private RectTransform[] _gems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002CC9")]
		[SerializeField]
		private ParticleSystem[] _gemsEffects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002CCA")]
		[SerializeField]
		private CurrencyContent _slidingPanelCurrencyContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002CCB")]
		[SerializeField]
		private Transform[] _nodePaths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002CCC")]
		[ItemID]
		[SerializeField]
		private int _currencyCoinType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4002CCD")]
		[SerializeField]
		[ItemID]
		private int _currencyGemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002CCE")]
		[SerializeField]
		private AK.Wwise.Event _sfxGainCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002CCF")]
		[SerializeField]
		private AK.Wwise.Event _sfxGainMoonStone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002CD0")]
		private Vector3[] _completePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002CD1")]
		private int _currentCurrencyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002CD2")]
		private Sequence _sequence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002CD3")]
		private CanvasGroup _currenciesGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002CD4")]
		private RectTransform[] _currencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002CD5")]
		private ParticleSystem[] _currenciesEffects;

		[Cpp2IlInjected.Token(Token = "0x170006DA")]
		internal RectTransform[] Coins
		{
			[Cpp2IlInjected.Token(Token = "0x60030CB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _coins;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030CC")]
		[Cpp2IlInjected.Address(RVA = "0x1118C70", Offset = "0x1117670", VA = "0x181118C70")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0062
			RectTransform[] coins = _coins;
			int num = 0;
			if (num < coins.Length)
			{
				RectTransform rectTransform = coins[num];
				if ((object)rectTransform != null)
				{
					int complete = 0;
					int num2 = rectTransform.DOKill((byte)complete != 0);
				}
				num++;
			}
			CanvasGroup coinsGroup = _coinsGroup;
			if ((object)coinsGroup != null)
			{
				int complete2 = 0;
				int num3 = coinsGroup.DOKill((byte)complete2 != 0);
			}
			Sequence sequence = _sequence;
			if (sequence != null)
			{
				int complete3 = 0;
				sequence.Kill((byte)complete3 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030CD")]
		[Cpp2IlInjected.Address(RVA = "0x1118820", Offset = "0x1117220", VA = "0x181118820")]
		public void Init(CurrencyGainCurrencyType currencyType, CurrencyGainAnimationType animationType, Action<object> callback, [System.Runtime.InteropServices.Optional] Action<object> onStart, [System.Runtime.InteropServices.Optional] RectTransform lastPos, int amount = -1, [System.Runtime.InteropServices.Optional] CurrencyContent slidingPanelCurrencyContent)
		{
			//IL_0074: Expected F4, but got I4
			//IL_0088: Expected F4, but got I4
			//IL_00d4: Expected O, but got I4
			//IL_00e3: Expected O, but got I4
			//IL_01b6: Expected O, but got I4
			//IL_01c6: Expected O, but got I4
			//IL_01ce: Expected O, but got I4
			Vector3[] array = (_completePath = new Vector3[_nodePaths.Length]);
			Transform[] nodePaths = _nodePaths;
			int num = 0;
			int num2 = 0;
			if (num < nodePaths.Length)
			{
				Vector3[] completePath = _completePath;
				Transform transform = nodePaths[num2];
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform[] nodePaths2 = _nodePaths;
				num2++;
				num = num2;
			}
			CanvasGroup coinsGroup = _coinsGroup;
			int num3 = 0;
			coinsGroup.alpha = num3;
			CanvasGroup gemsGroup = _gemsGroup;
			int num4 = 0;
			gemsGroup.alpha = num4;
			GameObject gameObject = _coinContainer.gameObject;
			bool active = currencyType == CurrencyGainCurrencyType.SoftCurrency;
			gameObject.SetActive(active);
			GameObject gameObject2 = _gemContainer.gameObject;
			bool active2 = currencyType == CurrencyGainCurrencyType.HardCurrency;
			gameObject2.SetActive(active2);
			CurrencyContent slidingPanelCurrencyContent2 = _slidingPanelCurrencyContent;
			int num5 = 0;
			bool flag = default(bool);
			if (slidingPanelCurrencyContent2 == (UnityEngine.Object)num5 && flag)
			{
				_slidingPanelCurrencyContent = (CurrencyContent)0;
			}
			if (currencyType == CurrencyGainCurrencyType.SoftCurrency)
			{
				RectTransform[] array2 = (_currencies = _coins);
				CanvasGroup canvasGroup = (_currenciesGroup = _coinsGroup);
				ParticleSystem[] array3 = (_currenciesEffects = _coinsEffects);
				int[] currencyItems = _slidingPanelCurrencyContent.CurrencyItems;
				int num6 = (currencyItems[0] = _currencyCoinType);
			}
			if (currencyType == CurrencyGainCurrencyType.HardCurrency)
			{
				RectTransform[] array4 = (_currencies = _gems);
				CanvasGroup canvasGroup2 = (_currenciesGroup = _gemsGroup);
				ParticleSystem[] array5 = (_currenciesEffects = _gemsEffects);
				int[] currencyItems2 = _slidingPanelCurrencyContent.CurrencyItems;
				int num7 = (currencyItems2[0] = _currencyGemType);
				int num8 = (_currentCurrencyType = _currencyGemType);
			}
			if (animationType == CurrencyGainAnimationType.StoreAnimation)
			{
				return;
			}
			while (animationType != CurrencyGainAnimationType.PickupAnimation)
			{
			}
			int _003C_003E1__state = default(int);
			_003CPlayPickUpAnimation_003Ed__27 _003CPlayPickUpAnimation_003Ed__ = new _003CPlayPickUpAnimation_003Ed__27(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPlayPickUpAnimation_003Ed__._003C_003E4__this = (CurrencyGainInfo)0;
			_003CPlayPickUpAnimation_003Ed__.callback = callback;
			_003CPlayPickUpAnimation_003Ed__.onStart = (Action<object>)0;
			_003CPlayPickUpAnimation_003Ed__.lastPos = (RectTransform)0;
			_003CPlayPickUpAnimation_003Ed__.amount = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030CE")]
		[Cpp2IlInjected.Address(RVA = "0x1118E60", Offset = "0x1117860", VA = "0x181118E60")]
		private void PlayStoreAnimation(Action<object> callback, Action<object> onStart, [System.Runtime.InteropServices.Optional] RectTransform lastCurrencyPos)
		{
			//IL_0038: Expected O, but got I4
			//IL_009c: Expected O, but got I4
			//IL_01b7: Expected O, but got F4
			//IL_0233: Expected O, but got F4
			//IL_02ac: Expected O, but got F4
			//IL_034d: Expected O, but got F4
			//IL_03c6: Expected O, but got F4
			//IL_043f: Expected O, but got F4
			//IL_04b8: Expected O, but got F4
			//IL_04de: Expected O, but got F4
			//IL_0504: Expected O, but got F4
			//IL_0554: Expected O, but got F4
			//IL_057a: Expected O, but got F4
			//IL_05a0: Expected O, but got F4
			//IL_05f0: Expected O, but got F4
			//IL_0616: Expected O, but got F4
			//IL_063c: Expected O, but got F4
			//IL_06ae: Expected F4, but got I4
			Sequence sequence = _sequence;
			if (sequence != null)
			{
				int complete = 0;
				sequence.Kill((byte)complete != 0);
			}
			int num = 0;
			bool flag = lastCurrencyPos != (UnityEngine.Object)num;
			int num2 = 0;
			if (flag)
			{
				RectTransform rectTransform = _currencies[3];
				Vector3 position = lastCurrencyPos.position;
				Vector3 position2 = lastCurrencyPos.position;
				RectTransform rectTransform2 = _currencies[3];
				Vector2 pivot = lastCurrencyPos.pivot;
				RectTransform rectTransform3 = _currencies[3];
				int num3 = 0;
				Vector2 pivot2 = rectTransform3.pivot;
				rectTransform2.pivot = (Vector2)num3;
				Transform transform = _currenciesEffects[3].transform;
				Transform transform2 = _currenciesEffects[3].transform;
				Transform transform3 = _currenciesEffects[3].transform;
				if ((object)transform3 != null && (object)transform3 != null)
				{
					Vector2 pivot3 = lastCurrencyPos.pivot;
					int num4 = 0;
				}
				Transform transform4 = _nodePaths[6];
				Vector3 position3 = transform3.position;
				Vector3 position4 = transform3.position;
				Transform transform5 = _nodePaths[6];
				if ((object)transform5 != null && (object)transform5 != null)
				{
					Vector2 pivot4 = lastCurrencyPos.pivot;
					int num5 = 0;
				}
			}
			int num6 = 0;
			Sequence t = DOTween.Sequence();
			TweenCallback tweenCallback = delegate
			{
				//Discarded unreachable code: IL_0032
				//IL_0030: Expected O, but got I4
				Transform transform21 = _currencies[0].transform;
				Action<object> action = onStart;
				if (action != null)
				{
					int num9 = 0;
					action((T)num9);
				}
			};
			Sequence s = t.OnStart(tweenCallback);
			TweenerCore<float, float, FloatOptions> t2 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_currenciesGroup, 1f, 1f);
			Sequence s2 = s.Append(t2);
			Transform parent = _currencies[0].parent;
			Vector3[] array = new Vector3[1];
			Transform[] nodePaths = _nodePaths;
			Transform transform6 = nodePaths[0];
			float z = ((Transform)(object)nodePaths).position.z;
			array[1] = (Vector3)z;
			int num7 = 0;
			TweenerCore<Vector3, Path, PathOptions> t3 = default(TweenerCore<Vector3, Path, PathOptions>);
			Sequence s3 = s2.Join(t3).SetEase(Ease.OutQuint);
			RectTransform rectTransform4 = _currencies[0];
			TweenerCore<Vector3, Vector3, VectorOptions> t4 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Sequence s4 = s3.Join(t4).SetEase(Ease.OutQuint);
			Transform parent2 = _currencies[1].parent;
			Vector3[] array2 = new Vector3[1];
			Transform[] nodePaths2 = _nodePaths;
			Transform transform7 = nodePaths2[1];
			float z2 = ((Transform)(object)nodePaths2).position.z;
			array2[1] = (Vector3)z2;
			TweenerCore<Vector3, Path, PathOptions> t5 = default(TweenerCore<Vector3, Path, PathOptions>);
			Sequence s5 = s4.Join(t5).SetEase(Ease.OutQuint);
			RectTransform rectTransform5 = _currencies[1];
			TweenerCore<Vector3, Vector3, VectorOptions> t6 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Sequence s6 = s5.Join(t6).SetEase(Ease.OutQuint);
			Transform parent3 = _currencies[2].parent;
			Vector3[] array3 = new Vector3[1];
			Transform[] nodePaths3 = _nodePaths;
			Transform transform8 = nodePaths3[2];
			float z3 = ((Transform)(object)nodePaths3).position.z;
			array3[1] = (Vector3)z3;
			TweenerCore<Vector3, Path, PathOptions> t7 = default(TweenerCore<Vector3, Path, PathOptions>);
			Sequence s7 = s6.Join(t7).SetEase(Ease.OutQuint);
			RectTransform rectTransform6 = _currencies[2];
			TweenerCore<Vector3, Vector3, VectorOptions> t8 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Sequence s8 = s7.Join(t8).SetEase(Ease.OutQuint);
			TweenCallback callback2 = delegate
			{
				//Discarded unreachable code: IL_0043
				_currenciesEffects[0].Play();
				_currenciesEffects[1].Play();
				_currenciesEffects[2].Play();
			};
			Sequence s9 = s8.InsertCallback(0.2f, callback2).AppendInterval(0.4f);
			Transform parent4 = _currencies[0].parent;
			Vector3[] array4 = new Vector3[1];
			Transform[] nodePaths4 = _nodePaths;
			Transform transform9 = nodePaths4[3];
			float z4 = ((Transform)(object)nodePaths4).position.z;
			array4[1] = (Vector3)z4;
			TweenerCore<Vector3, Path, PathOptions> t9 = default(TweenerCore<Vector3, Path, PathOptions>);
			Sequence s10 = s9.Append(t9).SetEase(Ease.OutQuint);
			RectTransform rectTransform7 = _currencies[0];
			TweenerCore<Vector3, Vector3, VectorOptions> t10 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Sequence s11 = s10.Join(t10).SetEase(Ease.OutQuint);
			Transform parent5 = _currencies[1].parent;
			Vector3[] array5 = new Vector3[1];
			Transform[] nodePaths5 = _nodePaths;
			Transform transform10 = nodePaths5[3];
			float z5 = ((Transform)(object)nodePaths5).position.z;
			array5[1] = (Vector3)z5;
			TweenerCore<Vector3, Path, PathOptions> t11 = default(TweenerCore<Vector3, Path, PathOptions>);
			Sequence s12 = s11.Join(t11).SetEase(Ease.OutQuint);
			RectTransform rectTransform8 = _currencies[1];
			TweenerCore<Vector3, Vector3, VectorOptions> t12 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Sequence s13 = s12.Join(t12).SetEase(Ease.OutQuint);
			Transform parent6 = _currencies[2].parent;
			Vector3[] array6 = new Vector3[1];
			Transform[] nodePaths6 = _nodePaths;
			Transform transform11 = nodePaths6[3];
			float z6 = ((Transform)(object)nodePaths6).position.z;
			array6[1] = (Vector3)z6;
			TweenerCore<Vector3, Path, PathOptions> t13 = default(TweenerCore<Vector3, Path, PathOptions>);
			Sequence s14 = s13.Join(t13).SetEase(Ease.OutQuint);
			RectTransform rectTransform9 = _currencies[2];
			TweenerCore<Vector3, Vector3, VectorOptions> t14 = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			Sequence s15 = s14.Join(t14).SetEase(Ease.OutQuint);
			Transform parent7 = _currencies[0].parent;
			Vector3[] array7 = new Vector3[3];
			Transform[] nodePaths7 = _nodePaths;
			Transform transform12 = nodePaths7[6];
			float z7 = ((Transform)(object)nodePaths7).position.z;
			array7[1] = (Vector3)z7;
			Transform transform13 = _nodePaths[4];
			float z8 = ((Transform)(object)nodePaths7).position.z;
			array7[2] = (Vector3)z8;
			Transform transform14 = _nodePaths[5];
			float z9 = ((Transform)(object)nodePaths7).position.z;
			array7[4] = (Vector3)z9;
			TweenerCore<Vector3, Path, PathOptions> t15 = default(TweenerCore<Vector3, Path, PathOptions>);
			Sequence s16 = s15.Append(t15);
			Transform parent8 = _currencies[1].parent;
			Vector3[] array8 = new Vector3[3];
			Transform[] nodePaths8 = _nodePaths;
			Transform transform15 = nodePaths8[6];
			float z10 = ((Transform)(object)nodePaths8).position.z;
			array8[1] = (Vector3)z10;
			Transform transform16 = _nodePaths[4];
			float z11 = ((Transform)(object)nodePaths8).position.z;
			array8[2] = (Vector3)z11;
			Transform transform17 = _nodePaths[5];
			float z12 = ((Transform)(object)nodePaths8).position.z;
			array8[4] = (Vector3)z12;
			TweenerCore<Vector3, Path, PathOptions> t16 = default(TweenerCore<Vector3, Path, PathOptions>);
			Sequence s17 = s16.Join(t16);
			Transform parent9 = _currencies[2].parent;
			Vector3[] array9 = new Vector3[3];
			Transform[] nodePaths9 = _nodePaths;
			Transform transform18 = nodePaths9[6];
			float z13 = ((Transform)(object)nodePaths9).position.z;
			array9[1] = (Vector3)z13;
			Transform transform19 = _nodePaths[4];
			float z14 = ((Transform)(object)nodePaths9).position.z;
			array9[2] = (Vector3)z14;
			Transform transform20 = _nodePaths[5];
			float z15 = ((Transform)(object)nodePaths9).position.z;
			array9[4] = (Vector3)z15;
			TweenerCore<Vector3, Path, PathOptions> t17 = default(TweenerCore<Vector3, Path, PathOptions>);
			Sequence s18 = s17.Join(t17);
			TweenerCore<float, float, FloatOptions> t18 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_currenciesGroup, 0.2f, 0.15f);
			Sequence s19 = s18.Insert(2.7f, t18);
			TweenerCore<float, float, FloatOptions> t19 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_currenciesGroup, 0.75f, 0.15f);
			Sequence s20 = s19.Insert(3.2f, t19);
			CanvasGroup currenciesGroup = _currenciesGroup;
			int num8 = 0;
			TweenerCore<float, float, FloatOptions> t20 = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(currenciesGroup, (float)num8, 0.15f);
			Sequence s21 = s20.Insert(3.3f, t20);
			TweenCallback callback3 = delegate
			{
				//Discarded unreachable code: IL_0017
				_currenciesEffects[3].Play();
			};
			Sequence sequence2 = s21.InsertCallback(3.3f, callback3);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030CF")]
		[Cpp2IlInjected.Address(RVA = "0x1118DF0", Offset = "0x11177F0", VA = "0x181118DF0")]
		private void PlaySfxGain()
		{
			if (!_gemContainer.gameObject.activeInHierarchy)
			{
				AK.Wwise.Event sfxGainCurrency = _sfxGainCurrency;
				if (sfxGainCurrency != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = sfxGainCurrency.Post(gameObject);
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030D0")]
		[Cpp2IlInjected.Address(RVA = "0x1118150", Offset = "0x1116B50", VA = "0x181118150")]
		private void AdjustLastCurrencyPos(RectTransform lastPos)
		{
			//Discarded unreachable code: IL_0111
			//IL_0014: Expected O, but got I4
			//IL_007f: Expected O, but got I4
			if ((object)lastPos == null)
			{
				RectTransform currentCurrencyPos = GetCurrentCurrencyPos();
			}
			int num = 0;
			if (!(lastPos != (UnityEngine.Object)num))
			{
				return;
			}
			RectTransform[] currencies = _currencies;
			if (currencies.Length > 3 && _currenciesEffects.Length > 3)
			{
				RectTransform rectTransform = currencies[3];
				RectTransform rectTransform2 = _currencies[3];
				Vector2 pivot = lastPos.pivot;
				RectTransform rectTransform3 = _currencies[3];
				int num2 = 0;
				Vector2 pivot2 = rectTransform3.pivot;
				rectTransform2.pivot = (Vector2)num2;
				Transform transform = _currenciesEffects[3].transform;
				Transform transform2 = _currenciesEffects[3].transform;
				Transform transform3 = _currenciesEffects[3].transform;
				if ((object)transform3 != null && (object)transform3 != null)
				{
					Vector2 pivot3 = lastPos.pivot;
					int num3 = 0;
				}
				Transform transform4 = _nodePaths[6];
				Vector3 position = transform3.position;
				Vector3 position2 = transform3.position;
				Transform transform5 = _nodePaths[6];
				if ((object)transform5 != null && (object)transform5 != null)
				{
					Vector2 pivot4 = lastPos.pivot;
					int num4 = 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030D1")]
		[Cpp2IlInjected.Address(RVA = "0x1118D20", Offset = "0x1117720", VA = "0x181118D20")]
		[IteratorStateMachine(typeof(_003CPlayPickUpAnimation_003Ed__27))]
		private IEnumerator PlayPickUpAnimation(Action<object> callback, Action<object> onStart, int amount = -1, [System.Runtime.InteropServices.Optional] RectTransform lastPos)
		{
			//IL_0025: Expected O, but got I4
			int _003C_003E1__state = default(int);
			_003CPlayPickUpAnimation_003Ed__27 _003CPlayPickUpAnimation_003Ed__ = new _003CPlayPickUpAnimation_003Ed__27(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPlayPickUpAnimation_003Ed__._003C_003E4__this = this;
			_003CPlayPickUpAnimation_003Ed__.callback = callback;
			_003CPlayPickUpAnimation_003Ed__.onStart = onStart;
			_003CPlayPickUpAnimation_003Ed__.lastPos = (RectTransform)0;
			_003CPlayPickUpAnimation_003Ed__.amount = amount;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030D2")]
		[Cpp2IlInjected.Address(RVA = "0x1118610", Offset = "0x1117010", VA = "0x181118610")]
		private RectTransform GetCurrentCurrencyPos()
		{
			//IL_007d: Expected O, but got I4
			CurrencyContent slidingPanelCurrencyContent = _slidingPanelCurrencyContent;
			if ((object)slidingPanelCurrencyContent != null)
			{
				ListBase list_currencyItems = slidingPanelCurrencyContent.list_currencyItems;
				if ((object)list_currencyItems != null)
				{
					RectTransform content = list_currencyItems.m_Content;
					if ((object)content != null)
					{
						int childCount = content.childCount;
						int num = 0;
					}
				}
				int num2 = 0;
				if (num2 != 0)
				{
					int childCount2 = _slidingPanelCurrencyContent.list_currencyItems.m_Content.childCount;
					if (num2 < childCount2)
					{
						FreemiumCurrencyItem component = _slidingPanelCurrencyContent.list_currencyItems.m_Content.GetChild(num2).GetComponent<FreemiumCurrencyItem>();
						int num3 = 0;
						if (!(component != (UnityEngine.Object)num3) || (IntPtr)component.CurrencyItem != (IntPtr)_currentCurrencyType)
						{
							CurrencyContent slidingPanelCurrencyContent2 = _slidingPanelCurrencyContent;
							num2++;
						}
						if ((object)component.transform == null)
						{
						}
					}
				}
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030D3")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CurrencyGainInfo()
		{
		}
	}
}
