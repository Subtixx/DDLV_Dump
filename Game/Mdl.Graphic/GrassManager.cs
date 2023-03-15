using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic
{
	[Cpp2IlInjected.Token(Token = "0x200049B")]
	[ExecuteAlways]
	public class GrassManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001D02")]
		public Mesh grassMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001D03")]
		public Material grassMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001D04")]
		[Min(0f)]
		public float density = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001D05")]
		public Vector2 scaleRange = (Vector2)1065353216;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001D06")]
		public GrassMask grassMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001D07")]
		public Bounds grassBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001D08")]
		private Guid thisGUID;

		[Cpp2IlInjected.Token(Token = "0x600147A")]
		[Cpp2IlInjected.Address(RVA = "0xCEA8D0", Offset = "0xCE92D0", VA = "0x180CEA8D0")]
		private void Awake()
		{
			Guid guid = Guid.NewGuid();
		}

		[Cpp2IlInjected.Token(Token = "0x600147B")]
		[Cpp2IlInjected.Address(RVA = "0xCEAC30", Offset = "0xCE9630", VA = "0x180CEAC30")]
		private void OnValidate()
		{
			//Discarded unreachable code: IL_00b0
			//IL_004e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			if (!base.isActiveAndEnabled)
			{
				return;
			}
			GrassMask grassMask = this.grassMask;
			if (grassMask != 0)
			{
				switch (grassMask)
				{
				}
			}
			Guid guid = thisGUID;
			Guid empty = Guid.Empty;
			if (!(guid != empty))
			{
				return;
			}
			Mesh mesh = grassMesh;
			int num = 0;
			if (!(mesh != (UnityEngine.Object)num))
			{
				return;
			}
			Material material = grassMaterial;
			int num2 = 0;
			if (material != (UnityEngine.Object)num2)
			{
				int num3 = 0;
				if (SystemInfo.supportsComputeShaders)
				{
					Vector2 vector = scaleRange;
					float y = scaleRange.y;
					Grass instance = Grass.instance;
					Bounds bounds = grassBounds;
					Material material2 = grassMaterial;
					Mesh mesh2 = grassMesh;
					Guid guid2 = thisGUID;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600147C")]
		[Cpp2IlInjected.Address(RVA = "0xCEA9F0", Offset = "0xCE93F0", VA = "0x180CEA9F0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_00a4
			//IL_0042: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			GrassMask grassMask = this.grassMask;
			if (grassMask != 0)
			{
				switch (grassMask)
				{
				}
			}
			Guid guid = thisGUID;
			Guid empty = Guid.Empty;
			if (!(guid != empty))
			{
				return;
			}
			Mesh mesh = grassMesh;
			int num = 0;
			if (!(mesh != (UnityEngine.Object)num))
			{
				return;
			}
			Material material = grassMaterial;
			int num2 = 0;
			if (material != (UnityEngine.Object)num2)
			{
				int num3 = 0;
				if (SystemInfo.supportsComputeShaders)
				{
					Vector2 vector = scaleRange;
					float y = scaleRange.y;
					Grass instance = Grass.instance;
					Bounds bounds = grassBounds;
					Material material2 = grassMaterial;
					Mesh mesh2 = grassMesh;
					Guid guid2 = thisGUID;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600147D")]
		[Cpp2IlInjected.Address(RVA = "0xCEA990", Offset = "0xCE9390", VA = "0x180CEA990")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0015
			Grass instance = Grass.instance;
			Guid gUID = thisGUID;
			instance.RemoveGrassPass(gUID);
		}

		[Cpp2IlInjected.Token(Token = "0x600147E")]
		[Cpp2IlInjected.Address(RVA = "0xCEA930", Offset = "0xCE9330", VA = "0x180CEA930")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0015
			Grass instance = Grass.instance;
			Guid gUID = thisGUID;
			instance.RemoveGrassPass(gUID);
		}

		[Cpp2IlInjected.Token(Token = "0x600147F")]
		[Cpp2IlInjected.Address(RVA = "0xCEAE80", Offset = "0xCE9880", VA = "0x180CEAE80")]
		public unsafe GrassManager()
		{
			//IL_0018: Expected O, but got I8
			//IL_0023: Expected native int or pointer, but got O
			//IL_0031: Expected I4, but got I8
			((Vector2*)(IntPtr)scaleRange)->y = 1f;
			grassMask = GrassMask.BOTH_TEXTURES;
			base._002Ector();
		}
	}
}
