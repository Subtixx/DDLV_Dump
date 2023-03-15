using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Streaming;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

namespace Mdl.Items
{
	[Cpp2IlInjected.Token(Token = "0x20003B8")]
	public class ItemPreview : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40018D9")]
		[SerializeField]
		protected GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40018DA")]
		[SerializeField]
		protected RectTransform _roundedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40018DB")]
		public int Width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40018DC")]
		public int Height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40018DD")]
		[SerializeField]
		protected Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40018DE")]
		[SerializeField]
		[ColorUsage(false, true)]
		protected Color directionalLightColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40018DF")]
		[SerializeField]
		[Header("Camera & Render Target")]
		protected RawImage renderTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40018E0")]
		protected RectTransform _renderTargetRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40018E1")]
		[SerializeField]
		protected GameObject _itemHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40018E2")]
		[SerializeField]
		protected float cameraDistanceFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40018E3")]
		[SerializeField]
		protected float offsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40018E4")]
		[SerializeField]
		protected float heightDegrees;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40018E5")]
		[SerializeField]
		protected float fieldOfView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40018E6")]
		[SerializeField]
		[Header("Effects")]
		protected int _rotSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40018E7")]
		[SerializeField]
		protected float _initialScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40018E8")]
		[SerializeField]
		protected float _targetScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40018E9")]
		[SerializeField]
		protected Vector3 _targetRot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40018EA")]
		[SerializeField]
		[Header("Footer")]
		protected GameObject _backgroundBot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40018EB")]
		private int resolution;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40018EC")]
		protected RenderTexture rt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40018ED")]
		protected bool _isAnimating;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40018EE")]
		protected bool _rotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40018EF")]
		protected Item _currentItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40018F0")]
		protected bool _isShown;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40018F2")]
		private Material copyDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40018F3")]
		private List<Renderer> targetRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40018F4")]
		private Vector4 screenParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40018F5")]
		private Vector4 projectionParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40018F6")]
		private Vector4 zBufferParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40018F7")]
		private Matrix4x4 viewMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40018F8")]
		private Matrix4x4 projectionMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40018F9")]
		private Matrix4x4 inverseViewMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40018FA")]
		private Matrix4x4 inverseProjectionMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40018FB")]
		private Matrix4x4 inverseViewProjection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40018FC")]
		private Matrix4x4 worldToCameraMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40018FD")]
		private Matrix4x4 cameraToWorldMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x40018FE")]
		private int depthAttachmentID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
		[Cpp2IlInjected.Token(Token = "0x40018FF")]
		private int depthTextureID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4001900")]
		private int opaqueTextureID;

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x6000FFC")]
			[Cpp2IlInjected.Address(RVA = "0x1195B30", Offset = "0x1194530", VA = "0x181195B30")]
			get
			{
				return _isShown;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		public GameObject TargetedObj
		{
			[Cpp2IlInjected.Token(Token = "0x6000FFD")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC20", Offset = "0x7D9620", VA = "0x1807DAC20")]
			[CompilerGenerated]
			get
			{
				return _003CTargetedObj_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000FFE")]
			[Cpp2IlInjected.Address(RVA = "0x9766B0", Offset = "0x9750B0", VA = "0x1809766B0")]
			[CompilerGenerated]
			private set
			{
				_003CTargetedObj_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FFF")]
		[Cpp2IlInjected.Address(RVA = "0x11C2650", Offset = "0x11C1050", VA = "0x1811C2650", Slot = "4")]
		protected virtual void Start()
		{
			//Discarded unreachable code: IL_0047
			//IL_0032: Expected O, but got I4
			Material material = (copyDepth = new Material(Shader.Find("Hidden/Universal Render Pipeline/CopyDepth")));
			RawImage rawImage = renderTarget;
			if ((object)rawImage != null)
			{
				RectTransform component = rawImage.GetComponent<RectTransform>();
			}
			int num = 0;
			_renderTargetRT = (RectTransform)num;
			GameObject gameObject = root;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001000")]
		[Cpp2IlInjected.Address(RVA = "0x11C0010", Offset = "0x11BEA10", VA = "0x1811C0010", Slot = "5")]
		protected virtual void OnDestroy()
		{
			//IL_0010: Expected O, but got I4
			//IL_0035: Expected O, but got I8
			RenderTexture renderTexture = rt;
			int num = 0;
			if (renderTexture != (UnityEngine.Object)num && rt.IsCreated())
			{
				rt.Release();
			}
			rt = (RenderTexture)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001001")]
		[Cpp2IlInjected.Address(RVA = "0x11BFBF0", Offset = "0x11BE5F0", VA = "0x1811BFBF0")]
		public void Clear()
		{
			//Discarded unreachable code: IL_0056
			//IL_0010: Expected O, but got I4
			GameObject itemHolder = _itemHolder;
			int num = 0;
			if (!(itemHolder == (UnityEngine.Object)num))
			{
				GameObject itemHolder2 = _itemHolder;
				int num2 = 0;
				int childCount = itemHolder2.transform.childCount;
				if (num2 < childCount)
				{
					UnityEngine.Object.Destroy(_itemHolder.transform.GetChild(num2).gameObject);
					GameObject itemHolder3 = _itemHolder;
					num2++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001002")]
		[Cpp2IlInjected.Address(RVA = "0x11BFD10", Offset = "0x11BE710", VA = "0x1811BFD10")]
		private void DestroyCurrentTarget()
		{
			//Discarded unreachable code: IL_008f
			//IL_0010: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			GameObject itemHolder = _itemHolder;
			int num = 0;
			if (itemHolder == (UnityEngine.Object)num)
			{
				return;
			}
			GameObject gameObject = TargetedObj;
			int num2 = 0;
			if (gameObject == (UnityEngine.Object)num2)
			{
				return;
			}
			GameObject itemHolder2 = _itemHolder;
			int num3 = 0;
			int childCount = itemHolder2.transform.childCount;
			if (num3 < childCount)
			{
				Transform child = _itemHolder.transform.GetChild(num3);
				Transform transform = TargetedObj.transform;
				if (!(child == transform))
				{
					GameObject itemHolder3 = _itemHolder;
					num3++;
				}
				UnityEngine.Object.Destroy(TargetedObj);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001003")]
		[Cpp2IlInjected.Address(RVA = "0x11C07A0", Offset = "0x11BF1A0", VA = "0x1811C07A0")]
		public void SetTargetByPrefab(string prefabAddress)
		{
			//IL_0010: Expected O, but got I4
			Task asyncTask = default(Task);
			string[] array;
			string text2 = default(string);
			while (true)
			{
				GameObject itemHolder = _itemHolder;
				int num = 0;
				if (!(itemHolder == (UnityEngine.Object)num))
				{
					int num2 = 0;
					asyncTask.FireAndForgetTask();
					return;
				}
				array = new string[7];
				if ("Trying to instantiate item by prefab address '" != null && "Trying to instantiate item by prefab address '" == null)
				{
					continue;
				}
				array[0] = "Trying to instantiate item by prefab address '";
				if (prefabAddress != null && "Trying to instantiate item by prefab address '" == null)
				{
					continue;
				}
				array[1] = prefabAddress;
				if ("' but there is no Item Holder assigned in object '" != null && "' but there is no Item Holder assigned in object '" == null)
				{
					continue;
				}
				array[2] = "' but there is no Item Holder assigned in object '";
				string text = base.gameObject.name;
				if (text != null && text == null)
				{
					continue;
				}
				array[3] = text;
				if ("' (parent: " != null && "' (parent: " == null)
				{
					continue;
				}
				array[4] = "' (parent: ";
				Transform parent = base.gameObject.transform.parent;
				if ((object)parent != null)
				{
					text2 = parent.name;
					if (text2 != null)
					{
					}
				}
				if ("none" == null || text2 != null)
				{
					array[5] = "none";
					if (")." == null || ")." != null)
					{
						break;
					}
				}
			}
			array[6] = ").";
			Debug.LogError(string.Concat(array));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001004")]
		[Cpp2IlInjected.Address(RVA = "0x11C0260", Offset = "0x11BEC60", VA = "0x1811C0260")]
		public void SetTargetByGO(GameObject target, bool cloneRequired)
		{
			//Discarded unreachable code: IL_016e
			//IL_0014: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			string[] array;
			GameObject gameObject = default(GameObject);
			GameObject gameObject2 = default(GameObject);
			string text3 = default(string);
			while (true)
			{
				if (cloneRequired)
				{
					GameObject itemHolder = _itemHolder;
					int num = 0;
					if (itemHolder == (UnityEngine.Object)num)
					{
						array = new string[7];
						if ("Trying to clone item '" != null && "Trying to clone item '" == null)
						{
							continue;
						}
						array[0] = "Trying to clone item '";
						string text = target.name;
						if (text != null && text == null)
						{
							continue;
						}
						array[1] = text;
						if ("' but there is no Item Holder assigned in object '" != null && "' but there is no Item Holder assigned in object '" == null)
						{
							continue;
						}
						array[2] = "' but there is no Item Holder assigned in object '";
						string text2 = gameObject.name;
						if (text2 != null && text2 == null)
						{
							continue;
						}
						array[3] = text2;
						if ("' (parent: " != null && "' (parent: " == null)
						{
							continue;
						}
						array[4] = "' (parent: ";
						Transform parent = gameObject2.transform.parent;
						if ((object)parent != null)
						{
							text3 = parent.name;
							if (text3 != null)
							{
							}
						}
						if ("none" == null || text3 != null)
						{
							array[5] = "none";
							if (")." == null || ")." != null)
							{
								break;
							}
						}
						continue;
					}
					Transform parent2 = _itemHolder.transform;
					GameObject gameObject3 = target.Clone(parent2);
				}
				int num2 = 0;
				if (target != (UnityEngine.Object)num2)
				{
					StreamableAssetRef componentInChildren = target.GetComponentInChildren<StreamableAssetRef>();
					int num3 = 0;
					if (componentInChildren != (UnityEngine.Object)num3)
					{
						UnityEngine.Object.Destroy(componentInChildren);
					}
					SetTarget(target);
				}
				return;
			}
			array[6] = ").";
			Debug.LogError(string.Concat(array));
		}

		[Cpp2IlInjected.Token(Token = "0x6001005")]
		[Cpp2IlInjected.Address(RVA = "0x11C0D00", Offset = "0x11BF700", VA = "0x1811C0D00", Slot = "6")]
		protected virtual void SetTarget(GameObject target)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001006")]
		[Cpp2IlInjected.Address(RVA = "0x11C00D0", Offset = "0x11BEAD0", VA = "0x1811C00D0")]
		public void ResetTarget()
		{
			//Discarded unreachable code: IL_0069
			//IL_0010: Expected O, but got I4
			GameObject itemHolder = _itemHolder;
			int num = 0;
			if (!(itemHolder == (UnityEngine.Object)num))
			{
				GameObject itemHolder2 = _itemHolder;
				int num2 = 0;
				int num3 = 0;
				int childCount = itemHolder2.transform.childCount;
				if (num3 < childCount)
				{
					UnityEngine.Object.Destroy(_itemHolder.transform.GetChild(num2).gameObject);
					GameObject itemHolder3 = _itemHolder;
					num2++;
				}
			}
			_rotationEnabled = true;
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6001007")]
		[Cpp2IlInjected.Address(RVA = "0x11C25C0", Offset = "0x11C0FC0", VA = "0x1811C25C0", Slot = "7")]
		public virtual void Show()
		{
			//Discarded unreachable code: IL_0025
			//IL_0017: Expected O, but got I4
			GameObject gameObject = TargetedObj;
			_isShown = true;
			int num = 0;
			bool active = gameObject != (UnityEngine.Object)num;
			root.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6001008")]
		[Cpp2IlInjected.Address(RVA = "0x11BFEC0", Offset = "0x11BE8C0", VA = "0x1811BFEC0", Slot = "8")]
		public virtual void Hide()
		{
			//Discarded unreachable code: IL_0018
			_isShown = false;
			GameObject gameObject = root;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001009")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "9")]
		public virtual void ShowFooter()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600100A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "10")]
		public virtual void HideFooter()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600100B")]
		[Cpp2IlInjected.Address(RVA = "0x11C0230", Offset = "0x11BEC30", VA = "0x1811C0230", Slot = "11")]
		public virtual void SetSquareBottomActive(bool active)
		{
			//Discarded unreachable code: IL_000d
			_backgroundBot.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x600100C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		public virtual void SetFooterText(string itemText)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600100D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		public virtual void SetTagsList()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600100E")]
		[Cpp2IlInjected.Address(RVA = "0x117D770", Offset = "0x117C170", VA = "0x18117D770")]
		private void SetActive(bool active)
		{
			//Discarded unreachable code: IL_000d
			root.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x600100F")]
		[Cpp2IlInjected.Address(RVA = "0x11BFEF0", Offset = "0x11BE8F0", VA = "0x1811BFEF0")]
		[AsyncStateMachine(typeof(_003CInstantiateTarget_003Ed__58))]
		private Task InstantiateTarget(string prefabAddress)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001010")]
		[Cpp2IlInjected.Address(RVA = "0x11C2880", Offset = "0x11C1280", VA = "0x1811C2880", Slot = "14")]
		protected unsafe virtual void Update()
		{
			//IL_0012: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0069: Expected F4, but got I4
			//IL_0069: Expected F4, but got I4
			//IL_0069: Expected F4, but got I4
			//IL_0258: Expected O, but got I4
			//IL_0269: Expected O, but got I4
			//IL_027a: Expected O, but got I4
			//IL_028b: Expected O, but got I4
			//IL_029c: Expected O, but got I4
			//IL_02ad: Expected O, but got I4
			//IL_02be: Expected O, but got I4
			//IL_02ef: Expected O, but got I4
			//IL_0303: Expected O, but got I4
			//IL_0320: Expected native int or pointer, but got O
			RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
			RenderTargetIdentifier renderTargetIdentifier2 = default(RenderTargetIdentifier);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			RenderTargetIdentifier renderTargetIdentifier3 = default(RenderTargetIdentifier);
			RenderTargetIdentifier renderTargetIdentifier4 = default(RenderTargetIdentifier);
			RenderTargetIdentifier renderTargetIdentifier5 = default(RenderTargetIdentifier);
			RenderTargetIdentifier renderTargetIdentifier6 = default(RenderTargetIdentifier);
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			int num29 = default(int);
			while (true)
			{
				int num = 0;
				GameObject gameObject = TargetedObj;
				int num2 = 0;
				if (gameObject == (UnityEngine.Object)num2)
				{
					continue;
				}
				RenderTexture renderTexture = rt;
				int num3 = 0;
				int num4 = 0;
				if (renderTexture == (UnityEngine.Object)num4)
				{
					continue;
				}
				if ((_rotationEnabled ? 1 : 0) != num && (_isAnimating ? 1 : 0) == num)
				{
					Transform transform = TargetedObj.transform;
					int num5 = 0;
					float deltaTime = Time.deltaTime;
					int num6 = 0;
					int num7 = 0;
					transform.Rotate(num7, num3, num6);
				}
				CommandBuffer commandBuffer = CommandBufferPool.Get("RenderItemPreview");
				commandBuffer.EnableShaderKeyword("_RECEIVE_SHADOWS_OFF");
				commandBuffer.DisableShaderKeyword("_ADDITIONAL_LIGHTS");
				commandBuffer.DisableShaderKeyword("_SCREEN_SPACE_OCCLUSION");
				commandBuffer.DisableShaderKeyword("CUSTOM_FOG");
				Vector4 value = screenParams;
				commandBuffer.SetGlobalVector("_ScreenParams", value);
				Vector4 value2 = zBufferParams;
				commandBuffer.SetGlobalVector("_ZBufferParams", value2);
				Vector4 value3 = projectionParams;
				commandBuffer.SetGlobalVector("_ProjectionParams", value3);
				Matrix4x4 matrix4x = projectionMatrix;
				float m = projectionMatrix.m01;
				float m2 = projectionMatrix.m02;
				float m3 = projectionMatrix.m03;
				Matrix4x4 value4 = worldToCameraMatrix;
				float m4 = worldToCameraMatrix.m01;
				float m5 = worldToCameraMatrix.m02;
				float m6 = worldToCameraMatrix.m03;
				commandBuffer.SetGlobalMatrix("unity_WorldToCamera", value4);
				Matrix4x4 value5 = cameraToWorldMatrix;
				float m7 = cameraToWorldMatrix.m01;
				float m8 = cameraToWorldMatrix.m02;
				float m9 = cameraToWorldMatrix.m03;
				commandBuffer.SetGlobalMatrix("unity_CameraToWorld", value5);
				Matrix4x4 value6 = inverseViewMatrix;
				float m10 = inverseViewMatrix.m01;
				float m11 = inverseViewMatrix.m02;
				float m12 = inverseViewMatrix.m03;
				commandBuffer.SetGlobalMatrix("unity_MatrixInvV", value6);
				Matrix4x4 value7 = inverseProjectionMatrix;
				float m13 = inverseProjectionMatrix.m01;
				float m14 = inverseProjectionMatrix.m02;
				float m15 = inverseProjectionMatrix.m03;
				commandBuffer.SetGlobalMatrix("unity_MatrixInvP", value7);
				Matrix4x4 value8 = inverseViewProjection;
				float m16 = inverseViewProjection.m01;
				float m17 = inverseViewProjection.m02;
				float m18 = inverseViewProjection.m03;
				commandBuffer.SetGlobalMatrix("unity_MatrixInvVP", value8);
				int num8 = 0;
				commandBuffer.SetGlobalVector("unity_SHAr", (Vector4)num8);
				int num9 = 0;
				commandBuffer.SetGlobalVector("unity_SHAg", (Vector4)num9);
				int num10 = 0;
				commandBuffer.SetGlobalVector("unity_SHAb", (Vector4)num10);
				int num11 = 0;
				commandBuffer.SetGlobalVector("unity_SHBr", (Vector4)num11);
				int num12 = 0;
				commandBuffer.SetGlobalVector("unity_SHBg", (Vector4)num12);
				int num13 = 0;
				commandBuffer.SetGlobalVector("unity_SHBb", (Vector4)num13);
				int num14 = 0;
				commandBuffer.SetGlobalVector("unity_SHC", (Vector4)num14);
				int num15 = 0;
				int num16 = 0;
				int num17 = 0;
				int num18 = 0;
				int num19 = 0;
				int num20 = 0;
				int num21 = 0;
				int num22 = 0;
				int num23 = 0;
				Color color = directionalLightColor;
				commandBuffer.SetGlobalVector("_WorldSpaceCameraPos", (Vector4)num20);
				int num24 = 0;
				int num25 = 0;
				commandBuffer.SetGlobalVector("unity_LightData", (Vector4)num24);
				IntPtr bufferPointer = renderTargetIdentifier.m_BufferPointer;
				IntPtr bufferPointer2 = renderTargetIdentifier2.m_BufferPointer;
				((Color*)(IntPtr)backgroundColor)->a = 1f;
				Color color2 = backgroundColor;
				commandBuffer.ClearRenderTarget(clearDepth: true, clearColor: true, color2);
				List<Renderer> list = targetRenderers;
				if (flag)
				{
					while (flag2)
					{
					}
					if (flag3)
					{
					}
					num++;
				}
				int num26 = 0;
				if (num != 0)
				{
					continue;
				}
				int num27 = 0;
				Texture2D whiteTexture = Texture2D.whiteTexture;
				IntPtr bufferPointer3 = renderTargetIdentifier3.m_BufferPointer;
				IntPtr bufferPointer4 = renderTargetIdentifier4.m_BufferPointer;
				int num28 = 0;
				Mesh fullscreenMesh = RenderingUtils.fullscreenMesh;
				Matrix4x4 identity = Matrix4x4.identity;
				float m19 = identity.m01;
				float m20 = identity.m02;
				float m21 = identity.m03;
				IntPtr bufferPointer5 = renderTargetIdentifier5.m_BufferPointer;
				IntPtr bufferPointer6 = renderTargetIdentifier6.m_BufferPointer;
				if (flag4)
				{
					while (flag5)
					{
					}
					if (!flag6 || num29 > 2500)
					{
					}
					num26++;
				}
				if (num == 0)
				{
					/*Error: Could not find block for branch target IL_03dc*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001011")]
		[Cpp2IlInjected.Address(RVA = "0x11C3D30", Offset = "0x11C2730", VA = "0x1811C3D30")]
		public unsafe ItemPreview()
		{
			//IL_000f: Expected I4, but got I8
			//IL_001c: Expected I4, but got I8
			//IL_002e: Expected O, but got I4
			//IL_0059: Expected I4, but got I8
			//IL_007c: Expected I4, but got I8
			//IL_008f: Expected F4, but got I8
			//IL_008a: Expected native int or pointer, but got O
			int num = 0;
			Width = 600;
			Height = 600;
			cameraDistanceFactor = 0.5f;
			directionalLightColor = (Color)num;
			offsetFactor = 0.6f;
			heightDegrees = 25f;
			fieldOfView = 60f;
			_rotSpeed = 15;
			_initialScale = 0.5f;
			_targetScale = 1f;
			resolution = 1024;
			_rotationEnabled = true;
			ulong num2 = default(ulong);
			((Vector3*)(IntPtr)_targetRot)->z = (long)num2;
			targetRenderers = (List<Renderer>)(object)new List<T>();
			depthAttachmentID = Shader.PropertyToID("_CameraDepthAttachment");
			depthTextureID = Shader.PropertyToID("_CameraDepthTexture");
			opaqueTextureID = Shader.PropertyToID("_CameraOpaqueTexture");
			base._002Ector();
		}
	}
}
