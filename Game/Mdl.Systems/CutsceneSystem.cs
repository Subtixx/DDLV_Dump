using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Ftue.Cutscenes;
using Meta.Online;
using Meta.Util;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000954")]
	public class CutsceneSystem : System
	{
		[Cpp2IlInjected.Token(Token = "0x2000955")]
		public struct CutscenePlayingScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40033C8")]
			private readonly CutsceneSystem system;

			[Cpp2IlInjected.Token(Token = "0x6002B2B")]
			[Cpp2IlInjected.Address(RVA = "0x1195F20", Offset = "0x1194920", VA = "0x181195F20")]
			public CutscenePlayingScope(CutsceneSystem system)
			{
				//Discarded unreachable code: IL_000f
				this.system = system;
				system.playingCutscene = true;
			}

			[Cpp2IlInjected.Token(Token = "0x6002B2C")]
			[Cpp2IlInjected.Address(RVA = "0x1195F00", Offset = "0x1194900", VA = "0x181195F00", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40033C2")]
		private Cutscene loadedCutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40033C3")]
		private string loadedCutsceneId = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40033C4")]
		private string loadedCutsceneGUID = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40033C5")]
		public GameObject preloadedCuscenes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40033C6")]
		[SerializeField]
		public List<SceneIntroCutscenesToPlay> sceneIntroCSList;

		[Cpp2IlInjected.Token(Token = "0x17000622")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x88"), Cpp2IlInjected.Token(Token = "0x40033C7")]
		public bool playingCutscene
		{
			[Cpp2IlInjected.Token(Token = "0x6002B1C")]
			[Cpp2IlInjected.Address(RVA = "0xBD6330", Offset = "0xBD4D30", VA = "0x180BD6330")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002B1D")]
			[Cpp2IlInjected.Address(RVA = "0x102A930", Offset = "0x1029330", VA = "0x18102A930")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B1E")]
		[Cpp2IlInjected.Address(RVA = "0x1112100", Offset = "0x1110B00", VA = "0x181112100")]
		[AsyncStateMachine(typeof(_003CDoPlayCutscene_003Ed__9))]
		public Task<bool> DoPlayCutscene(string cutsceneId, AssetReference cutsceneRef, bool CannotBeSkipped, float EndBlackScreenDuration, float EndFadeDuration, float FadeOutDuration, bool SkipEndFade, bool SkipCutsceneAudio, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B1F")]
		[Cpp2IlInjected.Address(RVA = "0x1112970", Offset = "0x1111370", VA = "0x181112970")]
		public static bool SceneIntroCutsceneNeedsToPlay()
		{
			//Discarded unreachable code: IL_0029
			//IL_0014: Expected O, but got I4
			CutsceneSystem system = SystemRoot.Instance.GetSystem<CutsceneSystem>();
			int num = 0;
			bool flag = system != (UnityEngine.Object)num;
			if (!flag)
			{
				return flag;
			}
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B20")]
		[Cpp2IlInjected.Address(RVA = "0x1112B50", Offset = "0x1111550", VA = "0x181112B50")]
		public bool SceneIntroCutsceneNeedsToPlay(Item sceneItem)
		{
			//Discarded unreachable code: IL_005f
			//IL_0014: Expected O, but got I4
			int itemID = sceneItem.ItemID;
			Item sceneItem2 = (Item)itemID;
			List<SceneIntroCutscenesToPlay> list = sceneIntroCSList;
			Func<SceneIntroCutscenesToPlay, bool> func = (Func<SceneIntroCutscenesToPlay, bool>)(object)(Func<T, TResult>)delegate(SceneIntroCutscenesToPlay x)
			{
				//Discarded unreachable code: IL_0011
				Item item = sceneItem2;
				return (IntPtr)x.sceneID == (IntPtr)item;
			};
			if (Enumerable.FirstOrDefault<SceneIntroCutscenesToPlay>((IEnumerable<>)list, (Func<, >)(object)func) != null)
			{
				int num = 0;
				Client client = default(Client);
				if (!DebugSettings.Settings.disableAllFtue_ && client.profile.player_.completedFtueEvents_ != null)
				{
					goto IL_0059;
				}
			}
			int num2 = 0;
			goto IL_0059;
			IL_0059:
			bool flag = default(bool);
			return !flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B21")]
		[Cpp2IlInjected.Address(RVA = "0x11122E0", Offset = "0x1110CE0", VA = "0x1811122E0")]
		[AsyncStateMachine(typeof(_003CGetCutscene_003Ed__12))]
		public Task<Cutscene> GetCutscene(string cutsceneId, AssetReference cutsceneRef)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<Cutscene>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B22")]
		[Cpp2IlInjected.Address(RVA = "0x1112440", Offset = "0x1110E40", VA = "0x181112440")]
		[AsyncStateMachine(typeof(_003CLoadCutscene_003Ed__13))]
		public Task<Cutscene> LoadCutscene(AssetReference cutsceneRef, string cutsceneId)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<Cutscene>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B23")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void OnSystemPause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B24")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B25")]
		[Cpp2IlInjected.Address(RVA = "0x11125A0", Offset = "0x1110FA0", VA = "0x1811125A0", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			loadedCutsceneId = "";
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B26")]
		[Cpp2IlInjected.Address(RVA = "0x11125F0", Offset = "0x1110FF0", VA = "0x1811125F0", Slot = "5")]
		public override void OnSystemStop()
		{
			//IL_0010: Expected O, but got I4
			//IL_002d: Expected O, but got I8
			Cutscene cutscene = loadedCutscene;
			int num = 0;
			if (cutscene != (UnityEngine.Object)num)
			{
				bool flag = Addressables.ReleaseInstance(loadedCutscene.gameObject);
			}
			loadedCutscene = (Cutscene)0;
			loadedCutsceneId = "";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002B27")]
		[Cpp2IlInjected.Address(RVA = "0x11126E0", Offset = "0x11110E0", VA = "0x1811126E0")]
		public void RemoveCutscene(string cutsceneId)
		{
			//Discarded unreachable code: IL_0053
			//IL_0010: Expected O, but got I4
			//IL_003c: Expected O, but got I8
			Cutscene cutscene = loadedCutscene;
			int num = 0;
			if (cutscene != (UnityEngine.Object)num && string.Equals(loadedCutsceneId, cutsceneId))
			{
				bool flag = Addressables.ReleaseInstance(loadedCutscene.gameObject);
				loadedCutscene = (Cutscene)0;
				loadedCutsceneId = "";
				loadedCutsceneGUID = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B28")]
		[Cpp2IlInjected.Address(RVA = "0x1112810", Offset = "0x1111210", VA = "0x181112810")]
		public void RemoveCutscene(AssetReference reference)
		{
			//Discarded unreachable code: IL_005d
			//IL_0010: Expected O, but got I4
			//IL_0046: Expected O, but got I8
			Cutscene cutscene = loadedCutscene;
			int num = 0;
			if (cutscene != (UnityEngine.Object)num)
			{
				string a = loadedCutsceneGUID;
				string assetGUID = reference.AssetGUID;
				if (string.Equals(a, assetGUID))
				{
					bool flag = Addressables.ReleaseInstance(loadedCutscene.gameObject);
					loadedCutscene = (Cutscene)0;
					loadedCutsceneId = "";
					loadedCutsceneGUID = "";
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002B29")]
		[Cpp2IlInjected.Address(RVA = "0x11122B0", Offset = "0x1110CB0", VA = "0x1811122B0")]
		public CutscenePlayingScope GetCutscenePlayingScope()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002B2A")]
		[Cpp2IlInjected.Address(RVA = "0x1112D10", Offset = "0x1111710", VA = "0x181112D10")]
		public CutsceneSystem()
		{
		}
	}
}
