using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Wind
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CreateAssetMenu]
	public class WindAtlas : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct Pivot
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public uint parent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public Vector3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float strength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public float randomStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public float random;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public static int stride
			{
				[Cpp2IlInjected.Token(Token = "0x6000005")]
				[Cpp2IlInjected.Address(RVA = "0x8BC8A0", Offset = "0x8BB2A0", VA = "0x1808BC8A0")]
				get
				{
					return 28;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x414A230", Offset = "0x4148C30", VA = "0x18414A230", Slot = "3")]
			public override string ToString()
			{
				//Discarded unreachable code: IL_0085
				//IL_003b: Expected O, but got F4
				//IL_005a: Expected O, but got F4
				//IL_0079: Expected O, but got F4
				object[] array;
				float z;
				while (true)
				{
					array = new object[4];
					if (array != null && array == null)
					{
						continue;
					}
					array[0] = array;
					z = position.z;
					if (z != 0f && z == 0f)
					{
						continue;
					}
					array[1] = z;
					float num = strength;
					if (z == 0f || z != 0f)
					{
						array[2] = z;
						float num2 = randomStrength;
						if (z == 0f || z != 0f)
						{
							break;
						}
					}
				}
				array[3] = z;
				return string.Format("Pivot(Parent={0}, Position={1}, Strength={2}, Random Strength={3})", array);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		public Pivot[] pivots;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ComputeBuffer buffer;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x414A5B0", Offset = "0x4148FB0", VA = "0x18414A5B0")]
		public void ShareBuffer()
		{
			//Discarded unreachable code: IL_00b1
			if ((long)buffer == 0)
			{
				buffer?.Dispose();
				Pivot[] array = pivots;
				if (array != null && array.Length != 0)
				{
					int count = default(int);
					ComputeBuffer computeBuffer = new ComputeBuffer(count, 28);
					count = array.Length;
					buffer = computeBuffer;
					ComputeBuffer computeBuffer2 = buffer;
					Pivot[] data = pivots;
					computeBuffer2.SetData(data);
				}
				Debug.LogError("The windAtlas data is empty. Check that there are hierarchies in the atlas, and do a build of the atlas.");
			}
			ComputeBuffer computeBuffer3 = buffer;
			if (computeBuffer3 != null && computeBuffer3.count > 1)
			{
				int value = buffer.count - 1;
				Shader.SetGlobalInt("_WindBufferLastIndex", value);
				ComputeBuffer value2 = buffer;
				Shader.SetGlobalBuffer("_WindBuffer", value2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x414A4A0", Offset = "0x4148EA0", VA = "0x18414A4A0")]
		public void GenerateBuffer()
		{
			//Discarded unreachable code: IL_0061
			buffer?.Dispose();
			Pivot[] array = pivots;
			if (array != null && array.Length != 0)
			{
				int count = default(int);
				ComputeBuffer computeBuffer = new ComputeBuffer(count, 28);
				count = array.Length;
				buffer = computeBuffer;
				ComputeBuffer computeBuffer2 = buffer;
				Pivot[] data = pivots;
				computeBuffer2.SetData(data);
			}
			else
			{
				Debug.LogError("The windAtlas data is empty. Check that there are hierarchies in the atlas, and do a build of the atlas.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public WindAtlas()
		{
		}
	}
}
