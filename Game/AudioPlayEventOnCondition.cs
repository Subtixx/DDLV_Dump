using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Conditions;
using Mdl.Audio;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AudioPlayEventOnCondition : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[ItemID]
	public int playEventCondition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public AK.Wwise.Event eventToPlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GameObject audioEmitter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public string triggerId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public AK.Wwise.Event eventToPlayOnDestroy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private ConditionEventHandler eventHandler;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool playing;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1505B00", Offset = "0x1504500", VA = "0x181505B00")]
	private void Start()
	{
		if (!string.IsNullOrEmpty(triggerId))
		{
			AudioManager.OnAudioEventTriggered -= OnAudioEventTriggered;
			AudioManager.OnAudioEventTriggered += OnAudioEventTriggered;
		}
		if (playEventCondition != 0 && !RunCondition())
		{
			CreateEventHandler();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1505C00", Offset = "0x1504600", VA = "0x181505C00")]
	private void OnEnable()
	{
		bool flag = RunCondition();
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1505B00", Offset = "0x1504500", VA = "0x181505B00")]
	public void InitListeners()
	{
		if (!string.IsNullOrEmpty(triggerId))
		{
			AudioManager.OnAudioEventTriggered -= OnAudioEventTriggered;
			AudioManager.OnAudioEventTriggered += OnAudioEventTriggered;
		}
		if (playEventCondition != 0 && !RunCondition())
		{
			CreateEventHandler();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1505C10", Offset = "0x1504610", VA = "0x181505C10")]
	private void OnAudioEventTriggered(string audioEventTriggered)
	{
		//Discarded unreachable code: IL_0056
		//IL_0044: Expected O, but got I8
		string text = triggerId;
		if (!(audioEventTriggered != text))
		{
			AK.Wwise.Event @event = eventToPlay;
			GameObject gameObject = GetAudioEmitter();
			uint num = @event.Post(gameObject);
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)0;
			AudioManager.OnAudioEventTriggered -= OnAudioEventTriggered;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x15057F0", Offset = "0x15041F0", VA = "0x1815057F0")]
	private void CreateEventHandler()
	{
		//IL_001a: Expected O, but got I4
		eventHandler?.Dispose();
		int num = 0;
		eventHandler = (ConditionEventHandler)num;
		long num2 = Convert.ToInt64((uint)playEventCondition);
		if (SystemRoot.Instance.MetaClient.Dispatcher != null)
		{
			ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
		}
		ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
		eventHandler = conditionEventHandler;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1505C00", Offset = "0x1504600", VA = "0x181505C00")]
	private void OnAnyConditionChanged(ConditionListener conditionListener)
	{
		bool flag = RunCondition();
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1505DF0", Offset = "0x15047F0", VA = "0x181505DF0")]
	private bool RunCondition()
	{
		//IL_006e: Expected O, but got I8
		long num = Convert.ToInt64((uint)playEventCondition);
		Client metaClient = SystemRoot.Instance.MetaClient;
		Client metaClient2 = SystemRoot.Instance.MetaClient;
		bool flag = default(bool);
		if (flag)
		{
			if (!playing)
			{
				AK.Wwise.Event @event = eventToPlay;
				GameObject gameObject = GetAudioEmitter();
				uint num2 = @event.Post(gameObject);
				ConditionEventHandler conditionEventHandler = eventHandler;
				playing = true;
				conditionEventHandler?.Dispose();
				eventHandler = (ConditionEventHandler)0;
				return true;
			}
		}
		else
		{
			playing = false;
		}
		int num3 = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1505D10", Offset = "0x1504710", VA = "0x181505D10")]
	private void OnDestroy()
	{
		//IL_0045: Expected O, but got I8
		AK.Wwise.Event @event = eventToPlayOnDestroy;
		if (@event != null)
		{
			GameObject gameObject = GetAudioEmitter();
			uint num = @event.Post(gameObject);
		}
		AudioManager.OnAudioEventTriggered -= OnAudioEventTriggered;
		eventHandler?.Dispose();
		eventHandler = (ConditionEventHandler)0;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x840940", Offset = "0x83F340", VA = "0x180840940")]
	private void DisposeEventHandler()
	{
		ConditionEventHandler conditionEventHandler;
		do
		{
			conditionEventHandler = eventHandler;
		}
		while (conditionEventHandler == null);
		conditionEventHandler.Dispose();
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x15059D0", Offset = "0x15043D0", VA = "0x1815059D0")]
	private GameObject GetAudioEmitter()
	{
		//IL_0010: Expected O, but got I4
		GameObject gameObject = audioEmitter;
		int num = 0;
		if (!(gameObject == (UnityEngine.Object)num))
		{
			return audioEmitter;
		}
		SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
		if ((object)_003CInstance_003Ek__BackingField != null)
		{
			AudioManager system = _003CInstance_003Ek__BackingField.GetSystem<AudioManager>();
			if ((object)system != null)
			{
				return system.gameObject;
			}
		}
		int num2 = 0;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public AudioPlayEventOnCondition()
	{
	}
}
