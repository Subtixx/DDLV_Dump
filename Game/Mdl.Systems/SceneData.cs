using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Navigation;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000966")]
	public struct SceneData : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4003414")]
		public SceneItemData sceneItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4003415")]
		public SceneInstance sceneInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003416")]
		public CameraNavigationConfig CameraConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003417")]
		public CameraNavigationConfig EditCameraConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003418")]
		public SceneComplexityData ComplexitySettings;

		[Cpp2IlInjected.Token(Token = "0x1700063D")]
		public Scene scene
		{
			[Cpp2IlInjected.Token(Token = "0x6002BA5")]
			[Cpp2IlInjected.Address(RVA = "0x6E07B0", Offset = "0x6DF1B0", VA = "0x1806E07B0")]
			get
			{
				SceneInstance sceneInstance = this.sceneInstance;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700063E")]
		public GameObject sceneRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6002BA6")]
			[Cpp2IlInjected.Address(RVA = "0xCC9850", Offset = "0xCC8250", VA = "0x180CC9850")]
			get
			{
				return sceneInstance.m_Scene.GetRoot();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002BA7")]
		[Cpp2IlInjected.Address(RVA = "0xCC96C0", Offset = "0xCC80C0", VA = "0x180CC96C0", Slot = "4")]
		public void Dispose()
		{
			//IL_0010: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			CameraNavigationConfig cameraConfig = CameraConfig;
			int num = 0;
			if (cameraConfig != (UnityEngine.Object)num)
			{
				Addressables.Release(CameraConfig);
			}
			CameraNavigationConfig editCameraConfig = EditCameraConfig;
			int num2 = 0;
			if (editCameraConfig != (UnityEngine.Object)num2)
			{
				Addressables.Release(EditCameraConfig);
			}
			SceneComplexityData complexitySettings = ComplexitySettings;
			int num3 = 0;
			if (complexitySettings != (UnityEngine.Object)num3)
			{
				Addressables.Release(ComplexitySettings);
			}
		}
	}
}
