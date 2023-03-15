using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Graphic.Weather;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mdl.Graphic.Sky
{
	[Cpp2IlInjected.Token(Token = "0x20004CC")]
	[CreateAssetMenu]
	public class ConstellationLibrary : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20004CD")]
		public struct StarCluster
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001E22")]
			public Vector3 dir;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4001E23")]
			public Matrix4x4 transform;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001E0B")]
		[SerializeField]
		[Tooltip("Axis of rotation of the sky. The celestial dome will turn around this axis. This value must always be normalized.")]
		private Vector3 rotationAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4001E0C")]
		[SerializeField]
		[Tooltip("Speed of rotation of the sky. 1 = One turn every 24 hours")]
		private float rotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E0D")]
		[SerializeField]
		[Tooltip("Distance at which the stars and constellations are drawn. Must be large enough to appear infinite, small enough to be under the far plane.")]
		private float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001E0E")]
		[SerializeField]
		[Tooltip("Allows you to draw all the constellations in the list, ignoring their unlocking status in the game.")]
		public bool forceAllConstellationsOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x4001E0F")]
		public bool drawConstellations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E10")]
		[SerializeField]
		[FormerlySerializedAs("Material")]
		[Tooltip("Material used to draw the constellations (Need GPU Instancing enable)")]
		private Material constellationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E11")]
		[SerializeField]
		[FormerlySerializedAs("Size")]
		[Tooltip("The size of the constellations in the sky.")]
		private float constellationSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001E12")]
		[SerializeField]
		[Tooltip("List of constellations usable by the library. These constellations can be activated and deactivated via code, so they can be in the list without being render.")]
		public List<Constellation> constellations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001E13")]
		[SerializeField]
		private Vector3[] positions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001E14")]
		private Material[] constellationImageMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001E15")]
		public bool drawConstellationImages;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001E16")]
		[SerializeField]
		[FormerlySerializedAs("Mesh")]
		[Tooltip("Mesh used to draw the constellation images. (The simple unity quad should be ok)")]
		private Mesh constellationImageMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001E17")]
		[SerializeField]
		[FormerlySerializedAs("Material")]
		[Tooltip("Material used to draw the constellation images (Need GPU Instancing enable)")]
		private Material constellationImageMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001E18")]
		[Tooltip("Indicates the amount of alignment required for the image to become visible. A lower rate = a more easily visible image.")]
		public float imageAlignementThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4001E19")]
		public bool drawStars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001E1A")]
		[SerializeField]
		[Tooltip("Material used to draw the stars (Need GPU Instancing enable)")]
		[FormerlySerializedAs("Material")]
		private Material starMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001E1B")]
		[SerializeField]
		public Mesh starMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001E1C")]
		public int clusterCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4001E1D")]
		public int starsPerCluster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001E1E")]
		public float clusterSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4001E1F")]
		[Range(0f, 1f)]
		public float clusterCullingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001E20")]
		[HideInInspector]
		public StarCluster[] clusters;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001E21")]
		private Matrix4x4[] visibleClusters;

		[Cpp2IlInjected.Token(Token = "0x6001525")]
		[Cpp2IlInjected.Address(RVA = "0xA91310", Offset = "0xA8FD10", VA = "0x180A91310")]
		private void OnValidate()
		{
			//IL_000e: Expected O, but got F4
			Vector3 vector = default(Vector3);
			float z = vector.z;
			rotationAxis = (Vector3)z;
		}

		[Cpp2IlInjected.Token(Token = "0x6001526")]
		[Cpp2IlInjected.Address(RVA = "0xA90310", Offset = "0xA8ED10", VA = "0x180A90310")]
		public void Draw(Camera camera)
		{
			//Discarded unreachable code: IL_01ba, IL_0329
			//IL_0025: Expected O, but got F4
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected F4, but got Unknown
			//IL_0143: Expected O, but got I4
			//IL_016a: Expected O, but got I4
			//IL_018b: Expected O, but got I4
			//IL_01db: Expected F4, but got I4
			//IL_025e: Expected O, but got I4
			//IL_0278: Expected O, but got I4
			float z2;
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			Material[] array3 = default(Material[]);
			bool flag = default(bool);
			Vector3 vector3 = default(Vector3);
			float @float = default(float);
			while (true)
			{
				int num = LayerMask.NameToLayer("FarClipBG");
				int num2 = 0;
				float time = Time.time;
				float z = rotationAxis.z;
				float num3 = ((ConstellationLibrary)time).rotationSpeed;
				float num4 = /*Error near IL_0026: Stack underflow*/* num3;
				Transform transform = camera.transform;
				z2 = vector.z;
				Transform transform2 = camera.transform;
				float z3 = vector2.z;
				int starsColor = WeatherIDs._StarsColor;
				float starsIntensity = Stars.starsIntensity;
				Shader.SetGlobalFloatImpl(WeatherIDs._StarsIntensity, starsIntensity);
				Vector3[] array = positions;
				if (array == null || (IntPtr)array.Length != (IntPtr)typeof(WeatherIDs).TypeHandle)
				{
					ComputeConstellationsPositions();
				}
				Material[] array2 = constellationImageMaterials;
				if (array2 == null || (IntPtr)array2.Length != (IntPtr)typeof(WeatherIDs).TypeHandle)
				{
					array3 = (constellationImageMaterials = new Material[((List<>)(object)constellations)._size]);
				}
				int num5 = 0;
				float deltaTime = Time.deltaTime;
				int num6 = 0;
				int num7 = 0;
				if (num6 >= array3.Length)
				{
					break;
				}
				if (!forceAllConstellationsOn)
				{
					num6 = num7;
					if (!flag)
					{
						goto IL_0226;
					}
				}
				Vector3[] forward = positions;
				Quaternion quaternion = Quaternion.LookRotation((Vector3)forward);
				Vector3 forward2 = Vector3.forward;
				int num8 = 0;
				float z4 = vector3.z;
				Quaternion quaternion2 = Quaternion.LookRotation((Vector3)forward);
				float z5 = Vector3.one.z;
				if (drawConstellations)
				{
					Material material = constellationMaterial;
					int num9 = 0;
					if (material != (UnityEngine.Object)num9)
					{
						num6 = num7;
					}
				}
				if (drawConstellationImages)
				{
					Mesh mesh = constellationImageMesh;
					int num10 = 0;
					if (mesh != (UnityEngine.Object)num10)
					{
						Material material2 = constellationImageMaterials[num7];
						int num11 = 0;
						if (material2 == (UnityEngine.Object)num11)
						{
							Material[] array4 = constellationImageMaterials;
							Material material3 = new Material(constellationImageMaterial);
							if ((object)material3 == null || (object)material3 != null)
							{
								num6 = num7;
								throw new IndexOutOfRangeException();
							}
							continue;
						}
						@float = constellationImageMaterials[num7].GetFloat("_Alpha");
						float value = Mathf.Clamp01(@float);
						constellationImageMaterials[num7].SetFloat("_Alpha", value);
						Material[] array5 = constellationImageMaterials;
						Mesh mesh2 = constellationImageMesh;
					}
				}
				goto IL_0226;
				IL_0226:
				num7++;
				num6 = num7;
				break;
			}
			if (!drawStars || (long)clusters == 0)
			{
				return;
			}
			Mesh mesh3 = starMesh;
			int num12 = 0;
			if (!(mesh3 != (UnityEngine.Object)num12))
			{
				return;
			}
			Material material4 = starMaterial;
			int num13 = 0;
			if (!(material4 != (UnityEngine.Object)num13))
			{
				return;
			}
			if (num13 != 0)
			{
				int length = clusters.Length;
			}
			Matrix4x4[] array6 = (visibleClusters = new Matrix4x4[clusters.Length]);
			StarCluster[] array7 = clusters;
			int num14 = 0;
			int num15 = 0;
			int num16 = 0;
			if (num16 < array7.Length)
			{
				long num17 = (long)num15 * 76L;
				Vector3 vector4 = default(Vector3);
				float z6 = vector4.z;
				float value = @float;
				value = z2;
				StarCluster[] array8 = clusters;
				num14++;
				Matrix4x4 matrix4x = default(Matrix4x4);
				float m = matrix4x.m01;
				float m2 = matrix4x.m02;
				float m3 = matrix4x.m03;
				StarCluster[] array9 = clusters;
				num15++;
				num16 = num15;
				while (array9 != null)
				{
				}
			}
			Mesh mesh4 = starMesh;
		}

		[Cpp2IlInjected.Token(Token = "0x6001527")]
		[Cpp2IlInjected.Address(RVA = "0xA8FF30", Offset = "0xA8E930", VA = "0x180A8FF30")]
		public void ComputeConstellationsPositions()
		{
			//Discarded unreachable code: IL_0048
			Vector3[] array = (positions = new Vector3[((List<>)(object)constellations)._size]);
			List<Constellation> list = constellations;
			int num = 0;
			Vector3[] array2 = positions;
			float z = Vector3.zero.z;
			Color red = Color.red;
			num++;
			List<Constellation> list2 = constellations;
		}

		[Cpp2IlInjected.Token(Token = "0x6001528")]
		[Cpp2IlInjected.Address(RVA = "0xA91150", Offset = "0xA8FB50", VA = "0x180A91150")]
		private Vector3 FibSphere(int i, int count)
		{
			float z = Vector3.zero.z;
			Color red = Color.red;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001529")]
		[Cpp2IlInjected.Address(RVA = "0xA902B0", Offset = "0xA8ECB0", VA = "0x180A902B0")]
		public void ComputeStarsClusters()
		{
			Debug.LogError("The positions of the stars cannot be calculated in runtime. These informations are made to be pre-calculated only.");
		}

		[Cpp2IlInjected.Token(Token = "0x600152A")]
		[Cpp2IlInjected.Address(RVA = "0xA91340", Offset = "0xA8FD40", VA = "0x180A91340")]
		public unsafe ConstellationLibrary()
		{
			//IL_000c: Expected F4, but got I8
			//IL_0007: Expected native int or pointer, but got O
			//IL_0041: Expected I4, but got I8
			//IL_004b: Expected I4, but got I8
			ulong num = default(ulong);
			((Vector3*)(IntPtr)rotationAxis)->z = (long)num;
			rotationSpeed = 50f;
			range = 550f;
			constellationSize = 100f;
			imageAlignementThreshold = 0.98f;
			clusterCount = 8;
			starsPerCluster = 100;
			clusterSize = 0.5f;
			base._002Ector();
		}
	}
}
