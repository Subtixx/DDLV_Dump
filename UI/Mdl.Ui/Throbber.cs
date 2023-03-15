using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Systems;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000287")]
	public class Throbber : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000288")]
		public enum Display
		{
			[Cpp2IlInjected.Token(Token = "0x4000B75")]
			Normal = 3,
			[Cpp2IlInjected.Token(Token = "0x4000B76")]
			NormalFrozen = 7,
			[Cpp2IlInjected.Token(Token = "0x4000B77")]
			WithoutLogo = 2,
			[Cpp2IlInjected.Token(Token = "0x4000B78")]
			FrozenWithoutLogo = 6,
			[Cpp2IlInjected.Token(Token = "0x4000B79")]
			NoDisplay = 0
		}

		[Cpp2IlInjected.Token(Token = "0x2000289")]
		public delegate void VisibilityChanged();

		[Cpp2IlInjected.Token(Token = "0x200028A")]
		public struct ThrobberTransactionScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000B7A")]
			private readonly Throbber throbber;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000B7B")]
			private readonly string key;

			[Cpp2IlInjected.Token(Token = "0x6001018")]
			[Cpp2IlInjected.Address(RVA = "0x13501D0", Offset = "0x134EBD0", VA = "0x1813501D0")]
			public ThrobberTransactionScope(Throbber throbber, string key, Display display = Display.Normal)
			{
				//Discarded unreachable code: IL_0016
				this.throbber = throbber;
				this.key = key;
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)throbber).get_ElementIdentifiers();
			}

			[Cpp2IlInjected.Token(Token = "0x6001019")]
			[Cpp2IlInjected.Address(RVA = "0xC26760", Offset = "0xC25160", VA = "0x180C26760", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001

		}

		[Cpp2IlInjected.Token(Token = "0x4000B6B")]
		private const int DISPLAY_VISIBLE = 1;

		[Cpp2IlInjected.Token(Token = "0x4000B6C")]
		private const int BLOCK_INPUT = 2;

		[Cpp2IlInjected.Token(Token = "0x4000B6D")]
		private const int FREEZE_RENDERING = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B6F")]
		[SerializeField]
		private ThrobberIcon mc_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B70")]
		[SerializeField]
		private Image mc_background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000B72")]
		private bool wasFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000B73")]
		private RenderTexture frozenFrame;

		[Cpp2IlInjected.Token(Token = "0x170002F8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4000B71")]
		private List<(string key, Display display)> _keyStack
		{
			[Cpp2IlInjected.Token(Token = "0x6001008")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get;
		} = (List<(string key, Display display)>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x170002F9")]
		public bool Visible
		{
			[Cpp2IlInjected.Token(Token = "0x600100A")]
			[Cpp2IlInjected.Address(RVA = "0x17EFF70", Offset = "0x17EE970", VA = "0x1817EFF70")]
			get
			{
				List<(string, Display)> list = _keyStack;
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FA")]
		public bool ShouldBlockInput
		{
			[Cpp2IlInjected.Token(Token = "0x600100B")]
			[Cpp2IlInjected.Address(RVA = "0x17EFF00", Offset = "0x17EE900", VA = "0x1817EFF00")]
			get
			{
				List<(string, Display)> list = _keyStack;
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event VisibilityChanged OnVisibilityChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6001006")]
			[Cpp2IlInjected.Address(RVA = "0x17EFE60", Offset = "0x17EE860", VA = "0x1817EFE60")]
			[CompilerGenerated]
			add
			{
				VisibilityChanged onVisibilityChanged = this.OnVisibilityChanged;
				Delegate @delegate = Delegate.Combine(onVisibilityChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onVisibilityChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001007")]
			[Cpp2IlInjected.Address(RVA = "0x17EFFE0", Offset = "0x17EE9E0", VA = "0x1817EFFE0")]
			[CompilerGenerated]
			remove
			{
				VisibilityChanged onVisibilityChanged = this.OnVisibilityChanged;
				Delegate @delegate = Delegate.Remove(onVisibilityChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onVisibilityChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001009")]
		[Cpp2IlInjected.Address(RVA = "0x17EEDB0", Offset = "0x17ED7B0", VA = "0x1817EEDB0")]
		private bool ContainsKey(string key)
		{
			//Discarded unreachable code: IL_0029
			List<(string, Display)> cpp2il__autoParamName__idx_ = _keyStack;
			Func<(string, Display), bool> cpp2il__autoParamName__idx_2 = (Func<(string, Display), bool>)(object)(Func<T, TResult>)delegate
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			};
			return ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<(string, Display)>((Func<, >)(object)cpp2il__autoParamName__idx_2);
		}

		[Cpp2IlInjected.Token(Token = "0x600100C")]
		[Cpp2IlInjected.Address(RVA = "0x17EF120", Offset = "0x17EDB20", VA = "0x1817EF120", Slot = "4")]
		public virtual void TransactionBegin(string key, Display display = Display.Normal)
		{
			//Discarded unreachable code: IL_006c
			//IL_001e: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			bool flag = ContainsKey(key);
			if (!flag)
			{
				List<(string, Display)> list = _keyStack;
				int num = 0;
				((List<T>)(object)list).Add((T)num);
				this.OnVisibilityChanged?.Invoke();
				List<(string, Display)> list2 = _keyStack;
				string arg = string.Join<(string, Display)>(" ", (IEnumerable<>)list2);
				string text = $"Throbber::TransactionBegin for key={key} display={flag} stack=[{arg}]";
			}
			string text2 = "Throbber::TransactionBegin, key duplicate of " + key;
			UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x600100D")]
		[Cpp2IlInjected.Address(RVA = "0x17EF2E0", Offset = "0x17EDCE0", VA = "0x1817EF2E0", Slot = "5")]
		public virtual void TransactionEnd(string key)
		{
			//Discarded unreachable code: IL_010e
			//IL_001d: Expected O, but got I4
			//IL_0105: Expected O, but got I4
			int num;
			while (true)
			{
				_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
				CS_0024_003C_003E8__locals0.key = key;
				num = 0;
				if (CS_0024_003C_003E8__locals0 != null || !ContainsKey((string)num))
				{
					break;
				}
				List<(string, Display)> list = _keyStack;
				Predicate<(string, Display)> predicate = (Predicate<(string, Display)>)(object)(Predicate<T>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
				int num2 = ((List<T>)(object)list).RemoveAll((Predicate<>)(object)predicate);
				this.OnVisibilityChanged?.Invoke();
				string[] array = new string[5];
				if ("Throbber::TransactionEnd for key=" != null && "Throbber::TransactionEnd for key=" == null)
				{
					continue;
				}
				array[0] = "Throbber::TransactionEnd for key=";
				if ("Throbber::TransactionEnd for key=" == null || (" stack=[" != null && " stack=[" == null))
				{
					continue;
				}
				array[2] = " stack=[";
				List<(string, Display)> list2 = _keyStack;
				string text = string.Join<(string, Display)>(" ", (IEnumerable<>)list2);
				if (text == null || text != null)
				{
					array[3] = text;
					if ("]" == null || "]" != null)
					{
						array[4] = "]";
						string text2 = string.Concat(array);
						break;
					}
				}
			}
			string text3 = "Throbber::TransactionEnd, key duplicate of " + (string)num;
			UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x600100E")]
		[Cpp2IlInjected.Address(RVA = "0x17EF770", Offset = "0x17EE170", VA = "0x1817EF770")]
		private void UpdateVisuals()
		{
			//IL_0043: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_00b1: Expected I4, but got I8
			//IL_0163: Expected O, but got I8
			GameObject gameObject = base.gameObject;
			List<(string, Display)> list = _keyStack;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			Image image = mc_background;
			Image image2 = mc_background;
			Image image3 = mc_background;
			List<(string, Display)> list2 = _keyStack;
			int num = 0;
			image.color = (Color)num;
			List<(string, Display)> list3 = _keyStack;
			(string, Display) tuple = ((IEnumerable<>)num).Last<(string, Display)>();
			ThrobberIcon throbberIcon = mc_icon;
			ThrobberIcon throbberIcon2 = default(ThrobberIcon);
			if ((object)tuple == null)
			{
				if (!throbberIcon.gameObject.activeSelf)
				{
					goto IL_00eb;
				}
				throbberIcon2 = mc_icon;
				Action onComplete = delegate
				{
					//Discarded unreachable code: IL_0011
					GameObject gameObject2 = base.gameObject;
					int active2 = 0;
					gameObject2.SetActive((byte)active2 != 0);
				};
				float showHideDuration = throbberIcon2._showHideDuration;
				throbberIcon2.Hide(showHideDuration, onComplete);
			}
			float showHideDuration2 = throbberIcon2._showHideDuration;
			ulong num2 = default(ulong);
			throbberIcon2.gameObject.SetActive((byte)num2 != 0);
			Sequence sequence = throbberIcon2._sequence.Play();
			CanvasGroup mc_canvasGroup = throbberIcon2._mc_canvasGroup;
			int complete = 0;
			int num3 = mc_canvasGroup.DOKill((byte)complete != 0);
			TweenerCore<float, float, FloatOptions> tweenerCore = (TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(throbberIcon2._mc_canvasGroup, 1f, showHideDuration2);
			goto IL_00eb;
			IL_00eb:
			List<(string, Display)> cpp2il__autoParamName__idx_ = _keyStack;
			Func<(string, Display), bool> cpp2il__autoParamName__idx_2 = default(Func<(string, Display), bool>);
			if (_003C_003Ec._003C_003E9__22_1 == null)
			{
				cpp2il__autoParamName__idx_2 = (Func<(string, Display), bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			bool flag = ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<(string, Display)>((Func<, >)(object)cpp2il__autoParamName__idx_2);
			bool flag2 = wasFrozen;
			if (!flag)
			{
				if (flag2 && !flag)
				{
					Action<RenderTargetIdentifier, CommandBuffer> action = (Action<RenderTargetIdentifier, CommandBuffer>)(object)new Action<T1, T2>(EndOfFrame);
					RenderTexture temp = frozenFrame;
					wasFrozen = false;
					RenderTexture.ReleaseTemporary(temp);
					frozenFrame = (RenderTexture)0;
				}
				return;
			}
			Camera playerCamera = SystemRoot.Instance._playerCamera;
			Action<RenderTargetIdentifier, CommandBuffer> action2 = (Action<RenderTargetIdentifier, CommandBuffer>)(object)new Action<T1, T2>(EndOfFrame);
			CameraCaptureBridge.AddCaptureAction(playerCamera, (Action<, >)(object)action2);
			wasFrozen = true;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600100F")]
		[Cpp2IlInjected.Address(RVA = "0x17EEEA0", Offset = "0x17ED8A0", VA = "0x1817EEEA0")]
		public void EndOfFrame(RenderTargetIdentifier source, CommandBuffer cmd)
		{
			//IL_0010: Expected O, but got I4
			RenderTexture renderTexture = frozenFrame;
			int num = 0;
			if (!(renderTexture == (UnityEngine.Object)num))
			{
				IntPtr bufferPointer = source.m_BufferPointer;
				return;
			}
			Camera playerCamera = SystemRoot.Instance._playerCamera;
			int pixelWidth = playerCamera.pixelWidth;
			int pixelHeight = playerCamera.pixelHeight;
			int num2 = 0;
			GraphicsFormat graphicsFormat = SystemInfo.GetGraphicsFormat(DefaultFormat.LDR);
			pixelHeight -= num2;
			pixelHeight = pixelWidth;
			pixelHeight -= num2;
			RenderTexture renderTexture2 = default(RenderTexture);
			frozenFrame = renderTexture2;
			frozenFrame.filterMode = FilterMode.Trilinear;
			frozenFrame.name = "Frozen frame";
			RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
			IntPtr bufferPointer2 = renderTargetIdentifier.m_BufferPointer;
			IntPtr bufferPointer3 = source.m_BufferPointer;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001010")]
		[Cpp2IlInjected.Address(RVA = "0x17EF700", Offset = "0x17EE100", VA = "0x1817EF700")]
		public ThrobberTransactionScope TransactionScope(string key, Display display = Display.Normal)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001011")]
		[Cpp2IlInjected.Address(RVA = "0x17EF730", Offset = "0x17EE130", VA = "0x1817EF730")]
		public ThrobberTransactionScope TransactionScope(string key, bool showLogo, bool freezeRendering)
		{
			while (true)
			{
				int num = 0;
				if (freezeRendering)
				{
					/*Error: Could not find block for branch target IL_0006*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001012")]
		[Cpp2IlInjected.Address(RVA = "0x17EFDE0", Offset = "0x17EE7E0", VA = "0x1817EFDE0")]
		public Throbber()
		{
		}
	}
}
