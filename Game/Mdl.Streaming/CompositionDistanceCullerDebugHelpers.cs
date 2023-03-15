using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Streaming
{
	[Cpp2IlInjected.Token(Token = "0x20007F7")]
	public class CompositionDistanceCullerDebugHelpers : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4002C7B")]
		private static GameObject _instanceGO;

		[Cpp2IlInjected.Token(Token = "0x4002C7C")]
		private static CompositionDistanceCullerDebugHelpers _instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002C7D")]
		private CompositionDistanceCullerDebugData totalCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C7E")]
		private CompositionDistanceCullerDebugData visibleCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002C7F")]
		private CompositionDistanceCuller[] _compositionDistanceCullers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002C80")]
		private int _compositionDistanceCullersNullCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002C81")]
		private int _compositionDistanceCullersVisibleCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002C82")]
		private int TotalNumberOfMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002C83")]
		private int TotalNumberOfLODGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002C84")]
		private readonly string ArtLayerName = "ArtLayer";

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002C85")]
		private int TotalNumberOfMeshRenderersInArtLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4002C86")]
		private int TotalNumberOfLODGroupInArtLayer;

		[Cpp2IlInjected.Token(Token = "0x170004FB")]
		public static CompositionDistanceCullerDebugHelpers Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6002378")]
			[Cpp2IlInjected.Address(RVA = "0xA8C630", Offset = "0xA8B030", VA = "0x180A8C630")]
			get
			{
				//Discarded unreachable code: IL_005c
				//IL_000f: Expected O, but got I4
				//IL_0021: Expected O, but got I4
				CompositionDistanceCullerDebugHelpers instance = _instance;
				int num = 0;
				if (instance == (UnityEngine.Object)num)
				{
					GameObject instanceGO = _instanceGO;
					int num2 = 0;
					if (instanceGO == (UnityEngine.Object)num2)
					{
						_instanceGO = new GameObject();
						_instanceGO.name = "CompositionDistanceCullerDebugHelpers";
						UnityEngine.Object.DontDestroyOnLoad(_instanceGO);
						_instanceGO = (GameObject)(object)_instanceGO.AddComponent<CompositionDistanceCullerDebugHelpers>();
					}
				}
				return _instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004FC")]
		private int CompositionDistanceCullerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6002379")]
			[Cpp2IlInjected.Address(RVA = "0xA8C620", Offset = "0xA8B020", VA = "0x180A8C620")]
			get
			{
				CompositionDistanceCuller[] compositionDistanceCullers;
				do
				{
					compositionDistanceCullers = _compositionDistanceCullers;
				}
				while (compositionDistanceCullers == null);
				return compositionDistanceCullers.Length;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600237A")]
		[Cpp2IlInjected.Address(RVA = "0xA8C340", Offset = "0xA8AD40", VA = "0x180A8C340")]
		public void SetOSDEnable(bool isEnable)
		{
			//Discarded unreachable code: IL_0057
			int num = 0;
			DebugOnScreenText instance = DebugOnScreenText.Instance;
			if (!isEnable)
			{
				DebugOnScreenText.AddOnScreenText value = OnScreenDebugText;
				instance.OnAddOnScreenText -= value;
				return;
			}
			DebugOnScreenText.AddOnScreenText value2 = OnScreenDebugText;
			instance.OnAddOnScreenText -= value2;
			int num2 = 0;
			DebugOnScreenText instance2 = DebugOnScreenText.Instance;
			DebugOnScreenText.AddOnScreenText value3 = OnScreenDebugText;
			instance2.OnAddOnScreenText += value3;
		}

		[Cpp2IlInjected.Token(Token = "0x600237B")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA10", Offset = "0xA8A410", VA = "0x180A8BA10")]
		private void CacheAllCullersComponent()
		{
			//Discarded unreachable code: IL_0093
			if ((long)_compositionDistanceCullers == 0)
			{
				CompositionDistanceCuller[] array = (_compositionDistanceCullers = UnityEngine.Object.FindObjectsOfType<CompositionDistanceCuller>(includeInactive: true));
				MeshRenderer[] array2 = UnityEngine.Object.FindObjectsOfType<MeshRenderer>(includeInactive: true);
				int num = (TotalNumberOfMeshRenderers = array2.Length);
				LODGroup[] array3 = UnityEngine.Object.FindObjectsOfType<LODGroup>(includeInactive: true);
				int num2 = (TotalNumberOfLODGroup = array3.Length);
				Func<MeshRenderer, bool> func = (Func<MeshRenderer, bool>)(object)(Func<T, TResult>)delegate(MeshRenderer x)
				{
					//Discarded unreachable code: IL_0016
					GameObject go2 = x.gameObject;
					string artLayerName2 = ArtLayerName;
					return go2.HasParentNamed(artLayerName2);
				};
				int num3 = (TotalNumberOfMeshRenderersInArtLayer = Enumerable.Count<MeshRenderer>(Enumerable.Where<MeshRenderer>((IEnumerable<>)(object)array2, (Func<, >)(object)func)));
				Func<LODGroup, bool> func2 = (Func<LODGroup, bool>)(object)(Func<T, TResult>)delegate(LODGroup x)
				{
					//Discarded unreachable code: IL_0016
					GameObject go = x.gameObject;
					string artLayerName = ArtLayerName;
					return go.HasParentNamed(artLayerName);
				};
				int num4 = (TotalNumberOfLODGroupInArtLayer = Enumerable.Count<LODGroup>(Enumerable.Where<LODGroup>((IEnumerable<>)(object)array3, (Func<, >)(object)func2)));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600237C")]
		[Cpp2IlInjected.Address(RVA = "0xA8C2C0", Offset = "0xA8ACC0", VA = "0x180A8C2C0")]
		public void SetAllCullersVisibility(CompositionDistanceCuller.ForceVisibilityType visibilityType, bool forceRecache = false)
		{
			//Discarded unreachable code: IL_0039
			CacheAllCullersComponent();
			CompositionDistanceCuller[] compositionDistanceCullers = _compositionDistanceCullers;
			int num = 0;
			int length = compositionDistanceCullers.Length;
			if (num < length)
			{
				CompositionDistanceCuller compositionDistanceCuller = compositionDistanceCullers[num];
				compositionDistanceCuller.UserVisibility = visibilityType;
				compositionDistanceCuller.UpdateVisibility();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600237D")]
		[Cpp2IlInjected.Address(RVA = "0xA8C4A0", Offset = "0xA8AEA0", VA = "0x180A8C4A0")]
		private void UpdateDebugStats()
		{
			//Discarded unreachable code: IL_0057
			//IL_001d: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			CacheAllCullersComponent();
			CompositionDistanceCuller[] compositionDistanceCullers = _compositionDistanceCullers;
			int num = (_compositionDistanceCullersNullCount = 0);
			totalCount = (CompositionDistanceCullerDebugData)num;
			visibleCount = (CompositionDistanceCullerDebugData)num;
			int length = compositionDistanceCullers.Length;
			if (num < length)
			{
				CompositionDistanceCuller compositionDistanceCuller = compositionDistanceCullers[num];
				int num2 = 0;
				if (!(compositionDistanceCuller != (UnityEngine.Object)num2))
				{
					num++;
				}
				if (compositionDistanceCuller.IsVisible)
				{
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600237E")]
		[Cpp2IlInjected.Address(RVA = "0xA8BC20", Offset = "0xA8A620", VA = "0x180A8BC20")]
		private void OnScreenDebugText(StringBuilder dest)
		{
			//Discarded unreachable code: IL_01ba
			//IL_0016: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00c3: Expected O, but got I4
			//IL_00da: Expected O, but got I4
			//IL_00f1: Expected O, but got I4
			//IL_0133: Expected O, but got I4
			//IL_0133: Expected O, but got I4
			//IL_0133: Expected O, but got I4
			//IL_0158: Expected O, but got I4
			//IL_0189: Expected O, but got I4
			//IL_0189: Expected O, but got I4
			//IL_0189: Expected O, but got I4
			bool flag = default(bool);
			string value2 = default(string);
			object[] array;
			int num3 = default(int);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			while (true)
			{
				CacheAllCullersComponent();
				int num = (_compositionDistanceCullersNullCount = 0);
				totalCount = (CompositionDistanceCullerDebugData)num;
				visibleCount = (CompositionDistanceCullerDebugData)num;
				CompositionDistanceCuller[] compositionDistanceCullers = _compositionDistanceCullers;
				int length = compositionDistanceCullers.Length;
				if (num < length)
				{
					CompositionDistanceCuller compositionDistanceCuller = compositionDistanceCullers[num];
					int num2 = 0;
					if (!(compositionDistanceCuller != (UnityEngine.Object)num2))
					{
						num++;
					}
					if (compositionDistanceCuller.IsVisible)
					{
					}
					num++;
				}
				GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
				if ((object)instance != null)
				{
					StreamingManagerConfig activeConfig = instance.ActiveConfig;
				}
				string value = $"IsUsingCompositionDistanceCulling={flag}";
				StringBuilder stringBuilder = dest.AppendLine(value);
				StringBuilder stringBuilder2 = dest.AppendLine(value2);
				array = new object[4];
				if (num3 != 0 && num3 == 0)
				{
					continue;
				}
				array[0] = num3;
				if (num4 != 0 && num4 == 0)
				{
					continue;
				}
				array[1] = num4;
				if (num5 == 0 || num5 != 0)
				{
					array[2] = num5;
					if (num6 == 0 || num6 != 0)
					{
						break;
					}
				}
			}
			array[3] = num6;
			string value3 = string.Format("Scene artlayer/total MR {0}/{1} artlayer/total LODGroup {2}/{3}", array);
			StringBuilder stringBuilder3 = dest.AppendLine(value3);
			int compositionDistanceCullersVisibleCount = _compositionDistanceCullersVisibleCount;
			if (_compositionDistanceCullers != null)
			{
			}
			if (_compositionDistanceCullers != null)
			{
			}
			int num7 = default(int);
			string value4 = $"CompositionDistanceCuller on/off/total={compositionDistanceCullersVisibleCount}/{compositionDistanceCullersVisibleCount}/{num7}";
			StringBuilder stringBuilder4 = dest.AppendLine(value4);
			int compositionDistanceCullersNullCount = _compositionDistanceCullersNullCount;
			if (compositionDistanceCullersNullCount > 0)
			{
				string value5 = $"CompositionDistanceCuller NullCount={compositionDistanceCullersNullCount}";
				StringBuilder stringBuilder5 = dest.AppendLine(value5);
			}
			int numLODGroup = visibleCount.NumLODGroup;
			compositionDistanceCullersVisibleCount = numLODGroup;
			compositionDistanceCullersVisibleCount = numLODGroup;
			string value6 = $"LODGroup   on/off/total : {compositionDistanceCullersVisibleCount}/{compositionDistanceCullersVisibleCount}/{numLODGroup}";
			StringBuilder stringBuilder6 = dest.AppendLine(value6);
			CompositionDistanceCullerDebugData compositionDistanceCullerDebugData = visibleCount;
			string value7 = $"NumMeshRdr on/off/total : {compositionDistanceCullerDebugData}/{compositionDistanceCullerDebugData}/{compositionDistanceCullerDebugData}";
			StringBuilder stringBuilder7 = dest.AppendLine(value7);
		}

		[Cpp2IlInjected.Token(Token = "0x600237F")]
		[Cpp2IlInjected.Address(RVA = "0xA8C5D0", Offset = "0xA8AFD0", VA = "0x180A8C5D0")]
		public CompositionDistanceCullerDebugHelpers()
		{
		}
	}
}
