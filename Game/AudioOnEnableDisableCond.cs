using System;
using AK.Wwise;
using Cpp2IlInjected;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001D")]
public class AudioOnEnableDisableCond : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[SerializeField]
	[ItemID]
	private int enableDisableCondition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public AK.Wwise.Event soundToPlayOnEnable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public AK.Wwise.Event soundToStopOnDisable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public GameObject audioEmitter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool conditionValid;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x15054F0", Offset = "0x1503EF0", VA = "0x1815054F0")]
	private void OnEnable()
	{
		long num = Convert.ToInt64((uint)enableDisableCondition);
		int num2 = 0;
		SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
		if ((object)_003CInstance_003Ek__BackingField != null)
		{
			Client client = _003CInstance_003Ek__BackingField.Client;
			if ((object)client != null && client.MetaClient == null)
			{
			}
		}
		SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
		if ((object)_003CInstance_003Ek__BackingField2 != null)
		{
			Client client2 = _003CInstance_003Ek__BackingField2.Client;
			if ((object)client2 != null && client2.MetaClient == null)
			{
			}
		}
		bool flag = default(bool);
		conditionValid = flag;
		if (flag)
		{
			AK.Wwise.Event @event = soundToPlayOnEnable;
			if (@event != null)
			{
				GameObject gameObject = audioEmitter;
				uint num3 = @event.Post(gameObject);
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x15054D0", Offset = "0x1503ED0", VA = "0x1815054D0")]
	private void OnDisable()
	{
		if (conditionValid)
		{
			AK.Wwise.Event @event = soundToStopOnDisable;
			if (@event != null)
			{
				GameObject gameObject = audioEmitter;
				uint num = @event.Post(gameObject);
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public AudioOnEnableDisableCond()
	{
	}
}
