using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000239")]
	[RequireComponent(typeof(CanvasScaler))]
	public class MenuStack : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200023A")]
		public delegate void CurrentMenuChanged(IMenu menu);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40009EE")]
		[SerializeField]
		private RectTransform _menuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40009EF")]
		private CanvasScaler _canvasScaler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40009F1")]
		public ShortcutDefinition PendingShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40009F2")]
		private List<IMenu> _stack = (List<IMenu>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40009F3")]
		private Queue<Action> _actionQueue = (Queue<Action>)(object)new Queue<T>();

		[Cpp2IlInjected.Token(Token = "0x170002BF")]
		public CanvasScaler CanvasScaler
		{
			[Cpp2IlInjected.Token(Token = "0x6000E1A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _canvasScaler;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C0")]
		internal int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000E1D")]
			[Cpp2IlInjected.Address(RVA = "0x12908B0", Offset = "0x128F2B0", VA = "0x1812908B0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((List<>)(object)_stack)._size;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C1")]
		internal IMenu Top
		{
			[Cpp2IlInjected.Token(Token = "0x6000E1E")]
			[Cpp2IlInjected.Address(RVA = "0x12909D0", Offset = "0x128F3D0", VA = "0x1812909D0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C2")]
		internal IMenu Bottom
		{
			[Cpp2IlInjected.Token(Token = "0x6000E1F")]
			[Cpp2IlInjected.Address(RVA = "0x1290840", Offset = "0x128F240", VA = "0x181290840")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C3")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000E20")]
			[Cpp2IlInjected.Address(RVA = "0x12908F0", Offset = "0x128F2F0", VA = "0x1812908F0")]
			get
			{
				//Discarded unreachable code: IL_0009
				List<IMenu> stack = _stack;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C4")]
		public bool IsHudOnTop
		{
			[Cpp2IlInjected.Token(Token = "0x6000E23")]
			[Cpp2IlInjected.Address(RVA = "0x1290940", Offset = "0x128F340", VA = "0x181290940")]
			get
			{
				IMenu top = Top;
				if (top == null)
				{
					return top != null;
				}
				int num = 0;
				return top != null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event CurrentMenuChanged OnCurrentMenuChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000E1B")]
			[Cpp2IlInjected.Address(RVA = "0x12907A0", Offset = "0x128F1A0", VA = "0x1812907A0")]
			[CompilerGenerated]
			add
			{
				CurrentMenuChanged onCurrentMenuChanged = this.OnCurrentMenuChanged;
				Delegate @delegate = Delegate.Combine(onCurrentMenuChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onCurrentMenuChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000E1C")]
			[Cpp2IlInjected.Address(RVA = "0x1290A50", Offset = "0x128F450", VA = "0x181290A50")]
			[CompilerGenerated]
			remove
			{
				CurrentMenuChanged onCurrentMenuChanged = this.OnCurrentMenuChanged;
				Delegate @delegate = Delegate.Remove(onCurrentMenuChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onCurrentMenuChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E21")]
		[Cpp2IlInjected.Address(RVA = "0x19C99F0", Offset = "0x19C83F0", VA = "0x1819C99F0")]
		public bool IsOnTop<T>()
		{
			//Discarded unreachable code: IL_000d
			return Top != null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E22")]
		[Cpp2IlInjected.Address(RVA = "0x128FF60", Offset = "0x128E960", VA = "0x18128FF60")]
		public bool IsOnTop(Menu menu)
		{
			if (Top == null)
			{
			}
			int num = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E24")]
		[Cpp2IlInjected.Address(RVA = "0x1290540", Offset = "0x128EF40", VA = "0x181290540")]
		public void Start()
		{
			CanvasScaler canvasScaler = (_canvasScaler = GetComponent<CanvasScaler>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E25")]
		[Cpp2IlInjected.Address(RVA = "0x12903B0", Offset = "0x128EDB0", VA = "0x1812903B0")]
		internal void Push(IMenu menu, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0030
			Action action = delegate
			{
				//Discarded unreachable code: IL_0031
				MenuStack menuStack = this;
				IMenu menu2 = menu;
				MenuParam param2 = param;
				Action onComplete = menuStack.ExecuteNextAction;
				menuStack.DoPush(menu2, param2, onComplete).FireAndForgetTask();
			};
			QueueAction(action);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E26")]
		[Cpp2IlInjected.Address(RVA = "0x1290180", Offset = "0x128EB80", VA = "0x181290180")]
		internal void PopAllAbove(Type menuType)
		{
			//Discarded unreachable code: IL_0029
			Action action = delegate
			{
				//Discarded unreachable code: IL_0024
				MenuStack menuStack = this;
				Type menuType2 = menuType;
				Action onComplete = menuStack.ExecuteNextAction;
				menuStack.DoPopAllAbove(menuType2, onComplete);
			};
			QueueAction(action);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E27")]
		[Cpp2IlInjected.Address(RVA = "0x12902D0", Offset = "0x128ECD0", VA = "0x1812902D0")]
		internal void Pop()
		{
			//Discarded unreachable code: IL_0030
			IMenu top = Top;
			Action action = delegate
			{
				//Discarded unreachable code: IL_0029
				//IL_0026: Expected I4, but got I8
				MenuStack menuStack = this;
				IMenu menu = top;
				Action onComplete = menuStack.ExecuteNextAction;
				ulong num = default(ulong);
				Menu menu2 = menuStack.DoPop(menu, onComplete, animate: true, (byte)num != 0);
			};
			QueueAction(action);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E28")]
		[Cpp2IlInjected.Address(RVA = "0x1290250", Offset = "0x128EC50", VA = "0x181290250")]
		internal void PopAll()
		{
			Action action = delegate
			{
				//Discarded unreachable code: IL_005a
				//IL_0045: Expected O, but got I4
				//IL_0045: Expected O, but got I4
				Action action2 = ExecuteNextAction;
				List<IMenu> stack = _stack;
				int num = 0;
				int size = ((List<>)(object)_stack)._size;
				if (size > 0)
				{
					int num2 = size - 1;
					int num3 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				int animate = 0;
				int num4 = 0;
				Menu menu = DoPop((IMenu)num, (Action)num4, (byte)animate != 0, (byte)num != 0);
				List<IMenu> stack2 = _stack;
				action2?.Invoke();
			};
			QueueAction(action);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E29")]
		[Cpp2IlInjected.Address(RVA = "0x128FC90", Offset = "0x128E690", VA = "0x18128FC90")]
		[AsyncStateMachine(typeof(_003CDoPush_003Ed__28))]
		private Task DoPush(IMenu menu, MenuParam param, Action onComplete)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2A")]
		[Cpp2IlInjected.Address(RVA = "0x128ED00", Offset = "0x128D700", VA = "0x18128ED00")]
		private void DoPopAllAbove(Type menuType, Action onComplete)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2B")]
		[Cpp2IlInjected.Address(RVA = "0x128F180", Offset = "0x128DB80", VA = "0x18128F180")]
		private void DoPopAllAbove(string assetGUID, Action onComplete)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2C")]
		[Cpp2IlInjected.Address(RVA = "0x128FE70", Offset = "0x128E870", VA = "0x18128FE70")]
		private IMenu GetMenu(Type menuType)
		{
			//Discarded unreachable code: IL_0029
			List<IMenu> stack = _stack;
			Predicate<IMenu> predicate = (Predicate<IMenu>)(object)(Predicate<T>)delegate
			{
				//Discarded unreachable code: IL_000f
				Type obj = menuType;
				Type type = default(Type);
				return ((object)type).Equals((object)obj);
			};
			return (IMenu)((List<T>)(object)stack).Find((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2D")]
		[Cpp2IlInjected.Address(RVA = "0x19C98F0", Offset = "0x19C82F0", VA = "0x1819C98F0")]
		public T GetMenu<T>() where T : class, IMenu
		{
			Type typeFromHandle = typeof(Type);
			IMenu menu = GetMenu(typeFromHandle);
			if (menu == null)
			{
			}
			if (menu != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2E")]
		[Cpp2IlInjected.Address(RVA = "0x19C9A50", Offset = "0x19C8450", VA = "0x1819C9A50")]
		public bool TryGetMenu<T>(out T menu) where T : class, IMenu
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2F")]
		[Cpp2IlInjected.Address(RVA = "0x128F760", Offset = "0x128E160", VA = "0x18128F760")]
		private Menu DoPop(IMenu menu, Action onComplete, bool animate = true, bool focusInNext = true)
		{
			//IL_004d: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			//IL_0078: Expected O, but got I4
			//IL_00f4: Expected O, but got I4
			//IL_00f4: Expected O, but got I4
			List<IMenu> stack = _stack;
			int num = 0;
			int size = ((List<>)(object)_stack)._size;
			if (size > 0)
			{
				int num2 = size - 1;
				int num3 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			if ((IntPtr)num == (IntPtr)menu)
			{
				IMenu top = Top;
				Type type = default(Type);
				if ((object)type != null)
				{
					string text = type.Name;
				}
				string text2 = "MenuStack :: Pop " + (string)num;
				if (((List<>)(object)_stack)._size > 1)
				{
					int num4 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
					if (text2 != null)
					{
						int num5 = 0;
					}
				}
				int num6 = 0;
				if ((UnityEngine.Object)num != (UnityEngine.Object)num6)
				{
					IMenu top2 = Top;
				}
				if (Top == null)
				{
				}
				int num7 = 0;
				int num8 = 0;
				IMenu top3 = Top;
				if (top3 != null)
				{
					int num9 = 0;
					if (top3 != null)
					{
						goto IL_0145;
					}
				}
				IMenu top4 = Top;
				uint num10 = default(uint);
				if (num < (int)num10)
				{
					num += num;
					num++;
				}
				List<IMenu> stack2 = _stack;
				int size2 = ((List<>)(object)stack2)._size;
				((List<T>)(object)stack2).RemoveAt(size2);
				List<IMenu> stack3 = _stack;
				IMenu top5 = Top;
				int num11 = 0;
				if ((UnityEngine.Object)num != (UnityEngine.Object)num11)
				{
				}
				CurrentMenuChanged onCurrentMenuChanged = this.OnCurrentMenuChanged;
				if (onCurrentMenuChanged != null)
				{
					IMenu top6 = Top;
					onCurrentMenuChanged(top6);
				}
				int num12 = default(int);
				if (onComplete != null)
				{
					num12 = 0;
					onComplete();
				}
				num12 += num12;
			}
			Type type2 = default(Type);
			string text3 = default(string);
			if ((object)type2 != null)
			{
				text3 = type2.Name;
			}
			string text4 = "MenuStack :: Pop failed" + text3;
			goto IL_0145;
			IL_0145:
			onComplete?.Invoke();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E30")]
		[Cpp2IlInjected.Address(RVA = "0x128F650", Offset = "0x128E050", VA = "0x18128F650")]
		private void DoPopAll(Action onComplete)
		{
			//Discarded unreachable code: IL_004c
			//IL_0037: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			List<IMenu> stack = _stack;
			int num = 0;
			int size = ((List<>)(object)_stack)._size;
			if (size > 0)
			{
				int num2 = size - 1;
				int num3 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			int animate = 0;
			int num4 = 0;
			Menu menu = DoPop((IMenu)num, (Action)num4, (byte)animate != 0, (byte)num != 0);
			List<IMenu> stack2 = _stack;
			onComplete?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E31")]
		[Cpp2IlInjected.Address(RVA = "0x12904A0", Offset = "0x128EEA0", VA = "0x1812904A0")]
		private void QueueAction(Action action)
		{
			//Discarded unreachable code: IL_001d
			((Queue<T>)(object)_actionQueue).Enqueue((T)action);
			((Queue<T>)(object)_actionQueue).Peek()();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E32")]
		[Cpp2IlInjected.Address(RVA = "0x128FDE0", Offset = "0x128E7E0", VA = "0x18128FDE0")]
		private void ExecuteNextAction()
		{
			//Discarded unreachable code: IL_001d, IL_001e
			Action action = (Action)((Queue<T>)(object)_actionQueue).Dequeue();
			((Queue<T>)(object)_actionQueue).Peek()();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E33")]
		[Cpp2IlInjected.Address(RVA = "0x1290020", Offset = "0x128EA20", VA = "0x181290020")]
		internal void Kill(IMenu menu)
		{
			//Discarded unreachable code: IL_003c
			if (Top != menu)
			{
				bool flag = ((List<T>)(object)_stack).Remove((T)menu);
				if (menu == null)
				{
				}
				int num = 0;
				int size = ((List<>)(object)_stack)._size;
				if (size > 0)
				{
					int num2 = size - 1;
					int num3 = 0;
					System.ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				int num4 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E34")]
		[Cpp2IlInjected.Address(RVA = "0x128EB90", Offset = "0x128D590", VA = "0x18128EB90")]
		public void ClearAllKeepVisible()
		{
			//Discarded unreachable code: IL_0011
			List<IMenu> stack = _stack;
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				int num2 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E35")]
		[Cpp2IlInjected.Address(RVA = "0x12906E0", Offset = "0x128F0E0", VA = "0x1812906E0")]
		public MenuStack()
		{
		}
	}
}
