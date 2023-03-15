using System;
using Cpp2IlInjected;
using Definitions;
using Mdl.Platform;
using UnityEngine;

namespace Assets.Scripts.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	internal static class DefinitionsAppInitializer
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x1621CF0", Offset = "0x16206F0", VA = "0x181621CF0")]
		[RuntimeInitializeOnLoadMethod]
		public static void Init()
		{
			//IL_0045: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			//IL_006f: Expected O, but got I4
			string runningPlatformName = PlatformUtils.GetRunningPlatformName();
			int num = 0;
			bool webSecurityEnabled = Application.webSecurityEnabled;
			int num2 = 0;
			bool isDebugBuild = Debug.isDebugBuild;
			int num3 = 0;
			RuntimePlatform platform = Application.platform;
			GameUserInfo gameUserInfo = new GameUserInfo();
			App.RuntimePlatform _003CCurrentPlatform_003Ek__BackingField = App.CurrentPlatform;
			string _003CStorePlatform_003Ek__BackingField = App.StorePlatform;
			Debug.Log($"Definitions.App.CurrentPlatform = {_003CCurrentPlatform_003Ek__BackingField}, StorePlatform={_003CStorePlatform_003Ek__BackingField}");
			App.RuntimePlatform _003CCurrentPlatform_003Ek__BackingField2 = App.CurrentPlatform;
			string text = ((Enum)_003CCurrentPlatform_003Ek__BackingField2).ToString();
			App.RuntimePlatform runtimePlatform = _003CCurrentPlatform_003Ek__BackingField2;
			int num4 = 0;
			RuntimePlatform platform2 = Application.platform;
			string value = ((Enum)platform2).ToString();
			RuntimePlatform runtimePlatform2 = platform2;
			if (text.Equals(value))
			{
				return;
			}
			Exception ex = new Exception("ERROR: Look like Application.platform enum from Unity have change, please fix me!!!");
			/*Error: Unexpected end of block*/;
		}
	}
}
