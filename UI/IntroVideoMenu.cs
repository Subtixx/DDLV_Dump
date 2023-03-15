using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Audio;
using Mdl.Performance;
using Mdl.Systems;
using Mdl.Ui;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Video;

[Cpp2IlInjected.Token(Token = "0x2000036")]
public class IntroVideoMenu : Menu, IHasRedirectionHandler
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public VideoPlayer defaultVideo;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[SerializeField]
	public List<FMVVideoPlayerForPlatforms> platformVideosMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[SerializeField]
	private Button _btnSkip;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xD27460", Offset = "0xD25E60", VA = "0x180D27460")]
	private VideoPlayer GetVideoForPlatform()
	{
		//Discarded unreachable code: IL_002e, IL_0034, IL_003a
		int num = 0;
		List<FMVVideoPlayerForPlatforms> list = platformVideosMap;
		bool flag = default(bool);
		if (flag)
		{
			int num2 = 0;
			int platform = (int)Application.platform;
			bool flag2 = default(bool);
			while (!flag2)
			{
			}
			num++;
		}
		if (num + 1 != 0)
		{
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0xD27AC0", Offset = "0xD264C0", VA = "0x180D27AC0", Slot = "30")]
	protected override void RegisterBaseListeners()
	{
		//Discarded unreachable code: IL_0033
		((object)this)._002Ector();
		VideoPlayer videoForPlatform = GetVideoForPlatform();
		VideoPlayer.EventHandler value = Video_loopPointReached;
		videoForPlatform.loopPointReached += value;
		UnityAction call = default(UnityAction);
		_btnSkip.m_OnClick.AddListener(call);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0xD27CA0", Offset = "0xD266A0", VA = "0x180D27CA0", Slot = "31")]
	protected override void UnregisterBaseListeners()
	{
		//Discarded unreachable code: IL_0033
		((object)this)._002Ector();
		VideoPlayer videoForPlatform = GetVideoForPlatform();
		VideoPlayer.EventHandler value = Video_loopPointReached;
		videoForPlatform.loopPointReached -= value;
		UnityAction call = default(UnityAction);
		_btnSkip.m_OnClick.RemoveListener(call);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0xD27800", Offset = "0xD26200", VA = "0x180D27800", Slot = "27")]
	public override void OnFocusIn()
	{
		//Discarded unreachable code: IL_0036
		base.OnFocusIn();
		SystemRoot.Instance.GetSystem<AudioManager>().SetGameState(AudioManager.GameState.IntroCinematic);
		Camera playerCamera = SystemRoot.Instance._playerCamera;
		int num = ((playerCamera.enabled = false) ? 1 : 0);
		GetVideoForPlatform().Play();
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0xD279B0", Offset = "0xD263B0", VA = "0x180D279B0")]
	private void Video_loopPointReached(VideoPlayer source)
	{
		StopVideo();
		IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0xD279B0", Offset = "0xD263B0", VA = "0x180D279B0", Slot = "39")]
	public virtual void OnSkipClickedHandler()
	{
		StopVideo();
		IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0xD27670", Offset = "0xD26070", VA = "0x180D27670", Slot = "24")]
	protected override void OnDestroy()
	{
		//Discarded unreachable code: IL_0075
		//IL_0016: Expected O, but got I4
		//IL_0033: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_0057: Expected O, but got I4
		base.OnDestroy();
		VideoPlayer videoForPlatform = GetVideoForPlatform();
		int num = 0;
		if (videoForPlatform != (UnityEngine.Object)num)
		{
			videoForPlatform.targetTexture?.Release();
			int num2 = 0;
			videoForPlatform.targetTexture = (RenderTexture)num2;
		}
		RawImage componentInChildren = GetComponentInChildren<RawImage>(includeInactive: true);
		int num3 = 0;
		if (componentInChildren != (UnityEngine.Object)num3)
		{
			int num4 = 0;
			componentInChildren.texture = (Texture)num4;
		}
		LowMemoryManager singleton = LowMemoryManager._singleton;
		if (singleton != null)
		{
			int isDuringLoading = 0;
			singleton.DoMemoryCleaningTask((byte)isDuringLoading != 0).FireAndForgetTask();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0xD27630", Offset = "0xD26030", VA = "0x180D27630", Slot = "38")]
	public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
	{
		//Discarded unreachable code: IL_0020
		if (redirectionType == RedirectionType.GamePopCurrentMenu)
		{
			_btnSkip.m_OnClick?.Invoke();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xD279E0", Offset = "0xD263E0", VA = "0x180D279E0")]
	private void PlayVideo()
	{
		//Discarded unreachable code: IL_0020
		Camera playerCamera = SystemRoot.Instance._playerCamera;
		int num = ((playerCamera.enabled = false) ? 1 : 0);
		GetVideoForPlatform().Play();
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0xD27BC0", Offset = "0xD265C0", VA = "0x180D27BC0")]
	private void StopVideo()
	{
		//Discarded unreachable code: IL_001c
		SystemRoot.Instance._playerCamera.enabled = true;
		GetVideoForPlatform().Stop();
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
	public IntroVideoMenu()
	{
	}
}
