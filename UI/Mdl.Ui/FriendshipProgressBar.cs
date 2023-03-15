using System;
using System.Runtime.InteropServices;
using System.Threading;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Characters;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000213")]
	public class FriendshipProgressBar : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000924")]
		public AK.Wwise.Event _sfxEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000925")]
		private float _from;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000926")]
		private float _to;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000927")]
		private float _xpGained;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000928")]
		private int _level;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000929")]
		private float _points;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400092A")]
		[SerializeField]
		private GameObject _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400092B")]
		[SerializeField]
		private GameObject _mcTrailEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400092C")]
		[SerializeField]
		private ProgressBar mc_progressBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400092D")]
		[SerializeField]
		private GameObject _mcProgressBarFill;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400092E")]
		[SerializeField]
		private TextBase tf_level;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400092F")]
		[SerializeField]
		private TextBase tf_points;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000930")]
		[SerializeField]
		private GameObject _mcVfxGuide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000931")]
		[SerializeField]
		private GameObject _mcVfxHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000932")]
		[SerializeField]
		private GameObject _mcTail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000933")]
		[SerializeField]
		private GameObject _mcGlow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000934")]
		[SerializeField]
		private AsyncImage _mcCharacterIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000935")]
		private Mdl.Characters.Character _character;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000936")]
		private CancellationToken _cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x17000281")]
		public float Percent
		{
			[Cpp2IlInjected.Token(Token = "0x6000D14")]
			[Cpp2IlInjected.Address(RVA = "0x166DCB0", Offset = "0x166C6B0", VA = "0x18166DCB0")]
			get
			{
				ProgressBar progressBar = mc_progressBar;
				if ((object)progressBar != null)
				{
					return progressBar._fillAmount;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D15")]
			[Cpp2IlInjected.Address(RVA = "0x166DDF0", Offset = "0x166C7F0", VA = "0x18166DDF0")]
			set
			{
				//Discarded unreachable code: IL_00aa
				//IL_0010: Expected O, but got I4
				//IL_0030: Expected F4, but got I4
				//IL_008e: Expected F4, but got I4
				//IL_008e: Expected F4, but got I4
				ProgressBar progressBar = mc_progressBar;
				int num = 0;
				if (progressBar != (UnityEngine.Object)num)
				{
					ProgressBar progressBar2 = mc_progressBar;
					float num2 = Mathf.Min(1f, value);
					float num3 = Mathf.Max(0f, value);
					progressBar2.FillAmount = value;
					GameObject mcVfxGuide = _mcVfxGuide;
					float num4 = value * 360f;
					RectTransform component = mcVfxGuide.GetComponent<RectTransform>();
					float x = num3 * 95f * 98f;
					GameObject mcTail = _mcTail;
					if (!(num4 >= 40f))
					{
					}
					Transform transform = mcTail.transform;
					int num5 = 0;
					int num6 = 0;
					Quaternion quaternion = Quaternion.Euler(x, num6, num5);
					_mcTail.SetActive(value: true);
					Transform transform2 = _mcGlow.transform;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000282")]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x6000D16")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return _level;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D17")]
			[Cpp2IlInjected.Address(RVA = "0x166DCD0", Offset = "0x166C6D0", VA = "0x18166DCD0")]
			set
			{
				//Discarded unreachable code: IL_0030, IL_003e, IL_0046, IL_0047
				//IL_0017: Expected O, but got I4
				TextBase textBase = tf_level;
				_level = 0;
				int num = 0;
				if (textBase != (UnityEngine.Object)num)
				{
					GameObject gameObject = tf_level.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000283")]
		public float Points
		{
			[Cpp2IlInjected.Token(Token = "0x6000D18")]
			[Cpp2IlInjected.Address(RVA = "0x83A7F0", Offset = "0x8391F0", VA = "0x18083A7F0")]
			get
			{
				return _points;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D19")]
			[Cpp2IlInjected.Address(RVA = "0x166E050", Offset = "0x166CA50", VA = "0x18166E050")]
			set
			{
				//Discarded unreachable code: IL_002a
				int num = 0;
				_points = value;
				TextBase textBase = tf_points;
				string text = string.Format("+{0}", "+{0}");
				string text2 = default(string);
				textBase.Text = text2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void Awake()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1B")]
		[Cpp2IlInjected.Address(RVA = "0x166D250", Offset = "0x166BC50", VA = "0x18166D250")]
		private void OnDestroy()
		{
			TweenMax.KillAllByCancelationToken(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1C")]
		[Cpp2IlInjected.Address(RVA = "0x166D2B0", Offset = "0x166BCB0", VA = "0x18166D2B0")]
		private void OnDisable()
		{
			TweenMax.KillAllByCancelationToken(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1D")]
		[Cpp2IlInjected.Address(RVA = "0x166DA30", Offset = "0x166C430", VA = "0x18166DA30")]
		public void RefreshData(CancellationToken cancellationToken, Mdl.Characters.Character character, AddedFriendshipSummary summary, float from, float to, int level, int gained)
		{
			//Discarded unreachable code: IL_00c8, IL_00d7, IL_00e8
			//IL_0007: Expected F4, but got I4
			//IL_000e: Expected F4, but got I4
			//IL_001e: Expected O, but got I4
			_from = 0f;
			_to = 0f;
			TextBase textBase = tf_level;
			int num = 0;
			if (textBase != (UnityEngine.Object)num)
			{
				GameObject gameObject = tf_level.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			float num2 = (Percent = _from);
			GameObject gameObject2 = tf_points.gameObject;
			bool active2 = _level > 0;
			gameObject2.SetActive(active2);
			_cancellationToken = cancellationToken;
			_character = character;
			_mcProgressBarFill.GetComponent<RectTransform>().SetAsLastSibling();
			Mdl.Characters.Character character2 = _character;
			string iconAddress_ = character2.Data.iconAddress_;
			if ((object)character2 == null)
			{
				CharacterItemData _003CData_003Ek__BackingField = _character.Data;
				AsyncImage mcCharacterIcon = _mcCharacterIcon;
				string iconAddress_2 = _003CData_003Ek__BackingField.iconAddress_;
				mcCharacterIcon.SetSpriteKey(iconAddress_2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1E")]
		[Cpp2IlInjected.Address(RVA = "0x166D7D0", Offset = "0x166C1D0", VA = "0x18166D7D0")]
		public void PlayAnimation([Optional] Action callback, float aniDuration = 2f)
		{
			//Discarded unreachable code: IL_0042, IL_0089
			AK.Wwise.Event sfxEvent = _sfxEvent;
			GameObject gameObject = base.gameObject;
			uint num = sfxEvent.Post(gameObject);
			float to = _to;
			if (_level > 0)
			{
				float xpGained = _xpGained;
				throw new NullReferenceException();
			}
			TweenDelegate tweenDelegate = OnPercentUpdate;
			TweenDelegate tweenDelegate2 = delegate
			{
				callback?.Invoke();
			};
			to = aniDuration;
			_003C_003Ef__AnonymousType2<float, TweenDelegate, TweenDelegate> vars = default(_003C_003Ef__AnonymousType2<float, TweenDelegate, TweenDelegate>);
			TweenMax tweenMax = TweenMax.To(this, to, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1F")]
		[Cpp2IlInjected.Address(RVA = "0x166D310", Offset = "0x166BD10", VA = "0x18166D310")]
		private void OnPercentUpdate(ITween tween, object param)
		{
			//Discarded unreachable code: IL_008a
			//IL_0055: Expected I4, but got I8
			//IL_0083: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			RectTransform component = _mcVfxHolder.GetComponent<RectTransform>();
			RectTransform component2 = _mcVfxGuide.GetComponent<RectTransform>();
			GameObject gameObject = UnityEngine.Object.Instantiate(_mcTrailEmitter, component);
			RectTransform component3 = gameObject.GetComponent<RectTransform>();
			Vector2 anchoredPosition = component2.anchoredPosition;
			Vector2 anchoredPosition2 = component2.anchoredPosition;
			component3.anchoredPosition = anchoredPosition;
			ulong num3 = default(ulong);
			gameObject.SetActive((byte)num3 != 0);
			if (_003C_003Ec._003C_003E9__33_0 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(TweenDelegate)delegate
				{
					//Discarded unreachable code: IL_0011
					//IL_0010: Expected O, but got I4
					int num4 = 0;
					if ((object)typeof(UnityEngine.Object).TypeHandle != null)
					{
					}
					UnityEngine.Object.Destroy((UnityEngine.Object)num4);
				};
			}
			_003C_003Ef__AnonymousType3<bool, float, float, float, float, _003C_003Ef__AnonymousType4<float, float, float>, TweenDelegate> vars = default(_003C_003Ef__AnonymousType3<bool, float, float, float, float, _003C_003Ef__AnonymousType4<float, float, float>, TweenDelegate>);
			uint tagNum = default(uint);
			TweenMax tweenMax = TweenMax.To(gameObject, 60f, vars, (int)tagNum, num);
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D20")]
		[Cpp2IlInjected.Address(RVA = "0x166D0D0", Offset = "0x166BAD0", VA = "0x18166D0D0")]
		public void PlayFloatingAnimation()
		{
			//IL_001c: Expected O, but got I4
			GameObject mcContent = _mcContent;
			TweenDelegate onComplete = GoFloat;
			_003C_003Ef__AnonymousType6<float, float, float, float> physics2D = default(_003C_003Ef__AnonymousType6<float, float, float, float>);
			var vars = (_003C_003Ef__AnonymousType5<bool, _003C_003Ef__AnonymousType6<float, float, float, float>, TweenDelegate>)(object)new
			{
				UseFrame = (_003CUseFrame_003Ej__TPar)1,
				Physics2D = (_003CPhysics2D_003Ej__TPar)physics2D,
				OnComplete = (_003COnComplete_003Ej__TPar)onComplete
			};
			TweenMax tweenMax = TweenMax.To(mcContent, 65f, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D21")]
		[Cpp2IlInjected.Address(RVA = "0x166D0D0", Offset = "0x166BAD0", VA = "0x18166D0D0")]
		private void GoFloat(ITween tween, object param)
		{
			//IL_001c: Expected O, but got I4
			GameObject mcContent = _mcContent;
			TweenDelegate onComplete = GoFloat;
			_003C_003Ef__AnonymousType6<float, float, float, float> physics2D = default(_003C_003Ef__AnonymousType6<float, float, float, float>);
			var vars = (_003C_003Ef__AnonymousType5<bool, _003C_003Ef__AnonymousType6<float, float, float, float>, TweenDelegate>)(object)new
			{
				UseFrame = (_003CUseFrame_003Ej__TPar)1,
				Physics2D = (_003CPhysics2D_003Ej__TPar)physics2D,
				OnComplete = (_003COnComplete_003Ej__TPar)onComplete
			};
			TweenMax tweenMax = TweenMax.To(mcContent, 65f, vars, int.MinValue, this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D22")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FriendshipProgressBar()
		{
		}
	}
}
