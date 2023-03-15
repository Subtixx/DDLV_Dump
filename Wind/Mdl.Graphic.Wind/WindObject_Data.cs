using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace Mdl.Graphic.Wind
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class WindObject_Data : ScriptableObject, IWindStatus<WindObject_Data>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public enum Leaves
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			[Tooltip("This object is not leaves. No additional movement will be applied to it other than that of the pivots. If the material is in leave mode and you don't want any movement. Use the NoWind option instead.")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			[Tooltip("This object will receive an additional leaf movement on it. The pivot point of this movement will be placed between the vertices with bottom uvs.")]
			Bottom,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			[Tooltip("This object will receive an additional leaf movement on it. The pivot point of this movement will be placed at the midpoints of the vertices.")]
			Center,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[Tooltip("NOT AVAILABLE. Allows you to custom place the pivot point of each uv shell on the uvs.")]
			Custom,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			[Tooltip("Stops leaves from moving on a mesh using a material with the Leaves mode enabled. If the leaves mode is set to none on the material. Use the None option instead.")]
			NoWind
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public enum SetupType
		{
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			Classic,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			Copy
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct CustomPivotArea
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public Rect[] rects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Vector2 pivot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public Vector3Int triangle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Vector3 barycentric;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x4149F90", Offset = "0x4148990", VA = "0x184149F90")]
			public bool Contains(Vector2 point)
			{
				int num = 0;
				num += 2;
				bool flag = default(bool);
				if (!flag)
				{
					num++;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x414A040", Offset = "0x4148A40", VA = "0x18414A040")]
			public Vector3 GetPosition(Vector2 point, ref Vector3[] vertices)
			{
				//IL_000e: Expected O, but got I4
				uint glyphIndex = ((GlyphAdjustmentRecord)this).glyphIndex;
				pivot = (Vector2)glyphIndex;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public Mesh sourceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int[] indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float[] locked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[HideInInspector]
		public CustomPivotArea[] pivotAreas = new CustomPivotArea[0];

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Vector3[] controlPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[HideInInspector]
		public int[] groups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public SetupType setup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public WindObject_Data copySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Tooltip("Specifies how the automatic leaf pivots should be placed on the different groups of the mesh. These pivot points will be used for a leaf movement.")]
		public Leaves leaves;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public WindStatus<WindObject_Data> status
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA90", Offset = "0x6ED490", VA = "0x1806EEA90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x414A8A0", Offset = "0x41492A0", VA = "0x18414A8A0", Slot = "5")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool bakeLeaves
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x24EDDF0", Offset = "0x24EC7F0", VA = "0x1824EDDF0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x414A790", Offset = "0x4149190", VA = "0x18414A790")]
		public int GetAreaID(Vector2 point)
		{
			//Discarded unreachable code: IL_0025
			CustomPivotArea[] array = pivotAreas;
			int num = 0;
			if (num < array.Length)
			{
				bool flag = default(bool);
				if (!flag)
				{
					CustomPivotArea[] array2 = pivotAreas;
					num++;
				}
				return num;
			}
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x414A840", Offset = "0x4149240", VA = "0x18414A840")]
		public WindObject_Data()
		{
		}
	}
}
