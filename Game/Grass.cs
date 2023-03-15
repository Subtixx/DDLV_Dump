using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Graphic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Cpp2IlInjected.Token(Token = "0x200007B")]
public class Grass : ScriptableRendererFeature
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class GrassPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		internal Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		internal MaterialPropertyBlock mpb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		internal Vector2 scaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		internal Mesh mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		internal float density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		internal Bounds bounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		internal Vector2 grassMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private GrassSettings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private ComputeBuffer positionBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private ComputeBuffer bufferWithArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public Rect grassMaskRect;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private static int TestPositionsKernelIndex;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private static int positionBufferID = Shader.PropertyToID("positionBuffer");

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private static int terrainLUTID = Shader.PropertyToID("_TerrainLUT");

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private static int grassMaskTexId = Shader.PropertyToID("_GrassMaskTex");

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private static int randomID = Shader.PropertyToID("_Random");

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private static int terrainLUTScaleOffsetID = Shader.PropertyToID("_TerrainLUTScaleOffset");

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private static int grassMaskID = Shader.PropertyToID("grassMask");

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private static int camPosID = Shader.PropertyToID("camPos");

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private static int rectID = Shader.PropertyToID("rect");

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private static int densityID = Shader.PropertyToID("density");

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private static int terrainRangeID = Shader.PropertyToID("_TerrainRange");

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private static int maxDistanceID = Shader.PropertyToID("maxDistance");

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private static int windStrengthID = Shader.PropertyToID("_WindStrength");

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private static int windSpeedID = Shader.PropertyToID("_WindSpeed");

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private static int scaleRangeID = Shader.PropertyToID("_ScaleRange");

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private static int viewProjectionID = Shader.PropertyToID("unity_MatrixVP");

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static int grassViewProjectionID = Shader.PropertyToID("grassMaskVP");

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static int[] SHAIDS;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private static int[] SHBIDS;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private static int SHCID;

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1044D80", Offset = "0x1043780", VA = "0x181044D80")]
		public GrassPass(GrassSettings settings, Vector2 scaleRange, float density, Bounds bounds, Vector2 grassMask, Mesh mesh, Material m)
		{
			//Discarded unreachable code: IL_012c
			//IL_0021: Expected O, but got I4
			//IL_0028: Expected O, but got I4
			//IL_0035: Expected I4, but got I8
			//IL_009a: Expected O, but got I4
			this.settings = settings;
			MaterialPropertyBlock materialPropertyBlock = (mpb = new MaterialPropertyBlock());
			material = (Material)0;
			this.mesh = (Mesh)0;
			base.renderPassEvent = (RenderPassEvent)151;
			this.density = density;
			MaterialPropertyBlock materialPropertyBlock2 = mpb;
			float windGustDistance = settings.windGustDistance;
			materialPropertyBlock2.SetFloat("_WindGustDistance", windGustDistance);
			MaterialPropertyBlock materialPropertyBlock3 = mpb;
			MaterialPropertyBlock materialPropertyBlock4 = mpb;
			Texture2D noiseTex = settings.noiseTex;
			materialPropertyBlock4.SetTexture("_Random", noiseTex);
			MaterialPropertyBlock materialPropertyBlock5 = mpb;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			materialPropertyBlock5.SetVector("unity_LightData", (Vector4)num);
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float f = default(float);
			ComputeBuffer computeBuffer = (positionBuffer = new ComputeBuffer(Mathf.Max(Mathf.CeilToInt(f), 100), 16, ComputeBufferType.Append));
			ComputeBuffer computeBuffer2 = (bufferWithArgs = new ComputeBuffer(1, 20, ComputeBufferType.DrawIndirect));
			uint[] array = new uint[0];
			int num4 = 0;
			uint num5 = default(uint);
			array[0] = num5;
			int num6 = 0;
			uint num7 = default(uint);
			array[1] = num7;
			int num8 = 0;
			uint num9 = default(uint);
			array[1] = num9;
			bufferWithArgs.SetData(array);
			ProfilingSampler profilingSampler = (base.profilingSampler = new ProfilingSampler("Grass"));
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1044850", Offset = "0x1043250", VA = "0x181044850")]
		public void Release()
		{
			positionBuffer?.Dispose();
			bufferWithArgs?.Dispose();
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x1043500", Offset = "0x1041F00", VA = "0x181043500", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			//Discarded unreachable code: IL_046c, IL_0472, IL_0478, IL_047e, IL_0484, IL_048a, IL_0490, IL_0496, IL_049c, IL_04a2, IL_04a8, IL_04ae, IL_04b4, IL_04ba, IL_04c0, IL_04c6, IL_04cc, IL_04d2, IL_04d8, IL_04de, IL_04e4, IL_04ea, IL_04f0, IL_04f6, IL_04fc, IL_0502, IL_0508, IL_050e
			//IL_0137: Expected O, but got I4
			//IL_0146: Expected O, but got I4
			//IL_02d3: Expected I4, but got I8
			//IL_03a9: Expected O, but got I4
			//IL_03e0: Expected O, but got I4
			//IL_0404: Expected O, but got I4
			CommandBuffer commandBuffer;
			Vector3 vector = default(Vector3);
			RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
			RenderTargetIdentifier renderTargetIdentifier2 = default(RenderTargetIdentifier);
			Vector3 vector2 = default(Vector3);
			Vector3 vector3 = default(Vector3);
			Matrix4x4 matrix4x = default(Matrix4x4);
			Matrix4x4 matrix4x2 = default(Matrix4x4);
			Matrix4x4 matrix4x3 = default(Matrix4x4);
			Matrix4x4 matrix4x4 = default(Matrix4x4);
			Matrix4x4 matrix4x5 = default(Matrix4x4);
			Matrix4x4 matrix4x6 = default(Matrix4x4);
			Matrix4x4 matrix4x7 = default(Matrix4x4);
			Matrix4x4 matrix4x8 = default(Matrix4x4);
			int a = default(int);
			Vector3 vector5 = default(Vector3);
			ulong num10 = default(ulong);
			float num11 = default(float);
			float num12 = default(float);
			float num13 = default(float);
			float num16 = default(float);
			float num17 = default(float);
			float num18 = default(float);
			float num22 = default(float);
			float num24 = default(float);
			Vector2 vector6 = default(Vector2);
			do
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				commandBuffer = CommandBufferPool.Get();
				Transform transform = renderingData.cameraData.camera.transform;
				float z = vector.z;
				int counterValue = 0;
				ComputeBuffer buffer = positionBuffer;
				commandBuffer.SetComputeBufferCounterValue(buffer, (uint)counterValue);
				ComputeShader computeShader = settings.computeShader;
				int testPositionsKernelIndex = TestPositionsKernelIndex;
				int nameID = positionBufferID;
				ComputeBuffer buffer2 = positionBuffer;
				commandBuffer.Internal_SetComputeBufferParam(computeShader, testPositionsKernelIndex, nameID, buffer2);
				GrassSettings grassSettings = settings;
				int num5 = terrainLUTID;
				IntPtr bufferPointer = renderTargetIdentifier.m_BufferPointer;
				nameID = num5;
				GrassSettings grassSettings2 = settings;
				int num6 = grassMaskTexId;
				int num7 = 0;
				int num8 = 0;
				nameID = num6;
				GrassSettings grassSettings3 = settings;
				IntPtr bufferPointer2 = renderTargetIdentifier2.m_BufferPointer;
				GrassSettings grassSettings4 = settings;
				GrassSettings grassSettings5 = settings;
				GrassSettings grassSettings6 = settings;
				GrassSettings grassSettings7 = settings;
				int nameID2 = terrainRangeID;
				ComputeShader computeShader2 = settings.computeShader;
				float _003CGrassDistanceBias_003Ek__BackingField = GraphicSettings.GrassDistanceBias;
				commandBuffer.SetComputeFloatParam(computeShader2, nameID2, _003CGrassDistanceBias_003Ek__BackingField);
				ComputeShader computeShader3 = settings.computeShader;
				int nameID3 = rectID;
				float z2 = vector2.z;
				float z3 = vector3.z;
				int num9 = 0;
				commandBuffer.SetComputeVectorParam(computeShader3, nameID3, (Vector4)num9);
				GrassSettings grassSettings8 = settings;
				Vector4 vector4 = (Vector2)num9;
				GrassSettings grassSettings9 = settings;
				float m = matrix4x.m01;
				float m2 = matrix4x.m02;
				float m3 = matrix4x.m03;
				float m4 = matrix4x2.m01;
				float m5 = matrix4x2.m02;
				float m6 = matrix4x2.m03;
				GrassSettings grassSettings10 = settings;
				float val = density;
				int nameID4 = densityID;
				ComputeShader computeShader4 = grassSettings10.computeShader;
				commandBuffer.SetComputeFloatParam(computeShader4, nameID4, val);
				float z4 = Vector3.down.z;
				z2 = m6;
				m5 = z2;
				float z5 = Vector3.forward.z;
				float m7 = matrix4x3.m01;
				float m8 = matrix4x3.m02;
				float m9 = matrix4x3.m03;
				float z6 = Vector3.zero.z;
				Quaternion identity = Quaternion.identity;
				float m10 = matrix4x4.m01;
				float m11 = matrix4x4.m02;
				float m12 = matrix4x4.m03;
				GrassSettings grassSettings11 = settings;
				float m13 = matrix4x5.m01;
				float m14 = matrix4x5.m02;
				float m15 = matrix4x5.m03;
				float m16 = matrix4x6.m01;
				float m17 = matrix4x6.m02;
				float m18 = matrix4x6.m03;
				float m19 = matrix4x7.m01;
				float m20 = matrix4x7.m02;
				float m21 = matrix4x7.m03;
				float m22 = matrix4x8.m01;
				float m23 = matrix4x8.m02;
				float m24 = matrix4x8.m03;
				ComputeShader computeShader5 = settings.computeShader;
				int testPositionsKernelIndex2 = TestPositionsKernelIndex;
				int threadGroupsX = Mathf.Max(a, 1);
				int threadGroupsY = Mathf.Max(Mathf.CeilToInt(vector5.z), 1);
				commandBuffer.Internal_DispatchCompute(computeShader5, testPositionsKernelIndex2, threadGroupsX, threadGroupsY, (int)num10);
				ComputeBuffer dst = bufferWithArgs;
				ComputeBuffer src = positionBuffer;
				commandBuffer.CopyCounterValueCC(src, dst, 4u);
				MaterialPropertyBlock materialPropertyBlock = mpb;
				float windGrassStrength = GrassSettings.windGrassStrength;
				int name = windStrengthID;
				materialPropertyBlock.SetFloatImpl(name, windGrassStrength);
				MaterialPropertyBlock materialPropertyBlock2 = mpb;
				float windGrassSpeed = GrassSettings.windGrassSpeed;
				int name2 = windSpeedID;
				materialPropertyBlock2.SetFloatImpl(name2, windGrassSpeed);
				SphericalHarmonicsL2 ambientProbe = RenderSettings.ambientProbe;
				float shr = ambientProbe.shr4;
				float shr2 = ambientProbe.shr8;
				float shg = ambientProbe.shg3;
				float shg2 = ambientProbe.shg7;
				float shb = ambientProbe.shb2;
				float shb2 = ambientProbe.shb8;
				MaterialPropertyBlock materialPropertyBlock3 = mpb;
				if (num3 < 3)
				{
					int nameID5 = SHAIDS[num3];
					m15 = num11;
					m14 = num12;
					m13 = num13;
					int num14 = 0;
					int num15 = 0;
					windGrassSpeed = m14;
					materialPropertyBlock3.SetVector(nameID5, (Vector4)num15);
					MaterialPropertyBlock materialPropertyBlock4 = mpb;
					int nameID6 = SHBIDS[num3];
					m14 = num16;
					m13 = num17;
					float num19 = num18;
					int num20 = 0;
					m13 = num19;
					windGrassSpeed = m13;
					materialPropertyBlock4.SetVector(nameID6, (Vector4)num20);
					num3++;
				}
				int sHCID = SHCID;
				int num21 = 0;
				m13 = num22;
				int num23 = 0;
				windGrassSpeed = num24;
				materialPropertyBlock3.SetVector(sHCID, (Vector4)num23);
				MaterialPropertyBlock materialPropertyBlock5 = mpb;
				ComputeBuffer value = positionBuffer;
				int name3 = positionBufferID;
				materialPropertyBlock5.SetBufferImpl(name3, value);
				ComputeBuffer computeBuffer = bufferWithArgs;
				MaterialPropertyBlock properties = mpb;
				Material material = this.material;
				int submeshIndex = 0;
				Mesh mesh = this.mesh;
				commandBuffer.DrawMeshInstancedIndirect(mesh, submeshIndex, material, num3, computeBuffer, num3, properties);
			}
			while ((object)vector6 != null);
			CommandBufferPool.Release(commandBuffer);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1044890", Offset = "0x1043290", VA = "0x181044890")]
		static GrassPass()
		{
			//Discarded unreachable code: IL_0199
			//IL_0138: Expected I4, but got O
			//IL_0189: Expected I4, but got O
			int[] array = new int[3];
			int num = (array[0] = Shader.PropertyToID("unity_SHAr"));
			int num2 = (array[0] = Shader.PropertyToID("unity_SHAg"));
			int num3 = (array[1] = Shader.PropertyToID("unity_SHAb"));
			TestPositionsKernelIndex = (int)array;
			int[] array2 = new int[3];
			int num4 = (array2[0] = Shader.PropertyToID("unity_SHBr"));
			int num5 = (array2[0] = Shader.PropertyToID("unity_SHBg"));
			int num6 = (array2[1] = Shader.PropertyToID("unity_SHBb"));
			TestPositionsKernelIndex = (int)array2;
			SHCID = Shader.PropertyToID("unity_SHC");
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private class GrassMaskPass : ScriptableRenderPass
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private Shader maskShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private Material maskMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public Rect grassMaskRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private List<ShaderTagId> m_ShaderTagIdList = (List<ShaderTagId>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private FilteringSettings m_FilteringSettings;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private static int grassMaskId = Shader.PropertyToID("_GrassMaskTex");

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1043220", Offset = "0x1041C20", VA = "0x181043220")]
		public GrassMaskPass(GrassSettings settings)
		{
			//Discarded unreachable code: IL_0068
			//IL_0053: Expected O, but got I4
			Shader shader = (maskShader = settings.maskShader);
			Material material = (maskMaterial = new Material(maskShader));
			maskMaterial.enableInstancing = true;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			m_FilteringSettings = (FilteringSettings)num3;
			ProfilingSampler profilingSampler = (base.profilingSampler = new ProfilingSampler("GrassMaskPass"));
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1042850", Offset = "0x1041250", VA = "0x181042850", Slot = "6")]
		public unsafe override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
			//Discarded unreachable code: IL_005d
			//IL_0030: Expected I4, but got I8
			//IL_002b: Expected native int or pointer, but got O
			//IL_005c: Expected O, but got I4
			int num = ((((RenderTextureDescriptor*)cameraTextureDescriptor)->useMipMap = false) ? 1 : 0);
			int num2 = ((((RenderTextureDescriptor*)cameraTextureDescriptor)->autoGenerateMips = false) ? 1 : 0);
			((RenderTextureDescriptor*)cameraTextureDescriptor)->colorFormat = RenderTextureFormat.R8;
			int num4 = (((RenderTextureDescriptor*)cameraTextureDescriptor)->depthBufferBits = 0);
			((RenderTextureDescriptor*)(IntPtr)cameraTextureDescriptor)->height = 1024;
			RenderTextureMemoryless _003Cmemoryless_003Ek__BackingField = cameraTextureDescriptor._003Cmemoryless_003Ek__BackingField;
			int _003CmipCount_003Ek__BackingField = cameraTextureDescriptor._003CmipCount_003Ek__BackingField;
			TextureDimension _003Cdimension_003Ek__BackingField = cameraTextureDescriptor.dimension;
			int num5 = 0;
			int num6 = 0;
			int num7 = grassMaskId;
			ConfigureTarget((RenderTargetIdentifier)num5);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x10429D0", Offset = "0x10413D0", VA = "0x1810429D0", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			//Discarded unreachable code: IL_016e
			//IL_0016: Expected O, but got I4
			CommandBuffer commandBuffer;
			Matrix4x4 matrix4x = default(Matrix4x4);
			Matrix4x4 matrix4x2 = default(Matrix4x4);
			Matrix4x4 matrix4x3 = default(Matrix4x4);
			Matrix4x4 matrix4x4 = default(Matrix4x4);
			Matrix4x4 matrix4x5 = default(Matrix4x4);
			Matrix4x4 matrix4x6 = default(Matrix4x4);
			Matrix4x4 matrix4x7 = default(Matrix4x4);
			ulong num7 = default(ulong);
			do
			{
				int num = 0;
				int num2 = 0;
				Material material = maskMaterial;
				int num3 = 0;
				if (material == (UnityEngine.Object)num3)
				{
					Material material2 = (maskMaterial = new Material(maskShader));
				}
				int num4 = 0;
				commandBuffer = CommandBufferPool.Get();
				commandBuffer.Clear();
				float z = Vector3.down.z;
				float z2 = Vector3.forward.z;
				float m = matrix4x.m01;
				float m2 = matrix4x.m02;
				float m3 = matrix4x.m03;
				float z3 = Vector3.zero.z;
				Quaternion identity = Quaternion.identity;
				float m4 = matrix4x2.m01;
				float m5 = matrix4x2.m02;
				float m6 = matrix4x2.m03;
				float m7 = matrix4x3.m01;
				float m8 = matrix4x3.m02;
				float m9 = matrix4x3.m03;
				float m10 = matrix4x4.m01;
				float m11 = matrix4x4.m02;
				float m12 = matrix4x4.m03;
				float m13 = matrix4x5.m01;
				float m14 = matrix4x5.m02;
				float m15 = matrix4x5.m03;
				float m16 = matrix4x6.m01;
				float m17 = matrix4x6.m02;
				float m18 = matrix4x6.m03;
				float m19 = matrix4x7.m01;
				float m20 = matrix4x7.m02;
				float m21 = matrix4x7.m03;
				Material m22 = maskMaterial;
				Camera camera = renderingData.cameraData.camera;
				GridTilesetManager.DrawAllGrassMask(commandBuffer, m22, camera);
				commandBuffer.Clear();
				Material material3 = maskMaterial;
				int num5 = 0;
				int num6 = 0;
			}
			while (num7 != 0);
			CommandBufferPool.Release(commandBuffer);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	public static Grass instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public GrassSettings settings = new GrassSettings
	{
		maxGrassDistance = 50f
	};

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private List<(Guid GUID, GrassPass pass)> m_Passes = (List<(Guid GUID, GrassPass pass)>)(object)new List<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private GrassMaskPass maskPass;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private Plane[] frustrumPlanes = new Plane[6];

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xCEB470", Offset = "0xCE9E70", VA = "0x180CEB470", Slot = "5")]
	public override void Create()
	{
		instance = this;
		GrassMaskPass grassMaskPass = (maskPass = new GrassMaskPass(settings));
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xCEB680", Offset = "0xCEA080", VA = "0x180CEB680")]
	public void UpdateGrassPass(Guid GUID, Vector2 scaleRange, float density, Bounds bounds, Vector2 grassMask, Mesh mesh, Material m)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xCEB510", Offset = "0xCE9F10", VA = "0x180CEB510")]
	public void RemoveGrassPass(Guid GUID)
	{
		//Discarded unreachable code: IL_0043
		List<(Guid, GrassPass)> passes = m_Passes;
		Guid GUID2 = default(Guid);
		Predicate<(Guid, GrassPass)> predicate = (Predicate<(Guid, GrassPass)>)(object)(Predicate<T>)delegate
		{
			Guid guid = GUID2;
			bool result = default(bool);
			return result;
		};
		int num = ((List<T>)(object)passes).FindIndex((Predicate<>)(object)predicate);
		if (num != -1)
		{
			List<(Guid, GrassPass)> passes2 = m_Passes;
			int num2 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			((List<T>)(object)m_Passes).RemoveAt(num);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xCEAEC0", Offset = "0xCE98C0", VA = "0x180CEAEC0", Slot = "6")]
	public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
		//Discarded unreachable code: IL_008b, IL_0091
		int num = 0;
		int num2 = 0;
		Plane[] planes = frustrumPlanes;
		GeometryUtility.CalculateFrustumPlanes(renderingData.cameraData.camera, planes);
		Plane[] array = frustrumPlanes;
		GrassSettings grassSettings = settings;
		float distance = ((Plane*)frustrumPlanes)->distance;
		List<(Guid, GrassPass)> passes = m_Passes;
		bool flag = default(bool);
		if (flag)
		{
			bool flag2 = default(bool);
			while (flag2)
			{
			}
			Plane[] array2 = frustrumPlanes;
			bool flag3 = default(bool);
			while (!flag3)
			{
			}
			Vector3 vector = default(Vector3);
			float z = vector.z;
			float num3 = Mathf.Min(float.MaxValue, z);
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			float num4 = Mathf.Max(float.MinValue, z2);
		}
		bool flag4 = default(bool);
		if (!flag4)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0xCEB9F0", Offset = "0xCEA3F0", VA = "0x180CEB9F0")]
	public Grass()
	{
	}
}
