using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.Characters.Critters;
using Mdl.Ftue.Cutscenes;
using Mdl.Grid;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Util;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x20006A3")]
	public class VillageEnvironment : Environment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400273C")]
		[SerializeField]
		[ItemID]
		private int _sceneItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400273D")]
		[Proto("Meta.VillageAreaData, Meta")]
		public string VillageAreaDataName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400273E")]
		[ItemID]
		public int FirstMission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400273F")]
		[ItemID]
		[SerializeField]
		private int introCutsceneID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002740")]
		[SerializeField]
		private Cutscene introCutsceneObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002741")]
		private readonly Item PlayerHouseItem = (Item)Convert.ToInt64(20500000u);

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002742")]
		private VillageArea[] villageAreas;

		[Cpp2IlInjected.Token(Token = "0x4002743")]
		internal static bool RebuildNavMeshOnRefresh;

		[Cpp2IlInjected.Token(Token = "0x17000422")]
		public SceneItemData VillageSceneItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001D70")]
			[Cpp2IlInjected.Address(RVA = "0xD48520", Offset = "0xD46F20", VA = "0x180D48520")]
			get
			{
				//Discarded unreachable code: IL_0016
				int sceneItem = _sceneItem;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)sceneItem);
				SceneItemData result = default(SceneItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000423")]
		private Item FirstMissionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001D71")]
			[Cpp2IlInjected.Address(RVA = "0xD48390", Offset = "0xD46D90", VA = "0x180D48390")]
			get
			{
				long num = Convert.ToInt64((uint)FirstMission);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000424")]
		public IEnumerable<VillageArea> VillageAreas
		{
			[Cpp2IlInjected.Token(Token = "0x6001D72")]
			[Cpp2IlInjected.Address(RVA = "0x856180", Offset = "0x854B80", VA = "0x180856180")]
			get
			{
				VillageArea[] array = villageAreas;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000425")]
		public override IEnumerable<GridScript> GridScriptsList
		{
			[Cpp2IlInjected.Token(Token = "0x6001D73")]
			[Cpp2IlInjected.Address(RVA = "0xD483F0", Offset = "0xD46DF0", VA = "0x180D483F0", Slot = "4")]
			get
			{
				VillageArea[] array = villageAreas;
				Func<VillageArea, GridScript> _003C_003E9__14_ = _003C_003Ec._003C_003E9__14_0;
				if (_003C_003E9__14_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((VillageArea x) => x.GridScript);
				}
				return (IEnumerable<GridScript>)Enumerable.Select<VillageArea, GridScript>((IEnumerable<>)(object)array, (Func<, >)(object)_003C_003E9__14_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D74")]
		[Cpp2IlInjected.Address(RVA = "0xD47A80", Offset = "0xD46480", VA = "0x180D47A80")]
		private void OnDestroy()
		{
			AudioManager.OnCutsceneAudioPop -= StopCutsceneAudio;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D75")]
		[Cpp2IlInjected.Address(RVA = "0xD47910", Offset = "0xD46310", VA = "0x180D47910", Slot = "8")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__17))]
		protected override Task Init(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D76")]
		[Cpp2IlInjected.Address(RVA = "0xD47B20", Offset = "0xD46520", VA = "0x180D47B20", Slot = "11")]
		public override void RefreshGrid()
		{
			//Discarded unreachable code: IL_0039
			NavMeshSurface[] componentsInChildren = GetComponentsInChildren<NavMeshSurface>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				NavMeshSurface navMeshSurface = componentsInChildren[num];
				NavMeshData navMeshData = navMeshSurface.m_NavMeshData;
				AsyncOperation asyncOperation = navMeshSurface.UpdateNavMesh(navMeshData);
				num++;
			}
			base.RefreshGrid();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D77")]
		[Cpp2IlInjected.Address(RVA = "0xD471F0", Offset = "0xD45BF0", VA = "0x180D471F0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CEnterEnvironment_003Ed__19))]
		internal override Task EnterEnvironment(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D78")]
		[Cpp2IlInjected.Address(RVA = "0xD47360", Offset = "0xD45D60", VA = "0x180D47360", Slot = "7")]
		internal override Task ExitEnvironment(Profile profile, PlayerAvatar avatar, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0019
			SystemRoot.Instance.GetSystem<CritterManager>().UpdateState();
			return base.ExitEnvironment(profile, avatar, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D79")]
		[Cpp2IlInjected.Address(RVA = "0xD47870", Offset = "0xD46270", VA = "0x180D47870")]
		public GridScript GetGridScript(IGrid grid)
		{
			VillageArea[] array = villageAreas;
			int num = 0;
			int length = array.Length;
			if (num < length)
			{
				if (array[num].GetComponent<GridScript>().Grid == grid)
				{
					goto IL_002e;
				}
				num++;
			}
			int num2 = 0;
			goto IL_002e;
			IL_002e:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D7A")]
		[Cpp2IlInjected.Address(RVA = "0xD47480", Offset = "0xD45E80", VA = "0x180D47480", Slot = "12")]
		public unsafe override GridScript GetCurrentGrid(Vector3 position, out bool voidGrid)
		{
			//IL_00b9: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			int num = 0;
			VillageArea[] array = villageAreas;
			int num2;
			VillageArea villageArea;
			if (array != null)
			{
				num2 = 0;
				int length = array.Length;
				if (num2 < length)
				{
					villageArea = array[num2];
					Transform gridOrigin = villageArea.GridScript.GridOrigin;
					Transform gridOrigin2 = villageArea.GridScript.GridOrigin;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					GridData gridData = villageArea.GridScript.GridData;
					GridScript gridScript = villageArea.GridScript;
					int num3 = 0;
					GridData gridData2 = gridScript.GridData;
					float z2 = position.z;
					bool flag = default(bool);
					if (flag)
					{
						GridScript gridScript2 = villageArea.GridScript;
						int allowInvalid = 0;
						GridPosition gridPosition = gridScript2.GetGridPosition(in *(Vector3*)position, 1, (byte)allowInvalid != 0);
						GridData gridData3 = villageArea.GridScript.GridData;
						GridFloorType gridFloorType = default(GridFloorType);
						int num4 = (int)gridFloorType;
						bool flag2 = default(bool);
						if (!flag2)
						{
							goto IL_00d7;
						}
						int num5 = 0;
						if ((UnityEngine.Object)num2 == (UnityEngine.Object)num5)
						{
							Transform gridOrigin3 = villageArea.GridScript.GridOrigin;
							GridScript gridScript3 = villageArea.GridScript;
						}
					}
					num2++;
					goto IL_00d7;
				}
			}
			int num6 = 0;
			throw new NullReferenceException();
			IL_00d7:
			voidGrid.m_value = (byte)num2 != 0;
			return villageArea.GridScript;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D7B")]
		[Cpp2IlInjected.Address(RVA = "0xD47C10", Offset = "0xD46610", VA = "0x180D47C10", Slot = "6")]
		protected override void SetAudioEnvironment()
		{
			//Discarded unreachable code: IL_0096
			//IL_0028: Expected O, but got I4
			RepeatedField<int> completedFtueEvents_ = SystemRoot.Instance.MetaClient.profile.player_.completedFtueEvents_;
			int num = introCutsceneID;
			if (!((RepeatedField<T>)(object)completedFtueEvents_).Contains((T)num))
			{
				int num2 = 0;
				if (!DebugSettings.Settings.disableAllFtue_)
				{
					int num3 = 0;
					if (!DebugSettings.WasCreatedThisSession)
					{
						AudioManager.OnCutsceneAudioPop -= StopCutsceneAudio;
						AudioManager.OnCutsceneAudioPop += StopCutsceneAudio;
						return;
					}
				}
			}
			if (!SystemRoot.Instance.GetSystem<AudioManager>().ContainsGameState(AudioManager.GameState.IngameExplor))
			{
				SystemRoot.Instance.GetSystem<AudioManager>().PushGameState(AudioManager.GameState.IngameExplor);
			}
			base.SetAudioEnvironment();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D7C")]
		[Cpp2IlInjected.Address(RVA = "0xD47FB0", Offset = "0xD469B0", VA = "0x180D47FB0")]
		private void StopCutsceneAudio(Cutscene cutscene)
		{
			//Discarded unreachable code: IL_0065
			//IL_0009: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			int num = 0;
			if (cutscene == (UnityEngine.Object)num)
			{
				return;
			}
			Cutscene cutscene2 = introCutsceneObj;
			int num2 = 0;
			if (cutscene2 == (UnityEngine.Object)num2)
			{
				return;
			}
			string cutsceneId = introCutsceneObj.cutsceneId;
			if (string.Equals(cutscene.cutsceneId, cutsceneId))
			{
				AudioManager audioManager = default(AudioManager);
				if (!audioManager.ContainsGameState(AudioManager.GameState.IngameExplor))
				{
					AudioManager audioManager2 = default(AudioManager);
					audioManager2.PushGameState(AudioManager.GameState.IngameExplor);
				}
				AudioManager.OnCutsceneAudioPop -= StopCutsceneAudio;
				base.SetAudioEnvironment();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D7D")]
		[Cpp2IlInjected.Address(RVA = "0xD48320", Offset = "0xD46D20", VA = "0x180D48320")]
		public VillageEnvironment()
		{
		}//IL_0013: Expected O, but got I8

	}
}
