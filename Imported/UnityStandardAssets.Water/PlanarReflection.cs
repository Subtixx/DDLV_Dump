using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class PlanarReflection : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public LayerMask reflectionMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public bool reflectSkybox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public Color clearColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public string reflectionSampler = "_ReflectionTex";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public float clipPlaneOffset = 0.07f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private Vector3 m_Oldpos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private Camera m_ReflectionCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private Material m_SharedMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E770", Offset = "0x2F1D170", VA = "0x182F1E770")]
		public void Start()
		{
			GameObject gameObject = base.gameObject;
			Type typeFromHandle = typeof(WaterBase);
			Component component = gameObject.GetComponent(typeFromHandle);
			int num = 0;
			if ((object)component != null)
			{
				int num2 = 0;
				if ((object)component != null)
				{
					m_SharedMaterial = (Material)typeof(WaterBase).TypeHandle;
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2F1D3A0", Offset = "0x2F1BDA0", VA = "0x182F1D3A0")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			//Discarded unreachable code: IL_0145
			GameObject gameObject;
			while (true)
			{
				string text = base.gameObject.name;
				string text2 = cam.name;
				string text3 = text + "Reflection" + text2;
				gameObject = GameObject.Find(text3);
				if ((bool)gameObject)
				{
					break;
				}
				Type[] array = new Type[1];
				Type typeFromHandle = typeof(Camera);
				if ((object)typeFromHandle == null || (object)typeFromHandle != null)
				{
					array[0] = typeFromHandle;
					GameObject gameObject2 = new GameObject(text3, array);
					break;
				}
			}
			Type typeFromHandle2 = typeof(Camera);
			if (!gameObject.GetComponent(typeFromHandle2))
			{
				Type typeFromHandle3 = typeof(Camera);
				Component component = gameObject.Internal_AddComponentWithType(typeFromHandle3);
			}
			Camera component2 = gameObject.GetComponent<Camera>();
			Color color2 = (component2.backgroundColor = clearColor);
			int mask = ((LayerMask)reflectionMask.m_Mask).m_Mask;
			int num = LayerMask.NameToLayer("Water");
			component2.cullingMask = mask;
			Color black = Color.black;
			int num2 = ((component2.enabled = false) ? 1 : 0);
			if (!component2.targetTexture)
			{
				int pixelWidth = cam.pixelWidth;
				float num3 = default(float);
				int width = Mathf.FloorToInt(num3);
				int pixelHeight = cam.pixelHeight;
				int height = Mathf.FloorToInt(num3 * 0.5f);
				uint depth = default(uint);
				RenderTexture renderTexture = new RenderTexture(width, height, (int)depth);
				renderTexture.hideFlags = HideFlags.DontSave;
				component2.targetTexture = renderTexture;
			}
			return component2;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E6A0", Offset = "0x2F1D0A0", VA = "0x182F1E6A0")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
			//Discarded unreachable code: IL_0022
			int mask2 = mask.m_Mask;
			int num = LayerMask.NameToLayer("Water");
			Color black = Color.black;
			int num2 = ((cam.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2F1D800", Offset = "0x2F1C200", VA = "0x182F1D800")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			//Discarded unreachable code: IL_003b
			int pixelWidth = cam.pixelWidth;
			float num = default(float);
			int width = Mathf.FloorToInt(num);
			int pixelHeight = cam.pixelHeight;
			int height = Mathf.FloorToInt(num * 0.5f);
			RenderTexture renderTexture = new RenderTexture(width, height, 24);
			renderTexture.hideFlags = HideFlags.DontSave;
			return renderTexture;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x2F1D9D0", Offset = "0x2F1C3D0", VA = "0x182F1D9D0")]
		public void RenderHelpCameras(Camera currentCam)
		{
			//Discarded unreachable code: IL_0023, IL_0027, IL_0034, IL_0043, IL_0051, IL_0062, IL_0081, IL_0082
			if (m_HelperCameras == null)
			{
				Dictionary<Camera, bool> dictionary = (m_HelperCameras = (Dictionary<Camera, bool>)(object)new Dictionary<TKey, TValue>());
				Dictionary<Camera, bool> helperCameras = m_HelperCameras;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2F1D8E0", Offset = "0x2F1C2E0", VA = "0x182F1D8E0")]
		public void LateUpdate()
		{
			((Dictionary<TKey, TValue>)(object)m_HelperCameras)?.Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E8C0", Offset = "0x2F1D2C0", VA = "0x182F1E8C0")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
			//Discarded unreachable code: IL_0023, IL_0027, IL_0034, IL_0043, IL_0051, IL_0062, IL_0081, IL_008f, IL_009d, IL_00c9, IL_00ca
			if (m_HelperCameras == null)
			{
				Dictionary<Camera, bool> dictionary = (m_HelperCameras = (Dictionary<Camera, bool>)(object)new Dictionary<TKey, TValue>());
				Dictionary<Camera, bool> helperCameras = m_HelperCameras;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2F1D980", Offset = "0x2F1C380", VA = "0x182F1D980")]
		public void OnEnable()
		{
			Shader.EnableKeyword("WATER_REFLECTIVE");
			Shader.DisableKeyword("WATER_SIMPLE");
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2F1D930", Offset = "0x2F1C330", VA = "0x182F1D930")]
		public void OnDisable()
		{
			Shader.EnableKeyword("WATER_SIMPLE");
			Shader.DisableKeyword("WATER_REFLECTIVE");
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2F1DB90", Offset = "0x2F1C590", VA = "0x182F1DB90")]
		private unsafe void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
			//Discarded unreachable code: IL_021d
			//IL_0138: Expected I4, but got I8
			//IL_01bb: Expected native int or pointer, but got O
			if (!reflectCamera)
			{
				return;
			}
			bool flag = m_SharedMaterial;
			if (flag)
			{
				Material sharedMaterial = m_SharedMaterial;
				string text = reflectionSampler;
				if (!sharedMaterial.HasProperty(text))
				{
					return;
				}
			}
			LayerMask layerMask = reflectionMask;
			int num = LayerMask.NameToLayer("Water");
			reflectCamera.cullingMask = (flag ? 1 : 0);
			int num2 = (int)(reflectCamera.depthTextureMode = DepthTextureMode.None);
			Color black = Color.black;
			reflectCamera.clearFlags = CameraClearFlags.Color;
			reflectCamera.renderingPath = RenderingPath.Forward;
			Color color2 = (reflectCamera.backgroundColor = clearColor);
			if (reflectSkybox)
			{
				GameObject gameObject = cam.gameObject;
				Type typeFromHandle = typeof(Skybox);
				if ((bool)gameObject.GetComponent(typeFromHandle))
				{
					GameObject gameObject2 = reflectCamera.gameObject;
					Type typeFromHandle2 = typeof(Skybox);
					Component component = gameObject2.GetComponent(typeFromHandle2);
					if ((object)component == null || (object)component != null)
					{
						if (!component)
						{
							GameObject gameObject3 = reflectCamera.gameObject;
							Type typeFromHandle3 = typeof(Skybox);
							Component component2 = gameObject3.Internal_AddComponentWithType(typeFromHandle3);
							if ((object)component2 != null && (object)component2 == null)
							{
								goto IL_0223;
							}
						}
						Type typeFromHandle4 = typeof(Skybox);
						if ((object)cam.GetComponent(typeFromHandle4) != null)
						{
							goto IL_0131;
						}
					}
					goto IL_0223;
				}
			}
			goto IL_0131;
			IL_0131:
			ulong num3 = default(ulong);
			GL.invertCulling = (byte)num3 != 0;
			Transform transform = base.transform;
			Transform transform2 = cam.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform3 = reflectCamera.transform;
			Transform transform4 = reflectCamera.transform;
			Transform transform5 = cam.transform;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			Transform transform6 = transform.transform;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			Transform transform7 = transform.transform;
			float z4 = transform.up.z;
			Matrix4x4 zero = Matrix4x4.zero;
			Transform transform8 = cam.transform;
			Vector3 vector4 = default(Vector3);
			float z5 = vector4.z;
			((Vector3*)(IntPtr)m_Oldpos)->z = z5;
			float z6 = vector4.z;
			Vector3 vector5 = default(Vector3);
			float z7 = vector5.z;
			Matrix4x4 worldToCameraMatrix = reflectCamera.worldToCameraMatrix;
			Vector3 vector6 = default(Vector3);
			float z8 = vector6.z;
			Vector3 vector7 = default(Vector3);
			float z9 = vector7.z;
			int num4 = 0;
			Transform transform9 = reflectCamera.transform;
			Transform transform10 = cam.transform;
			Vector3 vector8 = default(Vector3);
			float z10 = vector8.z;
			Transform transform11 = reflectCamera.transform;
			reflectCamera.Render();
			GL.invertCulling = false;
			return;
			IL_0223:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E630", Offset = "0x2F1D030", VA = "0x182F1E630")]
		private void SaneCameraSettings(Camera helperCam)
		{
			//Discarded unreachable code: IL_001e
			int num = (int)(helperCam.depthTextureMode = DepthTextureMode.None);
			Color black = Color.black;
			helperCam.clearFlags = CameraClearFlags.Color;
			helperCam.renderingPath = RenderingPath.Forward;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2F1CC20", Offset = "0x2F1B620", VA = "0x182F1CC20")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			int num = 0;
			Matrix4x4 matrix4x = default(Matrix4x4);
			float m = matrix4x.m01;
			float m2 = matrix4x.m02;
			float m3 = matrix4x.m03;
			int num2 = 0;
			int num3 = 0;
			return projection;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2F1CE80", Offset = "0x2F1B880", VA = "0x182F1CE80")]
		private unsafe static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			//IL_0059: Expected F4, but got I4
			//IL_0054: Expected native int or pointer, but got O
			//IL_0060: Expected native int or pointer, but got O
			//IL_0068: Expected native int or pointer, but got O
			//IL_0070: Expected native int or pointer, but got O
			//IL_0078: Expected native int or pointer, but got O
			int num = 0;
			int num2 = 0;
			float num3 = default(float);
			float num4 = num3 * 2f;
			int num5 = 0;
			float num6 = default(float);
			num4 = num6;
			int num7 = 0;
			float num8 = default(float);
			num4 = num8;
			int num9 = 0;
			float num10 = default(float);
			num4 = num10;
			int num11 = 0;
			float num12 = default(float);
			num4 = num12;
			float num13 = default(float);
			num4 = num13;
			float num14 = num4 * 2f;
			float num15 = default(float);
			num14 = num15;
			float num16 = default(float);
			num14 = num16;
			int num17 = 0;
			float num18 = default(float);
			num14 = num18;
			float num19 = default(float);
			num14 = num19;
			float num20 = default(float);
			num14 = num20;
			int num21 = 0;
			((Vector4*)(IntPtr)plane)->w = num21;
			float m = default(float);
			((Matrix4x4*)(IntPtr)reflectionMat)->m03 = (((Matrix4x4*)(IntPtr)reflectionMat)->m01 = (((Vector4*)(IntPtr)plane)->x = (((Matrix4x4*)(IntPtr)reflectionMat)->m00 = m)));
			return reflectionMat;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2F1E740", Offset = "0x2F1D140", VA = "0x182F1E740")]
		private static float Sgn(float a)
		{
			//IL_0004: Invalid comparison between F4 and I4
			//IL_0008: Invalid comparison between I4 and F4
			while (true)
			{
				int num = 0;
				if (!(a > (float)num) && !((float)num <= a))
				{
					/*Error: Could not find block for branch target IL_000a*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2F1D190", Offset = "0x2F1BB90", VA = "0x182F1D190")]
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

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2F1EB30", Offset = "0x2F1D530", VA = "0x182F1EB30")]
		public PlanarReflection()
		{
		}
	}
}
