using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000035")]
public class LookAtCamera : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private enum axis
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		X_Axis,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Y_Axis,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Z_Axis
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[SerializeField]
	private bool lockXAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[SerializeField]
	private bool lockYAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[SerializeField]
	private bool lockZAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[SerializeField]
	[Tooltip("Defines which axis will be facing the target")]
	private axis PointingAxis = axis.Z_Axis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Quaternion rightToForward;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[SerializeField]
	[Tooltip("This allows to compute all the children in parallel making them face the target with the set axis")]
	private bool computeChildren;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private List<Transform> children = (List<Transform>)(object)new List<T>();

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Camera _camera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Transform _cameraTransform;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Camera Camera
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xBBC630", Offset = "0xBBB030", VA = "0x180BBC630")]
		get
		{
			//IL_0010: Expected O, but got I4
			Camera camera = _camera;
			int num = 0;
			if (camera == (UnityEngine.Object)num)
			{
				int num2 = 0;
				Camera camera2 = (_camera = Camera.main);
			}
			return _camera;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Transform CameraTransform
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xBBC550", Offset = "0xBBAF50", VA = "0x180BBC550")]
		get
		{
			//Discarded unreachable code: IL_0042
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			Transform cameraTransform = _cameraTransform;
			int num = 0;
			if (cameraTransform == (UnityEngine.Object)num)
			{
				Camera camera = Camera;
				int num2 = 0;
				if (camera != (UnityEngine.Object)num2)
				{
					Transform transform = (_cameraTransform = Camera.transform);
				}
			}
			return _cameraTransform;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xBBC3E0", Offset = "0xBBADE0", VA = "0x180BBC3E0")]
	private void Start()
	{
		axis pointingAxis = PointingAxis;
		if (pointingAxis == axis.X_Axis || pointingAxis == axis.X_Axis)
		{
		}
		if (computeChildren)
		{
			Transform transform = base.transform;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xBBC3E0", Offset = "0xBBADE0", VA = "0x180BBC3E0")]
	private void OnValidate()
	{
		axis pointingAxis = PointingAxis;
		if (pointingAxis == axis.X_Axis || pointingAxis == axis.X_Axis)
		{
		}
		if (computeChildren)
		{
			Transform transform = base.transform;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0xBBC460", Offset = "0xBBAE60", VA = "0x180BBC460")]
	private void SetDirectionVector()
	{
		axis pointingAxis = PointingAxis;
		if (pointingAxis != 0 && pointingAxis != 0)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0xBBC160", Offset = "0xBBAB60", VA = "0x180BBC160")]
	private Quaternion GetLookRotation(Vector3 right, [Optional] Vector3 up)
	{
		int num = 0;
		bool flag = default(bool);
		if (flag)
		{
			float z = Vector3.up.z;
		}
		float z2 = up.z;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0xBBBB40", Offset = "0xBBA540", VA = "0x180BBBB40")]
	private void Compute(Transform trans)
	{
		//IL_0024: Expected O, but got I4
		//IL_0024: Expected O, but got I4
		//IL_0037: Expected O, but got I4
		//IL_0037: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_004c: Expected O, but got I4
		//IL_0060: Expected O, but got I4
		Transform cameraTransform = CameraTransform;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		int num = 0;
		Vector3 up = Vector3.up;
		int num2 = 0;
		if ((Vector3)num2 == (Vector3)num)
		{
			Vector3 up2 = Vector3.up;
		}
		Quaternion quaternion = Quaternion.LookRotation((Vector3)num2, (Vector3)num);
		Quaternion quaternion2 = (Quaternion)num2 * (Quaternion)num;
		trans.rotation = (Quaternion)num;
		Transform parent = trans.parent;
		int num3 = 0;
		bool flag = parent != (UnityEngine.Object)num3;
		bool flag2 = lockXAxis;
		if (!flag)
		{
			if (flag2)
			{
			}
			if (lockYAxis)
			{
			}
			if (lockZAxis)
			{
			}
			return;
		}
		if ((object)trans != null)
		{
		}
		Quaternion localRotation = trans.localRotation;
		if (lockYAxis)
		{
		}
		Quaternion localRotation2 = trans.localRotation;
		if (!lockZAxis)
		{
			Quaternion localRotation3 = trans.localRotation;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xBBBF60", Offset = "0xBBA960", VA = "0x180BBBF60")]
	private void GetAllChildren(Transform parent, ref List<Transform> transforms)
	{
		//Discarded unreachable code: IL_0028, IL_0034
		int num = 0;
		IEnumerator enumerator = parent.GetEnumerator();
		int num3 = default(int);
		if (enumerator != null)
		{
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			if (enumerator == null)
			{
			}
			num3 = 0;
			if (enumerator == null)
			{
				throw new InvalidCastException();
			}
		}
		if (num3 == 0)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0xBBC260", Offset = "0xBBAC60", VA = "0x180BBC260")]
	private void LateUpdate()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xBBC4D0", Offset = "0xBBAED0", VA = "0x180BBC4D0")]
	public LookAtCamera()
	{
	}//IL_0009: Expected I4, but got I8

}
