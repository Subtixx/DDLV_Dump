using System;
using Cpp2IlInjected;
using Mdl.Environments;
using Mdl.Systems;
using Meta;
using Meta.Online;
using Meta.Util;
using UnityEngine;

namespace Mdl.Graphic
{
	[Cpp2IlInjected.Token(Token = "0x2000498")]
	public class DayAndNight : Mdl.Systems.System
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001CF5")]
		public Texture2D fogNoiseTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001CF6")]
		[SerializeField]
		public float timeRate = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4001CF7")]
		private bool paused;

		[Cpp2IlInjected.Token(Token = "0x4001CF8")]
		private const int secondsInADay = 86400;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001CF9")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x1700028D")]
		private float minuteProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6001469")]
			[Cpp2IlInjected.Address(RVA = "0x1115DD0", Offset = "0x11147D0", VA = "0x181115DD0")]
			get
			{
				float result = default(float);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		private float hourProgress
		{
			[Cpp2IlInjected.Token(Token = "0x600146A")]
			[Cpp2IlInjected.Address(RVA = "0x1115DC0", Offset = "0x11147C0", VA = "0x181115DC0")]
			get
			{
				float result = default(float);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600146B")]
		[Cpp2IlInjected.Address(RVA = "0x11157A0", Offset = "0x11141A0", VA = "0x1811157A0")]
		private void OnEnable()
		{
			Texture2D value = fogNoiseTexture;
			Shader.SetGlobalTexture("_HeightFogNoise", value);
		}

		[Cpp2IlInjected.Token(Token = "0x600146C")]
		[Cpp2IlInjected.Address(RVA = "0x1115800", Offset = "0x1114200", VA = "0x181115800", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_003c
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.DebugSkippedTimeChanged value = OnDebugSkippedTimeChanged;
			_003CDispatcher_003Ek__BackingField.OnDebugSkippedTimeChanged += value;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += Environment_AnyEnvironmentEnteredEvent;
			SyncTime();
		}

		[Cpp2IlInjected.Token(Token = "0x600146D")]
		[Cpp2IlInjected.Address(RVA = "0x1115BD0", Offset = "0x11145D0", VA = "0x181115BD0")]
		public void SyncTime()
		{
			//Discarded unreachable code: IL_0030
			//IL_002a: Expected I8, but got I4
			//IL_002f: Expected I4, but got I8
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaClient != null)
			{
				DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
				int num = default(int);
				long num2 = num * 60;
				int num3 = (int)(num3 + num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600146E")]
		[Cpp2IlInjected.Address(RVA = "0x1115980", Offset = "0x1114380", VA = "0x181115980", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_0048
			//IL_0020: Expected O, but got I4
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= Environment_AnyEnvironmentEnteredEvent;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.DebugSkippedTimeChanged value = OnDebugSkippedTimeChanged;
				_003CDispatcher_003Ek__BackingField.OnDebugSkippedTimeChanged -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600146F")]
		[Cpp2IlInjected.Address(RVA = "0x11157E0", Offset = "0x11141E0", VA = "0x1811157E0", Slot = "6")]
		public override void OnSystemPause()
		{
			paused = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001470")]
		[Cpp2IlInjected.Address(RVA = "0x11157F0", Offset = "0x11141F0", VA = "0x1811157F0", Slot = "7")]
		public override void OnSystemResume()
		{
			paused = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6001471")]
		[Cpp2IlInjected.Address(RVA = "0x1115D60", Offset = "0x1114760", VA = "0x181115D60")]
		private void Update()
		{
			//IL_0015: Expected O, but got F4
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected F4, but got Unknown
			if (!paused)
			{
				int num = 0;
				float num2 = ((DayAndNight)Time.unscaledDeltaTime).timeRate;
				float num3 = (seconds = /*Error near IL_0016: Stack underflow*/* num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001472")]
		[Cpp2IlInjected.Address(RVA = "0x11155D0", Offset = "0x1113FD0", VA = "0x1811155D0")]
		public int GetHour()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001473")]
		[Cpp2IlInjected.Address(RVA = "0x11155F0", Offset = "0x1113FF0", VA = "0x1811155F0")]
		public int GetMinutes()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001474")]
		[Cpp2IlInjected.Address(RVA = "0x1115620", Offset = "0x1114020", VA = "0x181115620")]
		public float GetNormalizedTime()
		{
			//Discarded unreachable code: IL_0023
			//IL_0017: Invalid comparison between I4 and F4
			GameSettingsData data = (GameSettingsData)((BaseStorage<DataType>)(object)SystemRoot.Instance.MetaClient.GameSettings).Data;
			float num = default(float);
			if (!(0f <= num))
			{
			}
			if (!(num <= 1f))
			{
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001475")]
		[Cpp2IlInjected.Address(RVA = "0x1115BA0", Offset = "0x11145A0", VA = "0x181115BA0")]
		public void SetTime(int hour, int minutes = 0)
		{
			//IL_0006: Expected I8, but got I4
			long num = hour * 60;
			num += minutes;
			long num2 = num * 60;
		}

		[Cpp2IlInjected.Token(Token = "0x6001476")]
		[Cpp2IlInjected.Address(RVA = "0x1115BC0", Offset = "0x11145C0", VA = "0x181115BC0")]
		public void SetTime(float normalizedTime)
		{
			float num = (seconds = normalizedTime * 86400f);
		}

		[Cpp2IlInjected.Token(Token = "0x6001477")]
		[Cpp2IlInjected.Address(RVA = "0x11155C0", Offset = "0x1113FC0", VA = "0x1811155C0")]
		private void OnDebugSkippedTimeChanged(TimeSpan skippedTime)
		{
			SyncTime();
		}

		[Cpp2IlInjected.Token(Token = "0x6001478")]
		[Cpp2IlInjected.Address(RVA = "0x11155C0", Offset = "0x1113FC0", VA = "0x1811155C0")]
		private void Environment_AnyEnvironmentEnteredEvent(object sender, EventArgs e)
		{
			SyncTime();
		}

		[Cpp2IlInjected.Token(Token = "0x6001479")]
		[Cpp2IlInjected.Address(RVA = "0x1115DB0", Offset = "0x11147B0", VA = "0x181115DB0")]
		public DayAndNight()
		{
		}
	}
}
