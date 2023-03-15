using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AntidoteSDK;
using Cpp2IlInjected;
using Gameloft.Common;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

[Cpp2IlInjected.Token(Token = "0x200002D")]
public class Boot : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public AssetReference backtrace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public AssetReference main;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private AsyncOperationHandle<SceneInstance> _asyncSceneLoad;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x16439E0", Offset = "0x16423E0", VA = "0x1816439E0")]
	private void Awake()
	{
		//Discarded unreachable code: IL_00a3
		LogWithTime("Boot.Awake");
		if (File.Exists("antidote.json"))
		{
			LogWithTime("antidote: validating session...");
			Antidote.OnSessionValidated _003C_003E9__3_ = _003C_003Ec._003C_003E9__3_0;
			if (_003C_003E9__3_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Antidote.OnSessionValidated)delegate(bool isValid)
				{
					if (!isValid)
					{
					}
					LogWithTime("Antidote session is " + "" + " valid!");
				};
			}
			Antidote.ValidateSession(_003C_003E9__3_);
		}
		int num = 0;
		if (!((BaseStorage<DataType>)(object)GlobalStorage.Instance).Exists)
		{
			LogWithTime("last gameloft PlayFabId : globalstorage not found.");
			return;
		}
		GlobalStorageData globalStorageData = default(GlobalStorageData);
		if (globalStorageData == null || globalStorageData.LastTitleId == null)
		{
		}
		LogWithTime("last gameloft TitleId : " + "na");
		GlobalStorageData globalStorageData2 = default(GlobalStorageData);
		if (globalStorageData2 == null || globalStorageData2.LastPlayFabId == null)
		{
		}
		LogWithTime("last gameloft PlayFabId : " + "na");
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1643CF0", Offset = "0x16426F0", VA = "0x181643CF0")]
	private Gameloft.Common.Version LogBuildInfos()
	{
		//IL_0010: Expected O, but got I4
		int num = 0;
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)num;
		main = (AssetReference)num;
		Gameloft.Common.Version arg = default(Gameloft.Common.Version);
		int build = arg.version.build;
		string buildType = arg.buildType;
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)build;
		main = (AssetReference)(object)buildType;
		IntPtr cachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
		AssetReference assetReference = main;
		LogWithTime($"game version: {arg}");
		LogWithTime("game config: release");
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1643DD0", Offset = "0x16427D0", VA = "0x181643DD0")]
	public static void LogWithTime(string msg)
	{
		int num = 0;
		if ("yyyy-MM-dd-HH:mm:ss:fff" == null)
		{
			int num2 = 0;
			DateTime utcNow = DateTime.UtcNow;
			string text = default(string);
			string text2 = "[" + text + "] " + msg;
		}
		Debug.Log(msg);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1643C80", Offset = "0x1642680", VA = "0x181643C80")]
	[IteratorStateMachine(typeof(_003CLoadMain_003Ed__6))]
	public IEnumerator LoadMain()
	{
		int _003C_003E1__state = default(int);
		_003CLoadMain_003Ed__6 _003CLoadMain_003Ed__ = new _003CLoadMain_003Ed__6(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CLoadMain_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1643ED0", Offset = "0x16428D0", VA = "0x181643ED0")]
	[IteratorStateMachine(typeof(_003CStartMain_003Ed__7))]
	public IEnumerator StartMain([Optional] Func<IEnumerator> beforeCompletion)
	{
		int _003C_003E1__state = default(int);
		_003CStartMain_003Ed__7 _003CStartMain_003Ed__ = new _003CStartMain_003Ed__7(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CStartMain_003Ed__._003C_003E4__this = this;
		_003CStartMain_003Ed__.beforeCompletion = beforeCompletion;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public Boot()
	{
	}
}
