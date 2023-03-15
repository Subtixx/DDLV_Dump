using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Systems;
using Mdl.Utils;
using ScreenEffect;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000ACB")]
	internal class ToolPreviewSystem : Mdl.Systems.System
	{
		[Cpp2IlInjected.Token(Token = "0x2000ACC")]
		private class PreviewTilePool
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003BCB")]
			protected GameObject prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003BCC")]
			protected Transform owner;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003BCD")]
			protected readonly Dictionary<int, GameObject> activeTiles = (Dictionary<int, GameObject>)(object)new Dictionary<TKey, TValue>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4003BCE")]
			protected readonly Queue<GameObject> inactiveTiles = (Queue<GameObject>)(object)new Queue<T>();

			[Cpp2IlInjected.Token(Token = "0x60031C7")]
			[Cpp2IlInjected.Address(RVA = "0x1413780", Offset = "0x1412180", VA = "0x181413780")]
			public PreviewTilePool(GameObject prefab, Transform owner)
			{
				this.prefab = prefab;
				this.owner = owner;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60031C8")]
			[Cpp2IlInjected.Address(RVA = "0x14135C0", Offset = "0x1411FC0", VA = "0x1814135C0")]
			public unsafe GameObject Instantiate(Vector3 position)
			{
				//Discarded unreachable code: IL_0031, IL_0034
				int hashCode = ((Vector3*)position)->GetHashCode();
				Queue<GameObject> queue = inactiveTiles;
				float z = position.z;
				GameObject gameObject = prefab;
				Quaternion identity = Quaternion.identity;
				Dictionary<int, GameObject> dictionary = activeTiles;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60031C9")]
			[Cpp2IlInjected.Address(RVA = "0x1413410", Offset = "0x1411E10", VA = "0x181413410")]
			public unsafe void Destroy(Vector3 position)
			{
				//Discarded unreachable code: IL_0014, IL_0018, IL_0031, IL_0067
				//IL_002b: Expected O, but got F4
				//IL_002b: Expected O, but got F4
				//IL_003d: Expected O, but got I4
				//IL_004b: Expected O, but got I4
				int hashCode = ((Vector3*)position)->GetHashCode();
				Dictionary<int, GameObject> dictionary = activeTiles;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003BC5")]
		private FrameRelevantGameObjectCollection previewGameObjects = new FrameRelevantGameObjectCollection();

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003BC6")]
		private FrameRelevantCollection<Vector3> previewGridPositions = (FrameRelevantCollection<Vector3>)(object)new FrameRelevantCollection<ObjectType>();

		[Cpp2IlInjected.Token(Token = "0x4003BC7")]
		private static readonly ProfilerMarker s_ToolPreviewSystem;

		[Cpp2IlInjected.Token(Token = "0x4003BC8")]
		private static readonly ProfilerMarker s_ToolPreviewSystem_GetToolPreview;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003BC9")]
		public GameObject tilePreviewPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003BCA")]
		private PreviewTilePool tilePool;

		[Cpp2IlInjected.Token(Token = "0x60031B7")]
		[Cpp2IlInjected.Address(RVA = "0x13D5D40", Offset = "0x13D4740", VA = "0x1813D5D40", Slot = "4")]
		public override void OnSystemStart(ISystemData data)
		{
			//Discarded unreachable code: IL_0098
			GameObject prefab = tilePreviewPrefab;
			Transform owner = base.transform;
			PreviewTilePool previewTilePool = (tilePool = new PreviewTilePool(prefab, owner));
			FrameRelevantGameObjectCollection frameRelevantGameObjectCollection = previewGameObjects;
			EventHandler<GameObject> eventHandler = (EventHandler<GameObject>)(object)(EventHandler<TEventArgs>)delegate(object sender, GameObject gameObject)
			{
				//IL_0009: Expected O, but got I4
				int num2 = 0;
				Highlight.AddHighlightTo(gameObject, (AnimationCurve)num2);
			};
			((FrameRelevantCollection<ObjectType>)(object)frameRelevantGameObjectCollection).add_OnBecameRelevant((EventHandler<>)(object)eventHandler);
			FrameRelevantGameObjectCollection frameRelevantGameObjectCollection2 = previewGameObjects;
			EventHandler<GameObject> eventHandler2 = (EventHandler<GameObject>)(object)(EventHandler<TEventArgs>)delegate(object sender, GameObject gameObject)
			{
				//IL_0009: Expected O, but got I4
				int num = 0;
				Highlight.RemoveHighlightFrom(gameObject, (AnimationCurve)num);
			};
			((FrameRelevantCollection<ObjectType>)(object)frameRelevantGameObjectCollection2).add_OnLostRelevant((EventHandler<>)(object)eventHandler2);
			FrameRelevantCollection<Vector3> frameRelevantCollection = previewGridPositions;
			EventHandler<Vector3> eventHandler3 = (EventHandler<Vector3>)(object)(EventHandler<TEventArgs>)delegate(object sender, Vector3 position)
			{
				//Discarded unreachable code: IL_000f
				PreviewTilePool previewTilePool3 = tilePool;
				float z2 = position.z;
			};
			((FrameRelevantCollection<ObjectType>)(object)frameRelevantCollection).add_OnBecameRelevant((EventHandler<>)(object)eventHandler3);
			FrameRelevantCollection<Vector3> frameRelevantCollection2 = previewGridPositions;
			EventHandler<Vector3> eventHandler4 = (EventHandler<Vector3>)(object)(EventHandler<TEventArgs>)delegate(object sender, Vector3 position)
			{
				//Discarded unreachable code: IL_000f
				PreviewTilePool previewTilePool2 = tilePool;
				float z = position.z;
			};
			((FrameRelevantCollection<ObjectType>)(object)frameRelevantCollection2).add_OnLostRelevant((EventHandler<>)(object)eventHandler4);
		}

		[Cpp2IlInjected.Token(Token = "0x60031B8")]
		[Cpp2IlInjected.Address(RVA = "0x13D5CA0", Offset = "0x13D46A0", VA = "0x1813D5CA0", Slot = "6")]
		public override void OnSystemPause()
		{
			if (((FrameRelevantCollection<ObjectType>)(object)previewGameObjects).UpdateFrameRelevancy() == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031B9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void OnSystemResume()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60031BA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public override void OnSystemStop()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60031BB")]
		[Cpp2IlInjected.Address(RVA = "0x13D6200", Offset = "0x13D4C00", VA = "0x1813D6200")]
		private void Update()
		{
			//Discarded unreachable code: IL_0088, IL_008e, IL_0094, IL_009a, IL_00a0, IL_00a6
			//IL_0049: Expected O, but got I4
			int num = 0;
			FrameRelevantCollection<GameObject>.UpdateRelevancy updateRelevancy = (FrameRelevantCollection<GameObject>.UpdateRelevancy)(object)((FrameRelevantCollection<ObjectType>)(object)previewGameObjects).UpdateFrameRelevancy();
			FrameRelevantCollection<Vector3>.UpdateRelevancy updateRelevancy2 = (FrameRelevantCollection<Vector3>.UpdateRelevancy)(object)((FrameRelevantCollection<ObjectType>)(object)previewGridPositions).UpdateFrameRelevancy();
			Toolbox _003CToolbox_003Ek__BackingField = avatar.Toolbox;
			if (_003CToolbox_003Ek__BackingField._currentToolType != 0)
			{
				Toolbox.ToolType currentToolType = _003CToolbox_003Ek__BackingField._currentToolType;
				int num2 = 0;
				Toolbox.ToolType valueOrDefault = MoreLinq.GetValueOrDefault<Toolbox.ToolType, Tool>((IReadOnlyDictionary<, >)_003CToolbox_003Ek__BackingField.toolsByType, (Tool)currentToolType, (Toolbox.ToolType)num2);
				if (_003C_003Ec._003C_003E9__10_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GameObject r)
					{
						//Discarded unreachable code: IL_0011
						//IL_0010: Expected O, but got I4
						Renderer componentInChildren = r.GetComponentInChildren<Renderer>();
						int num4 = 0;
						return componentInChildren != (UnityEngine.Object)num4;
					};
				}
				IEnumerable<GameObject> enumerable = default(IEnumerable<GameObject>);
				IEnumerable<GameObject> enumerable2 = (IEnumerable<GameObject>)Enumerable.Distinct<GameObject>((IEnumerable<>)enumerable);
				((FrameRelevantCollection<ObjectType>.UpdateRelevancy)(object)updateRelevancy).AddRange((IEnumerable<>)enumerable2);
			}
			if (updateRelevancy2 != null)
			{
			}
			uint num3 = default(uint);
			if (num3 != 0)
			{
			}
			if (updateRelevancy == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031BC")]
		[Cpp2IlInjected.Address(RVA = "0x13D5F80", Offset = "0x13D4980", VA = "0x1813D5F80")]
		private void StartPreviewing(GameObject gameObject)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			Highlight.AddHighlightTo(gameObject, (AnimationCurve)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60031BD")]
		[Cpp2IlInjected.Address(RVA = "0x13D6020", Offset = "0x13D4A20", VA = "0x1813D6020")]
		private void StopPreviewing(GameObject gameObject)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			Highlight.RemoveHighlightFrom(gameObject, (AnimationCurve)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60031BE")]
		[Cpp2IlInjected.Address(RVA = "0x13D5FE0", Offset = "0x13D49E0", VA = "0x1813D5FE0")]
		private void StartTilePreviewing(Vector3 position)
		{
			//Discarded unreachable code: IL_000f
			PreviewTilePool previewTilePool = tilePool;
			float z = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60031BF")]
		[Cpp2IlInjected.Address(RVA = "0x13D6080", Offset = "0x13D4A80", VA = "0x1813D6080")]
		private void StopTilePreviewing(Vector3 position)
		{
			//Discarded unreachable code: IL_000f
			PreviewTilePool previewTilePool = tilePool;
			float z = position.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60031C0")]
		[Cpp2IlInjected.Address(RVA = "0x13D5C30", Offset = "0x13D4630", VA = "0x1813D5C30")]
		[Conditional("DEBUG_PREVIEW_SYSTEM")]
		private static void Log(string message)
		{
			string text = "ToolPreviewSystem: " + message;
		}

		[Cpp2IlInjected.Token(Token = "0x60031C1")]
		[Cpp2IlInjected.Address(RVA = "0x13D6610", Offset = "0x13D5010", VA = "0x1813D6610")]
		public ToolPreviewSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60031C2")]
		[Cpp2IlInjected.Address(RVA = "0x13D6550", Offset = "0x13D4F50", VA = "0x1813D6550")]
		static ToolPreviewSystem()
		{
			//IL_0021: Expected O, but got I
			//IL_003c: Expected O, but got I
			int num = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker("ToolPreviewSystem", categoryId, (MarkerFlags)flags, metadataCount);
			int num2 = 0;
			s_ToolPreviewSystem = (ProfilerMarker)(long)intPtr;
			int flags2 = 0;
			int metadataCount2 = 0;
			ushort categoryId2 = default(ushort);
			s_ToolPreviewSystem_GetToolPreview = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("ToolPreviewSystem.GetToolPreview", categoryId2, (MarkerFlags)flags2, metadataCount2);
		}
	}
}
