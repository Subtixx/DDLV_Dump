using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Cache;
using Mdl.Ui.Cache;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[RequireComponent(typeof(RawImage))]
	public class AsyncAtlassedIcon : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000179")]
		public enum IconType
		{
			[Cpp2IlInjected.Token(Token = "0x400060D")]
			Tiny,
			[Cpp2IlInjected.Token(Token = "0x400060E")]
			Small,
			[Cpp2IlInjected.Token(Token = "0x400060F")]
			Big
		}

		[Cpp2IlInjected.Token(Token = "0x200017A")]
		public delegate void ImageLoaded(AsyncAtlassedIcon image);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		public AssetReferenceTexture AssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public bool ReleaseManually = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public IconType SizeType = IconType.Small;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public Color startColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public Color loadedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public UIGameColors.GameColorName ColorToApply;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public bool PreserveAspectRatio;

		[Cpp2IlInjected.FieldOffset(Offset = "0x56")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private bool _acquired;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private AtlassedIcon _currentData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private UIGameColors.GameColorName _originalColorToApply;

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public RawImage RawImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000937")]
			[Cpp2IlInjected.Address(RVA = "0x881980", Offset = "0x880380", VA = "0x180881980")]
			get
			{
				return GetComponent<RawImage>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000938")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CKey_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CKey_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x55"), Cpp2IlInjected.Token(Token = "0x4000607")]
		public bool IsLoading
		{
			[Cpp2IlInjected.Token(Token = "0x600093A")]
			[Cpp2IlInjected.Address(RVA = "0x881950", Offset = "0x880350", VA = "0x180881950")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600093B")]
			[Cpp2IlInjected.Address(RVA = "0x881A60", Offset = "0x880460", VA = "0x180881A60")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		private bool IsReady
		{
			[Cpp2IlInjected.Token(Token = "0x600093C")]
			[Cpp2IlInjected.Address(RVA = "0x881960", Offset = "0x880360", VA = "0x180881960")]
			get
			{
				if (!_acquired)
				{
					int num = 0;
				}
				return !IsLoading;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event ImageLoaded OnImageLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600093D")]
			[Cpp2IlInjected.Address(RVA = "0x8818B0", Offset = "0x8802B0", VA = "0x1808818B0")]
			[CompilerGenerated]
			add
			{
				ImageLoaded onImageLoaded = this.OnImageLoaded;
				Delegate @delegate = Delegate.Combine(onImageLoaded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onImageLoaded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600093E")]
			[Cpp2IlInjected.Address(RVA = "0x8819C0", Offset = "0x8803C0", VA = "0x1808819C0")]
			[CompilerGenerated]
			remove
			{
				ImageLoaded onImageLoaded = this.OnImageLoaded;
				Delegate @delegate = Delegate.Remove(onImageLoaded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onImageLoaded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x880E00", Offset = "0x87F800", VA = "0x180880E00")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0037
			AtlassedIcon currentData = _currentData;
			UIGameColors.GameColorName gameColorName = (_originalColorToApply = ColorToApply);
			if (currentData != null)
			{
				UpdateIcon(currentData);
				return;
			}
			RawImage component = GetComponent<RawImage>();
			Color color2 = (component.color = startColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x880EE0", Offset = "0x87F8E0", VA = "0x180880EE0")]
		private void OnDestroy()
		{
			Release();
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x880F10", Offset = "0x87F910", VA = "0x180880F10")]
		private void OnEnable()
		{
			Acquire();
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x880EF0", Offset = "0x87F8F0", VA = "0x180880EF0")]
		private void OnDisable()
		{
			UIGameColors.GameColorName gameColorName = (ColorToApply = _originalColorToApply);
			if (!ReleaseManually)
			{
				Release();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x881250", Offset = "0x87FC50", VA = "0x180881250")]
		public bool SetIcon(string key)
		{
			//IL_0039: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			if (key != null)
			{
				Release();
				Key = key;
				Acquire();
				if (_acquired)
				{
					return !IsLoading;
				}
			}
			else
			{
				Release();
				int num = 0;
				_currentData = (AtlassedIcon)num;
				Key = (string)num;
				AssetReference = (AssetReferenceTexture)num;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x8811A0", Offset = "0x87FBA0", VA = "0x1808811A0")]
		public void SetIconRef(AssetReferenceTexture reference)
		{
			//IL_0013: Expected O, but got I8
			//IL_002f: Expected O, but got I8
			//IL_0038: Expected O, but got I8
			if (reference != null)
			{
				Release();
				Key = (string)0;
				AssetReference = reference;
				Acquire();
			}
			Release();
			Key = (string)0;
			AssetReference = (AssetReferenceTexture)0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x880C40", Offset = "0x87F640", VA = "0x180880C40")]
		internal void Acquire()
		{
			bool flag = (IsLoading = !_acquired);
			if ((long)Key == 0)
			{
				AssetReferenceTexture assetReference = AssetReference;
				if (assetReference != null && assetReference.RuntimeKeyIsValid())
				{
					int num = 0;
					if (Application.isPlaying)
					{
						string text = (Key = AssetReference.RuntimeKey.ToString());
					}
				}
				if ((long)Key == 0)
				{
					return;
				}
			}
			if (_acquired)
			{
				return;
			}
			IconType sizeType = SizeType;
			_acquired = true;
			if (sizeType != 0)
			{
				switch (sizeType)
				{
				case IconType.Small:
				{
					int num2 = 0;
					IconAtlasCache iconAtlasCacheBig = UiRoot.Instance._iconAtlasCacheBig;
					string text2 = Key;
					AssetCache<string, AtlassedIcon>.AssetLoaded assetLoaded = (AssetCache<string, AtlassedIcon>.AssetLoaded)(object)new AssetCache<Key, AssetType>.AssetLoaded(UpdateIcon);
					AssetReferenceTexture assetReference2 = AssetReference;
					((AssetCache<Key, AssetType>)(object)iconAtlasCacheBig).Acquire((Key)text2, (AssetCache<, >.AssetLoaded)(object)assetLoaded, (AssetReference)assetReference2);
					return;
				}
				default:
					return;
				case IconType.Tiny:
					break;
				}
				int num3 = 0;
				UiRoot instance = UiRoot.Instance;
			}
			int num4 = 0;
			UiRoot instance2 = UiRoot.Instance;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x880F20", Offset = "0x87F920", VA = "0x180880F20")]
		public void RefreshColor()
		{
			//Discarded unreachable code: IL_001e
			if (ColorToApply != 0)
			{
				RawImage component = GetComponent<RawImage>();
				int num = 0;
				UIGameColors gameColors = UiRoot.Instance._gameColors;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x880FD0", Offset = "0x87F9D0", VA = "0x180880FD0")]
		public void Release()
		{
			//Discarded unreachable code: IL_009d
			//IL_0083: Expected O, but got I4
			if ((long)Key != 0 && _acquired)
			{
				IconType sizeType = SizeType;
				if (sizeType != 0)
				{
					if (sizeType != 0)
					{
						if (sizeType != IconType.Small)
						{
							goto IL_0068;
						}
						int num = 0;
						UiRoot instance = UiRoot.Instance;
					}
					int num2 = 0;
					UiRoot instance2 = UiRoot.Instance;
				}
				int num3 = 0;
				IconAtlasCache iconAtlasCacheTiny = UiRoot.Instance._iconAtlasCacheTiny;
				string text = Key;
				AssetCache<string, AtlassedIcon>.AssetLoaded assetLoaded = (AssetCache<string, AtlassedIcon>.AssetLoaded)(object)new AssetCache<Key, AssetType>.AssetLoaded(UpdateIcon);
				((AssetCache<Key, AssetType>)(object)iconAtlasCacheTiny).Release((Key)text, (AssetCache<, >.AssetLoaded)(object)assetLoaded);
				goto IL_0068;
			}
			goto IL_006f;
			IL_006f:
			RawImage component = GetComponent<RawImage>();
			int num4 = 0;
			component.texture = (Texture)num4;
			RawImage component2 = GetComponent<RawImage>();
			Color color2 = (component2.color = startColor);
			return;
			IL_0068:
			_acquired = false;
			goto IL_006f;
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x8812F0", Offset = "0x87FCF0", VA = "0x1808812F0")]
		private void UpdateIcon(AtlassedIcon data)
		{
			//Discarded unreachable code: IL_0132
			//IL_0010: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			//IL_0046: Expected O, but got I4
			//IL_00c9: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			GameObject gameObject = base.gameObject;
			int num = 0;
			if (gameObject == (UnityEngine.Object)num)
			{
				return;
			}
			RawImage component = GetComponent<RawImage>();
			int num2 = 0;
			if (component == (UnityEngine.Object)num2)
			{
				return;
			}
			_currentData = data;
			int num3 = 0;
			if (data != null)
			{
			}
			int num4 = 0;
			if (!((UnityEngine.Object)num3 != (UnityEngine.Object)num4))
			{
				Release();
			}
			RawImage component2 = GetComponent<RawImage>();
			Texture texture2 = (component2.texture = data.texture);
			RawImage component3 = GetComponent<RawImage>();
			RawImage component4 = GetComponent<RawImage>();
			if (ColorToApply != (UIGameColors.GameColorName)num3)
			{
				RawImage component5 = GetComponent<RawImage>();
				int num5 = 0;
				UIGameColors gameColors = UiRoot.Instance._gameColors;
			}
			IsLoading = (byte)num3 != 0;
			if ((PreserveAspectRatio ? 1 : 0) != num3)
			{
				Transform transform = base.gameObject.transform;
				if ((object)transform != null)
				{
				}
				int num6 = 0;
				if (transform != (UnityEngine.Object)num6)
				{
					Texture texture3 = RawImage.m_Texture;
					int num7 = 0;
					if (texture3 != (UnityEngine.Object)num7)
					{
						Transform transform2 = base.gameObject.transform;
						int width = RawImage.m_Texture.width;
						int height = RawImage.m_Texture.height;
						int num8 = 0;
					}
				}
			}
			this.OnImageLoaded?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x880E90", Offset = "0x87F890", VA = "0x180880E90")]
		internal void Dispose()
		{
			Release();
			IsLoading = false;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x881860", Offset = "0x880260", VA = "0x180881860")]
		public AsyncAtlassedIcon()
		{
			//IL_0010: Expected I4, but got I8
			Color white = Color.white;
			base._002Ector();
		}
	}
}
