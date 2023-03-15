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
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[RequireComponent(typeof(Image))]
	internal class AsyncImage : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200017C")]
		public delegate void ImageLoaded(AsyncImage image);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public Color startColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		public Color loadedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private bool _acquired;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private Sprite _currentSprite;

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public Image Image
		{
			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0x882210", Offset = "0x880C10", VA = "0x180882210")]
			get
			{
				return GetComponent<Image>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000950")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CKey_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CKey_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public Sprite CurrentSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000952")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return _currentSprite;
			}
			[Cpp2IlInjected.Token(Token = "0x6000953")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			set
			{
				_currentSprite = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event ImageLoaded OnImageLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000954")]
			[Cpp2IlInjected.Address(RVA = "0x882170", Offset = "0x880B70", VA = "0x180882170")]
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
			[Cpp2IlInjected.Token(Token = "0x6000955")]
			[Cpp2IlInjected.Address(RVA = "0x882250", Offset = "0x880C50", VA = "0x180882250")]
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

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x881C10", Offset = "0x880610", VA = "0x180881C10")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0095
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			Sprite currentSprite = _currentSprite;
			int num = 0;
			if (!(currentSprite == (UnityEngine.Object)num))
			{
				Sprite sprite = (_currentSprite = _currentSprite);
				int num2 = 0;
				if (!(sprite != (UnityEngine.Object)num2))
				{
					Release();
				}
				Image component = GetComponent<Image>();
				Sprite sprite2 = (component.sprite = _currentSprite);
				Image component2 = GetComponent<Image>();
				Color color2 = (component2.color = loadedColor);
				this.OnImageLoaded?.Invoke(this);
			}
			else
			{
				Image component3 = GetComponent<Image>();
				Color color4 = (component3.color = startColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x881E10", Offset = "0x880810", VA = "0x180881E10")]
		private void OnDestroy()
		{
			Release();
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x881E20", Offset = "0x880820", VA = "0x180881E20")]
		private void OnEnable()
		{
			Acquire();
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x881E10", Offset = "0x880810", VA = "0x180881E10")]
		private void OnDisable()
		{
			Release();
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x881FB0", Offset = "0x8809B0", VA = "0x180881FB0")]
		public void SetSpriteKey(string key)
		{
			Release();
			Key = key;
			Acquire();
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x881A70", Offset = "0x880470", VA = "0x180881A70")]
		private void Acquire()
		{
			//IL_0049: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			if ((long)Key != 0 && !_acquired)
			{
				int num = 0;
				_acquired = true;
				SpriteCache spriteCache = UiRoot.Instance._spriteCache;
				string text = Key;
				AssetCache<string, Sprite>.AssetLoaded assetLoaded = (AssetCache<string, Sprite>.AssetLoaded)(object)new AssetCache<Key, AssetType>.AssetLoaded(UpdateSprite);
				int num2 = 0;
				((AssetCache<Key, AssetType>)(object)spriteCache).Acquire((Key)text, (AssetCache<, >.AssetLoaded)(object)assetLoaded, (AssetReference)num2);
				return;
			}
			Image component = GetComponent<Image>();
			Sprite currentSprite = _currentSprite;
			int num3 = 0;
			if (currentSprite == (UnityEngine.Object)num3)
			{
			}
			Color color2 = (component.color = loadedColor);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x881E30", Offset = "0x880830", VA = "0x180881E30")]
		internal void Release()
		{
			//Discarded unreachable code: IL_0072
			//IL_0058: Expected O, but got I4
			if ((long)Key != 0 && _acquired)
			{
				int num = 0;
				SpriteCache spriteCache = UiRoot.Instance._spriteCache;
				string text = Key;
				AssetCache<string, Sprite>.AssetLoaded assetLoaded = (AssetCache<string, Sprite>.AssetLoaded)(object)new AssetCache<Key, AssetType>.AssetLoaded(UpdateSprite);
				((AssetCache<Key, AssetType>)(object)spriteCache).Release((Key)text, (AssetCache<, >.AssetLoaded)(object)assetLoaded);
				_acquired = false;
			}
			Image component = GetComponent<Image>();
			int num2 = 0;
			component.sprite = (Sprite)num2;
			Image component2 = GetComponent<Image>();
			Color color2 = (component2.color = startColor);
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x881FF0", Offset = "0x8809F0", VA = "0x180881FF0")]
		private void UpdateSprite(Sprite sprite)
		{
			//Discarded unreachable code: IL_005b
			//IL_0010: Expected O, but got I4
			_currentSprite = sprite;
			int num = 0;
			if (!(sprite != (UnityEngine.Object)num))
			{
				Release();
			}
			Image component = GetComponent<Image>();
			Sprite sprite2 = (component.sprite = _currentSprite);
			Image component2 = GetComponent<Image>();
			Color color2 = (component2.color = loadedColor);
			this.OnImageLoaded?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x882130", Offset = "0x880B30", VA = "0x180882130")]
		public AsyncImage()
		{
			Color white = Color.white;
			base._002Ector();
		}
	}
}
