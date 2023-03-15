using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Mdl.Navigation;
using Mdl.Systems;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000475")]
	public abstract class GridObjectStateUser : MonoBehaviour, IPlayerTaskDataCancellationProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001C52")]
		private CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001C53")]
		private GridEditMode gridEditModeSystem;

		[Cpp2IlInjected.Token(Token = "0x17000276")]
		public CancellationToken GridObjectStateCancellationToken
		{
			[Cpp2IlInjected.Token(Token = "0x600138B")]
			[Cpp2IlInjected.Address(RVA = "0x1538830", Offset = "0x1537230", VA = "0x181538830")]
			get
			{
				CancellationTokenSource cancellationTokenSource = this.cancellationTokenSource;
				if (cancellationTokenSource != null)
				{
					return cancellationTokenSource.Token;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000277")]
		public GridObjectScript GridObjectScript
		{
			[Cpp2IlInjected.Token(Token = "0x600138C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CGridObjectScript_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600138D")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CGridObjectScript_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600138E")]
		[Cpp2IlInjected.Address(RVA = "0x1538A70", Offset = "0x1537470", VA = "0x181538A70", Slot = "5")]
		protected virtual void Start()
		{
			//Discarded unreachable code: IL_0097
			//IL_0030: Expected O, but got I4
			GridEditMode gridEditMode = (gridEditModeSystem = SystemRoot.Instance.GetSystem<GridEditMode>());
			GridObjectScript gridObjectScript = (GridObjectScript = GetComponentInParent<GridObjectScript>());
			GridObjectScript gridObjectScript2 = GridObjectScript;
			int num = 0;
			if (!(gridObjectScript2 != (Object)num))
			{
				return;
			}
			GridObjectScript gridObjectScript3 = GridObjectScript;
			GridObjectScript.GridEditModeChangedDelegate value = GridObjectChangedEvent;
			gridObjectScript3.GridObjectChangedEvent += value;
			if ((long)GridObjectScript.GridObject != 0)
			{
				GridObjectScript gridObjectScript4 = GridObjectScript;
				if ((long)gridObjectScript4.GridObject != 0)
				{
					CancellationTokenSource cancellationTokenSource = (this.cancellationTokenSource = new CancellationTokenSource());
				}
				GridObject _003CGridObject_003Ek__BackingField = gridObjectScript4.GridObject;
				InitWithGridObject(_003CGridObject_003Ek__BackingField);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600138F")]
		[Cpp2IlInjected.Address(RVA = "0x1538970", Offset = "0x1537370", VA = "0x181538970", Slot = "6")]
		protected virtual void OnDestroy()
		{
			//Discarded unreachable code: IL_0057
			//IL_0010: Expected O, but got I4
			//IL_0056: Expected O, but got I8
			GridObjectScript gridObjectScript = GridObjectScript;
			int num = 0;
			if (gridObjectScript != (Object)num)
			{
				GridObjectScript gridObjectScript2 = GridObjectScript;
				GridObjectScript.GridEditModeChangedDelegate value = GridObjectChangedEvent;
				gridObjectScript2.GridObjectChangedEvent -= value;
			}
			CancellationTokenSource cancellationTokenSource = this.cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				this.cancellationTokenSource.Dispose();
				this.cancellationTokenSource = (CancellationTokenSource)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001390")]
		[Cpp2IlInjected.Address(RVA = "0x1538850", Offset = "0x1537250", VA = "0x181538850")]
		private void GridObjectChangedEvent(object sender, bool editModeResynchronize)
		{
			//Discarded unreachable code: IL_003e
			//IL_0037: Expected O, but got I8
			if (gridEditModeSystem.IsQuitting && !editModeResynchronize)
			{
				CancellationTokenSource cancellationTokenSource = this.cancellationTokenSource;
				if (cancellationTokenSource != null)
				{
					cancellationTokenSource.Cancel();
					this.cancellationTokenSource.Dispose();
					this.cancellationTokenSource = (CancellationTokenSource)0;
				}
				Init();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001391")]
		[Cpp2IlInjected.Address(RVA = "0x15388D0", Offset = "0x15372D0", VA = "0x1815388D0")]
		private void Init()
		{
			//Discarded unreachable code: IL_002e
			GridObjectScript gridObjectScript = GridObjectScript;
			if ((long)gridObjectScript.GridObject != 0)
			{
				CancellationTokenSource cancellationTokenSource = (this.cancellationTokenSource = new CancellationTokenSource());
			}
			GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
			InitWithGridObject(_003CGridObject_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x6001392")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void InitWithGridObject(GridObject gridObject);

		[Cpp2IlInjected.Token(Token = "0x6001393")]
		[Cpp2IlInjected.Address(RVA = "0x15387E0", Offset = "0x15371E0", VA = "0x1815387E0")]
		private void CancelTokenSource()
		{
			//Discarded unreachable code: IL_0018
			CancellationTokenSource cancellationTokenSource = this.cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				cancellationTokenSource.Dispose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001394")]
		[Cpp2IlInjected.Address(RVA = "0x1538830", Offset = "0x1537230", VA = "0x181538830", Slot = "4")]
		public CancellationToken GetCancellationToken()
		{
			CancellationTokenSource cancellationTokenSource = this.cancellationTokenSource;
			if (cancellationTokenSource != null)
			{
				return cancellationTokenSource.Token;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001395")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected GridObjectStateUser()
		{
		}
	}
}
