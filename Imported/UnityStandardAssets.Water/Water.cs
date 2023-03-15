using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public enum WaterMode
		{
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			Simple,
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			Reflective,
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			Refractive
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public WaterMode waterMode = WaterMode.Refractive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public bool disablePixelLights = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public int textureSize = 256;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public float clipPlaneOffset = 0.07f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public LayerMask reflectLayers = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public LayerMask refractLayers = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private Dictionary<Camera, Camera> m_ReflectionCameras = (Dictionary<Camera, Camera>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private Dictionary<Camera, Camera> m_RefractionCameras = (Dictionary<Camera, Camera>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private RenderTexture m_ReflectionTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private RenderTexture m_RefractionTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private WaterMode m_HardwareWaterSupport = WaterMode.Refractive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private int m_OldReflectionTextureSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private int m_OldRefractionTextureSize;

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private static bool s_InsideWater;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3DC9C50", Offset = "0x3DC8650", VA = "0x183DC9C50")]
		public unsafe void OnWillRenderObject()
		{
			//Discarded unreachable code: IL_03d2
			//IL_00f8: Expected O, but got I4
			//IL_00f8: Expected O, but got I4
			//IL_0139: Expected I4, but got I8
			//IL_0192: Expected O, but got I4
			//IL_0192: Expected O, but got I4
			//IL_01d3: Expected I4, but got I8
			int num = 0;
			if (!base.enabled || !GetComponent<Renderer>() || !GetComponent<Renderer>().GetSharedMaterial() || !GetComponent<Renderer>().enabled)
			{
				return;
			}
			int num2 = 0;
			Camera current = Camera.current;
			if (!current)
			{
				return;
			}
			if ((bool)GetComponent<Renderer>())
			{
				Material sharedMaterial = GetComponent<Renderer>().GetSharedMaterial();
				if ((bool)sharedMaterial)
				{
					int searchFallbacks = 0;
					string a = sharedMaterial.GetTag("WATERMODE", (byte)searchFallbacks != 0);
					if (!string.Equals(a, "Refractive"))
					{
						bool flag = string.Equals(a, "Reflective");
					}
				}
			}
			WaterMode waterMode = this.waterMode;
			m_HardwareWaterSupport = (WaterMode)num;
			CreateWaterObjects(current, out *(Camera*)num, out *(Camera*)num);
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			int num3 = 0;
			int pixelLightCount = QualitySettings.pixelLightCount;
			if ((disablePixelLights ? 1 : 0) != num)
			{
				QualitySettings.pixelLightCount = 0;
			}
			int num4 = 0;
			if (!((UnityEngine.Object)num == (UnityEngine.Object)num4))
			{
				CameraClearFlags clearFlags = current.clearFlags;
				if (current.clearFlags == CameraClearFlags.Skybox)
				{
					Skybox component = current.GetComponent<Skybox>();
					Skybox skybox = default(Skybox);
					if ((bool)component && (bool)component.material)
					{
						ulong num5 = default(ulong);
						skybox.enabled = (byte)num5 != 0;
						Material material2 = (skybox.material = component.material);
					}
					int num6 = ((skybox.enabled = false) ? 1 : 0);
				}
				float farClipPlane = current.farClipPlane;
				farClipPlane = current.nearClipPlane;
				bool orthographic = current.orthographic;
				farClipPlane = current.fieldOfView;
				farClipPlane = current.aspect;
				farClipPlane = current.orthographicSize;
			}
			int num7 = 0;
			if (!((UnityEngine.Object)num == (UnityEngine.Object)num7))
			{
				CameraClearFlags clearFlags2 = current.clearFlags;
				if (current.clearFlags == CameraClearFlags.Skybox)
				{
					Skybox component2 = current.GetComponent<Skybox>();
					Skybox skybox2 = default(Skybox);
					if ((bool)component2 && (bool)component2.material)
					{
						ulong num8 = default(ulong);
						skybox2.enabled = (byte)num8 != 0;
						Material material4 = (skybox2.material = component2.material);
					}
					int num9 = ((skybox2.enabled = false) ? 1 : 0);
				}
				float farClipPlane = current.farClipPlane;
				farClipPlane = current.nearClipPlane;
				bool orthographic2 = current.orthographic;
				farClipPlane = current.fieldOfView;
				farClipPlane = current.aspect;
				farClipPlane = current.orthographicSize;
			}
			float m = Matrix4x4.zero.m02;
			Transform transform3 = current.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Matrix4x4 worldToCameraMatrix = current.worldToCameraMatrix;
			Matrix4x4 matrix4x = default(Matrix4x4);
			float m2 = matrix4x.m02;
			float m3 = matrix4x.m03;
			float num10 = clipPlaneOffset;
			m2 = num10;
			m3 = num10;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			Vector3 vector5 = default(Vector3);
			float z5 = vector5.z;
			int num11 = 0;
			Matrix4x4 matrix4x2 = default(Matrix4x4);
			float m4 = matrix4x2.m00;
			RenderTexture reflectionTexture = m_ReflectionTexture;
			int num12 = 0;
			bool invertCulling = GL.invertCulling;
			GL.invertCulling = !invertCulling;
			Transform transform4 = current.transform;
			Vector3 vector6 = default(Vector3);
			float z6 = vector6.z;
			GL.invertCulling = invertCulling;
			Material sharedMaterial2 = GetComponent<Renderer>().GetSharedMaterial();
			RenderTexture reflectionTexture2 = m_ReflectionTexture;
			sharedMaterial2.SetTexture("_ReflectionTex", reflectionTexture2);
			Matrix4x4 matrix4x3 = default(Matrix4x4);
			float m5 = matrix4x3.m02;
			float m6 = matrix4x3.m03;
			float num13 = clipPlaneOffset;
			m5 = num13;
			m6 = num13;
			Vector3 vector7 = default(Vector3);
			float z7 = vector7.z;
			Vector3 vector8 = default(Vector3);
			float z8 = vector8.z;
			Vector3 vector9 = default(Vector3);
			float z9 = vector9.z;
			int num14 = 0;
			num10 = num13;
			Matrix4x4 matrix4x4 = default(Matrix4x4);
			float m7 = matrix4x4.m00;
			RenderTexture refractionTexture = m_RefractionTexture;
			Transform transform5 = current.transform;
			Vector3 vector10 = default(Vector3);
			float z10 = vector10.z;
			Transform transform6 = current.transform;
			Material sharedMaterial3 = GetComponent<Renderer>().GetSharedMaterial();
			RenderTexture refractionTexture2 = m_RefractionTexture;
			sharedMaterial3.SetTexture("_RefractionTex", refractionTexture2);
			if (disablePixelLights)
			{
			}
			if (num != 0)
			{
				switch (num)
				{
				case 1:
					Shader.DisableKeyword("WATER_SIMPLE");
					Shader.DisableKeyword("WATER_REFLECTIVE");
					Shader.EnableKeyword("WATER_REFRACTIVE");
					break;
				case 0:
					break;
				default:
					return;
				}
				Shader.DisableKeyword("WATER_SIMPLE");
				Shader.EnableKeyword("WATER_REFLECTIVE");
			}
			Shader.EnableKeyword("WATER_SIMPLE");
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3DC9910", Offset = "0x3DC8310", VA = "0x183DC9910")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0061, IL_0067, IL_006d
			//IL_0022: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			int num = 0;
			if ((bool)m_ReflectionTexture)
			{
				UnityEngine.Object.DestroyImmediate(m_ReflectionTexture);
				m_ReflectionTexture = (RenderTexture)num;
			}
			if ((bool)m_RefractionTexture)
			{
				UnityEngine.Object.DestroyImmediate(m_RefractionTexture);
				m_RefractionTexture = (RenderTexture)num;
			}
			Dictionary<Camera, Camera> reflectionCameras = m_ReflectionCameras;
			bool flag = default(bool);
			if (flag)
			{
				GameObject obj = default(GameObject);
				UnityEngine.Object.DestroyImmediate(obj);
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				GameObject obj2 = default(GameObject);
				UnityEngine.Object.DestroyImmediate(obj2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB300", Offset = "0x3DC9D00", VA = "0x183DCB300")]
		private void Update()
		{
			//Discarded unreachable code: IL_0083
			//IL_0075: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			if ((bool)GetComponent<Renderer>())
			{
				Material sharedMaterial = GetComponent<Renderer>().GetSharedMaterial();
				if ((bool)sharedMaterial)
				{
					float @float = sharedMaterial.GetFloat("_WaveScale");
					float num = @float * 0.45f;
					int num2 = 0;
					num = @float;
					int num3 = 0;
					double x = Math.IEEERemainder(Math.IEEERemainder(Math.IEEERemainder(Time.timeSinceLevelLoad, num), num), num);
					int num4 = 0;
					double num5 = Math.IEEERemainder(x, num);
					int num6 = 0;
					sharedMaterial.SetVector("_WaveOffset", (Vector4)num4);
					sharedMaterial.SetVector("_WaveScale4", (Vector4)num4);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB090", Offset = "0x3DC9A90", VA = "0x183DCB090")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
			//Discarded unreachable code: IL_00cb
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (dest == (UnityEngine.Object)num)
			{
				return;
			}
			CameraClearFlags clearFlags = src.clearFlags;
			if (src.clearFlags == CameraClearFlags.Skybox)
			{
				Skybox component = src.GetComponent<Skybox>();
				Skybox component2 = dest.GetComponent<Skybox>();
				if ((bool)component && (bool)component.material)
				{
					component2.enabled = true;
					Material material2 = (component2.material = component.material);
				}
				int num2 = ((component2.enabled = false) ? 1 : 0);
			}
			float num3 = (dest.farClipPlane = src.farClipPlane);
			num3 = (dest.nearClipPlane = src.nearClipPlane);
			bool flag2 = (dest.orthographic = src.orthographic);
			num3 = (dest.fieldOfView = src.fieldOfView);
			num3 = (dest.aspect = src.aspect);
			num3 = (dest.orthographicSize = src.orthographicSize);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8D40", Offset = "0x3DC7740", VA = "0x183DC8D40")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
			//Discarded unreachable code: IL_02f7
			string text = default(string);
			bool flag = default(bool);
			string text4 = default(string);
			string text5 = default(string);
			GameObject gameObject2 = default(GameObject);
			bool flag2 = default(bool);
			string text7 = default(string);
			string text8 = default(string);
			GameObject gameObject3 = default(GameObject);
			GameObject gameObject4 = default(GameObject);
			string text10 = default(string);
			while (true)
			{
				WaterMode waterMode = this.waterMode;
				int num = 0;
				if (m_HardwareWaterSupport < waterMode)
				{
					WaterMode hardwareWaterSupport = m_HardwareWaterSupport;
				}
				if ((bool)m_ReflectionTexture)
				{
					int num2 = textureSize;
					if (m_OldReflectionTextureSize == num2)
					{
						goto IL_00c4;
					}
				}
				if ((bool)m_ReflectionTexture)
				{
					UnityEngine.Object.DestroyImmediate(m_ReflectionTexture);
				}
				int num3 = textureSize;
				RenderTexture renderTexture = (m_ReflectionTexture = new RenderTexture(num3, num3, 16));
				RenderTexture reflectionTexture = m_ReflectionTexture;
				int instanceID = GetInstanceID();
				string text3 = (reflectionTexture.name = "__WaterReflection" + text);
				m_ReflectionTexture.isPowerOfTwo = true;
				m_ReflectionTexture.hideFlags = HideFlags.DontSave;
				int oldReflectionTextureSize = textureSize;
				int num4 = 0;
				m_OldReflectionTextureSize = oldReflectionTextureSize;
				goto IL_00c4;
				IL_022c:
				Dictionary<Camera, Camera> refractionCameras = m_RefractionCameras;
				if (flag)
				{
					break;
				}
				int instanceID2 = GetInstanceID();
				int instanceID3 = currentCamera.GetInstanceID();
				string text6 = "Water Refr Camera id" + text4 + " for " + text5;
				Type[] array = new Type[2];
				Type typeFromHandle = typeof(Camera);
				if ((object)typeFromHandle == null || (object)typeFromHandle != null)
				{
					array[0] = typeFromHandle;
					Type typeFromHandle2 = typeof(Skybox);
					if ((object)typeFromHandle2 == null || (object)typeFromHandle2 != null)
					{
						array[1] = typeFromHandle2;
						GameObject gameObject = new GameObject(text6, array);
						Camera component = gameObject.GetComponent<Camera>();
						int num5 = 0;
						Transform transform = base.transform;
						Transform transform2 = base.transform;
						FlareLayer flareLayer = gameObject2.AddComponent<FlareLayer>();
						gameObject.hideFlags = HideFlags.HideAndDontSave;
						Dictionary<Camera, Camera> refractionCameras2 = m_RefractionCameras;
						throw new NullReferenceException();
					}
				}
				continue;
				IL_00c4:
				Dictionary<Camera, Camera> reflectionCameras = m_ReflectionCameras;
				if (!flag2)
				{
					int instanceID4 = GetInstanceID();
					int instanceID5 = currentCamera.GetInstanceID();
					string text9 = "Water Refl Camera id" + text7 + " for " + text8;
					Type[] array2 = new Type[2];
					Type typeFromHandle3 = typeof(Camera);
					if ((object)typeFromHandle3 == null || (object)typeFromHandle3 != null)
					{
						array2[0] = typeFromHandle3;
						Type typeFromHandle4 = typeof(Skybox);
						if ((object)typeFromHandle4 == null || (object)typeFromHandle4 != null)
						{
							array2[1] = typeFromHandle4;
							Camera component2 = gameObject3.GetComponent<Camera>();
							int num6 = 0;
							Transform transform3 = base.transform;
							Transform transform4 = base.transform;
							FlareLayer flareLayer2 = gameObject4.AddComponent<FlareLayer>();
							gameObject3.hideFlags = HideFlags.HideAndDontSave;
							Dictionary<Camera, Camera> reflectionCameras2 = m_ReflectionCameras;
							throw new NullReferenceException();
						}
					}
					continue;
				}
				if ((bool)m_RefractionTexture)
				{
					int num7 = textureSize;
					if (m_OldRefractionTextureSize == num7)
					{
						goto IL_022c;
					}
				}
				if ((bool)m_RefractionTexture)
				{
					UnityEngine.Object.DestroyImmediate(m_RefractionTexture);
				}
				int num8 = textureSize;
				RenderTexture renderTexture2 = (m_RefractionTexture = new RenderTexture(num8, num8, 16));
				RenderTexture refractionTexture = m_RefractionTexture;
				int instanceID6 = GetInstanceID();
				string text12 = (refractionTexture.name = "__WaterRefraction" + text10);
				m_RefractionTexture.isPowerOfTwo = true;
				m_RefractionTexture.hideFlags = HideFlags.DontSave;
				int num9 = (m_OldRefractionTextureSize = textureSize);
				goto IL_022c;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3DC9900", Offset = "0x3DC8300", VA = "0x183DC9900")]
		private WaterMode GetWaterMode()
		{
			if (m_HardwareWaterSupport >= waterMode)
			{
				return waterMode;
			}
			WaterMode result = default(WaterMode);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3DC9790", Offset = "0x3DC8190", VA = "0x183DC9790")]
		private WaterMode FindHardwareWaterSupport()
		{
			if ((bool)GetComponent<Renderer>())
			{
				Material sharedMaterial = GetComponent<Renderer>().GetSharedMaterial();
				if ((bool)sharedMaterial)
				{
					int searchFallbacks = 0;
					string a = sharedMaterial.GetTag("WATERMODE", (byte)searchFallbacks != 0);
					if (!string.Equals(a, "Refractive"))
					{
						bool flag = string.Equals(a, "Reflective");
					}
					return WaterMode.Refractive;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8B30", Offset = "0x3DC7530", VA = "0x183DC8B30")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			float z = normal.z;
			Vector3 vector = default(Vector3);
			float z2 = vector.z;
			Vector3 vector2 = default(Vector3);
			float z3 = vector2.z;
			Vector3 vector3 = default(Vector3);
			float z4 = vector3.z;
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8890", Offset = "0x3DC7290", VA = "0x183DC8890")]
		private unsafe static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
			//IL_0158: Expected F4, but got I4
			//IL_0160: Expected F4, but got I4
			//IL_0168: Expected F4, but got I4
			int index = 0;
			float num = (*(Vector4*)plane)[index];
			int index2 = 0;
			float num2 = (*(Vector4*)plane)[index2];
			float num3 = num * 2f;
			int index3 = 0;
			num3 = (*(Vector4*)plane)[index3];
			float m = (*(Vector4*)plane)[1];
			int index4 = 0;
			reflectionMat.m01 = m;
			num3 = (*(Vector4*)plane)[index4];
			float num4 = (reflectionMat.m02 = (*(Vector4*)plane)[2]);
			float num5 = (*(Vector4*)plane)[3];
			int index5 = 0;
			num3 = num5;
			float num6 = (reflectionMat.m03 = (*(Vector4*)plane)[index5]);
			float num7 = (*(Vector4*)plane)[1];
			int index6 = 0;
			num3 = num7;
			float num8 = (reflectionMat.m10 = (*(Vector4*)plane)[index6]);
			num3 = (*(Vector4*)plane)[1];
			float num9 = (*(Vector4*)plane)[1];
			float num10 = num3 * 2f;
			num10 = (*(Vector4*)plane)[1];
			float num11 = (reflectionMat.m12 = (*(Vector4*)plane)[2]);
			num10 = (*(Vector4*)plane)[3];
			float num12 = (reflectionMat.m13 = (*(Vector4*)plane)[1]);
			float num13 = (*(Vector4*)plane)[2];
			int index7 = 0;
			num10 = num13;
			float num14 = (reflectionMat.m20 = (*(Vector4*)plane)[index7]);
			num10 = (*(Vector4*)plane)[2];
			float num15 = (reflectionMat.m21 = (*(Vector4*)plane)[1]);
			num10 = (*(Vector4*)plane)[2];
			float num16 = (*(Vector4*)plane)[2];
			float num17 = (*(Vector4*)plane)[3];
			float m2 = (*(Vector4*)plane)[2];
			int num18 = 0;
			reflectionMat.m30 = num18;
			reflectionMat.m31 = num18;
			reflectionMat.m32 = num18;
			reflectionMat.m33 = 1f;
			reflectionMat.m23 = m2;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB630", Offset = "0x3DCA030", VA = "0x183DCB630")]
		public Water()
		{
		}//IL_0009: Expected I4, but got I8
		//IL_001d: Expected I4, but got I8
		//IL_0067: Expected I4, but got I8

	}
}
