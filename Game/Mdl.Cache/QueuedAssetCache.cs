using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Cache
{
	[Cpp2IlInjected.Token(Token = "0x200097F")]
	public abstract class QueuedAssetCache<Key, AssetType> : MonoBehaviour where Key : IEquatable<Key>
	{
		[Cpp2IlInjected.Token(Token = "0x2000980")]
		public delegate void AssetLoaded(AssetType asset);

		[Cpp2IlInjected.Token(Token = "0x2000981")]
		protected class CachedAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400346F")]
			public Key key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003470")]
			public AssetType asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003471")]
			public int refCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003472")]
			public Coroutine loading;

			[Cpp2IlInjected.Token(Token = "0x1400006B")]
			public event AssetLoaded OnCompleted
			{
				[Cpp2IlInjected.Token(Token = "0x6002C56")]
				[Cpp2IlInjected.Address(RVA = "0x1C6C740", Offset = "0x1C6B140", VA = "0x181C6C740")]
				[CompilerGenerated]
				add
				{
					QueuedAssetCache<, >.AssetLoaded onCompleted = (QueuedAssetCache<, >.AssetLoaded)(object)((QueuedAssetCache<, >.CachedAsset)(object)this).OnCompleted;
					Delegate @delegate = Delegate.Combine(onCompleted, value);
					if ((object)@delegate == null)
					{
					}
					if ((object)@delegate != null)
					{
						while ((object)@delegate != onCompleted)
						{
						}
						return;
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x6002C57")]
				[Cpp2IlInjected.Address(RVA = "0x1C6C800", Offset = "0x1C6B200", VA = "0x181C6C800")]
				[CompilerGenerated]
				remove
				{
					QueuedAssetCache<, >.AssetLoaded onCompleted = (QueuedAssetCache<, >.AssetLoaded)(object)((QueuedAssetCache<, >.CachedAsset)(object)this).OnCompleted;
					Delegate @delegate = Delegate.Remove(onCompleted, value);
					if ((object)@delegate == null)
					{
					}
					if ((object)@delegate != null)
					{
						while ((object)@delegate != onCompleted)
						{
						}
						return;
					}
					throw new InvalidCastException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002C58")]
			[Cpp2IlInjected.Address(RVA = "0x22BC4B0", Offset = "0x22BAEB0", VA = "0x1822BC4B0")]
			public void FinishLoading(AssetType asset)
			{
				((QueuedAssetCache<, >.CachedAsset)(object)this).asset = asset;
				((QueuedAssetCache<, >.CachedAsset)(object)this).OnCompleted?.Invoke(asset);
			}

			[Cpp2IlInjected.Token(Token = "0x6002C59")]
			[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
			public CachedAsset()
			{
			}//Discarded unreachable code: IL_0007

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400346A")]
		public int maxInCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400346B")]
		private List<CachedAsset> _queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400346C")]
		private Dictionary<Key, CachedAsset> _cache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400346D")]
		private List<Key> _zeroedOut;

		[Cpp2IlInjected.Token(Token = "0x6002C49")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract IEnumerator CreateAsset(CachedAsset cachedAsset);

		[Cpp2IlInjected.Token(Token = "0x6002C4A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void DestroyAsset(CachedAsset asset);

		[Cpp2IlInjected.Token(Token = "0x6002C4B")]
		[Cpp2IlInjected.Address(RVA = "0x2FCABD0", Offset = "0x2FC95D0", VA = "0x182FCABD0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0007
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C4C")]
		[Cpp2IlInjected.Address(RVA = "0x3C3AB70", Offset = "0x3C39570", VA = "0x183C3AB70")]
		public void Acquire(Key assetKey, AssetLoaded callback, bool reversePriority = false)
		{
			if (!reversePriority)
			{
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C4D")]
		[Cpp2IlInjected.Address(RVA = "0x3C3B0A0", Offset = "0x3C39AA0", VA = "0x183C3B0A0")]
		private void LoadNext()
		{
			//Discarded unreachable code: IL_0008
			int num = 0;
			int num2 = 0;
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C4E")]
		[Cpp2IlInjected.Address(RVA = "0x3C3B020", Offset = "0x3C39A20", VA = "0x183C3B020")]
		private void FinishLoading(AssetType asset)
		{
			//Discarded unreachable code: IL_000d
			int num = 0;
			int num2 = default(int);
			if (num2 > 0)
			{
				LoadNext();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C4F")]
		[Cpp2IlInjected.Address(RVA = "0x3C3B200", Offset = "0x3C39C00", VA = "0x183C3B200")]
		public void Release(Key assetKey, AssetLoaded unregisterCallback)
		{
			//Discarded unreachable code: IL_001a
			bool flag = default(bool);
			if (flag)
			{
				QueuedAssetCache<, >.CachedAsset cachedAsset = default(QueuedAssetCache<, >.CachedAsset);
				if (unregisterCallback != null)
				{
					((CachedAsset)(object)cachedAsset).remove_OnCompleted((QueuedAssetCache<, >.AssetLoaded)(object)unregisterCallback);
				}
				if (cachedAsset == null)
				{
					CleanupCache();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C50")]
		[Cpp2IlInjected.Address(RVA = "0x3C3AE20", Offset = "0x3C39820", VA = "0x183C3AE20")]
		private void CleanupCache()
		{
			//Discarded unreachable code: IL_001d
			int num = default(int);
			int num2 = default(int);
			if (num > 0 && num2 > 0)
			{
				int num3 = 0;
				QueuedAssetCache<, >.CachedAsset cachedAsset = default(QueuedAssetCache<, >.CachedAsset);
				if (cachedAsset != null)
				{
				}
				int num4 = default(int);
				while (num4 <= 0)
				{
				}
				int num5 = 0;
				LoadNext();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C51")]
		[Cpp2IlInjected.Address(RVA = "0x3C3B310", Offset = "0x3C39D10", VA = "0x183C3B310")]
		protected QueuedAssetCache()
		{
			Dictionary<, > dictionary = (Dictionary<, >)(object)new Dictionary<TKey, TValue>();
			List<> list = (List<>)(object)new List<T>();
			base._002Ector();
		}
	}
}
