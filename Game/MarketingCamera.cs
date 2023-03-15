using System;
using Cpp2IlInjected;
using Mdl.Environments;
using Mdl.Systems;
using Rewired;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000039")]
public class MarketingCamera : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[SerializeField]
	private float moveSpeed = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[SerializeField]
	private float rotateSpeed = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[SerializeField]
	private float craneSpeed = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[SerializeField]
	private float zoomSpeed = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Camera marketingCam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private Player marketingPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float curPitch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private bool zoomMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float engineSpeed = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float fixedDeltaTime;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xBBEA40", Offset = "0xBBD440", VA = "0x180BBEA40")]
	private void Start()
	{
		//Discarded unreachable code: IL_0073
		Camera camera = (marketingCam = GetComponent<Camera>());
		InitCurrentPitch();
		int num = 0;
		Player player = (marketingPlayer = ReInput.players.GetPlayer(1));
		Player player2 = marketingPlayer;
		if (player2 == null)
		{
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}
		player2.kmEfLNkViRABrvNGUeLWSgIPLpvD = true;
		int num2 = 0;
		float num3 = (fixedDeltaTime = Time.fixedDeltaTime);
		Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += AnyEnvironmentEnteredEvent;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0xBBE630", Offset = "0xBBD030", VA = "0x180BBE630")]
	private void OnDestroy()
	{
		Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= AnyEnvironmentEnteredEvent;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0xBBEBB0", Offset = "0xBBD5B0", VA = "0x180BBEBB0")]
	private void Update()
	{
		//Discarded unreachable code: IL_0175
		//IL_0041: Expected O, but got F4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected F4, but got Unknown
		//IL_0151: Expected O, but got F4
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected F4, but got Unknown
		if (marketingPlayer.GetButtonDown("ToggleZoom"))
		{
			bool flag = (zoomMode = !zoomMode);
		}
		int num = 0;
		bool flag2 = default(bool);
		if (flag2)
		{
			Time.timeScale = engineSpeed;
			float num2 = ((MarketingCamera)fixedDeltaTime).engineSpeed;
			Time.fixedDeltaTime = /*Error near IL_0042: Stack underflow*/* num2;
		}
		if (marketingPlayer.GetButtonDown("Reset"))
		{
			Reset();
		}
		int num3 = 0;
		float deltaTime = Time.deltaTime;
		Move(deltaTime);
		float num4 = rotateSpeed;
		Transform transform = marketingCam.transform;
		Player player = marketingPlayer;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		float axis = player.GetAxis("Yaw");
		Player player2 = marketingPlayer;
		float num5 = curPitch;
		float axis2 = player2.GetAxis("Pitch");
		axis2 = num5;
		curPitch = num5;
		float num6 = Mathf.Clamp(axis2, -90f, 90f);
		Player player3 = marketingPlayer;
		num5 = (curPitch = num6);
		float axis3 = player3.GetAxis("Roll");
		Transform transform2 = marketingCam.transform;
		if (zoomMode)
		{
			float fieldOfView = marketingCam.fieldOfView;
			Player player4 = marketingPlayer;
			z = fieldOfView;
			float axis4 = player4.GetAxis("Crane");
			Camera camera = marketingCam;
			float num7 = ((MarketingCamera)axis4).zoomSpeed;
			float num8 = /*Error near IL_0152: Stack underflow*/* num7;
			num8 = z;
			float num10 = (camera.fieldOfView = Mathf.Clamp(num8, 5f, 90f));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0xBBE0E0", Offset = "0xBBCAE0", VA = "0x180BBE0E0")]
	private bool AdjustSpeed(string actionName, ref float speed, float inc = 0.5f)
	{
		if (marketingPlayer.GetNegativeButtonDown(actionName))
		{
		}
		if (marketingPlayer.GetButtonDown(actionName))
		{
		}
		int num = 0;
		int num2 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0xBBE190", Offset = "0xBBCB90", VA = "0x180BBE190")]
	private void AnyEnvironmentEnteredEvent(object sender, EventArgs e)
	{
		Reset();
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xBBE230", Offset = "0xBBCC30", VA = "0x180BBE230")]
	private void Move(float dt)
	{
		//Discarded unreachable code: IL_0099
		//IL_0098: Expected O, but got I4
		Transform transform = marketingCam.transform;
		Transform transform2 = marketingCam.transform;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		Transform transform3 = marketingCam.transform;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		float axis = marketingPlayer.GetAxis("MoveFwd");
		float axis2 = marketingPlayer.GetAxis("MoveRight");
		if (!zoomMode)
		{
			Vector3 up = Vector3.up;
			axis2 = dt;
			axis2 = marketingPlayer.GetAxis("Crane");
		}
		Camera camera = marketingCam;
		int num = 0;
		camera.transform.position = (Vector3)num;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0xBBE860", Offset = "0xBBD260", VA = "0x180BBE860")]
	private void Rotate(float dt)
	{
		//Discarded unreachable code: IL_009e
		float num = rotateSpeed;
		Transform transform = marketingCam.transform;
		Player player = marketingPlayer;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		float axis = player.GetAxis("Yaw");
		Player player2 = marketingPlayer;
		float num2 = curPitch;
		float axis2 = player2.GetAxis("Pitch");
		axis2 = num2;
		curPitch = num2;
		float num3 = Mathf.Clamp(axis2, -90f, 90f);
		Player player3 = marketingPlayer;
		num2 = (curPitch = num3);
		float axis3 = player3.GetAxis("Roll");
		Transform transform2 = marketingCam.transform;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0xBBEFE0", Offset = "0xBBD9E0", VA = "0x180BBEFE0")]
	private void Zoom(float dt)
	{
		//Discarded unreachable code: IL_0052
		//IL_0033: Expected O, but got F4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected F4, but got Unknown
		if (zoomMode)
		{
			float fieldOfView = marketingCam.fieldOfView;
			float axis = marketingPlayer.GetAxis("Crane");
			Camera camera = marketingCam;
			float num = ((MarketingCamera)axis).zoomSpeed;
			float num2 = /*Error near IL_0034: Stack underflow*/* num;
			num2 = fieldOfView;
			float num4 = (camera.fieldOfView = Mathf.Clamp(num2, 5f, 90f));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0xBBE6A0", Offset = "0xBBD0A0", VA = "0x180BBE6A0")]
	private void Reset()
	{
		//Discarded unreachable code: IL_005b
		Camera playerCamera = SystemRoot.Instance._playerCamera;
		Transform transform = marketingCam.transform;
		Transform transform2 = playerCamera.transform;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		Transform transform3 = marketingCam.transform;
		Transform transform4 = playerCamera.transform;
		Camera camera = marketingCam;
		float num = (camera.fieldOfView = playerCamera.fieldOfView);
		InitCurrentPitch();
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0xBBE1A0", Offset = "0xBBCBA0", VA = "0x180BBE1A0")]
	private void InitCurrentPitch()
	{
		//Discarded unreachable code: IL_0014
		Transform transform = marketingCam.transform;
		float num = default(float);
		curPitch = num;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0xBBEB80", Offset = "0xBBD580", VA = "0x180BBEB80")]
	private void UpdateEngineSpeed()
	{
		//IL_0016: Expected O, but got F4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected F4, but got Unknown
		Time.timeScale = engineSpeed;
		float num = ((MarketingCamera)fixedDeltaTime).engineSpeed;
		Time.fixedDeltaTime = /*Error near IL_0017: Stack underflow*/* num;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0xBBF0B0", Offset = "0xBBDAB0", VA = "0x180BBF0B0")]
	public MarketingCamera()
	{
	}
}
