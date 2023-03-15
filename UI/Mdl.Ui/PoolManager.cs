using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001D0")]
	public class PoolManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		[Tooltip("Prefab Source")]
		public LoopScrollPrefabSource prefabSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		private bool inited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		private Pool pool;

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0xE13670", Offset = "0xE12070", VA = "0x180E13670", Slot = "4")]
		public virtual GameObject GetObject(bool autoActive = true)
		{
			//Discarded unreachable code: IL_003c
			if (!inited)
			{
				LoopScrollPrefabSource loopScrollPrefabSource = prefabSource;
				int poolSize = loopScrollPrefabSource.poolSize;
				GameObject prefab = loopScrollPrefabSource.prefab;
				InitPool(prefab, poolSize);
				inited = true;
			}
			int autoCreate = 0;
			return GetObjectFromPool(autoActive, autoCreate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0xE13AB0", Offset = "0xE124B0", VA = "0x180E13AB0", Slot = "5")]
		public virtual void ReturnObject(Transform go)
		{
			//Discarded unreachable code: IL_0077
			//IL_002a: Expected O, but got I4
			if (go.GetComponent<IPoolObjectEventHandler>() != null)
			{
			}
			go.SendMessage("ScrollCellReturn", SendMessageOptions.DontRequireReceiver);
			PoolObject component = go.gameObject.GetComponent<PoolObject>();
			int num = 0;
			if (component == (UnityEngine.Object)num)
			{
				return;
			}
			Pool pool = this.pool;
			if (pool != null)
			{
				string poolName = pool.poolName;
				string poolName2 = component.poolName;
				if (!poolName.Equals(poolName2))
				{
					string poolName3 = pool.poolName;
					string poolName4 = component.poolName;
					Debug.LogError($"Trying to add object to incorrect pool {poolName4} {poolName3}");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0xE136E0", Offset = "0xE120E0", VA = "0x180E136E0")]
		public void InitPool(GameObject prefab, int size, PoolInflationType type = PoolInflationType.DOUBLE)
		{
			//IL_0022: Expected O, but got I4
			if ((long)this.pool == 0)
			{
				GameObject prefab2 = prefabSource.prefab;
				int num = 0;
				if (prefab2 == (UnityEngine.Object)num)
				{
					Debug.LogError("[ResourceManager] Invalide prefab in prefabSource");
					throw new NullReferenceException();
				}
				LoopScrollPrefabSource loopScrollPrefabSource = prefabSource;
				GameObject gameObject = base.gameObject;
				Pool pool = default(Pool);
				this.pool = pool;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0xE134F0", Offset = "0xE11EF0", VA = "0x180E134F0")]
		public GameObject GetObjectFromPool(bool autoActive = true, int autoCreate = 0)
		{
			//IL_0098: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00a8: Expected I4, but got I8
			Pool pool = this.pool;
			int num = 0;
			if (pool != null)
			{
				goto IL_0037;
			}
			if (autoCreate > 0)
			{
				GameObject prefab = prefabSource.prefab;
				int type = 0;
				InitPool(prefab, autoCreate, (PoolInflationType)type);
				if (this.pool != null)
				{
					goto IL_0037;
				}
			}
			goto IL_00a8;
			IL_00a8:
			throw new NullReferenceException();
			IL_0078:
			uint initialCount = default(uint);
			pool.populatePool((int)initialCount);
			PoolObject poolObject = (PoolObject)((Stack<T>)(object)pool.availableObjStack).Pop();
			goto IL_008d;
			IL_0037:
			int size = ((Stack<>)(object)pool.availableObjStack)._size;
			PoolInflationType inflationType = pool.inflationType;
			if (inflationType == PoolInflationType.INCREMENT)
			{
				goto IL_0078;
			}
			if (inflationType == PoolInflationType.DOUBLE)
			{
				int objectsInUse = pool.objectsInUse;
				int b = 0;
				int num2 = Mathf.Max(objectsInUse, b);
				num2 += size;
				if (num2 > 0)
				{
					goto IL_0078;
				}
			}
			goto IL_008d;
			IL_008d:
			int num3 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num3 && autoActive)
			{
				GameObject gameObject = default(GameObject);
				ulong num4 = default(ulong);
				gameObject.SetActive((byte)num4 != 0);
			}
			goto IL_00a8;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0xE13940", Offset = "0xE12340", VA = "0x180E13940")]
		public void ReturnObjectToPool(GameObject go)
		{
			//Discarded unreachable code: IL_005d
			//IL_0010: Expected O, but got I4
			PoolObject component = go.GetComponent<PoolObject>();
			int num = 0;
			if (component == (UnityEngine.Object)num)
			{
				return;
			}
			Pool pool = this.pool;
			if (pool != null)
			{
				string poolName = pool.poolName;
				string poolName2 = component.poolName;
				if (!poolName.Equals(poolName2))
				{
					string poolName3 = pool.poolName;
					string poolName4 = component.poolName;
					Debug.LogError($"Trying to add object to incorrect pool {poolName4} {poolName3}");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0xE13860", Offset = "0xE12260", VA = "0x180E13860")]
		public void Kill()
		{
			//Discarded unreachable code: IL_0049
			//IL_0025: Expected O, but got I4
			//IL_0048: Expected O, but got I8
			int num = 0;
			if (Application.isPlaying)
			{
				return;
			}
			Pool pool = this.pool;
			if (pool != null)
			{
				GameObject rootObj = pool.rootObj;
				int num2 = 0;
				if (rootObj != (UnityEngine.Object)num2)
				{
					UnityEngine.Object.DestroyImmediate(this.pool.rootObj);
				}
			}
			inited = false;
			this.pool = (Pool)0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PoolManager()
		{
		}
	}
}
