using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000226")]
	[CreateAssetMenu]
	public class AsyncMenu : ScriptableObject, IMenu, IHasAsssetGUID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40009A1")]
		public AssetReference assetRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40009A2")]
		[SerializeField]
		private bool _isStaticMenu;

		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		public string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000D90")]
			[Cpp2IlInjected.Address(RVA = "0x882480", Offset = "0x880E80", VA = "0x180882480", Slot = "14")]
			get
			{
				AssetReference assetReference = assetRef;
				if (assetReference == null || assetReference.AssetGUID == null)
				{
				}
				return "";
			}
			[Cpp2IlInjected.Token(Token = "0x6000D91")]
			[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "15")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029C")]
		public bool IsStaticMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000D92")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380", Slot = "4")]
			get
			{
				return _isStaticMenu;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D93")]
			[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029D")]
		public bool UseCanvasScalerMatchWidthOrHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000D94")]
			[Cpp2IlInjected.Address(RVA = "0x882520", Offset = "0x880F20", VA = "0x180882520", Slot = "6")]
			get
			{
				NotImplementedException ex = new NotImplementedException("This should only be called on the Menu instance");
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029E")]
		public float CanvasScalerMatchWidthOrHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000D95")]
			[Cpp2IlInjected.Address(RVA = "0x8824D0", Offset = "0x880ED0", VA = "0x1808824D0", Slot = "7")]
			get
			{
				NotImplementedException ex = new NotImplementedException("This should only be called on the Menu instance");
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D96")]
		[Cpp2IlInjected.Address(RVA = "0x8822F0", Offset = "0x880CF0", VA = "0x1808822F0", Slot = "8")]
		[AsyncStateMachine(typeof(_003CInstantiate_003Ed__12))]
		public Task<Menu> Instantiate(Transform parent)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Menu>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D97")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "11")]
		public void OnFocusIn()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000D98")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		public void OnFocusOut(bool popAfterPreFocusOut = false, bool animate = true)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000D99")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "10")]
		public void OnPop()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "9")]
		public void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9B")]
		[Cpp2IlInjected.Address(RVA = "0x882430", Offset = "0x880E30", VA = "0x180882430", Slot = "12")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__17))]
		public IEnumerator PreFocusOut(bool popAfterPreFocusOut)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__17 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__17(_003C_003E1__state);
			_003C_003E1__state = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9C")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public AsyncMenu()
		{
		}
	}
}
