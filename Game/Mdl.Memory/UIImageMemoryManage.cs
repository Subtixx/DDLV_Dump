using System;
using Cpp2IlInjected;
using Unity.Services.Authentication;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Mdl.Memory
{
	[Cpp2IlInjected.Token(Token = "0x2000217")]
	[RequireComponent(typeof(Image))]
	public class UIImageMemoryManage : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40011BE")]
		[SerializeField]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40011BF")]
		[SerializeField]
		private AssetReferenceSprite spriteReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40011C0")]
		private Sprite original;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40011C1")]
		public UnityEvent OnLoadComplete;

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x13E2290", Offset = "0x13E0C90", VA = "0x1813E2290")]
		private unsafe void OnEnable()
		{
			//Discarded unreachable code: IL_0062
			//IL_0010: Expected O, but got I4
			Image image = this.image;
			int num = 0;
			if (image == (UnityEngine.Object)num)
			{
				Image image2 = (this.image = GetComponent<Image>());
			}
			Image image3 = this.image;
			Sprite sprite = default(Sprite);
			if ((object)image3 != null)
			{
				sprite = image3.m_Sprite;
			}
			original = sprite;
			AssetReferenceSprite assetReferenceSprite = spriteReference;
			uint num2 = num2 + 20;
			num2 += num2;
			Action<AsyncOperationHandle<Sprite>> action = (Action<AsyncOperationHandle<Sprite>>)(object)(Action<T>)delegate(AsyncOperationHandle<Sprite> handle)
			{
				//Discarded unreachable code: IL_002c
				//IL_0020: Expected O, but got I4
				Image image4 = this.image;
				if (((AsyncOperationHandle<TObject>*)handle)->IsValid())
				{
					Sprite result = (Sprite)((AsyncOperationHandle<TObject>*)handle)->Result;
				}
				int num3 = 0;
				image4.sprite = (Sprite)num3;
				OnLoadComplete.Invoke();
			};
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x13E21F0", Offset = "0x13E0BF0", VA = "0x1813E21F0")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0036
			//IL_0010: Expected O, but got I4
			Image image = this.image;
			int num = 0;
			if (image != (UnityEngine.Object)num)
			{
				Image image2 = this.image;
				Sprite sprite2 = (image2.sprite = original);
			}
			int refreshAttemptFrequency = ((Unity.Services.Authentication.IAuthenticationSettings)spriteReference).RefreshAttemptFrequency;
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public UIImageMemoryManage()
		{
		}
	}
}
