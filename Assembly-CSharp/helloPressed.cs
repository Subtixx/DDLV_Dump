using System;
using Cpp2IlInjected;
using GymAnimation;
using Mdl.Motion;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Cpp2IlInjected.Token(Token = "0x2000005")]
public class helloPressed : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Button btnMove;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public Button btnRun;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Button btnCamPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Button btnTurn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private Animator[] allAnimators;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private GameObject camPosOne;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private GameObject camPosTwo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Camera mainCam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int posVal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Quaternion beginRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Quaternion endRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Tween<Quaternion> rotationTween;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float turnF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private float directionF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool cameraRotationTransition;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1EAB9C0", Offset = "0x1EAA3C0", VA = "0x181EAB9C0")]
	private unsafe void Start()
	{
		//Discarded unreachable code: IL_0186
		//IL_010e: Expected I4, but got I8
		//IL_013e: Expected O, but got I4
		//IL_013e: Expected O, but got I4
		Button.ButtonClickedEvent onClick = btnMove.m_OnClick;
		UnityAction call = movePressed;
		onClick.AddListener(call);
		Button.ButtonClickedEvent onClick2 = btnRun.m_OnClick;
		UnityAction call2 = runPressed;
		onClick2.AddListener(call2);
		Button.ButtonClickedEvent onClick3 = btnCamPos.m_OnClick;
		UnityAction call3 = camPressed;
		onClick3.AddListener(call3);
		Button.ButtonClickedEvent onClick4 = btnTurn.m_OnClick;
		UnityAction call4 = turnPressed;
		onClick4.AddListener(call4);
		Animator[] array = (allAnimators = UnityEngine.Object.FindObjectsOfType<Animator>());
		GameObject gameObject = (camPosOne = GameObject.Find("CamPosOne"));
		GameObject gameObject2 = (camPosTwo = GameObject.Find("CamPosTwo"));
		int num = 0;
		Camera camera = (mainCam = Camera.main);
		Transform transform = mainCam.transform;
		Transform transform2 = camPosOne.transform;
		GameObject gameObject3 = camPosOne;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		Transform transform3 = gameObject3.transform;
		posVal = 1;
		cameraRotationTransition = false;
		GameObject gameObject4 = GameObject.Find("SceneRoot");
		if ((object)gameObject4 != null)
		{
			GymCharacterSelect componentInChildren = gameObject4.GetComponentInChildren<GymCharacterSelect>();
		}
		int num2 = 0;
		int num3 = 0;
		if ((UnityEngine.Object)num2 != (UnityEngine.Object)num3)
		{
			GymCharacterSelect.CharacterChanged characterChanged = default(GymCharacterSelect.CharacterChanged);
			((Delegate)characterChanged).method_ptr = (IntPtr)__ldftn(helloPressed.UpdateAnimators);
			((Delegate)characterChanged).method = (IntPtr)__ldftn(helloPressed.UpdateAnimators);
			((Delegate)characterChanged).m_target = this;
			GymCharacterSelect.CharacterChanged characterChanged2 = default(GymCharacterSelect.CharacterChanged);
			((Delegate)characterChanged2).method_ptr = (IntPtr)__ldftn(helloPressed.UpdateAnimators);
			((Delegate)characterChanged2).method = (IntPtr)__ldftn(helloPressed.UpdateAnimators);
			((Delegate)characterChanged2).m_target = this;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1EABE10", Offset = "0x1EAA810", VA = "0x181EABE10")]
	public void UpdateAnimators()
	{
		Animator[] array = (allAnimators = UnityEngine.Object.FindObjectsOfType<Animator>());
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1EABE80", Offset = "0x1EAA880", VA = "0x181EABE80")]
	private void Update()
	{
		//Discarded unreachable code: IL_002d
		if (cameraRotationTransition)
		{
			int num = 0;
			Tween<Quaternion> tween = rotationTween;
			float deltaTime = Time.deltaTime;
			int reverse = 0;
			bool flag = (cameraRotationTransition = ((Tween<T>)(object)tween).Play(deltaTime, (byte)reverse != 0));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1EABF00", Offset = "0x1EAA900", VA = "0x181EABF00")]
	private void camPressed()
	{
		//Discarded unreachable code: IL_00a8
		//IL_0051: Expected I4, but got I8
		//IL_00a7: Expected I4, but got I8
		int num = posVal;
		if (num == 0)
		{
			Transform transform = mainCam.transform;
			Transform transform2 = camPosOne.transform;
			GameObject gameObject = camPosOne;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Transform transform3 = gameObject.transform;
			mainCam.orthographic = true;
			posVal = 1;
			return;
		}
		while (num != 1)
		{
		}
		Transform transform4 = mainCam.transform;
		Transform transform5 = camPosTwo.transform;
		GameObject gameObject2 = camPosTwo;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		Transform transform6 = gameObject2.transform;
		Camera camera = mainCam;
		int num2 = ((camera.orthographic = false) ? 1 : 0);
		posVal = 0;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC280", Offset = "0x1EAAC80", VA = "0x181EAC280")]
	private unsafe void turnPressed()
	{
		//Discarded unreachable code: IL_011a
		//IL_00a2: Expected F4, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_00d7: Expected O, but got I4
		//IL_00e9: Expected O, but got I4
		Animator[] array = allAnimators;
		int num = 0;
		cameraRotationTransition = true;
		if (num < array.Length)
		{
			Animator i = array[num];
			i.SetTrigger("Turn");
			float num2 = (directionF = Mathf.Sign(turnF = i.GetFloat("TurnRatio")));
			Transform transform = i.transform;
			Quaternion message = default(Quaternion);
			Debug.Log(message);
			float t = turnF;
			float b = directionF;
			Quaternion quaternion = beginRotation;
			float num3 = Mathf.Lerp(0f, b, t);
			int num4 = 0;
			float z = Vector3.up.z;
			b = num3;
			Quaternion quaternion2 = Quaternion.AngleAxis(num3, (Vector3)num4);
			Quaternion quaternion3 = beginRotation;
			int num5 = default(int);
			Tween<Quaternion>.InterpolationFunction interpolationFunction = (Tween<Quaternion>.InterpolationFunction)(object)new Tween<T>.InterpolationFunction(num5, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<Quaternion, Quaternion, float, Quaternion>*/)(&Quaternion.Slerp));
			num5 = 0;
			int num6 = default(int);
			EasingFunction easingFunction = new EasingFunction(num6, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num6 = 0;
			Tween<Quaternion> tween = default(Tween<Quaternion>);
			rotationTween = tween;
			Tween<Quaternion> tween2 = rotationTween;
			Tween<Quaternion>.UpdateEventHandler updateEventHandler = (Tween<Quaternion>.UpdateEventHandler)(object)(Tween<T>.UpdateEventHandler)delegate
			{
				//Discarded unreachable code: IL_000d
				Transform transform2 = i.transform;
			};
			((Tween<T>)(object)tween2).add_OnUpdate((Tween<>.UpdateEventHandler)(object)updateEventHandler);
			num++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC1A0", Offset = "0x1EAABA0", VA = "0x181EAC1A0")]
	private void runPressed()
	{
		//Discarded unreachable code: IL_0057
		//IL_0052: Expected F4, but got I4
		Animator[] array = allAnimators;
		int num = 0;
		int length = array.Length;
		if (num < length)
		{
			Animator animator = array[num];
			if (!(animator.GetFloat("Run") >= 1f))
			{
				animator.SetFloat("Run", 1f);
				num++;
			}
			int num2 = 0;
			animator.SetFloat("Run", num2);
			num++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC0E0", Offset = "0x1EAAAE0", VA = "0x181EAC0E0")]
	private void movePressed()
	{
		//Discarded unreachable code: IL_004f
		Animator[] array = allAnimators;
		int num = 0;
		int length = array.Length;
		if (num < length)
		{
			Animator animator = array[num];
			if (!animator.GetBool("Move"))
			{
				animator.SetBool("Move", value: true);
				num++;
			}
			int value = 0;
			animator.SetBool("Move", (byte)value != 0);
			num++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public helloPressed()
	{
	}
}
