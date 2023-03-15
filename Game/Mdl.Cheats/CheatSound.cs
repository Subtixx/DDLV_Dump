using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AK;
using Cpp2IlInjected;
using Mdl.Audio;
using Mdl.Systems;
using Meta.Util;
using UnityEngine;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x2000843")]
	[CreateAssetMenu]
	public class CheatSound : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E0D")]
		private GameObject soundObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002E0E")]
		private int wwiseSeasonState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002E0F")]
		private int wwiseEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002E10")]
		public float dayNightTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002E11")]
		private int dayMomentState;

		[Cpp2IlInjected.Token(Token = "0x1700054B")]
		private Dictionary<string, uint> SeasonStatesDict
		{
			[Cpp2IlInjected.Token(Token = "0x6002556")]
			[Cpp2IlInjected.Address(RVA = "0xA7EBD0", Offset = "0xA7D5D0", VA = "0x180A7EBD0")]
			get
			{
				//Discarded unreachable code: IL_007f
				Type type = new STATES.SEASONS.STATE().GetType();
				Func<FieldInfo, bool> _003C_003E9__2_ = _003C_003Ec._003C_003E9__2_0;
				if (_003C_003E9__2_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(FieldInfo f)
					{
						//Discarded unreachable code: IL_001a
						Type fieldType = f.FieldType;
						Type typeFromHandle = typeof(uint);
						return ((object)fieldType).Equals((object)typeFromHandle);
					};
				}
				FieldInfo[] array = default(FieldInfo[]);
				IEnumerable<FieldInfo> enumerable = (IEnumerable<FieldInfo>)Enumerable.Where<FieldInfo>((IEnumerable<>)(object)array, (Func<, >)(object)_003C_003E9__2_);
				Func<FieldInfo, string> func = default(Func<FieldInfo, string>);
				if (_003C_003Ec._003C_003E9__2_1 == null)
				{
					func = (Func<FieldInfo, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FieldInfo f) => f.Name.ToLower()));
				}
				Func<FieldInfo, uint> func2 = default(Func<FieldInfo, uint>);
				if (_003C_003Ec._003C_003E9__2_2 == null)
				{
					func2 = (Func<FieldInfo, uint>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(FieldInfo f)
					{
						//IL_0009: Expected O, but got I4
						int num = 0;
						object value = f.GetValue(num);
						throw new NullReferenceException();
					});
				}
				return (Dictionary<string, uint>)(object)Enumerable.ToDictionary<FieldInfo, string, uint>((IEnumerable<>)enumerable, (Func<, >)(object)func, (Func<, >)(object)func2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054C")]
		private Dictionary<string, string> DayMomentsStatesDict
		{
			[Cpp2IlInjected.Token(Token = "0x6002557")]
			[Cpp2IlInjected.Address(RVA = "0xA7E400", Offset = "0xA7CE00", VA = "0x180A7E400")]
			get
			{
				//Discarded unreachable code: IL_0057
				List<AudioManager.DayMomentState> dayMomentStates = SystemRoot.Instance.GetSystem<AudioManager>().DayMomentStates;
				Func<AudioManager.DayMomentState, string> _003C_003E9__4_ = _003C_003Ec._003C_003E9__4_0;
				if (_003C_003E9__4_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new NullReferenceException();
					};
				}
				Func<AudioManager.DayMomentState, string> func = default(Func<AudioManager.DayMomentState, string>);
				if (_003C_003Ec._003C_003E9__4_1 == null)
				{
					func = (Func<AudioManager.DayMomentState, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				return (Dictionary<string, string>)(object)Enumerable.ToDictionary<AudioManager.DayMomentState, string, string>((IEnumerable<>)dayMomentStates, (Func<, >)(object)_003C_003E9__4_, (Func<, >)(object)func);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054D")]
		public string[] Events
		{
			[Cpp2IlInjected.Token(Token = "0x6002558")]
			[Cpp2IlInjected.Address(RVA = "0xA7E710", Offset = "0xA7D110", VA = "0x180A7E710")]
			get
			{
				//Discarded unreachable code: IL_0061
				Type type = new EVENTS().GetType();
				Func<FieldInfo, bool> _003C_003E9__6_ = _003C_003Ec._003C_003E9__6_0;
				if (_003C_003E9__6_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(FieldInfo f)
					{
						//Discarded unreachable code: IL_001a
						Type fieldType = f.FieldType;
						Type typeFromHandle = typeof(uint);
						return ((object)fieldType).Equals((object)typeFromHandle);
					};
				}
				FieldInfo[] array = default(FieldInfo[]);
				IEnumerable<FieldInfo> enumerable = (IEnumerable<FieldInfo>)Enumerable.Where<FieldInfo>((IEnumerable<>)(object)array, (Func<, >)(object)_003C_003E9__6_);
				Func<FieldInfo, string> func = default(Func<FieldInfo, string>);
				if (_003C_003Ec._003C_003E9__6_1 == null)
				{
					func = (Func<FieldInfo, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FieldInfo f) => f.Name.ToLower()));
				}
				return Enumerable.Select<FieldInfo, string>((IEnumerable<>)enumerable, (Func<, >)(object)func).ToArray<string>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054E")]
		public string[] SeasonStates
		{
			[Cpp2IlInjected.Token(Token = "0x6002559")]
			[Cpp2IlInjected.Address(RVA = "0xA7EF20", Offset = "0xA7D920", VA = "0x180A7EF20")]
			get
			{
				//Discarded unreachable code: IL_0011
				return ((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)this.get_SeasonStatesDict()).get_Keys()).ToArray<string>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700054F")]
		public string[] DayMomentsStates
		{
			[Cpp2IlInjected.Token(Token = "0x600255A")]
			[Cpp2IlInjected.Address(RVA = "0xA7E6A0", Offset = "0xA7D0A0", VA = "0x180A7E6A0")]
			get
			{
				//Discarded unreachable code: IL_0011
				return ((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)this.get_DayMomentsStatesDict()).get_Keys()).ToArray<string>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000550")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 58)]
		public float DayNightTime
		{
			[Cpp2IlInjected.Token(Token = "0x600255B")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
			get
			{
				return dayNightTime;
			}
			[Cpp2IlInjected.Token(Token = "0x600255C")]
			[Cpp2IlInjected.Address(RVA = "0xA7F190", Offset = "0xA7DB90", VA = "0x180A7F190")]
			set
			{
				dayNightTime = value;
				AKRESULT aKRESULT = AkSoundEngine.SetRTPCValue(GAME_PARAMETERS.DAY_TIME_RTPC, value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000551")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 69)]
		public bool MuteMusic
		{
			[Cpp2IlInjected.Token(Token = "0x600255D")]
			[Cpp2IlInjected.Address(RVA = "0xA7EAB0", Offset = "0xA7D4B0", VA = "0x180A7EAB0")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				return DebugSettings.Settings.muteMusic_;
			}
			[Cpp2IlInjected.Token(Token = "0x600255E")]
			[Cpp2IlInjected.Address(RVA = "0xA7F410", Offset = "0xA7DE10", VA = "0x180A7F410")]
			set
			{
				//Discarded unreachable code: IL_0027
				SystemRoot.Instance.GetSystem<AudioManager>().DoMuteMusic(value);
				int num = 0;
				DebugSettings settings = DebugSettings.Settings;
				int num2 = 0;
				settings.muteMusic_ = value;
				DebugSettings.Save();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000552")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 82)]
		public bool MuteSfx
		{
			[Cpp2IlInjected.Token(Token = "0x600255F")]
			[Cpp2IlInjected.Address(RVA = "0xA7EB10", Offset = "0xA7D510", VA = "0x180A7EB10")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				return DebugSettings.Settings.muteSfx_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002560")]
			[Cpp2IlInjected.Address(RVA = "0xA7F530", Offset = "0xA7DF30", VA = "0x180A7F530")]
			set
			{
				//Discarded unreachable code: IL_0027
				SystemRoot.Instance.GetSystem<AudioManager>().DoMuteSfx(value);
				int num = 0;
				DebugSettings settings = DebugSettings.Settings;
				int num2 = 0;
				settings.muteSfx_ = value;
				DebugSettings.Save();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000553")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 95)]
		public bool MuteAll
		{
			[Cpp2IlInjected.Token(Token = "0x6002561")]
			[Cpp2IlInjected.Address(RVA = "0xA7EA50", Offset = "0xA7D450", VA = "0x180A7EA50")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				return DebugSettings.Settings.muteAll_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002562")]
			[Cpp2IlInjected.Address(RVA = "0xA7F2F0", Offset = "0xA7DCF0", VA = "0x180A7F2F0")]
			set
			{
				//Discarded unreachable code: IL_0027
				SystemRoot.Instance.GetSystem<AudioManager>().DoMuteAll(value);
				int num = 0;
				DebugSettings settings = DebugSettings.Settings;
				int num2 = 0;
				settings.muteAll_ = value;
				DebugSettings.Save();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000554")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 108)]
		public bool MuteVO
		{
			[Cpp2IlInjected.Token(Token = "0x6002563")]
			[Cpp2IlInjected.Address(RVA = "0xA7EB70", Offset = "0xA7D570", VA = "0x180A7EB70")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				return DebugSettings.Settings.muteVO_;
			}
			[Cpp2IlInjected.Token(Token = "0x6002564")]
			[Cpp2IlInjected.Address(RVA = "0xA7F650", Offset = "0xA7E050", VA = "0x180A7F650")]
			set
			{
				//Discarded unreachable code: IL_0027
				SystemRoot.Instance.GetSystem<AudioManager>().DoMuteVO(value);
				int num = 0;
				DebugSettings settings = DebugSettings.Settings;
				int num2 = 0;
				settings.muteVO_ = value;
				DebugSettings.Save();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000555")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 122)]
		public int DayMomentState
		{
			[Cpp2IlInjected.Token(Token = "0x6002565")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get
			{
				return dayMomentState;
			}
			[Cpp2IlInjected.Token(Token = "0x6002566")]
			[Cpp2IlInjected.Address(RVA = "0xA7EFC0", Offset = "0xA7D9C0", VA = "0x180A7EFC0")]
			set
			{
				//Discarded unreachable code: IL_0034, IL_0038, IL_0054
				if (dayMomentState != value)
				{
					dayMomentState = value;
					string text = ((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)this.get_DayMomentsStatesDict()).get_Keys()).ToArray<string>()[value];
					Dictionary<string, string> dayMomentsStatesDict = (Dictionary<string, string>)(object)this.get_DayMomentsStatesDict();
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000556")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 138)]
		public int SeasonState
		{
			[Cpp2IlInjected.Token(Token = "0x6002567")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return wwiseSeasonState;
			}
			[Cpp2IlInjected.Token(Token = "0x6002568")]
			[Cpp2IlInjected.Address(RVA = "0xA7F770", Offset = "0xA7E170", VA = "0x180A7F770")]
			set
			{
				if (wwiseSeasonState != value)
				{
					wwiseSeasonState = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000557")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 151)]
		public int Event
		{
			[Cpp2IlInjected.Token(Token = "0x6002569")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get
			{
				return wwiseEvent;
			}
			[Cpp2IlInjected.Token(Token = "0x600256A")]
			[Cpp2IlInjected.Address(RVA = "0xA7F240", Offset = "0xA7DC40", VA = "0x180A7F240")]
			set
			{
				if (wwiseEvent != value)
				{
					wwiseEvent = value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000558")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 197)]
		public bool IsVerboseAudioEmitCullMgr
		{
			[Cpp2IlInjected.Token(Token = "0x600256E")]
			[Cpp2IlInjected.Address(RVA = "0xA7E9B0", Offset = "0xA7D3B0", VA = "0x180A7E9B0")]
			get
			{
				return AudioEmitterCullingManager.IsDebugVerbose;
			}
			[Cpp2IlInjected.Token(Token = "0x600256F")]
			[Cpp2IlInjected.Address(RVA = "0xA7F250", Offset = "0xA7DC50", VA = "0x180A7F250")]
			set
			{
				AudioEmitterCullingManager.IsDebugVerbose = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000559")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 204)]
		public int AkGameObjNumIdleUpdatePerFrame
		{
			[Cpp2IlInjected.Token(Token = "0x6002570")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3E0", Offset = "0xA7CDE0", VA = "0x180A7E3E0")]
			get
			{
				//Discarded unreachable code: IL_000d
				int num = 0;
				return DDVAkGameObjUpdateManager.Instance.NumIdleUpdatePerFrame;
			}
			[Cpp2IlInjected.Token(Token = "0x6002571")]
			[Cpp2IlInjected.Address(RVA = "0xA7EF90", Offset = "0xA7D990", VA = "0x180A7EF90")]
			set
			{
				//Discarded unreachable code: IL_000e
				int num = 0;
				DDVAkGameObjUpdateManager.Instance.NumIdleUpdatePerFrame = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600256B")]
		[Cpp2IlInjected.Address(RVA = "0xA7DFA0", Offset = "0xA7C9A0", VA = "0x180A7DFA0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 164)]
		public void LogWwise()
		{
			//IL_0013: Expected O, but got I4
			int num = 0;
			bool flag = AkSoundEngine.IsInitialized();
			string text = $"WWISE is Initialized: {flag}";
		}

		[Cpp2IlInjected.Token(Token = "0x600256C")]
		[Cpp2IlInjected.Address(RVA = "0xA7E080", Offset = "0xA7CA80", VA = "0x180A7E080")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 174)]
		public void PostEvent()
		{
			//Discarded unreachable code: IL_008a
			//IL_0010: Expected O, but got I4
			//IL_005f: Expected I4, but got O
			GameObject gameObject = soundObject;
			int num = 0;
			if (gameObject == (UnityEngine.Object)num)
			{
				GameObject gameObject2 = (soundObject = new GameObject());
			}
			int num2 = 0;
			AkSoundEngine.StopAll();
			Dictionary<string, uint> seasonStatesDict = (Dictionary<string, uint>)(object)this.get_SeasonStatesDict();
			string[] array = ((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)this.get_SeasonStatesDict()).get_Keys()).ToArray<string>();
			int num3 = wwiseSeasonState;
			string key = array[num3];
			uint num4 = (uint)(int)((Dictionary<TKey, TValue>)(object)seasonStatesDict)[(TKey)key];
			string[] events = Events;
			int num5 = wwiseEvent;
			GameObject in_gameObjectID = soundObject;
			uint num6 = AkSoundEngine.PostEvent(events[num5], in_gameObjectID);
		}

		[Cpp2IlInjected.Token(Token = "0x600256D")]
		[Cpp2IlInjected.Address(RVA = "0xA7E2A0", Offset = "0xA7CCA0", VA = "0x180A7E2A0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatSound.cs", 187)]
		public void TryKillingWwiseEngine()
		{
			//Discarded unreachable code: IL_0018
			((Mdl.Systems.System)SystemRoot.Instance.GetSystem<AudioManager>()).OnDestroy();
			int num = 0;
			AKRESULT aKRESULT = AkSoundEngine.UnregisterAllGameObj();
		}

		[Cpp2IlInjected.Token(Token = "0x6002572")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public CheatSound()
		{
		}
	}
}
