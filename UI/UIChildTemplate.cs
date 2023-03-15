using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class UIChildTemplate
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public GameObject Target;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public Transform Parent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public int ID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public string Name;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public bool IsEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public Vector3 Position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public Vector3 Rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Vector3 Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public Vector2 SizeDelta;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public Vector2 Pivot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Vector2 AnchorMin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public Vector2 AnchorMax;

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0xC94C10", Offset = "0xC93610", VA = "0x180C94C10")]
	private void Load(RectTransform rt)
	{
		//Discarded unreachable code: IL_0025
		float z = Position.z;
		float z2 = Rotation.z;
		float z3 = Scale.z;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0xC94D30", Offset = "0xC93730", VA = "0x180C94D30", Slot = "4")]
	public virtual void Load(GameObject gameObject)
	{
		//Discarded unreachable code: IL_00bc
		//IL_003d: Expected O, but got I4
		string name = Name;
		if ((object)typeof(RectTransform).TypeHandle == null)
		{
			string text = (gameObject.name = Name);
		}
		bool isEnabled = IsEnabled;
		gameObject.SetActive(isEnabled);
		Transform parent = Parent;
		int num = 0;
		if (parent != (UnityEngine.Object)num)
		{
			Transform parent2 = Parent;
			Transform parent3 = gameObject.transform.parent;
			if (parent2 != parent3)
			{
				Transform transform = gameObject.transform;
				Transform transform2 = (transform.parentInternal = Parent);
			}
		}
		Transform transform3 = gameObject.transform;
		if ((object)transform3 != null && (object)transform3 != null)
		{
			Transform transform4 = gameObject.transform;
			float z = Position.z;
			float z2 = Rotation.z;
			float z3 = Scale.z;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0xC951E0", Offset = "0xC93BE0", VA = "0x180C951E0")]
	private unsafe void Save(RectTransform rt)
	{
		//Discarded unreachable code: IL_00af
		//IL_000e: Expected native int or pointer, but got O
		//IL_0023: Expected native int or pointer, but got O
		//IL_0039: Expected native int or pointer, but got O
		//IL_005a: Expected F4, but got I4
		//IL_0055: Expected native int or pointer, but got O
		//IL_0076: Expected F4, but got I4
		//IL_0071: Expected native int or pointer, but got O
		//IL_0092: Expected F4, but got I4
		//IL_008d: Expected native int or pointer, but got O
		//IL_00ae: Expected F4, but got I4
		//IL_00a9: Expected native int or pointer, but got O
		Vector3 vector = default(Vector3);
		float z = vector.z;
		((Vector3*)(IntPtr)Position)->z = z;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		((Vector3*)(IntPtr)Rotation)->z = z2;
		Vector3 vector3 = default(Vector3);
		float z3 = vector3.z;
		((Vector3*)(IntPtr)Scale)->z = z3;
		Vector2 vector4 = (SizeDelta = rt.sizeDelta);
		((Vector2*)(IntPtr)SizeDelta)->y = 0f;
		Vector2 vector5 = (Pivot = rt.pivot);
		((Vector2*)(IntPtr)Pivot)->y = 0f;
		Vector2 vector6 = (AnchorMin = rt.anchorMin);
		((Vector2*)(IntPtr)AnchorMin)->y = 0f;
		Vector2 vector7 = (AnchorMax = rt.anchorMax);
		((Vector2*)(IntPtr)AnchorMax)->y = 0f;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0xC94FD0", Offset = "0xC939D0", VA = "0x180C94FD0", Slot = "5")]
	public unsafe virtual void Save(GameObject gameObject)
	{
		//Discarded unreachable code: IL_00e3
		//IL_0061: Expected native int or pointer, but got O
		//IL_0077: Expected native int or pointer, but got O
		//IL_008d: Expected native int or pointer, but got O
		//IL_00a6: Expected F4, but got I4
		//IL_00a1: Expected native int or pointer, but got O
		//IL_00ba: Expected F4, but got I4
		//IL_00b5: Expected native int or pointer, but got O
		//IL_00ce: Expected F4, but got I4
		//IL_00c9: Expected native int or pointer, but got O
		//IL_00e2: Expected F4, but got I4
		//IL_00dd: Expected native int or pointer, but got O
		string text = (Name = gameObject.name);
		bool flag = (IsEnabled = gameObject.activeSelf);
		Transform transform = (Parent = gameObject.transform.parent);
		Transform transform2 = gameObject.transform;
		if ((object)transform2 == null)
		{
			return;
		}
		int num = 0;
		if ((object)transform2 != null)
		{
			if ((object)gameObject.transform != null)
			{
			}
			Vector3 vector = default(Vector3);
			float z = vector.z;
			((Vector3*)(IntPtr)Position)->z = z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			((Vector3*)(IntPtr)Rotation)->z = z2;
			Vector3 vector3 = default(Vector3);
			float z3 = vector3.z;
			((Vector3*)(IntPtr)Scale)->z = z3;
			Vector2 sizeDelta = default(Vector2);
			SizeDelta = sizeDelta;
			((Vector2*)(IntPtr)SizeDelta)->y = 0f;
			Vector2 pivot = default(Vector2);
			Pivot = pivot;
			((Vector2*)(IntPtr)Pivot)->y = 0f;
			Vector2 anchorMin = default(Vector2);
			AnchorMin = anchorMin;
			((Vector2*)(IntPtr)AnchorMin)->y = 0f;
			Vector2 anchorMax = default(Vector2);
			AnchorMax = anchorMax;
			((Vector2*)(IntPtr)AnchorMax)->y = 0f;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0xC94B00", Offset = "0xC93500", VA = "0x180C94B00", Slot = "6")]
	public virtual UIChildTemplate Clone()
	{
		ConstructorInfo constructorInfo = GetType().GetConstructors()[0];
		object obj = default(object);
		if (obj == null)
		{
		}
		int num = 0;
		GameObject target = Target;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0xC95320", Offset = "0xC93D20", VA = "0x180C95320")]
	public unsafe UIChildTemplate()
	{
		//IL_0012: Expected native int or pointer, but got O
		//IL_002d: Expected native int or pointer, but got O
		//IL_0050: Expected F4, but got I4
		//IL_004b: Expected native int or pointer, but got O
		//IL_005d: Expected O, but got I8
		//IL_0068: Expected native int or pointer, but got O
		//IL_008b: Expected F4, but got I4
		//IL_0086: Expected native int or pointer, but got O
		//IL_00a6: Expected F4, but got I4
		//IL_00a1: Expected native int or pointer, but got O
		float z = Vector3.zero.z;
		((Vector3*)(IntPtr)Rotation)->z = z;
		Vector3 one = Vector3.one;
		int num = 0;
		float z2 = one.z;
		((Vector3*)(IntPtr)Scale)->z = z2;
		Vector2 zero = Vector2.zero;
		int num2 = 0;
		SizeDelta = zero;
		((Vector2*)(IntPtr)SizeDelta)->y = 0f;
		Pivot = (Vector2)1056964608;
		((Vector2*)(IntPtr)Pivot)->y = 0.5f;
		Vector2 zero2 = Vector2.zero;
		int num3 = 0;
		AnchorMin = zero2;
		((Vector2*)(IntPtr)AnchorMin)->y = 0f;
		AnchorMax = Vector2.zero;
		((Vector2*)(IntPtr)AnchorMax)->y = 0f;
		base._002Ector();
	}
}
