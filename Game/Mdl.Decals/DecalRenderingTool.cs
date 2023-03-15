using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Mdl.Decals
{
	[Cpp2IlInjected.Token(Token = "0x2000833")]
	public class DecalRenderingTool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002DC8")]
		public Shader decalShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002DC9")]
		public float projectorDefaultSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002DCA")]
		public int maxDecals = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002DCB")]
		public float minSize = 0.03f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002DCC")]
		public float maxSize = 0.3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002DCD")]
		public Texture2D emptyTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4002DCF")]
		private bool _mirrorMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4002DD0")]
		private bool _cutoutMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
		[Cpp2IlInjected.Token(Token = "0x4002DD1")]
		private bool _seeThroughMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002DD2")]
		private bool _UVSpaceMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4002DD3")]
		private bool _repeatMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E")]
		[Cpp2IlInjected.Token(Token = "0x4002DD4")]
		private bool _flipped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F")]
		[Cpp2IlInjected.Token(Token = "0x4002DD5")]
		private bool _liveEditingEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002DD6")]
		private bool _worldSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002DD7")]
		private ProjectorMode _mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002DD8")]
		private ProjectorResolution _res;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4002DD9")]
		private Color _color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4002DDA")]
		private UnityEngine.Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002DDB")]
		private UnityEngine.Vector3 mirrorPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4002DDC")]
		private Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4002DDD")]
		private Quaternion mirrorRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4002DDE")]
		private float size;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002DE0")]
		private RenderTexture[] _renderTextures;

		[Cpp2IlInjected.Token(Token = "0x4002DE1")]
		private const int STATIC_RENDER = 0;

		[Cpp2IlInjected.Token(Token = "0x4002DE2")]
		private const int LIVE_RENDER = 1;

		[Cpp2IlInjected.Token(Token = "0x4002DE3")]
		private const int DEPTH_MAP = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002DE4")]
		private Item _currentDecal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002DE5")]
		private Dictionary<Item, Texture2D> _textureCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002DE6")]
		private Renderer rendererInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002DE7")]
		private Material mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002DE8")]
		private RenderBufferLoadAction renderBufferLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4002DE9")]
		private RenderBufferStoreAction renderBufferStore;

		[Cpp2IlInjected.Token(Token = "0x17000534")]
		public Texture2D CurrentTexture
		{
			[Cpp2IlInjected.Token(Token = "0x60024D0")]
			[Cpp2IlInjected.Address(RVA = "0x16214B0", Offset = "0x161FEB0", VA = "0x1816214B0")]
			get
			{
				Dictionary<Item, Texture2D> textureCache = _textureCache;
				bool flag = default(bool);
				if (!flag)
				{
					return emptyTexture;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000535")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4002DCE")]
		public bool IsStarted
		{
			[Cpp2IlInjected.Token(Token = "0x60024D1")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60024D2")]
			[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000536")]
		public unsafe UnityEngine.Vector3 WorldPosition
		{
			[Cpp2IlInjected.Token(Token = "0x60024D3")]
			[Cpp2IlInjected.Address(RVA = "0x1621520", Offset = "0x161FF20", VA = "0x181621520")]
			get
			{
				int num = 0;
				UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60024D4")]
			[Cpp2IlInjected.Address(RVA = "0x16216F0", Offset = "0x16200F0", VA = "0x1816216F0")]
			set
			{
				//Discarded unreachable code: IL_0053
				//IL_001c: Expected native int or pointer, but got O
				//IL_0031: Expected native int or pointer, but got O
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Expected F4, but got Unknown
				//IL_004c: Expected O, but got F4
				Transform transform = base.transform;
				float z = value.z;
				UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
				float z2 = vector.z;
				((UnityEngine.Vector3*)(IntPtr)position)->z = z2;
				float z3 = vector.z;
				((UnityEngine.Vector3*)(IntPtr)mirrorPosition)->z = z3;
				float num = (float)(mirrorPosition * -1f);
				mirrorPosition = (UnityEngine.Vector3)num;
				RenderLiveDecal();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000537")]
		public float Size
		{
			[Cpp2IlInjected.Token(Token = "0x60024D5")]
			[Cpp2IlInjected.Address(RVA = "0x13392C0", Offset = "0x1337CC0", VA = "0x1813392C0")]
			get
			{
				return size;
			}
			[Cpp2IlInjected.Token(Token = "0x60024D6")]
			[Cpp2IlInjected.Address(RVA = "0x16216B0", Offset = "0x16200B0", VA = "0x1816216B0")]
			set
			{
				float max = maxSize;
				float min = minSize;
				float num = (size = Mathf.Clamp(value, min, max));
				RenderLiveDecal();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000538")]
		public Quaternion WorldRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60024D7")]
			[Cpp2IlInjected.Address(RVA = "0x1621590", Offset = "0x161FF90", VA = "0x181621590")]
			get
			{
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60024D8")]
			[Cpp2IlInjected.Address(RVA = "0x1621780", Offset = "0x1620180", VA = "0x181621780")]
			set
			{
				//Discarded unreachable code: IL_0017
				Transform transform = base.transform;
				UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
				float z = vector.z;
				RenderLiveDecal();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005A")]
		public event Action<Texture2D> OnCurrentTextureChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60024D9")]
			[Cpp2IlInjected.Address(RVA = "0x1621410", Offset = "0x161FE10", VA = "0x181621410")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60024DA")]
			[Cpp2IlInjected.Address(RVA = "0x1621610", Offset = "0x1620010", VA = "0x181621610")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024DB")]
		[Cpp2IlInjected.Address(RVA = "0x161BC30", Offset = "0x161A630", VA = "0x18161BC30")]
		private void Awake()
		{
			//IL_001d: Expected I4, but got I8
			int num = 0;
			if (Application.platform != 0)
			{
				int num2 = 0;
				if (Application.platform != RuntimePlatform.OSXPlayer)
				{
					return;
				}
			}
			renderBufferLoad = RenderBufferLoadAction.Load;
		}

		[Cpp2IlInjected.Token(Token = "0x60024DC")]
		[Cpp2IlInjected.Address(RVA = "0x1620C80", Offset = "0x161F680", VA = "0x181620C80")]
		public void StartProjector(ProjectorMode mode, ProjectorResolution res)
		{
			//Discarded unreachable code: IL_0159
			//IL_00f8: Expected O, but got I4
			RenderTexture renderTexture = default(RenderTexture);
			RenderTexture renderTexture2 = default(RenderTexture);
			RenderTexture renderTexture4 = default(RenderTexture);
			while (!IsStarted || _mode != mode || _res != res)
			{
				if (_res != res)
				{
					ReleaseRenderTargets();
				}
				_res = res;
				_mode = mode;
				_mirrorMode = false;
				_repeatMode = false;
				Color white = Color.white;
				ProjectorResolution res2 = _res;
				int num = 0;
				RenderTexture[] renderTextures = _renderTextures;
				if ((object)renderTexture != null && (object)renderTexture == null)
				{
					continue;
				}
				renderTextures[0] = renderTexture;
				_renderTextures[0].name = "_renderTextures[STATIC_RENDER]";
				ProjectorResolution res3 = _res;
				RenderTexture[] renderTextures2 = _renderTextures;
				if ((object)renderTexture2 != null && (object)renderTexture2 == null)
				{
					continue;
				}
				renderTextures2[2] = renderTexture2;
				_renderTextures[2].name = "_renderTextures[DEPTH_MAP]";
				ProjectorMode mode2 = _mode;
				if (mode2 != 0)
				{
					if (mode2 != ProjectorMode.RenderOnly)
					{
						goto IL_0151;
					}
					RenderTexture renderTexture3 = _renderTextures[1];
					int num2 = 0;
					if (renderTexture3 != (UnityEngine.Object)num2)
					{
						RenderTexture.ReleaseTemporary(_renderTextures[1]);
					}
					RenderTexture[] renderTextures3 = _renderTextures;
				}
				ProjectorResolution res4 = _res;
				RenderTexture[] renderTextures4 = _renderTextures;
				if ((object)renderTexture4 != null && (object)renderTexture4 == null)
				{
					continue;
				}
				renderTextures4[1] = renderTexture4;
				_renderTextures[1].name = "_renderTextures[LIVE_RENDER]";
				goto IL_0151;
				IL_0151:
				IsStarted = true;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024DD")]
		[Cpp2IlInjected.Address(RVA = "0x1621070", Offset = "0x161FA70", VA = "0x181621070")]
		public void StopProjector()
		{
			//Discarded unreachable code: IL_0050
			int num = 0;
			if ((IsStarted ? 1 : 0) != num)
			{
				if ((_liveEditingEnabled ? 1 : 0) != num)
				{
					_liveEditingEnabled = (byte)num != 0;
					int renderTarget = 0;
					SetRenderTarget(renderTarget);
					RenderTexture texture = _renderTextures[1];
					ClearRenderTexture(texture);
				}
				ReleaseRenderTargets();
				Dictionary<Item, Texture2D>.ValueCollection values = (Dictionary<Item, Texture2D>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)_textureCache).get_Values();
				bool flag = default(bool);
				if (!flag)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024DE")]
		[Cpp2IlInjected.Address(RVA = "0x1620940", Offset = "0x161F340", VA = "0x181620940")]
		public void SetRenderer(Renderer renderer, [Optional] Material m, bool worldSpace = false)
		{
			rendererInstance = renderer;
			_worldSpace = worldSpace;
			mat = m;
			int renderTarget = 0;
			SetRenderTarget(renderTarget);
		}

		[Cpp2IlInjected.Token(Token = "0x60024DF")]
		[Cpp2IlInjected.Address(RVA = "0x16207C0", Offset = "0x161F1C0", VA = "0x1816207C0")]
		private void SetRenderTarget(int renderTargetIdx)
		{
			//Discarded unreachable code: IL_0076
			//IL_0010: Expected O, but got I4
			Material material = mat;
			int num = 0;
			if (!(material == (UnityEngine.Object)num))
			{
				RenderTexture[] renderTextures = _renderTextures;
				Material material2 = mat;
				RenderTexture value = renderTextures[renderTargetIdx];
				material2.SetTexture("_DecalTex", value);
			}
			else
			{
				MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
				rendererInstance.Internal_GetPropertyBlock(materialPropertyBlock);
				RenderTexture value2 = _renderTextures[renderTargetIdx];
				materialPropertyBlock.SetTexture("_DecalTex", value2);
				rendererInstance.Internal_SetPropertyBlock(materialPropertyBlock);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024E0")]
		[Cpp2IlInjected.Address(RVA = "0x161F560", Offset = "0x161DF60", VA = "0x18161F560")]
		private void ReleaseRenderTargets()
		{
			//Discarded unreachable code: IL_0035
			//IL_0027: Expected O, but got I4
			RenderTexture[] renderTextures = _renderTextures;
			int num = 0;
			int length = renderTextures.Length;
			if (num < length)
			{
				RenderTexture renderTexture = renderTextures[num];
				int num2 = 0;
				if (renderTexture != (UnityEngine.Object)num2)
				{
					RenderTexture.ReleaseTemporary(renderTexture);
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024E1")]
		[Cpp2IlInjected.Address(RVA = "0x16209A0", Offset = "0x161F3A0", VA = "0x1816209A0")]
		[AsyncStateMachine(typeof(_003CSetTexture_003Ed__56))]
		public Task SetTexture(Item decalItem)
		{
			int itemID = decalItem.ItemID;
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60024E2")]
		[Cpp2IlInjected.Address(RVA = "0x1620350", Offset = "0x161ED50", VA = "0x181620350")]
		public void SetColor(Color color)
		{
			RenderLiveDecal();
		}

		[Cpp2IlInjected.Token(Token = "0x60024E3")]
		[Cpp2IlInjected.Address(RVA = "0x1620AC0", Offset = "0x161F4C0", VA = "0x181620AC0")]
		public unsafe void SetTransform(UnityEngine.Vector3 pos, Quaternion rotation, float size)
		{
			//Discarded unreachable code: IL_0085
			//IL_0015: Expected native int or pointer, but got O
			//IL_0028: Expected native int or pointer, but got O
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected F4, but got Unknown
			//IL_0043: Expected O, but got F4
			Transform transform = base.transform;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			((UnityEngine.Vector3*)(IntPtr)position)->z = z;
			float z2 = vector.z;
			((UnityEngine.Vector3*)(IntPtr)mirrorPosition)->z = z2;
			float num = (float)(mirrorPosition * -1f);
			mirrorPosition = (UnityEngine.Vector3)num;
			RenderLiveDecal();
			Transform transform2 = base.transform;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z3 = vector2.z;
			RenderLiveDecal();
			float max = maxSize;
			float min = minSize;
			float num2 = (this.size = Mathf.Clamp(size, min, max));
		}

		[Cpp2IlInjected.Token(Token = "0x60024E4")]
		[Cpp2IlInjected.Address(RVA = "0x1620220", Offset = "0x161EC20", VA = "0x181620220")]
		public void Roll(float roll)
		{
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z2 = vector2.z;
			RenderLiveDecal();
		}

		[Cpp2IlInjected.Token(Token = "0x60024E5")]
		[Cpp2IlInjected.Address(RVA = "0x1620620", Offset = "0x161F020", VA = "0x181620620")]
		public void SetOrbit(float x, float y)
		{
			//Discarded unreachable code: IL_0017
			Transform transform = base.transform;
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			RenderLiveDecal();
		}

		[Cpp2IlInjected.Token(Token = "0x60024E6")]
		[Cpp2IlInjected.Address(RVA = "0x1621280", Offset = "0x161FC80", VA = "0x181621280")]
		public void ToggleFlip()
		{
			bool flag = (_flipped = !_flipped);
			RenderLiveDecal();
		}

		[Cpp2IlInjected.Token(Token = "0x60024E7")]
		[Cpp2IlInjected.Address(RVA = "0x1620360", Offset = "0x161ED60", VA = "0x181620360")]
		public void SetFlip(bool flipped)
		{
			_flipped = flipped;
			RenderLiveDecal();
		}

		[Cpp2IlInjected.Token(Token = "0x60024E8")]
		[Cpp2IlInjected.Address(RVA = "0x1620370", Offset = "0x161ED70", VA = "0x181620370")]
		public unsafe void SetFromDecal(IDecal decal)
		{
			//Discarded unreachable code: IL_0067
			//IL_000d: Expected I4, but got O
			//IL_0018: Expected I4, but got O
			//IL_0023: Expected I4, but got O
			//IL_002e: Expected I4, but got O
			//IL_0039: Expected I4, but got O
			//IL_0045: Expected F4, but got I4
			//IL_0040: Expected native int or pointer, but got O
			//IL_004d: Expected F4, but got I4
			//IL_004d: Expected F4, but got I4
			//IL_004d: Expected F4, but got I4
			//IL_0060: Expected O, but got I4
			int num = 0;
			_cutoutMode = (byte)(int)typeof(IVector3).TypeHandle != 0;
			_flipped = (byte)(int)typeof(IVector3).TypeHandle != 0;
			_seeThroughMode = (byte)(int)typeof(IVector3).TypeHandle != 0;
			_repeatMode = (byte)(int)typeof(IVector3).TypeHandle != 0;
			_UVSpaceMode = (byte)(int)typeof(IVector3).TypeHandle != 0;
			((UnityEngine.Vector3*)(IntPtr)position)->z = num;
			Quaternion quaternion = (Quaternion)(_currentDecal = (Item)Quaternion.Euler(num, num, num));
			bool flag = default(bool);
			if (flag)
			{
				_color = (Color)num;
				RenderLiveDecal();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024E9")]
		[Cpp2IlInjected.Address(RVA = "0x161F020", Offset = "0x161DA20", VA = "0x18161F020")]
		public List<Decal> GenerateFromLiveRender()
		{
			//Discarded unreachable code: IL_01b6
			//IL_0098: Expected I4, but got O
			//IL_00e0: Expected F4, but got O
			//IL_00e9: Expected F4, but got O
			//IL_0102: Expected F4, but got O
			//IL_010b: Expected F4, but got O
			//IL_018e: Expected I4, but got O
			List<Decal> list = (List<Decal>)(object)new List<T>();
			Decal decal = new Decal();
			Meta.Customization.Vector3 vector = (decal.position_ = new Meta.Customization.Vector3());
			Meta.Customization.Vector3 vector2 = (decal.rotation_ = new Meta.Customization.Vector3());
			float num = (decal.size_ = size);
			bool flag = (decal.flipped_ = _flipped);
			bool flag2 = (decal.cutout_ = _cutoutMode);
			bool flag3 = (decal.seeThrough_ = _seeThroughMode);
			bool flag4 = (decal.uVSpace_ = _UVSpaceMode);
			bool flag5 = (decal.repeat_ = _repeatMode);
			Item currentDecal = _currentDecal;
			decal.decalItem_ = (int)currentDecal;
			Color color = _color;
			string text = default(string);
			string text3 = (decal.Color = "#" + text);
			((List<T>)(object)list).Add((T)decal);
			if (_mirrorMode)
			{
				Decal decal2 = new Decal();
				Meta.Customization.Vector3 vector3 = new Meta.Customization.Vector3();
				vector3.x_ = (float)color;
				vector3.z_ = (float)color;
				decal2.position_ = vector3;
				Meta.Customization.Vector3 vector4 = new Meta.Customization.Vector3();
				vector4.x_ = (float)color;
				vector4.z_ = (float)color;
				decal2.rotation_ = vector4;
				float num2 = (decal2.size_ = size);
				bool flag6 = (decal2.flipped_ = !_flipped);
				bool flag7 = (decal2.cutout_ = _cutoutMode);
				bool flag8 = (decal2.seeThrough_ = _seeThroughMode);
				bool flag9 = (decal2.uVSpace_ = _UVSpaceMode);
				bool flag10 = (decal2.repeat_ = _repeatMode);
				Item currentDecal2 = _currentDecal;
				decal2.decalItem_ = (int)currentDecal2;
				string text4 = default(string);
				string text6 = (decal2.Color = "#" + text4);
				((List<T>)(object)list).Add((T)decal2);
				_mirrorMode = false;
			}
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x60024EA")]
		[Cpp2IlInjected.Address(RVA = "0x16212E0", Offset = "0x161FCE0", VA = "0x1816212E0")]
		public void ToggleSeeThroughMode(bool enabled)
		{
			_seeThroughMode = enabled;
			RenderLiveDecal();
		}

		[Cpp2IlInjected.Token(Token = "0x60024EB")]
		[Cpp2IlInjected.Address(RVA = "0x16212A0", Offset = "0x161FCA0", VA = "0x1816212A0")]
		public void ToggleMirrorMode(bool enabled)
		{
			if (_mirrorMode != enabled)
			{
				_mirrorMode = enabled;
				if (_liveEditingEnabled)
				{
					RenderLiveDecal();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024EC")]
		[Cpp2IlInjected.Address(RVA = "0x1621260", Offset = "0x161FC60", VA = "0x181621260")]
		public void ToggleCutoutMode(bool enabled)
		{
			if (_cutoutMode != enabled)
			{
				_cutoutMode = enabled;
				if (_liveEditingEnabled)
				{
					RenderLiveDecal();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024ED")]
		[Cpp2IlInjected.Address(RVA = "0x16212F0", Offset = "0x161FCF0", VA = "0x1816212F0")]
		public void ToggleUVSpaceMode(bool enabled)
		{
			if (_UVSpaceMode != enabled)
			{
				_UVSpaceMode = enabled;
				if (_liveEditingEnabled)
				{
					RenderLiveDecal();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024EE")]
		[Cpp2IlInjected.Address(RVA = "0x16212C0", Offset = "0x161FCC0", VA = "0x1816212C0")]
		public void ToggleRepeatMode(bool enabled)
		{
			_repeatMode = enabled;
			if (_liveEditingEnabled)
			{
				RenderLiveDecal();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024EF")]
		[Cpp2IlInjected.Address(RVA = "0x161ECF0", Offset = "0x161D6F0", VA = "0x18161ECF0")]
		[AsyncStateMachine(typeof(_003CEnableLiveEditing_003Ed__70))]
		public Task EnableLiveEditing()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60024F0")]
		[Cpp2IlInjected.Address(RVA = "0x161BE00", Offset = "0x161A800", VA = "0x18161BE00")]
		public void DisableLiveEditing()
		{
			//Discarded unreachable code: IL_002f
			if (_liveEditingEnabled)
			{
				_liveEditingEnabled = false;
				int renderTarget = 0;
				SetRenderTarget(renderTarget);
				RenderTexture texture = _renderTextures[1];
				ClearRenderTexture(texture);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024F1")]
		[Cpp2IlInjected.Address(RVA = "0x161EDF0", Offset = "0x161D7F0", VA = "0x18161EDF0")]
		public int FindLayerAt(Vector2 uv)
		{
			//IL_005f: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected I4, but got Unknown
			RenderTexture renderTexture = _renderTextures[2];
			uint num = default(uint);
			int mipChain = default(int);
			Texture2D texture2D = new Texture2D((int)num, (int)num, TextureFormat.RGBA32, (byte)mipChain != 0);
			mipChain = 0;
			texture2D.name = "DecalLayerTexture";
			int width = _renderTextures[2].width;
			int height = _renderTextures[2].height;
			int num2 = 0;
			int destY = 0;
			int destX = 0;
			texture2D.ReadPixels((Rect)num2, destX, destY);
			texture2D.Apply();
			RenderTexture.SetActive((RenderTexture)0);
			Color32 color = default(Color32);
			uint num3 = (uint)(int)(num3 - color);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60024F2")]
		[Cpp2IlInjected.Address(RVA = "0x161E010", Offset = "0x161CA10", VA = "0x18161E010")]
		public void DrawLayerMap(IList<IDecal> decals)
		{
			//Discarded unreachable code: IL_01a0
			//IL_010e: Expected O, but got I4
			//IL_011c: Expected O, but got I4
			//IL_012a: Expected O, but got I4
			//IL_0177: Expected I4, but got I8
			int num = 0;
			if (_mode == (ProjectorMode)num)
			{
				_liveEditingEnabled = (byte)num != 0;
				CommandBuffer commandBuffer = CommandBufferPool.Get("BakeDecalRenderPass");
				RenderTexture[] renderTextures = _renderTextures;
				RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
				IntPtr bufferPointer = renderTargetIdentifier.m_BufferPointer;
				Camera playerCamera = SystemRoot.Instance._playerCamera;
				Matrix4x4 matrix4x = default(Matrix4x4);
				float m = matrix4x.m01;
				float m2 = matrix4x.m02;
				float m3 = matrix4x.m03;
				Camera playerCamera2 = SystemRoot.Instance._playerCamera;
				Matrix4x4 matrix4x2 = default(Matrix4x4);
				float m4 = matrix4x2.m02;
				float m5 = matrix4x2.m03;
				if ((long)num < (long)(IntPtr)matrix4x2)
				{
					if ((object)matrix4x2 == null)
					{
						Dictionary<Item, Texture2D> textureCache = _textureCache;
						bool flag = default(bool);
						if (flag)
						{
							Material material = new Material(decalShader);
							m = m4;
							m5 = m;
							Quaternion quaternion = Quaternion.Euler(m4, m5, m4);
							Matrix4x4 matrix4x3 = default(Matrix4x4);
							float m6 = matrix4x3.m01;
							float m7 = matrix4x3.m02;
							float m8 = matrix4x3.m03;
							float max = maxSize;
							float min = minSize;
							min = Mathf.Clamp(m7, min, max);
							m4 = min;
							Matrix4x4 matrix4x4 = default(Matrix4x4);
							if ((object)matrix4x4 != null)
							{
							}
							int num2 = 0;
							int num3 = 0;
							int num4 = 0;
							material.SetColor("_Color", (Color)num4);
							material.SetMatrix("_ProjectorView", (Matrix4x4)num4);
							material.SetMatrix("_ProjectorProj", (Matrix4x4)num4);
							Color color = default(Color);
							if ((object)color == null)
							{
								material.DisableKeyword("_REPEAT");
							}
							material.EnableKeyword("_REPEAT");
							int length = rendererInstance.GetSharedMaterialArray().Length;
							int num5 = 0;
							if (length > 0)
							{
								Renderer renderer = rendererInstance;
								ulong num6 = default(ulong);
								commandBuffer.DrawRenderer(renderer, material, num5, (int)num6);
								num5++;
							}
							UnityEngine.Object.Destroy(material);
						}
					}
					num++;
				}
				Graphics.ExecuteCommandBuffer(commandBuffer);
				CommandBufferPool.Release(commandBuffer);
			}
			else
			{
				Debug.LogError("DrawLayerMap: Projector must be in Edit mode to allow drawing a layer map. Use StartProjector to change the current mode.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024F3")]
		[Cpp2IlInjected.Address(RVA = "0x161F430", Offset = "0x161DE30", VA = "0x18161F430")]
		[AsyncStateMachine(typeof(_003CLoadAllTexturesAsync_003Ed__74))]
		public Task LoadAllTexturesAsync(IEnumerable<IDecal> decals)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60024F4")]
		[Cpp2IlInjected.Address(RVA = "0x161D050", Offset = "0x161BA50", VA = "0x18161D050")]
		public void DrawAll(IList<IDecal> decals)
		{
			this.DrawAllExcept((IList<>)decals, -1);
		}

		[Cpp2IlInjected.Token(Token = "0x60024F5")]
		[Cpp2IlInjected.Address(RVA = "0x161D060", Offset = "0x161BA60", VA = "0x18161D060")]
		public void DrawAll(Renderer renderer, IEnumerable<IDecal> decals, RenderTexture finalDecal)
		{
			//Discarded unreachable code: IL_02ae, IL_02b4, IL_02ba, IL_02c0, IL_02c6, IL_02cc, IL_02d2, IL_02d8, IL_02de, IL_02e4, IL_02ea, IL_02f0, IL_02f6, IL_02fc
			//IL_00af: Expected O, but got I4
			//IL_00af: Expected O, but got I4
			//IL_00c3: Expected O, but got I4
			//IL_00f9: Expected O, but got I4
			//IL_020d: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			CommandBuffer commandBuffer = CommandBufferPool.Get("BakeDecalRenderPass");
			RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
			IntPtr bufferPointer = renderTargetIdentifier.m_BufferPointer;
			RenderTexture renderTexture = default(RenderTexture);
			renderTexture.name = "DecalRenderingTool::temp";
			if ((object)renderTexture != null)
			{
				while ((object)renderTexture != null)
				{
				}
				Dictionary<Item, Texture2D> textureCache = _textureCache;
				bool flag = default(bool);
				while (!flag)
				{
				}
				Material material = new Material(decalShader);
				Color color2 = (material.color = _color);
				material.SetTexture("_ProjectorDepth", renderTexture);
				if ((object)material != null)
				{
				}
				material.SetFloat("_BlendMode", 5f);
				if ((object)material == null && (object)material == null)
				{
					material.DisableKeyword("_SEE_THROUGH");
				}
				material.EnableKeyword("_SEE_THROUGH");
				int num4 = 0;
				bool flag2 = (UnityEngine.Object)num != (UnityEngine.Object)num4;
				if (flag2)
				{
					material.SetTexture("_ProjectedTex", (Texture)num);
				}
				if (!flag2)
				{
					material.DisableKeyword("_REPEAT");
				}
				material.EnableKeyword("_REPEAT");
				bool flag3 = default(bool);
				Color white = default(Color);
				if (!flag3)
				{
					white = Color.white;
				}
				material.SetColor("_Color", (Color)num2);
				if ((object)white == null)
				{
				}
				material.SetFloat("_Flipped", 5f);
				RenderTargetIdentifier renderTargetIdentifier2 = default(RenderTargetIdentifier);
				IntPtr bufferPointer2 = renderTargetIdentifier2.m_BufferPointer;
				float num5 = maxSize;
				float num6 = minSize;
				float num7 = default(float);
				num5 = num7;
				num6 = num7;
				Quaternion quaternion = Quaternion.Euler(num7, num6, num5);
				Matrix4x4 matrix4x = default(Matrix4x4);
				float m = matrix4x.m01;
				float m2 = matrix4x.m02;
				float m3 = matrix4x.m03;
				Matrix4x4 matrix4x2 = default(Matrix4x4);
				float m4 = matrix4x2.m01;
				float m5 = matrix4x2.m02;
				float m6 = matrix4x2.m03;
				m2 = num7;
				Matrix4x4 matrix4x3 = default(Matrix4x4);
				float m7 = matrix4x3.m01;
				float m8 = matrix4x3.m02;
				float m9 = matrix4x3.m03;
				Matrix4x4 matrix4x4 = default(Matrix4x4);
				float m10 = matrix4x4.m01;
				float m11 = matrix4x4.m02;
				float m12 = matrix4x4.m03;
				m12 = num7;
				m11 = m12;
				m10 = num7;
				Matrix4x4 matrix4x5 = default(Matrix4x4);
				float m13 = matrix4x5.m01;
				float m14 = matrix4x5.m02;
				float m15 = matrix4x5.m03;
				Matrix4x4 matrix4x6 = default(Matrix4x4);
				float m16 = matrix4x6.m01;
				float m17 = matrix4x6.m02;
				float m18 = matrix4x6.m03;
				int length = renderer.GetSharedMaterialArray().Length;
				if (num < length)
				{
					ulong num8 = default(ulong);
					commandBuffer.DrawRenderer(renderer, material, num, (int)num8);
					num++;
				}
				RenderTargetIdentifier renderTargetIdentifier3 = default(RenderTargetIdentifier);
				IntPtr bufferPointer3 = renderTargetIdentifier3.m_BufferPointer;
				if (num < length)
				{
					commandBuffer.DrawRenderer(renderer, material, num, num);
					num++;
					Matrix4x4 matrix4x7 = default(Matrix4x4);
					float m19 = matrix4x7.m01;
					float m20 = matrix4x7.m02;
					float m21 = matrix4x7.m03;
					Matrix4x4 matrix4x8 = default(Matrix4x4);
					float m22 = matrix4x8.m01;
					float m23 = matrix4x8.m02;
					float m24 = matrix4x8.m03;
					Matrix4x4 matrix4x9 = default(Matrix4x4);
					float m25 = matrix4x9.m01;
					float m26 = matrix4x9.m02;
					float m27 = matrix4x9.m03;
					if ((object)matrix4x9 != null)
					{
					}
					int num9 = 0;
					Mesh fullscreenMesh = RenderingUtils.fullscreenMesh;
				}
				UnityEngine.Object.Destroy(material);
			}
			if ((object)renderTexture != null)
			{
			}
			Graphics.ExecuteCommandBuffer(commandBuffer);
			RenderTexture.ReleaseTemporary(renderTexture);
			CommandBufferPool.Release(commandBuffer);
		}

		[Cpp2IlInjected.Token(Token = "0x60024F6")]
		[Cpp2IlInjected.Address(RVA = "0x161BE60", Offset = "0x161A860", VA = "0x18161BE60")]
		public void DrawAllExcept(IList<IDecal> decals, int layerIndex)
		{
			//Discarded unreachable code: IL_002b, IL_0046, IL_004d, IL_0055, IL_0065, IL_00a4, IL_00ba, IL_00bf, IL_00cb, IL_00e9, IL_00f6, IL_00fb, IL_0107, IL_011b, IL_0123, IL_016a, IL_0183, IL_01ae, IL_01ca, IL_01d7, IL_01df, IL_01fb, IL_0202, IL_0206, IL_020e, IL_0228
			//IL_00e2: Expected O, but got I4
			//IL_00e2: Expected O, but got I4
			//IL_00f6: Expected O, but got I4
			//IL_0194: Expected O, but got I4
			//IL_01c4: Expected I4, but got I8
			//IL_0228: Expected I4, but got I8
			int liveEditingEnabled = 0;
			int renderTarget = 0;
			_liveEditingEnabled = (byte)liveEditingEnabled != 0;
			SetRenderTarget(renderTarget);
			if (layerIndex != -1)
			{
			}
			RenderTexture texture = _renderTextures[0];
			ClearRenderTexture(texture);
		}

		[Cpp2IlInjected.Token(Token = "0x60024F7")]
		[Cpp2IlInjected.Address(RVA = "0x161BC60", Offset = "0x161A660", VA = "0x18161BC60")]
		private void ClearRenderTexture(RenderTexture texture)
		{
			//Discarded unreachable code: IL_002e
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(texture == (UnityEngine.Object)num))
			{
				CommandBuffer buffer = CommandBufferPool.Get("BakeDecalRenderPass");
				int num2 = 0;
				RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
				IntPtr bufferPointer = renderTargetIdentifier.m_BufferPointer;
				Graphics.ExecuteCommandBuffer(buffer);
				CommandBufferPool.Release(buffer);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60024F8")]
		[Cpp2IlInjected.Address(RVA = "0x161F620", Offset = "0x161E020", VA = "0x18161F620")]
		private void RenderLiveDecal()
		{
			CommandBuffer buffer = CommandBufferPool.Get("LiveDecalRenderPass");
			float z = position.z;
			Quaternion quaternion = rotation;
			if (_mirrorMode)
			{
				float z2 = mirrorPosition.z;
				Quaternion quaternion2 = mirrorRotation;
			}
			Graphics.ExecuteCommandBuffer(buffer);
			CommandBufferPool.Release(buffer);
		}

		[Cpp2IlInjected.Token(Token = "0x60024F9")]
		[Cpp2IlInjected.Address(RVA = "0x161F790", Offset = "0x161E190", VA = "0x18161F790")]
		private unsafe void RenderLiveDecal(CommandBuffer cmd, bool flipped, UnityEngine.Vector3 camPosition, Quaternion camRotation, bool doBlit)
		{
			//Discarded unreachable code: IL_0214
			//IL_00eb: Expected native int or pointer, but got O
			//IL_0164: Expected I4, but got I8
			//IL_019d: Expected O, but got I4
			//IL_01eb: Expected F4, but got I4
			//IL_01eb: Expected F4, but got I4
			Material material = new Material(decalShader);
			Color color2 = (material.color = _color);
			RenderTexture value = _renderTextures[2];
			material.SetTexture("_ProjectorDepth", value);
			Dictionary<Item, Texture2D> textureCache = _textureCache;
			int num = 0;
			bool flag = default(bool);
			if (!flag)
			{
			}
			material.SetTexture("_ProjectedTex", value);
			if ((_seeThroughMode ? 1 : 0) == num && (_repeatMode ? 1 : 0) == num)
			{
				material.DisableKeyword("_SEE_THROUGH");
			}
			material.EnableKeyword("_SEE_THROUGH");
			if ((_repeatMode ? 1 : 0) == num)
			{
				material.DisableKeyword("_REPEAT");
			}
			material.EnableKeyword("_REPEAT");
			if ((_cutoutMode ? 1 : 0) != num)
			{
			}
			material.SetFloat("_BlendMode", 5f);
			flag = flipped;
			material.SetFloat("_Flipped", 5f);
			if ((_worldSpace ? 1 : 0) != num)
			{
				Transform transform = base.transform;
				float z = camPosition.z;
				UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
				float num2 = (((UnityEngine.Vector3*)(IntPtr)camPosition)->z = vector.z);
				Transform transform2 = base.transform;
			}
			float z2 = camPosition.z;
			Matrix4x4 matrix4x = default(Matrix4x4);
			float m = matrix4x.m01;
			Matrix4x4 matrix4x2 = default(Matrix4x4);
			float m2 = matrix4x2.m01;
			m2 = size;
			Matrix4x4 matrix4x3 = default(Matrix4x4);
			float m3 = matrix4x3.m01;
			Matrix4x4 matrix4x4 = default(Matrix4x4);
			float m4 = matrix4x4.m01;
			Material[] sharedMaterialArray = rendererInstance.GetSharedMaterialArray();
			RenderTexture[] renderTextures = _renderTextures;
			int length = sharedMaterialArray.Length;
			if (length > 0)
			{
				Renderer renderer = rendererInstance;
				ulong num3 = default(ulong);
				cmd.DrawRenderer(renderer, material, num, (int)num3);
				num++;
			}
			RenderTexture[] renderTextures2 = _renderTextures;
			int num4 = 0;
			RenderTexture[] renderTextures3 = _renderTextures;
			int length2 = renderTextures3.Length;
			RenderTexture source = renderTextures3[0];
			int num5 = 0;
			cmd.Blit(source, (RenderTargetIdentifier)num5);
			if (!_UVSpaceMode)
			{
				int num6 = 0;
				if (length <= 0)
				{
					goto IL_020d;
				}
				Renderer renderer2 = rendererInstance;
				cmd.DrawRenderer(renderer2, material, num6, num6);
				num6++;
			}
			float x = size;
			int num7 = 0;
			UnityEngine.Vector3 vector2 = default(UnityEngine.Vector3);
			float z3 = vector2.z;
			int num8 = 0;
			Quaternion quaternion = Quaternion.Euler(x, num8, num7);
			Matrix4x4 matrix4x5 = default(Matrix4x4);
			float m5 = matrix4x5.m01;
			Matrix4x4 matrix4x6 = default(Matrix4x4);
			float m6 = matrix4x6.m01;
			if (flipped)
			{
			}
			int num9 = 0;
			Mesh fullscreenMesh = RenderingUtils.fullscreenMesh;
			goto IL_020d;
			IL_020d:
			UnityEngine.Object.Destroy(material);
		}

		[Cpp2IlInjected.Token(Token = "0x60024FA")]
		[Cpp2IlInjected.Address(RVA = "0x1621310", Offset = "0x161FD10", VA = "0x181621310")]
		public DecalRenderingTool()
		{
			//IL_000a: Expected I4, but got I8
			//IL_005b: Expected I4, but got I8
			Quaternion identity = Quaternion.identity;
			Quaternion identity2 = Quaternion.identity;
			size = 1f;
			_renderTextures = new RenderTexture[3];
			_textureCache = (Dictionary<Item, Texture2D>)(object)new Dictionary<TKey, TValue>();
			renderBufferLoad = RenderBufferLoadAction.DontCare;
			base._002Ector();
		}
	}
}
