using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Missions;
using Definitions.Scene;
using Definitions.Util;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Activities;
using Mdl.Characters;
using Mdl.Environments;
using Mdl.Ftue.Cutscenes;
using Mdl.Graphic.Weather;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Collections;
using Meta.Online;
using Meta.Util;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000AF1")]
	public class AudioManager : Mdl.Systems.System
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000AF2")]
		public struct VOGeneralExpressionSwitch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003D16")]
			public string expressionID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003D17")]
			public Switch expressionSwitch;
		}

		[Cpp2IlInjected.Token(Token = "0x2000AF3")]
		public enum GameState
		{
			[Cpp2IlInjected.Token(Token = "0x4003D19")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4003D1A")]
			MainMenu,
			[Cpp2IlInjected.Token(Token = "0x4003D1B")]
			SplashScreen,
			[Cpp2IlInjected.Token(Token = "0x4003D1C")]
			MenuStartCustomization,
			[Cpp2IlInjected.Token(Token = "0x4003D1D")]
			IngameExplor,
			[Cpp2IlInjected.Token(Token = "0x4003D1E")]
			IntroCinematic,
			[Cpp2IlInjected.Token(Token = "0x4003D1F")]
			IntroVillage,
			[Cpp2IlInjected.Token(Token = "0x4003D20")]
			Dialogue,
			[Cpp2IlInjected.Token(Token = "0x4003D21")]
			LaunchMenu,
			[Cpp2IlInjected.Token(Token = "0x4003D22")]
			ChestOpen,
			[Cpp2IlInjected.Token(Token = "0x4003D23")]
			RenderedCinematic,
			[Cpp2IlInjected.Token(Token = "0x4003D24")]
			IngameCinematic
		}

		[Cpp2IlInjected.Token(Token = "0x2000AF4")]
		public enum Location
		{
			[Cpp2IlInjected.Token(Token = "0x4003D26")]
			Castle,
			[Cpp2IlInjected.Token(Token = "0x4003D27")]
			DarkMountains,
			[Cpp2IlInjected.Token(Token = "0x4003D28")]
			PhoneIcone,
			[Cpp2IlInjected.Token(Token = "0x4003D29")]
			SocialChallenge,
			[Cpp2IlInjected.Token(Token = "0x4003D2A")]
			IPRealms,
			[Cpp2IlInjected.Token(Token = "0x4003D2B")]
			IPHouses,
			[Cpp2IlInjected.Token(Token = "0x4003D2C")]
			Village,
			[Cpp2IlInjected.Token(Token = "0x4003D2D")]
			CharactersUnlock,
			[Cpp2IlInjected.Token(Token = "0x4003D2E")]
			DarkForest,
			[Cpp2IlInjected.Token(Token = "0x4003D2F")]
			PlateauMine,
			[Cpp2IlInjected.Token(Token = "0x4003D30")]
			DarkCastle
		}

		[Cpp2IlInjected.Token(Token = "0x2000AF5")]
		public enum AudioMinigameType
		{
			[Cpp2IlInjected.Token(Token = "0x4003D32")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4003D33")]
			Coin,
			[Cpp2IlInjected.Token(Token = "0x4003D34")]
			Harvest,
			[Cpp2IlInjected.Token(Token = "0x4003D35")]
			Fish,
			[Cpp2IlInjected.Token(Token = "0x4003D36")]
			Mineral
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000AF6")]
		public struct SeasonSwitcher
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003D37")]
			public Season season;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003D38")]
			public Switch switcher;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000AF7")]
		public struct DayMomentState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003D39")]
			public State state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003D3A")]
			public string start_time;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003D3B")]
			public string end_time;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000AF8")]
		public struct GameStateWwise
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003D3C")]
			public GameState gameState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003D3D")]
			public State state;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000AF9")]
		public struct LocationWwise
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003D3E")]
			public Location location;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003D3F")]
			public State state;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000AFA")]
		public struct LocationWwiseAreaOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003D40")]
			public VillageAreaType villageArea;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003D41")]
			public State state;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000AFB")]
		public struct HangoutWwise
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003D42")]
			[SerializeField]
			[ItemID]
			public int ipTag;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003D43")]
			public State ipHangout;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000AFC")]
		public struct HangoutWwiseOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003D44")]
			[ItemID]
			[SerializeField]
			public int character_Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003D45")]
			public State state_hangout;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000AFD")]
		public struct HangoutObjEvent
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003D46")]
			[SerializeField]
			[ItemID]
			public int character_Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003D47")]
			public AK.Wwise.Event char_event;
		}

		[Cpp2IlInjected.Token(Token = "0x2000AFE")]
		public delegate void CutsceneAudioPop(Cutscene cutscene);

		[Cpp2IlInjected.Token(Token = "0x2000AFF")]
		public delegate void AudioEventTriggered(string audioEventTriggered);

		[Cpp2IlInjected.Token(Token = "0x2000B00")]
		public delegate void VillageTypeChanged(VillageAreaType villageType);

		[Cpp2IlInjected.Token(Token = "0x2000B01")]
		public struct GameStateScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003D48")]
			private readonly AudioManager manager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003D49")]
			private bool startedDiscussion;

			[Cpp2IlInjected.Token(Token = "0x60032CB")]
			[Cpp2IlInjected.Address(RVA = "0x156AE00", Offset = "0x1569800", VA = "0x18156AE00")]
			public GameStateScope(AudioManager manager, GameState gameState, Mdl.Characters.Character character, List<uint> disabledVOs)
			{
				//Discarded unreachable code: IL_0035
				//IL_0017: Expected O, but got I4
				//IL_0023: Expected O, but got I4
				startedDiscussion = false;
				this.manager = manager;
				int num = 0;
				if (manager != (UnityEngine.Object)num)
				{
					int num2 = 0;
					if (character != (UnityEngine.Object)num2)
					{
						manager.DiscussionCharacter = character;
						startedDiscussion = true;
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60032CC")]
			[Cpp2IlInjected.Address(RVA = "0x156ADB0", Offset = "0x15697B0", VA = "0x18156ADB0", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_0011, IL_0012
				if (startedDiscussion)
				{
					startedDiscussion = false;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000B02")]
		public struct InFTUEScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003D4A")]
			private readonly AudioManager manager;

			[Cpp2IlInjected.Token(Token = "0x60032CD")]
			[Cpp2IlInjected.Address(RVA = "0x156AF80", Offset = "0x1569980", VA = "0x18156AF80")]
			public InFTUEScope(AudioManager manager)
			{
				//Discarded unreachable code: IL_001b
				//IL_0010: Expected O, but got I4
				this.manager = manager;
				int num = 0;
				if (manager != (UnityEngine.Object)num)
				{
					manager.InFTUESequence = true;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60032CE")]
			[Cpp2IlInjected.Address(RVA = "0x156AF00", Offset = "0x1569900", VA = "0x18156AF00", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_0005
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003CA1")]
		[Header("Banks")]
		public List<BankLoadConditionEvent> banksToLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003CA2")]
		private Dictionary<uint, AudioEmitterBankLoader> AudioEmitterBankLoaders = (Dictionary<uint, AudioEmitterBankLoader>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003CA3")]
		[Space]
		[Header("Foot Steps")]
		[Space(10f)]
		public Switch DefaultFootStepGroundType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003CA4")]
		public Switch ShoeWetStepSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003CA5")]
		public Switch ShoeDryStepSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003CA6")]
		public List<FootStepEnumEntryObj> SwitcherMapListObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003CA7")]
		public List<FootStepEnumEntry> SwitcherMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003CA8")]
		public List<AudioSurfaceEnumSwitchMap> AudioSurfaceEnumMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003CAA")]
		private Dictionary<int, Switch> FootstepSwitchDictObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003CAB")]
		private Dictionary<GridFloorType, Switch> FootstepSwitchDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003CAC")]
		private Dictionary<AudioSurfaceType, Switch> AudioSurfaceEnumMapDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003CAD")]
		private bool UseVillageRain;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4003CAE")]
		[SerializeField]
		[Space]
		[Space(10f)]
		[Header("Bark")]
		private Switch vo_call_to_action;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4003CAF")]
		[SerializeField]
		private Switch vo_environment;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4003CB0")]
		[SerializeField]
		private float barkVOCooldown = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4003CB1")]
		private DateTime startVOBarkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4003CB2")]
		[Space]
		[SerializeField]
		[Header("Dialogue General Expressions")]
		[Space(10f)]
		private Switch vo_introduction;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4003CB3")]
		[SerializeField]
		private Switch vo_new;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4003CB4")]
		[SerializeField]
		private Switch vo_repeated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4003CB5")]
		[SerializeField]
		private Switch vo_closing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4003CB6")]
		[SerializeField]
		private Switch vo_rewards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4003CB7")]
		[SerializeField]
		private Switch vo_humming;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4003CB8")]
		[Space]
		[SerializeField]
		private VOGeneralExpressionSwitch[] expressionsSwitches;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4003CB9")]
		private int dicussionCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4003CBB")]
		[Space]
		[Space(10f)]
		[Header("Humming")]
		public float hummingMaximumRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4003CBC")]
		public float hummingMinimumRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4003CBD")]
		public float hummingMinimumCooldown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4003CBE")]
		public float hummingMaximumCooldown;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4003CBF")]
		private bool? SkipNextEndVOEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13A")]
		[Cpp2IlInjected.Token(Token = "0x4003CC0")]
		private bool levelingUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4003CC1")]
		private List<uint> allDisabledVOs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4003CC2")]
		private Mdl.Characters.Character discussionCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4003CC4")]
		private CancellationTokenProvider cancellationTokenProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4003CC6")]
		[Header("Wwise")]
		public AK.Wwise.Event MuteMusic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4003CC7")]
		public AK.Wwise.Event UnmuteMusic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4003CC8")]
		public AK.Wwise.Event MuteSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4003CC9")]
		public AK.Wwise.Event UnmuteSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4003CCA")]
		public AK.Wwise.Event MuteAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4003CCB")]
		public AK.Wwise.Event UnmuteAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4003CCC")]
		public AK.Wwise.Event MuteVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4003CCD")]
		public AK.Wwise.Event UnmuteVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4003CCE")]
		public AK.Wwise.Event MusicEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4003CCF")]
		[Header("Radio")]
		public AK.Wwise.Event startRadio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4003CD0")]
		public AK.Wwise.Event pauseRadio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4003CD1")]
		public AK.Wwise.Event resumeRadio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4003CD2")]
		public GameObject houseRadio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4003CD3")]
		public bool houseRadioAdded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4003CD4")]
		public GameObject otherRadio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4003CD5")]
		[Header("Mining")]
		public AK.Wwise.Event miningRockDestroyed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4003CD6")]
		public AK.Wwise.Event miningRockSpecialReveal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4003CD7")]
		[Header("Minigame")]
		public AK.Wwise.Event criticalSuccessLootSpawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4003CD8")]
		public State minigameOnAudioState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4003CD9")]
		public AK.Wwise.Event minigameFailSFXEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4003CDA")]
		public AK.Wwise.Event minigameCompletedSFXEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4003CDB")]
		public State minigameHarvestOnAudioState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4003CDC")]
		public AK.Wwise.Event minigameHarvestCompletedSFXEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4003CDD")]
		[Header("DayTime")]
		public RTPC DayTimeRTPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4003CDE")]
		public int updateTimeIntervalSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4003CDF")]
		public List<SeasonSwitcher> Seasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4003CE0")]
		public List<DayMomentState> DayMomentStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4003CE1")]
		[Header("Misc")]
		public AK.Wwise.Event rewardGroundSpawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4003CE2")]
		public RTPC cursedFogDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4003CE3")]
		public int curseFogRTPCCheckInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4003CE4")]
		public AK.Wwise.Event cutsceneSkipped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4003CE5")]
		public State notInCutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4003CE6")]
		public State defaultRainState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4003CE7")]
		public State defaultNoRainState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4003CE8")]
		public State IP_State_None;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4003CEA")]
		public AK.Wwise.Event mMemoryCollectionComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4003CEB")]
		public AK.Wwise.Event weedTreasureSpawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4003CEC")]
		public AK.Wwise.Event miningTreasureSpawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4003CED")]
		public float bankLoaderUpdateIntervalSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4003CEE")]
		[SerializeField]
		private State broken_village_state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4003CEF")]
		[SerializeField]
		private State normal_village_state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4003CF0")]
		[SerializeField]
		private State limbo_village_state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4003CF1")]
		[SerializeField]
		private int normalStateCastleLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4003CF2")]
		[SerializeField]
		[Header("States")]
		private State no_game_state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4003CF3")]
		[SerializeField]
		private GameStateWwise[] gameStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4003CF4")]
		[SerializeField]
		private LocationWwise[] locations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4003CF5")]
		[SerializeField]
		private LocationWwiseAreaOverride[] villageLocationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4003CF6")]
		[SerializeField]
		[Header("Hangout")]
		private AK.Wwise.Event startHangout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4003CF7")]
		[SerializeField]
		private AK.Wwise.Event stopHangout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4003CF8")]
		[SerializeField]
		private HangoutWwise[] hangout_states;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4003CF9")]
		[SerializeField]
		private HangoutWwiseOverride[] hangout_char_overrided;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4003CFA")]
		[SerializeField]
		private HangoutObjEvent[] hangout_obj_char;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4003CFB")]
		[Header("SceneSwitch")]
		public AK.Wwise.Event sceneChangeStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4003CFC")]
		public AK.Wwise.Event sceneChangeEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4003CFD")]
		[Header("SpecialEvents")]
		public State NoSpecialEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4003CFE")]
		[SerializeField]
		public List<AudioSpecialEvent> SpecialEventsAudio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4003CFF")]
		private Dictionary<string, GameObject> radioGameObjs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4003D00")]
		private bool hangoutActive;

		[Cpp2IlInjected.Token(Token = "0x4003D01")]
		private static GameObject avatarAudioListener;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4003D02")]
		private AudioStateStack GameStateStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4003D03")]
		private AudioStateStack LocationStateStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4003D04")]
		private Dictionary<GameState, State> GameStateDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4003D05")]
		private Dictionary<Location, State> LocationDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4003D06")]
		private Dictionary<VillageAreaType, State> LocationAreaOverrideDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4003D07")]
		private Dictionary<int, State> HangoutsDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4003D08")]
		private Dictionary<Item, State> HangoutsDictCharOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4003D09")]
		private Dictionary<Item, AK.Wwise.Event> HangoutsObjDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4003D0A")]
		private Dictionary<string, Switch> ExpressionSwitchesDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4003D0B")]
		private Dictionary<int, string> characterLastExpressionUsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x4003D0D")]
		private AudioMinigameType typeMinigameStarted;

		[Cpp2IlInjected.Token(Token = "0x4003D11")]
		private static Dictionary<string, string> culture2folder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4003D12")]
		private int unloadCutsceneBankDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4003D13")]
		private string currentHouseRadioChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4003D14")]
		private float bankLoaderTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x4003D15")]
		private VillageAreaType currentAreaType;

		[Cpp2IlInjected.Token(Token = "0x170006F3")]
		public Switch DefaultFootStepSwitch
		{
			[Cpp2IlInjected.Token(Token = "0x6003259")]
			[Cpp2IlInjected.Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
			[CompilerGenerated]
			get
			{
				return _003CDefaultFootStepSwitch_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600325A")]
			[Cpp2IlInjected.Address(RVA = "0x824270", Offset = "0x822C70", VA = "0x180824270")]
			[CompilerGenerated]
			set
			{
				_003CDefaultFootStepSwitch_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x124"), Cpp2IlInjected.Token(Token = "0x4003CBA")]
		public bool MissionComplete
		{
			[Cpp2IlInjected.Token(Token = "0x6003264")]
			[Cpp2IlInjected.Address(RVA = "0xA5A5D0", Offset = "0xA58FD0", VA = "0x180A5A5D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003265")]
			[Cpp2IlInjected.Address(RVA = "0xA5A940", Offset = "0xA59340", VA = "0x180A5A940")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170006F5")]
		public Mdl.Characters.Character DiscussionCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6003266")]
			[Cpp2IlInjected.Address(RVA = "0x738F60", Offset = "0x737960", VA = "0x180738F60")]
			get
			{
				return discussionCharacter;
			}
			[Cpp2IlInjected.Token(Token = "0x6003267")]
			[Cpp2IlInjected.Address(RVA = "0xA5A8F0", Offset = "0xA592F0", VA = "0x180A5A8F0")]
			set
			{
				//IL_0010: Expected I4, but got I8
				discussionCharacter = value;
				dicussionCounter = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x150"), Cpp2IlInjected.Token(Token = "0x4003CC3")]
		public bool SkipEndVo
		{
			[Cpp2IlInjected.Token(Token = "0x600326C")]
			[Cpp2IlInjected.Address(RVA = "0xA5A5E0", Offset = "0xA58FE0", VA = "0x180A5A5E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600326D")]
			[Cpp2IlInjected.Address(RVA = "0xA5A950", Offset = "0xA59350", VA = "0x180A5A950")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170006F7")]
		public State ActiveDayMomentState
		{
			[Cpp2IlInjected.Token(Token = "0x6003278")]
			[Cpp2IlInjected.Address(RVA = "0x738EC0", Offset = "0x7378C0", VA = "0x180738EC0")]
			[CompilerGenerated]
			get
			{
				return _003CActiveDayMomentState_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003279")]
			[Cpp2IlInjected.Address(RVA = "0x739EB0", Offset = "0x7388B0", VA = "0x180739EB0")]
			[CompilerGenerated]
			set
			{
				_003CActiveDayMomentState_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x280"), Cpp2IlInjected.Token(Token = "0x4003CE9")]
		public bool? IsUnlockCurseLight
		{
			[Cpp2IlInjected.Token(Token = "0x600327A")]
			[Cpp2IlInjected.Address(RVA = "0xA5A5C0", Offset = "0xA58FC0", VA = "0x180A5A5C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600327B")]
			[Cpp2IlInjected.Address(RVA = "0xA5A930", Offset = "0xA59330", VA = "0x180A5A930")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170006F9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x390"), Cpp2IlInjected.Token(Token = "0x4003D0C")]
		public bool InFTUESequence
		{
			[Cpp2IlInjected.Token(Token = "0x600327C")]
			[Cpp2IlInjected.Address(RVA = "0xA5A5B0", Offset = "0xA58FB0", VA = "0x180A5A5B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600327D")]
			[Cpp2IlInjected.Address(RVA = "0xA5A920", Offset = "0xA59320", VA = "0x180A5A920")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000082")]
		public static event CutsceneAudioPop OnCutsceneAudioPop
		{
			[Cpp2IlInjected.Token(Token = "0x600327E")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3B0", Offset = "0xA58DB0", VA = "0x180A5A3B0")]
			[CompilerGenerated]
			add
			{
				CutsceneAudioPop onCutsceneAudioPop = AudioManager.OnCutsceneAudioPop;
				Delegate @delegate = Delegate.Combine(onCutsceneAudioPop, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onCutsceneAudioPop)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600327F")]
			[Cpp2IlInjected.Address(RVA = "0xA5A6F0", Offset = "0xA590F0", VA = "0x180A5A6F0")]
			[CompilerGenerated]
			remove
			{
				CutsceneAudioPop onCutsceneAudioPop = AudioManager.OnCutsceneAudioPop;
				Delegate @delegate = Delegate.Remove(onCutsceneAudioPop, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onCutsceneAudioPop)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000083")]
		public static event AudioEventTriggered OnAudioEventTriggered
		{
			[Cpp2IlInjected.Token(Token = "0x6003280")]
			[Cpp2IlInjected.Address(RVA = "0xA5A2B0", Offset = "0xA58CB0", VA = "0x180A5A2B0")]
			[CompilerGenerated]
			add
			{
				AudioEventTriggered onAudioEventTriggered = AudioManager.OnAudioEventTriggered;
				Delegate @delegate = Delegate.Combine(onAudioEventTriggered, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onAudioEventTriggered)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003281")]
			[Cpp2IlInjected.Address(RVA = "0xA5A5F0", Offset = "0xA58FF0", VA = "0x180A5A5F0")]
			[CompilerGenerated]
			remove
			{
				AudioEventTriggered onAudioEventTriggered = AudioManager.OnAudioEventTriggered;
				Delegate @delegate = Delegate.Remove(onAudioEventTriggered, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onAudioEventTriggered)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000084")]
		public static event VillageTypeChanged OnVillageTypeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6003282")]
			[Cpp2IlInjected.Address(RVA = "0xA5A4B0", Offset = "0xA58EB0", VA = "0x180A5A4B0")]
			[CompilerGenerated]
			add
			{
				VillageTypeChanged onVillageTypeChanged = AudioManager.OnVillageTypeChanged;
				Delegate @delegate = Delegate.Combine(onVillageTypeChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onVillageTypeChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003283")]
			[Cpp2IlInjected.Address(RVA = "0xA5A7F0", Offset = "0xA591F0", VA = "0x180A5A7F0")]
			[CompilerGenerated]
			remove
			{
				VillageTypeChanged onVillageTypeChanged = AudioManager.OnVillageTypeChanged;
				Delegate @delegate = Delegate.Remove(onVillageTypeChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onVillageTypeChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003253")]
		[Cpp2IlInjected.Address(RVA = "0xA57440", Offset = "0xA55E40", VA = "0x180A57440")]
		public void StartBanks()
		{
			//Discarded unreachable code: IL_0064
			//IL_0020: Expected O, but got I4
			//IL_0020: Expected O, but got I4
			if ((long)SystemRoot.Instance.MetaClient.profile != 0)
			{
				int num = 0;
				int num2 = 0;
				OnInitialLoginCompleted((Profile)num2, (CancellationToken)num);
				return;
			}
			Meta.Online.Client metaClient = SystemRoot.Instance.MetaClient;
			Meta.Online.Client.InitialLoginCompleted value = OnInitialLoginCompleted;
			metaClient.OnInitialLoginCompleted -= value;
			Meta.Online.Client metaClient2 = SystemRoot.Instance.MetaClient;
			Meta.Online.Client.InitialLoginCompleted value2 = OnInitialLoginCompleted;
			metaClient2.OnInitialLoginCompleted += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003254")]
		[Cpp2IlInjected.Address(RVA = "0xA535F0", Offset = "0xA51FF0", VA = "0x180A535F0")]
		private void OnInitialLoginCompleted(Profile profile, CancellationToken ct)
		{
			//Discarded unreachable code: IL_002e
			int num = 0;
			Meta.Online.Client metaClient = SystemRoot.Instance.MetaClient;
			Meta.Online.Client.InitialLoginCompleted value = OnInitialLoginCompleted;
			metaClient.OnInitialLoginCompleted -= value;
			List<BankLoadConditionEvent> list = banksToLoad;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003255")]
		[Cpp2IlInjected.Address(RVA = "0xA52380", Offset = "0xA50D80", VA = "0x180A52380")]
		public void LoadBankWithTag(string bankTag)
		{
			//Discarded unreachable code: IL_0034
			List<BankLoadConditionEvent> list = banksToLoad;
			Func<BankLoadConditionEvent, bool> func = (Func<BankLoadConditionEvent, bool>)(object)(Func<T, TResult>)delegate(BankLoadConditionEvent x)
			{
				//Discarded unreachable code: IL_0014
				string b = bankTag;
				return string.Equals(x.tag, b);
			};
			Enumerable.FirstOrDefault<BankLoadConditionEvent>((IEnumerable<>)list, (Func<, >)(object)func)?.ForceLoadBank();
		}

		[Cpp2IlInjected.Token(Token = "0x6003256")]
		[Cpp2IlInjected.Address(RVA = "0xA52880", Offset = "0xA51280", VA = "0x180A52880")]
		public void OnDestroyBanks()
		{
			//Discarded unreachable code: IL_000c
			List<BankLoadConditionEvent> list = banksToLoad;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003257")]
		[Cpp2IlInjected.Address(RVA = "0xA514F0", Offset = "0xA4FEF0", VA = "0x180A514F0")]
		public AudioEmitterBankLoader GetAudioBankLoader(Bank bank)
		{
			//Discarded unreachable code: IL_0014, IL_0018, IL_0035, IL_004f
			//IL_004e: Expected O, but got I4
			Dictionary<uint, AudioEmitterBankLoader> audioEmitterBankLoaders = AudioEmitterBankLoaders;
			uint id = bank.Id;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003258")]
		[Cpp2IlInjected.Address(RVA = "0xA59360", Offset = "0xA57D60", VA = "0x180A59360")]
		public void UpdateBanksLoaders()
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0018
			Dictionary<uint, AudioEmitterBankLoader> audioEmitterBankLoaders = AudioEmitterBankLoaders;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600325B")]
		[Cpp2IlInjected.Address(RVA = "0xA57810", Offset = "0xA56210", VA = "0x180A57810")]
		private void StartFS()
		{
			List<FootStepEnumEntryObj> switcherMapListObj = SwitcherMapListObj;
			Func<FootStepEnumEntryObj, int> _003C_003E9__22_ = _003C_003Ec._003C_003E9__22_0;
			if (_003C_003E9__22_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FootStepEnumEntryObj f) => f.itemID);
			}
			Func<FootStepEnumEntryObj, Switch> func = default(Func<FootStepEnumEntryObj, Switch>);
			if (_003C_003Ec._003C_003E9__22_1 == null)
			{
				func = (Func<FootStepEnumEntryObj, Switch>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FootStepEnumEntryObj f) => f.eventType));
			}
			Dictionary<FootStepEnumEntryObj, int> dictionary = (Dictionary<FootStepEnumEntryObj, int>)(object)(FootstepSwitchDictObj = (Dictionary<int, Switch>)(object)Enumerable.ToDictionary<FootStepEnumEntryObj, int, Switch>((IEnumerable<>)switcherMapListObj, (Func<, >)(object)_003C_003E9__22_, (Func<, >)(object)func));
			List<FootStepEnumEntry> switcherMapList = SwitcherMapList;
			Func<FootStepEnumEntry, GridFloorType> func2 = default(Func<FootStepEnumEntry, GridFloorType>);
			if (_003C_003Ec._003C_003E9__22_2 == null)
			{
				func2 = (Func<FootStepEnumEntry, GridFloorType>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FootStepEnumEntry f) => f.type));
			}
			Func<FootStepEnumEntry, Switch> func3 = default(Func<FootStepEnumEntry, Switch>);
			if (_003C_003Ec._003C_003E9__22_3 == null)
			{
				func3 = (Func<FootStepEnumEntry, Switch>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((FootStepEnumEntry f) => f.eventType));
			}
			Dictionary<FootStepEnumEntry, GridFloorType> dictionary2 = (Dictionary<FootStepEnumEntry, GridFloorType>)(object)(FootstepSwitchDict = (Dictionary<GridFloorType, Switch>)(object)Enumerable.ToDictionary<FootStepEnumEntry, GridFloorType, Switch>((IEnumerable<>)switcherMapList, (Func<, >)(object)func2, (Func<, >)(object)func3));
			List<AudioSurfaceEnumSwitchMap> audioSurfaceEnumMapList = AudioSurfaceEnumMapList;
			Func<AudioSurfaceEnumSwitchMap, AudioSurfaceType> func4 = default(Func<AudioSurfaceEnumSwitchMap, AudioSurfaceType>);
			if (_003C_003Ec._003C_003E9__22_4 == null)
			{
				func4 = (Func<AudioSurfaceEnumSwitchMap, AudioSurfaceType>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AudioSurfaceEnumSwitchMap f) => f.audioSurfaceType));
			}
			Func<AudioSurfaceEnumSwitchMap, Switch> func5 = default(Func<AudioSurfaceEnumSwitchMap, Switch>);
			if (_003C_003Ec._003C_003E9__22_5 == null)
			{
				func5 = (Func<AudioSurfaceEnumSwitchMap, Switch>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AudioSurfaceEnumSwitchMap f) => f.audioFloorSwitch));
			}
			Dictionary<AudioSurfaceEnumSwitchMap, AudioSurfaceType> dictionary3 = (Dictionary<AudioSurfaceEnumSwitchMap, AudioSurfaceType>)(object)(AudioSurfaceEnumMapDict = (Dictionary<AudioSurfaceType, Switch>)(object)Enumerable.ToDictionary<AudioSurfaceEnumSwitchMap, AudioSurfaceType, Switch>((IEnumerable<>)audioSurfaceEnumMapList, (Func<, >)(object)func4, (Func<, >)(object)func5));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600325C")]
		[Cpp2IlInjected.Address(RVA = "0xA518C0", Offset = "0xA502C0", VA = "0x180A518C0")]
		public unsafe Switch GetSceneDefaultFootstep()
		{
			//IL_0064: Expected O, but got I4
			//IL_0064: Expected O, but got I4
			//IL_0087: Expected O, but got I4
			int num = 0;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneStack sceneStack2 = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			if ((object)gameObject != null)
			{
				PlayerHouseEnvironment component = gameObject.GetComponent<PlayerHouseEnvironment>();
				if ((object)component != null)
				{
					GameObject activeRoom = component.ActiveRoom;
					if ((object)activeRoom != null)
					{
						FlooringSetter componentInChildren = activeRoom.GetComponentInChildren<FlooringSetter>();
					}
				}
			}
			int num2 = 0;
			TrimmingItemData trimmingItemData = default(TrimmingItemData);
			if (!((UnityEngine.Object)num == (UnityEngine.Object)num2) && trimmingItemData != null)
			{
				Dictionary<AudioSurfaceType, Switch> audioSurfaceEnumMapDict = AudioSurfaceEnumMapDict;
				AudioSurfaceType audioSurfaceType_ = trimmingItemData.audioSurfaceType_;
				bool flag = ((Dictionary<TKey, TValue>)(object)audioSurfaceEnumMapDict).TryGetValue((TKey)audioSurfaceType_, out *(TValue*)num);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600325D")]
		[Cpp2IlInjected.Address(RVA = "0xA51750", Offset = "0xA50150", VA = "0x180A51750")]
		public unsafe GridFloorType GetFloorType(GridScript grid, Vector3 footPosition)
		{
			int num = 0;
			if ((object)grid != null && (IntPtr)grid.Grid != (IntPtr)num)
			{
				int allowInvalid = 0;
				GridPosition gridPosition = grid.GetGridPosition(in *(Vector3*)footPosition, 1, (byte)allowInvalid != 0);
				GridData gridData = grid.GridData;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600325E")]
		[Cpp2IlInjected.Address(RVA = "0xA517C0", Offset = "0xA501C0", VA = "0x180A517C0")]
		public Switch GetFootStepGroundType(GridFloorType floorType)
		{
			Dictionary<GridFloorType, Switch> footstepSwitchDict = FootstepSwitchDict;
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600325F")]
		[Cpp2IlInjected.Address(RVA = "0xA56AD0", Offset = "0xA554D0", VA = "0x180A56AD0")]
		public void SetRainFootStepState(GameObject audioEmitter)
		{
			//IL_001e: Expected O, but got I4
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			int num = 0;
			if (!WeatherController.IsRaining)
			{
				int num2 = 0;
				if (!CheckRainInModifiers((WeatherTimeline)num2))
				{
					ShoeDryStepSwitch.SetValue(audioEmitter);
					return;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003260")]
		[Cpp2IlInjected.Address(RVA = "0xA52E70", Offset = "0xA51870", VA = "0x180A52E70")]
		public unsafe bool OnFootStepOnGroundAlteration(GridScript grid, Vector3 footPosition, GameObject audioEmitter)
		{
			//Discarded unreachable code: IL_0055, IL_005b
			//IL_0046: Expected O, but got I4
			GridPosition gridPosition = default(GridPosition);
			bool flag = default(bool);
			ItemType itemType = default(ItemType);
			FurnitureItemType furnitureItemType = default(FurnitureItemType);
			while (true)
			{
				int num = 0;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item gardeningTileItem = CreateGardeningTile.GardeningTileItem;
				IGridPlaceableItemData itemData = _003CInstance_003Ek__BackingField.GetItemData<IGridPlaceableItemData>(gardeningTileItem);
				int num2 = 0;
				if (grid.GetGridObjectsForPosition(ref *(GridPosition*)gridPosition, (byte)num2 != 0) == null)
				{
					break;
				}
				if (flag)
				{
					while (itemType != ItemType.Furniture)
					{
					}
					int num3 = 0;
					while (furnitureItemType != FurnitureItemType.GroundAlteration)
					{
					}
					if (!((Dictionary<TKey, TValue>)(object)FootstepSwitchDictObj).TryGetValue((TKey)num3, out *(TValue*)num))
					{
						continue;
					}
				}
				if (num == 0)
				{
					break;
				}
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003261")]
		[Cpp2IlInjected.Address(RVA = "0xA566E0", Offset = "0xA550E0", VA = "0x180A566E0")]
		internal void SetEnviromentAudio(Location audioLocation, AK.Wwise.Event sfxAmbient, Switch defaultFootStepSwitch, bool useVillageRain)
		{
			//Discarded unreachable code: IL_0024
			PushLocation(audioLocation);
			GameObject gameObject = avatarAudioListener;
			uint num = sfxAmbient.Post(gameObject);
			DefaultFootStepSwitch = defaultFootStepSwitch;
			UseVillageRain = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6003262")]
		[Cpp2IlInjected.Address(RVA = "0xA52B90", Offset = "0xA51590", VA = "0x180A52B90")]
		public unsafe bool OnFootStepAudioSurface(Vector3 footPosition, GameObject audioEmitter)
		{
			//IL_0078: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			//IL_0090: Expected O, but got I4
			//IL_0090: Expected O, but got I4
			int num3;
			string[] array;
			do
			{
				int num = 0;
				int num2 = 0;
				num3 = 0;
				float z = Vector3.down.z;
				array = new string[0];
			}
			while ("Audio" != null && array == null);
			array[0] = "Audio";
			int mask = LayerMask.GetMask(array);
			float z2 = footPosition.z;
			int num4 = 0;
			RaycastHit[] array2 = default(RaycastHit[]);
			int length = array2.Length;
			if (num3 < length)
			{
				long num5 = (long)num3 * 44L;
				Transform transform = default(Transform);
				if (transform.gameObject.TryGetComponent<AudioFootStepData>(out *(AudioFootStepData*)num3))
				{
					int num6 = 0;
					RaycastHit raycastHit = default(RaycastHit);
					if (!((UnityEngine.Object)num3 == (UnityEngine.Object)num6) && (long)num4 <= (long)(IntPtr)raycastHit)
					{
					}
				}
				num3++;
			}
			int num7 = 0;
			bool flag = (UnityEngine.Object)num3 != (UnityEngine.Object)num7;
			if (!flag)
			{
				return flag;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003263")]
		[Cpp2IlInjected.Address(RVA = "0xA56EE0", Offset = "0xA558E0", VA = "0x180A56EE0")]
		public bool SetupFootStep(Vector3 footPosition, GameObject audioEmitter, bool isSetup = false)
		{
			//IL_0053: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			SceneData sceneData = default(SceneData);
			GameObject gameObject = default(GameObject);
			GridFloorType gridFloorType = default(GridFloorType);
			Switch @switch = default(Switch);
			while (true)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneItemData sceneItemData = sceneData.sceneItemData;
				int num = 0;
				if ((object)gameObject == null || (object)gameObject.GetComponent<Mdl.Environments.Environment>() != null)
				{
				}
				if (!isSetup)
				{
					SetRainFootStepState(audioEmitter);
				}
				Switch sceneDefaultFootstep = GetSceneDefaultFootstep();
				if (sceneDefaultFootstep == null || !sceneDefaultFootstep.IsValid())
				{
					break;
				}
				int num2 = 0;
				int num3 = 0;
				if ((!((UnityEngine.Object)num != (UnityEngine.Object)num3) || !OnFootStepOnGroundAlteration((GridScript)num, (Vector3)num2, audioEmitter)) && !OnFootStepAudioSurface((Vector3)num, audioEmitter))
				{
					if (num == 0)
					{
						continue;
					}
					int num4 = 0;
					if (gridFloorType != GridFloorType.Water || @switch == null)
					{
					}
					sceneDefaultFootstep.SetValue(audioEmitter);
				}
				return true;
			}
			int num5 = 0;
			bool flag = default(bool);
			if (flag)
			{
				int num6 = 0;
				bool flag2 = default(bool);
				while (flag2)
				{
				}
				bool flag3 = default(bool);
				while (flag3)
				{
				}
				Switch switch2 = default(Switch);
				if (switch2 == null)
				{
					goto IL_00af;
				}
			}
			bool flag4 = default(bool);
			while (flag4)
			{
			}
			goto IL_00af;
			IL_00af:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003268")]
		[Cpp2IlInjected.Address(RVA = "0xA58C50", Offset = "0xA57650", VA = "0x180A58C50")]
		public void TryTriggerHumming()
		{
			//Discarded unreachable code: IL_00e6, IL_00ec, IL_00f2, IL_00f8, IL_00fe, IL_0104, IL_010a, IL_0110, IL_0116, IL_011c, IL_0122, IL_0128, IL_012e, IL_0134, IL_013a, IL_0140
			//IL_00a5: Expected O, but got I4
			int num = 0;
			List<Mdl.Characters.Character> list;
			float z2 = default(float);
			if (dicussionCounter == num)
			{
				Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					CharacterManager system = _003CInstance_003Ek__BackingField.GetSystem<CharacterManager>();
					int num2 = 0;
					IEnumerable<Mdl.Characters.Character> activeCharacters = (IEnumerable<Mdl.Characters.Character>)system.GetActiveCharacters((byte)num2 != 0);
				}
				list = (List<Mdl.Characters.Character>)(object)new List<T>();
				if (list != null)
				{
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_0077;
						}
						num++;
					}
					Vector3 vector2 = default(Vector3);
					z2 = vector2.z;
					float num4 = hummingMaximumRange;
					goto IL_0077;
				}
				goto IL_0088;
			}
			goto IL_00e2;
			IL_0077:
			list = (List<Mdl.Characters.Character>)(object)((object)list + (object)list);
			z2 += 4.37E-43f;
			goto IL_0088;
			IL_00e2:
			int num5 = 0;
			return;
			IL_0088:
			int num6 = 0;
			if (list != null)
			{
			}
			Mdl.Characters.Character character = ((IEnumerable<>)list).RandomElement<Mdl.Characters.Character>();
			int num7 = 0;
			if (character != (UnityEngine.Object)num7)
			{
				uint[] array = new uint[6];
				Switch characterSwitch = character.characterSwitch;
				uint num8 = (array[0] = characterSwitch.Id);
				int num9 = 0;
				uint num10 = (array[0] = characterSwitch.Id);
			}
			goto IL_00e2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003269")]
		[Cpp2IlInjected.Address(RVA = "0xA51870", Offset = "0xA50270", VA = "0x180A51870")]
		public float GetHummingInterval()
		{
			float maxInclusive = hummingMaximumCooldown;
			return UnityEngine.Random.Range(hummingMinimumCooldown, maxInclusive);
		}

		[Cpp2IlInjected.Token(Token = "0x600326A")]
		[Cpp2IlInjected.Address(RVA = "0xA55880", Offset = "0xA54280", VA = "0x180A55880")]
		public void PlayCharacterVO(Mdl.Characters.Character character, string expressionId)
		{
			//Discarded unreachable code: IL_0031, IL_0036, IL_0090
			//IL_0009: Expected O, but got I4
			int num = 0;
			bool flag = character == (UnityEngine.Object)num;
			if (!flag && !flag)
			{
				uint[] array = new uint[6];
				string text = expressionId.ToLower();
				Dictionary<string, Switch> expressionSwitchesDict = ExpressionSwitchesDict;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600326B")]
		[Cpp2IlInjected.Address(RVA = "0xA50430", Offset = "0xA4EE30", VA = "0x180A50430")]
		public unsafe void CharacterBark(Mdl.Characters.Character characterObj)
		{
			//Discarded unreachable code: IL_010d
			int num = 0;
			DateTime now = DateTime.Now;
			DateTime dateTime = startVOBarkTime;
			TimeSpan timeSpan = now - dateTime;
			int num2 = 0;
			DateTime dateTime2 = (startVOBarkTime = DateTime.Now);
			uint[] array = new uint[6];
			uint num3 = (array[0] = characterObj.characterSwitch.Id);
			Item item = characterObj.GetComponent<ItemScript>().Item;
			if ((object)item == null)
			{
				CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
				if ((object)system != null)
				{
					MissionSlotState characterMarkerState = system.GetCharacterMarkerState(item);
					int num4 = 0;
					int num5 = (int)characterMarkerState;
				}
				int num6 = 0;
				if (((num6 == 0) ? 1 : 0) == num6)
				{
					uint id = vo_call_to_action.Id;
				}
				uint num7 = (array[0] = vo_environment.Id);
				AKRESULT state = AkSoundEngine.GetState("DayMoment", out *(uint*)num6);
				AKRESULT state2 = AkSoundEngine.GetState("Weather_Conditions_Clouds", out *(uint*)num6);
				AKRESULT state3 = AkSoundEngine.GetState("Weather_Conditions_Rain", out *(uint*)num6);
				int length = array.Length;
				array[1] = (uint)num6;
				array[2] = (uint)num6;
				array[2] = (uint)num6;
				PlayDialogueEvent((uint)num6, characterObj, array);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600326E")]
		[Cpp2IlInjected.Address(RVA = "0xA581E0", Offset = "0xA56BE0", VA = "0x180A581E0")]
		public void StartingDiscussion([System.Runtime.InteropServices.Optional] List<uint> disabledVOs)
		{
			//Discarded unreachable code: IL_0038, IL_0050, IL_00a0, IL_00b5
			//IL_001e: Expected O, but got I4
			levelingUp = false;
			allDisabledVOs = disabledVOs;
			Mdl.Characters.Character character = discussionCharacter;
			int num = 0;
			if (!(character == (UnityEngine.Object)num))
			{
				Mdl.Characters.Character character2 = discussionCharacter;
				Dictionary<int, string> dictionary = characterLastExpressionUsed;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600326F")]
		[Cpp2IlInjected.Address(RVA = "0xA52210", Offset = "0xA50C10", VA = "0x180A52210")]
		private bool IsVoDisabled(uint VOId)
		{
			//IL_0014: Expected O, but got I4
			List<uint> list = allDisabledVOs;
			if (list == null)
			{
				int num = 0;
			}
			return ((List<T>)(object)list).Contains((T)VOId);
		}

		[Cpp2IlInjected.Token(Token = "0x6003270")]
		[Cpp2IlInjected.Address(RVA = "0xA55AB0", Offset = "0xA544B0", VA = "0x180A55AB0")]
		private void PlayDialogueEvent(uint eventID, Mdl.Characters.Character character, uint[] eventPath)
		{
			//Discarded unreachable code: IL_003e
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (character != (UnityEngine.Object)num)
			{
				uint in_playingID = AkSoundEngine.DynamicSequenceOpen(character.CharacterAudioEmitterObj);
				uint in_audioNodeID = default(uint);
				AKRESULT aKRESULT = AkSoundEngine.DynamicSequenceLockPlaylist(in_playingID).Enqueue(in_audioNodeID);
				AKRESULT aKRESULT2 = AkSoundEngine.DynamicSequenceUnlockPlaylist(in_playingID);
				AKRESULT aKRESULT3 = AkSoundEngine.DynamicSequencePlay(in_playingID);
				AKRESULT aKRESULT4 = AkSoundEngine.DynamicSequenceClose(in_playingID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003271")]
		[Cpp2IlInjected.Address(RVA = "0xA511D0", Offset = "0xA4FBD0", VA = "0x180A511D0")]
		public unsafe void EndDiscussion()
		{
			//Discarded unreachable code: IL_00f2
			//IL_0034: Expected I4, but got O
			//IL_00bf: Expected O, but got I4
			//IL_00ea: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				return;
			}
			int num = dicussionCounter;
			if (num == 0)
			{
				return;
			}
			dicussionCounter = num;
			int num2 = (dicussionCounter = 0);
			uint[] array = new uint[0];
			array[0] = (uint)(int)array;
			if ((MissionComplete ? 1 : 0) == num2)
			{
				uint id = vo_closing.Id;
				bool flag2 = IsVoDisabled(id);
				uint num3 = (array[0] = vo_closing.Id);
			}
			uint id2 = vo_rewards.Id;
			bool flag3 = IsVoDisabled(id2);
			uint num4 = (array[0] = vo_rewards.Id);
			MissionComplete = (byte)num2 != 0;
			if ((levelingUp ? 1 : 0) == num2 && !flag3)
			{
				bool? skipNextEndVOEvent = SkipNextEndVOEvent;
				int num5 = 0;
				SkipNextEndVOEvent = (bool?)(object)num5;
				bool flag4 = (object)skipNextEndVOEvent == null;
				if ((IntPtr)(void*)skipNextEndVOEvent != (IntPtr)(flag4 ? 1 : 0) && (SkipEndVo ? 1 : 0) != num2)
				{
				}
			}
			SkipEndVo = (byte)num2 != 0;
			levelingUp = (byte)num2 != 0;
			discussionCharacter = (Mdl.Characters.Character)num2;
			dicussionCounter = num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003272")]
		[Cpp2IlInjected.Address(RVA = "0xA55C00", Offset = "0xA54600", VA = "0x180A55C00")]
		public void PlayDialogueGenExp(string expressionId, Switch overrideVO)
		{
			//Discarded unreachable code: IL_0043, IL_004b, IL_00c5, IL_00da, IL_00e3, IL_00e8, IL_0103, IL_011a, IL_0148
			//IL_001c: Expected O, but got I4
			if (dicussionCounter == 0)
			{
				return;
			}
			Mdl.Characters.Character character = discussionCharacter;
			int num = 0;
			if (character == (UnityEngine.Object)num)
			{
				return;
			}
			string text = expressionId.ToLower();
			if (overrideVO == null || !overrideVO.IsValid())
			{
				Dictionary<string, Switch> expressionSwitchesDict = ExpressionSwitchesDict;
				throw new NullReferenceException();
			}
			Switch @switch = default(Switch);
			if (@switch != null)
			{
				uint id = @switch.Id;
				if (!IsVoDisabled(id))
				{
					uint[] array = new uint[6];
					uint num2 = (array[0] = discussionCharacter.characterSwitch.Id);
					uint num3 = (array[0] = @switch.Id);
					Mdl.Characters.Character character2 = discussionCharacter;
					Dictionary<int, string> dictionary = characterLastExpressionUsed;
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003273")]
		[Cpp2IlInjected.Address(RVA = "0xA53920", Offset = "0xA52320", VA = "0x180A53920")]
		public void OnSystemStartVO()
		{
			//Discarded unreachable code: IL_0049
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.FriendshipAdded value = OnFriendshipAdded;
			_003CDispatcher_003Ek__BackingField.OnFriendshipAdded -= value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.FriendshipAdded value2 = OnFriendshipAdded;
			_003CDispatcher_003Ek__BackingField2.OnFriendshipAdded += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6003274")]
		[Cpp2IlInjected.Address(RVA = "0xA56820", Offset = "0xA55220", VA = "0x180A56820")]
		public void SetHangout(bool isStart)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			SkipNextEndVOEvent = (bool?)(object)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003275")]
		[Cpp2IlInjected.Address(RVA = "0xA516B0", Offset = "0xA500B0", VA = "0x180A516B0")]
		public bool? GetEndVOHangout()
		{
			//Discarded unreachable code: IL_002b
			//IL_0017: Expected O, but got I4
			//IL_0029: Expected O, but got I4
			bool flag = discussionCharacter.IsFollowingAvatar();
			int num = 0;
			int num2 = 0;
			SkipNextEndVOEvent = (bool?)(object)num2;
			bool? skipNextEndVOEvent = SkipNextEndVOEvent;
			int num3 = 0;
			SkipNextEndVOEvent = (bool?)(object)num3;
			return skipNextEndVOEvent;
		}

		[Cpp2IlInjected.Token(Token = "0x6003276")]
		[Cpp2IlInjected.Address(RVA = "0xA531E0", Offset = "0xA51BE0", VA = "0x180A531E0")]
		private void OnFriendshipAdded(AddedFriendshipSummary addedFriendshipSummary)
		{
			//Discarded unreachable code: IL_001a
			if (!addedFriendshipSummary.PlayerLevelUp)
			{
			}
			bool flag = (levelingUp = 1 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003277")]
		[Cpp2IlInjected.Address(RVA = "0xA54FE0", Offset = "0xA539E0", VA = "0x180A54FE0")]
		private void OnSystemStopVO()
		{
			//Discarded unreachable code: IL_0037
			//IL_000f: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.FriendshipAdded value = OnFriendshipAdded;
				_003CDispatcher_003Ek__BackingField.OnFriendshipAdded -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003284")]
		[Cpp2IlInjected.Address(RVA = "0xA57DC0", Offset = "0xA567C0", VA = "0x180A57DC0")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_00f1
			//IL_006c: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_0081: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00a7: Expected O, but got I4
			//IL_00e2: Expected O, but got I4
			avatarAudioListener = SystemRoot.Instance._avatar.AudioController.GetComponentInChildren<AkGameObj>().gameObject;
			LocalizationManager localizationManager = SystemRoot.Instance._localizationManager;
			EventHandler value = SetLanguage;
			localizationManager.OnLanguageChanged -= value;
			LocalizationManager localizationManager2 = SystemRoot.Instance._localizationManager;
			EventHandler value2 = SetLanguage;
			localizationManager2.OnLanguageChanged += value2;
			int num = 0;
			int num2 = 0;
			SetLanguage(num2, (EventArgs)num);
			Dictionary<GameState, State> gameStateDict = GameStateDict;
			int num3 = 0;
			bool flag = ((Dictionary<TKey, TValue>)(object)gameStateDict).TryGetValue((TKey)8, out *(TValue*)num3);
			if (num3 == 0 || !GameStateStack.Exists((State)num3))
			{
				bool flag2 = ((Dictionary<TKey, TValue>)(object)GameStateDict).TryGetValue((TKey)8, out *(TValue*)num3);
				if (num3 != 0)
				{
				}
				AK.Wwise.Event musicEvent = MusicEvent;
				GameObject gameObject = base.gameObject;
				uint num4 = musicEvent.Post(gameObject);
			}
			StartFS();
			StartBanks();
			SetSpecialEventAudio();
			Channel channel = default(Channel);
			string text = ((Enum)channel).ToString();
			Channel channel2 = channel;
			currentHouseRadioChannel = text;
		}

		[Cpp2IlInjected.Token(Token = "0x6003285")]
		[Cpp2IlInjected.Address(RVA = "0xA56C20", Offset = "0xA55620", VA = "0x180A56C20")]
		private void SetSpecialEventAudio()
		{
			//Discarded unreachable code: IL_001f, IL_0025
			int num = 0;
			List<AudioSpecialEvent> specialEventsAudio = SpecialEventsAudio;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				num++;
			}
			if (num + 1 == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003286")]
		[Cpp2IlInjected.Address(RVA = "0xA51FC0", Offset = "0xA509C0", VA = "0x180A51FC0")]
		private bool IsEventActive(AudioSpecialEvent spec_event)
		{
			//Discarded unreachable code: IL_0061
			//IL_0044: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			int num = 0;
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			AudioSpecialEvent.EventMonth eventMonthStart = spec_event.eventMonthStart;
			AudioSpecialEvent.EventMonth eventMonthEnd = spec_event.eventMonthEnd;
			if (eventMonthStart == eventMonthEnd)
			{
				int eventDayEnd = spec_event.eventDayEnd;
				if (spec_event.eventDayStart <= eventDayEnd)
				{
				}
			}
			if (eventMonthStart <= eventMonthEnd || !(localTime < (DateTime)num))
			{
			}
			DateTime dateTime = default(DateTime);
			bool flag = localTime <= dateTime;
			if (!flag)
			{
				return flag;
			}
			return localTime >= (DateTime)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003287")]
		[Cpp2IlInjected.Address(RVA = "0xA56880", Offset = "0xA55280", VA = "0x180A56880")]
		private void SetLanguage(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_004f
			string culture = SystemRoot.Instance._localizationManager.Culture;
			Dictionary<string, string> dictionary = culture2folder;
			bool flag = default(bool);
			if (flag)
			{
			}
			string text = (string)((Dictionary<TKey, TValue>)(object)culture2folder)[(TKey)"en-US"];
			int num = 0;
			if (AkSoundEngine.GetCurrentLanguage() != text)
			{
				AKRESULT aKRESULT = AkSoundEngine.SetCurrentLanguage(text);
				int num2 = 0;
				AkBankManager.ReloadAllBanks();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003288")]
		[Cpp2IlInjected.Address(RVA = "0xA588D0", Offset = "0xA572D0", VA = "0x180A588D0")]
		public void TriggerAudioEvent(string eventName)
		{
			AudioManager.OnAudioEventTriggered?.Invoke(eventName);
		}

		[Cpp2IlInjected.Token(Token = "0x6003289")]
		[Cpp2IlInjected.Address(RVA = "0xA508C0", Offset = "0xA4F2C0", VA = "0x180A508C0")]
		public void CheckFogEmmiters()
		{
			//Discarded unreachable code: IL_0041, IL_0047
			int num = 0;
			List<CurseEmitter> emitters = CurseEmitter.emitters;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			List<CurseEmitter> emitters2 = CurseEmitter.emitters;
			bool flag = default(bool);
			if (flag)
			{
			}
			int num2 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600328A")]
		[Cpp2IlInjected.Address(RVA = "0xA576B0", Offset = "0xA560B0", VA = "0x180A576B0")]
		public void StartCutsceneAudio(Cutscene cutscene)
		{
			//Discarded unreachable code: IL_0079
			//IL_0009: Expected O, but got I4
			//IL_0034: Expected I4, but got I8
			int num = 0;
			if (!(cutscene == (UnityEngine.Object)num))
			{
				if (typeMinigameStarted == AudioMinigameType.Coin)
				{
					AK.Wwise.Event @event = minigameFailSFXEvent;
					GameObject gameObject = base.gameObject;
					uint num2 = @event.Post(gameObject);
				}
				typeMinigameStarted = AudioMinigameType.None;
				Bank cutsceneBank = cutscene.cutsceneBank;
				int saveDecodedBank = 0;
				int decodeBank = 0;
				cutsceneBank.Load((byte)decodeBank != 0, (byte)saveDecodedBank != 0);
				GameState sceneGameState = cutscene.sceneGameState;
				Dictionary<GameState, State> gameStateDict = GameStateDict;
				ulong num3 = default(ulong);
				if (num3 == 0 || GameStateStack != null)
				{
				}
				cutscene.sceneState.SetValue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600328B")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA56E10", VA = "0x180A58410")]
		public void StopCutsceneAudio(Cutscene cutscene, bool wasSkipped)
		{
			//Discarded unreachable code: IL_005f
			notInCutscene.SetValue();
			GameStateStack?.Pop();
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> asyncTask = default(Task<>);
			asyncTask.FireAndForgetTask();
			if (wasSkipped)
			{
				AK.Wwise.Event @event = cutsceneSkipped;
				GameObject gameObject = base.gameObject;
				uint num2 = @event.Post(gameObject);
			}
			AudioManager.OnCutsceneAudioPop?.Invoke(cutscene);
		}

		[Cpp2IlInjected.Token(Token = "0x600328C")]
		[Cpp2IlInjected.Address(RVA = "0xA59220", Offset = "0xA57C20", VA = "0x180A59220")]
		[AsyncStateMachine(typeof(_003CUnloadCutsceneBank_003Ed__193))]
		public Task<bool> UnloadCutsceneBank(Cutscene cutscene)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600328D")]
		[Cpp2IlInjected.Address(RVA = "0xA56030", Offset = "0xA54A30", VA = "0x180A56030")]
		public void PushGameState(GameState gameState)
		{
			//Discarded unreachable code: IL_0017
			Dictionary<GameState, State> gameStateDict = GameStateDict;
			ulong num = default(ulong);
			if (num != 0 && GameStateStack == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600328E")]
		[Cpp2IlInjected.Address(RVA = "0xA567A0", Offset = "0xA551A0", VA = "0x180A567A0")]
		public void SetGameState(GameState gameState)
		{
			//Discarded unreachable code: IL_000e
			Dictionary<GameState, State> gameStateDict = GameStateDict;
			ulong num = default(ulong);
			if (num == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600328F")]
		[Cpp2IlInjected.Address(RVA = "0xA50E70", Offset = "0xA4F870", VA = "0x180A50E70")]
		public bool ContainsGameState(GameState gameState)
		{
			//Discarded unreachable code: IL_001a
			Dictionary<GameState, State> gameStateDict = GameStateDict;
			ulong num = default(ulong);
			if (num == 0)
			{
				int num2 = 0;
			}
			AudioStateStack gameStateStack = GameStateStack;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003290")]
		[Cpp2IlInjected.Address(RVA = "0xA55FF0", Offset = "0xA549F0", VA = "0x180A55FF0")]
		public void PopGameState()
		{
			GameStateStack?.Pop();
		}

		[Cpp2IlInjected.Token(Token = "0x6003291")]
		[Cpp2IlInjected.Address(RVA = "0xA560C0", Offset = "0xA54AC0", VA = "0x180A560C0")]
		public void PushLocation(Location location)
		{
			//Discarded unreachable code: IL_0083
			//IL_005c: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			int num = 0;
			Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			SceneItemData sceneItemData = sceneData.sceneItemData;
			GameObject gameObject = default(GameObject);
			if ((object)gameObject == null || (object)gameObject.GetComponent<Mdl.Environments.Environment>() != null)
			{
			}
			bool skipSetValue = TryLocationAreaOverride((GridScript)num, force: true);
			Dictionary<Location, State> locationDict = LocationDict;
			bool flag = default(bool);
			if (flag)
			{
				LocationStateStack?.Push((State)num, skipSetValue);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003292")]
		[Cpp2IlInjected.Address(RVA = "0xA56660", Offset = "0xA55060", VA = "0x180A56660")]
		public void SetAmbient(AK.Wwise.Event amb_event)
		{
			//Discarded unreachable code: IL_000f
			GameObject gameObject = avatarAudioListener;
			uint num = amb_event.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6003293")]
		[Cpp2IlInjected.Address(RVA = "0xA56010", Offset = "0xA54A10", VA = "0x180A56010")]
		public void PopLocation()
		{
			LocationStateStack?.Pop();
		}

		[Cpp2IlInjected.Token(Token = "0x6003294")]
		[Cpp2IlInjected.Address(RVA = "0xA51620", Offset = "0xA50020", VA = "0x180A51620")]
		public unsafe Channel GetCurHouseRadioChan()
		{
			int num = 0;
			bool flag = Enum.TryParse<Channel>(currentHouseRadioChannel, out *(Channel*)num);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003295")]
		[Cpp2IlInjected.Address(RVA = "0xA50000", Offset = "0xA4EA00", VA = "0x180A50000")]
		public bool AddRadio(string radioID, GameObject radioGameobj, bool inPlayerHouse)
		{
			//Discarded unreachable code: IL_0016, IL_001d, IL_0075, IL_0100
			int num = 0;
			if (!inPlayerHouse)
			{
				Dictionary<string, GameObject> dictionary = radioGameObjs;
				throw new NullReferenceException();
			}
			Transform transform = houseRadio.transform;
			Transform transform2 = radioGameobj.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			if ((houseRadioAdded ? 1 : 0) == num)
			{
				AK.Wwise.Event @event = startRadio;
				GameObject gameObject = houseRadio;
				uint num2 = @event.Post(gameObject);
				string in_pszEventName = currentHouseRadioChannel;
				GameObject in_gameObjectID = houseRadio;
				uint num3 = AkSoundEngine.PostEvent(in_pszEventName, in_gameObjectID);
				houseRadioAdded = true;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003296")]
		[Cpp2IlInjected.Address(RVA = "0xA56360", Offset = "0xA54D60", VA = "0x180A56360")]
		public void RemoveRadio(string radioID, bool inPlayerHouse)
		{
			//Discarded unreachable code: IL_0011, IL_0015, IL_005a
			if (!inPlayerHouse)
			{
				Dictionary<string, GameObject> dictionary = radioGameObjs;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003297")]
		[Cpp2IlInjected.Address(RVA = "0xA557A0", Offset = "0xA541A0", VA = "0x180A557A0")]
		public void PauseRadio(string radioID, bool inPlayerHouse)
		{
			//Discarded unreachable code: IL_0011, IL_0015, IL_0036
			if (!inPlayerHouse)
			{
				Dictionary<string, GameObject> dictionary = radioGameObjs;
				throw new NullReferenceException();
			}
			while (!houseRadioAdded)
			{
			}
			AK.Wwise.Event @event = pauseRadio;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003298")]
		[Cpp2IlInjected.Address(RVA = "0xA564A0", Offset = "0xA54EA0", VA = "0x180A564A0")]
		public void ResumeRadio(string radioID, bool inPlayerHouse)
		{
			//Discarded unreachable code: IL_0011, IL_0015, IL_0036, IL_0077
			if (!inPlayerHouse)
			{
				Dictionary<string, GameObject> dictionary = radioGameObjs;
				throw new NullReferenceException();
			}
			while (!houseRadioAdded)
			{
			}
			AK.Wwise.Event @event = resumeRadio;
			GameObject gameObject = houseRadio;
			uint num = @event.Post(gameObject);
			string in_pszEventName = currentHouseRadioChannel;
			GameObject in_gameObjectID = houseRadio;
			uint num2 = AkSoundEngine.PostEvent(in_pszEventName, in_gameObjectID);
		}

		[Cpp2IlInjected.Token(Token = "0x6003299")]
		[Cpp2IlInjected.Address(RVA = "0xA51E80", Offset = "0xA50880", VA = "0x180A51E80")]
		public void InteractWithRadio(string radioID, bool inPlayerHouse, string channel)
		{
			//Discarded unreachable code: IL_0011, IL_0015, IL_004d
			if (!inPlayerHouse)
			{
				Dictionary<string, GameObject> dictionary = radioGameObjs;
				throw new NullReferenceException();
			}
			if (houseRadioAdded)
			{
				GameObject in_gameObjectID = houseRadio;
				uint num = AkSoundEngine.PostEvent(channel, in_gameObjectID);
				currentHouseRadioChannel = channel;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600329A")]
		[Cpp2IlInjected.Address(RVA = "0xA59550", Offset = "0xA57F50", VA = "0x180A59550")]
		public void UpdateRadio(string radioID, GameObject gameObj, bool inPlayerHouse)
		{
			//Discarded unreachable code: IL_002d, IL_0032
			if (inPlayerHouse)
			{
				Transform transform = houseRadio.transform;
				Transform transform2 = gameObj.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				return;
			}
			Dictionary<string, GameObject> dictionary = radioGameObjs;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600329B")]
		[Cpp2IlInjected.Address(RVA = "0xA56DA0", Offset = "0xA557A0", VA = "0x180A56DA0")]
		public void SetStateToNone()
		{
			//Discarded unreachable code: IL_000c
			IP_State_None.SetValue();
		}

		[Cpp2IlInjected.Token(Token = "0x600329C")]
		[Cpp2IlInjected.Address(RVA = "0xA56620", Offset = "0xA55020", VA = "0x180A56620")]
		public void SceneChangeStart()
		{
			AK.Wwise.Event @event = sceneChangeStart;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600329D")]
		[Cpp2IlInjected.Address(RVA = "0xA565E0", Offset = "0xA54FE0", VA = "0x180A565E0")]
		public void SceneChangeEnd()
		{
			AK.Wwise.Event @event = sceneChangeEnd;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600329E")]
		[Cpp2IlInjected.Address(RVA = "0xA52270", Offset = "0xA50C70", VA = "0x180A52270")]
		public void ItemCollectMinigameStarted(Profile.ItemCollectMinigame minigame)
		{
			//Discarded unreachable code: IL_005f
			//IL_0028: Expected I4, but got I8
			//IL_0031: Expected I4, but got I8
			//IL_0041: Expected I4, but got I8
			AudioMinigameType typeMinigame = GetTypeMinigame(minigame);
			if (typeMinigame != AudioMinigameType.Coin)
			{
				if (typeMinigame != AudioMinigameType.Harvest)
				{
					if (typeMinigame != AudioMinigameType.Mineral)
					{
						if (typeMinigame != AudioMinigameType.Fish)
						{
							goto IL_0047;
						}
						typeMinigameStarted = typeMinigame;
					}
					typeMinigameStarted = AudioMinigameType.Mineral;
				}
				typeMinigameStarted = AudioMinigameType.Harvest;
			}
			State state = minigameOnAudioState;
			typeMinigameStarted = AudioMinigameType.Coin;
			state.SetValue();
			goto IL_0047;
			IL_0047:
			AK.Wwise.Event @event = criticalSuccessLootSpawn;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600329F")]
		[Cpp2IlInjected.Address(RVA = "0xA51BE0", Offset = "0xA505E0", VA = "0x180A51BE0")]
		private unsafe AudioMinigameType GetTypeMinigame(Profile.ItemCollectMinigame minigame)
		{
			int num = 0;
			MultiItemInstance multiItemInstance = Enumerable.FirstOrDefault<MultiItemInstance>((IEnumerable<>)minigame.ItemsToCollect);
			if (multiItemInstance != null)
			{
				RepeatedField<ItemInstance> items_ = multiItemInstance.items_;
				if (items_ != null)
				{
					ItemInstance itemInstance = Enumerable.FirstOrDefault<ItemInstance>((IEnumerable<>)(object)items_);
					if (itemInstance != null)
					{
						Item item = itemInstance.Item;
						int num2 = 0;
						Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
						if (!(*(Item*)item == *(Item*)softCurrencyItem))
						{
							Item item2 = itemInstance.Item;
							bool flag = default(bool);
							if (!flag)
							{
								bool flag2 = flag;
								Item item3 = itemInstance.Item;
								bool flag3 = default(bool);
								if (!flag3)
								{
									flag2 = flag3;
									Item item4 = itemInstance.Item;
								}
								return AudioMinigameType.Fish;
							}
							return AudioMinigameType.Harvest;
						}
						return AudioMinigameType.Coin;
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032A0")]
		[Cpp2IlInjected.Address(RVA = "0xA52480", Offset = "0xA50E80", VA = "0x180A52480")]
		public void MinigameCompleted(bool wonMinigame = false)
		{
			//Discarded unreachable code: IL_0037
			//IL_0036: Expected I4, but got I8
			AudioMinigameType audioMinigameType = typeMinigameStarted;
			if (audioMinigameType == AudioMinigameType.Coin || (audioMinigameType == AudioMinigameType.Harvest && wonMinigame))
			{
				if (!wonMinigame)
				{
				}
				AK.Wwise.Event @event = minigameCompletedSFXEvent;
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
			typeMinigameStarted = AudioMinigameType.None;
		}

		[Cpp2IlInjected.Token(Token = "0x60032A1")]
		[Cpp2IlInjected.Address(RVA = "0xA53AF0", Offset = "0xA524F0", VA = "0x180A53AF0", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			Season currentSeason = SystemRoot.Instance.MetaClient.LocalTime.GetSeason();
			Func<SeasonSwitcher, bool> func = (Func<SeasonSwitcher, bool>)(object)(Func<T, TResult>)delegate
			{
				Season season = currentSeason;
				bool result = default(bool);
				return result;
			};
			GameObject gameObject = base.gameObject;
			CancellationTokenProvider cancellationTokenProvider = (this.cancellationTokenProvider = base.gameObject.GetOrAddComponent<CancellationTokenProvider>());
			AudioStateStack audioStateStack = (GameStateStack = new AudioStateStack());
			GameStateWwise[] array = gameStates;
			Func<GameStateWwise, GameState> _003C_003E9__215_ = _003C_003Ec._003C_003E9__215_1;
			if (_003C_003E9__215_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			Func<GameStateWwise, State> func2 = default(Func<GameStateWwise, State>);
			if (_003C_003Ec._003C_003E9__215_2 == null)
			{
				func2 = (Func<GameStateWwise, State>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Dictionary<GameStateWwise, GameState> dictionary = (Dictionary<GameStateWwise, GameState>)(object)(GameStateDict = (Dictionary<GameState, State>)(object)Enumerable.ToDictionary<GameStateWwise, GameState, State>((IEnumerable<>)(object)array, (Func<, >)(object)_003C_003E9__215_, (Func<, >)(object)func2));
			AudioStateStack audioStateStack2 = (LocationStateStack = new AudioStateStack());
			LocationWwise[] array2 = locations;
			Func<LocationWwise, Location> func3 = default(Func<LocationWwise, Location>);
			if (_003C_003Ec._003C_003E9__215_3 == null)
			{
				func3 = (Func<LocationWwise, Location>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Func<LocationWwise, State> func4 = default(Func<LocationWwise, State>);
			if (_003C_003Ec._003C_003E9__215_4 == null)
			{
				func4 = (Func<LocationWwise, State>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Dictionary<LocationWwise, Location> dictionary2 = (Dictionary<LocationWwise, Location>)(object)(LocationDict = (Dictionary<Location, State>)(object)Enumerable.ToDictionary<LocationWwise, Location, State>((IEnumerable<>)(object)array2, (Func<, >)(object)func3, (Func<, >)(object)func4));
			LocationWwiseAreaOverride[] array3 = villageLocationOverride;
			Func<LocationWwiseAreaOverride, VillageAreaType> func5 = default(Func<LocationWwiseAreaOverride, VillageAreaType>);
			if (_003C_003Ec._003C_003E9__215_5 == null)
			{
				func5 = (Func<LocationWwiseAreaOverride, VillageAreaType>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Func<LocationWwiseAreaOverride, State> func6 = default(Func<LocationWwiseAreaOverride, State>);
			if (_003C_003Ec._003C_003E9__215_6 == null)
			{
				func6 = (Func<LocationWwiseAreaOverride, State>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Dictionary<LocationWwiseAreaOverride, VillageAreaType> dictionary3 = (Dictionary<LocationWwiseAreaOverride, VillageAreaType>)(object)(LocationAreaOverrideDict = (Dictionary<VillageAreaType, State>)(object)Enumerable.ToDictionary<LocationWwiseAreaOverride, VillageAreaType, State>((IEnumerable<>)(object)array3, (Func<, >)(object)func5, (Func<, >)(object)func6));
			HangoutWwise[] array4 = hangout_states;
			Func<HangoutWwise, int> func7 = default(Func<HangoutWwise, int>);
			if (_003C_003Ec._003C_003E9__215_7 == null)
			{
				func7 = (Func<HangoutWwise, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Func<HangoutWwise, State> func8 = default(Func<HangoutWwise, State>);
			if (_003C_003Ec._003C_003E9__215_8 == null)
			{
				func8 = (Func<HangoutWwise, State>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Dictionary<HangoutWwise, int> dictionary4 = (Dictionary<HangoutWwise, int>)(object)(HangoutsDict = (Dictionary<int, State>)(object)Enumerable.ToDictionary<HangoutWwise, int, State>((IEnumerable<>)(object)array4, (Func<, >)(object)func7, (Func<, >)(object)func8));
			HangoutWwiseOverride[] array5 = hangout_char_overrided;
			Func<HangoutWwiseOverride, Item> func9 = default(Func<HangoutWwiseOverride, Item>);
			if (_003C_003Ec._003C_003E9__215_9 == null)
			{
				func9 = (Func<HangoutWwiseOverride, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((HangoutWwiseOverride f) => (Item)typeof(Item).TypeHandle));
			}
			Func<HangoutWwiseOverride, State> func10 = default(Func<HangoutWwiseOverride, State>);
			if (_003C_003Ec._003C_003E9__215_10 == null)
			{
				func10 = (Func<HangoutWwiseOverride, State>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Dictionary<HangoutWwiseOverride, Item> dictionary5 = (Dictionary<HangoutWwiseOverride, Item>)(object)(HangoutsDictCharOverride = (Dictionary<Item, State>)(object)Enumerable.ToDictionary<HangoutWwiseOverride, Item, State>((IEnumerable<>)(object)array5, (Func<, >)(object)func9, (Func<, >)(object)func10));
			HangoutObjEvent[] array6 = hangout_obj_char;
			Func<HangoutObjEvent, Item> func11 = default(Func<HangoutObjEvent, Item>);
			if (_003C_003Ec._003C_003E9__215_11 == null)
			{
				func11 = (Func<HangoutObjEvent, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((HangoutObjEvent f) => (Item)typeof(Item).TypeHandle));
			}
			Func<HangoutObjEvent, AK.Wwise.Event> func12 = default(Func<HangoutObjEvent, AK.Wwise.Event>);
			if (_003C_003Ec._003C_003E9__215_12 == null)
			{
				func12 = (Func<HangoutObjEvent, AK.Wwise.Event>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Dictionary<HangoutObjEvent, Item> dictionary6 = (Dictionary<HangoutObjEvent, Item>)(object)(HangoutsObjDict = (Dictionary<Item, AK.Wwise.Event>)(object)Enumerable.ToDictionary<HangoutObjEvent, Item, AK.Wwise.Event>((IEnumerable<>)(object)array6, (Func<, >)(object)func11, (Func<, >)(object)func12));
			VOGeneralExpressionSwitch[] array7 = expressionsSwitches;
			Func<VOGeneralExpressionSwitch, string> func13 = default(Func<VOGeneralExpressionSwitch, string>);
			if (_003C_003Ec._003C_003E9__215_13 == null)
			{
				func13 = (Func<VOGeneralExpressionSwitch, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Func<VOGeneralExpressionSwitch, Switch> func14 = default(Func<VOGeneralExpressionSwitch, Switch>);
			if (_003C_003Ec._003C_003E9__215_14 == null)
			{
				func14 = (Func<VOGeneralExpressionSwitch, Switch>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Dictionary<VOGeneralExpressionSwitch, string> dictionary7 = (Dictionary<VOGeneralExpressionSwitch, string>)(object)(ExpressionSwitchesDict = (Dictionary<string, Switch>)(object)Enumerable.ToDictionary<VOGeneralExpressionSwitch, string, Switch>((IEnumerable<>)(object)array7, (Func<, >)(object)func13, (Func<, >)(object)func14));
			Dictionary<string, GameObject> dictionary8 = (radioGameObjs = (Dictionary<string, GameObject>)(object)new Dictionary<TKey, TValue>());
			Dictionary<int, string> dictionary9 = (characterLastExpressionUsed = (Dictionary<int, string>)(object)new Dictionary<TKey, TValue>());
			int num = 0;
			bool muteAll_ = DebugSettings.Settings.muteAll_;
			DoMuteAudio(muteAll_);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.MiningRockDamaged value = OnMiningRockDamaged;
			_003CDispatcher_003Ek__BackingField.OnMiningRockDamaged += value;
			HangoutSystem system = SystemRoot.Instance.GetSystem<HangoutSystem>();
			HangoutSystem.HangoutEventDelegate value2 = OnHangoutActivity;
			system.HangoutEvent += value2;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.CollectionSetUpdated value3 = OnCollectionSetUpdated;
			_003CDispatcher_003Ek__BackingField2.OnCollectionSetUpdated += value3;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += AnyEnvironmentEnteredEvent;
			float maxInclusive = hummingMaximumCooldown;
			float time = UnityEngine.Random.Range(hummingMinimumCooldown, maxInclusive);
			Invoke("TryTriggerHumming", time);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032A2")]
		[Cpp2IlInjected.Address(RVA = "0xA52320", Offset = "0xA50D20", VA = "0x180A52320")]
		public void LateUpdate()
		{
			//IL_001a: Invalid comparison between I4 and F4
			float num = bankLoaderTimer;
			int num2 = 0;
			float deltaTime = Time.deltaTime;
			int num3 = 0;
			bankLoaderTimer = num;
			if (!((float)num3 <= num))
			{
				UpdateBanksLoaders();
				float num4 = (bankLoaderTimer = bankLoaderUpdateIntervalSeconds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032A3")]
		[Cpp2IlInjected.Address(RVA = "0xA57330", Offset = "0xA55D30", VA = "0x180A57330")]
		public unsafe void SetupInitialState()
		{
			//Discarded unreachable code: IL_0054
			//IL_0011: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			Dictionary<GameState, State> gameStateDict = GameStateDict;
			int num = 0;
			bool flag = ((Dictionary<TKey, TValue>)(object)gameStateDict).TryGetValue((TKey)8, out *(TValue*)num);
			if (num == 0 || !GameStateStack.Exists((State)num))
			{
				bool flag2 = ((Dictionary<TKey, TValue>)(object)GameStateDict).TryGetValue((TKey)8, out *(TValue*)num);
				if (num != 0)
				{
				}
				AK.Wwise.Event musicEvent = MusicEvent;
				GameObject gameObject = base.gameObject;
				uint num2 = musicEvent.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032A4")]
		[Cpp2IlInjected.Address(RVA = "0xA53220", Offset = "0xA51C20", VA = "0x180A53220")]
		private void OnHangoutActivity(Item characterItem, HangoutEvent hangoutEvent, bool affectHangoutAudio)
		{
			//Discarded unreachable code: IL_003f, IL_0044, IL_0052, IL_0057, IL_0065, IL_0072, IL_007c, IL_0080, IL_0084, IL_00a7, IL_00b5, IL_00ba, IL_00bf, IL_00c4, IL_00d6, IL_00de
			//IL_0063: Expected O, but got I4
			//IL_00d3: Expected O, but got I4
			//IL_00d3: Expected O, but got I4
			int itemID = characterItem.ItemID;
			if (affectHangoutAudio)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				CharacterItemData characterItemData = default(CharacterItemData);
				if (characterItemData != null && (object)characterItemData.GetUniverseTag() == null)
				{
					Item universeTag = characterItemData.GetUniverseTag();
					Dictionary<Item, State> hangoutsDictCharOverride = HangoutsDictCharOverride;
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032A5")]
		[Cpp2IlInjected.Address(RVA = "0xA50350", Offset = "0xA4ED50", VA = "0x180A50350")]
		private void AnyEnvironmentEnteredEvent(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0026
			//IL_0017: Expected O, but got I4
			if (UseVillageRain)
			{
				bool flag = default(bool);
				if (!flag)
				{
				}
				return;
			}
			int num = 0;
			if (!CheckRainInModifiers((WeatherTimeline)num))
			{
			}
			defaultRainState.SetValue();
		}

		[Cpp2IlInjected.Token(Token = "0x60032A6")]
		[Cpp2IlInjected.Address(RVA = "0xA59E30", Offset = "0xA58830", VA = "0x180A59E30")]
		public void UpdateWeather([System.Runtime.InteropServices.Optional] WeatherTimeline weatherTimeline)
		{
			//Discarded unreachable code: IL_0024
			if (UseVillageRain)
			{
				bool flag = default(bool);
				if (!flag)
				{
				}
				return;
			}
			if (!CheckRainInModifiers(weatherTimeline))
			{
			}
			defaultRainState.SetValue();
		}

		[Cpp2IlInjected.Token(Token = "0x60032A7")]
		[Cpp2IlInjected.Address(RVA = "0xA50C50", Offset = "0xA4F650", VA = "0x180A50C50")]
		private unsafe bool CheckRainInModifiers([System.Runtime.InteropServices.Optional] WeatherTimeline weatherTimeline)
		{
			//IL_000d: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (!(weatherTimeline != (UnityEngine.Object)num3) && SystemRoot.TryGetSystem<WeatherSystem>(out *(WeatherSystem*)num))
			{
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = default(bool);
					while (!flag2)
					{
					}
					num++;
				}
				if (num + 1 == 0)
				{
				}
			}
			return TimelineHasRain(weatherTimeline);
		}

		[Cpp2IlInjected.Token(Token = "0x60032A8")]
		[Cpp2IlInjected.Address(RVA = "0xA58660", Offset = "0xA57060", VA = "0x180A58660")]
		private bool TimelineHasRain(WeatherTimeline timeline)
		{
			//Discarded unreachable code: IL_0033, IL_0039
			int num = 0;
			int num2 = 0;
			if (timeline.modifiers != null)
			{
				int num3 = 0;
				bool flag = default(bool);
				if (flag)
				{
					int num4 = 0;
					bool flag2 = default(bool);
					while (!flag2)
					{
					}
					bool flag3 = default(bool);
					while (!flag3)
					{
					}
					num2++;
				}
				if (num2 + 1 == 0)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032A9")]
		[Cpp2IlInjected.Address(RVA = "0xA56DD0", Offset = "0xA557D0", VA = "0x180A56DD0")]
		public void SetVillageState(bool isCursedLifted)
		{
			//Discarded unreachable code: IL_0028
			if (SystemRoot.Instance.GetSystem<CurseSystem>().isLimboActive || !isCursedLifted)
			{
			}
			limbo_village_state?.SetValue();
		}

		[Cpp2IlInjected.Token(Token = "0x60032AA")]
		[Cpp2IlInjected.Address(RVA = "0xA537E0", Offset = "0xA521E0", VA = "0x180A537E0")]
		private void OnMiningRockDamaged()
		{
			//Discarded unreachable code: IL_0017
			AK.Wwise.Event @event = miningTreasureSpawn;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60032AB")]
		[Cpp2IlInjected.Address(RVA = "0xA53820", Offset = "0xA52220", VA = "0x180A53820")]
		public void OnMiningRockDestroyed(GameObject audioEmitter)
		{
			//Discarded unreachable code: IL_000e
			uint num = miningRockDestroyed.Post(audioEmitter);
		}

		[Cpp2IlInjected.Token(Token = "0x60032AC")]
		[Cpp2IlInjected.Address(RVA = "0xA53850", Offset = "0xA52250", VA = "0x180A53850")]
		public void OnMiningRockSpecialReveal(GameObject audioEmitter)
		{
			//Discarded unreachable code: IL_000e
			uint num = miningRockSpecialReveal.Post(audioEmitter);
		}

		[Cpp2IlInjected.Token(Token = "0x60032AD")]
		[Cpp2IlInjected.Address(RVA = "0xA551C0", Offset = "0xA53BC0", VA = "0x180A551C0", Slot = "5")]
		public override void OnSystemStop()
		{
			//Discarded unreachable code: IL_00f6
			//IL_001c: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			CancelInvoke();
			int num = 0;
			AkSoundEngine.StopAll();
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num2 = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num2)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.MiningRockDamaged value = OnMiningRockDamaged;
				_003CDispatcher_003Ek__BackingField.OnMiningRockDamaged -= value;
				HangoutSystem system = SystemRoot.Instance.GetSystem<HangoutSystem>();
				HangoutSystem.HangoutEventDelegate value2 = OnHangoutActivity;
				system.HangoutEvent -= value2;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.CollectionSetUpdated value3 = OnCollectionSetUpdated;
				_003CDispatcher_003Ek__BackingField2.OnCollectionSetUpdated -= value3;
			}
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= AnyEnvironmentEnteredEvent;
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			int num3 = 0;
			if (_003CInstance_003Ek__BackingField2 != (UnityEngine.Object)num3)
			{
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
				ProfileEventDispatcher.FriendshipAdded value4 = OnFriendshipAdded;
				_003CDispatcher_003Ek__BackingField3.OnFriendshipAdded -= value4;
			}
			CancelInvoke("CheckFogEmmiters");
			CancelInvoke("UpdateTimeOfDayInvoke");
		}

		[Cpp2IlInjected.Token(Token = "0x60032AE")]
		[Cpp2IlInjected.Address(RVA = "0xA52500", Offset = "0xA50F00", VA = "0x180A52500")]
		private unsafe void OnCollectionSetUpdated(Item collectionSetItem, int groupIndex, Item itemAdded, bool fromCooking)
		{
			//Discarded unreachable code: IL_00a8
			//IL_0016: Expected O, but got I4
			int itemID = collectionSetItem.ItemID;
			int num = 0;
			Item collectionSetItem2 = (Item)itemID;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = collectionSetItem2;
			if (_003CInstance_003Ek__BackingField.GetItemData<CollectionSetItemData>(item).submenu_ != CollectionSubMenu.Memories)
			{
				return;
			}
			RepeatedField<CollectionSet> collectionSets_ = SystemRoot.Instance.Client.Profile.player_.collectionSets_;
			Predicate<CollectionSet> predicate = (Predicate<CollectionSet>)(object)(Predicate<T>)delegate(CollectionSet x)
			{
				//Discarded unreachable code: IL_0011
				Item item2 = collectionSetItem2;
				return (IntPtr)x.collectionDefinitionID_ == (IntPtr)item2;
			};
			if (ProtoExtensions.TryFindValue<CollectionSet>((RepeatedField<>)(object)collectionSets_, (Predicate<>)(object)predicate, ref *(CollectionSet*)num))
			{
				Predicate<CollectionSetGroup> predicate2 = (Predicate<CollectionSetGroup>)(object)(Predicate<T>)delegate(CollectionSetGroup x)
				{
					//Discarded unreachable code: IL_0011
					int num3 = groupIndex;
					return x.groupIndex_ == num3;
				};
				if (ProtoExtensions.TryFindValue<CollectionSetGroup>((RepeatedField<>)(object)collectionSets_, (Predicate<>)(object)predicate2, ref *(CollectionSetGroup*)num))
				{
					AK.Wwise.Event @event = mMemoryCollectionComplete;
					GameObject gameObject = base.gameObject;
					uint num2 = @event.Post(gameObject);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032AF")]
		[Cpp2IlInjected.Address(RVA = "0xA58950", Offset = "0xA57350", VA = "0x180A58950")]
		public unsafe bool TryLocationAreaOverride(GridScript grid, bool force = false)
		{
			//IL_001a: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			int num3 = 0;
			if (!(grid == (UnityEngine.Object)num3))
			{
				Mdl.Online.Client client = default(Mdl.Online.Client);
				Village village = client.Profile.Village;
				uint gridID = grid.GridID;
				if (village.TryGetAreaType(gridID, out *(VillageAreaType*)num) && (currentAreaType != (VillageAreaType)num || force))
				{
					Dictionary<VillageAreaType, State> locationAreaOverrideDict = LocationAreaOverrideDict;
					currentAreaType = (VillageAreaType)num;
					if (((Dictionary<TKey, TValue>)(object)locationAreaOverrideDict).TryGetValue((TKey)num, out *(TValue*)num) || ((Dictionary<TKey, TValue>)(object)LocationDict).TryGetValue((TKey)6, out *(TValue*)num))
					{
					}
					AudioManager.OnVillageTypeChanged?.Invoke((VillageAreaType)num);
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032B0")]
		[Cpp2IlInjected.Address(RVA = "0xA53880", Offset = "0xA52280", VA = "0x180A53880", Slot = "6")]
		public override void OnSystemPause()
		{
			AKRESULT aKRESULT = AkSoundEngine.Suspend(in_bRenderAnyway: false);
		}

		[Cpp2IlInjected.Token(Token = "0x60032B1")]
		[Cpp2IlInjected.Address(RVA = "0xA538D0", Offset = "0xA522D0", VA = "0x180A538D0", Slot = "7")]
		public override void OnSystemResume()
		{
			int num = 0;
			AKRESULT aKRESULT = AkSoundEngine.WakeupFromSuspend();
		}

		[Cpp2IlInjected.Token(Token = "0x60032B2")]
		[Cpp2IlInjected.Address(RVA = "0xA59680", Offset = "0xA58080", VA = "0x180A59680")]
		private void UpdateTimeOfDayInvoke()
		{
			//Discarded unreachable code: IL_0018
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			TimeSpan cur_time = default(TimeSpan);
			UpdateTimeOfDay(cur_time);
		}

		[Cpp2IlInjected.Token(Token = "0x60032B3")]
		[Cpp2IlInjected.Address(RVA = "0xA59770", Offset = "0xA58170", VA = "0x180A59770")]
		public void UpdateTimeOfDay()
		{
			//Discarded unreachable code: IL_0018
			DateTime localTime = SystemRoot.Instance.MetaClient.LocalTime;
			TimeSpan cur_time = default(TimeSpan);
			UpdateTimeOfDay(cur_time);
		}

		[Cpp2IlInjected.Token(Token = "0x60032B4")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58260", VA = "0x180A59860")]
		public void UpdateTimeOfDay(TimeSpan cur_time)
		{
			//Discarded unreachable code: IL_00e2, IL_00e8
			//IL_0068: Expected F4, but got I4
			//IL_00ca: Expected O, but got I4
			int num = 0;
			if ((object)IsUnlockCurseLight == null)
			{
				GameSettingsData data = (GameSettingsData)((BaseStorage<DataType>)(object)SystemRoot.Instance.MetaClient.GameSettings).Data;
				TimeSpan zero = TimeSpan.Zero;
				TimeSpan timeSpan = default(TimeSpan);
				TimeSpan timeSpan2 = default(TimeSpan);
				if (timeSpan < zero)
				{
					TimeSpan timeSpan3 = timeSpan2 + timeSpan;
				}
				if (!(timeSpan > timeSpan2))
				{
					goto IL_0054;
				}
				TimeSpan timeSpan4 = timeSpan - timeSpan2;
			}
			int num2 = 0;
			goto IL_0054;
			IL_0054:
			RTPC dayTimeRTPC = DayTimeRTPC;
			int num3 = 0;
			dayTimeRTPC.SetGlobalValue(num3);
			List<DayMomentState> dayMomentStates = DayMomentStates;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			TimeSpan timeSpan5 = default(TimeSpan);
			TimeSpan timeSpan6 = default(TimeSpan);
			bool flag2 = timeSpan5 <= timeSpan6;
			bool flag3 = default(bool);
			if (!flag2 || !flag2 || !flag3)
			{
				bool flag4 = timeSpan5 > timeSpan6;
				while (!flag4)
				{
				}
				if (!flag4)
				{
					bool flag5 = default(bool);
					while (!flag5)
					{
					}
				}
			}
			if (ActiveDayMomentState != null)
			{
				string text = ActiveDayMomentState.Name;
				if (!((string)num != text))
				{
					return;
				}
			}
			ActiveDayMomentState?.SetValue();
		}

		[Cpp2IlInjected.Token(Token = "0x60032B5")]
		[Cpp2IlInjected.Address(RVA = "0xA51840", Offset = "0xA50240", VA = "0x180A51840")]
		public GameStateScope GetGameStateScope(GameState gameState, [System.Runtime.InteropServices.Optional] Mdl.Characters.Character character, [System.Runtime.InteropServices.Optional] List<uint> disabledVOs)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60032B6")]
		[Cpp2IlInjected.Address(RVA = "0xA51890", Offset = "0xA50290", VA = "0x180A51890")]
		public InFTUEScope GetInFTUEScope()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60032B7")]
		[Cpp2IlInjected.Address(RVA = "0xA50F00", Offset = "0xA4F900", VA = "0x180A50F00")]
		public void DoMuteAll(bool mute)
		{
			if (!mute)
			{
				AK.Wwise.Event unmuteAll = UnmuteAll;
				GameObject gameObject = base.gameObject;
				uint num = unmuteAll.Post(gameObject);
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032B8")]
		[Cpp2IlInjected.Address(RVA = "0xA51110", Offset = "0xA4FB10", VA = "0x180A51110")]
		public void DoMuteMusic(bool mute)
		{
			if (!mute)
			{
				AK.Wwise.Event unmuteMusic = UnmuteMusic;
				GameObject gameObject = base.gameObject;
				uint num = unmuteMusic.Post(gameObject);
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032B9")]
		[Cpp2IlInjected.Address(RVA = "0xA51150", Offset = "0xA4FB50", VA = "0x180A51150")]
		public void DoMuteSfx(bool mute)
		{
			if (!mute)
			{
				AK.Wwise.Event unmuteSfx = UnmuteSfx;
				GameObject gameObject = base.gameObject;
				uint num = unmuteSfx.Post(gameObject);
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032BA")]
		[Cpp2IlInjected.Address(RVA = "0xA51190", Offset = "0xA4FB90", VA = "0x180A51190")]
		public void DoMuteVO(bool mute)
		{
			if (!mute)
			{
				AK.Wwise.Event unmuteVO = UnmuteVO;
				GameObject gameObject = base.gameObject;
				uint num = unmuteVO.Post(gameObject);
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032BB")]
		[Cpp2IlInjected.Address(RVA = "0xA50F40", Offset = "0xA4F940", VA = "0x180A50F40")]
		public void DoMuteAudio(bool mute)
		{
			if (!mute)
			{
				int num = 0;
				if (!DebugSettings.Settings.muteAll_)
				{
					AK.Wwise.Event unmuteAll = UnmuteAll;
					GameObject gameObject = base.gameObject;
					uint num2 = unmuteAll.Post(gameObject);
					int num3 = 0;
					if (DebugSettings.Settings.muteMusic_)
					{
						AK.Wwise.Event muteMusic = MuteMusic;
						GameObject gameObject2 = base.gameObject;
						uint num4 = muteMusic.Post(gameObject2);
					}
					int num5 = 0;
					if (DebugSettings.Settings.muteSfx_)
					{
						AK.Wwise.Event muteSfx = MuteSfx;
						GameObject gameObject3 = base.gameObject;
						uint num6 = muteSfx.Post(gameObject3);
					}
					int num7 = 0;
					if (DebugSettings.Settings.muteVO_)
					{
						AK.Wwise.Event muteVO = MuteVO;
						GameObject gameObject4 = base.gameObject;
						uint num8 = muteVO.Post(gameObject4);
					}
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60032BC")]
		[Cpp2IlInjected.Address(RVA = "0xA52970", Offset = "0xA51370", VA = "0x180A52970")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0067
			//IL_0013: Expected O, but got I4
			//IL_0013: Expected O, but got I4
			if ((object)SystemRoot.Instance != null)
			{
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				LocalizationManager localizationManager = SystemRoot.Instance._localizationManager;
				EventHandler value = SetLanguage;
				localizationManager.OnLanguageChanged -= value;
			}
			if (hangoutActive)
			{
				AK.Wwise.Event @event = stopHangout;
				GameObject gameObject = base.gameObject;
				uint num3 = @event.Post(gameObject);
				hangoutActive = false;
			}
			OnDestroyBanks();
		}

		[Cpp2IlInjected.Token(Token = "0x60032BD")]
		[Cpp2IlInjected.Address(RVA = "0xA5A1A0", Offset = "0xA58BA0", VA = "0x180A5A1A0")]
		public AudioManager()
		{
			//IL_005d: Expected I4, but got I8
			//IL_0066: Expected I4, but got I8
			//IL_007e: Expected I4, but got I8
			int num = 0;
			startVOBarkTime = DateTime.Now;
			hummingMaximumRange = 20f;
			hummingMinimumRange = 5f;
			hummingMinimumCooldown = 0.2f;
			hummingMaximumCooldown = 0.5f;
			updateTimeIntervalSeconds = 60;
			curseFogRTPCCheckInterval = 2;
			bankLoaderUpdateIntervalSeconds = 0.1f;
			unloadCutsceneBankDelay = 5000;
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x60032BE")]
		[Cpp2IlInjected.Address(RVA = "0xA59F20", Offset = "0xA58920", VA = "0x180A59F20")]
		static AudioManager()
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0018, IL_001e, IL_0024, IL_002a, IL_0030, IL_0036, IL_003c
			Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
			throw new NullReferenceException();
		}
	}
}
