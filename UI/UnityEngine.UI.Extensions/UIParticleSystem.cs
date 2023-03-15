using System;
using Cpp2IlInjected;
using Mono.Xml;

namespace UnityEngine.UI.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[ExecuteInEditMode]
	[AddComponentMenu("UI/Effects/Extensions/UIParticleSystem")]
	[RequireComponent(typeof(CanvasRenderer), typeof(ParticleSystem))]
	public class UIParticleSystem : MaskableGraphic
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[Tooltip("Having this enabled run the system in LateUpdate rather than in Update making it faster but less precise (more clunky)")]
		public bool fixedTime = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private Transform _transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private ParticleSystem pSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private ParticleSystem.Particle[] particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private UIVertex[] _quad = new UIVertex[4];

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private Vector4 imageUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private ParticleSystem.TextureSheetAnimationModule textureSheetAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private int textureSheetAnimationFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private Vector2 textureSheetAnimationFrameSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private ParticleSystemRenderer pRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private Material currentMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private Texture currentTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private ParticleSystem.MainModule mainModule;

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public override Texture mainTexture
		{
			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0x975DD0", Offset = "0x9747D0", VA = "0x180975DD0", Slot = "35")]
			get
			{
				return currentTexture;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0xC976D0", Offset = "0xC960D0", VA = "0x180C976D0")]
		protected unsafe bool Initialize()
		{
			//IL_0012: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			//IL_0101: Expected O, but got I4
			//IL_011d: Expected O, but got I4
			//IL_0141: Expected O, but got I4
			//IL_016e: Expected F4, but got I4
			//IL_0169: Expected native int or pointer, but got O
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_018b: Expected I4, but got O
			int num = 0;
			Transform transform = _transform;
			int num2 = 0;
			if (transform == (Object)num2)
			{
				Transform transform2 = (_transform = base.transform);
			}
			bool flag = default(bool);
			if (flag)
			{
				ParticleSystem particleSystem = (pSystem = GetComponent<ParticleSystem>());
				bool flag2 = default(bool);
				if (flag2)
				{
					throw new NullReferenceException();
				}
				mainModule = (ParticleSystem.MainModule)flag2;
				if ((flag2 ? 1 : 0) > (true ? 1 : 0))
				{
				}
				ParticleSystemRenderer particleSystemRenderer = default(ParticleSystemRenderer);
				pRenderer = particleSystemRenderer;
				ParticleSystemRenderer particleSystemRenderer2 = pRenderer;
				int num3 = 0;
				if (particleSystemRenderer2 != (Object)num3)
				{
					ParticleSystemRenderer particleSystemRenderer3 = pRenderer;
					int num4 = ((particleSystemRenderer3.enabled = false) ? 1 : 0);
				}
				Material material = new Material(Shader.Find("UI Extensions/Particles/Additive"));
				Material material2 = this.material;
				int num5 = 0;
				if (material2 == (Object)num5)
				{
					this.material = material;
				}
				Material material3 = (currentMaterial = this.material);
				if ((bool)material && material.HasProperty("_MainTex"))
				{
					Texture texture = (currentTexture = material.mainTexture);
					Texture texture2 = currentTexture;
					int num6 = 0;
					if (texture2 == (Object)num6)
					{
						int num7 = 0;
						Texture2D texture2D = (Texture2D)(currentTexture = Texture2D.whiteTexture);
					}
				}
				particles = (ParticleSystem.Particle[])num;
			}
			ParticleSystem.Particle[] array = default(ParticleSystem.Particle[]);
			if ((IntPtr)particles == (IntPtr)num)
			{
				array = (particles = new ParticleSystem.Particle[0]);
			}
			int num8 = 0;
			imageUV = (Vector4)num8;
			textureSheetAnimation = (ParticleSystem.TextureSheetAnimationModule)array;
			int num9 = 0;
			textureSheetAnimationFrames = num;
			Vector2 vector = (textureSheetAnimationFrameSize = Vector2.zero);
			((Vector2*)(IntPtr)textureSheetAnimationFrameSize)->y = 0f;
			if ((object)vector != null)
			{
				float x = vector.x;
				Vector2 vector2 = vector * x;
				textureSheetAnimationFrames = (int)vector2;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xC97690", Offset = "0xC96090", VA = "0x180C97690", Slot = "4")]
		protected override void Awake()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			((Mono.Xml.SecurityParser)(object)this).OnStartParsing((Mono.Xml.SmallXmlParser)num);
			if (!Initialize())
			{
				int num2 = ((base.enabled = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0xC97F70", Offset = "0xC96970", VA = "0x180C97F70", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
			//Discarded unreachable code: IL_03b0
			//IL_0183: Expected O, but got F4
			//IL_0197: Expected O, but got F4
			//IL_01ac: Expected O, but got F4
			//IL_01ba: Expected O, but got I4
			//IL_01e7: Expected O, but got F4
			//IL_01fd: Expected O, but got F4
			//IL_0213: Expected O, but got F4
			//IL_0230: Expected O, but got I4
			//IL_025d: Expected O, but got F4
			//IL_0273: Expected O, but got F4
			//IL_0289: Expected O, but got F4
			//IL_02a6: Expected O, but got I4
			//IL_02d3: Expected O, but got F4
			//IL_02e9: Expected O, but got F4
			//IL_02ff: Expected O, but got F4
			//IL_031c: Expected O, but got I4
			//IL_0338: Expected O, but got I8
			//IL_0347: Expected O, but got I8
			//IL_0356: Expected O, but got I8
			//IL_036c: Expected O, but got I8
			//IL_037b: Expected O, but got I8
			//IL_038a: Expected O, but got I8
			//IL_0399: Expected O, but got I8
			int num = 0;
			vh.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int num2 = 0;
			Vector2 zero = Vector2.zero;
			int num3 = 0;
			Vector2 zero2 = Vector2.zero;
			int num4 = 0;
			Vector2 zero3 = Vector2.zero;
			ParticleSystem particleSystem = pSystem;
			ParticleSystem.Particle[] array = particles;
			int num5 = particleSystem.GetParticles(array);
			int num6 = 0;
			if (num5 <= 0)
			{
				return;
			}
			int num7 = 0;
			ParticleSystem.Particle[] array2 = particles;
			long num8 = (long)num6 * 132L;
			ParticleSystem.Particle particle = default(ParticleSystem.Particle);
			if ((object)particle == null)
			{
			}
			Transform transform = _transform;
			ParticleSystem particleSystem2 = pSystem;
			ParticleSystem particleSystem3 = pSystem;
			Color32 color = default(Color32);
			int rgba = color.rgba;
			Canvas canvas = default(Canvas);
			if ((long)color == 2)
			{
				canvas = base.canvas;
				float scaleFactor = canvas.scaleFactor;
			}
			float y = default(float);
			if ((object)canvas != null)
			{
				ParticleSystem.MinMaxCurve minMaxCurve = default(ParticleSystem.MinMaxCurve);
				AnimationCurve curveMax = minMaxCurve.m_CurveMax;
				float num10;
				if ((object)minMaxCurve == null)
				{
					ParticleSystem.MinMaxCurve minMaxCurve2 = default(ParticleSystem.MinMaxCurve);
					AnimationCurve curveMax2 = minMaxCurve2.m_CurveMax;
					if ((object)minMaxCurve2 == null)
					{
						ParticleSystem.MinMaxCurve minMaxCurve3 = default(ParticleSystem.MinMaxCurve);
						AnimationCurve curveMax3 = minMaxCurve3.m_CurveMax;
						ParticleSystem.MinMaxCurve minMaxCurve4 = default(ParticleSystem.MinMaxCurve);
						AnimationCurve curveMax4 = minMaxCurve4.m_CurveMax;
						float num9 = default(float);
						num10 = num9;
					}
					ParticleSystem.MinMaxCurve minMaxCurve5 = default(ParticleSystem.MinMaxCurve);
					AnimationCurve curveMax5 = minMaxCurve5.m_CurveMax;
				}
				ParticleSystem.MinMaxCurve minMaxCurve6 = default(ParticleSystem.MinMaxCurve);
				AnimationCurve curveMax6 = minMaxCurve6.m_CurveMax;
				float num11 = default(float);
				num10 = num11;
				float t = default(float);
				float num12 = Mathf.Repeat(t, 1f);
				num10 = num12;
				int num13 = default(int);
				if ((object)minMaxCurve6 == null)
				{
					num13 = Mathf.FloorToInt(num12);
				}
				int num16;
				if (num13 == 1)
				{
					int num14 = Mathf.FloorToInt(num12);
					num13 = num14;
					int num15 = 0;
					num16 = num14 * num14;
					num13 += num16;
				}
				num16 = num13;
				int num17 = Mathf.FloorToInt(num12);
				y = textureSheetAnimationFrameSize.y;
				t = y;
			}
			UIVertex[] quad = _quad;
			UIVertex uIVertex = (quad[0] = UIVertex.simpleVert);
			quad[2] = (UIVertex)y;
			quad[4] = uIVertex;
			quad[6] = (UIVertex)y;
			quad[8] = uIVertex;
			quad[10] = (UIVertex)y;
			_quad[5] = (UIVertex)rgba;
			UIVertex[] quad2 = _quad;
			UIVertex[] quad3 = _quad;
			UIVertex uIVertex2 = (quad3[13] = UIVertex.simpleVert);
			quad3[15] = (UIVertex)y;
			quad3[17] = uIVertex2;
			quad3[19] = (UIVertex)y;
			quad3[21] = uIVertex2;
			quad3[23] = (UIVertex)y;
			quad3[26] = (UIVertex)typeof(UIVertex).TypeHandle;
			_quad[18] = (UIVertex)rgba;
			UIVertex[] quad4 = _quad;
			UIVertex[] quad5 = _quad;
			UIVertex uIVertex3 = (quad5[27] = UIVertex.simpleVert);
			quad5[29] = (UIVertex)y;
			quad5[31] = uIVertex3;
			quad5[33] = (UIVertex)y;
			quad5[35] = uIVertex3;
			quad5[37] = (UIVertex)y;
			quad5[40] = (UIVertex)typeof(UIVertex).TypeHandle;
			_quad[32] = (UIVertex)rgba;
			UIVertex[] quad6 = _quad;
			UIVertex[] quad7 = _quad;
			UIVertex uIVertex4 = (quad7[40] = UIVertex.simpleVert);
			quad7[42] = (UIVertex)y;
			quad7[44] = uIVertex4;
			quad7[46] = (UIVertex)y;
			quad7[48] = uIVertex4;
			quad7[50] = (UIVertex)y;
			quad7[53] = (UIVertex)typeof(UIVertex).TypeHandle;
			_quad[45] = (UIVertex)rgba;
			ulong num20 = default(ulong);
			if (_quad.Length == 3)
			{
				ulong num18 = default(ulong);
				_quad[1] = (UIVertex)num18;
				ulong num19 = default(ulong);
				_quad[14] = (UIVertex)num19;
				_quad[28] = (UIVertex)num20;
				UIVertex[] quad8 = _quad;
			}
			_quad[1] = (UIVertex)num20;
			_quad[14] = (UIVertex)num20;
			_quad[28] = (UIVertex)num20;
			_quad[41] = (UIVertex)num20;
			UIVertex[] quad9 = _quad;
			vh.AddUIVertexQuad(quad9);
			num6++;
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0xC98E10", Offset = "0xC97810", VA = "0x180C98E10")]
		private void Update()
		{
			//Discarded unreachable code: IL_00e3
			//IL_003b: Expected I4, but got I8
			//IL_0055: Expected O, but got I4
			//IL_0091: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			//IL_00da: Expected O, but got I8
			if (fixedTime)
			{
				return;
			}
			int num = 0;
			if (!Application.isPlaying)
			{
				return;
			}
			int num2 = 0;
			ParticleSystem particleSystem = pSystem;
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			int restart = 0;
			int withChildren = 0;
			ulong num3 = default(ulong);
			particleSystem.Simulate(unscaledDeltaTime, (byte)withChildren != 0, (byte)restart != 0, (byte)num3 != 0);
			SetAllDirty();
			Material material = currentMaterial;
			int num4 = 0;
			if (material != (Object)num4)
			{
				Material material2 = currentMaterial;
				Texture texture = currentTexture;
				Texture texture2 = material2.mainTexture;
				if (texture != texture2)
				{
					goto IL_00d1;
				}
			}
			Material material3 = this.material;
			int num5 = 0;
			if (material3 != (Object)num5)
			{
				Material material4 = currentMaterial;
				int num6 = 0;
				if (material4 != (Object)num6)
				{
					Shader shader = this.material.shader;
					Shader shader2 = currentMaterial.shader;
					if (!(shader != shader2))
					{
						return;
					}
					goto IL_00d1;
				}
				return;
			}
			return;
			IL_00d1:
			pSystem = (ParticleSystem)0;
			bool flag = Initialize();
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0xC97C90", Offset = "0xC96690", VA = "0x180C97C90")]
		private void LateUpdate()
		{
			//Discarded unreachable code: IL_010d
			//IL_003b: Expected I4, but got I8
			//IL_0055: Expected O, but got I4
			//IL_0091: Expected O, but got I4
			//IL_00a8: Expected O, but got I4
			//IL_00da: Expected O, but got I8
			int num = 0;
			if (!Application.isPlaying)
			{
				goto IL_00e2;
			}
			if (fixedTime)
			{
				ParticleSystem particleSystem = pSystem;
				int num2 = 0;
				float unscaledDeltaTime = Time.unscaledDeltaTime;
				int restart = 0;
				int withChildren = 0;
				ulong num3 = default(ulong);
				particleSystem.Simulate(unscaledDeltaTime, (byte)withChildren != 0, (byte)restart != 0, (byte)num3 != 0);
				SetAllDirty();
				Material material = currentMaterial;
				int num4 = 0;
				if (material != (Object)num4)
				{
					Material material2 = currentMaterial;
					Texture texture = currentTexture;
					Texture texture2 = material2.mainTexture;
					if (texture != texture2)
					{
						goto IL_00d1;
					}
				}
				Material material3 = this.material;
				int num5 = 0;
				if (material3 != (Object)num5)
				{
					Material material4 = currentMaterial;
					int num6 = 0;
					if (material4 != (Object)num6)
					{
						Shader shader = this.material.shader;
						Shader shader2 = currentMaterial.shader;
						if (shader != shader2)
						{
							goto IL_00d1;
						}
					}
				}
			}
			goto IL_00e8;
			IL_00e8:
			Material material5 = this.material;
			Material material6 = currentMaterial;
			if (!(material5 == material6))
			{
				bool flag = Initialize();
			}
			return;
			IL_00e2:
			SetAllDirty();
			goto IL_00e8;
			IL_00d1:
			pSystem = (ParticleSystem)0;
			bool flag2 = Initialize();
			goto IL_00e2;
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xC99070", Offset = "0xC97A70", VA = "0x180C99070")]
		public UIParticleSystem()
		{
			Vector4 zero = Vector4.zero;
			base._002Ector();
		}
	}
}
