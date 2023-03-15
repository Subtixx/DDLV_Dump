using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Conditions;
using Gameloft.Common;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.Rendering;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004F7")]
	[ExecuteAlways]
	[RequireComponent(typeof(Volume))]
	public class WeatherSystem : Mdl.Systems.System, IWeatherController
	{
		[Cpp2IlInjected.Token(Token = "0x20004F8")]
		private class TransitionValues
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001F5C")]
			public float start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4001F5D")]
			public float end;

			[Cpp2IlInjected.Token(Token = "0x6001624")]
			[Cpp2IlInjected.Address(RVA = "0xF880E0", Offset = "0xF86AE0", VA = "0x180F880E0")]
			public TransitionValues(float start, float end)
			{
				this.start = start;
				this.end = end;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20004F9")]
		public class WeatherOverrideStatus
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001F5E")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001F5F")]
			public bool active;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4001F60")]
			public int activationCount;

			[Cpp2IlInjected.Token(Token = "0x6001625")]
			[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
			public WeatherOverrideStatus(string name)
			{
				this.name = name;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001F3E")]
		public bool useJobs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4001F3F")]
		public bool useSmoothing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4001F40")]
		public float smoothingFactor = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001F41")]
		public Transform effectsRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001F42")]
		private Volume volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001F43")]
		[SerializeField]
		public float windFrequency = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4001F44")]
		[SerializeField]
		[Range(0f, 1f)]
		public float windAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001F45")]
		private DayAndNight dayAndNight;

		[Cpp2IlInjected.Token(Token = "0x4001F46")]
		public static bool lockTime;

		[Cpp2IlInjected.Token(Token = "0x4001F47")]
		public static float lockTimeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001F48")]
		[Tooltip("Layer of weather volumes. Only the weatherVolumes in this layer will influence the weatherSystem.")]
		public LayerMask layer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4001F49")]
		[Tooltip("Update count per second")]
		public float updateFreq = 15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001F4A")]
		public bool cubemapBlending;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001F4B")]
		public List<WeatherModifier> permanentModifiers = (List<WeatherModifier>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001F4C")]
		private List<(WeatherTimeline timeline, float weight)> timelines = (List<(WeatherTimeline timeline, float weight)>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001F4D")]
		private RenderTexture cubemapBlendingTex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001F4E")]
		[HideInInspector]
		public WeatherProfileDeprecated currentProfile;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001F4F")]
		private Collider[] colliders = new Collider[5];

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001F50")]
		[HideInInspector]
		public WeatherInfluences influences = new WeatherInfluences();

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4001F51")]
		private WeatherTimeline lastMainTimeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001F52")]
		private HashSet<WeatherModifier> currentModifiers = (HashSet<WeatherModifier>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001F53")]
		public Dictionary<string, float> overrideTags = (Dictionary<string, float>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001F54")]
		public List<WeatherTimeline.Variant> genericVariants = (List<WeatherTimeline.Variant>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001F55")]
		public Dictionary<WeatherTimeline, float> smoothTimelines = (Dictionary<WeatherTimeline, float>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001F56")]
		private WeatherProfileDeprecated lastWeatherProfile;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001F57")]
		private Coroutine transitionWeatherCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001F58")]
		private Coroutine weatherEffectTransitionCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001F59")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001F5B")]
		private WeatherOverride currentWeatherOverride;

		[Cpp2IlInjected.Token(Token = "0x170002CF")]
		public bool UseJobs
		{
			[Cpp2IlInjected.Token(Token = "0x60015FD")]
			[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
			get
			{
				return useJobs;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D0")]
		public float WindFrequency
		{
			[Cpp2IlInjected.Token(Token = "0x60015FE")]
			[Cpp2IlInjected.Address(RVA = "0x83E0F0", Offset = "0x83CAF0", VA = "0x18083E0F0", Slot = "10")]
			get
			{
				return windFrequency;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D1")]
		public Vector3 WindAxis
		{
			[Cpp2IlInjected.Token(Token = "0x60015FF")]
			[Cpp2IlInjected.Address(RVA = "0x83E0A0", Offset = "0x83CAA0", VA = "0x18083E0A0", Slot = "11")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D2")]
		public MonoBehaviour monoBehaviour
		{
			[Cpp2IlInjected.Token(Token = "0x6001600")]
			[Cpp2IlInjected.Address(RVA = "0x7EF5A0", Offset = "0x7EDFA0", VA = "0x1807EF5A0", Slot = "18")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D3")]
		public float updateFrequency
		{
			[Cpp2IlInjected.Token(Token = "0x6001601")]
			[Cpp2IlInjected.Address(RVA = "0x83E100", Offset = "0x83CB00", VA = "0x18083E100", Slot = "15")]
			get
			{
				return updateFreq;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D4")]
		public List<(WeatherTimeline, float)> Timelines
		{
			[Cpp2IlInjected.Token(Token = "0x6001602")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80", Slot = "8")]
			get
			{
				return timelines;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D5")]
		public List<WeatherModifier> Modifiers
		{
			[Cpp2IlInjected.Token(Token = "0x6001603")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0", Slot = "9")]
			get
			{
				return permanentModifiers;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D6")]
		public PostProcess PostProcess
		{
			[Cpp2IlInjected.Token(Token = "0x6001604")]
			[Cpp2IlInjected.Address(RVA = "0x83DEC0", Offset = "0x83C8C0", VA = "0x18083DEC0", Slot = "12")]
			get
			{
				return GraphicSettings.PostProcess;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D7")]
		public Volume Volume
		{
			[Cpp2IlInjected.Token(Token = "0x6001605")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0", Slot = "13")]
			get
			{
				return volume;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D8")]
		public float Time
		{
			[Cpp2IlInjected.Token(Token = "0x6001606")]
			[Cpp2IlInjected.Address(RVA = "0x83DF20", Offset = "0x83C920", VA = "0x18083DF20", Slot = "14")]
			get
			{
				//Discarded unreachable code: IL_0006, IL_0019, IL_0025
				//IL_0016: Expected O, but got I4
				return lockTimeValue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D9")]
		private IEnumerable<WeatherOverride> WeatherOverrides
		{
			[Cpp2IlInjected.Token(Token = "0x6001614")]
			[Cpp2IlInjected.Address(RVA = "0x83DFE0", Offset = "0x83C9E0", VA = "0x18083DFE0")]
			get
			{
				//Discarded unreachable code: IL_000b
				return (IEnumerable<WeatherOverride>)ProtoDatabase.Instance.Enumerate<WeatherOverride>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DA")]
		public Dictionary<WeatherOverride, WeatherOverrideStatus> DebugWeatherOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6001617")]
			[Cpp2IlInjected.Address(RVA = "0x7389D0", Offset = "0x7373D0", VA = "0x1807389D0")]
			[CompilerGenerated]
			get
			{
				return _003CDebugWeatherOverride_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001618")]
			[Cpp2IlInjected.Address(RVA = "0x83E110", Offset = "0x83CB10", VA = "0x18083E110")]
			[CompilerGenerated]
			private set
			{
				_003CDebugWeatherOverride_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DB")]
		private bool HasWeatherOverride
		{
			[Cpp2IlInjected.Token(Token = "0x600161B")]
			[Cpp2IlInjected.Address(RVA = "0x83DEB0", Offset = "0x83C8B0", VA = "0x18083DEB0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001607")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void Awake()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001608")]
		[Cpp2IlInjected.Address(RVA = "0x83D310", Offset = "0x83BD10", VA = "0x18083D310")]
		private void OnValidate()
		{
			float num = (updateFreq = Mathf.Clamp(updateFreq, 0.01f, 150f));
		}

		[Cpp2IlInjected.Token(Token = "0x6001609")]
		[Cpp2IlInjected.Address(RVA = "0x83DA00", Offset = "0x83C400", VA = "0x18083DA00")]
		private void Update()
		{
			//Discarded unreachable code: IL_003b
			//IL_0019: Expected O, but got I4
			int force = 0;
			WeatherController.Evaluate(this, (byte)force != 0);
			Transform transform = effectsRoot;
			int num = 0;
			if (transform != (UnityEngine.Object)num)
			{
				Transform transform2 = effectsRoot;
				float z = WeatherController.GetAnchorPoint().z;
				FogPass._FogMat = (Material)(object)effectsRoot;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600160A")]
		[Cpp2IlInjected.Address(RVA = "0x83C7B0", Offset = "0x83B1B0", VA = "0x18083C7B0")]
		private void OnEnable()
		{
			Volume volume = (this.volume = GetComponent<Volume>());
			WeatherController.AddController(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600160B")]
		[Cpp2IlInjected.Address(RVA = "0x83C750", Offset = "0x83B150", VA = "0x18083C750")]
		private void OnDisable()
		{
			WeatherController.RemoveController(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600160C")]
		[Cpp2IlInjected.Address(RVA = "0x83D4C0", Offset = "0x83BEC0", VA = "0x18083D4C0")]
		public static void SetLockTimeState(bool enable, float timeValue = 0f)
		{
			lockTime = enable;
			lockTimeValue = timeValue;
		}

		[Cpp2IlInjected.Token(Token = "0x600160D")]
		[Cpp2IlInjected.Address(RVA = "0x83B920", Offset = "0x83A320", VA = "0x18083B920", Slot = "17")]
		public void LoadTimelines()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600160E")]
		[Cpp2IlInjected.Address(RVA = "0x83D840", Offset = "0x83C240", VA = "0x18083D840")]
		[AsyncStateMachine(typeof(_003CTransitionToWeather_003Ed__51))]
		public Task TransitionToWeather(string newWeatherProfileName)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600160F")]
		[Cpp2IlInjected.Address(RVA = "0x83D520", Offset = "0x83BF20", VA = "0x18083D520")]
		[AsyncStateMachine(typeof(_003CTransitionToWeather_003Ed__52))]
		private Task TransitionToWeather(WeatherOverride weatherOverride)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001610")]
		[Cpp2IlInjected.Address(RVA = "0x83D650", Offset = "0x83C050", VA = "0x18083D650")]
		private void TransitionToWeather(WeatherProfileDeprecated profile, bool weatherOverride)
		{
			//Discarded unreachable code: IL_00c0
			if (!base.gameObject.activeInHierarchy)
			{
				base.gameObject.SetActive(value: true);
			}
			if (!weatherOverride)
			{
				lastWeatherProfile = profile;
				if ((long)currentWeatherOverride > 0)
				{
					return;
				}
			}
			Coroutine coroutine = transitionWeatherCoroutine;
			WeatherProfileDeprecated prevProfile = currentProfile;
			if (coroutine != null)
			{
				StopCoroutine(coroutine);
			}
			int _003C_003E1__state = default(int);
			_003CTransitionWeatherRoutine_003Ed__57 _003CTransitionWeatherRoutine_003Ed__ = new _003CTransitionWeatherRoutine_003Ed__57(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CTransitionWeatherRoutine_003Ed__._003C_003E4__this = this;
			_003CTransitionWeatherRoutine_003Ed__.newWeather = profile;
			Coroutine coroutine2 = (transitionWeatherCoroutine = StartCoroutine(_003CTransitionWeatherRoutine_003Ed__));
			Coroutine coroutine3 = weatherEffectTransitionCoroutine;
			if (coroutine3 != null)
			{
				StopCoroutine(coroutine3);
			}
			int _003C_003E1__state2 = default(int);
			_003CWeatherEffectTransition_003Ed__59 _003CWeatherEffectTransition_003Ed__ = new _003CWeatherEffectTransition_003Ed__59(_003C_003E1__state2);
			_003C_003E1__state2 = 0;
			_003CWeatherEffectTransition_003Ed__._003C_003E4__this = this;
			_003CWeatherEffectTransition_003Ed__.prevProfile = prevProfile;
			_003CWeatherEffectTransition_003Ed__.newProfile = profile;
			Coroutine coroutine4 = (weatherEffectTransitionCoroutine = StartCoroutine(_003CWeatherEffectTransition_003Ed__));
		}

		[Cpp2IlInjected.Token(Token = "0x6001611")]
		[Cpp2IlInjected.Address(RVA = "0x83D970", Offset = "0x83C370", VA = "0x18083D970")]
		[IteratorStateMachine(typeof(_003CTransitionWeatherRoutine_003Ed__57))]
		private IEnumerator TransitionWeatherRoutine(WeatherProfileDeprecated newWeather)
		{
			int _003C_003E1__state = default(int);
			_003CTransitionWeatherRoutine_003Ed__57 _003CTransitionWeatherRoutine_003Ed__ = new _003CTransitionWeatherRoutine_003Ed__57(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CTransitionWeatherRoutine_003Ed__._003C_003E4__this = this;
			_003CTransitionWeatherRoutine_003Ed__.newWeather = newWeather;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001612")]
		[Cpp2IlInjected.Address(RVA = "0x83DB70", Offset = "0x83C570", VA = "0x18083DB70")]
		[IteratorStateMachine(typeof(_003CWeatherEffectTransition_003Ed__59))]
		private IEnumerator WeatherEffectTransition(WeatherProfileDeprecated prevProfile, WeatherProfileDeprecated newProfile)
		{
			int _003C_003E1__state = default(int);
			_003CWeatherEffectTransition_003Ed__59 _003CWeatherEffectTransition_003Ed__ = new _003CWeatherEffectTransition_003Ed__59(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWeatherEffectTransition_003Ed__._003C_003E4__this = this;
			_003CWeatherEffectTransition_003Ed__.prevProfile = prevProfile;
			_003CWeatherEffectTransition_003Ed__.newProfile = newProfile;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001613")]
		[Cpp2IlInjected.Address(RVA = "0x83D350", Offset = "0x83BD50", VA = "0x18083D350")]
		private void OnWeatherChanged(string oldWeather, string newWeather)
		{
			int num = 0;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001615")]
		[Cpp2IlInjected.Address(RVA = "0x83B630", Offset = "0x83A030", VA = "0x18083B630")]
		private void InitEventHandler()
		{
			//Discarded unreachable code: IL_0055, IL_005b, IL_0061
			int num = 0;
			IEnumerable<WeatherOverride> enumerable = (IEnumerable<WeatherOverride>)this.get_WeatherOverrides();
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num != (int)num2)
					{
						num++;
					}
				}
				enumerable = (IEnumerable<WeatherOverride>)(object)((object)enumerable + (object)enumerable);
			}
			if (enumerable != null)
			{
			}
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			if (_003CDispatcher_003Ek__BackingField != null)
			{
				ProfileEventDispatcher.AnyConditionChanged callback = default(ProfileEventDispatcher.AnyConditionChanged);
				conditionEventHandler = _003CDispatcher_003Ek__BackingField.RegisterToAnyConditionChanged((ConditionListener)num, callback);
			}
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001616")]
		[Cpp2IlInjected.Address(RVA = "0x83B250", Offset = "0x839C50", VA = "0x18083B250")]
		private void DisposeEventHandler()
		{
			while (true)
			{
				if ((object)this != null)
				{
					/*Error: Could not find block for branch target IL_0004*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001619")]
		[Cpp2IlInjected.Address(RVA = "0x83AEC0", Offset = "0x8398C0", VA = "0x18083AEC0")]
		[Conditional("UNITY_EDITOR")]
		private void DebugInitStatus()
		{
			//Discarded unreachable code: IL_0039, IL_003f
			int num = 0;
			Dictionary<WeatherOverride, WeatherOverrideStatus> dictionary = (DebugWeatherOverride = (Dictionary<WeatherOverride, WeatherOverrideStatus>)(object)new Dictionary<TKey, TValue>());
			IEnumerable<> enumerable = ProtoDatabase.Instance.EnumerateWithId<WeatherOverride>();
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0034;
					}
					num++;
				}
				throw new NullReferenceException();
			}
			goto IL_0034;
			IL_0034:
			if (enumerable == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600161A")]
		[Cpp2IlInjected.Address(RVA = "0x83B1B0", Offset = "0x839BB0", VA = "0x18083B1B0")]
		[Conditional("UNITY_EDITOR")]
		private void DebugUpdateStatus(WeatherOverride weatherOverride, bool activate)
		{
			//Discarded unreachable code: IL_0010
			Dictionary<WeatherOverride, WeatherOverrideStatus> dictionary = DebugWeatherOverride;
			bool flag = default(bool);
			if (flag && !activate)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600161C")]
		[Cpp2IlInjected.Address(RVA = "0x83C3F0", Offset = "0x83ADF0", VA = "0x18083C3F0")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_0094, IL_009a
			//IL_005a: Expected F4, but got I4
			//IL_0061: Expected O, but got I4
			int num = 0;
			WeatherOverride weatherOverride = currentWeatherOverride;
			if (weatherOverride != null)
			{
				ConditionsList conditions_ = weatherOverride.conditions_;
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
				if (!conditions_.Evaluate(profile, _003CTransactionContext_003Ek__BackingField))
				{
					if ((currentWeatherOverride.lockTime_ ? 1 : 0) != num)
					{
						int num2 = 0;
						SetLockTimeState(enable: false, num2);
					}
					currentWeatherOverride = (WeatherOverride)num;
				}
			}
			IEnumerable<WeatherOverride> weatherOverrides = (IEnumerable<WeatherOverride>)this.get_WeatherOverrides();
			if (weatherOverrides != null)
			{
				bool flag = default(bool);
				while (!flag)
				{
				}
				num++;
			}
			num++;
			if (weatherOverrides != null)
			{
			}
			if (num != 0)
			{
			}
			if (weatherOverride != null)
			{
				int num3 = 0;
				bool flag2 = default(bool);
				if (flag2)
				{
					int num4 = 0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600161D")]
		[Cpp2IlInjected.Address(RVA = "0x83B290", Offset = "0x839C90", VA = "0x18083B290")]
		private bool EvaluateWeatherOverride(WeatherOverride weatherOverride)
		{
			if ((long)currentWeatherOverride <= 0)
			{
				ConditionsList conditions_ = weatherOverride.conditions_;
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
				bool flag = conditions_.Evaluate(profile, _003CTransactionContext_003Ek__BackingField);
				if (!flag)
				{
					return flag;
				}
				currentWeatherOverride = weatherOverride;
				WeatherOverride weatherOverride2 = currentWeatherOverride;
				int num = 0;
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				WeatherOverride weatherOverride3 = currentWeatherOverride;
				TimeInDay time_ = weatherOverride3.time_;
				bool lockTime_ = weatherOverride3.lockTime_;
				float totalDays = time_.TotalDays;
				SetLockTimeState(lockTime_, totalDays);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600161E")]
		[Cpp2IlInjected.Address(RVA = "0x83CAB0", Offset = "0x83B4B0", VA = "0x18083CAB0", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_0093, IL_0099
			WeatherController.overrideTime = (WeatherController.overridePostProcess = (WeatherController.paused = false));
			((HashSet<T>)(object)currentModifiers).Clear();
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			string currentWeather_ = SystemRoot.Instance.MetaClient.profile.world_.currentWeather_;
			int num = 0;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.WeatherChanged value = OnWeatherChanged;
			_003CDispatcher_003Ek__BackingField.OnWeatherChanged += value;
			List<WeatherModifier> list = permanentModifiers;
			bool flag = default(bool);
			if (flag)
			{
			}
			int num3 = 0;
			WeatherController.ResetAnchor();
		}

		[Cpp2IlInjected.Token(Token = "0x600161F")]
		[Cpp2IlInjected.Address(RVA = "0x83D000", Offset = "0x83BA00", VA = "0x18083D000", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_0084
			//IL_001a: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			int num = 0;
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)num;
			RenderTexture renderTexture = cubemapBlendingTex;
			int num2 = 0;
			if (renderTexture != (UnityEngine.Object)num2)
			{
				cubemapBlendingTex.Release();
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaClient != null)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.WeatherChanged value = OnWeatherChanged;
				_003CDispatcher_003Ek__BackingField.OnWeatherChanged -= value;
			}
			List<WeatherModifier> list = permanentModifiers;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001620")]
		[Cpp2IlInjected.Address(RVA = "0x83C830", Offset = "0x83B230", VA = "0x18083C830", Slot = "6")]
		public override void OnSystemPause()
		{
			//Discarded unreachable code: IL_000e
			int num = 0;
			List<WeatherModifier> list = permanentModifiers;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001621")]
		[Cpp2IlInjected.Address(RVA = "0x83C970", Offset = "0x83B370", VA = "0x18083C970", Slot = "7")]
		public override void OnSystemResume()
		{
			//Discarded unreachable code: IL_0012
			WeatherController.paused = false;
			List<WeatherModifier> list = permanentModifiers;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001622")]
		[Cpp2IlInjected.Address(RVA = "0x83B5D0", Offset = "0x839FD0", VA = "0x18083B5D0", Slot = "16")]
		public void Evaluate()
		{
			int force = 0;
			WeatherController.Evaluate(this, (byte)force != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001623")]
		[Cpp2IlInjected.Address(RVA = "0x83DC20", Offset = "0x83C620", VA = "0x18083DC20")]
		public WeatherSystem()
		{
		}
	}
}
