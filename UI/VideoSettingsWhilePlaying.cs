using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Graphic.Weather;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Video;

[Cpp2IlInjected.Token(Token = "0x2000037")]
public class VideoSettingsWhilePlaying : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[SerializeField]
	[NotNull]
	private VideoPlayer video;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static readonly int VSYNC_DO_NOT_CHANGE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly int TARGETFPS_DO_NOT_CHANGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[SerializeField]
	[Range(-1f, 4f)]
	private int vSyncCount = VSYNC_DO_NOT_CHANGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[SerializeField]
	private int targetFrameRate = TARGETFPS_DO_NOT_CHANGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[SerializeField]
	private bool PauseWeatherSystem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[SerializeField]
	private bool DisablePlayerCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool _reactivateWeatherSystem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private int _backupVSyncCount = VSYNC_DO_NOT_CHANGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private int _backupTargetFrameRate = TARGETFPS_DO_NOT_CHANGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private SettingScope VideoSettingScope;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool IsVideoActive
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x14D66F0", Offset = "0x14D50F0", VA = "0x1814D66F0")]
		get
		{
			//Discarded unreachable code: IL_001c
			if (video.isPlaying)
			{
				return true;
			}
			return video.isPaused;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x14D5ED0", Offset = "0x14D48D0", VA = "0x1814D5ED0")]
	public void Awake()
	{
		//Discarded unreachable code: IL_001c
		VideoPlayer videoPlayer = video;
		VideoPlayer.EventHandler value = VideoStarted;
		videoPlayer.started += value;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x14D5F60", Offset = "0x14D4960", VA = "0x1814D5F60")]
	public void OnDestroy()
	{
		//IL_0056: Expected O, but got I8
		VideoPlayer videoPlayer = video;
		VideoPlayer.EventHandler value = VideoStarted;
		videoPlayer.started -= value;
		if (_reactivateWeatherSystem)
		{
			WeatherSystem system = SystemRoot.Instance.GetSystem<WeatherSystem>();
			_reactivateWeatherSystem = false;
			system.ResumeSystem();
		}
		VideoSettingScope?.Dispose();
		VideoSettingScope = (SettingScope)0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x14D61F0", Offset = "0x14D4BF0", VA = "0x1814D61F0")]
	private void VideoStarted(VideoPlayer source)
	{
		//Discarded unreachable code: IL_00c2
		//IL_0040: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		int num = 0;
		int num2 = vSyncCount;
		if (vSyncCount <= 4)
		{
		}
		int num3 = targetFrameRate;
		int num4 = targetFrameRate;
		VideoSettingScope?.Dispose();
		string text = default(string);
		VideoSettingScope = (VideoSettingScope = new SettingScope(95, (Nullable<>)num, (Nullable<>)num, (Nullable<>)num, text));
		if (PauseWeatherSystem)
		{
			WeatherSystem system = SystemRoot.Instance.GetSystem<WeatherSystem>();
			bool flag = (_reactivateWeatherSystem = !system.IsPaused);
			system.PauseSystem();
		}
		if (DisablePlayerCamera)
		{
			Camera playerCamera = SystemRoot.Instance._playerCamera;
			int num5 = ((playerCamera.enabled = false) ? 1 : 0);
		}
		int _003C_003E1__state = default(int);
		_003CcheckVideoEnded_003Ed__16 _003CcheckVideoEnded_003Ed__ = new _003CcheckVideoEnded_003Ed__16(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CcheckVideoEnded_003Ed__._003C_003E4__this = this;
		Coroutine coroutine = StartCoroutine(_003CcheckVideoEnded_003Ed__);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x14D6680", Offset = "0x14D5080", VA = "0x1814D6680")]
	[IteratorStateMachine(typeof(_003CcheckVideoEnded_003Ed__16))]
	private IEnumerator checkVideoEnded()
	{
		int _003C_003E1__state = default(int);
		_003CcheckVideoEnded_003Ed__16 _003CcheckVideoEnded_003Ed__ = new _003CcheckVideoEnded_003Ed__16(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CcheckVideoEnded_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x14D60E0", Offset = "0x14D4AE0", VA = "0x1814D60E0")]
	private void VideoEnded()
	{
		//IL_003b: Expected O, but got I8
		if (_reactivateWeatherSystem)
		{
			WeatherSystem system = SystemRoot.Instance.GetSystem<WeatherSystem>();
			_reactivateWeatherSystem = false;
			system.ResumeSystem();
		}
		VideoSettingScope?.Dispose();
		VideoSettingScope = (SettingScope)0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x14D65D0", Offset = "0x14D4FD0", VA = "0x1814D65D0")]
	public VideoSettingsWhilePlaying()
	{
	}
}
