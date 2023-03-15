using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x2000212")]
	public sealed class VFXPool : MonoBehaviour, IVFXPool, IComparer<VFXPoolSortIndex>
	{
		[Cpp2IlInjected.Token(Token = "0x2000213")]
		public class VFXPoolEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40011B8")]
			public Transform target;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40011B9")]
			public GameObject vfx;

			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public VFXPoolEntry()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40011AE")]
		[SerializeField]
		private GameObject prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40011AF")]
		[SerializeField]
		private float cullingDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40011B0")]
		[SerializeField]
		private int maxCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40011B1")]
		private GameObject poolRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40011B2")]
		private readonly List<VFXPoolEntry> targets = (List<VFXPoolEntry>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40011B3")]
		private readonly List<VFXPoolSortIndex> sortedTargets = (List<VFXPoolSortIndex>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40011B4")]
		private CullingGroup cullingGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40011B5")]
		private BoundingSphere[] boundingSpheres;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40011B6")]
		private int[] queryIndiceResult = new int[256];

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40011B7")]
		private int instanceCount;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		[field: Cpp2IlInjected.Token(Token = "0x40011AD")]
		public static int DistanceMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0xD42C00", Offset = "0xD41600", VA = "0x180D42C00")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60008D7")]
			[Cpp2IlInjected.Address(RVA = "0xD42C60", Offset = "0xD41660", VA = "0x180D42C60")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public GameObject Prefab
		{
			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "4")]
			get
			{
				return prefab;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0xD42170", Offset = "0xD40B70", VA = "0x180D42170", Slot = "5")]
		public void RequestEffect(Transform parent)
		{
			//Discarded unreachable code: IL_00c9
			List<VFXPoolEntry> list = targets;
			VFXPoolEntry vFXPoolEntry = new VFXPoolEntry();
			vFXPoolEntry.target = parent;
			((List<T>)(object)list).Add((T)vFXPoolEntry);
			BoundingSphere[] array = boundingSpheres;
			List<VFXPoolEntry> list2 = targets;
			int size = ((List<>)(object)list2)._size;
			if (array.Length < size)
			{
				size += 256;
				BoundingSphere[] array2 = boundingSpheres;
				CullingGroup cullingGroup = this.cullingGroup;
				BoundingSphere[] array3 = boundingSpheres;
				cullingGroup.SetBoundingSpheres(array3);
			}
			int num = ((List<>)(object)list2)._size - 1;
			num += 2;
			num += num;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			List<VFXPoolEntry> list3 = targets;
			BoundingSphere[] array4 = boundingSpheres;
			int size2 = ((List<>)(object)list3)._size;
			size2 += size2;
			List<VFXPoolEntry> list4 = targets;
			CullingGroup cullingGroup2 = this.cullingGroup;
			int size3 = ((List<>)(object)list4)._size;
			cullingGroup2.SetBoundingSphereCount(size3);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xD41E30", Offset = "0xD40830", VA = "0x180D41E30", Slot = "6")]
		public void EndEffect(Transform parent)
		{
			//Discarded unreachable code: IL_009c
			List<VFXPoolEntry> list = targets;
			Predicate<VFXPoolEntry> predicate = (Predicate<VFXPoolEntry>)(object)(Predicate<T>)delegate(VFXPoolEntry x)
			{
				//Discarded unreachable code: IL_0016
				Transform target = x.target;
				Transform transform = parent;
				return target == transform;
			};
			int num = ((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate);
			MoveVFXToPool(num);
			List<VFXPoolEntry> list2 = targets;
			VFXPoolEntry vFXPoolEntry = (VFXPoolEntry)(((List<T>)(object)list2)[num] = (T)((IEnumerable<>)list2).Last<VFXPoolEntry>());
			List<VFXPoolEntry> list3 = targets;
			int size = ((List<>)(object)list3)._size;
			((List<T>)(object)list3).RemoveAt(size);
			CullingGroup cullingGroup = this.cullingGroup;
			size = num;
			cullingGroup.EraseSwapBack(size);
			List<VFXPoolEntry> list4 = targets;
			CullingGroup cullingGroup2 = this.cullingGroup;
			int size2 = ((List<>)(object)list4)._size;
			cullingGroup2.SetBoundingSphereCount(size2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0xD41C00", Offset = "0xD40600", VA = "0x180D41C00")]
		private void Awake()
		{
			//Discarded unreachable code: IL_00d4
			//IL_00d3: Expected O, but got I4
			GameObject gameObject = (poolRoot = new GameObject("pool"));
			GameObject gameObject2 = poolRoot;
			int active = 0;
			gameObject2.SetActive((byte)active != 0);
			Transform transform = poolRoot.transform;
			Transform transform3 = (transform.parent = base.gameObject.transform);
			BoundingSphere[] array = (boundingSpheres = new BoundingSphere[256]);
			CullingGroup cullingGroup = (this.cullingGroup = new CullingGroup());
			CullingGroup cullingGroup2 = this.cullingGroup;
			BoundingSphere[] array2 = boundingSpheres;
			cullingGroup2.SetBoundingSpheres(array2);
			CullingGroup cullingGroup3 = this.cullingGroup;
			int boundingSphereCount = 0;
			cullingGroup3.SetBoundingSphereCount(boundingSphereCount);
			CullingGroup cullingGroup4 = this.cullingGroup;
			CullingGroup.StateChanged onStateChanged = cullingGroup4.onStateChanged;
			CullingGroup.StateChanged b = OnStateChanged;
			Delegate @delegate = Delegate.Combine(onStateChanged, b);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				cullingGroup4.onStateChanged = (CullingGroup.StateChanged)num;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xD420F0", Offset = "0xD40AF0", VA = "0x180D420F0")]
		private void OnStateChanged(CullingGroupEvent sphere)
		{
			bool flag = default(bool);
			int num = default(int);
			int num2 = default(int);
			int num3 = default(int);
			if (flag || (num != num2 && num3 != 0))
			{
				MoveVFXToPool(flag ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xD42380", Offset = "0xD40D80", VA = "0x180D42380")]
		private void Start()
		{
			//Discarded unreachable code: IL_006a
			//IL_002b: Expected F4, but got I8
			//IL_0069: Expected F4, but got I4
			CullingGroup cullingGroup = this.cullingGroup;
			float[] array = new float[2];
			int length = array.Length;
			float num = default(float);
			array[0] = num;
			array[0] = 2.139095E+09f;
			cullingGroup.SetBoundingDistances(array);
			CullingGroup cullingGroup2 = this.cullingGroup;
			Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
			cullingGroup2.SetDistanceReferencePoint_InternalTransform(_003Ctransform_003Ek__BackingField);
			int num2 = 0;
			InvokeRepeating("UpdateTargets", num2, 0.25f);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0xD41E10", Offset = "0xD40810", VA = "0x180D41E10")]
		public void Destroy()
		{
			//Discarded unreachable code: IL_000c
			cullingGroup.Dispose();
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0xD425B0", Offset = "0xD40FB0", VA = "0x180D425B0")]
		private unsafe bool TryGetVFXInstance(out GameObject vfx)
		{
			//IL_0027: Expected O, but got Ref
			int childCount = poolRoot.transform.childCount;
			int num = instanceCount;
			int num2 = maxCount;
			int num3 = 0;
			Transform transform = ((GameObject)System.Runtime.CompilerServices.Unsafe.AsPointer(ref vfx)).transform;
			int index = 0;
			Transform transform2 = default(Transform);
			GameObject gameObject = transform2.GetChild(index).gameObject;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0xD41990", Offset = "0xD40390", VA = "0x180D41990")]
		private bool AttachVFXToTarget(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0xD41FF0", Offset = "0xD409F0", VA = "0x180D41FF0")]
		private void MoveVFXToPool(int index)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xD42770", Offset = "0xD41170", VA = "0x180D42770")]
		private void UpdateTargets()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xD425A0", Offset = "0xD40FA0", VA = "0x180D425A0", Slot = "7")]
		int IComparer<VFXPoolSortIndex>.Compare(VFXPoolSortIndex x, VFXPoolSortIndex y)
		{
			return x.index;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0xD42B10", Offset = "0xD41510", VA = "0x180D42B10")]
		public VFXPool()
		{
		}
	}
}
