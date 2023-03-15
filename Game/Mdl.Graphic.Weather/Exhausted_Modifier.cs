using System;
using Cpp2IlInjected;
using Definitions;
using Definitions.Conditions;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Ftue.Cutscenes;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20004D5")]
	[CreateAssetMenu]
	public class Exhausted_Modifier : WeatherModifier
	{
		[Cpp2IlInjected.Token(Token = "0x20004D6")]
		public enum Debug
		{
			[Cpp2IlInjected.Token(Token = "0x4001E58")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4001E59")]
			ForceOn,
			[Cpp2IlInjected.Token(Token = "0x4001E5A")]
			ForceOff
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E48")]
		[Header("Pulse")]
		public Debug debug;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4001E49")]
		public float pulseSpeed = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E4A")]
		public AnimationCurve vignettePulse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E4B")]
		public AnimationCurve vignetteSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E4C")]
		[SerializeField]
		[Tooltip("Timeline which contains the information for the exhausted effect. Only postProcesses will be taken into account.")]
		[Header("Timelines")]
		private WeatherTimeline exhaustedTimeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001E4D")]
		[SerializeField]
		[Tooltip("Timeline which contains the information for the exhausted effect (with pulse). Only postProcesses will be taken into account.")]
		private WeatherTimeline exhaustedPulsedTimeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001E4E")]
		[SerializeField]
		private Texture2D vignette;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001E4F")]
		[ItemID]
		[SerializeField]
		[ItemID(ItemType.Condition)]
		[Tooltip("The effect will only be applied if the condition is fulfilled.")]
		private int _conditionItem;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001E50")]
		private float effectIntensity;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001E51")]
		private float smoothEffectIntensity;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4001E52")]
		private float timer;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001E53")]
		private bool inCutscene;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4001E54")]
		private bool firstMissionDone;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4001E55")]
		private float effectDuration = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001E56")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x170002A6")]
		public override string menuName
		{
			[Cpp2IlInjected.Token(Token = "0x6001545")]
			[Cpp2IlInjected.Address(RVA = "0x1368C80", Offset = "0x1367680", VA = "0x181368C80", Slot = "4")]
			get
			{
				return "Exhausted";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A7")]
		public Item ConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001546")]
			[Cpp2IlInjected.Address(RVA = "0x1368C20", Offset = "0x1367620", VA = "0x181368C20")]
			get
			{
				long num = Convert.ToInt64((uint)_conditionItem);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001547")]
		[Cpp2IlInjected.Address(RVA = "0x1368170", Offset = "0x1366B70", VA = "0x181368170", Slot = "6")]
		public override void Disable()
		{
			//Discarded unreachable code: IL_0088
			//IL_003c: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			Cutscene.OnStartedPlaying -= OnStartedPlayingCutscene;
			Cutscene.OnFinishedPlaying -= OnStopPlayingCutscene;
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			PlayerAvatar avatar = default(PlayerAvatar);
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				avatar = _003CInstance_003Ek__BackingField._avatar;
			}
			int num2 = 0;
			if (avatar != (UnityEngine.Object)num2)
			{
				Action value = AvatarLowManaEvent;
				avatar.LowManaEvent -= value;
				Action value2 = AvatarNotEnoughManaEvent;
				avatar.NotEnoughManaEvent -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001548")]
		[Cpp2IlInjected.Address(RVA = "0x13683E0", Offset = "0x1366DE0", VA = "0x1813683E0", Slot = "5")]
		public unsafe override void Enable()
		{
			//Discarded unreachable code: IL_00dd
			//IL_001e: Expected F4, but got I4
			int num = 0;
			if (ProtoDatabase.Instance.TryGet("ManaInfo", out *(ManaData*)num))
			{
				int num2 = 0;
				effectDuration = num2;
			}
			Cutscene.OnStartedPlaying += OnStartedPlayingCutscene;
			Cutscene.OnFinishedPlaying += OnStopPlayingCutscene;
			CreateEventHandler();
			PlayerAvatar avatar = SystemRoot.Instance._avatar;
			Action value = AvatarLowManaEvent;
			avatar.LowManaEvent += value;
			PlayerAvatar avatar2 = SystemRoot.Instance._avatar;
			Action value2 = AvatarNotEnoughManaEvent;
			avatar2.NotEnoughManaEvent += value2;
			long num3 = Convert.ToInt64((uint)_conditionItem);
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			Texture2D value3 = vignette;
			bool flag = default(bool);
			firstMissionDone = flag;
			Shader.SetGlobalTexture("_PostProcessVignette", value3);
			Shader.SetGlobalFloat("_PostProcessVignetteSize", 1f);
		}

		[Cpp2IlInjected.Token(Token = "0x6001549")]
		[Cpp2IlInjected.Address(RVA = "0x1368AC0", Offset = "0x13674C0", VA = "0x181368AC0")]
		private void OnStartedPlayingCutscene(Cutscene cutscene)
		{
			inCutscene = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600154A")]
		[Cpp2IlInjected.Address(RVA = "0x1368AD0", Offset = "0x13674D0", VA = "0x181368AD0")]
		private void OnStopPlayingCutscene(Cutscene cutscene)
		{
			inCutscene = false;
		}

		[Cpp2IlInjected.Token(Token = "0x600154B")]
		[Cpp2IlInjected.Address(RVA = "0x13688F0", Offset = "0x13672F0", VA = "0x1813688F0")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_0025
			int conditionItem = _conditionItem;
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			bool flag = default(bool);
			firstMissionDone = flag;
		}

		[Cpp2IlInjected.Token(Token = "0x600154C")]
		[Cpp2IlInjected.Address(RVA = "0x1367F80", Offset = "0x1366980", VA = "0x181367F80")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			long num2 = Convert.ToInt64((uint)_conditionItem);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600154D")]
		[Cpp2IlInjected.Address(RVA = "0x13683B0", Offset = "0x1366DB0", VA = "0x1813683B0")]
		private void DisposeEventHandler()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = eventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600154E")]
		[Cpp2IlInjected.Address(RVA = "0x1367D00", Offset = "0x1366700", VA = "0x181367D00")]
		private void AvatarLowManaEvent()
		{
			//IL_0012: Expected F4, but got I4
			if (debug == Debug.ForceOff)
			{
				int num = 0;
				effectIntensity = num;
			}
			else
			{
				float num2 = (timer = effectDuration);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600154F")]
		[Cpp2IlInjected.Address(RVA = "0x1367D00", Offset = "0x1366700", VA = "0x181367D00")]
		private void AvatarNotEnoughManaEvent()
		{
			//IL_0012: Expected F4, but got I4
			if (debug == Debug.ForceOff)
			{
				int num = 0;
				effectIntensity = num;
			}
			else
			{
				float num2 = (timer = effectDuration);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001550")]
		[Cpp2IlInjected.Address(RVA = "0x1368AE0", Offset = "0x13674E0", VA = "0x181368AE0")]
		private void OnValidate()
		{
			//IL_0019: Expected O, but got I4
			int num = 0;
			if (!Application.isPlaying)
			{
				return;
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num2 = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num2)
			{
				if (debug == Debug.ForceOff)
				{
					effectIntensity = 0f;
					return;
				}
				float num3 = (timer = effectDuration);
				effectIntensity = 1f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001551")]
		[Cpp2IlInjected.Address(RVA = "0x1367D00", Offset = "0x1366700", VA = "0x181367D00")]
		private void StartEffect()
		{
			//IL_0012: Expected F4, but got I4
			if (debug == Debug.ForceOff)
			{
				int num = 0;
				effectIntensity = num;
			}
			else
			{
				float num2 = (timer = effectDuration);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001552")]
		[Cpp2IlInjected.Address(RVA = "0x1367D30", Offset = "0x1366730", VA = "0x181367D30", Slot = "7")]
		public override void BeforeEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			//Discarded unreachable code: IL_0136
			//IL_004a: Expected O, but got F4
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected F4, but got Unknown
			//IL_00b5: Expected O, but got I4
			//IL_00cf: Expected O, but got I4
			//IL_00e7: Expected O, but got I4
			int num = 0;
			float num2 = effectIntensity;
			float num3 = Time.deltaTime * 3f;
			float num4 = (smoothEffectIntensity = Mathf.Lerp(num3, time, num3));
			if (!inCutscene && firstMissionDone)
			{
				int num5 = 0;
				float num6 = ((Exhausted_Modifier)Time.time).pulseSpeed;
				float time2 = /*Error near IL_004b: Stack underflow*/* num6;
				float num7 = vignettePulse.Evaluate(time2);
				AnimationCurve animationCurve = vignetteSize;
				num2 = num7;
				float num8 = animationCurve.Evaluate(time2);
				float t = smoothEffectIntensity;
				time2 = num8;
				float num9 = Mathf.Lerp(1f, time2, t);
				int num10 = 0;
				int num11 = 0;
				float time3 = Time.time;
				WeatherTimeline weatherTimeline = exhaustedTimeline;
				int num12 = 0;
				t = time;
				weatherTimeline.Evaluate((Hash128)num10, t, forceCopy: true);
				WeatherTimeline weatherTimeline2 = exhaustedPulsedTimeline;
				int num13 = 0;
				t = time;
				weatherTimeline2.Evaluate((Hash128)num13, t, forceCopy: true);
				if ((IntPtr)mainTimeline._propValues == (IntPtr)num12)
				{
					t = time;
					mainTimeline.Evaluate((Hash128)num10, t, forceCopy: true);
				}
				float num14 = smoothEffectIntensity;
				WeatherTimeline target = exhaustedTimeline;
				mainTimeline.Lerp(target, num14, enableOnly: true);
				WeatherTimeline target2 = exhaustedPulsedTimeline;
				mainTimeline.Lerp(target2, num14, enableOnly: true);
				Texture2D value = vignette;
				Shader.SetGlobalTexture("_PostProcessVignette", value);
				Shader.SetGlobalFloat("_PostProcessVignetteSize", time3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001553")]
		[Cpp2IlInjected.Address(RVA = "0x1367CB0", Offset = "0x13666B0", VA = "0x181367CB0", Slot = "8")]
		public override void AfterEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			//IL_000b: Invalid comparison between F4 and I4
			float num = timer;
			int num2 = 0;
			if (!(num <= (float)num2))
			{
				int num3 = 0;
				float deltaTime = Time.deltaTime;
				timer = num;
				effectIntensity = 0f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001554")]
		[Cpp2IlInjected.Address(RVA = "0x1368C00", Offset = "0x1367600", VA = "0x181368C00")]
		public Exhausted_Modifier()
		{
		}
	}
}
