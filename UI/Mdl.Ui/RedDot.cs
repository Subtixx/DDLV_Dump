using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[ExecuteInEditMode]
	public class RedDot : MonoBehaviour, IHasDynamicView
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public List<RedDotDataType> DataTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public RedDotVisualType VisualType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		[SerializeField]
		private RedDotView _view;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public TextBase TextBase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A04")]
			[Cpp2IlInjected.Address(RVA = "0xF47DB0", Offset = "0xF467B0", VA = "0x180F47DB0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return View.TextBase;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public RedDotView View
		{
			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0xF47DD0", Offset = "0xF467D0", VA = "0x180F47DD0")]
			get
			{
				bool flag = default(bool);
				if (flag)
				{
					int num = 0;
					bool isPlaying = Application.isPlaying;
					int num2 = 0;
					RecycleBin miscRecycleBin = UiRoot.Instance._miscRecycleBin;
					Type typeFromHandle = typeof(RedDotView);
					RectTransform content = _content;
					GameObject gameObject = miscRecycleBin.FindReusableOrNew(typeFromHandle, content);
					Transform transform = gameObject.transform;
					int num3 = 0;
					if ((object)transform != null)
					{
					}
					int num4 = 0;
					Vector2 zero = Vector2.zero;
					float z = Vector3.one.z;
					gameObject.SetActive(value: true);
					RedDotView redDotView = (_view = gameObject.GetComponent<RedDotView>());
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0xF47AF0", Offset = "0xF464F0", VA = "0x180F47AF0")]
		private void OnEnable()
		{
			//IL_0010: Expected O, but got I4
			RedDotView view = _view;
			int num = 0;
			if (view == (UnityEngine.Object)num)
			{
				RedDotView redDotView = (_view = View);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0xF47A30", Offset = "0xF46430", VA = "0x180F47A30")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0053
			//IL_0010: Expected O, but got I4
			//IL_0052: Expected O, but got I8
			RedDotView view = _view;
			int num = 0;
			if (view != (UnityEngine.Object)num)
			{
				int num2 = 0;
				if (Application.isPlaying)
				{
					int num3 = 0;
					UiRoot instance = UiRoot.Instance;
					RedDotView view2 = _view;
					RecycleBin miscRecycleBin = instance._miscRecycleBin;
					GameObject trash = view2.gameObject;
					miscRecycleBin.SendToBin(trash);
				}
				_view = (RedDotView)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0xF478E0", Offset = "0xF462E0", VA = "0x180F478E0", Slot = "4")]
		public GameObject GetView()
		{
			//Discarded unreachable code: IL_0067
			int num = 0;
			bool isPlaying = Application.isPlaying;
			int num2 = 0;
			RecycleBin miscRecycleBin = UiRoot.Instance._miscRecycleBin;
			Type typeFromHandle = typeof(RedDotView);
			RectTransform content = _content;
			GameObject gameObject = miscRecycleBin.FindReusableOrNew(typeFromHandle, content);
			Transform transform = gameObject.transform;
			int num3 = 0;
			if ((object)transform != null)
			{
			}
			int num4 = 0;
			Vector2 zero = Vector2.zero;
			float z = Vector3.one.z;
			gameObject.SetActive(value: true);
			return gameObject;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0xF47A30", Offset = "0xF46430", VA = "0x180F47A30", Slot = "5")]
		public void ReleaseView()
		{
			//Discarded unreachable code: IL_0053
			//IL_0010: Expected O, but got I4
			//IL_0052: Expected O, but got I8
			RedDotView view = _view;
			int num = 0;
			if (view != (UnityEngine.Object)num)
			{
				int num2 = 0;
				if (Application.isPlaying)
				{
					int num3 = 0;
					UiRoot instance = UiRoot.Instance;
					RedDotView view2 = _view;
					RecycleBin miscRecycleBin = instance._miscRecycleBin;
					GameObject trash = view2.gameObject;
					miscRecycleBin.SendToBin(trash);
				}
				_view = (RedDotView)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0xF47B80", Offset = "0xF46580", VA = "0x180F47B80")]
		private void RefreshDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void PlayAnimation()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void ReleaseAnimation()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0xF477E0", Offset = "0xF461E0", VA = "0x180F477E0")]
		public void CheckState(bool refresh = false)
		{
			//Discarded unreachable code: IL_0056
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu bottom = menuStack.Bottom;
			if (bottom != null)
			{
				int num3 = 0;
				if (bottom != null)
				{
					GameObject gameObject = base.gameObject;
					int num4 = 0;
					RedDotHelper redDotHelper = UiRoot.Instance.RedDotHelper;
					List<RedDotDataType> dataTypes = DataTypes;
					bool active = redDotHelper.Check((List<>)(object)dataTypes, refresh);
					gameObject.SetActive(active);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0xF47CB0", Offset = "0xF466B0", VA = "0x180F47CB0")]
		public void UpdateState(bool force = false)
		{
			//Discarded unreachable code: IL_0056
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu bottom = menuStack.Bottom;
			if (bottom != null)
			{
				int num3 = 0;
				if (bottom != null)
				{
					GameObject gameObject = base.gameObject;
					int num4 = 0;
					RedDotHelper redDotHelper = UiRoot.Instance.RedDotHelper;
					List<RedDotDataType> dataTypes = DataTypes;
					bool active = redDotHelper.UpdateHistory((List<>)(object)dataTypes, force);
					gameObject.SetActive(active);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0xF476C0", Offset = "0xF460C0", VA = "0x180F476C0")]
		public void AddToRealTimeUpdate()
		{
			//Discarded unreachable code: IL_005b
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			if ((object)instance == null)
			{
				return;
			}
			MenuStack menuStack = instance._menuStack;
			if ((object)menuStack == null)
			{
				return;
			}
			int num2 = 0;
			IMenu bottom = menuStack.Bottom;
			if (bottom == null)
			{
				return;
			}
			int num3 = 0;
			if (bottom != null)
			{
				int num4 = 0;
				RedDotHelper redDotHelper = UiRoot.Instance.RedDotHelper;
				if (!((List<T>)(object)redDotHelper._redDotsForRealTimeUpdate).Contains((T)this))
				{
					((List<T>)(object)redDotHelper._redDotsForRealTimeUpdate).Add((T)this);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0xF47B90", Offset = "0xF46590", VA = "0x180F47B90")]
		public void RemoveFromRealTimeUpdate()
		{
			//Discarded unreachable code: IL_005d
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			if ((object)instance == null)
			{
				return;
			}
			MenuStack menuStack = instance._menuStack;
			if ((object)menuStack == null)
			{
				return;
			}
			int num2 = 0;
			IMenu bottom = menuStack.Bottom;
			if (bottom == null)
			{
				return;
			}
			int num3 = 0;
			if (bottom != null)
			{
				int num4 = 0;
				RedDotHelper redDotHelper = UiRoot.Instance.RedDotHelper;
				if (((List<T>)(object)redDotHelper._redDotsForRealTimeUpdate).Contains((T)this))
				{
					bool flag = ((List<T>)(object)redDotHelper._redDotsForRealTimeUpdate).Remove((T)this);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public RedDot()
		{
		}
	}
}
