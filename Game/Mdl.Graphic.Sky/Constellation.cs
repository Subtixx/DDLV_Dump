using System;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

namespace Mdl.Graphic.Sky
{
	[Cpp2IlInjected.Token(Token = "0x20004C9")]
	[CreateAssetMenu]
	public class Constellation : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20004CA")]
		public struct Star
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001E05")]
			public Vector2 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4001E06")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001E07")]
			public float size;

			[Cpp2IlInjected.Token(Token = "0x6001524")]
			[Cpp2IlInjected.Address(RVA = "0x1783BF0", Offset = "0x17825F0", VA = "0x181783BF0")]
			public Star(Vector2 position, float size)
			{
				this.position = position;
				this.size = size;
				Color white = Color.white;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20004CB")]
		private struct vertex
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001E08")]
			public float3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4001E09")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4001E0A")]
			public float3 uv;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DFE")]
		[ItemID]
		[SerializeField]
		[Tooltip("The condition to display this constellation in the sky.")]
		[ItemID(ItemType.Condition)]
		public int condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001DFF")]
		[Tooltip("The position of the image in the atlas. The index points to the channels first [RGBA / 0123], then the cells on the x-axis, then on the y-axis.")]
		public int atlasIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E00")]
		private Mesh mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E01")]
		[HideInInspector]
		public Star[] stars = new Star[0];

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E02")]
		[HideInInspector]
		public Vector2Int[] lines = new Vector2Int[0];

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E03")]
		private bool? isEnableCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001E04")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x170002A0")]
		public Item conditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x600151B")]
			[Cpp2IlInjected.Address(RVA = "0xA925E0", Offset = "0xA90FE0", VA = "0x180A925E0")]
			get
			{
				long num = Convert.ToInt64((uint)condition);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A1")]
		public Mesh Mesh
		{
			[Cpp2IlInjected.Token(Token = "0x600151C")]
			[Cpp2IlInjected.Address(RVA = "0xA92550", Offset = "0xA90F50", VA = "0x180A92550")]
			get
			{
				//IL_0010: Expected O, but got I4
				Mesh mesh = this.mesh;
				int num = 0;
				if (mesh == (UnityEngine.Object)num)
				{
					Mesh mesh2 = (this.mesh = GenerateMesh());
				}
				return this.mesh;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600151D")]
		[Cpp2IlInjected.Address(RVA = "0xA92490", Offset = "0xA90E90", VA = "0x180A92490")]
		private void OnValidate()
		{
			//IL_0009: Expected O, but got I4
			while (true)
			{
				int num = 0;
				isEnableCache = (bool?)(object)num;
				if ((object)this != null)
				{
					/*Error: Could not find block for branch target IL_000d*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600151E")]
		[Cpp2IlInjected.Address(RVA = "0xA92020", Offset = "0xA90A20", VA = "0x180A92020")]
		public bool IsEnable()
		{
			//IL_000f: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			Meta.Online.Client client = default(Meta.Online.Client);
			bool result = default(bool);
			if (!(_003CInstance_003Ek__BackingField == (UnityEngine.Object)num) && SystemRoot.Instance.MetaClient != null && (long)client.profile != 0)
			{
				return result;
			}
			int num2 = 0;
			isEnableCache = (bool?)(object)num2;
			CreateEventHandler();
			int conditionListener = 0;
			OnConditionChanged((ConditionListener)conditionListener);
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600151F")]
		[Cpp2IlInjected.Address(RVA = "0xA92240", Offset = "0xA90C40", VA = "0x180A92240")]
		private void OnConditionChanged(ConditionListener conditionListener)
		{
			//IL_0061: Expected O, but got I4
			int num = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Mdl.Online.Client client = _003CInstance_003Ek__BackingField.Client;
				if ((object)client != null && client.MetaClient == null)
				{
				}
			}
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField2 != null)
			{
				Mdl.Online.Client client2 = _003CInstance_003Ek__BackingField2.Client;
				if ((object)client2 != null && client2.MetaClient == null)
				{
				}
			}
			if (num != 0 && num != 0)
			{
				if (condition == 0)
				{
				}
				int num2 = condition;
				isEnableCache = (bool?)(object)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001520")]
		[Cpp2IlInjected.Address(RVA = "0xA913B0", Offset = "0xA8FDB0", VA = "0x180A913B0")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			long num2 = Convert.ToInt64((uint)condition);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Meta.Online.Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && metaClient.Dispatcher != null)
				{
					ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnConditionChanged;
				}
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001521")]
		[Cpp2IlInjected.Address(RVA = "0x840940", Offset = "0x83F340", VA = "0x180840940")]
		private void DisposeEventHandler()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = eventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001522")]
		[Cpp2IlInjected.Address(RVA = "0xA91590", Offset = "0xA8FF90", VA = "0x180A91590")]
		private Mesh GenerateMesh()
		{
			//Discarded unreachable code: IL_0050, IL_0063, IL_0093, IL_00a4, IL_012b, IL_015a
			//IL_0030: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_0124: Expected I4, but got O
			//IL_0157: Expected I4, but got I8
			Star[] array = stars;
			int length = lines.Length;
			int num = 0;
			VertexAttributeDescriptor[] array2 = new VertexAttributeDescriptor[3];
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			array2[0] = (VertexAttributeDescriptor)num3;
			int num5 = 0;
			array2[2] = (VertexAttributeDescriptor)num4;
			array2[4] = (VertexAttributeDescriptor)num4;
			int num6 = 0;
			throw new MissingMethodException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001523")]
		[Cpp2IlInjected.Address(RVA = "0xA924D0", Offset = "0xA90ED0", VA = "0x180A924D0")]
		public Constellation()
		{
		}
	}
}
