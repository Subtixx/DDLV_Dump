using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000038")]
public class HideObstructorsForCutscene : CameraModifier
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[SerializeField]
	private float sphereCastCollisionRadius = 0.01f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[SerializeField]
	private ItemType[] cullItemTypes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[SerializeField]
	private FurnitureItemType[] cullFurnitureTypes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private List<GameObject> culledObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private RaycastHitBuffer raycastHits;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x154E710", Offset = "0x154D110", VA = "0x18154E710")]
	public HideObstructorsForCutscene()
	{
		//Discarded unreachable code: IL_0058
		//IL_001c: Expected I4, but got I8
		//IL_0034: Expected I4, but got I8
		//IL_0051: Expected O, but got I4
		ItemType[] array = new ItemType[1];
		array[0] = ItemType.Building;
		cullItemTypes = array;
		FurnitureItemType[] array2 = new FurnitureItemType[1];
		array2[0] = FurnitureItemType.Landscaping;
		cullFurnitureTypes = array2;
		culledObjects = (List<GameObject>)(object)new List<T>();
		raycastHits = (RaycastHitBuffer)0;
		base._002Ector();
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x154E0F0", Offset = "0x154CAF0", VA = "0x18154E0F0")]
	public void OnDisable()
	{
		//Discarded unreachable code: IL_000c
		List<GameObject> list = culledObjects;
		bool flag = default(bool);
		if (!flag)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x154E210", Offset = "0x154CC10", VA = "0x18154E210")]
	public void Update()
	{
		//Discarded unreachable code: IL_00a4
		//IL_004b: Expected O, but got I4
		int num = 0;
		CameraCollisionSystem system = SystemRoot.Instance.GetSystem<CameraCollisionSystem>();
		Transform transform = base.Camera.transform;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		Transform transform2 = base.Camera.transform;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		GameObject gameObject = base.targetObject;
		int num2 = 0;
		if (gameObject != (UnityEngine.Object)num2)
		{
			Transform transform3 = base.targetObject.transform;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
		}
		Transform transform4 = base.Camera.transform;
		Vector3 vector4 = default(Vector3);
		float z4 = vector4.z;
		int num3 = 0;
		int num4 = default(int);
		if (num4 > 0)
		{
			Collider collider = default(Collider);
			GameObject gameObject2 = collider.gameObject;
			(bool, GameObject) tuple = default((bool, GameObject));
			bool flag = default(bool);
			if ((object)tuple != null && flag)
			{
				List<GameObject> list = culledObjects;
			}
			num3++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x154DEB0", Offset = "0x154C8B0", VA = "0x18154DEB0")]
	protected bool IsObjectInFrontOfTargetPlane(GameObject gameObject)
	{
		//Discarded unreachable code: IL_0036
		//IL_0010: Expected O, but got I4
		GameObject gameObject2 = base.targetObject;
		int num = 0;
		if (!(gameObject2 == (UnityEngine.Object)num))
		{
			Transform transform = base.Camera.transform;
			Transform transform2 = base.targetObject.transform;
			Transform transform3 = gameObject.transform;
		}
		return true;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x154DBC0", Offset = "0x154C5C0", VA = "0x18154DBC0", Slot = "6")]
	protected virtual (bool, GameObject) DoesObjectPassFilter(GameObject potentialObject)
	{
		//IL_001d: Expected O, but got I4
		//IL_002c: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		bool flag = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		if (!flag && !flag2 && flag3)
		{
			int num = 0;
			GridObjectScript gridObjectScript = default(GridObjectScript);
			if (!(gridObjectScript == (UnityEngine.Object)num))
			{
				int num2 = 0;
				ItemScript itemScript = default(ItemScript);
				if (!(itemScript == (UnityEngine.Object)num2))
				{
					Item item = itemScript.Item;
					ItemType itemType = default(ItemType);
					if (itemType != ItemType.Furniture)
					{
						Item item2 = itemScript.Item;
					}
					Item item3 = itemScript.Item;
					bool flag4 = default(bool);
					if (flag4)
					{
						int num3 = 0;
						if (!(itemScript.gameObject == (UnityEngine.Object)num3))
						{
							GameObject gameObject = itemScript.gameObject;
							bool flag5 = default(bool);
							if (!flag5)
							{
								GameObject gameObject2 = itemScript.gameObject;
							}
						}
					}
				}
			}
		}
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x154DAD0", Offset = "0x154C4D0", VA = "0x18154DAD0")]
	private bool DoesItemScriptPassFilter(ItemScript itemScript)
	{
		Item item = itemScript.Item;
		ItemType itemType = default(ItemType);
		if (itemType != ItemType.Furniture)
		{
			ItemType[] array = cullItemTypes;
			Item item2 = itemScript.Item;
			bool result = default(bool);
			return result;
		}
		Item item3 = itemScript.Item;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x10F5DB0", Offset = "0x10F47B0", VA = "0x1810F5DB0", Slot = "7")]
	protected virtual void StartCullFor(GameObject gameObject)
	{
		//Discarded unreachable code: IL_000a
		int active = 0;
		gameObject.SetActive((byte)active != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x10F5D80", Offset = "0x10F4780", VA = "0x1810F5D80", Slot = "8")]
	protected virtual void StopCullFor(GameObject gameObject)
	{
		//Discarded unreachable code: IL_0008
		gameObject.SetActive(value: true);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x154E070", Offset = "0x154CA70", VA = "0x18154E070")]
	[Conditional("DEBUG_HIDE_OBSTRUCTORS")]
	private void LogDebug(string message)
	{
		UnityEngine.Debug.Log("HideObstructorsForCutscene:  " + message);
	}
}
