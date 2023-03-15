using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x2000500")]
	public class ProbeData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F84")]
		public KeyGroup<ReflectionMap> keys = (KeyGroup<ReflectionMap>)(object)new KeyGroup<T>();

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F85")]
		private AssetReference currentCubemapRef;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001F86")]
		public Cubemap currentCubemap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001F87")]
		private AsyncOperationHandle<Cubemap> currentCubemapHandle;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001F88")]
		public float cubemapBlending;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4001F89")]
		private int requestA = -1;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001F8A")]
		public Cubemap currentCubemapA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001F8B")]
		private AsyncOperationHandle<Cubemap> currentCubemapHandleA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001F8C")]
		private int requestB = -1;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001F8D")]
		public Cubemap currentCubemapB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001F8E")]
		private AsyncOperationHandle<Cubemap> currentCubemapHandleB;

		[Cpp2IlInjected.Token(Token = "0x170002E0")]
		public bool blendingAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6001639")]
			[Cpp2IlInjected.Address(RVA = "0xCB8E70", Offset = "0xCB7870", VA = "0x180CB8E70")]
			get
			{
				//IL_0010: Expected O, but got I4
				//IL_0029: Expected O, but got I4
				Cubemap cubemap = currentCubemapA;
				int num = 0;
				bool flag = cubemap != (UnityEngine.Object)num;
				if (!flag)
				{
					return flag;
				}
				Cubemap cubemap2 = currentCubemapB;
				int num2 = 0;
				return cubemap2 != (UnityEngine.Object)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001638")]
		[Cpp2IlInjected.Address(RVA = "0xCB8180", Offset = "0xCB6B80", VA = "0x180CB8180")]
		public AssetReference GetNearestCubemap(float time)
		{
			KeyGroup<ReflectionMap> keyGroup = keys;
			int index = 0;
			int num = 0;
			if (((KeyGroup<T>)(object)keyGroup).Count != 0)
			{
				KeyGroup<ReflectionMap> keyGroup2 = keys;
				return ((ReflectionMap)((KeyGroup<T>)(object)keys)[index]).cubemap;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600163A")]
		[Cpp2IlInjected.Address(RVA = "0xCB83A0", Offset = "0xCB6DA0", VA = "0x180CB83A0")]
		public void RequestBlendedCubemap(float time)
		{
			//IL_0037: Expected F4, but got I4
			//IL_0089: Expected O, but got I4
			//IL_00bf: Expected O, but got I4
			//IL_012b: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_01bf: Expected O, but got I4
			//IL_0206: Expected O, but got I4
			//IL_020d: Expected F4, but got I4
			//IL_025f: Expected O, but got I4
			//IL_0295: Expected O, but got I4
			KeyGroup<ReflectionMap> keyGroup = keys;
			int num = 0;
			int num2 = 0;
			int num3 = requestA;
			int num4 = requestB;
			if ((IntPtr)num3 != (IntPtr)keyGroup)
			{
				if ((IntPtr)num4 != (IntPtr)keyGroup)
				{
					if ((IntPtr)num3 != (IntPtr)keyGroup)
					{
						cubemapBlending = num2;
						if ((IntPtr)num4 != (IntPtr)keyGroup)
						{
							if (num3 != -1 && ((ReflectionMap)((KeyGroup<T>)(object)keys)[num3]).cubemap.IsValid())
							{
								KeyGroup<ReflectionMap> keyGroup2 = keys;
								int index = requestA;
								((ReflectionMap)((KeyGroup<T>)(object)keyGroup2)[index]).cubemap.ReleaseAsset();
							}
							int index2 = 0;
							currentCubemapA = (Cubemap)num;
							KeyGroup<ReflectionMap> keyGroup3 = keys;
							requestA = index2;
							AssetReference cubemap = ((ReflectionMap)((KeyGroup<T>)(object)keyGroup3)[index2]).cubemap;
							uint num5 = num5 + 20;
							num5 += num5;
							currentCubemapHandleA = (AsyncOperationHandle<Cubemap>)num2;
							Action<AsyncOperationHandle<Cubemap>> action = (Action<AsyncOperationHandle<Cubemap>>)(object)new Action<T>(CurrentCubemapHandleA_Completed);
							if (requestB == -1)
							{
								goto IL_0255;
							}
							KeyGroup<ReflectionMap> keyGroup4 = keys;
						}
						if (num3 != -1 && ((ReflectionMap)((KeyGroup<T>)(object)keys)[num3]).cubemap.IsValid())
						{
							KeyGroup<ReflectionMap> keyGroup5 = keys;
							int index3 = requestA;
							((ReflectionMap)((KeyGroup<T>)(object)keyGroup5)[index3]).cubemap.ReleaseAsset();
						}
						int index4 = 0;
						currentCubemapA = (Cubemap)num;
						KeyGroup<ReflectionMap> keyGroup6 = keys;
						requestA = index4;
						AssetReference cubemap2 = ((ReflectionMap)((KeyGroup<T>)(object)keyGroup6)[index4]).cubemap;
						uint num6 = num6 + 20;
						num6 += num6;
						currentCubemapHandleA = (AsyncOperationHandle<Cubemap>)num2;
						Action<AsyncOperationHandle<Cubemap>> action2 = (Action<AsyncOperationHandle<Cubemap>>)(object)new Action<T>(CurrentCubemapHandleA_Completed);
						return;
					}
					if (num4 != -1)
					{
						KeyGroup<ReflectionMap> keyGroup7 = keys;
						num3 = num4;
						if (((ReflectionMap)((KeyGroup<T>)(object)keyGroup7)[num3]).cubemap.IsValid())
						{
							KeyGroup<ReflectionMap> keyGroup8 = keys;
							int index5 = requestB;
							((ReflectionMap)((KeyGroup<T>)(object)keyGroup8)[index5]).cubemap.ReleaseAsset();
						}
					}
					currentCubemapB = (Cubemap)num;
				}
				if (num3 != -1 && ((ReflectionMap)((KeyGroup<T>)(object)keys)[num3]).cubemap.IsValid())
				{
					KeyGroup<ReflectionMap> keyGroup9 = keys;
					int index6 = requestA;
					((ReflectionMap)((KeyGroup<T>)(object)keyGroup9)[index6]).cubemap.ReleaseAsset();
				}
				currentCubemapA = (Cubemap)num;
			}
			cubemapBlending = num2;
			if (num4 != -1)
			{
				KeyGroup<ReflectionMap> keyGroup10 = keys;
				num3 = num4;
				if (((ReflectionMap)((KeyGroup<T>)(object)keyGroup10)[num3]).cubemap.IsValid())
				{
					KeyGroup<ReflectionMap> keyGroup11 = keys;
					int index7 = requestB;
					((ReflectionMap)((KeyGroup<T>)(object)keyGroup11)[index7]).cubemap.ReleaseAsset();
				}
			}
			goto IL_0255;
			IL_0255:
			int index8 = 0;
			currentCubemapB = (Cubemap)num;
			KeyGroup<ReflectionMap> keyGroup12 = keys;
			requestB = index8;
			AssetReference cubemap3 = ((ReflectionMap)((KeyGroup<T>)(object)keyGroup12)[index8]).cubemap;
			uint num7 = num7 + 20;
			num7 += num7;
			currentCubemapHandleB = (AsyncOperationHandle<Cubemap>)num2;
			Action<AsyncOperationHandle<Cubemap>> action3 = (Action<AsyncOperationHandle<Cubemap>>)(object)new Action<T>(CurrentCubemapHandleB_Completed);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600163B")]
		[Cpp2IlInjected.Address(RVA = "0xCB8080", Offset = "0xCB6A80", VA = "0x180CB8080")]
		private unsafe void CurrentCubemapHandleA_Completed(AsyncOperationHandle<Cubemap> handle)
		{
			if (((AsyncOperationHandle<TObject>*)handle)->Status == AsyncOperationStatus.Succeeded)
			{
				Cubemap cubemap = (currentCubemapA = (Cubemap)((AsyncOperationHandle<TObject>*)handle)->Result);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600163C")]
		[Cpp2IlInjected.Address(RVA = "0xCB8100", Offset = "0xCB6B00", VA = "0x180CB8100")]
		private unsafe void CurrentCubemapHandleB_Completed(AsyncOperationHandle<Cubemap> handle)
		{
			if (((AsyncOperationHandle<TObject>*)handle)->Status == AsyncOperationStatus.Succeeded)
			{
				Cubemap cubemap = (currentCubemapB = (Cubemap)((AsyncOperationHandle<TObject>*)handle)->Result);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600163D")]
		[Cpp2IlInjected.Address(RVA = "0xCB8A60", Offset = "0xCB7460", VA = "0x180CB8A60")]
		public void RequestNearestCubemap(float time)
		{
			//IL_006d: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_00ad: Expected O, but got I4
			KeyGroup<ReflectionMap> keyGroup = keys;
			int num = 0;
			int num2 = 0;
			if (((KeyGroup<T>)(object)keyGroup).Count != 0)
			{
				KeyGroup<ReflectionMap> keyGroup2 = keys;
				ReflectionMap reflectionMap = (ReflectionMap)((KeyGroup<T>)(object)keys)[num];
			}
			AssetReference assetReference = currentCubemapRef;
			if ((IntPtr)assetReference == (IntPtr)num)
			{
				return;
			}
			if (assetReference != null && assetReference.IsValid())
			{
				currentCubemapRef.ReleaseAsset();
			}
			bool flag = default(bool);
			if (!flag)
			{
				Action<AsyncOperationHandle<Cubemap>> action = (Action<AsyncOperationHandle<Cubemap>>)(object)new Action<T>(LoadCubemap_Completed);
			}
			currentCubemap = (Cubemap)num;
			currentCubemapRef = (AssetReference)num;
			AssetReference assetReference2 = currentCubemapRef;
			if (assetReference2 == null)
			{
				return;
			}
			bool flag2 = assetReference2.IsValid();
			AssetReference assetReference3 = currentCubemapRef;
			Action<AsyncOperationHandle<Cubemap>> action2 = default(Action<AsyncOperationHandle<Cubemap>>);
			if (!flag2)
			{
				uint num3 = num3 + 20;
				num3 += num3;
				currentCubemapHandle = (AsyncOperationHandle<Cubemap>)num2;
				action2 = (Action<AsyncOperationHandle<Cubemap>>)(object)new Action<T>(LoadCubemap_Completed);
				return;
			}
			if (action2 != null)
			{
			}
			currentCubemap = (Cubemap)(object)action2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600163E")]
		[Cpp2IlInjected.Address(RVA = "0xCB8280", Offset = "0xCB6C80", VA = "0x180CB8280")]
		private unsafe void LoadCubemap_Completed(AsyncOperationHandle<Cubemap> handle)
		{
			if (((AsyncOperationHandle<TObject>*)handle)->Status == AsyncOperationStatus.Succeeded)
			{
				Cubemap cubemap = (currentCubemap = (Cubemap)((AsyncOperationHandle<TObject>*)handle)->Result);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600163F")]
		[Cpp2IlInjected.Address(RVA = "0xCB8300", Offset = "0xCB6D00", VA = "0x180CB8300")]
		public void Release()
		{
			//IL_0021: Expected O, but got I4
			//IL_002d: Expected O, but got I8
			currentCubemapRef?.ReleaseAsset();
			Cubemap cubemap = currentCubemap;
			int num = 0;
			if (cubemap != (UnityEngine.Object)num)
			{
				currentCubemap = (Cubemap)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001640")]
		[Cpp2IlInjected.Address(RVA = "0xCB8DE0", Offset = "0xCB77E0", VA = "0x180CB8DE0")]
		public ProbeData()
		{
		}//IL_001d: Expected I4, but got I8
		//IL_002d: Expected I4, but got I8

	}
}
