using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Cache
{
	[Cpp2IlInjected.Token(Token = "0x200097C")]
	public abstract class AssetCache<Key, AssetType> : MonoBehaviour where Key : IEquatable<Key>
	{
		[Cpp2IlInjected.Token(Token = "0x200097D")]
		public delegate void AssetLoaded(AssetType asset);

		[Cpp2IlInjected.Token(Token = "0x200097E")]
		protected class CachedAsset
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003464")]
			public Key key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003465")]
			public AssetReference assetReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003466")]
			public AssetType asset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003467")]
			public Coroutine loading;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003468")]
			private bool isFinished;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003469")]
			private int refCount;

			[Cpp2IlInjected.Token(Token = "0x1400006A")]
			public event AssetLoaded OnCompleted
			{
				[Cpp2IlInjected.Token(Token = "0x6002C40")]
				[Cpp2IlInjected.Address(RVA = "0x1C6C740", Offset = "0x1C6B140", VA = "0x181C6C740")]
				[CompilerGenerated]
				add
				{
					AssetCache<, >.AssetLoaded onCompleted = (AssetCache<, >.AssetLoaded)(object)((AssetCache<, >.CachedAsset)(object)this).OnCompleted;
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
				[Cpp2IlInjected.Token(Token = "0x6002C41")]
				[Cpp2IlInjected.Address(RVA = "0x1C6C800", Offset = "0x1C6B200", VA = "0x181C6C800")]
				[CompilerGenerated]
				remove
				{
					AssetCache<, >.AssetLoaded onCompleted = (AssetCache<, >.AssetLoaded)(object)((AssetCache<, >.CachedAsset)(object)this).OnCompleted;
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

			[Cpp2IlInjected.Token(Token = "0x6002C42")]
			[Cpp2IlInjected.Address(RVA = "0x18ECBA0", Offset = "0x18EB5A0", VA = "0x1818ECBA0")]
			public bool IsLoading()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6002C43")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
			public bool IsLoaded()
			{
				return ((AssetCache<, >.CachedAsset)(object)this).isFinished;
			}

			[Cpp2IlInjected.Token(Token = "0x6002C44")]
			[Cpp2IlInjected.Address(RVA = "0x22BC520", Offset = "0x22BAF20", VA = "0x1822BC520")]
			public void FinishLoading(AssetType asset)
			{
				((AssetCache<, >.CachedAsset)(object)this).asset = asset;
				AssetCache<, >.AssetLoaded onCompleted = (AssetCache<, >.AssetLoaded)(object)((AssetCache<, >.CachedAsset)(object)this).OnCompleted;
				((AssetCache<, >.CachedAsset)(object)this).isFinished = true;
				((AssetLoaded)(object)onCompleted)?.Invoke(asset);
			}

			[Cpp2IlInjected.Token(Token = "0x6002C45")]
			[Cpp2IlInjected.Address(RVA = "0x22BC4A0", Offset = "0x22BAEA0", VA = "0x1822BC4A0")]
			public bool AddRef()
			{
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6002C46")]
			[Cpp2IlInjected.Address(RVA = "0x22BC590", Offset = "0x22BAF90", VA = "0x1822BC590")]
			public bool Release()
			{
				int num = 0;
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6002C47")]
			[Cpp2IlInjected.Address(RVA = "0x22BC5B0", Offset = "0x22BAFB0", VA = "0x1822BC5B0", Slot = "3")]
			public override string ToString()
			{
				//Discarded unreachable code: IL_0084
				//IL_0045: Expected O, but got I4
				//IL_005e: Expected O, but got I4
				object[] array;
				AssetType val2;
				while (true)
				{
					array = new object[5];
					Key val = ((AssetCache<, >.CachedAsset)(object)this).key;
					if (val != null && array == null)
					{
						continue;
					}
					array[0] = val;
					if (array != null && array == null)
					{
						continue;
					}
					array[1] = array;
					bool flag = IsLoaded();
					if (flag && !flag)
					{
						continue;
					}
					array[2] = flag;
					bool flag2 = IsLoading();
					flag = flag2;
					if (!flag2 || flag2)
					{
						array[3] = flag;
						val2 = ((AssetCache<, >.CachedAsset)(object)this).asset;
						if (val2 == null || flag2)
						{
							break;
						}
					}
				}
				array[4] = val2;
				return string.Format("(key: {0}, rc: {1}, loaded: {2}, loading: {3}, asset: {4})", array);
			}

			[Cpp2IlInjected.Token(Token = "0x6002C48")]
			[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
			public CachedAsset()
			{
			}//Discarded unreachable code: IL_0007

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4003460")]
		[HideInInspector]
		public int maxInCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4003461")]
		private Dictionary<Key, CachedAsset> _cache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4003462")]
		private List<Key> _pendingCleanup;

		[Cpp2IlInjected.Token(Token = "0x6002C33")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract IEnumerator CreateAsset(CachedAsset cachedAsset);

		[Cpp2IlInjected.Token(Token = "0x6002C34")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void DestroyAsset(CachedAsset asset);

		[Cpp2IlInjected.Token(Token = "0x6002C35")]
		[Cpp2IlInjected.Address(RVA = "0x2FCABD0", Offset = "0x2FC95D0", VA = "0x182FCABD0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0007
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C36")]
		[Cpp2IlInjected.Address(RVA = "0x2FC9E10", Offset = "0x2FC8810", VA = "0x182FC9E10")]
		public unsafe void Acquire(Key assetKey, AssetLoaded callback, [Optional] AssetReference assetReference)
		{
			//Discarded unreachable code: IL_0016
			//IL_0015: Expected I8, but got O
			int num = 0;
			IEnumerator routine = default(IEnumerator);
			Coroutine coroutine = StartCoroutine(routine);
			if (coroutine == null)
			{
				ulong num2 = default(ulong);
				((ulong*)num2)->m_value = (ulong)(long)coroutine;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C37")]
		[Cpp2IlInjected.Address(RVA = "0x2FCABF0", Offset = "0x2FC95F0", VA = "0x182FCABF0")]
		public void Release(Key assetKey, AssetLoaded unregisterCallback)
		{
			//Discarded unreachable code: IL_000d
			bool flag = default(bool);
			if (flag)
			{
				if (unregisterCallback != null)
				{
				}
				bool flag2 = default(bool);
				if (!flag2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C38")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA0A0", Offset = "0x2FC8AA0", VA = "0x182FCA0A0")]
		public bool CleanupCache(int maxInCache)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002C39")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA730", Offset = "0x2FC9130", VA = "0x182FCA730")]
		[Conditional("DEBUG_ASSET_CACHE_VERBOSE")]
		protected static void Log(string message, [CallerMemberName] string memberName = "")
		{
			//Discarded unreachable code: IL_00e9
			string[] array;
			Type type = default(Type);
			Type type2 = default(Type);
			while (true)
			{
				array = new string[8];
				if ("AssetCache<" != null && "AssetCache<" == null)
				{
					continue;
				}
				array[0] = "AssetCache<";
				string text = type.Name;
				if (text != null && text == null)
				{
					continue;
				}
				array[1] = text;
				if (", " != null && ", " == null)
				{
					continue;
				}
				array[2] = ", ";
				string text2 = type2.Name;
				if (text2 != null && text2 == null)
				{
					continue;
				}
				array[3] = text2;
				if (">." != null && ">." == null)
				{
					continue;
				}
				array[4] = ">.";
				if (memberName != null && ">." == null)
				{
					continue;
				}
				array[5] = memberName;
				if (": " == null || ": " != null)
				{
					array[6] = ": ";
					if (message == null || ": " != null)
					{
						break;
					}
				}
			}
			array[7] = message;
			UnityEngine.Debug.Log(string.Concat(array));
		}

		[Cpp2IlInjected.Token(Token = "0x6002C3A")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA290", Offset = "0x2FC8C90", VA = "0x182FCA290")]
		[Conditional("DEBUG_ASSET_CACHE_VERBOSE")]
		protected static void LogError(string message, [CallerMemberName] string memberName = "")
		{
			//Discarded unreachable code: IL_00e9
			string[] array;
			Type type = default(Type);
			Type type2 = default(Type);
			while (true)
			{
				array = new string[8];
				if ("AssetCache<" != null && "AssetCache<" == null)
				{
					continue;
				}
				array[0] = "AssetCache<";
				string text = type.Name;
				if (text != null && text == null)
				{
					continue;
				}
				array[1] = text;
				if (", " != null && ", " == null)
				{
					continue;
				}
				array[2] = ", ";
				string text2 = type2.Name;
				if (text2 != null && text2 == null)
				{
					continue;
				}
				array[3] = text2;
				if (">." != null && ">." == null)
				{
					continue;
				}
				array[4] = ">.";
				if (memberName != null && ">." == null)
				{
					continue;
				}
				array[5] = memberName;
				if (": " == null || ": " != null)
				{
					array[6] = ": ";
					if (message == null || ": " != null)
					{
						break;
					}
				}
			}
			array[7] = message;
			UnityEngine.Debug.LogError(string.Concat(array));
		}

		[Cpp2IlInjected.Token(Token = "0x6002C3B")]
		[Cpp2IlInjected.Address(RVA = "0x2FCACD0", Offset = "0x2FC96D0", VA = "0x182FCACD0")]
		protected AssetCache()
		{
			Dictionary<, > dictionary = (Dictionary<, >)(object)new Dictionary<TKey, TValue>();
			List<> list = (List<>)(object)new List<T>();
			base._002Ector();
		}
	}
}
