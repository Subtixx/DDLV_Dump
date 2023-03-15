using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Utils;
using Meta;
using Meta.Online;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes.Clips
{
	[Cpp2IlInjected.Token(Token = "0x2000605")]
	public class CutsceneAutoPullWeed : CutsceneClip, ITimelineCutsceneCleanUp
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400245F")]
		[ItemID]
		[SerializeField]
		private int item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002460")]
		[SerializeField]
		private float waitBefore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002461")]
		[SerializeField]
		private float waitAfter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002462")]
		private float waitTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002463")]
		private bool initialized;

		[Cpp2IlInjected.Token(Token = "0x170003D1")]
		private Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x6001A9D")]
			[Cpp2IlInjected.Address(RVA = "0x1110DA0", Offset = "0x110F7A0", VA = "0x181110DA0")]
			get
			{
				long num = Convert.ToInt64((uint)item);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A9E")]
		[Cpp2IlInjected.Address(RVA = "0x1110C50", Offset = "0x110F650", VA = "0x181110C50")]
		public void Play()
		{
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A9F")]
		[Cpp2IlInjected.Address(RVA = "0x11107C0", Offset = "0x110F1C0", VA = "0x1811107C0", Slot = "4")]
		public override bool Play(float elapsed)
		{
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
					if (gridCollection_ != null)
					{
						int num3 = 0;
						GameObject gameObject = default(GameObject);
						VillageEnvironment component = gameObject.GetComponent<VillageEnvironment>();
						GridObjectScript gridObjectScript = default(GridObjectScript);
						ItemScript component2 = gridObjectScript.GetComponent<ItemScript>();
						PullWeed.Types.Request request = new PullWeed.Types.Request();
						uint num4 = (request.gridID_ = gridObjectScript.GridScript.GridID);
						uint num5 = (request.gridObjectID_ = gridObjectScript.GridObject.iD_);
						request.automatic_ = true;
						Transform transform = component2.transform;
						Vector3 vector = default(Vector3);
						float z = vector.z;
						int num6 = 0;
						Task asyncTask = default(Task);
						asyncTask.FireAndForgetTask();
					}
				}
				return true;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public override void Stop()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public override void Pause()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void Resume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA3")]
		[Cpp2IlInjected.Address(RVA = "0x1110C70", Offset = "0x110F670", VA = "0x181110C70")]
		[AsyncStateMachine(typeof(_003CPullWeed_003Ed__12))]
		private Task PullWeed(PullWeed.Types.Request pullWeedRequest, Vector3 position)
		{
			int num = 0;
			int num2 = 0;
			float z = position.z;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA4")]
		[Cpp2IlInjected.Address(RVA = "0x11107A0", Offset = "0x110F1A0", VA = "0x1811107A0", Slot = "8")]
		public void EndCutsceneCleanup()
		{
			if (!initialized)
			{
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA5")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CutsceneAutoPullWeed()
		{
		}
	}
}
