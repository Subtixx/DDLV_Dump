using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000865")]
	public class RecycleBin : MonoBehaviour, ISupportsRecycling
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400312D")]
		[NotNull]
		[SerializeField]
		private Transform _trashBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400312E")]
		[SerializeField]
		private GameObject[] _prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400312F")]
		[SerializeField]
		private int _size = -1;

		[Cpp2IlInjected.Token(Token = "0x17000783")]
		public Transform TrashBin
		{
			[Cpp2IlInjected.Token(Token = "0x6003515")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "4")]
			get
			{
				return _trashBin;
			}
			[Cpp2IlInjected.Token(Token = "0x6003516")]
			[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003517")]
		[Cpp2IlInjected.Address(RVA = "0xF40640", Offset = "0xF3F040", VA = "0x180F40640", Slot = "8")]
		public void Clear()
		{
			//Discarded unreachable code: IL_0060, IL_006c, IL_0072
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			List<Transform> list = (List<Transform>)(object)new List<T>();
			IEnumerator enumerator = _trashBin.GetEnumerator();
			int num5 = default(int);
			if (enumerator != null)
			{
				uint num4 = default(uint);
				if (num3 < (int)num4)
				{
					num3 += num3;
					num3++;
				}
				if (enumerator == null)
				{
					num3 += num3;
				}
				num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
			}
			if (num5 != 0)
			{
			}
			bool flag = default(bool);
			if (flag)
			{
				int num6 = 0;
				if (!Application.isPlaying)
				{
					GameObject obj = default(GameObject);
					UnityEngine.Object.DestroyImmediate(obj);
				}
				GameObject obj2 = default(GameObject);
				UnityEngine.Object.Destroy(obj2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003518")]
		[Cpp2IlInjected.Address(RVA = "0xF411E0", Offset = "0xF3FBE0", VA = "0x180F411E0", Slot = "9")]
		public GameObject FindReusable(Type type)
		{
			//Discarded unreachable code: IL_002b, IL_0031, IL_0037, IL_0049
			int num = 0;
			IEnumerator enumerator = _trashBin.GetEnumerator();
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
			}
			GameObject gameObject = default(GameObject);
			if ((object)gameObject != null)
			{
			}
			return gameObject;
		}

		[Cpp2IlInjected.Token(Token = "0x6003519")]
		[Cpp2IlInjected.Address(RVA = "0xF40F40", Offset = "0xF3F940", VA = "0x180F40F40")]
		public GameObject FindReusable(string AssetGUID)
		{
			//Discarded unreachable code: IL_003c, IL_0042, IL_0048, IL_004e, IL_0060
			int num = 0;
			IEnumerator enumerator = _trashBin.GetEnumerator();
			if (enumerator != null)
			{
				Type typeFromHandle = typeof(IHasAsssetGUID);
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
				while (!flag)
				{
				}
			}
			GameObject gameObject = default(GameObject);
			if ((object)gameObject != null)
			{
			}
			return gameObject;
		}

		[Cpp2IlInjected.Token(Token = "0x600351A")]
		[Cpp2IlInjected.Address(RVA = "0xF40B10", Offset = "0xF3F510", VA = "0x180F40B10")]
		public GameObject FindReusableOrNew(Type type, Transform container)
		{
			//Discarded unreachable code: IL_0079, IL_007f, IL_0085, IL_008b, IL_0091, IL_0097, IL_00a9
			//IL_002a: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			//IL_0069: Expected O, but got I4
			Transform transform = default(Transform);
			GameObject gameObject = default(GameObject);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			GameObject result = default(GameObject);
			while (true)
			{
				int num = 0;
				IEnumerator enumerator = _trashBin.GetEnumerator();
				if (enumerator != null)
				{
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					if (!((object)num.GetType()).Equals((object)type))
					{
						continue;
					}
					transform = gameObject.transform;
				}
				int num4 = 0;
				if ((object)transform != null)
				{
				}
				int num5 = 0;
				if (gameObject == (UnityEngine.Object)num5 && flag && num4 < (flag ? 1 : 0))
				{
					if (flag2)
					{
						Type type2 = num.GetType();
						if (flag3)
						{
							goto IL_0076;
						}
					}
					num4++;
				}
				goto IL_0076;
				IL_0076:
				return result;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600351B")]
		[Cpp2IlInjected.Address(RVA = "0xF413C0", Offset = "0xF3FDC0", VA = "0x180F413C0", Slot = "7")]
		public void Kill(GameObject trash)
		{
			//IL_0009: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			int num = 0;
			if (trash != (UnityEngine.Object)num)
			{
				SendToBin(trash);
				int num2 = 0;
				if (trash != (UnityEngine.Object)num2)
				{
					UnityEngine.Object.Destroy(trash);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600351C")]
		[Cpp2IlInjected.Address(RVA = "0xF41910", Offset = "0xF40310", VA = "0x180F41910", Slot = "6")]
		public void SendToBin(GameObject trash)
		{
			//Discarded unreachable code: IL_0078
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(trash != (UnityEngine.Object)num))
			{
				return;
			}
			int active = 0;
			trash.SetActive((byte)active != 0);
			if (_size > 0)
			{
				int childCount = _trashBin.childCount;
				childCount++;
				if (childCount > _size)
				{
					Transform transform = trash.transform;
					Transform transform2 = (transform.parentInternal = trash.transform.root);
					int num2 = 0;
					if (!Application.isPlaying)
					{
						UnityEngine.Object.DestroyImmediate(trash);
					}
					return;
				}
			}
			Transform transform3 = default(Transform);
			Transform transform4 = (transform3.parentInternal = _trashBin);
		}

		[Cpp2IlInjected.Token(Token = "0x600351D")]
		[Cpp2IlInjected.Address(RVA = "0xF41490", Offset = "0xF3FE90", VA = "0x180F41490")]
		public void SendChildrenToBin(Transform container, Type type)
		{
			//Discarded unreachable code: IL_0070, IL_0076, IL_0082, IL_0088, IL_008e, IL_0094
			//IL_000f: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			if (!(container != (UnityEngine.Object)num4))
			{
				return;
			}
			List<Transform> list = (List<Transform>)(object)new List<T>();
			IEnumerator enumerator = container.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				uint num5 = default(uint);
				if (num < (int)num5)
				{
					num += num;
					num++;
				}
				int num6 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				while (!flag)
				{
				}
			}
			if (flag)
			{
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				int active = 0;
				GameObject gameObject = default(GameObject);
				gameObject.SetActive((byte)active != 0);
				int num7 = 0;
				if (!Application.isPlaying)
				{
					GameObject obj = default(GameObject);
					UnityEngine.Object.DestroyImmediate(obj);
				}
				GameObject obj2 = default(GameObject);
				UnityEngine.Object.Destroy(obj2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600351E")]
		[Cpp2IlInjected.Address(RVA = "0xF409E0", Offset = "0xF3F3E0", VA = "0x180F409E0", Slot = "10")]
		public void Delegate(ITrashSeeker trashSeeker, object param)
		{
		}//Discarded unreachable code: IL_0001


		[Cpp2IlInjected.Token(Token = "0x600351F")]
		[Cpp2IlInjected.Address(RVA = "0xF40A70", Offset = "0xF3F470", VA = "0x180F40A70", Slot = "11")]
		public void Delegate(ITrashSeeker trashSeeker, Transform container, object param)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003520")]
		[Cpp2IlInjected.Address(RVA = "0xF41A90", Offset = "0xF40490", VA = "0x180F41A90")]
		public RecycleBin()
		{
		}//IL_0010: Expected I4, but got I8

	}
}
