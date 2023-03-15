using System;
using System.Linq;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes.Clips
{
	[Cpp2IlInjected.Token(Token = "0x2000609")]
	public class CutsceneExecutePlayerTask : CutsceneClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400246F")]
		[ItemID]
		[SerializeField]
		private int item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002470")]
		[SerializeField]
		private PlayerTaskDefinition overrideTaskDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002471")]
		[SerializeField]
		private float waitBefore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002472")]
		[SerializeField]
		private float waitAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002473")]
		private float waitTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002474")]
		private bool initialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002475")]
		private CancellationTokenSource cts = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x170003D2")]
		private Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001AB5")]
			[Cpp2IlInjected.Address(RVA = "0x1111B20", Offset = "0x1110520", VA = "0x181111B20")]
			get
			{
				long num = Convert.ToInt64((uint)item);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB6")]
		[Cpp2IlInjected.Address(RVA = "0x1111690", Offset = "0x1110090", VA = "0x181111690", Slot = "4")]
		public override bool Play(float elapsed)
		{
			//IL_0099: Expected O, but got I4
			int num = this.item;
			if ((object)typeof(Item).TypeHandle == null)
			{
				waitTime = elapsed;
				if ((IntPtr)(initialized ? 1 : 0) != (IntPtr)typeof(Item).TypeHandle)
				{
					float num2 = waitAfter;
				}
				if (!(waitBefore > elapsed))
				{
					initialized = true;
					waitTime = 0f;
					Client client = default(Client);
					GridCollection gridCollection_ = client.profile.world_.gridCollection_;
					Item item = Item;
					SceneData sceneData = default(SceneData);
					AsyncOperation operation = sceneData.sceneInstance.m_Operation;
					CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
					GameObject gameObject = default(GameObject);
					VillageEnvironment component = gameObject.GetComponent<VillageEnvironment>();
					GridObjectScript gridObjectScript = default(GridObjectScript);
					PlayerTaskCollider component2 = gridObjectScript.GetComponent<PlayerTaskCollider>();
					int num3 = 0;
					bool flag = component2 != (UnityEngine.Object)num3;
					if (!flag)
					{
						return flag;
					}
					PlayerTaskDefinition playerTaskDefinition = Enumerable.FirstOrDefault<PlayerTaskDefinition>(component2.GetAllTasks());
					PlayerNavigation playerNavigation = default(PlayerNavigation);
					CancellationToken cancellationToken = default(CancellationToken);
					playerNavigation.QueueTask(playerTaskDefinition, component2, cancellationToken).FireAndForgetTask();
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB7")]
		[Cpp2IlInjected.Address(RVA = "0x1111A90", Offset = "0x1110490", VA = "0x181111A90", Slot = "5")]
		public override void Stop()
		{
			//Discarded unreachable code: IL_000c
			cts.Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void Pause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AB9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void Resume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001ABA")]
		[Cpp2IlInjected.Address(RVA = "0x1111AB0", Offset = "0x11104B0", VA = "0x181111AB0")]
		public CutsceneExecutePlayerTask()
		{
		}
	}
}
