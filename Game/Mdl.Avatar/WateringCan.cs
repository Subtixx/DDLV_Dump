using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Grids;
using Meta.Online;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000ACE")]
	internal class WateringCan : Tool
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4003BD1")]
		public float radius = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x4003BD2")]
		public float angle = 90f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4003BD3")]
		public AssetReferenceGameObject waterVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4003BD4")]
		public AK.Wwise.Event waterSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4003BD5")]
		public AssetReferenceGameObject buffedWaterVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4003BD6")]
		public AssetReferenceGameObject wateringActionVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4003BD7")]
		public AssetReferenceGameObject buffedWateringActionVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4003BD8")]
		public AK.Wwise.Event bounceSfx;

		[Cpp2IlInjected.Token(Token = "0x4003BD9")]
		private const bool OnlyWhenDry = false;

		[Cpp2IlInjected.Token(Token = "0x4003BDA")]
		private const bool PreviewOnlyWhenDry = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4003BDB")]
		private GridObjectScriptCache cachedGridObjectScripts = new GridObjectScriptCache();

		[Cpp2IlInjected.Token(Token = "0x4003BDC")]
		private static readonly ProfilerMarker s_previewComplete;

		[Cpp2IlInjected.Token(Token = "0x4003BDD")]
		private static readonly ProfilerMarker s_previewWaterableInReach;

		[Cpp2IlInjected.Token(Token = "0x4003BDE")]
		private static readonly ProfilerMarker s_previewGridPositionInRadius;

		[Cpp2IlInjected.Token(Token = "0x4003BDF")]
		private static readonly ProfilerMarker s_previewIsValid;

		[Cpp2IlInjected.Token(Token = "0x4003BE0")]
		private static readonly ProfilerMarker s_previewIsInReach;

		[Cpp2IlInjected.Token(Token = "0x4003BE1")]
		private static readonly ProfilerMarker s_previewIsValidFlower;

		[Cpp2IlInjected.Token(Token = "0x4003BE2")]
		private static readonly ProfilerMarker s_previewIsValidGardeningSlot;

		[Cpp2IlInjected.Token(Token = "0x4003BE3")]
		private static readonly ProfilerMarker s_slotTryGet;

		[Cpp2IlInjected.Token(Token = "0x4003BE4")]
		private static readonly ProfilerMarker s_slotWaterState;

		[Cpp2IlInjected.Token(Token = "0x4003BE5")]
		private static readonly ProfilerMarker s_seedLookup;

		[Cpp2IlInjected.Token(Token = "0x170006E8")]
		public override Toolbox.ToolType ToolType
		{
			[Cpp2IlInjected.Token(Token = "0x60031CD")]
			[Cpp2IlInjected.Address(RVA = "0xD51100", Offset = "0xD4FB00", VA = "0x180D51100", Slot = "8")]
			get
			{
				return Toolbox.ToolType.WateringCan;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031CE")]
		[Cpp2IlInjected.Address(RVA = "0xD50B20", Offset = "0xD4F520", VA = "0x180D50B20", Slot = "9")]
		[AsyncStateMachine(typeof(_003CUseTool_003Ed__13))]
		protected override Task<bool> UseTool(PlayerAvatar avatar)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60031CF")]
		[Cpp2IlInjected.Address(RVA = "0xD4F760", Offset = "0xD4E160", VA = "0x180D4F760", Slot = "10")]
		public override (IEnumerable<GameObject>, IEnumerable<Vector3>) GetToolPreview(PlayerAvatar avatar)
		{
			//Discarded unreachable code: IL_00bf, IL_00c5, IL_00cb, IL_00d1, IL_00d7, IL_00dd
			//IL_0041: Expected O, but got I4
			//IL_007b: Expected F4, but got I4
			int num = 0;
			int num2 = 0;
			ProfilerMarker profilerMarker = s_previewComplete;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			Mdl.Environments.Environment component = gameObject.GetComponent<Mdl.Environments.Environment>();
			int num3 = 0;
			GridScript gridScript = default(GridScript);
			if (!(gridScript != (UnityEngine.Object)num3))
			{
				(IEnumerable<GameObject>, IEnumerable<Vector3>) noPreview = ((IEnumerable<GameObject>, IEnumerable<Vector3>))Tool.get_NoPreview();
			}
			Toolbox.ToolType previousToolType = avatar.relaxToolScope.previousToolType;
			_003CWaterableObjectsInReach_003Ed__23 _003CWaterableObjectsInReach_003Ed__ = new _003CWaterableObjectsInReach_003Ed__23(-2);
			_003CWaterableObjectsInReach_003Ed__._003C_003E4__this = (WateringCan)(object)avatar;
			_003CWaterableObjectsInReach_003Ed__._003C_003E3__gridScript = gridScript;
			_003CWaterableObjectsInReach_003Ed__._003C_003E3__radius = (float)previousToolType;
			_003CWaterableObjectsInReach_003Ed__._003C_003E3__onlyWhenDry = true;
			Func<(GridObject, GridObjectScript, bool), GameObject> _003C_003E9__21_ = _003C_003Ec._003C_003E9__21_0;
			if (_003C_003E9__21_ == null)
			{
				GameObject result2 = default(GameObject);
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)(((GridObject gridObject, GridObjectScript gridObjectScript, bool isGardeningSlot) result) => result2);
			}
			IEnumerable<(GridObject, GridObjectScript, bool)> enumerable = (IEnumerable<(GridObject, GridObjectScript, bool)>)Enumerable.Select<(GridObject, GridObjectScript, bool), GameObject>((IEnumerable<>)(object)_003CWaterableObjectsInReach_003Ed__, (Func<, >)(object)_003C_003E9__21_);
			Vector3[] noPreviewPositions = Tool.NoPreviewPositions;
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031D0")]
		[Cpp2IlInjected.Address(RVA = "0xD50790", Offset = "0xD4F190", VA = "0x180D50790", Slot = "12")]
		protected override void OnUnequipped()
		{
			GridObjectScriptCache gridObjectScriptCache = (cachedGridObjectScripts = new GridObjectScriptCache());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60031D1")]
		[Cpp2IlInjected.Address(RVA = "0xD50C50", Offset = "0xD4F650", VA = "0x180D50C50")]
		[IteratorStateMachine(typeof(_003CWaterableObjectsInReach_003Ed__23))]
		private IEnumerable<(GridObject, GridObjectScript, bool)> WaterableObjectsInReach(GridScript gridScript, PlayerAvatar avatar, float radius, bool onlyWhenDry)
		{
			_003CWaterableObjectsInReach_003Ed__23 _003CWaterableObjectsInReach_003Ed__ = new _003CWaterableObjectsInReach_003Ed__23(-2);
			_003CWaterableObjectsInReach_003Ed__._003C_003E4__this = this;
			_003CWaterableObjectsInReach_003Ed__._003C_003E3__gridScript = gridScript;
			_003CWaterableObjectsInReach_003Ed__._003C_003E3__avatar = avatar;
			_003CWaterableObjectsInReach_003Ed__._003C_003E3__onlyWhenDry = false;
			_003CWaterableObjectsInReach_003Ed__._003C_003E3__radius = radius;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031D2")]
		[Cpp2IlInjected.Address(RVA = "0xD4FC20", Offset = "0xD4E620", VA = "0x180D4FC20")]
		[IteratorStateMachine(typeof(_003CGridPositionsInRadius_003Ed__24))]
		private IEnumerable<GridPosition> GridPositionsInRadius(GridScript gridScript, GridPosition center, float radius)
		{
			_003CGridPositionsInRadius_003Ed__24 _003CGridPositionsInRadius_003Ed__ = new _003CGridPositionsInRadius_003Ed__24(-2);
			_003CGridPositionsInRadius_003Ed__._003C_003E3__gridScript = gridScript;
			_003CGridPositionsInRadius_003Ed__._003C_003E3__radius = radius;
			_003CGridPositionsInRadius_003Ed__._003C_003E3__center = center;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031D3")]
		[Cpp2IlInjected.Address(RVA = "0xD4FCC0", Offset = "0xD4E6C0", VA = "0x180D4FCC0")]
		private bool IsInReach(PlayerAvatar avatar, GridObjectScript gridObjectScript)
		{
			//Discarded unreachable code: IL_004f, IL_0055, IL_005b, IL_0061
			int num = 0;
			int num2 = 0;
			ProfilerMarker profilerMarker = s_previewIsInReach;
			Transform transform = gridObjectScript.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			int num3 = 0;
			float num4 = default(float);
			if (!(radius >= num4))
			{
			}
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			float num5 = angle;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031D4")]
		[Cpp2IlInjected.Address(RVA = "0xD4FEF0", Offset = "0xD4E8F0", VA = "0x180D4FEF0")]
		private bool IsValidFlower(GridObject gridObject, bool onlyWhenDry)
		{
			//Discarded unreachable code: IL_005e, IL_0064
			int num = 0;
			int num2 = 0;
			ProfilerMarker profilerMarker = s_previewIsValidFlower;
			int itemID = gridObject.ItemID;
			bool flag = default(bool);
			ActivityItemType activityItemType = default(ActivityItemType);
			if (flag && activityItemType == ActivityItemType.Flower)
			{
				GridState state_ = gridObject.state_;
				if (state_ != null)
				{
					FlowerData flowerData = state_.FlowerData;
					if (flowerData != null)
					{
						bool dry_ = flowerData.dry_;
					}
					GridState state_2 = gridObject.state_;
					if (state_2 != null)
					{
						FlowerData flowerData2 = state_2.FlowerData;
					}
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031D5")]
		[Cpp2IlInjected.Address(RVA = "0xD50120", Offset = "0xD4EB20", VA = "0x180D50120")]
		private bool IsValidGardeningSlot(IGrid grid, GridObject gridObject, bool onlyWhenDry)
		{
			//Discarded unreachable code: IL_010f, IL_0115, IL_011b, IL_0121, IL_0127, IL_012d, IL_0133, IL_0139, IL_013f, IL_0145, IL_014b, IL_0151, IL_0157, IL_015d, IL_0163, IL_0169
			//IL_00fa: Expected O, but got I4
			int num = 0;
			ProfilerMarker profilerMarker = s_previewIsValidGardeningSlot;
			ProfilerMarker profilerMarker2 = s_slotTryGet;
			int itemID = gridObject.ItemID;
			bool flag = default(bool);
			BuildingItemType buildingItemType = default(BuildingItemType);
			if (flag && buildingItemType == BuildingItemType.Garden)
			{
				GridState state_ = gridObject.state_;
				if (state_ != null)
				{
					GardenData gardenData = state_.GardenData;
					if (gardenData != null)
					{
						RepeatedField<GardenData.Types.GardeningSlot> slots_ = gardenData.slots_;
						if (slots_ != null)
						{
							int count = ((RepeatedField<T>)(object)slots_).Count;
						}
					}
					if (((num == 1) ? 1 : 0) == num)
					{
					}
				}
			}
			int num2 = 0;
			uint num3 = default(uint);
			if (num3 != 0)
			{
				if ((long)profilerMarker2 == 400)
				{
				}
				if ((long)profilerMarker2 != 175)
				{
				}
			}
			GardenData gardenData2 = default(GardenData);
			RepeatedField<GardenData.Types.GardeningSlot> slots_2 = gardenData2.slots_;
			int index = 0;
			GardenData.Types.GardeningSlot gardeningSlot = (GardenData.Types.GardeningSlot)((RepeatedField<T>)(object)slots_2)[index];
			if (gardeningSlot.Sapling != null)
			{
				ProfilerMarker profilerMarker3 = s_slotWaterState;
				ProfilerMarker profilerMarker4 = s_seedLookup;
				Item plantedSeedItem = gardeningSlot.PlantedSeedItem;
				num3++;
				int num4 = 0;
				if (num3 != 0)
				{
				}
				SaplingGrowthData sapling = gardeningSlot.Sapling;
				Client client = default(Client);
				ProfileWorld world_ = client.profile.world_;
				Client client2 = default(Client);
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client2.TransactionContext;
				Client client3 = default(Client);
				Village village = client3.profile.Village;
				bool inVillage = default(bool);
				WateringState wateringState = sapling.GetWateringState((SeedItemData)num2, world_, _003CTransactionContext_003Ek__BackingField, inVillage);
				num3++;
				if (num3 == 0)
				{
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031D6")]
		[Cpp2IlInjected.Address(RVA = "0xD51050", Offset = "0xD4FA50", VA = "0x180D51050")]
		public WateringCan()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60031D7")]
		[Cpp2IlInjected.Address(RVA = "0xD50D20", Offset = "0xD4F720", VA = "0x180D50D20")]
		static WateringCan()
		{
			//IL_0025: Expected O, but got I
			//IL_0047: Expected O, but got I
			//IL_0069: Expected O, but got I
			//IL_008b: Expected O, but got I
			//IL_00ad: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00f1: Expected O, but got I
			//IL_0113: Expected O, but got I
			//IL_0135: Expected O, but got I
			//IL_0150: Expected O, but got I
			int num = 0;
			int num2 = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker("PreviewWateringCan", categoryId, (MarkerFlags)flags, metadataCount);
			int num3 = 0;
			s_previewComplete = (ProfilerMarker)(long)intPtr;
			int flags2 = 0;
			int metadataCount2 = 0;
			ushort categoryId2 = default(ushort);
			IntPtr intPtr2 = ProfilerUnsafeUtility.CreateMarker("WaterableObjectsInReach", categoryId2, (MarkerFlags)flags2, metadataCount2);
			int num4 = 0;
			s_previewWaterableInReach = (ProfilerMarker)(long)intPtr2;
			int flags3 = 0;
			int metadataCount3 = 0;
			ushort categoryId3 = default(ushort);
			IntPtr intPtr3 = ProfilerUnsafeUtility.CreateMarker("GridPositionInRadius", categoryId3, (MarkerFlags)flags3, metadataCount3);
			int num5 = 0;
			s_previewGridPositionInRadius = (ProfilerMarker)(long)intPtr3;
			int flags4 = 0;
			int metadataCount4 = 0;
			ushort categoryId4 = default(ushort);
			IntPtr intPtr4 = ProfilerUnsafeUtility.CreateMarker("ValidityCheck", categoryId4, (MarkerFlags)flags4, metadataCount4);
			int num6 = 0;
			s_previewIsValid = (ProfilerMarker)(long)intPtr4;
			int flags5 = 0;
			int metadataCount5 = 0;
			ushort categoryId5 = default(ushort);
			IntPtr intPtr5 = ProfilerUnsafeUtility.CreateMarker("IsInReach", categoryId5, (MarkerFlags)flags5, metadataCount5);
			int num7 = 0;
			s_previewIsInReach = (ProfilerMarker)(long)intPtr5;
			int flags6 = 0;
			int metadataCount6 = 0;
			ushort categoryId6 = default(ushort);
			IntPtr intPtr6 = ProfilerUnsafeUtility.CreateMarker("IsValidFlower", categoryId6, (MarkerFlags)flags6, metadataCount6);
			int num8 = 0;
			s_previewIsValidFlower = (ProfilerMarker)(long)intPtr6;
			int flags7 = 0;
			int metadataCount7 = 0;
			ushort categoryId7 = default(ushort);
			IntPtr intPtr7 = ProfilerUnsafeUtility.CreateMarker("IsValidGardeningSlot", categoryId7, (MarkerFlags)flags7, metadataCount7);
			int num9 = 0;
			s_previewIsValidGardeningSlot = (ProfilerMarker)(long)intPtr7;
			int flags8 = 0;
			int metadataCount8 = 0;
			ushort categoryId8 = default(ushort);
			IntPtr intPtr8 = ProfilerUnsafeUtility.CreateMarker("GardenTryGet", categoryId8, (MarkerFlags)flags8, metadataCount8);
			int num10 = 0;
			s_slotTryGet = (ProfilerMarker)(long)intPtr8;
			int flags9 = 0;
			int metadataCount9 = 0;
			ushort categoryId9 = default(ushort);
			IntPtr intPtr9 = ProfilerUnsafeUtility.CreateMarker("WateringState", categoryId9, (MarkerFlags)flags9, metadataCount9);
			int num11 = 0;
			s_slotWaterState = (ProfilerMarker)(long)intPtr9;
			int flags10 = 0;
			int metadataCount10 = 0;
			ushort categoryId10 = default(ushort);
			s_seedLookup = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("SeedLookup", categoryId10, (MarkerFlags)flags10, metadataCount10);
		}
	}
}
