using System;
using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200002B")]
public class SetRTPCToDistance : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public RTPC GameParameter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Transform PlayerCameraTransform;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public float MaxDistance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Action UpdateRTPCValues;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x40000CC")]
	public bool TaskCreated
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xF4ABE0", Offset = "0xF495E0", VA = "0x180F4ABE0")]
	private void Start()
	{
		//Discarded unreachable code: IL_005b
		Action action = (UpdateRTPCValues = delegate
		{
			//Discarded unreachable code: IL_001a
			SetRTPCToDistance setRTPCToDistance = this;
			RoundRobinTaskManager _003CSingleton_003Ek__BackingField2 = RoundRobinTaskManager.Singleton;
			TaskCreated = false;
		});
		if ((bool)RoundRobinTaskManager.Singleton && !TaskCreated)
		{
			RoundRobinTaskManager _003CSingleton_003Ek__BackingField = RoundRobinTaskManager.Singleton;
			Action updateRTPCValues = UpdateRTPCValues;
			int fpRemoveOnExecuted = 0;
			bool flag = (TaskCreated = _003CSingleton_003Ek__BackingField.AppendParallelTask(updateRTPCValues, (byte)fpRemoveOnExecuted != 0));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xF4AD60", Offset = "0xF49760", VA = "0x180F4AD60")]
	private void UpdateValues(Vector3 camPos)
	{
		//Discarded unreachable code: IL_0041
		//IL_0028: Invalid comparison between F4 and I4
		//IL_0040: Expected O, but got I4
		Transform transform = base.transform;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		float z2 = camPos.z;
		float maxDistance = MaxDistance;
		int num = 0;
		if ((object)transform == null || !(maxDistance <= (float)num))
		{
			RTPC gameParameter = GameParameter;
			int num2 = 0;
			float value = default(float);
			gameParameter.SetValue((GameObject)num2, value);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xF4AB00", Offset = "0xF49500", VA = "0x180F4AB00")]
	private void OptimizeUpdate()
	{
		//Discarded unreachable code: IL_0036
		if ((bool)RoundRobinTaskManager.Singleton && !TaskCreated)
		{
			RoundRobinTaskManager _003CSingleton_003Ek__BackingField = RoundRobinTaskManager.Singleton;
			Action updateRTPCValues = UpdateRTPCValues;
			int fpRemoveOnExecuted = 0;
			bool flag = (TaskCreated = _003CSingleton_003Ek__BackingField.AppendParallelTask(updateRTPCValues, (byte)fpRemoveOnExecuted != 0));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xF4AAA0", Offset = "0xF494A0", VA = "0x180F4AAA0")]
	private void OnDestroy()
	{
		//Discarded unreachable code: IL_0016
		RoundRobinTaskManager _003CSingleton_003Ek__BackingField = RoundRobinTaskManager.Singleton;
		Action updateRTPCValues = UpdateRTPCValues;
		bool flag = _003CSingleton_003Ek__BackingField.RemoveParallelTask(updateRTPCValues);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public SetRTPCToDistance()
	{
	}
}
