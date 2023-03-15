using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using SoftMasking.Extensions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace SoftMasking
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Soft Mask", 14)]
	[HelpURL("https://docs.google.com/document/d/1xFZQGn_odhTCokMFR0LyCPXWtqWXN-bBGVS9GETglx8")]
	public class SoftMask : UIBehaviour, ISoftMask, ICanvasRaycastFilter
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		public enum MaskSource
		{
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			Graphic,
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			Sprite,
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			Texture
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		public enum BorderMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			Simple,
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			Sliced,
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			Tiled
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		[Flags]
		public enum Errors
		{
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			NoError = 0,
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			UnsupportedShaders = 1,
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			NestedMasks = 2,
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			TightPackedSprite = 4,
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			AlphaSplitSprite = 8,
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			UnsupportedImageType = 0x10,
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			UnreadableTexture = 0x20,
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			UnreadableRenderTexture = 0x40
		}

		[Cpp2IlInjected.Token(Token = "0x2000105")]
		private struct SourceParameters
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			public Image image;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			public Sprite sprite;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			public BorderMode spriteBorderMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000524")]
			public float spritePixelsPerUnit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public Texture texture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public Rect textureUVRect;
		}

		[Cpp2IlInjected.Token(Token = "0x2000106")]
		private class MaterialReplacerImpl : IMaterialReplacer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			private readonly SoftMask _owner;

			[Cpp2IlInjected.Token(Token = "0x170001B4")]
			public int order
			{
				[Cpp2IlInjected.Token(Token = "0x600075B")]
				[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
			public MaterialReplacerImpl(SoftMask owner)
			{
				_owner = owner;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x10E7060", Offset = "0x10E5A60", VA = "0x1810E7060", Slot = "5")]
			public Material Replace(Material original)
			{
				//Discarded unreachable code: IL_0058
				//IL_0009: Expected O, but got I4
				int num = 0;
				if (!(original == (UnityEngine.Object)num) && !original.HasDefaultUIShader())
				{
					if (!original.HasDefaultETC1UIShader())
					{
						if (!original.SupportsSoftMask())
						{
							int num2 = 0;
						}
						return new Material(original);
					}
					Shader defaultETC1Shader = _owner._defaultETC1Shader;
					return Replace(original, defaultETC1Shader);
				}
				Shader defaultShader = _owner._defaultShader;
				return Replace(original, defaultShader);
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x10E7180", Offset = "0x10E5B80", VA = "0x1810E7180")]
			private static Material Replace(Material original, Shader defaultReplacementShader)
			{
				//IL_0016: Expected O, but got I4
				if ((bool)defaultReplacementShader)
				{
					Material material = new Material(defaultReplacementShader);
				}
				if (!(UnityEngine.Object)0 || (bool)original)
				{
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000107")]
		private static class Mathr
		{
			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0x10E75F0", Offset = "0x10E5FF0", VA = "0x1810E75F0")]
			public unsafe static Vector4 ToVector(Rect r)
			{
				//IL_0009: Expected F4, but got I4
				//IL_0004: Expected native int or pointer, but got O
				int num = 0;
				((Rect*)(IntPtr)r)->m_XMin = num;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x10E7350", Offset = "0x10E5D50", VA = "0x1810E7350")]
			public unsafe static Vector4 Div(Vector4 v, Vector2 s)
			{
				//IL_0009: Expected F4, but got I4
				//IL_0004: Expected native int or pointer, but got O
				int num = 0;
				((Vector4*)(IntPtr)v)->x = num;
				return v;
			}

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0x10E73B0", Offset = "0x10E5DB0", VA = "0x1810E73B0")]
			public static Vector2 Div(Vector2 v, Vector2 s)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x10E74D0", Offset = "0x10E5ED0", VA = "0x1810E74D0")]
			public unsafe static Vector4 Mul(Vector4 v, Vector2 s)
			{
				//IL_0009: Expected F4, but got I4
				//IL_0004: Expected native int or pointer, but got O
				int num = 0;
				((Vector4*)(IntPtr)v)->x = num;
				return v;
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0x10E75D0", Offset = "0x10E5FD0", VA = "0x1810E75D0")]
			public static Vector2 Size(Vector4 r)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x10E7470", Offset = "0x10E5E70", VA = "0x1810E7470")]
			public unsafe static Vector4 Move(Vector4 v, Vector2 o)
			{
				//IL_0009: Expected F4, but got I4
				//IL_0004: Expected native int or pointer, but got O
				int num = 0;
				((Vector4*)(IntPtr)v)->x = num;
				return v;
			}

			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(RVA = "0x10E72F0", Offset = "0x10E5CF0", VA = "0x1810E72F0")]
			public unsafe static Vector4 BorderOf(Vector4 outer, Vector4 inner)
			{
				//IL_0010: Expected F4, but got I4
				//IL_000b: Expected native int or pointer, but got O
				float w = inner.w;
				int num = 0;
				((Vector4*)(IntPtr)outer)->x = num;
				return outer;
			}

			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x10E7290", Offset = "0x10E5C90", VA = "0x1810E7290")]
			public unsafe static Vector4 ApplyBorder(Vector4 v, Vector4 b)
			{
				//IL_0010: Expected F4, but got I4
				//IL_000b: Expected native int or pointer, but got O
				float w = b.w;
				int num = 0;
				((Vector4*)(IntPtr)v)->x = num;
				return v;
			}

			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(RVA = "0x10E7450", Offset = "0x10E5E50", VA = "0x1810E7450")]
			public static Vector2 Min(Vector4 r)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(RVA = "0x10E7430", Offset = "0x10E5E30", VA = "0x1810E7430")]
			public static Vector2 Max(Vector4 r)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(RVA = "0x10E7530", Offset = "0x10E5F30", VA = "0x1810E7530")]
			public static Vector2 Remap(Vector2 c, Vector4 from, Vector4 to)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(RVA = "0x10E73F0", Offset = "0x10E5DF0", VA = "0x1810E73F0")]
			public static bool Inside(Vector2 v, Vector4 r)
			{
				float z = r.z;
				float w = r.w;
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000108")]
		private struct MaterialParameters
		{
			[Cpp2IlInjected.Token(Token = "0x2000109")]
			public enum SampleMaskResult
			{
				[Cpp2IlInjected.Token(Token = "0x4000534")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000535")]
				NonReadable,
				[Cpp2IlInjected.Token(Token = "0x4000536")]
				NonTexture2D
			}

			[Cpp2IlInjected.Token(Token = "0x200010A")]
			private static class Ids
			{
				[Cpp2IlInjected.Token(Token = "0x4000537")]
				public static readonly int SoftMask;

				[Cpp2IlInjected.Token(Token = "0x4000538")]
				public static readonly int SoftMask_Rect;

				[Cpp2IlInjected.Token(Token = "0x4000539")]
				public static readonly int SoftMask_UVRect;

				[Cpp2IlInjected.Token(Token = "0x400053A")]
				public static readonly int SoftMask_ChannelWeights;

				[Cpp2IlInjected.Token(Token = "0x400053B")]
				public static readonly int SoftMask_WorldToMask;

				[Cpp2IlInjected.Token(Token = "0x400053C")]
				public static readonly int SoftMask_BorderRect;

				[Cpp2IlInjected.Token(Token = "0x400053D")]
				public static readonly int SoftMask_UVBorderRect;

				[Cpp2IlInjected.Token(Token = "0x400053E")]
				public static readonly int SoftMask_TileRepeat;

				[Cpp2IlInjected.Token(Token = "0x400053F")]
				public static readonly int SoftMask_InvertMask;

				[Cpp2IlInjected.Token(Token = "0x4000540")]
				public static readonly int SoftMask_InvertOutsides;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public Vector4 maskRect;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			public Vector4 maskBorder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			public Vector4 maskRectUV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			public Vector4 maskBorderUV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public Vector2 tileRepeat;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public Color maskChannelWeights;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public Matrix4x4 worldToMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public Texture texture;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public BorderMode borderMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public bool invertMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			public bool invertOutsides;

			[Cpp2IlInjected.Token(Token = "0x170001B5")]
			public Texture activeTexture
			{
				[Cpp2IlInjected.Token(Token = "0x600076A")]
				[Cpp2IlInjected.Address(RVA = "0x10E6FE0", Offset = "0x10E59E0", VA = "0x1810E6FE0")]
				get
				{
					if ((bool)texture)
					{
						return texture;
					}
					int num = 0;
					Texture2D whiteTexture = Texture2D.whiteTexture;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x10E6DF0", Offset = "0x10E57F0", VA = "0x1810E6DF0")]
			public SampleMaskResult SampleMask(Vector2 localPos, out float mask)
			{
				//IL_0009: Expected F4, but got I4
				//IL_001a: Expected O, but got I4
				//IL_0038: Expected I4, but got I8
				//IL_0038: Expected O, but got I4
				//IL_0046: Expected O, but got I4
				//IL_004f: Expected O, but got I4
				int num = 0;
				mask.m_value = num;
				if ((object)texture != null)
				{
				}
				int num2 = 0;
				if ((bool)(UnityEngine.Object)num)
				{
					BorderMode borderMode = this.borderMode;
					if (borderMode != 0)
					{
						if (borderMode != 0)
						{
							if (borderMode != BorderMode.Sliced)
							{
								goto IL_0048;
							}
							ulong num3 = default(ulong);
							Vector2 vector = MapBorder((Vector2)num2, (byte)num3 != 0);
						}
						int repeat = 0;
						Vector2 vector2 = MapBorder((Vector2)num2, (byte)repeat != 0);
					}
					goto IL_0048;
				}
				goto IL_0059;
				IL_0059:
				throw new NullReferenceException();
				IL_0048:
				Vector2 vector3 = MapSimple((Vector2)num2);
				Color color = maskChannelWeights;
				goto IL_0059;
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x10E66E0", Offset = "0x10E50E0", VA = "0x1810E66E0")]
			public void Apply(Material mat)
			{
				//Discarded unreachable code: IL_0113
				int softMask = Ids.SoftMask;
				Texture value = activeTexture;
				mat.SetTextureImpl(softMask, value);
				Vector4 value2 = maskRectUV;
				int softMask_UVRect = Ids.SoftMask_UVRect;
				mat.SetVector(softMask_UVRect, value2);
				Color value3 = maskChannelWeights;
				int softMask_ChannelWeights = Ids.SoftMask_ChannelWeights;
				mat.SetColor(softMask_ChannelWeights, value3);
				Matrix4x4 value4 = worldToMask;
				float m = worldToMask.m01;
				float m2 = worldToMask.m02;
				float m3 = worldToMask.m03;
				int softMask_WorldToMask = Ids.SoftMask_WorldToMask;
				mat.SetMatrix(softMask_WorldToMask, value4);
				int num = 0;
				bool state = borderMode == BorderMode.Simple;
				CoreUtils.SetKeyword(mat, "SOFTMASK_SIMPLE", state);
				bool state2 = borderMode == BorderMode.Sliced;
				CoreUtils.SetKeyword(mat, "SOFTMASK_SLICED", state2);
				bool state3 = borderMode == BorderMode.Tiled;
				CoreUtils.SetKeyword(mat, "SOFTMASK_TILED", state3);
				if (borderMode != 0)
				{
					Vector4 value5 = maskBorder;
					int softMask_BorderRect = Ids.SoftMask_BorderRect;
					mat.SetVector(softMask_BorderRect, value5);
					Vector4 value6 = maskBorderUV;
					int softMask_UVBorderRect = Ids.SoftMask_UVBorderRect;
					mat.SetVector(softMask_UVBorderRect, value6);
					if (borderMode != BorderMode.Tiled)
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x10E6F90", Offset = "0x10E5990", VA = "0x1810E6F90")]
			private Vector2 XY2UV(Vector2 localPos)
			{
				BorderMode borderMode = this.borderMode;
				if (borderMode != 0)
				{
					switch (borderMode)
					{
					case BorderMode.Sliced:
					{
						Vector2 result2 = default(Vector2);
						return result2;
					}
					case BorderMode.Simple:
					{
						Vector2 result = default(Vector2);
						return result;
					}
					}
				}
				Vector2 result3 = default(Vector2);
				return result3;
			}

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x10E6CF0", Offset = "0x10E56F0", VA = "0x1810E6CF0")]
			private Vector2 MapSimple(Vector2 localPos)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x10E6BA0", Offset = "0x10E55A0", VA = "0x1810E6BA0")]
			private Vector2 MapBorder(Vector2 localPos, bool repeat)
			{
				do
				{
					float z = maskBorder.z;
					Vector4 vector = maskRectUV;
					Vector4 vector2 = maskBorderUV;
					float z2 = maskBorderUV.z;
					float z3 = maskRectUV.z;
					if (repeat)
					{
					}
					float w = maskBorder.w;
					float y = maskRectUV.y;
					float y2 = maskBorderUV.y;
					float w2 = maskBorderUV.w;
					float w3 = maskRectUV.w;
				}
				while (!repeat);
				float y3 = tileRepeat.y;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x10E6B40", Offset = "0x10E5540", VA = "0x1810E6B40")]
			private float Inset(float v, float x1, float x2, float u1, float u2, float repeat = 1f)
			{
				float result = default(float);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x10E6A60", Offset = "0x10E5460", VA = "0x1810E6A60")]
			private float Inset(float v, float x1, float x2, float x3, float x4, float u1, float u2, float u3, float u4, float repeat = 1f)
			{
				if (!(x2 > v))
				{
				}
				float result = default(float);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x10E6A30", Offset = "0x10E5430", VA = "0x1810E6A30")]
			private float Frac(float v)
			{
				return v;
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x10E6D90", Offset = "0x10E5790", VA = "0x1810E6D90")]
			private float MaskValue(Color mask)
			{
				Color color = maskChannelWeights;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010B")]
		private struct Diagnostics
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			private SoftMask _softMask;

			[Cpp2IlInjected.Token(Token = "0x170001B6")]
			private Image image
			{
				[Cpp2IlInjected.Token(Token = "0x6000778")]
				[Cpp2IlInjected.Address(RVA = "0x10E6630", Offset = "0x10E5030", VA = "0x1810E6630")]
				get
				{
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001B7")]
			private Sprite sprite
			{
				[Cpp2IlInjected.Token(Token = "0x6000779")]
				[Cpp2IlInjected.Address(RVA = "0x10E6660", Offset = "0x10E5060", VA = "0x1810E6660")]
				get
				{
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001B8")]
			private Texture texture
			{
				[Cpp2IlInjected.Token(Token = "0x600077A")]
				[Cpp2IlInjected.Address(RVA = "0x10E66A0", Offset = "0x10E50A0", VA = "0x1810E66A0")]
				get
				{
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x6DDCC0", Offset = "0x6DC6C0", VA = "0x1806DDCC0")]
			public Diagnostics(SoftMask softMask)
			{
				_softMask = softMask;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x10E6060", Offset = "0x10E4A60", VA = "0x1810E6060")]
			public Errors PollErrors()
			{
				//Discarded unreachable code: IL_0062
				int num = 0;
				_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
				SoftMask softMask = CS_0024_003C_003E8__locals0.softMask;
				List<SoftMaskable> s_maskables = SoftMask.s_maskables;
				((Component)softMask).GetComponentsInChildren<SoftMaskable>((List<>)(object)s_maskables);
				List<SoftMaskable> s_maskables2 = SoftMask.s_maskables;
				List<SoftMaskable> s_maskables3 = SoftMask.s_maskables;
				Func<SoftMaskable, bool> cpp2il__autoParamName__idx_ = (Func<SoftMaskable, bool>)(object)(Func<T, TResult>)((SoftMaskable m) => default(bool));
				bool flag = ((IEnumerable<>)s_maskables3).Any<SoftMaskable>((Func<, >)(object)cpp2il__autoParamName__idx_);
				int num2 = 0;
				bool flag2 = default(bool);
				if (flag2)
				{
				}
				bool flag3 = default(bool);
				if (flag3)
				{
					bool flag4 = default(bool);
					if (flag4)
					{
					}
					Texture2D texture2D = default(Texture2D);
					if (!texture2D)
					{
					}
				}
				Errors result = default(Errors);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x10E5DE0", Offset = "0x10E47E0", VA = "0x1810E5DE0")]
			public static Errors CheckSprite(Sprite sprite)
			{
				int num = 0;
				if ((bool)sprite)
				{
					if (sprite.packed)
					{
						int packingMode = sprite.GetPackingMode();
					}
					if (!sprite.associatedAlphaSplitTexture)
					{
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x10E6390", Offset = "0x10E4D90", VA = "0x1810E6390")]
			private bool ThereAreNestedMasks()
			{
				//Discarded unreachable code: IL_008d, IL_0093, IL_0099
				int num = 0;
				_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
				List<SoftMask> s_masks = SoftMask.s_masks;
				SoftMask softMask = CS_0024_003C_003E8__locals0.softMask;
				List<SoftMask> s_masks2 = SoftMask.s_masks;
				int num2 = 0;
				((Component)softMask).GetComponentsInChildren<SoftMask>((byte)num2 != 0, (List<>)(object)s_masks2);
				List<SoftMask> s_masks3 = SoftMask.s_masks;
				Func<SoftMask, bool> cpp2il__autoParamName__idx_ = (Func<SoftMask, bool>)(object)(Func<T, TResult>)((SoftMask x) => default(bool));
				bool result = ((IEnumerable<>)s_masks3).Any<SoftMask>((Func<, >)(object)cpp2il__autoParamName__idx_);
				SoftMask softMask2 = CS_0024_003C_003E8__locals0.softMask;
				List<SoftMask> s_masks4 = SoftMask.s_masks;
				int num3 = 0;
				((Component)softMask2).GetComponentsInChildren<SoftMask>((byte)num3 != 0, (List<>)(object)s_masks4);
				List<SoftMask> s_masks5 = SoftMask.s_masks;
				Func<SoftMask, bool> cpp2il__autoParamName__idx_2 = (Func<SoftMask, bool>)(object)(Func<T, TResult>)((SoftMask x) => default(bool));
				bool flag = ((IEnumerable<>)s_masks5).Any<SoftMask>((Func<, >)(object)cpp2il__autoParamName__idx_2);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x10E5CB0", Offset = "0x10E46B0", VA = "0x1810E5CB0")]
			private Errors CheckImage()
			{
				int num = 0;
				bool flag = default(bool);
				if ((object)typeof(SoftMask).TypeHandle != null && flag)
				{
					SoftMask softMask = _softMask;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0x10E5EC0", Offset = "0x10E48C0", VA = "0x1810E5EC0")]
			private Errors CheckTexture()
			{
				//IL_0018: Expected O, but got I4
				//IL_0021: Expected O, but got I4
				int num = 0;
				bool flag = default(bool);
				if (flag)
				{
					SourceParameters sourceParameters = default(SourceParameters);
					BorderMode spriteBorderMode = sourceParameters.spriteBorderMode;
					bool flag2 = default(bool);
					if (flag2 && (bool)(UnityEngine.Object)num && !IsReadable((Texture2D)num))
					{
						return Errors.UnreadableTexture;
					}
				}
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x10E5B30", Offset = "0x10E4530", VA = "0x1810E5B30")]
			private static bool AreCompeting(SoftMask softMask, SoftMask other)
			{
				if (softMask.isMaskingEnabled && softMask != other && other.isMaskingEnabled)
				{
					Canvas rootCanvas = softMask.canvas.rootCanvas;
					Canvas rootCanvas2 = other.canvas.rootCanvas;
					if (rootCanvas == rootCanvas2)
					{
						SoftMask softMask2 = SelectChild(softMask, other);
						Canvas canvas = default(Canvas);
						return !canvas.overrideSorting;
					}
				}
				int num = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x20B8780", Offset = "0x20B7180", VA = "0x1820B8780")]
			private static T SelectChild<T>(T first, T second) where T : Component
			{
				//Discarded unreachable code: IL_000a
				Transform transform = default(Transform);
				Transform parent = default(Transform);
				bool flag = transform.IsChildOf(parent);
				return first;
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x10E6020", Offset = "0x10E4A20", VA = "0x1810E6020")]
			private static bool IsReadable(Texture2D texture)
			{
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		private struct WarningReporter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private UnityEngine.Object _owner;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			private Texture _lastReadTexture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private Sprite _lastUsedSprite;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			private Sprite _lastUsedImageSprite;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			private Image.Type _lastUsedImageType;

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x10F8CD0", Offset = "0x10F76D0", VA = "0x1810F8CD0")]
			public WarningReporter(UnityEngine.Object owner)
			{
				//IL_0010: Expected O, but got I4
				//IL_0017: Expected O, but got I4
				//IL_001e: Expected O, but got I4
				_owner = owner;
				int num = 0;
				_lastReadTexture = (Texture)num;
				_lastUsedSprite = (Sprite)num;
				_lastUsedImageSprite = (Sprite)num;
				_lastUsedImageType = (Image.Type)num;
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x10F8A70", Offset = "0x10F7470", VA = "0x1810F8A70")]
			public void TextureRead(Texture texture, MaterialParameters.SampleMaskResult sampleResult)
			{
				object[] array2;
				string text = default(string);
				while (true)
				{
					if (_lastReadTexture == texture)
					{
						return;
					}
					_lastReadTexture = texture;
					if (sampleResult == MaterialParameters.SampleMaskResult.NonReadable)
					{
						object[] array = new object[1];
						string name = texture.name;
						if (name == null || name != null)
						{
							array[0] = name;
							return;
						}
					}
					else
					{
						array2 = new object[1];
						if (text == null || text != null)
						{
							break;
						}
					}
				}
				array2[0] = text;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x10F8930", Offset = "0x10F7330", VA = "0x1810F8930")]
			public void SpriteUsed(Sprite sprite, Errors errors)
			{
				if (!(_lastUsedSprite == sprite))
				{
					_lastUsedSprite = sprite;
					if (errors != Errors.TightPackedSprite)
					{
					}
					if (errors == Errors.AlphaSplitSprite)
					{
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x10F86C0", Offset = "0x10F70C0", VA = "0x1810F86C0")]
			public void ImageUsed(Image image)
			{
				//IL_009b: Expected O, but got I4
				bool flag = default(bool);
				while ((bool)image)
				{
					Sprite lastUsedImageSprite = _lastUsedImageSprite;
					Sprite sprite = image.m_Sprite;
					if (lastUsedImageSprite == sprite)
					{
						Image.Type type = image.m_Type;
						if (_lastUsedImageType == type)
						{
							return;
						}
					}
					Sprite sprite2 = (_lastUsedImageSprite = image.m_Sprite);
					Image.Type type2 = (_lastUsedImageType = image.m_Type);
					if ((bool)image)
					{
						int type3 = (int)image.m_Type;
						if (!flag)
						{
							object[] array = new object[1];
							Image.Type type4 = image.m_Type;
							if (array == null || array != null)
							{
								array[0] = array;
								return;
							}
							continue;
						}
						return;
					}
					return;
				}
				int num = 0;
				_lastUsedImageSprite = (Sprite)num;
				_lastUsedImageType = (Image.Type)num;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		[SerializeField]
		private Shader _defaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		[SerializeField]
		private Shader _defaultETC1Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[SerializeField]
		private MaskSource _source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		[SerializeField]
		private RectTransform _separateMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		[SerializeField]
		private Sprite _sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		[SerializeField]
		private BorderMode _spriteBorderMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		[SerializeField]
		private float _spritePixelsPerUnitMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		[SerializeField]
		private Texture _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		[SerializeField]
		private Rect _textureUVRect = DefaultUVRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		[SerializeField]
		private Color _channelWeights = MaskChannel.alpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[SerializeField]
		private float _raycastThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		[SerializeField]
		private bool _invertMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x75")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		[SerializeField]
		private bool _invertOutsides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private MaterialReplacements _materials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private MaterialParameters _parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private WarningReporter _warningReporter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private Rect _lastMaskRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private bool _maskingWasEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private bool _destroyed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x162")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private bool _dirty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private RectTransform _maskTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private Graphic _graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private Canvas _canvas;

		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private static readonly Rect DefaultUVRect = (Rect)0;

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private const float DefaultPixelsPerUnit = 100f;

		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private static readonly List<SoftMask> s_masks;

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private static readonly List<SoftMaskable> s_maskables;

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public Shader defaultShader
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _defaultShader;
			}
			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0x15FC840", Offset = "0x15FB240", VA = "0x1815FC840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public Shader defaultETC1Shader
		{
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _defaultETC1Shader;
			}
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0x15FC810", Offset = "0x15FB210", VA = "0x1815FC810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public MaskSource source
		{
			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return _source;
			}
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x15FCAB0", Offset = "0x15FB4B0", VA = "0x1815FCAB0")]
			set
			{
				if (_source == value)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public RectTransform separateMask
		{
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _separateMask;
			}
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x15FC9E0", Offset = "0x15FB3E0", VA = "0x1815FC9E0")]
			set
			{
				//IL_0018: Expected O, but got I4
				//IL_001f: Expected O, but got I4
				if (_separateMask != value)
				{
					int num = 0;
					_graphic = (Graphic)num;
					_maskTransform = (RectTransform)num;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public Sprite sprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _sprite;
			}
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x15FCC10", Offset = "0x15FB610", VA = "0x1815FCC10")]
			set
			{
				if (!(_sprite != value))
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public BorderMode spriteBorderMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x70BFB0", Offset = "0x70A9B0", VA = "0x18070BFB0")]
			get
			{
				return _spriteBorderMode;
			}
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x15FCB10", Offset = "0x15FB510", VA = "0x1815FCB10")]
			set
			{
				if (_spriteBorderMode == value)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public float spritePixelsPerUnitMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xD392E0", Offset = "0xD37CE0", VA = "0x180D392E0")]
			get
			{
				return _spritePixelsPerUnitMultiplier;
			}
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x15FCB70", Offset = "0x15FB570", VA = "0x1815FCB70")]
			set
			{
				float num = _spritePixelsPerUnitMultiplier;
				num = value;
				float num2 = Mathf.Max(num, 0.01f);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public Texture2D texture
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0x15FC730", Offset = "0x15FB130", VA = "0x1815FC730")]
			get
			{
				while (true)
				{
					Texture texture = _texture;
					int num = 0;
					if ((object)texture != null)
					{
						/*Error: Could not find block for branch target IL_000d*/;
					}
				}
			}
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0x15FCD50", Offset = "0x15FB750", VA = "0x1815FCD50")]
			set
			{
				if (!(_texture != value))
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		public RenderTexture renderTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0x15FC6B0", Offset = "0x15FB0B0", VA = "0x1815FC6B0")]
			get
			{
				if ((object)_texture == null)
				{
					int num = 0;
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x15FC930", Offset = "0x15FB330", VA = "0x1815FC930")]
			set
			{
				if (!(_texture != value))
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public Rect textureUVRect
		{
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x1024680", Offset = "0x1023080", VA = "0x181024680")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x15FCCC0", Offset = "0x15FB6C0", VA = "0x1815FCCC0")]
			set
			{
				Rect rect = _textureUVRect;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public Color channelWeights
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xCC66A0", Offset = "0xCC50A0", VA = "0x180CC66A0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x15FC780", Offset = "0x15FB180", VA = "0x1815FC780")]
			set
			{
				Color color = _channelWeights;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public float raycastThreshold
		{
			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0xBBBA50", Offset = "0xBBA450", VA = "0x180BBBA50")]
			get
			{
				return _raycastThreshold;
			}
			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0xBBBA60", Offset = "0xBBA460", VA = "0x180BBBA60")]
			set
			{
				_raycastThreshold = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public bool invertMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0xA8DE10", Offset = "0xA8C810", VA = "0x180A8DE10")]
			get
			{
				return _invertMask;
			}
			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x15FC870", Offset = "0x15FB270", VA = "0x1815FC870")]
			set
			{
				if (_invertMask == value)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public bool invertOutsides
		{
			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x15FC510", Offset = "0x15FAF10", VA = "0x1815FC510")]
			get
			{
				return _invertOutsides;
			}
			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x15FC8D0", Offset = "0x15FB2D0", VA = "0x1815FC8D0")]
			set
			{
				if (_invertOutsides == value)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public bool isUsingRaycastFiltering
		{
			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x15FC5B0", Offset = "0x15FAFB0", VA = "0x1815FC5B0")]
			get
			{
				float num = _raycastThreshold;
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public bool isMaskingEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x15FC530", Offset = "0x15FAF30", VA = "0x1815FC530", Slot = "18")]
			get
			{
				bool flag = base.isActiveAndEnabled;
				if (!flag)
				{
					return flag;
				}
				return canvas;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		private RectTransform maskTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x15FC5C0", Offset = "0x15FAFC0", VA = "0x1815FC5C0")]
			get
			{
				bool flag = default(bool);
				do
				{
					if (flag)
					{
					}
				}
				while (!_separateMask);
				return _maskTransform = _separateMask.GetComponent<RectTransform>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		private Canvas canvas
		{
			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x15FC3C0", Offset = "0x15FADC0", VA = "0x1815FC3C0")]
			get
			{
				//Discarded unreachable code: IL_0044
				bool flag = default(bool);
				if (flag)
				{
				}
				int includeInactive = 0;
				Canvas[] componentsInParent = GetComponentsInParent<Canvas>((byte)includeInactive != 0);
				int num = 0;
				int length = componentsInParent.Length;
				Canvas result = default(Canvas);
				if (num < length)
				{
					if (!componentsInParent[num].isActiveAndEnabled)
					{
						num++;
					}
					result = componentsInParent[num];
				}
				_canvas = result;
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		private bool isBasedOnGraphic
		{
			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x15FC520", Offset = "0x15FAF20", VA = "0x1815FC520")]
			get
			{
				return _source == MaskSource.Graphic;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		bool ISoftMask.isAlive
		{
			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x15FB780", Offset = "0x15FA180", VA = "0x1815FB780", Slot = "17")]
			get
			{
				bool flag = this;
				if (!flag)
				{
					return flag;
				}
				return !_destroyed;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x15FC140", Offset = "0x15FAB40", VA = "0x1815FC140")]
		public SoftMask()
		{
			//IL_0055: Expected O, but got I4
			//IL_005d: Expected O, but got I4
			MaterialReplacerImpl materialReplacerImpl = new MaterialReplacerImpl(this);
			Action<Material> action = (Action<Material>)(object)(Action<T>)delegate
			{
			};
			MaterialReplacerChain materialReplacerChain = default(MaterialReplacerChain);
			MaterialReplacements materialReplacements = (_materials = new MaterialReplacements((IMaterialReplacer)materialReplacerChain, (Action<>)(object)action));
			int num = 0;
			int num2 = 0;
			_warningReporter = (WarningReporter)num;
			_warningReporter = (WarningReporter)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x15FB530", Offset = "0x15F9F30", VA = "0x1815FB530")]
		public Errors PollErrors()
		{
			Errors result = default(Errors);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x15FAA10", Offset = "0x15F9410", VA = "0x1815FAA10", Slot = "22")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera cam)
		{
			//IL_003c: Invalid comparison between F4 and I4
			int num = 0;
			RectTransform rectTransform = maskTransform;
			bool flag = default(bool);
			if (flag)
			{
				Vector4 zero = Vector4.zero;
				RectTransform rectTransform2 = maskTransform;
				bool flag2 = default(bool);
				if (flag2 && (bool)_parameters.texture && !(_raycastThreshold <= (float)num))
				{
					MaterialParameters.SampleMaskResult sampleMaskResult = default(MaterialParameters.SampleMaskResult);
					int num2 = (int)sampleMaskResult;
					if (num2 == 0 && (_invertMask ? 1 : 0) == num2)
					{
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x15FBA60", Offset = "0x15FA460", VA = "0x1815FBA60", Slot = "6")]
		protected override void Start()
		{
			((object)this)._002Ector();
			WarnIfDefaultShaderIsNotSet();
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x15FB340", Offset = "0x15F9D40", VA = "0x1815FB340", Slot = "5")]
		protected override void OnEnable()
		{
			((object)this)._002Ector();
			int num = 0;
			CanvasUpdateRegistry canvasUpdateRegistry = Touch(CanvasUpdateRegistry.instance);
			Canvas.willRenderCanvases += OnWillRenderCanvases;
			Transform root = base.transform;
			SpawnMaskablesInChildren(root);
			FindGraphic();
			if (isMaskingEnabled)
			{
				UpdateMaskParameters();
			}
			NotifyChildrenThatMaskMightChanged();
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x15FB190", Offset = "0x15F9B90", VA = "0x1815FB190", Slot = "7")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_0076
			//IL_0064: Expected O, but got I8
			((object)this)._002Ector();
			Canvas.willRenderCanvases -= OnWillRenderCanvases;
			if ((bool)_graphic)
			{
				Graphic graphic = _graphic;
				UnityAction action = OnGraphicDirty;
				graphic.UnregisterDirtyVerticesCallback(action);
				Graphic graphic2 = _graphic;
				UnityAction action2 = OnGraphicDirty;
				graphic2.UnregisterDirtyMaterialCallback(action2);
				_graphic = (Graphic)0;
			}
			NotifyChildrenThatMaskMightChanged();
			_materials.DestroyAllAndClear();
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x15FB140", Offset = "0x15F9B40", VA = "0x1815FB140", Slot = "8")]
		protected override void OnDestroy()
		{
			((object)this)._002Ector();
			_destroyed = true;
			NotifyChildrenThatMaskMightChanged();
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x15FAC60", Offset = "0x15F9660", VA = "0x1815FAC60", Slot = "23")]
		protected virtual void LateUpdate()
		{
			//Discarded unreachable code: IL_005b
			bool flag = isMaskingEnabled;
			if (flag)
			{
				if (_maskingWasEnabled != flag)
				{
					Transform root = base.transform;
					SpawnMaskablesInChildren(root);
				}
				Graphic graphic = _graphic;
				FindGraphic();
				Rect lastMaskRect = _lastMaskRect;
				RectTransform rectTransform = maskTransform;
				bool flag2 = default(bool);
				if (flag2 || (object)_graphic != graphic)
				{
					_dirty = true;
				}
			}
			_maskingWasEnabled = flag;
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x15FB170", Offset = "0x15F9B70", VA = "0x1815FB170", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
			((object)this)._002Ector();
			_dirty = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x15FB170", Offset = "0x15F9B70", VA = "0x1815FB170", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
			((object)this)._002Ector();
			_dirty = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x15F9F90", Offset = "0x15F8990", VA = "0x1815F9F90")]
		private static float ClampPixelsPerUnitMultiplier(float value)
		{
			return Mathf.Max(value, 0.01f);
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x15FB4C0", Offset = "0x15F9EC0", VA = "0x1815FB4C0", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
			((object)this)._002Ector();
			_dirty = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x15FB100", Offset = "0x15F9B00", VA = "0x1815FB100", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
			((object)this)._002Ector();
			_dirty = true;
			NotifyChildrenThatMaskMightChanged();
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x15FB490", Offset = "0x15F9E90", VA = "0x1815FB490")]
		private void OnTransformChildrenChanged()
		{
			Transform root = base.transform;
			SpawnMaskablesInChildren(root);
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x15FBA80", Offset = "0x15FA480", VA = "0x1815FBA80")]
		private void SubscribeOnWillRenderCanvases()
		{
			int num = 0;
			CanvasUpdateRegistry canvasUpdateRegistry = Touch(CanvasUpdateRegistry.instance);
			Canvas.willRenderCanvases += OnWillRenderCanvases;
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x15FBB80", Offset = "0x15FA580", VA = "0x1815FBB80")]
		private void UnsubscribeFromWillRenderCanvases()
		{
			Canvas.willRenderCanvases -= OnWillRenderCanvases;
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x15FB500", Offset = "0x15F9F00", VA = "0x1815FB500")]
		private void OnWillRenderCanvases()
		{
			if (isMaskingEnabled)
			{
				UpdateMaskParameters();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5A0", Offset = "0x7EDFA0", VA = "0x1807EF5A0")]
		private static T Touch<T>(T obj)
		{
			return obj;
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x15FB730", Offset = "0x15FA130", VA = "0x1815FB730", Slot = "19")]
		Material ISoftMask.GetReplacement(Material original)
		{
			//Discarded unreachable code: IL_000d
			return _materials.Get(original);
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x15FB750", Offset = "0x15FA150", VA = "0x1815FB750", Slot = "20")]
		void ISoftMask.ReleaseReplacement(Material replacement)
		{
			//Discarded unreachable code: IL_000d
			_materials.Release(replacement);
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x15FB770", Offset = "0x15FA170", VA = "0x1815FB770", Slot = "21")]
		void ISoftMask.UpdateTransformChildren(Transform transform)
		{
			SpawnMaskablesInChildren(transform);
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x15FB480", Offset = "0x15F9E80", VA = "0x1815FB480")]
		private void OnGraphicDirty()
		{
			if (_source == MaskSource.Graphic)
			{
				_dirty = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x15FA4A0", Offset = "0x15F8EA0", VA = "0x1815FA4A0")]
		private void FindGraphic()
		{
			//Discarded unreachable code: IL_0040
			bool flag = default(bool);
			if (!flag && _source == MaskSource.Graphic)
			{
				Graphic graphic = (_graphic = maskTransform.GetComponent<Graphic>());
				bool flag2 = default(bool);
				if (flag2)
				{
					UnityAction unityAction = OnGraphicDirty;
					UnityAction unityAction2 = OnGraphicDirty;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x15FAF10", Offset = "0x15F9910", VA = "0x1815FAF10")]
		private Canvas NearestEnabledCanvas()
		{
			int includeInactive = 0;
			Canvas[] componentsInParent = GetComponentsInParent<Canvas>((byte)includeInactive != 0);
			int num = 0;
			int length = componentsInParent.Length;
			if (num < length)
			{
				if (!componentsInParent[num].isActiveAndEnabled)
				{
					num++;
				}
				return componentsInParent[num];
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x15FBBF0", Offset = "0x15FA5F0", VA = "0x1815FBBF0")]
		private void UpdateMaskParameters()
		{
			//Discarded unreachable code: IL_0072
			if (_dirty || maskTransform.hasChanged)
			{
				SourceParameters sourceParameters = default(SourceParameters);
				BorderMode borderMode = sourceParameters.spriteBorderMode;
				Rect rect = sourceParameters.textureUVRect;
				Errors errors = default(Errors);
				int num = (int)errors;
				bool flag = default(bool);
				bool flag2 = default(bool);
				if (!flag && !flag2)
				{
					CalculateSolidFill();
				}
				if (num != 0)
				{
					CalculateSolidFill();
				}
				RectTransform rectTransform = maskTransform;
				int num2 = ((rectTransform.hasChanged = false) ? 1 : 0);
				RectTransform rectTransform2 = maskTransform;
				_dirty = false;
			}
			_materials.ApplyAll();
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x15FB7F0", Offset = "0x15FA1F0", VA = "0x1815FB7F0")]
		private void SpawnMaskablesInChildren(Transform root)
		{
			//Discarded unreachable code: IL_0043, IL_0049, IL_004f, IL_0055
			int num = 0;
			List<SoftMaskable> list = s_maskables;
			int childCount = root.childCount;
			if (num < childCount)
			{
				Transform child = root.GetChild(num);
				List<SoftMaskable> list2 = s_maskables;
				((Component)child).GetComponents<SoftMaskable>((List<>)(object)list2);
				List<SoftMaskable> list3 = s_maskables;
				SoftMaskable softMaskable = child.gameObject.AddComponent<SoftMaskable>();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x15FA8E0", Offset = "0x15F92E0", VA = "0x1815FA8E0")]
		private void InvalidateChildren()
		{
			//Discarded unreachable code: IL_0027
			Action<SoftMaskable> _003C_003E9__107_ = _003C_003Ec._003C_003E9__107_0;
			if (_003C_003E9__107_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(SoftMaskable x)
				{
					//Discarded unreachable code: IL_0007
					x.Invalidate();
				};
			}
			this.ForEachChildMaskable((Action<>)(object)_003C_003E9__107_);
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x15FAFE0", Offset = "0x15F99E0", VA = "0x1815FAFE0")]
		private void NotifyChildrenThatMaskMightChanged()
		{
			//Discarded unreachable code: IL_0027
			Action<SoftMaskable> _003C_003E9__108_ = _003C_003Ec._003C_003E9__108_0;
			if (_003C_003E9__108_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(SoftMaskable x)
				{
					//Discarded unreachable code: IL_0007
					x.MaskMightChanged();
				};
			}
			this.ForEachChildMaskable((Action<>)(object)_003C_003E9__108_);
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x15FA630", Offset = "0x15F9030", VA = "0x1815FA630")]
		private void ForEachChildMaskable(Action<SoftMaskable> f)
		{
			//Discarded unreachable code: IL_0048, IL_004e, IL_0054, IL_005a
			int num = 0;
			Transform transform = base.transform;
			List<SoftMaskable> list = s_maskables;
			((Component)transform).GetComponentsInChildren<SoftMaskable>((List<>)(object)list);
			List<SoftMaskable> list2 = s_maskables;
			List<SoftMaskable> list3 = s_maskables;
			List<SoftMaskable> list4 = s_maskables;
			bool flag = default(bool);
			if (flag)
			{
				GameObject gameObject = base.gameObject;
				GameObject gameObject2 = default(GameObject);
				if (!(gameObject2 != gameObject))
				{
				}
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x15FA300", Offset = "0x15F8D00", VA = "0x1815FA300")]
		private void DestroyMaterials()
		{
			//Discarded unreachable code: IL_000c
			_materials.DestroyAllAndClear();
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x15F9FA0", Offset = "0x15F89A0", VA = "0x1815F9FA0")]
		private SourceParameters DeduceSourceParameters()
		{
			//IL_0010: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			//IL_003c: Expected I, but got O
			int num = 0;
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num;
			_defaultETC1Shader = (Shader)num;
			if ((object)typeof(SoftMask).TypeHandle != null)
			{
				if ((object)typeof(SoftMask).TypeHandle != null && (long)typeof(SoftMask).TypeHandle == 1)
				{
					_defaultETC1Shader = (Shader)num;
				}
				((UnityEngine.Object)this).m_CachedPtr = (IntPtr)typeof(SoftMask).TypeHandle;
				bool flag = default(bool);
				if (!flag)
				{
					goto IL_0067;
				}
				Texture2D texture2D = default(Texture2D);
				_defaultShader = (Shader)(object)texture2D;
			}
			int num2 = 0;
			int num3 = 0;
			uint num5 = default(uint);
			if (num2 != 0)
			{
				int num4 = 0;
				if (num2 != 0)
				{
					((UnityEngine.Object)this).m_CachedPtr = (IntPtr)(int)num5;
					bool flag2 = default(bool);
					if (flag2)
					{
					}
					goto IL_0067;
				}
				throw new InvalidCastException();
			}
			goto IL_006f;
			IL_006f:
			int num6 = 0;
			while (num5 == 0)
			{
			}
			int num7 = 0;
			if (num5 != 0)
			{
				_defaultShader = (Shader)typeof(RawImage).TypeHandle;
			}
			throw new InvalidCastException();
			IL_0067:
			Texture2D texture2D2 = default(Texture2D);
			_defaultShader = (Shader)(object)texture2D2;
			goto IL_006f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x15FA8C0", Offset = "0x15F92C0", VA = "0x1815FA8C0")]
		public static BorderMode ImageTypeToBorderMode(Image.Type type)
		{
			if (type != 0)
			{
				switch (type)
				{
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x15FAA00", Offset = "0x15F9400", VA = "0x1815FAA00")]
		public static bool IsImageTypeSupported(Image.Type type)
		{
			if (type <= Image.Type.Sliced)
			{
				return true;
			}
			return type == Image.Type.Tiled;
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x15F9730", Offset = "0x15F8130", VA = "0x1815F9730")]
		private void CalculateMaskParameters()
		{
			SourceParameters sourceParameters = default(SourceParameters);
			BorderMode borderMode = sourceParameters.spriteBorderMode;
			Rect rect = sourceParameters.textureUVRect;
			Errors errors = default(Errors);
			int num = (int)errors;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if ((!flag && !flag2) || num != 0)
			{
				CalculateSolidFill();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x15F9920", Offset = "0x15F8320", VA = "0x1815F9920")]
		private unsafe void CalculateSpriteBased(Sprite sprite, BorderMode borderMode, float spritePixelsPerUnit)
		{
			//Discarded unreachable code: IL_00ad
			//IL_0062: Expected native int or pointer, but got O
			//IL_006e: Expected native int or pointer, but got O
			//IL_009a: Expected O, but got F4
			//IL_0095: Expected native int or pointer, but got O
			//IL_00ac: Expected F4, but got O
			//IL_00a7: Expected native int or pointer, but got O
			FillCommonParameters();
			Vector4 zero = Vector4.zero;
			RectTransform rectTransform = maskTransform;
			if (borderMode != 0)
			{
				float num = SpriteToCanvasScale(spritePixelsPerUnit);
				int num2 = 0;
				float num3 = default(float);
				num = num3;
				float num4 = default(float);
				float num5 = default(float);
				if (!(num4 <= num5) && num4 != num5)
				{
					float num6 = default(float);
					num = num6;
					float num7 = default(float);
					float num8 = num7;
				}
				num2++;
				while (num2 <= 1)
				{
				}
				RectTransform rectTransform2 = maskTransform;
			}
			Texture2D texture2D = sprite.texture;
			((MaterialParameters*)(IntPtr)_parameters)->texture = texture2D;
			((MaterialParameters*)(IntPtr)_parameters)->borderMode = borderMode;
			if (borderMode == BorderMode.Tiled)
			{
				Vector4 maskBorder = _parameters.maskBorder;
				float num9 = SpriteToCanvasScale(spritePixelsPerUnit);
				((MaterialParameters*)(IntPtr)_parameters)->tileRepeat = (Vector2)num9;
				((Vector2*)(IntPtr)_parameters.tileRepeat)->y = (float)maskBorder;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x15F9600", Offset = "0x15F8000", VA = "0x1815F9600")]
		private unsafe static Vector4 AdjustBorders(Vector4 border, Vector4 rect)
		{
			Vector2 vector = Mathr.Size(border);
			int num = 0;
			float num2 = (*(Vector4*)rect)[num];
			float num3 = (*(Vector4*)rect)[2];
			float num4 = default(float);
			if (!(num3 <= num4) && num3 != num4)
			{
				float num5 = default(float);
				num2 = num5;
				float num7 = ((*(Vector4*)rect)[num] = (*(Vector4*)rect)[num]);
				num7 = ((*(Vector4*)rect)[2] = (*(Vector4*)rect)[2]);
			}
			num++;
			while (num <= 1)
			{
			}
			return border;
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x15F9E80", Offset = "0x15F8880", VA = "0x1815F9E80")]
		private unsafe void CalculateTextureBased(Texture texture, Rect uvRect)
		{
			//Discarded unreachable code: IL_002e
			//IL_001a: Expected native int or pointer, but got O
			//IL_002d: Expected I4, but got I8
			//IL_0028: Expected native int or pointer, but got O
			FillCommonParameters();
			Vector4 zero = Vector4.zero;
			RectTransform rectTransform = maskTransform;
			((MaterialParameters*)(IntPtr)_parameters)->texture = texture;
			((MaterialParameters*)(IntPtr)_parameters)->borderMode = BorderMode.Simple;
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x15F98A0", Offset = "0x15F82A0", VA = "0x1815F98A0")]
		private void CalculateSolidFill()
		{
			//IL_0010: Expected O, but got I4
			int num = 0;
			Rect defaultUVRect = DefaultUVRect;
			CalculateTextureBased((Texture)num, defaultUVRect);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x15FA320", Offset = "0x15F8D20", VA = "0x1815FA320")]
		private unsafe void FillCommonParameters()
		{
			//Discarded unreachable code: IL_00db
			//IL_0060: Expected native int or pointer, but got O
			//IL_007b: Expected native int or pointer, but got O
			//IL_0096: Expected native int or pointer, but got O
			//IL_00ab: Expected native int or pointer, but got O
			//IL_00c0: Expected native int or pointer, but got O
			//IL_00d5: Expected native int or pointer, but got O
			RectTransform rectTransform = maskTransform;
			Matrix4x4 matrix4x = default(Matrix4x4);
			float m = matrix4x.m01;
			float m2 = matrix4x.m02;
			float m3 = matrix4x.m03;
			Transform transform = canvas.rootCanvas.transform;
			Matrix4x4 matrix4x2 = default(Matrix4x4);
			float m4 = matrix4x2.m01;
			float m5 = matrix4x2.m02;
			float m6 = matrix4x2.m03;
			Matrix4x4 matrix4x3 = default(Matrix4x4);
			float m7 = matrix4x3.m01;
			((Matrix4x4*)(IntPtr)_parameters.worldToMask)->m01 = m7;
			float m8 = matrix4x3.m02;
			((Matrix4x4*)(IntPtr)_parameters.worldToMask)->m02 = m8;
			float m9 = matrix4x3.m03;
			((Matrix4x4*)(IntPtr)_parameters.worldToMask)->m03 = m9;
			Color maskChannelWeights = _channelWeights;
			((MaterialParameters*)(IntPtr)_parameters)->maskChannelWeights = maskChannelWeights;
			bool flag = _invertMask;
			((MaterialParameters*)(IntPtr)_parameters)->invertMask = flag;
			bool flag2 = _invertOutsides;
			((MaterialParameters*)(IntPtr)_parameters)->invertOutsides = flag2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x15FB9B0", Offset = "0x15FA3B0", VA = "0x1815FB9B0")]
		private float SpriteToCanvasScale(float spritePixelsPerUnit)
		{
			if ((bool)canvas)
			{
				float referencePixelsPerUnit = canvas.referencePixelsPerUnit;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x15FBEC0", Offset = "0x15FA8C0", VA = "0x1815FBEC0")]
		private Matrix4x4 WorldToMask()
		{
			//IL_0059: Expected I, but got F4
			//IL_006a: Expected O, but got F4
			//IL_0072: Expected O, but got F4
			Matrix4x4 matrix4x = default(Matrix4x4);
			float m = matrix4x.m01;
			float m2 = matrix4x.m02;
			float m3 = matrix4x.m03;
			Canvas canvas = default(Canvas);
			Transform transform = canvas.rootCanvas.transform;
			Matrix4x4 matrix4x2 = default(Matrix4x4);
			float m4 = matrix4x2.m01;
			float m5 = matrix4x2.m02;
			float m6 = matrix4x2.m03;
			Matrix4x4 matrix4x3 = default(Matrix4x4);
			float m7 = matrix4x3.m01;
			float m8 = matrix4x3.m02;
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)m7;
			float m9 = matrix4x3.m03;
			_defaultETC1Shader = (Shader)m8;
			_separateMask = (RectTransform)m9;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x15FAD40", Offset = "0x15F9740", VA = "0x1815FAD40")]
		private Vector4 LocalMaskRect(Vector4 border)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x15FADD0", Offset = "0x15F97D0", VA = "0x1815FADD0")]
		private Vector2 MaskRepeat(Sprite sprite, float spritePixelsPerUnit, Vector4 centralPart)
		{
			//Discarded unreachable code: IL_000c
			float num = SpriteToCanvasScale(spritePixelsPerUnit);
			Vector2 result = default(Vector2);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x15FBE10", Offset = "0x15FA810", VA = "0x1815FBE10")]
		private void WarnIfDefaultShaderIsNotSet()
		{
			if (!_defaultShader)
			{
				Debug.LogWarning("SoftMask may not work because its defaultShader is not set", this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x1B242A0", Offset = "0x1B22CA0", VA = "0x181B242A0")]
		private void Set<T>(ref T field, T value)
		{
			_dirty = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x15FB570", Offset = "0x15F9F70", VA = "0x1815FB570")]
		private void SetShader(ref Shader field, Shader value, bool warnIfNotSet = true)
		{
			//Discarded unreachable code: IL_0040
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			if (warnIfNotSet)
			{
				WarnIfDefaultShaderIsNotSet();
			}
			_materials.DestroyAllAndClear();
			Action<SoftMaskable> action = default(Action<SoftMaskable>);
			if (_003C_003Ec._003C_003E9__107_0 == null)
			{
				action = (Action<SoftMaskable>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(SoftMaskable x)
				{
					//Discarded unreachable code: IL_0007
					x.Invalidate();
				});
			}
			this.ForEachChildMaskable((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x15FC020", Offset = "0x15FAA20", VA = "0x1815FC020")]
		static SoftMask()
		{
			//IL_0006: Expected O, but got I4
			DefaultUVRect = (Rect)new List<T>();
			DefaultUVRect = (Rect)new List<T>();
		}
	}
}
