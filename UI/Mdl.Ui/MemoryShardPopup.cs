using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004EC")]
	public class MemoryShardPopup : Menu
	{
		[Cpp2IlInjected.Token(Token = "0x20004ED")]
		public class MemoryShardPopupParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001A46")]
			public Item shardItem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4001A47")]
			public int currentIndex;

			[Cpp2IlInjected.Token(Token = "0x600202B")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public MemoryShardPopupParam()
			{
				((RemotingServices.CACD)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001A3C")]
		private MemoryShardPopupParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001A3D")]
		private MemoryShardItemData shardItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001A3E")]
		private Texture2D backgroundTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001A3F")]
		private Texture2D maskTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001A40")]
		private Texture2D borderTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001A41")]
		[SerializeField]
		private Image _mcMasked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001A42")]
		[SerializeField]
		private Image _mcCurrent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001A43")]
		[SerializeField]
		private Button _btnExit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001A44")]
		[SerializeField]
		private Image _mcBlocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001A45")]
		[SerializeField]
		private CanvasGroup _mcContent;

		[Cpp2IlInjected.Token(Token = "0x6002020")]
		[Cpp2IlInjected.Address(RVA = "0x118C2A0", Offset = "0x118ACA0", VA = "0x18118C2A0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			base.OnPush(stack, param);
			if (param == null)
			{
				return;
			}
			int num = 0;
			if (param != null)
			{
				int num2 = 0;
				if (param == null)
				{
					throw new InvalidCastException();
				}
				_param = (MemoryShardPopupParam)param;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002021")]
		[Cpp2IlInjected.Address(RVA = "0x118C120", Offset = "0x118AB20", VA = "0x18118C120", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_005d
			base.OnFocusIn();
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item shardItem = _param.shardItem;
			MemoryShardItemData memoryShardItemData = (shardItemData = _003CInstance_003Ek__BackingField.GetItemData<MemoryShardItemData>(shardItem));
			GameObject gameObject = _mcContent.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			int _003C_003E1__state = default(int);
			_003CLoadTexturesAsync_003Ed__16 _003CLoadTexturesAsync_003Ed__ = new _003CLoadTexturesAsync_003Ed__16(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CLoadTexturesAsync_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CLoadTexturesAsync_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002022")]
		[Cpp2IlInjected.Address(RVA = "0x118C390", Offset = "0x118AD90", VA = "0x18118C390", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0021
			Button.ButtonClickedEvent onClick = _btnExit.m_OnClick;
			UnityAction call = OnExitClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002023")]
		[Cpp2IlInjected.Address(RVA = "0x118C850", Offset = "0x118B250", VA = "0x18118C850", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_002f
			MenuLayoutTemplate oldLayout = _oldLayout;
			base.RemoveRewiredMapCategory(oldLayout);
			Button.ButtonClickedEvent onClick = _btnExit.m_OnClick;
			UnityAction call = OnExitClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6002024")]
		[Cpp2IlInjected.Address(RVA = "0x118C0F0", Offset = "0x118AAF0", VA = "0x18118C0F0")]
		private void OnExitClickHandler()
		{
			//Discarded unreachable code: IL_0012
			int num = 0;
			UiRoot.Instance._popupStack.Pop();
		}

		[Cpp2IlInjected.Token(Token = "0x6002025")]
		[Cpp2IlInjected.Address(RVA = "0x118C080", Offset = "0x118AA80", VA = "0x18118C080")]
		[IteratorStateMachine(typeof(_003CLoadTexturesAsync_003Ed__16))]
		private IEnumerator LoadTexturesAsync()
		{
			int _003C_003E1__state = default(int);
			_003CLoadTexturesAsync_003Ed__16 _003CLoadTexturesAsync_003Ed__ = new _003CLoadTexturesAsync_003Ed__16(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CLoadTexturesAsync_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002026")]
		[Cpp2IlInjected.Address(RVA = "0x118C430", Offset = "0x118AE30", VA = "0x18118C430")]
		private void SetupMaterial(int previous, int toReveal)
		{
			//Discarded unreachable code: IL_0163
			//IL_00d2: Expected F4, but got I4
			Image mcMasked = _mcMasked;
			Material material2 = (mcMasked.material = new Material(mcMasked.material));
			Material material3 = _mcMasked.material;
			Texture2D value = backgroundTexture;
			material3.SetTexture("_BaseTex", value);
			Material material4 = _mcMasked.material;
			Texture2D value2 = maskTexture;
			material4.SetTexture("_Mask", value2);
			Material material5 = _mcMasked.material;
			Texture2D value3 = borderTexture;
			material5.SetTexture("_ContourAlpha", value3);
			_mcMasked.material.SetInt("_Pieces", previous);
			Image mcCurrent = _mcCurrent;
			Material material7 = (mcCurrent.material = new Material(mcCurrent.material));
			Material material8 = _mcCurrent.material;
			int num = 0;
			material8.SetFloat("_Alpha", num);
			Material material9 = _mcCurrent.material;
			Texture2D value4 = backgroundTexture;
			material9.SetTexture("_BaseTex", value4);
			Material material10 = _mcCurrent.material;
			Texture2D value5 = maskTexture;
			material10.SetTexture("_Mask", value5);
			Material material11 = _mcCurrent.material;
			Texture2D value6 = borderTexture;
			material11.SetTexture("_ContourAlpha", value6);
			_mcCurrent.material.SetInt("_Pieces", toReveal);
			_mcContent.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002027")]
		[Cpp2IlInjected.Address(RVA = "0x118BEE0", Offset = "0x118A8E0", VA = "0x18118BEE0")]
		private void CurrentImageAlpha(float alpha)
		{
			//Discarded unreachable code: IL_0017
			_mcCurrent.material.SetFloat("_Alpha", alpha);
		}

		[Cpp2IlInjected.Token(Token = "0x6002028")]
		[Cpp2IlInjected.Address(RVA = "0x118BF60", Offset = "0x118A960", VA = "0x18118BF60")]
		[AsyncStateMachine(typeof(_003CLoadTextureAsync_003Ed__19))]
		private Task LoadTextureAsync(MemoryShardItemData shardItemData)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002029")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public MemoryShardPopup()
		{
		}
	}
}
