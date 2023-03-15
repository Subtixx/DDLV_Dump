using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	internal class Pool
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private Stack<PoolObject> availableObjStack = (Stack<PoolObject>)(object)new Stack<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private GameObject rootObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		private PoolInflationType inflationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private string poolName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private int objectsInUse;

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		public GameObject Root
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return rootObj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0xE13FA0", Offset = "0xE129A0", VA = "0x180E13FA0")]
		public Pool(string poolName, GameObject poolObjectPrefab, GameObject rootPoolObj, int initialCount, PoolInflationType type)
		{
			//Discarded unreachable code: IL_00ab
			//IL_001c: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			int num = 0;
			if (!(poolObjectPrefab == (Object)num))
			{
				this.poolName = poolName;
				inflationType = PoolInflationType.INCREMENT;
				GameObject gameObject = (rootObj = new GameObject(poolName + "Pool"));
				Transform transform = rootObj.transform;
				Transform transform2 = rootPoolObj.transform;
				int worldPositionStays = 0;
				transform.SetParent(transform2, (byte)worldPositionStays != 0);
				GameObject gameObject2 = Object.Instantiate(poolObjectPrefab);
				PoolObject component = gameObject2.GetComponent<PoolObject>();
				int num2 = 0;
				if (component == (Object)num2)
				{
					PoolObject poolObject = gameObject2.AddComponent<PoolObject>();
				}
				component.poolName = poolName;
				AddObjectToPool(component);
				int initialCount2 = default(int);
				populatePool(initialCount2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0xE13CA0", Offset = "0xE126A0", VA = "0x180E13CA0")]
		private void AddObjectToPool(PoolObject po)
		{
			//Discarded unreachable code: IL_0061
			GameObject gameObject = po.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = po.gameObject;
			string text2 = (gameObject2.name = poolName);
			((Stack<T>)(object)availableObjStack).Push((T)po);
			po.isPooled = true;
			Transform transform = po.gameObject.transform;
			Transform transform2 = rootObj.transform;
			int worldPositionStays = 0;
			transform.SetParent(transform2, (byte)worldPositionStays != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0xE14210", Offset = "0xE12C10", VA = "0x180E14210")]
		private void populatePool(int initialCount)
		{
			//Discarded unreachable code: IL_0023
			int num = 0;
			if (initialCount > 0)
			{
				PoolObject po = Object.Instantiate((PoolObject)((Stack<T>)(object)availableObjStack).Peek());
				AddObjectToPool(po);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0xE13D90", Offset = "0xE12790", VA = "0x180E13D90")]
		public GameObject NextAvailableObject(bool autoActive)
		{
			//Discarded unreachable code: IL_0073
			//IL_0060: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			//IL_0070: Expected I4, but got I8
			Stack<PoolObject> stack = availableObjStack;
			int num = 0;
			int size = ((Stack<>)(object)stack)._size;
			PoolInflationType poolInflationType = inflationType;
			if (poolInflationType == PoolInflationType.INCREMENT)
			{
				goto IL_0040;
			}
			if (poolInflationType == PoolInflationType.DOUBLE)
			{
				int a = objectsInUse;
				int b = 0;
				int num2 = Mathf.Max(a, b);
				num2 += size;
				if (num2 > 0)
				{
					goto IL_0040;
				}
			}
			goto IL_0055;
			IL_0040:
			uint initialCount = default(uint);
			populatePool((int)initialCount);
			PoolObject poolObject = (PoolObject)((Stack<T>)(object)availableObjStack).Pop();
			goto IL_0055;
			IL_0055:
			int num3 = 0;
			GameObject gameObject = default(GameObject);
			if ((Object)num != (Object)num3 && autoActive)
			{
				ulong num4 = default(ulong);
				gameObject.SetActive((byte)num4 != 0);
			}
			return gameObject;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0xE13ED0", Offset = "0xE128D0", VA = "0x180E13ED0")]
		public void ReturnObjectToPool(PoolObject po)
		{
			//Discarded unreachable code: IL_0049
			string text = poolName;
			string value = po.poolName;
			if (!text.Equals(value))
			{
				string arg = poolName;
				string arg2 = po.poolName;
				Debug.LogError($"Trying to add object to incorrect pool {arg2} {arg}");
			}
			else
			{
				while (po.isPooled)
				{
				}
				AddObjectToPool(po);
			}
		}
	}
}
