using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Audio;
using Mdl.Ui;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005BB")]
	public class Cutscene : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20005BC")]
		public class Step
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002360")]
			public float elapsed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4002361")]
			public float delay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002362")]
			public bool isBlocking;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002363")]
			public CutsceneClip clip;

			[Cpp2IlInjected.Token(Token = "0x60019A4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Step()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20005BD")]
		public delegate void StartedPlaying(Cutscene cutscene);

		[Cpp2IlInjected.Token(Token = "0x20005BE")]
		public delegate void FinishedPlaying(Cutscene cutscene);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400234C")]
		[HideInInspector]
		public List<Step> steps = (List<Step>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400234F")]
		public string cutsceneId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002350")]
		[ItemID]
		[SerializeField]
		public int sceneId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002351")]
		public Camera camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002352")]
		public GameObject cutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002353")]
		public RectTransform inputRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002354")]
		public Bank cutsceneBank;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002355")]
		public AudioManager.GameState sceneGameState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002356")]
		public State sceneState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002357")]
		public bool recenterCameraWhenFinished = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4002358")]
		private bool doSkip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400235D")]
		private List<Step> _playing = (List<Step>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400235E")]
		private Vector3 _cameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400235F")]
		private Quaternion _cameraRotation;

		[Cpp2IlInjected.Token(Token = "0x170003A7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x62"), Cpp2IlInjected.Token(Token = "0x4002359")]
		public bool Paused
		{
			[Cpp2IlInjected.Token(Token = "0x6001990")]
			[Cpp2IlInjected.Address(RVA = "0x1114280", Offset = "0x1112C80", VA = "0x181114280")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001991")]
			[Cpp2IlInjected.Address(RVA = "0x1114410", Offset = "0x1112E10", VA = "0x181114410")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003A8")]
		public bool IsPlaying
		{
			[Cpp2IlInjected.Token(Token = "0x6001992")]
			[Cpp2IlInjected.Address(RVA = "0x1114230", Offset = "0x1112C30", VA = "0x181114230")]
			get
			{
				//Discarded unreachable code: IL_0009
				List<Step> playing = _playing;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003A9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x64"), Cpp2IlInjected.Token(Token = "0x400235A")]
		public float FadeOutDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6001993")]
			[Cpp2IlInjected.Address(RVA = "0x823E70", Offset = "0x822870", VA = "0x180823E70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001994")]
			[Cpp2IlInjected.Address(RVA = "0x824290", Offset = "0x822C90", VA = "0x180824290")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003AA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x68"), Cpp2IlInjected.Token(Token = "0x400235B")]
		public bool CanBeSkipped
		{
			[Cpp2IlInjected.Token(Token = "0x6001995")]
			[Cpp2IlInjected.Address(RVA = "0xFB01D0", Offset = "0xFAEBD0", VA = "0x180FB01D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001996")]
			[Cpp2IlInjected.Address(RVA = "0xFB0200", Offset = "0xFAEC00", VA = "0x180FB0200")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x170003AB")]
		public Func<int> SkipKeyCodeFetcher
		{
			[Cpp2IlInjected.Token(Token = "0x6001997")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			[CompilerGenerated]
			get
			{
				return _003CSkipKeyCodeFetcher_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001998")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			[CompilerGenerated]
			set
			{
				_003CSkipKeyCodeFetcher_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003A")]
		public static event StartedPlaying OnStartedPlaying
		{
			[Cpp2IlInjected.Token(Token = "0x600198C")]
			[Cpp2IlInjected.Address(RVA = "0x1114170", Offset = "0x1112B70", VA = "0x181114170")]
			[CompilerGenerated]
			add
			{
				StartedPlaying onStartedPlaying = Cutscene.OnStartedPlaying;
				Delegate @delegate = Delegate.Combine(onStartedPlaying, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(Cutscene).TypeHandle != onStartedPlaying)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600198D")]
			[Cpp2IlInjected.Address(RVA = "0x1114350", Offset = "0x1112D50", VA = "0x181114350")]
			[CompilerGenerated]
			remove
			{
				StartedPlaying onStartedPlaying = Cutscene.OnStartedPlaying;
				Delegate @delegate = Delegate.Remove(onStartedPlaying, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(Cutscene).TypeHandle != onStartedPlaying)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003B")]
		public static event FinishedPlaying OnFinishedPlaying
		{
			[Cpp2IlInjected.Token(Token = "0x600198E")]
			[Cpp2IlInjected.Address(RVA = "0x11140B0", Offset = "0x1112AB0", VA = "0x1811140B0")]
			[CompilerGenerated]
			add
			{
				FinishedPlaying onFinishedPlaying = Cutscene.OnFinishedPlaying;
				Delegate @delegate = Delegate.Combine(onFinishedPlaying, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(Cutscene).TypeHandle != onFinishedPlaying)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600198F")]
			[Cpp2IlInjected.Address(RVA = "0x1114290", Offset = "0x1112C90", VA = "0x181114290")]
			[CompilerGenerated]
			remove
			{
				FinishedPlaying onFinishedPlaying = Cutscene.OnFinishedPlaying;
				Delegate @delegate = Delegate.Remove(onFinishedPlaying, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(Cutscene).TypeHandle != onFinishedPlaying)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001999")]
		[Cpp2IlInjected.Address(RVA = "0x1113640", Offset = "0x1112040", VA = "0x181113640")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0011
			GameObject gameObject = cutscene;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600199A")]
		[Cpp2IlInjected.Address(RVA = "0x1113AE0", Offset = "0x11124E0", VA = "0x181113AE0")]
		public void Play(Camera camera, float fadeOutDuration, bool mustSkip = false)
		{
			//Discarded unreachable code: IL_0072, IL_0078, IL_007e
			//IL_0027: Expected I4, but got I8
			//IL_004f: Expected O, but got I4
			int num = 0;
			if (!mustSkip)
			{
				List<Step> playing = _playing;
				this.camera = camera;
				FadeOutDuration = fadeOutDuration;
				ulong num2 = default(ulong);
				cutscene.SetActive((byte)num2 != 0);
				List<Step> list = steps;
				bool flag = default(bool);
				if (flag)
				{
					List<Step> playing2 = _playing;
				}
				int _003C_003E1__state = default(int);
				_003CPlayAsync_003Ed__48 _003CPlayAsync_003Ed__ = new _003CPlayAsync_003Ed__48(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CPlayAsync_003Ed__._003C_003E4__this = (Cutscene)0;
				if (Cutscene.OnStartedPlaying == null)
				{
				}
				return;
			}
			List<Step> playing3 = _playing;
			Finish();
			Skip();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600199B")]
		[Cpp2IlInjected.Address(RVA = "0x1113910", Offset = "0x1112310", VA = "0x181113910")]
		[AsyncStateMachine(typeof(_003CPlayAsync_003Ed__43))]
		public Task<bool> PlayAsync(Camera camera, float holdInPlaceDuration, float holdInPlaceDragTolerance, float fadeOutDuration, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600199C")]
		[Cpp2IlInjected.Address(RVA = "0x1113EA0", Offset = "0x11128A0", VA = "0x181113EA0")]
		public void Skip()
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0018
			List<Step> playing = _playing;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600199D")]
		[Cpp2IlInjected.Address(RVA = "0x1113670", Offset = "0x1112070", VA = "0x181113670")]
		private void Finish()
		{
			//Discarded unreachable code: IL_002c
			BaseUiRoot.Instance.HideCutsceneSkipper();
			Cutscene.OnFinishedPlaying?.Invoke(this);
			GameObject gameObject = cutscene;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600199E")]
		[Cpp2IlInjected.Address(RVA = "0x1113800", Offset = "0x1112200", VA = "0x181113800")]
		public void Pause()
		{
			//Discarded unreachable code: IL_0013, IL_0019
			Paused = true;
			List<Step> playing = _playing;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600199F")]
		[Cpp2IlInjected.Address(RVA = "0x1113D90", Offset = "0x1112790", VA = "0x181113D90")]
		public void Resume()
		{
			//Discarded unreachable code: IL_0015, IL_001b
			int num = ((Paused = false) ? 1 : 0);
			List<Step> playing = _playing;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019A0")]
		[Cpp2IlInjected.Address(RVA = "0x1113A70", Offset = "0x1112470", VA = "0x181113A70")]
		[IteratorStateMachine(typeof(_003CPlayAsync_003Ed__48))]
		private IEnumerator PlayAsync()
		{
			int _003C_003E1__state = default(int);
			_003CPlayAsync_003Ed__48 _003CPlayAsync_003Ed__ = new _003CPlayAsync_003Ed__48(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPlayAsync_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019A1")]
		[Cpp2IlInjected.Address(RVA = "0x1113770", Offset = "0x1112170", VA = "0x181113770")]
		private bool NoPreviousBlocker(List<Step> steps, int current)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60019A2")]
		[Cpp2IlInjected.Address(RVA = "0x1114000", Offset = "0x1112A00", VA = "0x181114000")]
		public Cutscene()
		{
		}
	}
}
