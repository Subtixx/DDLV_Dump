using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x20005A6")]
	[CreateAssetMenu]
	public class PlayCutscene : FtueStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40022C2")]
		public string cutsceneId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40022C3")]
		public AssetReference cutsceneRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40022C4")]
		public float FadeOutDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40022C5")]
		public bool CannotBeSkipped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40022C6")]
		public float StartFadeDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40022C7")]
		public float EndBlackScreenDuration = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40022C8")]
		public float EndFadeDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40022C9")]
		public bool SkipEndFade;

		[Cpp2IlInjected.Token(Token = "0x600192F")]
		[Cpp2IlInjected.Address(RVA = "0x14B9040", Offset = "0x14B7A40", VA = "0x1814B9040", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__8))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001930")]
		[Cpp2IlInjected.Address(RVA = "0x14B9310", Offset = "0x14B7D10", VA = "0x1814B9310")]
		[AsyncStateMachine(typeof(_003CRunCustomizedCutscene_003Ed__9))]
		public Task<bool> RunCustomizedCutscene([Optional] GameObject obj, [Optional] Dictionary<string, Item> items, [Optional] Dictionary<int, GameObject> itemPrefabMap, [Optional] Dictionary<string, string> textForTracks, string objHolderId = "")
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001931")]
		[Cpp2IlInjected.Address(RVA = "0x14B94B0", Offset = "0x14B7EB0", VA = "0x1814B94B0")]
		[AsyncStateMachine(typeof(_003CSetupCutscene_003Ed__10))]
		private Task SetupCutscene([Optional] GameObject obj, [Optional] Dictionary<string, Item> items, [Optional] Dictionary<int, GameObject> itemPrefabMap, [Optional] Dictionary<string, string> textForTracks, string objHolderId = "")
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001932")]
		[Cpp2IlInjected.Address(RVA = "0x14B9180", Offset = "0x14B7B80", VA = "0x1814B9180")]
		[AsyncStateMachine(typeof(_003CDoPlayCutscene_003Ed__11))]
		private Task DoPlayCutscene([Optional] GameObject obj, [Optional] Dictionary<string, Item> items, [Optional] Dictionary<int, GameObject> itemPrefabMap, [Optional] Dictionary<string, string> textForTracks, string objHolderId = "", [Optional] CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001933")]
		[Cpp2IlInjected.Address(RVA = "0x14B8DB0", Offset = "0x14B77B0", VA = "0x1814B8DB0")]
		public void CutsceneComplete()
		{
			//Discarded unreachable code: IL_0048
			if ((long)cutsceneRef == 0)
			{
				CutsceneSystem system = SystemRoot.Instance.GetSystem<CutsceneSystem>();
				if ((object)system != null)
				{
					string text = cutsceneId;
					system.RemoveCutscene(text);
				}
			}
			else
			{
				CutsceneSystem system2 = SystemRoot.Instance.GetSystem<CutsceneSystem>();
				while ((object)system2 == null)
				{
				}
				AssetReference reference = cutsceneRef;
				system2.RemoveCutscene(reference);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001934")]
		[Cpp2IlInjected.Address(RVA = "0x14B9630", Offset = "0x14B8030", VA = "0x1814B9630")]
		public PlayCutscene()
		{
		}
	}
}
