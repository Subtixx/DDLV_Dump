using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Definitions.Util;
using Gameloft.Common;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000793")]
	public class OutdoorEnvironmentVFX : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000794")]
		public enum CurseBehaviour
		{
			[Cpp2IlInjected.Token(Token = "0x4002B58")]
			RealTime,
			[Cpp2IlInjected.Token(Token = "0x4002B59")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4002B5A")]
			Enabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002B50")]
		public float ProbabilityToDisplay = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002B51")]
		public List<Season> Seasons = (List<Season>)(object)new List<T> { (T)0 };

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002B52")]
		[Proto("Definitions.TimeOfDay, Meta.Definitions")]
		public List<string> TimesOfDay = (List<string>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002B53")]
		public bool AnyWeather = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002B54")]
		[Proto("Definitions.Weather, Meta.Definitions")]
		public List<string> Weathers = (List<string>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002B55")]
		public CurseBehaviour BehaviourDuringCurse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002B56")]
		private CancellationTokenProvider cancellationTokenProvider;

		[Cpp2IlInjected.Token(Token = "0x600219D")]
		[Cpp2IlInjected.Address(RVA = "0xF0B810", Offset = "0xF0A210", VA = "0x180F0B810")]
		private void Start()
		{
			//Discarded unreachable code: IL_0065
			int num = 0;
			CancellationTokenProvider cancellationTokenProvider = (this.cancellationTokenProvider = this.GetOrAddComponent<CancellationTokenProvider>());
			CheckActivationStatus();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.WeatherChanged value = OnWeatherChanged;
			_003CDispatcher_003Ek__BackingField.OnWeatherChanged += value;
			CancellationToken cancellationToken = this.cancellationTokenProvider.CancellationToken;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			bool flag = default(bool);
			if (flag)
			{
				EventHandler<bool> eventHandler = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(CurseSystemStateChanged);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600219E")]
		[Cpp2IlInjected.Address(RVA = "0xF0B590", Offset = "0xF09F90", VA = "0x180F0B590")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_005a
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.WeatherChanged value = OnWeatherChanged;
					_003CDispatcher_003Ek__BackingField.OnWeatherChanged -= value;
				}
			}
			bool flag = default(bool);
			if (flag)
			{
				EventHandler<bool> eventHandler = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(CurseSystemStateChanged);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600219F")]
		[Cpp2IlInjected.Address(RVA = "0xF0B100", Offset = "0xF09B00", VA = "0x180F0B100")]
		private void CheckActivationStatus()
		{
			//IL_009f: Expected O, but got I4
			if (SystemRoot.Instance.GetSystem<CurseSystem>().isActive && BehaviourDuringCurse != 0)
			{
				GameObject gameObject = base.gameObject;
				bool active = BehaviourDuringCurse == CurseBehaviour.Enabled;
				gameObject.SetActive(active);
				return;
			}
			Season season = SystemRoot.Instance.MetaClient.LocalTime.GetSeason();
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			string currentWeather_ = SystemRoot.Instance.MetaClient.profile.world_.currentWeather_;
			GameObject gameObject2 = base.gameObject;
			List<Season> seasons = Seasons;
			int num = 0;
			if (!((List<T>)(object)seasons).Contains((T)num))
			{
				List<Season> seasons2 = Seasons;
				bool flag = default(bool);
				if (!flag)
				{
					goto IL_00ea;
				}
			}
			List<string> timesOfDay = TimesOfDay;
			Func<string, bool> cpp2il__autoParamName__idx_ = (Func<string, bool>)(object)(Func<T, TResult>)delegate(string x)
			{
				TimeOfDay timeOfDay = ProtoDatabase.Instance.Get<TimeOfDay>(x);
				if (timeOfDay != null)
				{
					DateTime time = localTime;
					return timeOfDay.IsTimeWithinInterval(time);
				}
				throw new NullReferenceException();
			};
			if (((IEnumerable<>)timesOfDay).Any<string>((Func<, >)(object)cpp2il__autoParamName__idx_) && !AnyWeather && ((List<T>)(object)Weathers).Contains((T)currentWeather_))
			{
			}
			goto IL_00ea;
			IL_00ea:
			int num2 = 0;
			float value = UnityEngine.Random.value;
			float probabilityToDisplay = ProbabilityToDisplay;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60021A0")]
		[Cpp2IlInjected.Address(RVA = "0xF0BB60", Offset = "0xF0A560", VA = "0x180F0BB60")]
		[AsyncStateMachine(typeof(_003CWaitForNextTimeOfDay_003Ed__11))]
		private Task WaitForNextTimeOfDay(CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60021A1")]
		[Cpp2IlInjected.Address(RVA = "0xF0B580", Offset = "0xF09F80", VA = "0x180F0B580")]
		private void OnWeatherChanged(string oldWeather, string newWeather)
		{
			CheckActivationStatus();
		}

		[Cpp2IlInjected.Token(Token = "0x60021A2")]
		[Cpp2IlInjected.Address(RVA = "0xF0B580", Offset = "0xF09F80", VA = "0x180F0B580")]
		private void CurseSystemStateChanged(object sender, bool e)
		{
			CheckActivationStatus();
		}

		[Cpp2IlInjected.Token(Token = "0x60021A3")]
		[Cpp2IlInjected.Address(RVA = "0xF0BC80", Offset = "0xF0A680", VA = "0x180F0BC80")]
		public OutdoorEnvironmentVFX()
		{
		}//Discarded unreachable code: IL_0049
		//IL_001a: Expected O, but got I4

	}
}
