using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Scene;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Characters.Critters;
using Mdl.Environments;
using Mdl.Furnitures;
using Mdl.Graphic;
using Mdl.Graphic.Weather;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Navigation.ControlSchemes;
using Mdl.Streaming;
using Mdl.Systems;
using Mdl.Ui;
using Meta;
using Meta.Grids;
using Meta.Online;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000406")]
	public class GridEditMode : GridObjectGizmoSystem
	{
		[Cpp2IlInjected.Token(Token = "0x2000407")]
		private class CommandStack
		{
			[Cpp2IlInjected.Token(Token = "0x2000408")]
			public delegate void CommandAddedOrRemovedDelegate(Command command);

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001A2F")]
			private readonly Stack<Command> commands = (Stack<Command>)(object)new Stack<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001A30")]
			private Task lastUndo;

			[Cpp2IlInjected.Token(Token = "0x17000232")]
			public bool HasCommands
			{
				[Cpp2IlInjected.Token(Token = "0x6001179")]
				[Cpp2IlInjected.Address(RVA = "0x184BBF0", Offset = "0x184A5F0", VA = "0x18184BBF0")]
				get
				{
					//Discarded unreachable code: IL_0009
					Stack<Command> stack = commands;
					bool result = default(bool);
					return result;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000025")]
			public event CommandAddedOrRemovedDelegate CommandAddedEvent
			{
				[Cpp2IlInjected.Token(Token = "0x600117B")]
				[Cpp2IlInjected.Address(RVA = "0x184BAB0", Offset = "0x184A4B0", VA = "0x18184BAB0")]
				[CompilerGenerated]
				add
				{
					CommandAddedOrRemovedDelegate commandAddedEvent = this.CommandAddedEvent;
					Delegate @delegate = Delegate.Combine(commandAddedEvent, value);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						while ((object)@delegate != commandAddedEvent)
						{
						}
						return;
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x600117C")]
				[Cpp2IlInjected.Address(RVA = "0x184BC40", Offset = "0x184A640", VA = "0x18184BC40")]
				[CompilerGenerated]
				remove
				{
					CommandAddedOrRemovedDelegate commandAddedEvent = this.CommandAddedEvent;
					Delegate @delegate = Delegate.Remove(commandAddedEvent, value);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						while ((object)@delegate != commandAddedEvent)
						{
						}
						return;
					}
					throw new InvalidCastException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000026")]
			public event CommandAddedOrRemovedDelegate CommandRemovedEvent
			{
				[Cpp2IlInjected.Token(Token = "0x600117D")]
				[Cpp2IlInjected.Address(RVA = "0x184BB50", Offset = "0x184A550", VA = "0x18184BB50")]
				[CompilerGenerated]
				add
				{
					CommandAddedOrRemovedDelegate commandRemovedEvent = this.CommandRemovedEvent;
					Delegate @delegate = Delegate.Combine(commandRemovedEvent, value);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						while ((object)@delegate != commandRemovedEvent)
						{
						}
						return;
					}
					throw new InvalidCastException();
				}
				[Cpp2IlInjected.Token(Token = "0x600117E")]
				[Cpp2IlInjected.Address(RVA = "0x184BCE0", Offset = "0x184A6E0", VA = "0x18184BCE0")]
				[CompilerGenerated]
				remove
				{
					CommandAddedOrRemovedDelegate commandRemovedEvent = this.CommandRemovedEvent;
					Delegate @delegate = Delegate.Remove(commandRemovedEvent, value);
					if ((object)@delegate == null || (object)@delegate != null)
					{
						while ((object)@delegate != commandRemovedEvent)
						{
						}
						return;
					}
					throw new InvalidCastException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600117A")]
			[Cpp2IlInjected.Address(RVA = "0x184B740", Offset = "0x184A140", VA = "0x18184B740")]
			public Command Peek()
			{
				//Discarded unreachable code: IL_000c
				return (Command)((Stack<T>)(object)commands).Peek();
			}

			[Cpp2IlInjected.Token(Token = "0x600117F")]
			[Cpp2IlInjected.Address(RVA = "0x184A770", Offset = "0x1849170", VA = "0x18184A770")]
			public void DoCommand(Command newCommand)
			{
				int num = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}

			[Cpp2IlInjected.Token(Token = "0x6001180")]
			[Cpp2IlInjected.Address(RVA = "0x184A650", Offset = "0x1849050", VA = "0x18184A650")]
			[AsyncStateMachine(typeof(_003CDoCommandAsync_003Ed__13))]
			private Task DoCommandAsync(Command newCommand)
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001181")]
			[Cpp2IlInjected.Address(RVA = "0x184B930", Offset = "0x184A330", VA = "0x18184B930")]
			[AsyncStateMachine(typeof(_003CUndoCommand_003Ed__14))]
			public Task UndoCommand()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001182")]
			[Cpp2IlInjected.Address(RVA = "0x184B6E0", Offset = "0x184A0E0", VA = "0x18184B6E0")]
			public Command GetLastCommand()
			{
				//Discarded unreachable code: IL_000c
				return (Command)((Stack<T>)(object)commands).Peek();
			}

			[Cpp2IlInjected.Token(Token = "0x6001183")]
			[Cpp2IlInjected.Address(RVA = "0x184A600", Offset = "0x1849000", VA = "0x18184A600")]
			public void ClearCommands()
			{
				//Discarded unreachable code: IL_000c
				((Stack<T>)(object)commands).Clear();
			}

			[Cpp2IlInjected.Token(Token = "0x6001184")]
			[Cpp2IlInjected.Address(RVA = "0x184B610", Offset = "0x184A010", VA = "0x18184B610")]
			public List<Command> GetCommandsInOrder()
			{
				//IL_0018: Expected O, but got I4
				IEnumerable<Command> enumerable = (IEnumerable<Command>)Enumerable.Reverse<Command>((IEnumerable<>)commands);
				Func<Command, Command> func = (Func<Command, Command>)(object)new Func<T, TResult>(splitClearing);
				int num = 0;
				return (List<Command>)(object)Enumerable.ToList<Command>(Enumerable.Select<Command, Command>((IEnumerable<>)enumerable, (Func<, >)(object)func));
				[Cpp2IlInjected.Token(Token = "0x6001189")]
				[Cpp2IlInjected.Address(RVA = "0x184B7B0", Offset = "0x184A1B0", VA = "0x18184B7B0")]
				static Command splitClearing(Command command)
				{
					if (command != null)
					{
						int num2 = 0;
						if (command != null)
						{
							return command;
						}
					}
					return command;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6001185")]
			[Cpp2IlInjected.Address(RVA = "0x184A9F0", Offset = "0x18493F0", VA = "0x18184A9F0")]
			public List<Command> GetCleanedCommandsInOrder()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6001186")]
			[Cpp2IlInjected.Address(RVA = "0x184A8D0", Offset = "0x18492D0", VA = "0x18184A8D0")]
			private static List<Command> ExpandCommands(List<Command> commandsInOrder)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x6001187")]
			[Cpp2IlInjected.Address(RVA = "0x184BA30", Offset = "0x184A430", VA = "0x18184BA30")]
			public CommandStack()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200040D")]
		private abstract class Command
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001A43")]
			private bool done;

			[Cpp2IlInjected.Token(Token = "0x17000233")]
			public virtual bool CanUndoCommand
			{
				[Cpp2IlInjected.Token(Token = "0x600119A")]
				[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "4")]
				get
				{
					return true;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000234")]
			public virtual IEnumerable<Command> ExpandBefore
			{
				[Cpp2IlInjected.Token(Token = "0x600119F")]
				[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
				get
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000235")]
			public virtual IEnumerable<Command> ExpandAfter
			{
				[Cpp2IlInjected.Token(Token = "0x60011A0")]
				[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "10")]
				get
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6001198")]
			[Cpp2IlInjected.Address(RVA = "0x184BD80", Offset = "0x184A780", VA = "0x18184BD80")]
			public void Do()
			{
				if (!done)
				{
					PerformDo();
					done = true;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6001199")]
			[Cpp2IlInjected.Address(RVA = "0x184BE70", Offset = "0x184A870", VA = "0x18184BE70")]
			[AsyncStateMachine(typeof(_003CUndo_003Ed__2))]
			public Task Undo()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x600119B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			protected abstract void PerformDo();

			[Cpp2IlInjected.Token(Token = "0x600119C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			protected abstract Task PerformUndo();

			[Cpp2IlInjected.Token(Token = "0x600119D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct);

			[Cpp2IlInjected.Token(Token = "0x600119E")]
			[Cpp2IlInjected.Address(RVA = "0x184BDB0", Offset = "0x184A7B0", VA = "0x18184BDB0", Slot = "8")]
			public virtual Task RemoveWhilePending()
			{
				int num = 0;
				return Task.CompletedTask;
			}

			[Cpp2IlInjected.Token(Token = "0x60011A1")]
			[Cpp2IlInjected.Address(RVA = "0x184BE00", Offset = "0x184A800", VA = "0x18184BE00", Slot = "3")]
			public override string ToString()
			{
				//Discarded unreachable code: IL_000c
				return GetType().Name;
			}

			[Cpp2IlInjected.Token(Token = "0x60011A2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			protected Command()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200040F")]
		private abstract class GridCommand : Command
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001A49")]
			private GridObjectScript gridObjectScript;

			[Cpp2IlInjected.Token(Token = "0x17000236")]
			public GridScript GridScript
			{
				[Cpp2IlInjected.Token(Token = "0x60011A5")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CGridScript_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60011A6")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				private set
				{
					_003CGridScript_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000237")]
			public GridObjectScript GridObjectScript
			{
				[Cpp2IlInjected.Token(Token = "0x60011A7")]
				[Cpp2IlInjected.Address(RVA = "0x184DA70", Offset = "0x184C470", VA = "0x18184DA70")]
				get
				{
					//Discarded unreachable code: IL_0039
					//IL_0010: Expected O, but got I4
					GridObjectScript gridObjectScript = this.gridObjectScript;
					int num = 0;
					if (gridObjectScript == (UnityEngine.Object)num)
					{
						GridScript gridScript = GridScript;
						uint gridObjectID = GridObjectID;
						GridObjectScript gridObjectScript2 = (this.gridObjectScript = gridScript.GetGridObjectScript(gridObjectID));
					}
					return this.gridObjectScript;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000238")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4001A4A")]
			public uint GridID
			{
				[Cpp2IlInjected.Token(Token = "0x60011A8")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60011A9")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				protected set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000239")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C"), Cpp2IlInjected.Token(Token = "0x4001A4B")]
			public uint? ResolvedGridID
			{
				[Cpp2IlInjected.Token(Token = "0x60011AA")]
				[Cpp2IlInjected.Address(RVA = "0x13AD1D0", Offset = "0x13ABBD0", VA = "0x1813AD1D0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60011AB")]
				[Cpp2IlInjected.Address(RVA = "0xEFF4B0", Offset = "0xEFDEB0", VA = "0x180EFF4B0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700023A")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x4001A4C")]
			public uint GridObjectID
			{
				[Cpp2IlInjected.Token(Token = "0x60011AC")]
				[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60011AD")]
				[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700023B")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4001A4D")]
			public uint? ResolvedGridObjectID
			{
				[Cpp2IlInjected.Token(Token = "0x60011AE")]
				[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60011AF")]
				[Cpp2IlInjected.Address(RVA = "0x7B2EF0", Offset = "0x7B18F0", VA = "0x1807B2EF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x60011B0")]
			[Cpp2IlInjected.Address(RVA = "0x184D9B0", Offset = "0x184C3B0", VA = "0x18184D9B0")]
			protected GridCommand(GridScript gridScript, GridObjectScript gridObjectScript)
			{
				//Discarded unreachable code: IL_000d
				uint iD_ = gridObjectScript.GridObject.iD_;
			}

			[Cpp2IlInjected.Token(Token = "0x60011B1")]
			[Cpp2IlInjected.Address(RVA = "0x184D9E0", Offset = "0x184C3E0", VA = "0x18184D9E0")]
			protected GridCommand(GridScript gridScript, GridObjectScript gridObjectScript, uint gridObjectID)
			{
				//Discarded unreachable code: IL_002f
				GridScript = gridScript;
				this.gridObjectScript = gridObjectScript;
				uint num = (GridID = GridScript.GridID);
				GridObjectID = gridObjectID;
			}

			[Cpp2IlInjected.Token(Token = "0x60011B2")]
			[Cpp2IlInjected.Address(RVA = "0x184D7A0", Offset = "0x184C1A0", VA = "0x18184D7A0")]
			public void ChangeGrid(GridScript newGridScript, uint newGridObjectID)
			{
				//Discarded unreachable code: IL_0022
				GridScript = newGridScript;
				uint gridID = GridScript.GridID;
				GridObjectID = newGridObjectID;
				GridID = gridID;
			}

			[Cpp2IlInjected.Token(Token = "0x60011B3")]
			[Cpp2IlInjected.Address(RVA = "0x184D7F0", Offset = "0x184C1F0", VA = "0x18184D7F0", Slot = "11")]
			public unsafe virtual void ResolveIDs(uint gridID, (uint previous, uint resolved) gridObjectID, [Optional] (uint previous, uint resolved)? subGridID)
			{
				//IL_0019: Expected I4, but got O
				//IL_0020: Expected O, but got I8
				//IL_003f: Expected I4, but got O
				//IL_0047: Expected O, but got I8
				if (GridID == gridID && (IntPtr)(int)GridObjectID == (IntPtr)gridObjectID)
				{
					uint num = (uint)(int)((ValueTuple<, >*)(&gridObjectID))->Item1;
					ulong num2 = default(ulong);
					ResolvedGridObjectID = (uint?)(object)num2;
				}
				uint num3 = GridID;
				(uint, uint) value = ((uint, uint))((T?*)subGridID)->Value;
				if ((IntPtr)(int)num3 == (IntPtr)value)
				{
					uint num4 = (uint)(int)((ValueTuple<, >)((T?*)subGridID)->Value).Item1;
					ulong num5 = default(ulong);
					ResolvedGridID = (uint?)(object)num5;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60011B4")]
			[Cpp2IlInjected.Address(RVA = "0x184D8E0", Offset = "0x184C2E0", VA = "0x18184D8E0", Slot = "3")]
			public override string ToString()
			{
				//Discarded unreachable code: IL_0028
				string name = GetType().Name;
				uint num = GridID;
				uint num2 = GridObjectID;
				return $"{name}(GridID={name}, GridObjectID={name})";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000410")]
		private abstract class AddCommand : GridCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001A4E")]
			protected GridObject onGridGridObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4001A4F")]
			private uint? subGridID;

			[Cpp2IlInjected.Token(Token = "0x1700023C")]
			public GridObject NewGridObject
			{
				[Cpp2IlInjected.Token(Token = "0x60011B5")]
				[Cpp2IlInjected.Address(RVA = "0x1848D40", Offset = "0x1847740", VA = "0x181848D40")]
				get
				{
					//Discarded unreachable code: IL_0014
					GridObject gridObject = onGridGridObject;
					if (gridObject == null)
					{
						GridObjectScript gridObjectScript = base.GridObjectScript;
					}
					return gridObject;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700023D")]
			public IGridMovementRestriction GridMovementRestriction
			{
				[Cpp2IlInjected.Token(Token = "0x60011B6")]
				[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
				[CompilerGenerated]
				get
				{
					return _003CGridMovementRestriction_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60011B7")]
				[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
				[CompilerGenerated]
				private set
				{
					_003CGridMovementRestriction_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60011B8")]
			[Cpp2IlInjected.Address(RVA = "0x1848CF0", Offset = "0x18476F0", VA = "0x181848CF0")]
			public AddCommand(GridScript gridScript, GridObjectScript gridObjectScript, IGridMovementRestriction gridMovementRestriction)
				: base(gridScript, gridObjectScript, gridObjectScript.GridObject.iD_)
			{
				GridMovementRestriction = gridMovementRestriction;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60011B9")]
			[Cpp2IlInjected.Address(RVA = "0x18485A0", Offset = "0x1846FA0", VA = "0x1818485A0", Slot = "5")]
			protected override void PerformDo()
			{
				//Discarded unreachable code: IL_00a2
				//IL_006b: Expected O, but got I4
				//IL_007f: Expected O, but got I8
				GridScript gridScript = base.GridObjectScript.GridScript;
				GridObjectScript gridObjectScript = base.GridObjectScript;
				GridObject gridObject = gridScript.AddObjectToEditGrid(gridObjectScript);
				if (gridObject != null)
				{
					GridObject gridObject2 = gridObject.Clone();
				}
				onGridGridObject = gridObject;
				if ((long)onGridGridObject == 0)
				{
					InvalidOperationException ex = new InvalidOperationException("The GridObject cannot be added.");
					/*Error: Unexpected end of block*/;
				}
				uint num = (base.GridID = base.GridObjectScript.GridScript.GridID);
				SubGridScript component = base.GridObjectScript.GetComponent<SubGridScript>();
				int num2 = 0;
				if (component != (UnityEngine.Object)num2)
				{
					uint gridID = component.GridID;
					ulong num3 = default(ulong);
					subGridID = (uint?)(object)num3;
				}
				ObjectAdded onObjectAdded = GridEditMode.OnObjectAdded;
				if (onObjectAdded != null)
				{
					GameObject gameObject = base.GridObjectScript.gameObject;
					onObjectAdded(gameObject);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60011BA")]
			[Cpp2IlInjected.Address(RVA = "0x18487B0", Offset = "0x18471B0", VA = "0x1818487B0", Slot = "6")]
			protected override Task PerformUndo()
			{
				//Discarded unreachable code: IL_0079
				//IL_0017: Expected O, but got I4
				GridScript gridScript = base.GridScript;
				GridObjectScript gridObjectScript = base.gridObjectScript;
				int num = 0;
				if (gridObjectScript == (UnityEngine.Object)num)
				{
					GridScript gridScript2 = base.GridScript;
					uint gridObjectID = base.GridObjectID;
					GridObjectScript gridObjectScript2 = (base.gridObjectScript = gridScript2.GetGridObjectScript(gridObjectID));
				}
				GridObjectScript gridObjectScript3 = base.gridObjectScript;
				bool flag = gridScript.RemoveObject(gridObjectScript3, destroyGameObject: true);
				ObjectRemoved onObjectRemoved = GridEditMode.OnObjectRemoved;
				if (onObjectRemoved != null)
				{
					GameObject gameObject = base.GridObjectScript.gameObject;
					onObjectRemoved(gameObject);
				}
				int num2 = 0;
				return Task.CompletedTask;
			}

			[Cpp2IlInjected.Token(Token = "0x60011BB")]
			[Cpp2IlInjected.Address(RVA = "0x1848910", Offset = "0x1847310", VA = "0x181848910")]
			protected void ResolveIDsInRemainingCommands(Queue<Command> remainingCommands, uint resolvedGridObjectID)
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000411")]
		private class AddFromBackpackCommand : AddCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4001A51")]
			public readonly uint InventoryID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4001A52")]
			public readonly Item Item;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4001A53")]
			public readonly int Amount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4001A54")]
			public readonly ItemState ItemState;

			[Cpp2IlInjected.Token(Token = "0x60011BC")]
			[Cpp2IlInjected.Address(RVA = "0x1848EE0", Offset = "0x18478E0", VA = "0x181848EE0")]
			public AddFromBackpackCommand(uint inventoryID, Item item, int amount, ItemState itemState, GridObjectScript gridObjectScript, GridScript gridScript, IGridMovementRestriction gridMovementRestriction)
			{
				//IL_000e: Expected O, but got I4
				//IL_0015: Expected O, but got I4
				//IL_0023: Expected O, but got I4
				int itemID = item.ItemID;
				base.GridMovementRestriction = (IGridMovementRestriction)0;
				ItemState = (ItemState)0;
				InventoryID = inventoryID;
				Item = (Item)itemID;
				Amount = amount;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60011BD")]
			[Cpp2IlInjected.Address(RVA = "0x1848D70", Offset = "0x1847770", VA = "0x181848D70", Slot = "7")]
			[AsyncStateMachine(typeof(_003CCommit_003Ed__5))]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000413")]
		private class AddFromCatalogCommand : AddCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4001A5D")]
			public readonly uint InventoryID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4001A5E")]
			public readonly Item Item;

			[Cpp2IlInjected.Token(Token = "0x1700023E")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x60"), Cpp2IlInjected.Token(Token = "0x4001A5F")]
			public bool IsRemovedPreviewWithSubGrid
			{
				[Cpp2IlInjected.Token(Token = "0x60011C0")]
				[Cpp2IlInjected.Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60011C1")]
				[Cpp2IlInjected.Address(RVA = "0x63FD00", Offset = "0x63E700", VA = "0x18063FD00")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x60011C2")]
			[Cpp2IlInjected.Address(RVA = "0x18490D0", Offset = "0x1847AD0", VA = "0x1818490D0")]
			public AddFromCatalogCommand(uint inventoryID, Item item, GridObjectScript gridObjectScript, GridScript gridScript, IGridMovementRestriction gridMovementRestriction)
			{
				//Discarded unreachable code: IL_0024
				//IL_0015: Expected O, but got I4
				//IL_0023: Expected O, but got I4
				int itemID = item.ItemID;
				GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
				base.GridMovementRestriction = (IGridMovementRestriction)0;
				InventoryID = inventoryID;
				Item = (Item)itemID;
			}

			[Cpp2IlInjected.Token(Token = "0x60011C3")]
			[Cpp2IlInjected.Address(RVA = "0x1848F70", Offset = "0x1847970", VA = "0x181848F70", Slot = "7")]
			[AsyncStateMachine(typeof(_003CCommit_003Ed__7))]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000415")]
		private class AddBuildingCommand : AddCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4001A69")]
			private readonly Item buildingItem;

			[Cpp2IlInjected.Token(Token = "0x60011C6")]
			[Cpp2IlInjected.Address(RVA = "0x1848540", Offset = "0x1846F40", VA = "0x181848540")]
			public AddBuildingCommand(Item buildingItem, GridScript gridScript, GridObjectScript gridObjectScript, IGridMovementRestriction gridMovementRestriction)
			{
				//Discarded unreachable code: IL_002b
				//IL_0023: Expected O, but got I4
				//IL_002a: Expected O, but got I4
				int itemID = buildingItem.ItemID;
				base._002Ector(gridScript, gridObjectScript, gridObjectScript.GridObject.iD_);
				base.GridMovementRestriction = (IGridMovementRestriction)0;
				this.buildingItem = (Item)itemID;
			}

			[Cpp2IlInjected.Token(Token = "0x60011C7")]
			[Cpp2IlInjected.Address(RVA = "0x18483D0", Offset = "0x1846DD0", VA = "0x1818483D0", Slot = "7")]
			[AsyncStateMachine(typeof(_003CCommit_003Ed__2))]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000417")]
		private class AddLandscapingCommand : AddCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4001A72")]
			private readonly Item landscapingItem;

			[Cpp2IlInjected.Token(Token = "0x60011CA")]
			[Cpp2IlInjected.Address(RVA = "0x1848540", Offset = "0x1846F40", VA = "0x181848540")]
			public AddLandscapingCommand(Item landscapingItem, GridScript gridScript, GridObjectScript gridObjectScript, IGridMovementRestriction gridMovementRestriction)
			{
				//Discarded unreachable code: IL_002b
				//IL_0023: Expected O, but got I4
				//IL_002a: Expected O, but got I4
				int itemID = landscapingItem.ItemID;
				base._002Ector(gridScript, gridObjectScript, gridObjectScript.GridObject.iD_);
				base.GridMovementRestriction = (IGridMovementRestriction)0;
				this.landscapingItem = (Item)itemID;
			}

			[Cpp2IlInjected.Token(Token = "0x60011CB")]
			[Cpp2IlInjected.Address(RVA = "0x1849140", Offset = "0x1847B40", VA = "0x181849140", Slot = "7")]
			[AsyncStateMachine(typeof(_003CCommit_003Ed__2))]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000419")]
		private abstract class RemoveCommand : GridCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001A7B")]
			public readonly GridObject GridObjectCopy;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4001A7C")]
			public readonly uint? SubGridID;

			[Cpp2IlInjected.Token(Token = "0x1700023F")]
			public IGridMovementRestriction GridMovementRestriction
			{
				[Cpp2IlInjected.Token(Token = "0x60011CE")]
				[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
				[CompilerGenerated]
				get
				{
					return _003CGridMovementRestriction_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60011CF")]
				[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
				[CompilerGenerated]
				private set
				{
					_003CGridMovementRestriction_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60011D0")]
			[Cpp2IlInjected.Address(RVA = "0x184E380", Offset = "0x184CD80", VA = "0x18184E380")]
			public RemoveCommand(GridScript gridScript, GridObjectScript gridObjectScript, GridObject initialGridObject, IGridMovementRestriction gridMovementRestriction)
				: base(gridScript, gridObjectScript, initialGridObject.iD_)
			{
				//IL_0027: Expected O, but got I4
				//IL_003a: Expected O, but got I8
				//IL_0041: Expected O, but got I4
				GridObjectCopy = initialGridObject;
				SubGridScript component = gridObjectScript.GetComponent<SubGridScript>();
				int num = 0;
				if (component != (UnityEngine.Object)num)
				{
					uint gridID = component.GridID;
					ulong num2 = default(ulong);
					SubGridID = (uint?)(object)num2;
				}
				GridMovementRestriction = (IGridMovementRestriction)0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60011D1")]
			[Cpp2IlInjected.Address(RVA = "0x184DE60", Offset = "0x184C860", VA = "0x18184DE60", Slot = "5")]
			protected override void PerformDo()
			{
				//Discarded unreachable code: IL_0098
				//IL_0036: Expected O, but got I4
				//IL_0097: Expected O, but got I4
				//IL_0097: Expected O, but got I4
				ObjectRemoved onObjectRemoved = GridEditMode.OnObjectRemoved;
				if (onObjectRemoved != null)
				{
					GameObject gameObject = base.GridObjectScript.gameObject;
					onObjectRemoved(gameObject);
				}
				GridScript gridScript = base.GridScript;
				GridObjectScript gridObjectScript = base.gridObjectScript;
				int num = 0;
				if (gridObjectScript == (UnityEngine.Object)num)
				{
					GridScript gridScript2 = base.GridScript;
					uint gridObjectID = base.GridObjectID;
					GridObjectScript gridObjectScript2 = (base.gridObjectScript = gridScript2.GetGridObjectScript(gridObjectID));
				}
				GridObjectScript gridObjectScript3 = base.gridObjectScript;
				if (!gridScript.RemoveObject(gridObjectScript3, destroyGameObject: true))
				{
					UnityEngine.Object.Destroy(base.GridObjectScript.gameObject);
					return;
				}
				int editModeResynchronize = 0;
				int num2 = 0;
				int num3 = 0;
				GridObjectScript gridObjectScript4 = default(GridObjectScript);
				gridObjectScript4.Init((GridScript)num3, (GridObject)num2, (byte)editModeResynchronize != 0);
			}

			[Cpp2IlInjected.Token(Token = "0x60011D2")]
			[Cpp2IlInjected.Address(RVA = "0x184E010", Offset = "0x184CA10", VA = "0x18184E010", Slot = "6")]
			protected override Task PerformUndo()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x60011D3")]
			[Cpp2IlInjected.Address(RVA = "0x184E010", Offset = "0x184CA10", VA = "0x18184E010")]
			[AsyncStateMachine(typeof(_003CPerformUndoTask_003Ed__9))]
			private Task PerformUndoTask()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x60011D4")]
			[Cpp2IlInjected.Address(RVA = "0x184E110", Offset = "0x184CB10", VA = "0x18184E110", Slot = "3")]
			public override string ToString()
			{
				//Discarded unreachable code: IL_0087
				//IL_003c: Expected O, but got I4
				//IL_0057: Expected O, but got I4
				//IL_007b: Expected O, but got I4
				object[] array;
				uint num;
				while (true)
				{
					array = new object[4];
					string name = GetType().Name;
					if (name != null && name == null)
					{
						continue;
					}
					array[0] = name;
					num = base.GridID;
					if (num != 0 && num == 0)
					{
						continue;
					}
					array[1] = num;
					uint num2 = base.GridObjectID;
					num = num2;
					if (num2 == 0 || num2 != 0)
					{
						array[2] = num;
						uint iD_ = GridObjectCopy.iD_;
						num = iD_;
						if (iD_ == 0 || iD_ != 0)
						{
							break;
						}
					}
				}
				array[3] = num;
				return string.Format("{0}(GridID={1}, GridObjectID={2}, InitialGridObjectID={3})", array);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200041B")]
		private class RemoveBackpackObjectCommand : RemoveCommand
		{
			[Cpp2IlInjected.Token(Token = "0x60011D7")]
			[Cpp2IlInjected.Address(RVA = "0x184DD60", Offset = "0x184C760", VA = "0x18184DD60")]
			public RemoveBackpackObjectCommand(GridScript gridScript, GridObjectScript gridObjectScript, GridObject initialGridObject, IGridMovementRestriction gridMovementRestriction)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60011D8")]
			[Cpp2IlInjected.Address(RVA = "0x184DCA0", Offset = "0x184C6A0", VA = "0x18184DCA0", Slot = "7")]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				//IL_0018: Expected I4, but got O
				PickUpContainerItem.Types.Request request = new PickUpContainerItem.Types.Request();
				uint? num = ((GridCommand)this).ResolvedGridID;
				if ((object)num == null)
				{
				}
				request.gridID_ = (uint)(int)num;
				uint num2 = (request.gridObjectID_ = GridObjectCopy.iD_);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200041C")]
		private class RemoveCatalogObjectCommand : RemoveCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4001A82")]
			public readonly bool IsPreview = false;

			[Cpp2IlInjected.Token(Token = "0x60011D9")]
			[Cpp2IlInjected.Address(RVA = "0x184DE30", Offset = "0x184C830", VA = "0x18184DE30")]
			public RemoveCatalogObjectCommand(GridScript gridScript, GridObjectScript gridObjectScript, GridObject initialGridObject, bool isPreview, IGridMovementRestriction gridMovementRestriction)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60011DA")]
			[Cpp2IlInjected.Address(RVA = "0x184DD70", Offset = "0x184C770", VA = "0x18184DD70", Slot = "7")]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				//IL_0018: Expected I4, but got O
				PickUpListItem.Types.Request request = new PickUpListItem.Types.Request();
				uint? num = ((GridCommand)this).ResolvedGridID;
				if ((object)num == null)
				{
				}
				request.gridID_ = (uint)(int)num;
				uint num2 = (request.gridObjectID_ = GridObjectCopy.iD_);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200041D")]
		private class RemoveHouseCommand : RemoveCommand
		{
			[Cpp2IlInjected.Token(Token = "0x60011DB")]
			[Cpp2IlInjected.Address(RVA = "0x184DD60", Offset = "0x184C760", VA = "0x18184DD60")]
			public RemoveHouseCommand(GridScript gridScript, GridObjectScript gridObjectScript, GridObject initialGridObject, IGridMovementRestriction gridMovementRestriction)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60011DC")]
			[Cpp2IlInjected.Address(RVA = "0x184F000", Offset = "0x184DA00", VA = "0x18184F000", Slot = "7")]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				//IL_0018: Expected I4, but got O
				RemoveHouse.Types.Request request = new RemoveHouse.Types.Request();
				uint? num = ((GridCommand)this).ResolvedGridID;
				if ((object)num == null)
				{
				}
				request.gridID_ = (uint)(int)num;
				uint num2 = (request.gridObjectID_ = GridObjectCopy.iD_);
				TransactionService.TransactionServiceClient transactionService = client.TransactionService;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200041E")]
		private class RemoveNonInventoryObjectCommand : RemoveCommand
		{
			[Cpp2IlInjected.Token(Token = "0x60011DD")]
			[Cpp2IlInjected.Address(RVA = "0x184DD60", Offset = "0x184C760", VA = "0x18184DD60")]
			public RemoveNonInventoryObjectCommand(GridScript gridScript, GridObjectScript gridObjectScript, GridObject initialGridObject, IGridMovementRestriction gridMovementRestriction)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60011DE")]
			[Cpp2IlInjected.Address(RVA = "0x184F0D0", Offset = "0x184DAD0", VA = "0x18184F0D0", Slot = "7")]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				//IL_0018: Expected I4, but got O
				RemoveFromGrid.Types.Request request = new RemoveFromGrid.Types.Request();
				uint? num = ((GridCommand)this).ResolvedGridID;
				if ((object)num == null)
				{
				}
				request.gridID_ = (uint)(int)num;
				uint num2 = (request.gridObjectID_ = GridObjectCopy.iD_);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200041F")]
		private class UpdateTransformCommand : GridCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001A83")]
			protected GridObject newGridObjectTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4001A84")]
			private readonly GridObject initialGridObjectTransform;

			[Cpp2IlInjected.Token(Token = "0x60011DF")]
			[Cpp2IlInjected.Address(RVA = "0x185DC00", Offset = "0x185C600", VA = "0x18185DC00")]
			public UpdateTransformCommand(GridScript gridScript, GridObjectScript gridObjectScript, GridObject initialGridObjectTransform)
				: base(gridScript, gridObjectScript, initialGridObjectTransform.iD_)
			{
				GridObjectScript gridObjectScript2 = base.GridObjectScript;
				GridObject gridObject = default(GridObject);
				GridObject gridObject2 = (newGridObjectTransform = gridObject.Clone());
				this.initialGridObjectTransform = initialGridObjectTransform;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60011E0")]
			[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
			protected override void PerformDo()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x60011E1")]
			[Cpp2IlInjected.Address(RVA = "0x184C3B0", Offset = "0x184ADB0", VA = "0x18184C3B0", Slot = "6")]
			protected override Task PerformUndo()
			{
				//Discarded unreachable code: IL_002a
				GridObjectScript gridObjectScript = base.GridObjectScript;
				GridPosition position = initialGridObjectTransform.Position;
				int num = 0;
				GridOrientation orientation_ = initialGridObjectTransform.orientation_;
				int num2 = 0;
				return Task.CompletedTask;
			}

			[Cpp2IlInjected.Token(Token = "0x60011E2")]
			[Cpp2IlInjected.Address(RVA = "0x185DAD0", Offset = "0x185C4D0", VA = "0x18185DAD0", Slot = "7")]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				//IL_0018: Expected I4, but got O
				UpdateGridObjectTransform.Types.Request request = new UpdateGridObjectTransform.Types.Request();
				uint? num = base.ResolvedGridID;
				if ((object)num == null)
				{
				}
				request.gridID_ = (uint)(int)num;
				uint gridObjectID_ = default(uint);
				if ((object)base.ResolvedGridObjectID == null)
				{
					gridObjectID_ = base.GridObjectID;
				}
				request.gridObjectID_ = gridObjectID_;
				int num2 = (request.newX_ = newGridObjectTransform.x_);
				int num3 = (request.newY_ = newGridObjectTransform.y_);
				GridOrientation gridOrientation = (request.newOrientation_ = newGridObjectTransform.orientation_);
				int itemID = newGridObjectTransform.ItemID;
				bool clearArea_ = default(bool);
				request.clearArea_ = clearArea_;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000420")]
		private class SwitchGridCommand : GridCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001A85")]
			private readonly GridScript previousGridScript;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4001A86")]
			private readonly GridObject initialGridObjectTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4001A87")]
			private GridObject onNewGridTransform;

			[Cpp2IlInjected.Token(Token = "0x17000240")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x58"), Cpp2IlInjected.Token(Token = "0x4001A88")]
			public uint PreviousGridID
			{
				[Cpp2IlInjected.Token(Token = "0x60011E3")]
				[Cpp2IlInjected.Address(RVA = "0x63F810", Offset = "0x63E210", VA = "0x18063F810")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60011E4")]
				[Cpp2IlInjected.Address(RVA = "0x63FBF0", Offset = "0x63E5F0", VA = "0x18063FBF0")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000241")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x5C"), Cpp2IlInjected.Token(Token = "0x4001A89")]
			public uint? ResolvedPreviousGridID
			{
				[Cpp2IlInjected.Token(Token = "0x60011E5")]
				[Cpp2IlInjected.Address(RVA = "0x184FDD0", Offset = "0x184E7D0", VA = "0x18184FDD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60011E6")]
				[Cpp2IlInjected.Address(RVA = "0x184FDE0", Offset = "0x184E7E0", VA = "0x18184FDE0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x60011E7")]
			[Cpp2IlInjected.Address(RVA = "0x184FD50", Offset = "0x184E750", VA = "0x18184FD50")]
			public SwitchGridCommand(GridScript gridScript, GridObjectScript gridObjectScript, GridScript previousGridScript, GridObject initialGridObjectTransform)
			{
				//Discarded unreachable code: IL_001d
				//IL_000e: Expected O, but got I4
				this.previousGridScript = previousGridScript;
				this.initialGridObjectTransform = (GridObject)0;
				uint num = (PreviousGridID = previousGridScript.GridID);
			}

			[Cpp2IlInjected.Token(Token = "0x60011E8")]
			[Cpp2IlInjected.Address(RVA = "0x184F7B0", Offset = "0x184E1B0", VA = "0x18184F7B0", Slot = "5")]
			protected override void PerformDo()
			{
				//IL_002e: Expected O, but got I4
				//IL_00d1: Expected O, but got I4
				GridScript gridScript = previousGridScript;
				GridObject gridObject = initialGridObjectTransform;
				gridScript.ForgetEditObject(gridObject);
				GridScript gridScript2 = base.GridScript;
				GridObjectScript gridObjectScript = base.gridObjectScript;
				int num = 0;
				if (gridObjectScript == (UnityEngine.Object)num)
				{
					GridScript gridScript3 = base.GridScript;
					uint gridObjectID = base.GridObjectID;
					GridObjectScript gridObjectScript2 = (base.gridObjectScript = gridScript3.GetGridObjectScript(gridObjectID));
				}
				int itemID = base.gridObjectScript.GridObject.ItemID;
				GridPosition position = base.GridObjectScript.GridObject.Position;
				GridObject _003CGridObject_003Ek__BackingField = base.GridObjectScript.GridObject;
				GridObject gridObject2 = default(GridObject);
				onNewGridTransform = gridObject2;
				GridObjectScript gridObjectScript3 = base.GridObjectScript;
				GridObject gridObject3 = onNewGridTransform;
				int editModeResynchronize = 0;
				GridScript gridScript4 = base.GridScript;
				gridObjectScript3.Init(gridScript4, gridObject3, (byte)editModeResynchronize != 0);
				GridScript gridScript5 = base.GridScript;
				GridObjectScript gridObjectScript4 = base.gridObjectScript;
				int num2 = 0;
				if (gridObjectScript4 == (UnityEngine.Object)num2)
				{
					GridScript gridScript6 = base.GridScript;
					uint gridObjectID2 = base.GridObjectID;
					GridObjectScript gridObjectScript5 = (base.gridObjectScript = gridScript6.GetGridObjectScript(gridObjectID2));
				}
				GridObjectScript gridObjectScript6 = base.gridObjectScript;
				GridObject gridObject4 = (onNewGridTransform = gridScript5.AddObjectToEditGrid(gridObjectScript6));
				GridObject gridObject5 = onNewGridTransform;
				if (gridObject5 == null)
				{
					InvalidOperationException ex = new InvalidOperationException("The GridObject cannot be added.");
					/*Error: Unexpected end of block*/;
				}
				GridObject gridObject6 = (onNewGridTransform = gridObject5.Clone());
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60011E9")]
			[Cpp2IlInjected.Address(RVA = "0x184FA60", Offset = "0x184E460", VA = "0x18184FA60", Slot = "6")]
			protected override Task PerformUndo()
			{
				//Discarded unreachable code: IL_00f6
				//IL_0017: Expected O, but got I4
				//IL_006e: Expected O, but got I4
				GridScript gridScript = base.GridScript;
				GridObjectScript gridObjectScript = base.gridObjectScript;
				int num = 0;
				if (gridObjectScript == (UnityEngine.Object)num)
				{
					GridScript gridScript2 = base.GridScript;
					uint gridObjectID = base.GridObjectID;
					GridObjectScript gridObjectScript2 = (base.gridObjectScript = gridScript2.GetGridObjectScript(gridObjectID));
				}
				GridObjectScript gridObjectScript3 = base.gridObjectScript;
				int destroyGameObject = 0;
				bool flag = gridScript.RemoveObject(gridObjectScript3, (byte)destroyGameObject != 0);
				GridScript gridScript3 = base.GridScript;
				GridObjectScript gridObjectScript4 = base.gridObjectScript;
				int num2 = 0;
				if (gridObjectScript4 == (UnityEngine.Object)num2)
				{
					GridScript gridScript4 = base.GridScript;
					uint gridObjectID2 = base.GridObjectID;
					GridObjectScript gridObjectScript5 = (base.gridObjectScript = gridScript4.GetGridObjectScript(gridObjectID2));
				}
				GridObject _003CGridObject_003Ek__BackingField = base.gridObjectScript.GridObject;
				gridScript3.ForgetEditObject(_003CGridObject_003Ek__BackingField);
				GridObjectScript gridObjectScript6 = base.GridObjectScript;
				GridObject gridObject = initialGridObjectTransform;
				int editModeResynchronize = 0;
				GridScript gridScript5 = previousGridScript;
				gridObjectScript6.Init(gridScript5, gridObject, (byte)editModeResynchronize != 0);
				GridScript gridScript6 = previousGridScript;
				GridObjectScript gridObjectScript7 = base.GridObjectScript;
				GridObject gridObject2 = gridScript6.AddObjectToEditGrid(gridObjectScript7);
				int num3 = 0;
				return Task.CompletedTask;
			}

			[Cpp2IlInjected.Token(Token = "0x60011EA")]
			[Cpp2IlInjected.Address(RVA = "0x184F630", Offset = "0x184E030", VA = "0x18184F630", Slot = "7")]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				//IL_0018: Expected I4, but got O
				SwitchGridObjectGrid.Types.Request request = new SwitchGridObjectGrid.Types.Request();
				uint? num = ResolvedPreviousGridID;
				if ((object)num == null)
				{
				}
				request.oldGridID_ = (uint)(int)num;
				uint oldGridObjectID_ = default(uint);
				if ((object)base.ResolvedGridObjectID == null)
				{
					oldGridObjectID_ = base.GridObjectID;
				}
				request.oldGridObjectID_ = oldGridObjectID_;
				uint newGridID_ = default(uint);
				if ((object)base.ResolvedGridID == null)
				{
					newGridID_ = base.GridID;
				}
				request.newGridID_ = newGridID_;
				int num2 = (request.newX_ = onNewGridTransform.x_);
				int num3 = (request.newY_ = onNewGridTransform.y_);
				GridOrientation gridOrientation = (request.newOrientation_ = onNewGridTransform.orientation_);
				int itemID = onNewGridTransform.ItemID;
				bool clearArea_ = default(bool);
				request.clearArea_ = clearArea_;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60011EB")]
			[Cpp2IlInjected.Address(RVA = "0x184FC60", Offset = "0x184E660", VA = "0x18184FC60", Slot = "11")]
			public unsafe override void ResolveIDs(uint gridID, (uint previous, uint resolved) gridObjectID, [Optional] (uint previous, uint resolved)? subGridID)
			{
				//IL_001e: Expected I4, but got O
				//IL_0026: Expected O, but got I8
				uint num = PreviousGridID;
				(uint, uint) value = ((uint, uint))((T?*)subGridID)->Value;
				if ((IntPtr)(int)num == (IntPtr)value)
				{
					uint num2 = (uint)(int)((ValueTuple<, >)((T?*)subGridID)->Value).Item1;
					ulong num3 = default(ulong);
					ResolvedPreviousGridID = (uint?)(object)num3;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60011EC")]
			[Cpp2IlInjected.Address(RVA = "0x184F770", Offset = "0x184E170", VA = "0x18184F770")]
			internal void FakeDo()
			{
				GridObject gridObject = (onNewGridTransform = base.GridObjectScript.GridObject.Clone());
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000421")]
		private class GridClearingCommand : GridCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001A8A")]
			public readonly GridCommand RealCommand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4001A8B")]
			public readonly List<GridCommand> FakeCommands;

			[Cpp2IlInjected.Token(Token = "0x17000242")]
			public override bool CanUndoCommand
			{
				[Cpp2IlInjected.Token(Token = "0x60011ED")]
				[Cpp2IlInjected.Address(RVA = "0xAE4160", Offset = "0xAE2B60", VA = "0x180AE4160", Slot = "4")]
				get
				{
					((Command)RealCommand).PerformDo();
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60011EE")]
			[Cpp2IlInjected.Address(RVA = "0x184D720", Offset = "0x184C120", VA = "0x18184D720")]
			public GridClearingCommand(GridCommand realCommand, List<GridCommand> fakeCommands, GridScript gridScript, GridObjectScript gridObjectScript)
			{
				RealCommand = realCommand;
				FakeCommands = fakeCommands;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x60011EF")]
			[Cpp2IlInjected.Address(RVA = "0x184D4C0", Offset = "0x184BEC0", VA = "0x18184D4C0", Slot = "5")]
			protected override void PerformDo()
			{
				//Discarded unreachable code: IL_000c, IL_0012
				List<GridCommand> fakeCommands = FakeCommands;
				bool flag = default(bool);
				if (!flag)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60011F0")]
			[Cpp2IlInjected.Address(RVA = "0x184D610", Offset = "0x184C010", VA = "0x18184D610", Slot = "6")]
			[AsyncStateMachine(typeof(_003CPerformUndo_003Ed__6))]
			protected override Task PerformUndo()
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x60011F1")]
			[Cpp2IlInjected.Address(RVA = "0x184D470", Offset = "0x184BE70", VA = "0x18184D470", Slot = "7")]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				InvalidOperationException ex = new InvalidOperationException("We should never get here. The GridClearingCommand should get replaced by its RealCommand when clearing the command queue");
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000423")]
		private class ChangePlayerHouseWallpaperCommand : Command
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001A91")]
			private readonly int floorIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4001A92")]
			private readonly House.Types.RoomSlot roomSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001A93")]
			private readonly House.Types.WallPosition? wallPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4001A94")]
			private readonly Item wallpaperItem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001A95")]
			private readonly Dictionary<House.Types.WallPosition, Item> previousWallpaperItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4001A96")]
			private readonly AnimationCurve curve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4001A97")]
			private HouseWallManager wallManager;

			[Cpp2IlInjected.Token(Token = "0x60011F4")]
			[Cpp2IlInjected.Address(RVA = "0x184A590", Offset = "0x1848F90", VA = "0x18184A590")]
			public ChangePlayerHouseWallpaperCommand(int floorIndex, House.Types.RoomSlot roomSlot, House.Types.WallPosition? wallPosition, Item wallpaperItem, Dictionary<House.Types.WallPosition, Item> previousWallpaperItems, AnimationCurve curve)
			{
				//IL_000f: Expected O, but got I4
				//IL_002b: Expected O, but got I4
				//IL_0032: Expected O, but got I4
				this.previousWallpaperItems = (Dictionary<House.Types.WallPosition, Item>)0;
				this.floorIndex = floorIndex;
				this.roomSlot = roomSlot;
				this.wallPosition = wallPosition;
				this.wallpaperItem = (Item)0;
				this.curve = (AnimationCurve)0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x60011F5")]
			[Cpp2IlInjected.Address(RVA = "0x1849E50", Offset = "0x1848850", VA = "0x181849E50", Slot = "5")]
			protected override void PerformDo()
			{
				//Discarded unreachable code: IL_006f
				//IL_004d: Expected O, but got I4
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneData sceneData = default(SceneData);
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				GameObject gameObject = default(GameObject);
				HouseWallManager houseWallManager = (wallManager = gameObject.GetComponent<PlayerHouseEnvironment>().ActiveRoom.GetComponentInChildren<HouseWallManager>());
				HouseWallManager houseWallManager2 = wallManager;
				int num = 0;
				if (houseWallManager2 != (UnityEngine.Object)num)
				{
					HouseWallManager houseWallManager3 = wallManager;
					Item wallpaper = wallpaperItem;
					houseWallManager3.SetWallpaper(wallpaper).FireAndForgetTask();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60011F6")]
			[Cpp2IlInjected.Address(RVA = "0x184A1D0", Offset = "0x1848BD0", VA = "0x18184A1D0", Slot = "6")]
			protected override Task PerformUndo()
			{
				//Discarded unreachable code: IL_0065, IL_0071, IL_0077
				//IL_0012: Expected O, but got I4
				//IL_004d: Expected O, but got I4
				int num = 0;
				HouseWallManager houseWallManager = wallManager;
				int num2 = 0;
				if (!(houseWallManager != (UnityEngine.Object)num2))
				{
					int num3 = 0;
					return Task.CompletedTask;
				}
				Task[] tasks = new Task[((Dictionary<TKey, TValue>)(object)previousWallpaperItems).Count];
				Dictionary<House.Types.WallPosition, Item> dictionary = previousWallpaperItems;
				bool flag = default(bool);
				if (flag)
				{
					num++;
					Task task = wallManager.SetWallpaper((House.Types.WallPosition)num, (Item)num);
					if (task != null && task == null)
					{
						throw new IndexOutOfRangeException();
					}
					num += 4;
				}
				return Task.WhenAll(tasks);
			}

			[Cpp2IlInjected.Token(Token = "0x60011F7")]
			[Cpp2IlInjected.Address(RVA = "0x1849DB0", Offset = "0x18487B0", VA = "0x181849DB0", Slot = "7")]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				//IL_0040: Expected I4, but got O
				ChangePlayerHouseWallpaper.Types.Request request = new ChangePlayerHouseWallpaper.Types.Request();
				int num = (request.floorIndex_ = floorIndex);
				House.Types.RoomSlot roomSlot = (request.roomSlot_ = this.roomSlot);
				House.Types.WallPosition? modifiedWall = wallPosition;
				request.set_ModifiedWall((Nullable<>)modifiedWall);
				Item item = wallpaperItem;
				request.wallpaperItemID_ = (int)item;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000425")]
		private class ChangePlayerHouseFlooringCommand : Command
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001A9D")]
			private readonly int floorIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4001A9E")]
			private readonly House.Types.RoomSlot roomSlot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001A9F")]
			private readonly Item flooringItem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4001AA0")]
			private FlooringSetter flooringSetter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001AA1")]
			private Item previousFlooringItem;

			[Cpp2IlInjected.Token(Token = "0x60011FB")]
			[Cpp2IlInjected.Address(RVA = "0x1849D60", Offset = "0x1848760", VA = "0x181849D60")]
			public ChangePlayerHouseFlooringCommand(int floorIndex, House.Types.RoomSlot roomSlot, Item flooringItem)
			{
				//IL_001d: Expected O, but got I4
				int itemID = flooringItem.ItemID;
				((object)this)._002Ector();
				this.roomSlot = roomSlot;
				this.flooringItem = (Item)itemID;
				this.floorIndex = floorIndex;
			}

			[Cpp2IlInjected.Token(Token = "0x60011FC")]
			[Cpp2IlInjected.Address(RVA = "0x1849B60", Offset = "0x1848560", VA = "0x181849B60", Slot = "5")]
			protected override void PerformDo()
			{
				//Discarded unreachable code: IL_0068
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneData sceneData = default(SceneData);
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				GameObject gameObject = default(GameObject);
				FlooringSetter flooringSetter = (this.flooringSetter = gameObject.GetComponent<PlayerHouseEnvironment>().ActiveRoom.GetComponentInChildren<FlooringSetter>());
				Item trimmingItem = this.flooringSetter.TrimmingItem;
				FlooringSetter flooringSetter2 = this.flooringSetter;
				previousFlooringItem = trimmingItem;
				Item item2 = (flooringSetter2.TrimmingItem = flooringItem);
			}

			[Cpp2IlInjected.Token(Token = "0x60011FD")]
			[Cpp2IlInjected.Address(RVA = "0x1849CF0", Offset = "0x18486F0", VA = "0x181849CF0", Slot = "6")]
			protected override Task PerformUndo()
			{
				//Discarded unreachable code: IL_001d
				FlooringSetter flooringSetter = this.flooringSetter;
				Item item2 = (flooringSetter.TrimmingItem = previousFlooringItem);
				int num = 0;
				return Task.CompletedTask;
			}

			[Cpp2IlInjected.Token(Token = "0x60011FE")]
			[Cpp2IlInjected.Address(RVA = "0x1849AD0", Offset = "0x18484D0", VA = "0x181849AD0", Slot = "7")]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				//IL_0030: Expected I4, but got O
				ChangePlayerHouseFlooring.Types.Request request = new ChangePlayerHouseFlooring.Types.Request();
				int num = (request.floorIndex_ = floorIndex);
				House.Types.RoomSlot roomSlot = (request.roomSlot_ = this.roomSlot);
				Item item = flooringItem;
				request.flooringItemID_ = (int)item;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000426")]
		private class FenceCommand : UpdateTransformCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4001AA2")]
			private readonly List<AddFromCatalogCommand> addFenceCommands = (List<AddFromCatalogCommand>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4001AA3")]
			private readonly Dictionary<GridPosition, AddFromCatalogCommand> addLandcapingCommandsByPosition = (Dictionary<GridPosition, AddFromCatalogCommand>)(object)new Dictionary<TKey, TValue>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4001AA4")]
			private readonly List<RemoveCatalogObjectCommand> removeFenceCommands = (List<RemoveCatalogObjectCommand>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4001AA5")]
			private readonly int numberOfFences;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4001AA6")]
			private bool? adding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4001AA7")]
			private GridObjectScript origin;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4001AA8")]
			private GridObjectScript separatingExtension;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4001AA9")]
			private readonly FenceMode fenceMode;

			[Cpp2IlInjected.Token(Token = "0x17000243")]
			public int DeltaNumberOfFences
			{
				[Cpp2IlInjected.Token(Token = "0x60011FF")]
				[Cpp2IlInjected.Address(RVA = "0x184C670", Offset = "0x184B070", VA = "0x18184C670")]
				get
				{
					//Discarded unreachable code: IL_0030, IL_0036, IL_003c, IL_0042, IL_0048, IL_004e, IL_0054, IL_005a
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					List<RemoveCatalogObjectCommand> list = removeFenceCommands;
					bool flag = default(bool);
					if (flag)
					{
						int num4 = 0;
						bool flag2 = default(bool);
						if (flag2)
						{
						}
						uint num5 = default(uint);
						num += (int)num5;
					}
					bool flag3 = default(bool);
					if (flag3)
					{
						bool flag4 = default(bool);
						if (flag4)
						{
						}
						num -= (flag4 ? 1 : 0);
					}
					return num;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000244")]
			public int RemainingNumberOfFences
			{
				[Cpp2IlInjected.Token(Token = "0x6001200")]
				[Cpp2IlInjected.Address(RVA = "0x184C9D0", Offset = "0x184B3D0", VA = "0x18184C9D0")]
				get
				{
					int num = numberOfFences;
					int deltaNumberOfFences = DeltaNumberOfFences;
					return deltaNumberOfFences + num;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000245")]
			public override IEnumerable<Command> ExpandBefore
			{
				[Cpp2IlInjected.Token(Token = "0x6001201")]
				[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060", Slot = "9")]
				get
				{
					List<RemoveCatalogObjectCommand> list = removeFenceCommands;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000246")]
			public override IEnumerable<Command> ExpandAfter
			{
				[Cpp2IlInjected.Token(Token = "0x6001202")]
				[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0", Slot = "10")]
				get
				{
					List<AddFromCatalogCommand> list = addFenceCommands;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6001203")]
			[Cpp2IlInjected.Address(RVA = "0x184C4C0", Offset = "0x184AEC0", VA = "0x18184C4C0")]
			public FenceCommand(GridScript gridScript, GridObjectScript gridObjectScript, GridObject initialGridObjectTransform, int numberOfFences, FenceMode fenceMode)
				: base(gridScript, gridObjectScript, initialGridObjectTransform.iD_)
			{
				//IL_005e: Expected O, but got I4
				GridObjectScript gridObjectScript2 = base.GridObjectScript;
				GridObject gridObject = default(GridObject);
				GridObject gridObject2 = (newGridObjectTransform = gridObject.Clone());
				base.initialGridObjectTransform = initialGridObjectTransform;
				this.fenceMode = (FenceMode)0;
				this.numberOfFences = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6001204")]
			[Cpp2IlInjected.Address(RVA = "0x184C2B0", Offset = "0x184ACB0", VA = "0x18184C2B0", Slot = "6")]
			[AsyncStateMachine(typeof(_003CPerformUndo_003Ed__17))]
			protected override Task PerformUndo()
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001205")]
			[Cpp2IlInjected.Address(RVA = "0x184BFC0", Offset = "0x184A9C0", VA = "0x18184BFC0")]
			[AsyncStateMachine(typeof(_003CCancel_003Ed__18))]
			public Task Cancel()
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001206")]
			[Cpp2IlInjected.Address(RVA = "0x184C0C0", Offset = "0x184AAC0", VA = "0x18184C0C0")]
			[AsyncStateMachine(typeof(_003CMoveTo_003Ed__19))]
			public Task MoveTo(GridPosition newPosition, Action<GridPosition> updateBasePosition)
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001207")]
			[Cpp2IlInjected.Address(RVA = "0x184C200", Offset = "0x184AC00", VA = "0x18184C200")]
			private void OnCommandAdded()
			{
				//Discarded unreachable code: IL_002f
				//IL_002e: Expected O, but got I4
				int size = ((List<>)(object)addFenceCommands)._size;
				if (size == 1)
				{
					List<RemoveCatalogObjectCommand> list = removeFenceCommands;
				}
				if (size == 0)
				{
					List<RemoveCatalogObjectCommand> list2 = removeFenceCommands;
					int num = 0;
					int num2 = 0;
					adding = (bool?)(object)num;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200042E")]
		private class RemoveFenceCommand : RemoveCatalogObjectCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4001ADA")]
			private readonly List<RemoveCatalogObjectCommand> removeFenceCommands;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4001ADB")]
			private readonly FenceMode fenceMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4001ADC")]
			private readonly bool deleteWholeFence;

			[Cpp2IlInjected.Token(Token = "0x17000247")]
			public override IEnumerable<Command> ExpandBefore
			{
				[Cpp2IlInjected.Token(Token = "0x6001219")]
				[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060", Slot = "9")]
				get
				{
					List<RemoveCatalogObjectCommand> list = removeFenceCommands;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000248")]
			public Item BaseFenceItem
			{
				[Cpp2IlInjected.Token(Token = "0x600121A")]
				[Cpp2IlInjected.Address(RVA = "0x184ED50", Offset = "0x184D750", VA = "0x18184ED50")]
				get
				{
					//Discarded unreachable code: IL_0011
					return fenceMode.fenceModeUtility.BaseItem;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000249")]
			public int NumberOfFencesRemoved
			{
				[Cpp2IlInjected.Token(Token = "0x600121B")]
				[Cpp2IlInjected.Address(RVA = "0x184ED70", Offset = "0x184D770", VA = "0x18184ED70")]
				get
				{
					//Discarded unreachable code: IL_0041, IL_0047, IL_004d, IL_0053, IL_0059, IL_005f
					int num = 0;
					List<RemoveCatalogObjectCommand> list = removeFenceCommands;
					IEnumerable<RemoveFenceCommand> enumerable = (IEnumerable<RemoveFenceCommand>)MoreLinq.Yield<RemoveFenceCommand>(this);
					IEnumerable<RemoveCatalogObjectCommand> enumerable2 = (IEnumerable<RemoveCatalogObjectCommand>)Enumerable.Concat<RemoveCatalogObjectCommand>((IEnumerable<>)list, (IEnumerable<>)enumerable);
					if (enumerable2 != null)
					{
						uint num2 = default(uint);
						if (num < (int)num2)
						{
							num += num;
							if (num == (int)num2)
							{
								goto IL_003b;
							}
							num++;
						}
						int num3 = 0;
						bool flag = default(bool);
						if (flag)
						{
						}
						num += (flag ? 1 : 0);
					}
					goto IL_003b;
					IL_003b:
					if (enumerable2 != null)
					{
					}
					return num;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600121C")]
			[Cpp2IlInjected.Address(RVA = "0x184EC70", Offset = "0x184D670", VA = "0x18184EC70")]
			public RemoveFenceCommand(GridScript gridScript, GridObjectScript gridObjectScript, GridObject initialGridObject, bool isPreview, IGridMovementRestriction gridMovementRestriction, FenceMode fenceMode, bool deleteWholeFence)
			{
				//IL_001b: Expected O, but got I4
				List<RemoveCatalogObjectCommand> list = (removeFenceCommands = (List<RemoveCatalogObjectCommand>)(object)new List<T>());
				IsPreview = false;
				this.fenceMode = (FenceMode)0;
				this.deleteWholeFence = false;
			}

			[Cpp2IlInjected.Token(Token = "0x600121D")]
			[Cpp2IlInjected.Address(RVA = "0x184E4C0", Offset = "0x184CEC0", VA = "0x18184E4C0", Slot = "5")]
			protected override void PerformDo()
			{
				//Discarded unreachable code: IL_0090, IL_0096, IL_009c, IL_00a2
				//IL_0065: Expected O, but got I4
				bool flag = default(bool);
				bool flag3 = default(bool);
				RemoveCatalogObjectCommand removeCatalogObjectCommand = default(RemoveCatalogObjectCommand);
				while (true)
				{
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					if ((deleteWholeFence ? 1 : 0) == num2)
					{
						FenceMode fenceMode = this.fenceMode;
						int itemID = base.GridObjectScript.GridObject.ItemID;
						if (flag)
						{
							break;
						}
					}
					HashSet<GridObjectScript> hashSet = (HashSet<GridObjectScript>)(object)new HashSet<T>();
					GridObjectScript gridObjectScript = base.GridObjectScript;
					bool flag2 = deleteWholeFence;
					this._003CPerformDo_003Eg__VisitAllFences_007C10_0(gridObjectScript, (HashSet<>)(object)hashSet, flag2);
					if (flag3)
					{
						GridObjectScript gridObjectScript2 = base.GridObjectScript;
						if ((UnityEngine.Object)num2 != gridObjectScript2)
						{
							int num4 = 0;
							removeCatalogObjectCommand.IsPreview = false;
							((RemoveCommand)removeCatalogObjectCommand).PerformDo();
							((Command)removeCatalogObjectCommand).done = true;
							((List<T>)(object)removeFenceCommands).Add((T)removeCatalogObjectCommand);
							break;
						}
						continue;
					}
					break;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600121E")]
			[Cpp2IlInjected.Address(RVA = "0x184E780", Offset = "0x184D180", VA = "0x18184E780", Slot = "6")]
			[AsyncStateMachine(typeof(_003CPerformUndo_003Ed__11))]
			protected override Task PerformUndo()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000430")]
		private class ReplaceGridObjectCommand : AddCommand
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4001AE2")]
			public readonly RemoveCommand RemoveOldObjectCommand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4001AE3")]
			public readonly uint InventoryID;

			[Cpp2IlInjected.Token(Token = "0x6001223")]
			[Cpp2IlInjected.Address(RVA = "0x184F5B0", Offset = "0x184DFB0", VA = "0x18184F5B0")]
			public ReplaceGridObjectCommand(RemoveCommand removeOldObjectCommand, uint inventoryID, GridObjectScript gridObjectScript, IGridMovementRestriction gridMovementRestriction)
				: base(gridObjectID: gridObjectScript.GridObject.iD_, gridScript: gridObjectScript.GridScript, gridObjectScript: gridObjectScript)
			{
				//Discarded unreachable code: IL_0032
				//IL_0023: Expected O, but got I4
				base.GridMovementRestriction = (IGridMovementRestriction)0;
				RemoveOldObjectCommand = removeOldObjectCommand;
				InventoryID = inventoryID;
			}

			[Cpp2IlInjected.Token(Token = "0x6001224")]
			[Cpp2IlInjected.Address(RVA = "0x184F300", Offset = "0x184DD00", VA = "0x18184F300", Slot = "6")]
			[AsyncStateMachine(typeof(_003CPerformUndo_003Ed__3))]
			protected override Task PerformUndo()
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001225")]
			[Cpp2IlInjected.Address(RVA = "0x184F190", Offset = "0x184DB90", VA = "0x18184F190", Slot = "7")]
			[AsyncStateMachine(typeof(_003CCommit_003Ed__4))]
			public override Task Commit(GridEditMode gridEditMode, Client client, Queue<Command> remainingCommands, CancellationToken ct)
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001226")]
			[Cpp2IlInjected.Address(RVA = "0x184F400", Offset = "0x184DE00", VA = "0x18184F400", Slot = "8")]
			public override Task RemoveWhilePending()
			{
				//Discarded unreachable code: IL_000b
				RemoveCommand removeOldObjectCommand = RemoveOldObjectCommand;
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001227")]
			[Cpp2IlInjected.Address(RVA = "0x184F510", Offset = "0x184DF10", VA = "0x18184F510", Slot = "11")]
			public override void ResolveIDs(uint gridID, (uint previous, uint resolved) gridObjectID, [Optional] (uint previous, uint resolved)? subGridID)
			{
				//Discarded unreachable code: IL_0008
				RemoveCommand removeOldObjectCommand = RemoveOldObjectCommand;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000433")]
		public delegate void ObjectAdded(GameObject instance);

		[Cpp2IlInjected.Token(Token = "0x2000434")]
		public delegate void ObjectRemoved(GameObject instance);

		[Cpp2IlInjected.Token(Token = "0x2000435")]
		public delegate void NumberOfItemsInCartChangedDelegate(int newNumber);

		[Cpp2IlInjected.Token(Token = "0x2000436")]
		public delegate void GridEditModeFinishedDelegate(bool confirm);

		[Cpp2IlInjected.Token(Token = "0x2000437")]
		public class FenceMode : IGridMovementRestriction, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000438")]
			internal struct SpatialInformation
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4001AF5")]
				public GridObjectScript Base;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4001AF6")]
				public GridObjectScript Extension;
			}

			[Cpp2IlInjected.Token(Token = "0x2000439")]
			public class InputActionPanModifier : InputActionModifier
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4001AF7")]
				private readonly float ratio;

				[Cpp2IlInjected.Token(Token = "0x6001259")]
				[Cpp2IlInjected.Address(RVA = "0x12C4700", Offset = "0x12C3100", VA = "0x1812C4700")]
				public InputActionPanModifier(float ratio)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600125A")]
				[Cpp2IlInjected.Address(RVA = "0x12C46E0", Offset = "0x12C30E0", VA = "0x1812C46E0", Slot = "4")]
				protected override void ModifyValue(float deltaTime, ref InputActionValue value)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001AF0")]
			private FenceModeUtility fenceModeUtility;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4001AF1")]
			private readonly GridObjectScript gridObjectScript;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4001AF2")]
			private readonly GridScript gridScript;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4001AF3")]
			private List<GameObject> loadedExtensions;

			[Cpp2IlInjected.Token(Token = "0x1700024A")]
			public GridPosition Position
			{
				[Cpp2IlInjected.Token(Token = "0x600123D")]
				[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "4")]
				get
				{
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700024B")]
			public GridPosition Size
			{
				[Cpp2IlInjected.Token(Token = "0x600123E")]
				[Cpp2IlInjected.Address(RVA = "0x184D3F0", Offset = "0x184BDF0", VA = "0x18184D3F0", Slot = "5")]
				get
				{
					GridData gridData = gridScript.GridData;
					GridData gridData2 = gridScript.GridData;
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700024C")]
			public GridOrientation DefaultOrientation
			{
				[Cpp2IlInjected.Token(Token = "0x600123F")]
				[Cpp2IlInjected.Address(RVA = "0x7BA030", Offset = "0x7B8A30", VA = "0x1807BA030", Slot = "6")]
				get
				{
					return GridOrientation.Down;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700024D")]
			public GridFloorType AvailableGridFloorTypes
			{
				[Cpp2IlInjected.Token(Token = "0x6001240")]
				[Cpp2IlInjected.Address(RVA = "0x184D390", Offset = "0x184BD90", VA = "0x18184D390", Slot = "7")]
				get
				{
					//Discarded unreachable code: IL_000c
					return gridScript.AvailableFloorTypes;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700024E")]
			public Item BaseItem
			{
				[Cpp2IlInjected.Token(Token = "0x6001241")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get
				{
					return fenceModeUtility.BaseItem;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700024F")]
			public (Item item, int size) MinExtension
			{
				[Cpp2IlInjected.Token(Token = "0x6001242")]
				[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
				get
				{
					return fenceModeUtility.MinExtension;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000250")]
			public (Item item, int size) MaxExtension
			{
				[Cpp2IlInjected.Token(Token = "0x6001243")]
				[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
				get
				{
					return fenceModeUtility.MaxExtension;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000251")]
			public bool HasExtensions
			{
				[Cpp2IlInjected.Token(Token = "0x6001244")]
				[Cpp2IlInjected.Address(RVA = "0x184D3B0", Offset = "0x184BDB0", VA = "0x18184D3B0")]
				get
				{
					bool result = default(bool);
					return result;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000252")]
			public bool IsReady
			{
				[Cpp2IlInjected.Token(Token = "0x6001247")]
				[Cpp2IlInjected.Address(RVA = "0x184D3D0", Offset = "0x184BDD0", VA = "0x18184D3D0")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000253")]
			public bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x6001248")]
				[Cpp2IlInjected.Address(RVA = "0x184D3E0", Offset = "0x184BDE0", VA = "0x18184D3E0")]
				get
				{
					bool result = default(bool);
					return result;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000254")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x68"), Cpp2IlInjected.Token(Token = "0x4001AF4")]
			public bool? HorizontalMove
			{
				[Cpp2IlInjected.Token(Token = "0x6001249")]
				[Cpp2IlInjected.Address(RVA = "0x184D3C0", Offset = "0x184BDC0", VA = "0x18184D3C0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600124A")]
				[Cpp2IlInjected.Address(RVA = "0x184D460", Offset = "0x184BE60", VA = "0x18184D460")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6001245")]
			[Cpp2IlInjected.Address(RVA = "0x184CC30", Offset = "0x184B630", VA = "0x18184CC30")]
			public bool IsExtension(Item item)
			{
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001246")]
			[Cpp2IlInjected.Address(RVA = "0x184CDC0", Offset = "0x184B7C0", VA = "0x18184CDC0")]
			public bool TryGetExtension(int size, out Item extensionItem)
			{
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x600124B")]
			[Cpp2IlInjected.Address(RVA = "0x184D1A0", Offset = "0x184BBA0", VA = "0x18184D1A0")]
			public FenceMode(GridObjectScript gridObjectScript, GridScript gridScript)
			{
				//Discarded unreachable code: IL_003c
				//IL_002b: Expected O, but got I4
				//IL_0032: Expected O, but got I4
				Select();
				this.gridObjectScript = gridObjectScript;
				this.gridScript = gridScript;
				Meta.Grids.Grid _003CEditGrid_003Ek__BackingField = gridScript.EditGrid;
				GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
				int num = 0;
				fenceModeUtility = (FenceModeUtility)num;
				fenceModeUtility = (FenceModeUtility)num;
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}

			[Cpp2IlInjected.Token(Token = "0x600124C")]
			[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
			public void Select()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x600124D")]
			[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "10")]
			public void Deselect()
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			[Cpp2IlInjected.Token(Token = "0x600124E")]
			[Cpp2IlInjected.Address(RVA = "0x184CC40", Offset = "0x184B640", VA = "0x18184CC40", Slot = "9")]
			public unsafe void RestrictMovement(ref GridPosition mainGridPosition, GridOrientation gridOrientation, GridArea gridArea)
			{
				//Discarded unreachable code: IL_0078
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected I4, but got Unknown
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Expected I4, but got Unknown
				GridPosition position = this.gridObjectScript.GridObject.Position;
				GridPosition gridPosition = mainGridPosition - *(GridPosition*)position;
				bool? flag = HorizontalMove;
				if ((object)flag != null)
				{
				}
				int x = gridPosition.X;
				int x2 = gridPosition.X;
				x -= (_003F?)flag;
				x2 -= (_003F?)flag;
				bool flag2 = x2 > x;
				GridObjectScript gridObjectScript = this.gridObjectScript;
				GridObject _003CGridObject_003Ek__BackingField = default(GridObject);
				if (!flag2)
				{
					_003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
					GridPosition position2 = _003CGridObject_003Ek__BackingField.Position;
				}
				GridPosition position3 = _003CGridObject_003Ek__BackingField.Position;
				int num = (mainGridPosition.X = 0);
			}

			[Cpp2IlInjected.Token(Token = "0x600124F")]
			[Cpp2IlInjected.Address(RVA = "0x184D190", Offset = "0x184BB90", VA = "0x18184D190")]
			internal void UpdateSpatialInformation(GridPosition selectedObjectPosition)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6001250")]
			[Cpp2IlInjected.Address(RVA = "0x184CB40", Offset = "0x184B540", VA = "0x18184CB40")]
			internal SpatialInformation[] GetSpatialInformationForItemAtPosition(Item item, GridPosition selectedObjectPosition, GridOrientation selectedObjectOrientation)
			{
				Func<FenceModeUtility.SpatialInformation, SpatialInformation> func = (Func<FenceModeUtility.SpatialInformation, SpatialInformation>)(object)(Func<T, TResult>)delegate
				{
					int num = 0;
					int num2 = 0;
					if (num != 0)
					{
					}
					throw new NullReferenceException();
				};
				FenceModeUtility.SpatialInformation[] array = default(FenceModeUtility.SpatialInformation[]);
				return Enumerable.Select<FenceModeUtility.SpatialInformation, SpatialInformation>((IEnumerable<>)(object)array, (Func<, >)(object)func).ToArray<SpatialInformation>();
			}

			[Cpp2IlInjected.Token(Token = "0x6001251")]
			[Cpp2IlInjected.Address(RVA = "0x184CA10", Offset = "0x184B410", VA = "0x18184CA10")]
			public bool CanMove()
			{
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001252")]
			[Cpp2IlInjected.Address(RVA = "0x184CA00", Offset = "0x184B400", VA = "0x18184CA00")]
			public bool CanMove(GridPosition delta)
			{
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001253")]
			[Cpp2IlInjected.Address(RVA = "0x184C9F0", Offset = "0x184B3F0", VA = "0x18184C9F0")]
			public bool CanMove(GridOrientation direction)
			{
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001254")]
			[Cpp2IlInjected.Address(RVA = "0x184CEB0", Offset = "0x184B8B0", VA = "0x18184CEB0")]
			public bool TryGetFencesInDirection(GridPosition delta, out GridObjectScript baseFence, out GridObjectScript extensionFence)
			{
				//Discarded unreachable code: IL_0028
				int num = 0;
				int direction = (int)FenceModeUtility.GetDirection(delta);
				bool flag = default(bool);
				if (!flag)
				{
				}
				GridObjectScript gridObjectScript = this.gridScript.GetGridObjectScript((uint)direction);
				if (num != 0)
				{
					GridScript gridScript = this.gridScript;
				}
				return flag;
			}

			[Cpp2IlInjected.Token(Token = "0x6001255")]
			[Cpp2IlInjected.Address(RVA = "0x184CDD0", Offset = "0x184B7D0", VA = "0x18184CDD0")]
			public bool TryGetFencesInDirection(GridOrientation direction, out GridObjectScript baseFence, out GridObjectScript extensionFence)
			{
				int num = 0;
				bool flag = default(bool);
				if (!flag)
				{
					int num2 = 0;
				}
				GridScript gridScript = this.gridScript;
				GridScript gridScript2 = this.gridScript;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6001256")]
			[Cpp2IlInjected.Address(RVA = "0x184CA20", Offset = "0x184B420", VA = "0x18184CA20", Slot = "11")]
			public void Dispose()
			{
				bool flag = default(bool);
				if (loadedExtensions != null && !flag)
				{
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4001A03")]
		[SerializeField]
		private GameObject _previewFurniturePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4001A04")]
		[SerializeField]
		private AssetReference _currencyListPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4001A05")]
		[SerializeField]
		private AssetReference _shoppingCartPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4001A06")]
		[SerializeField]
		private float _houseUnlockDefaultZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
		[Cpp2IlInjected.Token(Token = "0x4001A07")]
		[SerializeField]
		private Vector3 _decorChallengeWantedViewportPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4001A08")]
		[SerializeField]
		private float _fenceModeCameraPanSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
		[Cpp2IlInjected.Token(Token = "0x4001A09")]
		[SerializeField]
		private float _removeWholeFencePressDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4001A0A")]
		[SerializeField]
		private float _undoAllPressDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4001A0B")]
		[SerializeField]
		private GameObject _fenceModeGizmoPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4001A0C")]
		[SerializeField]
		private AssetReferenceGameObject _itemSelectorPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4001A0D")]
		[SerializeField]
		private AnimationCurve _selectWallpaperFlashCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4001A0E")]
		[SerializeField]
		private AssetReferenceGameObject _selectWallpaperVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4001A0F")]
		[SerializeField]
		private AK.Wwise.Event _selectWallpaperSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4001A14")]
		private (House.Types.WallPosition wall, Item previousWallpaper)? previewWall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4001A15")]
		private PlayerHouseEnvironment playerHouseEnvironment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4001A16")]
		private HouseWallManager houseWallManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4001A17")]
		public ItemFilterData FilterData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4001A18")]
		private FenceCommand pendingFenceCommand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4001A19")]
		private FenceMode.InputActionPanModifier fenceModeInputActionPanModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4001A1A")]
		private CommandStack commandStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4001A1B")]
		private ContainerInventory fakeBackpack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4001A1C")]
		private ListInventory fakeCatalog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4001A1D")]
		private ListInventory fakeBuildingInventory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4001A1E")]
		private GridCollection editGridCollection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4001A1F")]
		private HashSet<Item> allAvailableLandscapingItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4001A20")]
		private List<Item> availableOriginalLandscapingItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4001A21")]
		private AddCommand pendingAddCommand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4001A22")]
		private Dictionary<GridObjectScript, CancellationTokenSource> cart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4001A23")]
		protected InputAction inputActionCancel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4001A24")]
		protected InputAction inputActionRemoveWholeFence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4001A25")]
		protected InputAction inputActionUndo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4001A26")]
		protected InputAction inputActionUndoAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4001A27")]
		protected InputAction inputActionReplace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4001A28")]
		[SerializeField]
		private GameObject editTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x4001A29")]
		private EventHandler _commandStackChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4001A2D")]
		private readonly Dictionary<Item, Item[]> variationsPerItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4001A2E")]
		private bool undoingAll;

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public bool ShouldCatalogShowTrimmingItems
		{
			[Cpp2IlInjected.Token(Token = "0x6001114")]
			[Cpp2IlInjected.Address(RVA = "0xCF94C0", Offset = "0xCF7EC0", VA = "0x180CF94C0")]
			get
			{
				//Discarded unreachable code: IL_0016
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				return (long)"{il2cpp field on {'constant23' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == 3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000221")]
		public float RemoveWholeFencePressDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6001117")]
			[Cpp2IlInjected.Address(RVA = "0xCF94A0", Offset = "0xCF7EA0", VA = "0x180CF94A0")]
			get
			{
				return _removeWholeFencePressDelay;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		public float UndoAllPressDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6001118")]
			[Cpp2IlInjected.Address(RVA = "0xCF95B0", Offset = "0xCF7FB0", VA = "0x180CF95B0")]
			get
			{
				return _undoAllPressDelay;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		public bool CanStartEditMode
		{
			[Cpp2IlInjected.Token(Token = "0x600111D")]
			[Cpp2IlInjected.Address(RVA = "0xCF8D10", Offset = "0xCF7710", VA = "0x180CF8D10")]
			get
			{
				//IL_0033: Expected O, but got I4
				SceneData sceneData = default(SceneData);
				GameObject gameObject = default(GameObject);
				bool flag = default(bool);
				Vector3 vector = default(Vector3);
				GridScript gridScript = default(GridScript);
				do
				{
					SceneStack sceneStack = SystemRoot.Instance._sceneStack;
					AsyncOperation operation = sceneData.sceneInstance.m_Operation;
					CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
					SceneItemData sceneItemData = sceneData.sceneItemData;
					int num = 0;
					if (!(gameObject == (UnityEngine.Object)num) && flag)
					{
						IEnumerable<GridScript> gridScriptsList = (IEnumerable<GridScript>)gameObject.GetComponent<Mdl.Environments.Environment>().get_GridScriptsList();
						if (Enumerable.Any<GridScript>((IEnumerable<>)gridScriptsList))
						{
							Func<GridScript, bool> _003C_003E9__51_ = _003C_003Ec._003C_003E9__51_0;
							if (_003C_003E9__51_ == null)
							{
								_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridScript x)
								{
									if ((long)x.Grid == 0)
									{
										return true;
									}
									IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)x).get_ElementIdentifiers();
									throw new NullReferenceException();
								};
							}
							if (!((IEnumerable<>)gridScriptsList).All<GridScript>((Func<, >)(object)_003C_003E9__51_))
							{
								break;
							}
						}
					}
					int num2 = 0;
					float z = vector.z;
					while ((object)gridScript == null)
					{
					}
					while ((long)gridScript.Grid == 0)
					{
					}
				}
				while (gridScript.Locked);
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x350"), Cpp2IlInjected.Token(Token = "0x4001A12")]
		public bool IsQuitting
		{
			[Cpp2IlInjected.Token(Token = "0x600111E")]
			[Cpp2IlInjected.Address(RVA = "0xCF9490", Offset = "0xCF7E90", VA = "0x180CF9490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600111F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF83C0", VA = "0x180CF99C0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x354"), Cpp2IlInjected.Token(Token = "0x4001A13")]
		public Item SelectedWallpaperItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001120")]
			[Cpp2IlInjected.Address(RVA = "0xCF94B0", Offset = "0xCF7EB0", VA = "0x180CF94B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001121")]
			[Cpp2IlInjected.Address(RVA = "0xCF99D0", Offset = "0xCF83D0", VA = "0x180CF99D0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		public override bool UseEditGrid
		{
			[Cpp2IlInjected.Token(Token = "0x6001122")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "10")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		public override bool CanManuallySelect
		{
			[Cpp2IlInjected.Token(Token = "0x6001123")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "11")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		public GridEditModeStartData StartData
		{
			[Cpp2IlInjected.Token(Token = "0x6001130")]
			[Cpp2IlInjected.Address(RVA = "0xCF95A0", Offset = "0xCF7FA0", VA = "0x180CF95A0")]
			[CompilerGenerated]
			get
			{
				return _003CStartData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001131")]
			[Cpp2IlInjected.Address(RVA = "0xCF99E0", Offset = "0xCF83E0", VA = "0x180CF99E0")]
			[CompilerGenerated]
			private set
			{
				_003CStartData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000229")]
		public bool CanConfirmAndQuitEditMode
		{
			[Cpp2IlInjected.Token(Token = "0x6001135")]
			[Cpp2IlInjected.Address(RVA = "0xCF7D40", Offset = "0xCF6740", VA = "0x180CF7D40")]
			get
			{
				//IL_0010: Expected O, but got I4
				GridObjectScript selectedGridObject = base._selectedGridObject;
				int num = 0;
				if (selectedGridObject == (UnityEngine.Object)num)
				{
					return true;
				}
				return CanUndoLastCommand;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		public override bool CanDuplicateSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x6001143")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E70", Offset = "0xCF6870", VA = "0x180CF7E70", Slot = "19")]
			get
			{
				//IL_0010: Expected O, but got I4
				GridObjectScript selectedGridObject = base._selectedGridObject;
				int num = 0;
				if (selectedGridObject != (UnityEngine.Object)num && CanDeselectSelectedObject)
				{
					int itemID = base._selectedGridObject.GridObject.ItemID;
					GridObjectScript selectedGridObject2 = base._selectedGridObject;
					IBackpackItem backpackItem = default(IBackpackItem);
					if (backpackItem != null)
					{
						ContainerInventory containerInventory = fakeBackpack;
						int itemID2 = selectedGridObject2.GridObject.ItemID;
						bool result = default(bool);
						return result;
					}
					ListInventory listInventory = fakeCatalog;
					int itemID3 = selectedGridObject2.GridObject.ItemID;
					bool flag = default(bool);
					if (flag)
					{
						return true;
					}
				}
				int num2 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		public unsafe override bool CanRemoveSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x6001145")]
			[Cpp2IlInjected.Address(RVA = "0xCF8450", Offset = "0xCF6E50", VA = "0x180CF8450", Slot = "21")]
			get
			{
				//IL_0012: Expected O, but got I4
				int num = 0;
				GridObjectScript selectedGridObject = base._selectedGridObject;
				int num2 = 0;
				bool flag = selectedGridObject != (UnityEngine.Object)num2;
				if (!flag)
				{
					return flag;
				}
				int itemID = base._selectedGridObject.GridObject.ItemID;
				ItemType itemType = default(ItemType);
				if (itemType != ItemType.Building)
				{
					Client client = default(Client);
					Profile profile = client.profile;
					Client client2 = default(Client);
					Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client2.TransactionContext;
					IGridEditRestriction gridEditRestriction = default(IGridEditRestriction);
					bool flag2 = default(bool);
					BuildingItemType buildingItemType = default(BuildingItemType);
					ItemType itemType2 = default(ItemType);
					ItemType itemType3 = default(ItemType);
					if (gridEditRestriction.CanBeRemoved(profile, _003CTransactionContext_003Ek__BackingField) && (!flag2 || buildingItemType == BuildingItemType.House) && itemType2 != ItemType.ActivityItem && itemType3 != ItemType.Tool)
					{
						if ((IntPtr)pendingAddCommand == (IntPtr)num)
						{
							GridObjectScript selectedGridObject2 = base._selectedGridObject;
							IBackpackItem backpackItem = default(IBackpackItem);
							if (backpackItem != null)
							{
								AmountWithState amountWithState = default(AmountWithState);
								if (num == 0 || amountWithState != null)
								{
								}
								GridState state_ = base._selectedGridObject.GridObject.state_;
								if (state_ == null || state_.ItemAmountState != null)
								{
								}
								ContainerInventory containerInventory = fakeBackpack;
								ContainerInventory.CanAddResult canAddResult = default(ContainerInventory.CanAddResult);
								return canAddResult == ContainerInventory.CanAddResult.Success;
							}
							if (selectedGridObject2.TryGetComponent<SubGridScript>(out *(SubGridScript*)num))
							{
								bool useEditGrid = UseEditGrid;
								bool flag3 = default(bool);
								if (flag3)
								{
									goto IL_00f0;
								}
							}
							bool flag4 = default(bool);
							if (base._selectedGridObject.TryGetComponent<FurnitureStorage>(out *(FurnitureStorage*)num) && !flag4)
							{
								goto IL_00f0;
							}
						}
						return true;
					}
				}
				goto IL_00f0;
				IL_00f0:
				int num3 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		public bool CanRemoveWholeFence
		{
			[Cpp2IlInjected.Token(Token = "0x6001148")]
			[Cpp2IlInjected.Address(RVA = "0xCF8860", Offset = "0xCF7260", VA = "0x180CF8860")]
			get
			{
				bool flag = IsInFenceMode();
				if (!flag)
				{
					return flag;
				}
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		protected override bool CanMoveSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x600114A")]
			[Cpp2IlInjected.Address(RVA = "0xCF8020", Offset = "0xCF6A20", VA = "0x180CF8020", Slot = "26")]
			get
			{
				//IL_0012: Expected O, but got I4
				int num = 0;
				GridObjectScript selectedGridObject = base._selectedGridObject;
				int num2 = 0;
				if (selectedGridObject != (UnityEngine.Object)num2)
				{
					int itemID = base._selectedGridObject.GridObject.ItemID;
					ItemType itemType = default(ItemType);
					if (itemType == ItemType.ActivityItem)
					{
						int itemID2 = base._selectedGridObject.GridObject.ItemID;
						ActivityItemType activityItemType = default(ActivityItemType);
						if (activityItemType != ActivityItemType.RequestItem && activityItemType > (ActivityItemType)1)
						{
							int itemID3 = base._selectedGridObject.GridObject.ItemID;
							bool flag = default(bool);
							FurnitureItemType furnitureItemType = default(FurnitureItemType);
							if (flag && furnitureItemType == FurnitureItemType.Fence)
							{
								int itemID4 = base._selectedGridObject.GridObject.ItemID;
								uint num3 = default(uint);
								if (num < (int)num3)
								{
									num += num;
									num++;
								}
								bool flag2 = default(bool);
								if (flag2)
								{
									goto IL_00d5;
								}
							}
							GridObjectScript selectedGridObject2 = base._selectedGridObject;
							ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
							int itemID5 = selectedGridObject2.GridObject.ItemID;
							Client client = default(Client);
							Profile profile = client.profile;
							Client client2 = default(Client);
							Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client2.TransactionContext;
							IGridEditRestriction gridEditRestriction = default(IGridEditRestriction);
							return gridEditRestriction.CanMove(profile, _003CTransactionContext_003Ek__BackingField);
						}
					}
					else
					{
						while (itemType != ItemType.Tool)
						{
						}
					}
				}
				goto IL_00d5;
				IL_00d5:
				int num4 = 0;
				selectedGridObject = (GridObjectScript)(object)((object)selectedGridObject + (object)selectedGridObject);
				num4 += 328;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		protected override bool CanTapToMoveSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x600114B")]
			[Cpp2IlInjected.Address(RVA = "0xCF9110", Offset = "0xCF7B10", VA = "0x180CF9110", Slot = "27")]
			get
			{
				//IL_0012: Expected O, but got I4
				int num = 0;
				GridObjectScript selectedGridObject = base._selectedGridObject;
				int num2 = 0;
				if (selectedGridObject != (UnityEngine.Object)num2)
				{
					if (base._currentGridMovementRestriction != null)
					{
						int num3 = 0;
						int num4 = 0;
					}
					bool flag = default(bool);
					if (num != 0 && flag)
					{
						int num5 = 0;
					}
				}
				return CanMoveSelectedObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public override bool CanDeselectSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x600114F")]
			[Cpp2IlInjected.Address(RVA = "0xCF7DC0", Offset = "0xCF67C0", VA = "0x180CF7DC0", Slot = "24")]
			get
			{
				if (base.CanDeselectSelectedObject)
				{
					if ((long)pendingAddCommand != 0)
					{
						VillageObjectLimit villageObjectLimit = currentAmounts;
						if (villageObjectLimit != null)
						{
							VillageObjectLimit current = villageObjectLimit.Clone();
							int itemID = base._selectedGridObject.GridObject.ItemID;
							VillageObjectLimitData limits = currentLimits;
							return !VillageObjectLimit.IsGoingOverLimit(currentAmounts, current, limits);
						}
					}
					return true;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public bool CanUndoLastCommand
		{
			[Cpp2IlInjected.Token(Token = "0x6001155")]
			[Cpp2IlInjected.Address(RVA = "0xCF9270", Offset = "0xCF7C70", VA = "0x180CF9270")]
			get
			{
				//Discarded unreachable code: IL_0076
				//IL_0027: Expected O, but got I4
				//IL_004c: Expected O, but got I4
				if (!commandStack.HasCommands && (object)SelectedWallpaperItem != null)
				{
					GridObjectScript selectedGridObject = base._selectedGridObject;
					int num = 0;
					if (selectedGridObject == (UnityEngine.Object)num)
					{
						int num2 = 0;
					}
				}
				Item item = SelectedWallpaperItem;
				bool flag = default(bool);
				if (!flag)
				{
					GridObjectScript selectedGridObject2 = base._selectedGridObject;
					int num3 = 0;
					if (!(selectedGridObject2 != (UnityEngine.Object)num3))
					{
						return commandStack.Peek().CanUndoCommand;
					}
					if (pendingAddCommand == null)
					{
						List<Task> list = base.blockingTasks;
						bool result = default(bool);
						return result;
					}
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public bool CanReplaceSelectedObject
		{
			[Cpp2IlInjected.Token(Token = "0x600115A")]
			[Cpp2IlInjected.Address(RVA = "0xCF88A0", Offset = "0xCF72A0", VA = "0x180CF88A0")]
			get
			{
				//IL_0010: Expected O, but got I4
				GridObjectScript selectedGridObject = base._selectedGridObject;
				int num = 0;
				ItemType itemType = default(ItemType);
				if (selectedGridObject != (UnityEngine.Object)num)
				{
					int itemID = base._selectedGridObject.GridObject.ItemID;
					if (itemType != ItemType.Building)
					{
						goto IL_00b3;
					}
					int itemID2 = base._selectedGridObject.GridObject.ItemID;
					BuildingItemType buildingItemType = default(BuildingItemType);
					if (buildingItemType == BuildingItemType.PlayerHouse)
					{
						int itemID3 = base._selectedGridObject.GridObject.ItemID;
						bool flag = default(bool);
						if (flag)
						{
							UpgradeState upgradeState_ = base._selectedGridObject.GridObject.state_.HouseData.upgradeState_;
							UpgradeData upgradeData = default(UpgradeData);
							if (upgradeData.House.canReplaceWithSkins_)
							{
								ListInventory listInventory = fakeBuildingInventory;
								if (_003C_003Ec._003C_003E9__158_0 == null)
								{
									Func<KeyValuePair<int, ListInventory.Types.Data>, bool> func = (Func<KeyValuePair<int, ListInventory.Types.Data>, bool>)(object)(Func<T, TResult>)delegate
									{
										//Discarded unreachable code: IL_0007
										int num4 = 0;
										BuildingItemType buildingItemType2 = default(BuildingItemType);
										return buildingItemType2 == BuildingItemType.PlayerHouse;
									};
									goto IL_00b3;
								}
								goto IL_00fd;
							}
						}
					}
				}
				goto IL_0109;
				IL_00b3:
				MapField<int, ListInventory.Types.Data> inventory_ = default(MapField<int, ListInventory.Types.Data>);
				Func<KeyValuePair<int, ListInventory.Types.Data>, bool> _003C_003E9__158_ = default(Func<KeyValuePair<int, ListInventory.Types.Data>, bool>);
				if (itemType == ItemType.Furniture)
				{
					int itemID4 = base._selectedGridObject.GridObject.ItemID;
					FurnitureItemType furnitureItemType = default(FurnitureItemType);
					if (furnitureItemType == FurnitureItemType.Door)
					{
						inventory_ = fakeCatalog.inventory_;
						_003C_003E9__158_ = _003C_003Ec._003C_003E9__158_1;
						if (_003C_003E9__158_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
							{
								//Discarded unreachable code: IL_0007
								int num3 = 0;
								FurnitureItemType furnitureItemType2 = default(FurnitureItemType);
								return furnitureItemType2 == FurnitureItemType.Door;
							};
						}
						goto IL_00fd;
					}
				}
				goto IL_0109;
				IL_0109:
				int num2 = 0;
				throw new NullReferenceException();
				IL_00fd:
				if (!((IEnumerable<>)(object)inventory_).Any<KeyValuePair<int, ListInventory.Types.Data>>((Func<, >)(object)_003C_003E9__158_))
				{
				}
				goto IL_0109;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public static event ObjectAdded OnObjectAdded
		{
			[Cpp2IlInjected.Token(Token = "0x6001119")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BC0", Offset = "0xCF65C0", VA = "0x180CF7BC0")]
			[CompilerGenerated]
			add
			{
				ObjectAdded onObjectAdded = GridEditMode.OnObjectAdded;
				Delegate @delegate = Delegate.Combine(onObjectAdded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(GridEditMode).TypeHandle != onObjectAdded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600111A")]
			[Cpp2IlInjected.Address(RVA = "0xCF9840", Offset = "0xCF8240", VA = "0x180CF9840")]
			[CompilerGenerated]
			remove
			{
				ObjectAdded onObjectAdded = GridEditMode.OnObjectAdded;
				Delegate @delegate = Delegate.Remove(onObjectAdded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(GridEditMode).TypeHandle != onObjectAdded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public static event ObjectRemoved OnObjectRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x600111B")]
			[Cpp2IlInjected.Address(RVA = "0xCF7C80", Offset = "0xCF6680", VA = "0x180CF7C80")]
			[CompilerGenerated]
			add
			{
				ObjectRemoved onObjectRemoved = GridEditMode.OnObjectRemoved;
				Delegate @delegate = Delegate.Combine(onObjectRemoved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(GridEditMode).TypeHandle != onObjectRemoved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600111C")]
			[Cpp2IlInjected.Address(RVA = "0xCF9900", Offset = "0xCF8300", VA = "0x180CF9900")]
			[CompilerGenerated]
			remove
			{
				ObjectRemoved onObjectRemoved = GridEditMode.OnObjectRemoved;
				Delegate @delegate = Delegate.Remove(onObjectRemoved, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(GridEditMode).TypeHandle != onObjectRemoved)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event EventHandler CommandStackChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6001129")]
			[Cpp2IlInjected.Address(RVA = "0xCF7930", Offset = "0xCF6330", VA = "0x180CF7930")]
			add
			{
				EventHandler commandStackChangedEvent = _commandStackChangedEvent;
				if (commandStackChangedEvent == null)
				{
					CommandStack commandStack = this.commandStack;
					if (commandStack != null)
					{
						CommandStack.CommandAddedOrRemovedDelegate value2 = OnCommandStackChanged;
						commandStack.CommandAddedEvent += value2;
						CommandStack commandStack2 = this.commandStack;
						CommandStack.CommandAddedOrRemovedDelegate value3 = OnCommandStackChanged;
						commandStack2.CommandRemovedEvent += value3;
					}
				}
				Delegate @delegate = Delegate.Combine(commandStackChangedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					_commandStackChangedEvent = (EventHandler)@delegate;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600112A")]
			[Cpp2IlInjected.Address(RVA = "0xCF95C0", Offset = "0xCF7FC0", VA = "0x180CF95C0")]
			remove
			{
				//IL_001e: Expected O, but got I4
				Delegate @delegate = Delegate.Remove(_commandStackChangedEvent, value);
				int num = 0;
				if ((object)@delegate == null || (object)@delegate != null)
				{
					_commandStackChangedEvent = (EventHandler)num;
					if ((long)_commandStackChangedEvent == 0)
					{
						CommandStack commandStack = this.commandStack;
						if (commandStack != null)
						{
							CommandStack.CommandAddedOrRemovedDelegate value2 = OnCommandStackChanged;
							commandStack.CommandAddedEvent -= value2;
							CommandStack commandStack2 = this.commandStack;
							CommandStack.CommandAddedOrRemovedDelegate value3 = OnCommandStackChanged;
							commandStack2.CommandRemovedEvent -= value3;
						}
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event NumberOfItemsInCartChangedDelegate NumberOfItemsInCartChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600112B")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B20", Offset = "0xCF6520", VA = "0x180CF7B20")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600112C")]
			[Cpp2IlInjected.Address(RVA = "0xCF97A0", Offset = "0xCF81A0", VA = "0x180CF97A0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event GridEditModeFinishedDelegate GridEditModeFinishedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600112D")]
			[Cpp2IlInjected.Address(RVA = "0xCF7A80", Offset = "0xCF6480", VA = "0x180CF7A80")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600112E")]
			[Cpp2IlInjected.Address(RVA = "0xCF9700", Offset = "0xCF8100", VA = "0x180CF9700")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001115")]
		[Cpp2IlInjected.Address(RVA = "0xCEE420", Offset = "0xCECE20", VA = "0x180CEE420")]
		public void ChangePlayerHouseWallpaper(Item wallpaperItem)
		{
			//Discarded unreachable code: IL_0093
			//IL_0017: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			int itemID = wallpaperItem.ItemID;
			GridObjectScript selectedGridObject = base._selectedGridObject;
			int num = 0;
			if (!(selectedGridObject != (UnityEngine.Object)num))
			{
				SelectedWallpaperItem = (Item)itemID;
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneData sceneData = default(SceneData);
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				GameObject gameObject = default(GameObject);
				PlayerHouseEnvironment playerHouseEnvironment = (this.playerHouseEnvironment = gameObject.GetComponent<PlayerHouseEnvironment>());
				HouseWallManager houseWallManager = (this.houseWallManager = this.playerHouseEnvironment.ActiveRoom.GetComponentInChildren<HouseWallManager>());
				if (_selectWallpaperVFXPrefab.RuntimeKeyIsValid() && !_selectWallpaperVFXPrefab.IsValid())
				{
					AssetReferenceGameObject selectWallpaperVFXPrefab = _selectWallpaperVFXPrefab;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001116")]
		[Cpp2IlInjected.Address(RVA = "0xCEE260", Offset = "0xCECC60", VA = "0x180CEE260")]
		public void ChangePlayerHouseFlooring(Item flooringItem)
		{
			//Discarded unreachable code: IL_0042
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			PlayerHouseEnvironment component = gameObject.GetComponent<PlayerHouseEnvironment>();
			CommandStack commandStack = this.commandStack;
			House.Types.RoomSlot _003CActiveRoomSlot_003Ek__BackingField = component.ActiveRoomSlot;
			ChangePlayerHouseFlooringCommand newCommand = default(ChangePlayerHouseFlooringCommand);
			commandStack.DoCommand(newCommand);
		}

		[Cpp2IlInjected.Token(Token = "0x6001124")]
		[Cpp2IlInjected.Address(RVA = "0xCED8D0", Offset = "0xCEC2D0", VA = "0x180CED8D0", Slot = "12")]
		public override bool CanClear(Item item)
		{
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Building)
			{
				return true;
			}
			ItemType itemType2 = default(ItemType);
			if (itemType2 != ItemType.Furniture)
			{
				int num = 0;
			}
			FurnitureItemType furnitureItemType = default(FurnitureItemType);
			return furnitureItemType == FurnitureItemType.Default;
		}

		[Cpp2IlInjected.Token(Token = "0x6001125")]
		[Cpp2IlInjected.Address(RVA = "0xCF58C0", Offset = "0xCF42C0", VA = "0x180CF58C0", Slot = "15")]
		public override bool ShouldStartAutomaticMovement()
		{
			//IL_0010: Expected O, but got I4
			GridObjectScript selectedGridObject = base._selectedGridObject;
			int num = 0;
			bool flag = selectedGridObject != (UnityEngine.Object)num;
			if (!flag)
			{
				return flag;
			}
			return !IsInFenceMode();
		}

		[Cpp2IlInjected.Token(Token = "0x6001126")]
		[Cpp2IlInjected.Address(RVA = "0xCF07E0", Offset = "0xCEF1E0", VA = "0x180CF07E0")]
		public bool IsInFenceMode()
		{
			if (base._currentGridMovementRestriction == null)
			{
				int num = 0;
			}
			int num2 = 0;
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001127")]
		[Cpp2IlInjected.Address(RVA = "0xCF08A0", Offset = "0xCEF2A0", VA = "0x180CF08A0")]
		private bool IsInFenceMode(out FenceMode fenceMode)
		{
			if (base._currentGridMovementRestriction == null)
			{
				int num = 0;
			}
			int num2 = 0;
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001128")]
		[Cpp2IlInjected.Address(RVA = "0xCF2870", Offset = "0xCF1270", VA = "0x180CF2870")]
		private void OnCommandStackChanged(Command command)
		{
			if (_commandStackChangedEvent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600112F")]
		[Cpp2IlInjected.Address(RVA = "0xCF5AA0", Offset = "0xCF44A0", VA = "0x180CF5AA0")]
		public Task StartSystemAndWait(ISystemData data)
		{
			TaskCompletionSource<bool> taskCompletionSource = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>();
			SystemEvent value = SystemStop;
			base.SystemStoppedEvent += value;
			StartSystem(data);
			Task<> task = (Task<>)(object)((TaskCompletionSource<>)(object)taskCompletionSource).m_task;
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6001277")]
			[Cpp2IlInjected.Address(RVA = "0x185B330", Offset = "0x1859D30", VA = "0x18185B330")]
			void SystemStop(Mdl.Systems.System system)
			{
				//Discarded unreachable code: IL_0029
				//IL_0027: Expected O, but got I4
				GridEditMode gridEditMode = this;
				SystemEvent value2 = SystemStop;
				gridEditMode.SystemStoppedEvent -= value2;
				bool flag = ((TaskCompletionSource<TResult>)(object)taskCompletionSource).TrySetResult((TResult)1);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001132")]
		[Cpp2IlInjected.Address(RVA = "0xCF2BF0", Offset = "0xCF15F0", VA = "0x180CF2BF0", Slot = "4")]
		public unsafe override void OnSystemStart(ISystemData data)
		{
			//IL_0099: Expected O, but got I4
			//IL_00c7: Expected O, but got I4
			//IL_01e3: Expected I4, but got O
			//IL_027d: Expected O, but got I4
			//IL_0292: Expected I4, but got I8
			//IL_02a4: Expected I8, but got I4
			//IL_02b0: Expected O, but got I4
			//IL_02db: Expected O, but got I4
			//IL_02ee: Expected O, but got I4
			//IL_0308: Expected O, but got I4
			//IL_031b: Expected O, but got I4
			//IL_0335: Expected O, but got I4
			SceneData sceneData = default(SceneData);
			GameObject gameObject = default(GameObject);
			bool flag = default(bool);
			uint num5 = default(uint);
			CommandStack.CommandAddedOrRemovedDelegate value = default(CommandStack.CommandAddedOrRemovedDelegate);
			CommandStack.CommandAddedOrRemovedDelegate value2 = default(CommandStack.CommandAddedOrRemovedDelegate);
			CommandStack.CommandAddedOrRemovedDelegate value3 = default(CommandStack.CommandAddedOrRemovedDelegate);
			CommandStack.CommandAddedOrRemovedDelegate value4 = default(CommandStack.CommandAddedOrRemovedDelegate);
			Func<LandscapingItemData, bool> func = default(Func<LandscapingItemData, bool>);
			IEnumerable<> enumerable = default(IEnumerable<>);
			Func<LandscapingItemData, Item> func2 = default(Func<LandscapingItemData, Item>);
			Func<Item, bool> func3 = default(Func<Item, bool>);
			ProfileEventDispatcher.ShopItemBought value5 = default(ProfileEventDispatcher.ShopItemBought);
			ProfileEventDispatcher.ItemsSold value6 = default(ProfileEventDispatcher.ItemsSold);
			Vector3 vector = default(Vector3);
			Transform transform = default(Transform);
			ulong num10 = default(ulong);
			Delegate @delegate = default(Delegate);
			do
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (data == null)
				{
				}
				int num4 = 0;
				base.OnSystemStart(data);
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				SceneItemData sceneItemData = sceneData.sceneItemData;
				GridCollection gridCollection = (editGridCollection = gameObject.GetComponent<Mdl.Environments.Environment>().GridCollection.Clone());
				GridScript[] array = allGridScripts;
				int length = array.Length;
				if (num3 < length)
				{
					GridScript gridScript = array[num3];
					MapField<uint, Meta.Grids.Grid> grids_ = editGridCollection.grids_;
					uint gridID = gridScript.GridID;
					Meta.Grids.Grid editGrid = (Meta.Grids.Grid)((MapField<TKey, TValue>)(object)grids_)[(TKey)gridID];
					gridScript.StartEditMode(editGrid);
					num3++;
				}
				List<SubGridScript> list = subGridScripts;
				if (flag)
				{
					Meta.Grids.Grid grid = (Meta.Grids.Grid)((MapField<TKey, TValue>)(object)editGridCollection.grids_)[(TKey)num5];
				}
				int num6 = 0;
				CommandStack commandStack = new CommandStack();
				commandStack.CommandAddedEvent += value;
				commandStack.CommandRemovedEvent += value2;
				commandStack.CommandAddedEvent += value3;
				commandStack.CommandRemovedEvent += value4;
				ContainerInventory containerInventory = SystemRoot.Instance.MetaClient.profile.Backpack.Clone();
				ListInventory listInventory = SystemRoot.Instance.MetaClient.profile.Catalog.Clone();
				ListInventory listInventory2 = SystemRoot.Instance.MetaClient.profile.Buildings.Clone();
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				if (_003C_003Ec._003C_003E9__107_0 == null)
				{
					func = (Func<LandscapingItemData, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(LandscapingItemData x)
					{
						//Discarded unreachable code: IL_0038
						if (!x.villageArea_.useField_)
						{
							return true;
						}
						Profile profile = SystemRoot.Instance.MetaClient.profile;
						OptionalField villageArea_ = x.villageArea_;
						ProfileWorld world_ = profile.world_;
						VillageAreaType villageArea = villageArea_.VillageArea;
						bool result = default(bool);
						return result;
					});
				}
				IEnumerable<LandscapingItemData> enumerable2 = (IEnumerable<LandscapingItemData>)Enumerable.Where<LandscapingItemData>(enumerable, (Func<, >)(object)func);
				if (_003C_003Ec._003C_003E9__107_1 == null)
				{
					func2 = (Func<LandscapingItemData, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(LandscapingItemData x)
					{
						int iD = x.ID;
						throw new NullReferenceException();
					});
				}
				HashSet<Item> hashSet = (allAvailableLandscapingItems = (HashSet<Item>)(object)new HashSet<T>((IEqualityComparer<>)Enumerable.Select<LandscapingItemData, Item>((IEnumerable<>)enumerable2, (Func<, >)(object)func2)));
				if (_003C_003Ec._003C_003E9__107_2 == null)
				{
					func3 = (Func<Item, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						//Discarded unreachable code: IL_000e
						ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
						bool flag2 = default(bool);
						return !flag2 || flag2;
					});
				}
				List<Item> list2 = (availableOriginalLandscapingItems = (List<Item>)(object)new List<T>((int)Enumerable.Where<Item>((IEnumerable<>)enumerable2, (Func<, >)(object)func3)));
				SystemRoot.Instance.MetaClient.Dispatcher.OnShopItemBought += value5;
				ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
				_003CDispatcher_003Ek__BackingField.OnItemsSold += value6;
				ProfileEventDispatcher.MissionStepProgress onMissionStepProgress = _003CDispatcher_003Ek__BackingField.OnMissionStepProgress;
				int num7 = 0;
				SystemRoot.Instance.PauseSystem<PlayerNavigation>();
				SystemRoot.Instance.GetSystem<CritterManager>().UpdateState();
				SystemRoot.Instance.MetaClient.Clock.IsPaused = true;
				Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
				float z = vector.z;
				int num8 = 0;
				WeatherController.SetAnchor(transform, (Vector3)num8);
				PostProcessManager.Instance.SetDof(DOFDistance.NEAR);
				int num9 = 0;
				GraphicSettings.ToggleGroundCullingDistance((byte)num10 != 0);
				if (data != null)
				{
					if (num9 != 0)
					{
						((ulong*)num10)->m_value = (ulong)num9;
					}
					int num11 = 0;
					if (!(transform != (UnityEngine.Object)num11))
					{
					}
				}
			}
			while ((object)@delegate != null && (object)@delegate == null);
			while (@delegate != transform)
			{
			}
			InputTriggerReleased trigger = new InputTriggerReleased();
			int num12 = default(int);
			InputActionBool inputActionBool = new InputActionBool("EditMode_Cancel", trigger, (InputProvider)num12);
			num12 = 0;
			InputTriggerPressedWithMinDuration trigger2 = default(InputTriggerPressedWithMinDuration);
			int num13 = default(int);
			InputActionBool inputActionBool2 = new InputActionBool("EditMode_Remove", trigger2, (InputProvider)num13);
			num13 = 0;
			InputTriggerReleased trigger3 = new InputTriggerReleased();
			int num14 = default(int);
			InputActionBool inputActionBool3 = new InputActionBool("EditMode_Undo", trigger3, (InputProvider)num14);
			num14 = 0;
			InputTriggerPressedWithMinDuration trigger4 = default(InputTriggerPressedWithMinDuration);
			int num15 = default(int);
			InputActionBool inputActionBool4 = new InputActionBool("EditMode_Undo", trigger4, (InputProvider)num15);
			num15 = 0;
			InputTriggerReleased trigger5 = new InputTriggerReleased();
			int num16 = default(int);
			InputActionBool inputActionBool5 = new InputActionBool("EditMode_Replace", trigger5, (InputProvider)num16);
			num16 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001133")]
		[Cpp2IlInjected.Address(RVA = "0xCF61D0", Offset = "0xCF4BD0", VA = "0x180CF61D0", Slot = "18")]
		protected unsafe override void Update()
		{
			//Discarded unreachable code: IL_03b9, IL_03c2, IL_03d0
			//IL_010b: Expected O, but got I4
			//IL_01a0: Expected O, but got I4
			//IL_021a: Expected O, but got I4
			//IL_026a: Expected O, but got I4
			//IL_0272: Expected native int or pointer, but got O
			//IL_035b: Expected O, but got I4
			//IL_0363: Expected O, but got I4
			//IL_038b: Expected O, but got I4
			int num;
			Vector3 vector = default(Vector3);
			float deltaTime;
			InputAction[] array;
			InputAction inputAction5;
			while (true)
			{
				num = 0;
				base.Update();
				Transform transform = editTarget.transform;
				Camera camera = playerCamera;
				FreeCameraControl freeCameraControl = cameraNav;
				Transform transform2 = camera.transform;
				float z = vector.z;
				int num2 = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[0];
				InputAction inputAction = inputActionCancel;
				if (inputAction != null && array == null)
				{
					continue;
				}
				array[0] = inputAction;
				InputAction inputAction2 = inputActionRemoveWholeFence;
				if (inputAction2 != null && array == null)
				{
					continue;
				}
				array[1] = inputAction2;
				InputAction inputAction3 = inputActionUndo;
				if (inputAction3 != null && array == null)
				{
					continue;
				}
				array[2] = inputAction3;
				InputAction inputAction4 = inputActionUndoAll;
				if (inputAction4 == null || array != null)
				{
					array[3] = inputAction4;
					inputAction5 = inputActionReplace;
					if (inputAction5 == null || array != null)
					{
						break;
					}
				}
			}
			array[4] = inputAction5;
			InputAction.UpdateAll(deltaTime, array);
			List<Task> list = base.blockingTasks;
			if (CanUndoLastCommand)
			{
				GridObjectScript selectedGridObject = base._selectedGridObject;
				int num3 = 0;
				if (!(selectedGridObject != (UnityEngine.Object)num3))
				{
					if ((inputActionUndo.IsTriggered ? 1 : 0) != num && (undoingAll ? 1 : 0) == num)
					{
						UndoLastCommand();
					}
					if ((inputActionUndoAll.IsTriggered ? 1 : 0) == num)
					{
						goto IL_0180;
					}
					int num4 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
				if ((inputActionCancel.IsTriggered ? 1 : 0) != num && !IsInFenceMode())
				{
					AK.Wwise.Event sfxCancelItemEvent = _sfxCancelItemEvent;
					if (sfxCancelItemEvent != null)
					{
						GameObject gameObject = base.gameObject;
						uint num5 = sfxCancelItemEvent.Post(gameObject);
					}
					UndoLastCommand();
				}
			}
			goto IL_0180;
			IL_0321:
			num++;
			goto IL_0325;
			IL_0180:
			if (IsInFenceMode())
			{
				GridObjectScript selectedGridObject2 = base._selectedGridObject;
				int num6 = 0;
				if (selectedGridObject2 != (UnityEngine.Object)num6 && (inputActionCancel.IsTriggered ? 1 : 0) != num && CanDeselectSelectedObject)
				{
					AK.Wwise.Event sfxCancelItemEvent2 = _sfxCancelItemEvent;
					if (sfxCancelItemEvent2 != null)
					{
						GameObject gameObject2 = base.gameObject;
						uint num7 = sfxCancelItemEvent2.Post(gameObject2);
					}
					DeselectSelectedObject();
				}
				if ((inputActionRemoveWholeFence.IsTriggered ? 1 : 0) != num && IsInFenceMode() && CanRemoveSelectedObject)
				{
					RemoveWholeFence();
				}
			}
			GridObjectScript selectedGridObject3 = base._selectedGridObject;
			int num8 = 0;
			if (selectedGridObject3 != (UnityEngine.Object)num8 && (inputActionReplace.IsTriggered ? 1 : 0) != num && CanReplaceSelectedObject)
			{
				int num9 = 0;
				Task task = default(Task);
				((List<T>)(object)base.blockingTasks).Add((T)task);
				task.FireAndForgetTask();
			}
			bool flag = default(bool);
			if (!flag)
			{
				HouseWallManager houseWallManager = this.houseWallManager;
				Task asyncTask2 = default(Task);
				asyncTask2.FireAndForgetTask();
				int num10 = 0;
				previewWall = ((House.Types.WallPosition wall, Item previousWallpaper)?)(object)num10;
				((Nullable<>*)(IntPtr)previewWall)->has_value = (byte)num10 != 0;
				BaseUiRoot.Instance.HideLootOfflineMarkers();
				BaseUiRoot.Instance.HideMailboxMarkers();
				return;
			}
			Vector2 vector2 = base.CursorPosition;
			float y = base.CursorPosition.y;
			Camera camera2 = playerCamera;
			Vector3 zero = Vector3.zero;
			Renderer mainWallRenderer = this.houseWallManager.GetMainWallRenderer((House.Types.WallPosition)num);
			Transform transform3 = mainWallRenderer.transform;
			Transform transform4 = mainWallRenderer.transform;
			Vector3 vector3 = default(Vector3);
			float z2 = vector3.z;
			bool flag2 = default(bool);
			if (flag2)
			{
				int num11 = 0;
				Vector3 vector4 = default(Vector3);
				float z3 = vector4.z;
				Vector2 zero2 = Vector2.zero;
				if (num != 0)
				{
					if (num != 0)
					{
						if (num == 0)
						{
							goto IL_030a;
						}
						if (num != 1)
						{
							goto IL_031c;
						}
					}
					Vector3 vector5 = default(Vector3);
					float z4 = vector5.z;
				}
				goto IL_030a;
			}
			goto IL_0321;
			IL_030a:
			Vector3 vector6 = default(Vector3);
			float z5 = vector6.z;
			Vector3 vector7 = default(Vector3);
			float z6 = vector7.z;
			goto IL_031c;
			IL_031c:
			bool flag3 = default(bool);
			if (!flag3)
			{
				goto IL_0321;
			}
			goto IL_0325;
			IL_0325:
			if ((base.leftClickTapGesture.IsTrue ? 1 : 0) == num)
			{
				if ((inputActionInteract.IsTriggered ? 1 : 0) != num)
				{
				}
				HouseWallManager houseWallManager2 = this.houseWallManager;
				Task asyncTask3 = default(Task);
				asyncTask3.FireAndForgetTask();
				int num12 = 0;
				previewWall = ((House.Types.WallPosition wall, Item previousWallpaper)?)(object)num12;
				previewWall = ((House.Types.WallPosition wall, Item previousWallpaper)?)(object)num12;
				HouseWallManager houseWallManager3 = this.houseWallManager;
				House.Types.WallPosition wallPosition = default(House.Types.WallPosition);
				int num13 = (int)wallPosition;
				Item item = default(Item);
				int itemID = item.ItemID;
				int num14 = 0;
				HouseWallManager houseWallManager4 = this.houseWallManager;
				previewWall = ((House.Types.WallPosition wall, Item previousWallpaper)?)(object)num14;
				Task asyncTask4 = default(Task);
				asyncTask4.FireAndForgetTask();
			}
			Dictionary<House.Types.WallPosition, Item> dictionary = (Dictionary<House.Types.WallPosition, Item>)(object)new Dictionary<TKey, TValue>();
			int num15 = 0;
			bool flag4 = (IntPtr)"{il2cpp field on {'constant256' (constant value of type Cpp2IL.Core.Analysis.ResultModels.FieldPointer)}, offset 0x0}" == (IntPtr)num;
			bool flag5 = default(bool);
			if (flag5)
			{
			}
			HouseWallManager houseWallManager5 = this.houseWallManager;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001134")]
		[Cpp2IlInjected.Address(RVA = "0xCF40E0", Offset = "0xCF2AE0", VA = "0x180CF40E0", Slot = "5")]
		public unsafe override void OnSystemStop()
		{
			//Discarded unreachable code: IL_01ee, IL_01f4
			//IL_0066: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_0089: Expected O, but got I4
			//IL_0090: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_00b1: Expected O, but got I4
			//IL_00b9: Expected native int or pointer, but got O
			//IL_00c5: Expected O, but got I4
			//IL_00cc: Expected O, but got I4
			//IL_00fc: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
			SetCullingReferenceTransform(_003Ctransform_003Ek__BackingField);
			avatar.gameObject.SetActive(value: true);
			CommandStack.CommandAddedOrRemovedDelegate commandAddedOrRemovedDelegate = OnCommandAdded;
			CommandStack.CommandAddedOrRemovedDelegate commandAddedOrRemovedDelegate2 = OnCommandRemoved;
			CommandStack.CommandAddedOrRemovedDelegate commandAddedOrRemovedDelegate3 = OnCommandStackChanged;
			CommandStack.CommandAddedOrRemovedDelegate commandAddedOrRemovedDelegate4 = OnCommandStackChanged;
			commandStack = (CommandStack)num2;
			fakeBackpack = (ContainerInventory)num2;
			fakeCatalog = (ListInventory)num2;
			fakeBuildingInventory = (ListInventory)num2;
			allAvailableLandscapingItems = (HashSet<Item>)num2;
			availableOriginalLandscapingItems = (List<Item>)num2;
			FilterData = (ItemFilterData)num2;
			StartData = (GridEditModeStartData)num2;
			Item item = (SelectedWallpaperItem = Item.Invalid);
			int num3 = 0;
			previewWall = ((House.Types.WallPosition wall, Item previousWallpaper)?)(object)num3;
			((Nullable<>*)(IntPtr)previewWall)->has_value = (byte)num3 != 0;
			playerHouseEnvironment = (PlayerHouseEnvironment)num2;
			houseWallManager = (HouseWallManager)num2;
			_selectWallpaperVFXPrefab.ReleaseAsset();
			Dictionary<GridObjectScript, CancellationTokenSource>.ValueCollection values = (Dictionary<GridObjectScript, CancellationTokenSource>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)cart).get_Values();
			bool flag = default(bool);
			if (flag)
			{
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num4 = 0;
			Mdl.Furnitures.FurnitureCustomization system = default(Mdl.Furnitures.FurnitureCustomization);
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num4)
			{
				ProfileEventDispatcher.ShopItemBought value = default(ProfileEventDispatcher.ShopItemBought);
				SystemRoot.Instance.MetaClient.Dispatcher.OnShopItemBought -= value;
				ProfileEventDispatcher.ItemsSold value2 = default(ProfileEventDispatcher.ItemsSold);
				SystemRoot.Instance.MetaClient.Dispatcher.OnItemsSold -= value2;
				SystemRoot.Instance.GetSystem<PlayerNavigation>().ResumeSystem();
				SystemRoot.Instance.GetSystem<CritterManager>().UpdateState();
				SystemRoot.Instance.MetaClient.Clock.IsPaused = false;
				PostProcessManager.Instance.SetDof(DOFDistance.DEFAULT);
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				SceneData sceneData = default(SceneData);
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				GameObject gameObject = default(GameObject);
				gameObject.GetComponent<Mdl.Environments.Environment>().RefreshGrid();
				system = SystemRoot.Instance.GetSystem<Mdl.Furnitures.FurnitureCustomization>();
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				system.RefreshAllDecals(profile);
			}
			int num5 = 0;
			WeatherController.ResetAnchor();
			Delegate @delegate = default(Delegate);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while (@delegate != system)
				{
				}
				BaseUiRoot.Instance.ShowLootOfflineMarkers();
				BaseUiRoot.Instance.ShowMailboxMarkers();
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001136")]
		[Cpp2IlInjected.Address(RVA = "0xCF4D00", Offset = "0xCF3700", VA = "0x180CF4D00")]
		[AsyncStateMachine(typeof(_003CQuitEditMode_003Ed__112))]
		public Task<bool> QuitEditMode(CancellationToken ct, bool confirm)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001137")]
		[Cpp2IlInjected.Address(RVA = "0xCED2E0", Offset = "0xCEBCE0", VA = "0x180CED2E0")]
		public bool CanAddObjectFromBackpack(Item item, ItemState itemState)
		{
			//IL_0010: Expected O, but got I4
			GridObjectScript selectedGridObject = base._selectedGridObject;
			int num = 0;
			if (!(selectedGridObject != (UnityEngine.Object)num) || CanDeselectSelectedObject)
			{
				ContainerInventory backpack = SystemRoot.Instance.MetaClient.profile.Backpack;
				bool flag = default(bool);
				if (flag)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					IItemData itemData = default(IItemData);
					bool flag2 = default(bool);
					bool flag3 = default(bool);
					if (itemData != null && flag2 && !flag2 && flag3)
					{
						goto IL_0054;
					}
				}
			}
			int num2 = 0;
			goto IL_0054;
			IL_0054:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001138")]
		[Cpp2IlInjected.Address(RVA = "0xCECAC0", Offset = "0xCEB4C0", VA = "0x180CECAC0")]
		[AsyncStateMachine(typeof(_003CAddObjectFromBackpack_003Ed__114))]
		public Task AddObjectFromBackpack(Item item, int amount, ItemState itemState, Vector2 screenPosition, bool drag)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001139")]
		[Cpp2IlInjected.Address(RVA = "0xCF5950", Offset = "0xCF4350", VA = "0x180CF5950")]
		[AsyncStateMachine(typeof(_003CSpawnObject_003Ed__115))]
		private static Task<GameObject> SpawnObject(Item item, GridPosition gridPosition, GridOrientation gridOrientation, GridScript gridToUse, bool bounce = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GameObject>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600113A")]
		[Cpp2IlInjected.Address(RVA = "0xCEC960", Offset = "0xCEB360", VA = "0x180CEC960")]
		[AsyncStateMachine(typeof(_003CAddObjectFromBackpack_003Ed__116))]
		private Task AddObjectFromBackpack(Item item, int amount, ItemState itemState, GridPosition gridPosition, GridOrientation gridOrientation, GridScript gridToUse)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600113B")]
		[Cpp2IlInjected.Address(RVA = "0xCEDFF0", Offset = "0xCEC9F0", VA = "0x180CEDFF0")]
		public bool CanUseItem(Item item)
		{
			//Discarded unreachable code: IL_002e
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			if (itemData == null)
			{
				ItemType itemType = default(ItemType);
				if (itemType == ItemType.Trimming)
				{
					SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				}
				int num = 0;
			}
			bool flag = default(bool);
			while (!flag)
			{
			}
			while (flag)
			{
			}
			bool flag2 = default(bool);
			while (!flag2)
			{
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x600113C")]
		[Cpp2IlInjected.Address(RVA = "0xCED600", Offset = "0xCEC000", VA = "0x180CED600")]
		[AsyncStateMachine(typeof(_003CCanAdd_003Ed__118))]
		private Task<bool> CanAdd(Item item)
		{
			int itemID = item.ItemID;
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600113D")]
		[Cpp2IlInjected.Address(RVA = "0xCECC10", Offset = "0xCEB610", VA = "0x180CECC10")]
		[AsyncStateMachine(typeof(_003CAddObjectFromCatalog_003Ed__119))]
		public Task AddObjectFromCatalog(Item item, Vector2 screenPosition, bool drag)
		{
			int itemID = item.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600113E")]
		[Cpp2IlInjected.Address(RVA = "0xCECD60", Offset = "0xCEB760", VA = "0x180CECD60")]
		[AsyncStateMachine(typeof(_003CAddObjectFromCatalog_003Ed__120))]
		private Task AddObjectFromCatalog(Item item, GridPosition gridPosition, GridOrientation gridOrientation, GridScript gridToUse)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600113F")]
		[Cpp2IlInjected.Address(RVA = "0xCF03B0", Offset = "0xCEEDB0", VA = "0x180CF03B0")]
		public unsafe Item HandleVariations(Item item)
		{
			//IL_0018: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			int itemID = item.ItemID;
			int num = 0;
			int num2 = 0;
			Item item2 = (Item)itemID;
			bool flag = default(bool);
			FurnitureItemType furnitureItemType = default(FurnitureItemType);
			if (ItemDatabase.Instance.TryGetItemData((Item)num2, out *(IItemIsVariationOf*)num) && (!flag || furnitureItemType != FurnitureItemType.Fence))
			{
				Item[] array = default(Item[]);
				if (!((Dictionary<TKey, TValue>)(object)variationsPerItem).TryGetValue((TKey)num, out *(TValue*)num))
				{
					Func<IItemIsVariationOf, bool> func = (Func<IItemIsVariationOf, bool>)(object)(Func<T, TResult>)((IItemIsVariationOf x) => (byte)(int)typeof(Item).TypeHandle != 0);
					IEnumerable<> enumerable = default(IEnumerable<>);
					IEnumerable<IItemIsVariationOf> enumerable2 = (IEnumerable<IItemIsVariationOf>)Enumerable.Where<IItemIsVariationOf>(enumerable, (Func<, >)(object)func);
					Func<IItemIsVariationOf, Item> func2 = default(Func<IItemIsVariationOf, Item>);
					if (_003C_003Ec._003C_003E9__122_1 == null)
					{
						func2 = (Func<IItemIsVariationOf, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							throw new NullReferenceException();
						});
					}
					IEnumerable<IItemIsVariationOf> enumerable3 = (IEnumerable<IItemIsVariationOf>)Enumerable.Select<IItemIsVariationOf, Item>((IEnumerable<>)enumerable2, (Func<, >)(object)func2);
					IEnumerable<Item> enumerable4 = default(IEnumerable<Item>);
					array = Enumerable.Concat<Item>((IEnumerable<>)enumerable4, (IEnumerable<>)enumerable3).ToArray<Item>();
					Dictionary<Item, Item[]> dictionary = variationsPerItem;
					throw new NullReferenceException();
				}
				int num3 = 0;
				NullReferenceException ex = default(NullReferenceException);
				return array[(object)ex];
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001140")]
		[Cpp2IlInjected.Address(RVA = "0xCEC590", Offset = "0xCEAF90", VA = "0x180CEC590")]
		[AsyncStateMachine(typeof(_003CAddBuildingFromCatalog_003Ed__123))]
		private Task AddBuildingFromCatalog(Item buildingItem, GridPosition gridPosition, GridOrientation gridOrientation, GridScript gridToUse)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001141")]
		[Cpp2IlInjected.Address(RVA = "0xCEC810", Offset = "0xCEB210", VA = "0x180CEC810")]
		[AsyncStateMachine(typeof(_003CAddLandscapingItem_003Ed__124))]
		public Task AddLandscapingItem(Item landcapingItem, Vector2 screenPosition, bool drag)
		{
			int itemID = landcapingItem.ItemID;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001142")]
		[Cpp2IlInjected.Address(RVA = "0xCEC6D0", Offset = "0xCEB0D0", VA = "0x180CEC6D0")]
		[AsyncStateMachine(typeof(_003CAddLandcapingItem_003Ed__125))]
		private Task AddLandcapingItem(Item landscapingItem, GridPosition gridPosition, GridOrientation gridOrientation, GridScript gridToUse)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001144")]
		[Cpp2IlInjected.Address(RVA = "0xCEEB70", Offset = "0xCED570", VA = "0x180CEEB70", Slot = "20")]
		[AsyncStateMachine(typeof(_003CDoDuplicateSelectedObject_003Ed__128))]
		protected override Task DoDuplicateSelectedObject()
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001146")]
		[Cpp2IlInjected.Address(RVA = "0xCEEC90", Offset = "0xCED690", VA = "0x180CEEC90", Slot = "22")]
		[AsyncStateMachine(typeof(_003CDoRemoveSelectedObject_003Ed__131))]
		protected override Task DoRemoveSelectedObject()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001147")]
		[Cpp2IlInjected.Address(RVA = "0xCEE6C0", Offset = "0xCED0C0", VA = "0x180CEE6C0")]
		private RemoveCommand CreateDefaultRemoveCommand(GridObjectScript gridObjectScript, GridScript gridScript, GridObject initialGridObject, IGridMovementRestriction movementRestriction)
		{
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int itemID = gridObjectScript.GridObject.ItemID;
			IBackpackItem backpackItem = default(IBackpackItem);
			if (backpackItem == null)
			{
				ListInventory catalog = SystemRoot.Instance.MetaClient.profile.Catalog;
				int itemID2 = gridObjectScript.GridObject.ItemID;
				bool flag = default(bool);
				if (!flag)
				{
					int itemID3 = gridObjectScript.GridObject.ItemID;
					bool flag2 = default(bool);
					if (flag2)
					{
					}
				}
				Dictionary<GridObjectScript, CancellationTokenSource> dictionary = cart;
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001149")]
		[Cpp2IlInjected.Address(RVA = "0xCF4F50", Offset = "0xCF3950", VA = "0x180CF4F50")]
		public void RemoveWholeFence()
		{
			//Discarded unreachable code: IL_008b, IL_00a8
			//IL_00a7: Expected O, but got I4
			if (base._currentGridMovementRestriction == null)
			{
			}
			int num = 0;
			int num2 = 0;
			AK.Wwise.Event sfxRemoveItemEvent = _sfxRemoveItemEvent;
			if (sfxRemoveItemEvent != null)
			{
				GameObject gameObject = base.gameObject;
				uint num3 = sfxRemoveItemEvent.Post(gameObject);
			}
			FenceCommand fenceCommand = pendingFenceCommand;
			if (fenceCommand != null)
			{
				this.commandStack.DoCommand(fenceCommand);
				GridObject gridObject = (_initialSelectedGridObjectTransform = base._selectedGridObject.GridObject.Clone());
			}
			GridObjectScript selectedGridObject = base._selectedGridObject;
			CommandStack commandStack = this.commandStack;
			GridScript _003CGridScript_003Ek__BackingField = selectedGridObject.GridScript;
			Dictionary<GridObjectScript, CancellationTokenSource> dictionary = cart;
			GridObject initialSelectedGridObjectTransform = _initialSelectedGridObjectTransform;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600114C")]
		[Cpp2IlInjected.Address(RVA = "0xCF0EE0", Offset = "0xCEF8E0", VA = "0x180CF0EE0", Slot = "28")]
		protected override bool IsValidMove(GridPosition mainGridPosition, GridOrientation mainGridOrientation, GridScript usedGridScript, GridArea gridArea)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600114D")]
		[Cpp2IlInjected.Address(RVA = "0xCECEA0", Offset = "0xCEB8A0", VA = "0x180CECEA0", Slot = "29")]
		protected override void ApplyMove(GridScript usedGridScript, GridPosition mainGridPosition, GridOrientation mainGridOrientation)
		{
			//Discarded unreachable code: IL_003e, IL_0042, IL_0071, IL_0079
			int num = 0;
			if (base._currentGridMovementRestriction == null)
			{
			}
			int num2 = 0;
			int num3 = 0;
			GridOrientation gridOrientation = mainGridOrientation;
			GridScript gridScript = usedGridScript;
		}

		[Cpp2IlInjected.Token(Token = "0x600114E")]
		[Cpp2IlInjected.Address(RVA = "0xCEDA50", Offset = "0xCEC450", VA = "0x180CEDA50", Slot = "23")]
		public unsafe override bool CanRotateSelectedObject(bool clockwise)
		{
			//Discarded unreachable code: IL_00a8
			//IL_0012: Expected O, but got I4
			int num = 0;
			GridObjectScript selectedGridObject = base._selectedGridObject;
			int num2 = 0;
			if (selectedGridObject != (UnityEngine.Object)num2)
			{
				int itemID = base._selectedGridObject.GridObject.ItemID;
				bool flag = default(bool);
				ActivityItemType activityItemType = default(ActivityItemType);
				if (!flag || activityItemType != ActivityItemType.RequestItem)
				{
					int itemID2 = base._selectedGridObject.GridObject.ItemID;
					ItemType itemType = default(ItemType);
					if (itemType != ItemType.Tool)
					{
						int itemID3 = base._selectedGridObject.GridObject.ItemID;
						bool flag2 = default(bool);
						FurnitureItemType furnitureItemType = default(FurnitureItemType);
						FurnitureItemType furnitureItemType2 = default(FurnitureItemType);
						if (!flag2 || (furnitureItemType != FurnitureItemType.GroundAlteration && furnitureItemType2 != FurnitureItemType.Fence))
						{
							int itemID4 = base._selectedGridObject.GridObject.ItemID;
							Client client = default(Client);
							Profile profile = client.profile;
							Client client2 = default(Client);
							Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client2.TransactionContext;
							IGridEditRestriction gridEditRestriction = default(IGridEditRestriction);
							if (gridEditRestriction.CanRotate(profile, _003CTransactionContext_003Ek__BackingField))
							{
							}
						}
					}
				}
			}
			return base.CanRotateSelectedObjectWithOrientation(clockwise, out *(GridOrientation*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001150")]
		[Cpp2IlInjected.Address(RVA = "0xCEEA50", Offset = "0xCED450", VA = "0x180CEEA50", Slot = "25")]
		[AsyncStateMachine(typeof(_003CDoDeselectSelectedObject_003Ed__145))]
		protected override Task<bool> DoDeselectSelectedObject()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001151")]
		[Cpp2IlInjected.Address(RVA = "0xCEE660", Offset = "0xCED060", VA = "0x180CEE660", Slot = "30")]
		protected override void ChangeSelectedObjectGrid(GridScript newGridScript)
		{
			//Discarded unreachable code: IL_002c
			base.ChangeSelectedObjectGrid(newGridScript);
			AddCommand addCommand = pendingAddCommand;
			if (addCommand != null)
			{
				uint iD_ = base._selectedGridObject.GridObject.iD_;
				addCommand.ChangeGrid(newGridScript, iD_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001152")]
		[Cpp2IlInjected.Address(RVA = "0xCEDD20", Offset = "0xCEC720", VA = "0x180CEDD20", Slot = "13")]
		public override bool CanSelectObject(GridObjectScript gridObjectScript)
		{
			if ((long)gridObjectScript.GridObject != 0)
			{
				Item item = SelectedWallpaperItem;
				bool flag = default(bool);
				if (!flag)
				{
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					int itemID = _003CGridObject_003Ek__BackingField.ItemID;
					Client client = default(Client);
					Profile profile = client.profile;
					Client client2 = default(Client);
					Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client2.TransactionContext;
					IGridEditRestriction gridEditRestriction = default(IGridEditRestriction);
					if (gridEditRestriction.CanBeSelected(profile, _003CTransactionContext_003Ek__BackingField))
					{
						int itemID2 = gridObjectScript.GridObject.ItemID;
						bool flag2 = default(bool);
						ActivityItemType activityItemType = default(ActivityItemType);
						ActivityItemType activityItemType2 = default(ActivityItemType);
						ActivityItemType activityItemType3 = default(ActivityItemType);
						if (!flag2 || (activityItemType != ActivityItemType.RequestItem && activityItemType2 != ActivityItemType.Consummable && activityItemType3 != ActivityItemType.LootPresent))
						{
							int itemID3 = gridObjectScript.GridObject.ItemID;
							ItemType itemType = default(ItemType);
							if (itemType != ItemType.Tool)
							{
								IGridMovementRestriction[] array = base.gridMovementRestrictions;
							}
						}
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001153")]
		[Cpp2IlInjected.Address(RVA = "0xCED950", Offset = "0xCEC350", VA = "0x180CED950", Slot = "14")]
		public override bool CanIgnoreObject(GridObjectScript gridObjectScript)
		{
			//IL_0010: Expected O, but got I4
			GridObjectScript selectedGridObject = base._selectedGridObject;
			int num = 0;
			if (selectedGridObject != (UnityEngine.Object)num)
			{
				int itemID = gridObjectScript.GridObject.ItemID;
				ItemType itemType = default(ItemType);
				if (itemType == ItemType.Furniture)
				{
					int itemID2 = gridObjectScript.GridObject.ItemID;
					FurnitureItemType furnitureItemType = default(FurnitureItemType);
					return furnitureItemType == FurnitureItemType.GroundAlteration;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001154")]
		[Cpp2IlInjected.Address(RVA = "0xCF54C0", Offset = "0xCF3EC0", VA = "0x180CF54C0")]
		[AsyncStateMachine(typeof(_003CRequestClearingPermission_003Ed__149))]
		private Task<(bool, GridCommand)> RequestClearingPermission(GridCommand commandToDo)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<(bool, GridCommand)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001156")]
		[Cpp2IlInjected.Address(RVA = "0xCF5FF0", Offset = "0xCF49F0", VA = "0x180CF5FF0")]
		public void UndoLastCommand()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001157")]
		[Cpp2IlInjected.Address(RVA = "0xCF5EF0", Offset = "0xCF48F0", VA = "0x180CF5EF0")]
		[AsyncStateMachine(typeof(_003CUndoLastCommandAsync_003Ed__153))]
		public Task UndoLastCommandAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001158")]
		[Cpp2IlInjected.Address(RVA = "0xCF5DA0", Offset = "0xCF47A0", VA = "0x180CF5DA0")]
		public void UndoAllCommands()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001159")]
		[Cpp2IlInjected.Address(RVA = "0xCF5CA0", Offset = "0xCF46A0", VA = "0x180CF5CA0")]
		[AsyncStateMachine(typeof(_003CUndoAllCommandsAsync_003Ed__156))]
		public Task UndoAllCommandsAsync()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600115B")]
		[Cpp2IlInjected.Address(RVA = "0xCF5310", Offset = "0xCF3D10", VA = "0x180CF5310")]
		public void ReplaceSelectedObject()
		{
			//Discarded unreachable code: IL_0015
			int num = 0;
			Task task = default(Task);
			((List<T>)(object)base.blockingTasks).Add((T)task);
			task.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600115C")]
		[Cpp2IlInjected.Address(RVA = "0xCF51F0", Offset = "0xCF3BF0", VA = "0x180CF51F0")]
		[AsyncStateMachine(typeof(_003CReplaceSelectedObjectAsync_003Ed__160))]
		private Task ReplaceSelectedObjectAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600115D")]
		[Cpp2IlInjected.Address(RVA = "0xCEF710", Offset = "0xCEE110", VA = "0x180CEF710")]
		public ContainerInventory GetFakeBackpack()
		{
			return fakeBackpack;
		}

		[Cpp2IlInjected.Token(Token = "0x600115E")]
		[Cpp2IlInjected.Address(RVA = "0xCEF730", Offset = "0xCEE130", VA = "0x180CEF730")]
		public ListInventory GetFakeCatalog()
		{
			return fakeCatalog;
		}

		[Cpp2IlInjected.Token(Token = "0x600115F")]
		[Cpp2IlInjected.Address(RVA = "0xCEF720", Offset = "0xCEE120", VA = "0x180CEF720")]
		public ListInventory GetFakeBuildingInventory()
		{
			return fakeBuildingInventory;
		}

		[Cpp2IlInjected.Token(Token = "0x6001160")]
		[Cpp2IlInjected.Address(RVA = "0xCEFA80", Offset = "0xCEE480", VA = "0x180CEFA80")]
		public int GetRemainingAmountOfSelectedFences()
		{
			//Discarded unreachable code: IL_003f
			if (IsInFenceMode())
			{
				FenceCommand fenceCommand = pendingFenceCommand;
				if (fenceCommand == null)
				{
					GridObjectScript selectedGridObject = base._selectedGridObject;
					ListInventory listInventory = fakeCatalog;
					int itemID = selectedGridObject.GridObject.ItemID;
					bool flag = default(bool);
					if (flag)
					{
					}
					return 0;
				}
				return fenceCommand.RemainingNumberOfFences;
			}
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001161")]
		[Cpp2IlInjected.Address(RVA = "0xCEF2B0", Offset = "0xCEDCB0", VA = "0x180CEF2B0")]
		public IEnumerable<Item> GetAvailableLandscapingItems()
		{
			List<Item> list = availableOriginalLandscapingItems;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001162")]
		[Cpp2IlInjected.Address(RVA = "0xCED730", Offset = "0xCEC130", VA = "0x180CED730")]
		public bool CanBePutBackInInventory(Item item)
		{
			//Discarded unreachable code: IL_004e
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int itemID = base._selectedGridObject.GridObject.ItemID;
			IBackpackItem backpackItem = default(IBackpackItem);
			if (backpackItem == null)
			{
				GridObjectScript selectedGridObject = base._selectedGridObject;
				ListInventory listInventory = fakeCatalog;
				int itemID2 = selectedGridObject.GridObject.ItemID;
				bool flag = default(bool);
				if (!flag)
				{
					bool flag2 = default(bool);
					if (!flag2)
					{
						return flag2;
					}
					BuildingItemType buildingItemType = default(BuildingItemType);
					return buildingItemType == BuildingItemType.House;
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001163")]
		[Cpp2IlInjected.Address(RVA = "0xCEFA40", Offset = "0xCEE440", VA = "0x180CEFA40")]
		public Meta.Grids.Grid GetNewEditGrid(string gridDataPath)
		{
			GridCollection gridCollection = editGridCollection;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001164")]
		[Cpp2IlInjected.Address(RVA = "0xCEF6E0", Offset = "0xCEE0E0", VA = "0x180CEF6E0")]
		public GridCollection GetEditGridCollectionCopy()
		{
			//Discarded unreachable code: IL_000c
			return editGridCollection.Clone();
		}

		[Cpp2IlInjected.Token(Token = "0x6001165")]
		[Cpp2IlInjected.Address(RVA = "0xCED1A0", Offset = "0xCEBBA0", VA = "0x180CED1A0")]
		[AsyncStateMachine(typeof(_003CBuyAllCartItems_003Ed__169))]
		public Task<bool> BuyAllCartItems(CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001166")]
		[Cpp2IlInjected.Address(RVA = "0xCEF740", Offset = "0xCEE140", VA = "0x180CEF740")]
		public Dictionary<Item, int> GetItemsInCart()
		{
			Dictionary<GridObjectScript, CancellationTokenSource> dictionary = cart;
			Func<KeyValuePair<GridObjectScript, CancellationTokenSource>, Item> _003C_003E9__170_ = _003C_003Ec._003C_003E9__170_0;
			if (_003C_003E9__170_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				};
			}
			IEnumerable<> enumerable = Enumerable.GroupBy<KeyValuePair<GridObjectScript, CancellationTokenSource>, Item>((IEnumerable<>)dictionary, (Func<, >)(object)_003C_003E9__170_);
			Func<IGrouping<Item, KeyValuePair<GridObjectScript, CancellationTokenSource>>, Item> func = default(Func<IGrouping<Item, KeyValuePair<GridObjectScript, CancellationTokenSource>>, Item>);
			if (_003C_003Ec._003C_003E9__170_1 == null)
			{
				func = (Func<IGrouping<Item, KeyValuePair<GridObjectScript, CancellationTokenSource>>, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				});
			}
			Func<IGrouping<Item, KeyValuePair<GridObjectScript, CancellationTokenSource>>, int> func2 = default(Func<IGrouping<Item, KeyValuePair<GridObjectScript, CancellationTokenSource>>, int>);
			if (_003C_003Ec._003C_003E9__170_2 == null)
			{
				func2 = (Func<IGrouping<Item, KeyValuePair<GridObjectScript, CancellationTokenSource>>, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((IGrouping<Item, KeyValuePair<GridObjectScript, CancellationTokenSource>> x) => Enumerable.Count<KeyValuePair<GridObjectScript, CancellationTokenSource>>((IEnumerable<>)x)));
			}
			return (Dictionary<Item, int>)(object)Enumerable.ToDictionary<IGrouping<Item, KeyValuePair<GridObjectScript, CancellationTokenSource>>, Item, int>(enumerable, (Func<, >)(object)func, (Func<, >)(object)func2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001167")]
		[Cpp2IlInjected.Address(RVA = "0xCF5740", Offset = "0xCF4140", VA = "0x180CF5740")]
		public void SetGizmosVisibility(bool visible)
		{
			//Discarded unreachable code: IL_0039, IL_003f
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			GridScript[] array = allGridScripts;
			int length = array.Length;
			if (num3 < length)
			{
				array[num3].SetVisualGridVisibility(visible);
				num3++;
			}
			List<SubGridScript> list = subGridScripts;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001168")]
		[Cpp2IlInjected.Address(RVA = "0xCF0970", Offset = "0xCEF370", VA = "0x180CF0970")]
		private unsafe bool IsItemValidInThisScene(Item item)
		{
			//IL_00db: Expected O, but got I4
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IGridPlaceableItemData gridPlaceableItemData2 = default(IGridPlaceableItemData);
			IGridPlaceableItemData gridPlaceableItemData = gridPlaceableItemData2;
			if (gridPlaceableItemData != null && gridPlaceableItemData2 != null)
			{
				IGridPlaceableItemData gridPlaceableItemData3 = gridPlaceableItemData;
				int num2 = 0;
				bool flag = default(bool);
				if (flag)
				{
					GridScript[] array = allGridScripts;
					if (array == null)
					{
						SceneData sceneData = default(SceneData);
						AsyncOperation operation = sceneData.sceneInstance.m_Operation;
						CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
						SceneItemData sceneItemData = sceneData.sceneItemData;
						GameObject gameObject = default(GameObject);
						GridScript[] componentsInChildren = gameObject.GetComponentsInChildren<GridScript>();
						Func<GridScript, bool> _003C_003E9__172_ = _003C_003Ec._003C_003E9__172_0;
						if (_003C_003E9__172_ == null)
						{
							_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridScript x)
							{
								if ((object)x == null)
								{
									return 0 == 0;
								}
								int num6 = 0;
								return (object)x == null;
							};
						}
						GridScript[] array2 = Enumerable.Where<GridScript>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)_003C_003E9__172_).ToArray<GridScript>();
					}
					if (array.Length != 0)
					{
						Func<GridFloorType, GridScript, GridFloorType> func = default(Func<GridFloorType, GridScript, GridFloorType>);
						if (_003C_003Ec._003C_003E9__172_1 == null)
						{
							func = (Func<GridFloorType, GridScript, GridFloorType>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T1, T2, TResult>)((GridFloorType current, GridScript gridScript) => gridScript.AvailableFloorTypes));
						}
						int num3 = 0;
						GridScript gridScript2 = Enumerable.Aggregate<GridScript, GridFloorType>((IEnumerable<>)(object)array, (GridScript)num3, (Func<, , >)(object)func);
						IGridPlaceableItemData gridPlaceableItemData4 = gridPlaceableItemData;
						if ((object)gridScript2 != null)
						{
							Predicate<GridScript> predicate = (Predicate<GridScript>)(object)(Predicate<T>)delegate(GridScript x)
							{
								//Discarded unreachable code: IL_0029
								GridData gridData = x.GridData;
								IGridPlaceableItemData gridPlaceableItemData5 = gridPlaceableItemData;
								IGridPlaceableItemData gridPlaceableItemData6 = gridPlaceableItemData;
								int num5 = 0;
								GridPosition position = *(GridPosition*)num5 - *(GridPosition*)num5;
								return gridData.Contains(position);
							};
							int num4 = default(int);
							return num4 != -1;
						}
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001169")]
		[Cpp2IlInjected.Address(RVA = "0xCF13E0", Offset = "0xCEFDE0", VA = "0x180CF13E0")]
		private unsafe void OnCommandAdded(Command command)
		{
			//Discarded unreachable code: IL_01a9
			//IL_0181: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (command != null)
			{
				int num4 = 0;
				if (command != null)
				{
					ContainerInventory containerInventory = fakeBackpack;
					int num5 = 0;
				}
				int num6 = 0;
				if (command != null)
				{
					ListInventory listInventory = fakeCatalog;
				}
			}
			if (command == null)
			{
			}
			int num7 = 0;
			RemoveCatalogObjectCommand removeCatalogObjectCommand = (RemoveCatalogObjectCommand)command;
			RemoveCatalogObjectCommand removeCatalogObjectCommand2 = removeCatalogObjectCommand;
			if (removeCatalogObjectCommand2 != null)
			{
				Dictionary<GridObjectScript, CancellationTokenSource> dictionary = cart;
				GridObjectScript gridObjectScript = removeCatalogObjectCommand2.GridObjectScript;
				CancellationTokenSource cancellationTokenSource = default(CancellationTokenSource);
				if (!((Dictionary<TKey, TValue>)(object)dictionary).TryGetValue((TKey)gridObjectScript, out *(TValue*)num))
				{
					Func<KeyValuePair<GridObjectScript, CancellationTokenSource>, bool> func = (Func<KeyValuePair<GridObjectScript, CancellationTokenSource>, bool>)(object)(Func<T, TResult>)delegate
					{
						int itemID4 = removeCatalogObjectCommand.GridObjectCopy.ItemID;
						throw new NullReferenceException();
					};
					bool flag = default(bool);
					if (!flag)
					{
						ListInventory listInventory2 = fakeCatalog;
						int itemID = removeCatalogObjectCommand.GridObjectCopy.ItemID;
					}
					Dictionary<GridObjectScript, CancellationTokenSource> dictionary2 = cart;
					cancellationTokenSource.Cancel();
					cancellationTokenSource.Dispose();
					Dictionary<GridObjectScript, CancellationTokenSource> dictionary3 = cart;
				}
				cancellationTokenSource.Cancel();
				cancellationTokenSource.Dispose();
				Dictionary<GridObjectScript, CancellationTokenSource> dictionary4 = cart;
				GridObjectScript gridObjectScript2 = removeCatalogObjectCommand.GridObjectScript;
				bool flag2 = ((Dictionary<TKey, TValue>)(object)dictionary4).Remove((TKey)gridObjectScript2);
				NumberOfItemsInCartChangedDelegate numberOfItemsInCartChangedEvent = this.NumberOfItemsInCartChangedEvent;
				if (numberOfItemsInCartChangedEvent == null)
				{
					goto IL_0181;
				}
				int count = ((Dictionary<TKey, TValue>)(object)cart).Count;
				int num8 = 0;
				numberOfItemsInCartChangedEvent(count);
			}
			if (command == null)
			{
				return;
			}
			int num9 = 0;
			if (command != null)
			{
				ListInventory listInventory3 = fakeBuildingInventory;
				List<Item> list = (List<Item>)(object)new List<T>();
				if (listInventory3.HasAllItems((List<>)(object)list))
				{
					goto IL_0181;
				}
				ListInventory listInventory4 = fakeBuildingInventory;
			}
			int num10 = 0;
			if (command != null)
			{
				ListInventory listInventory5 = fakeCatalog;
				GridObjectScript gridObjectScript3 = default(GridObjectScript);
				int itemID2 = gridObjectScript3.GridObject.ItemID;
				GridObjectScript gridObjectScript4 = default(GridObjectScript);
				itemID2 = gridObjectScript4.GridObject.ItemID;
				int num11 = 0;
			}
			int num12 = 0;
			bool flag3 = default(bool);
			if (command != null && flag3)
			{
				OnCommandAdded((Command)num3);
			}
			goto IL_0181;
			IL_0181:
			int num13 = 0;
			GridObjectScript gridObjectScript5 = default(GridObjectScript);
			GridObject _003CGridObject_003Ek__BackingField = gridObjectScript5.GridObject;
			int itemID3 = _003CGridObject_003Ek__BackingField.ItemID;
			if (_003CGridObject_003Ek__BackingField != null)
			{
				int num14 = 0;
				if (itemID3 != 0 && itemID3 == 0)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600116A")]
		[Cpp2IlInjected.Address(RVA = "0xCF1D20", Offset = "0xCF0720", VA = "0x180CF1D20")]
		private unsafe void OnCommandRemoved(Command command)
		{
			//Discarded unreachable code: IL_01d8
			//IL_00e4: Expected O, but got I4
			//IL_00e4: Expected O, but got I4
			//IL_01a4: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (command != null)
			{
				int num4 = 0;
				if (command != null)
				{
					ContainerInventory containerInventory = fakeBackpack;
					GridObjectScript gridObjectScript = default(GridObjectScript);
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
					int num5 = 0;
					int itemID = _003CGridObject_003Ek__BackingField.ItemID;
				}
				ContainerInventory.CanAddResult canAddResult = default(ContainerInventory.CanAddResult);
				int num6 = (int)canAddResult;
				int num7 = 0;
				if (command != null)
				{
					ContainerInventory containerInventory2 = fakeBackpack;
					AmountWithState amountWithState = default(AmountWithState);
					if (num6 == 0 || amountWithState != null)
					{
					}
					AmountWithState amountWithState2 = default(AmountWithState);
					if (num != 0 && amountWithState2 == null)
					{
					}
				}
				int num8 = 0;
				if (command != null)
				{
					GridObjectScript key = default(GridObjectScript);
					if (!((Dictionary<TKey, TValue>)(object)cart).TryGetValue((TKey)key, out *(TValue*)num))
					{
						ListInventory listInventory = fakeCatalog;
					}
					GridObjectScript key2 = default(GridObjectScript);
					bool flag = ((Dictionary<TKey, TValue>)(object)cart).Remove((TKey)key2);
					NumberOfItemsInCartChangedDelegate numberOfItemsInCartChangedEvent = this.NumberOfItemsInCartChangedEvent;
					if (numberOfItemsInCartChangedEvent == null)
					{
						goto IL_01be;
					}
					int count = ((Dictionary<TKey, TValue>)(object)cart).Count;
					int num9 = 0;
					numberOfItemsInCartChangedEvent(count);
				}
				int num10 = 0;
				if (command != null)
				{
					ListInventory listInventory2 = fakeCatalog;
					Item item = default(Item);
					int itemID2 = item.ItemID;
				}
				int num11 = 0;
				if (command == null)
				{
					int num12 = 0;
					if (command != null)
					{
						ListInventory listInventory3 = fakeBuildingInventory;
						List<Item> list = (List<Item>)(object)new List<T>();
						GridObjectScript gridObjectScript2 = default(GridObjectScript);
						int itemID3 = gridObjectScript2.GridObject.ItemID;
						if (listInventory3.HasAllItems((List<>)(object)list))
						{
							goto IL_01be;
						}
						ListInventory listInventory4 = fakeBuildingInventory;
						GridObjectScript gridObjectScript3 = default(GridObjectScript);
						int itemID4 = gridObjectScript3.GridObject.ItemID;
					}
					int num13 = 0;
					if (command != null)
					{
						ListInventory listInventory5 = fakeBuildingInventory;
					}
					int num14 = 0;
					if (command != null)
					{
						ListInventory listInventory6 = fakeCatalog;
						GridObjectScript gridObjectScript4 = default(GridObjectScript);
						int itemID5 = gridObjectScript4.GridObject.ItemID;
						ListInventory listInventory7 = fakeCatalog;
						GridObjectScript gridObjectScript5 = default(GridObjectScript);
						itemID5 = gridObjectScript5.GridObject.ItemID;
						int num15 = default(int);
						int num16 = num15;
					}
					int num17 = 0;
					if (command != null)
					{
						bool flag2 = default(bool);
						if (flag2)
						{
							int num18 = 0;
							OnCommandRemoved((Command)num3);
						}
						num++;
						int num19 = 0;
						if (num == 0)
						{
							goto IL_01b2;
						}
					}
					int num20 = 0;
					goto IL_01b2;
				}
				ListInventory listInventory8 = fakeCatalog;
				int num21 = 0;
				if (!listInventory8.RemoveItem((Item)num11, 1, (ProfileEventDispatcher)num21))
				{
					CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
					Dictionary<GridObjectScript, CancellationTokenSource> dictionary = cart;
					throw new NullReferenceException();
				}
			}
			goto IL_01be;
			IL_01be:
			int num22 = 0;
			GridObject gridObject = default(GridObject);
			int itemID6 = gridObject.ItemID;
			if (gridObject != null && gridObject != null)
			{
				int num23 = 0;
			}
			return;
			IL_01b2:
			GridObject gridObject2 = default(GridObject);
			int itemID7 = gridObject2.ItemID;
			int num24 = 0;
			goto IL_01be;
		}

		[Cpp2IlInjected.Token(Token = "0x600116B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4E50", Offset = "0xCF3850", VA = "0x180CF4E50")]
		[AsyncStateMachine(typeof(_003CRemovePendingObject_003Ed__175))]
		private Task RemovePendingObject()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600116C")]
		[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1360", VA = "0x180CF2960")]
		private void OnShopItemBought(string shopName, Item item, int amount, CurrencyCost cost, bool isDelivery)
		{
			//Discarded unreachable code: IL_00e6
			//IL_0014: Expected O, but got I4
			//IL_006b: Expected O, but got I4
			//IL_0092: Expected O, but got I4
			//IL_0092: Expected O, but got I4
			int itemID = item.ItemID;
			Item item2 = (Item)itemID;
			ItemType itemType = default(ItemType);
			if (itemType != ItemType.Furniture)
			{
				return;
			}
			int num = 0;
			if (amount <= 0)
			{
				return;
			}
			Dictionary<GridObjectScript, CancellationTokenSource>.KeyCollection keys = (Dictionary<GridObjectScript, CancellationTokenSource>.KeyCollection)(object)((Dictionary<TKey, TValue>)(object)cart).get_Keys();
			Func<GridObjectScript, bool> func = default(Func<GridObjectScript, bool>);
			Func<GridObjectScript, bool> func2 = func;
			if (func2 == null)
			{
				func = (Func<GridObjectScript, bool>)(object)(Func<T, TResult>)delegate(GridObjectScript x)
				{
					int itemID2 = x.GridObject.ItemID;
					throw new NullReferenceException();
				};
			}
			GridObjectScript gridObjectScript = Enumerable.FirstOrDefault<GridObjectScript>((IEnumerable<>)(object)keys, (Func<, >)(object)func2);
			int num2 = 0;
			if (!(gridObjectScript != (UnityEngine.Object)num2))
			{
				ListInventory listInventory = fakeCatalog;
				Item item3 = item2;
				int num3 = 0;
				int num4 = 0;
				listInventory.AddItem(item3, 1, (ProfileEventDispatcher)num4, (AddDetail)num3);
			}
			CancellationTokenSource cancellationTokenSource = (CancellationTokenSource)((Dictionary<TKey, TValue>)(object)cart)[(TKey)gridObjectScript];
			cancellationTokenSource.Cancel();
			cancellationTokenSource.Dispose();
			bool flag = ((Dictionary<TKey, TValue>)(object)cart).Remove((TKey)gridObjectScript);
			NumberOfItemsInCartChangedDelegate numberOfItemsInCartChangedEvent = this.NumberOfItemsInCartChangedEvent;
			if (numberOfItemsInCartChangedEvent != null)
			{
				int count = ((Dictionary<TKey, TValue>)(object)cart).Count;
				numberOfItemsInCartChangedEvent(count);
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x600116D")]
		[Cpp2IlInjected.Address(RVA = "0xCF2900", Offset = "0xCF1300", VA = "0x180CF2900")]
		private void OnItemsSold(string shopName, Item item, int amount, CurrencyCost cost)
		{
			//Discarded unreachable code: IL_000c
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Furniture)
			{
				ListInventory listInventory = fakeCatalog;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600116E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFB40", Offset = "0xCEE540", VA = "0x180CEFB40")]
		private void GridEditModeSelectedObjectChangedEvent(GridObjectScript previous, GridObjectScript current)
		{
			//IL_013c: Expected O, but got I4
			//IL_015d: Expected O, but got I4
			//IL_01da: Expected O, but got I4
			bool flag = default(bool);
			FurnitureItemType furnitureItemType = default(FurnitureItemType);
			FurnitureItemType furnitureItemType2 = default(FurnitureItemType);
			GameObject obj = default(GameObject);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			GridObjectScript gridObjectScript3 = default(GridObjectScript);
			SendOrPostCallback @object = default(SendOrPostCallback);
			GameObject obj2 = default(GameObject);
			while (true)
			{
				int num = 0;
				if ((object)current != null)
				{
					GridObject _003CGridObject_003Ek__BackingField = current.GridObject;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						int itemID = _003CGridObject_003Ek__BackingField.ItemID;
						if (flag && (furnitureItemType == FurnitureItemType.GroundAlteration || furnitureItemType2 == FurnitureItemType.Fence))
						{
							GridObjectScript selectedGridObject = base._selectedGridObject;
							GridScript _003CGridScript_003Ek__BackingField = current.GridScript;
							GridObject _003CGridObject_003Ek__BackingField2 = selectedGridObject.GridObject;
							if (_003CGridScript_003Ek__BackingField.IsOnEditGrid(_003CGridObject_003Ek__BackingField2))
							{
								IGridMovementRestriction currentGridMovementRestriction = base._currentGridMovementRestriction;
								if (currentGridMovementRestriction != null)
								{
									int num2 = 0;
									if (currentGridMovementRestriction == null)
									{
									}
								}
								EventHandler value = FenceObjectMoveEndedEvent;
								base.SelectedObjectMoveEndedEvent -= value;
								GridObjectScript selectedGridObject2 = base._selectedGridObject;
								GridScript _003CGridScript_003Ek__BackingField2 = selectedGridObject2.GridScript;
								FenceMode fenceMode = (FenceMode)(base.CurrentMovementRestriction = new FenceMode(selectedGridObject2, _003CGridScript_003Ek__BackingField2));
								CameraNavigationConfig cameraConfig = _cameraConfig;
								FenceMode.InputActionPanModifier inputActionPanModifier = (fenceModeInputActionPanModifier = new FenceMode.InputActionPanModifier(_fenceModeCameraPanSpeed));
								InputAction inputAction = inputCameraPan;
								FenceMode.InputActionPanModifier modifier = fenceModeInputActionPanModifier;
								inputAction.AddModifier(modifier);
								EventHandler b = FenceObjectMoveEndedEvent;
								EventHandler selectedObjectMoveEndedEvent = base.SelectedObjectMoveEndedEvent;
								Delegate @delegate = Delegate.Combine(selectedObjectMoveEndedEvent, b);
								if ((object)@delegate != null && (object)@delegate == null)
								{
									break;
								}
								while ((object)@delegate != selectedObjectMoveEndedEvent)
								{
								}
								GameObject fenceModeGizmoPrefab = _fenceModeGizmoPrefab;
								int num3 = 0;
								if (!(fenceModeGizmoPrefab != (UnityEngine.Object)num3))
								{
									return;
								}
								if (num3 != 0)
								{
									int num4 = 0;
									if (num3 != 0)
									{
										UnityEngine.Object.Destroy(obj);
										base.CustomMoveHandler = (ICustomMoveHandler)num;
									}
								}
								int itemID2 = base._selectedGridObject.GridObject.ItemID;
								if (!flag2 && fenceMode.CanMove())
								{
									GridObjectScript selectedGridObject3 = base._selectedGridObject;
									GameObject fenceModeGizmoPrefab2 = _fenceModeGizmoPrefab;
									Transform parent = selectedGridObject3.transform;
									FenceModeGizmo component = UnityEngine.Object.Instantiate(fenceModeGizmoPrefab2, parent).GetComponent<FenceModeGizmo>();
									component.fenceMode = fenceMode;
									base.CustomMoveHandler = component;
								}
								return;
							}
						}
					}
				}
				if (!IsInFenceMode())
				{
					GridObjectScript gridObjectScript = previous;
					while (!flag3)
					{
					}
					int num5 = 0;
					if (!(current == (UnityEngine.Object)num5))
					{
						continue;
					}
					CommandStack commandStack = this.commandStack;
					int num6 = 0;
					Command command = commandStack.Peek();
					while (command == null)
					{
					}
					int num7 = 0;
					while (command == null)
					{
					}
					GridObjectScript gridObjectScript2 = previous;
					if (!(gridObjectScript3 == gridObjectScript2))
					{
						continue;
					}
					@object = delegate
					{
						//Discarded unreachable code: IL_002f
						//IL_0015: Expected O, but got I4
						GridObjectScript selectedGridObject4 = base._selectedGridObject;
						int num14 = 0;
						if (selectedGridObject4 == (UnityEngine.Object)num14)
						{
							GridEditMode gridEditMode = this;
							GridObjectScript gridObjectScript5 = (gridEditMode.SelectedGridObject = previous);
						}
					};
					GameObject ditherableGameObject = gridObjectScript3.GetDitherableGameObject();
				}
				int num8 = 0;
				int num9 = 0;
				int num10 = 0;
				int num11 = 0;
				EventHandler eventHandler = FenceObjectMoveEndedEvent;
				int num12 = 0;
				while (num12 == 0)
				{
				}
				int num13 = 0;
				while (num12 == 0)
				{
				}
				UnityEngine.Object.Destroy(obj2);
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600116F")]
		[Cpp2IlInjected.Address(RVA = "0xCEED90", Offset = "0xCED790", VA = "0x180CEED90")]
		private void FenceObjectMoveEndedEvent(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0063
			//IL_004a: Expected O, but got I8
			FenceCommand fenceCommand = pendingFenceCommand;
			if (fenceCommand != null && (Enumerable.Any<Command>(fenceCommand.get_ExpandAfter()) || Enumerable.Any<Command>(pendingFenceCommand.get_ExpandBefore())))
			{
				CommandStack commandStack = this.commandStack;
				FenceCommand newCommand = pendingFenceCommand;
				commandStack.DoCommand(newCommand);
				pendingFenceCommand = (FenceCommand)0;
				GridObject gridObject = (_initialSelectedGridObjectTransform = base._selectedGridObject.GridObject.Clone());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001170")]
		[Cpp2IlInjected.Address(RVA = "0xCEEEA0", Offset = "0xCED8A0", VA = "0x180CEEEA0", Slot = "31")]
		protected override IEnumerable<GridScript> FilterGrids(GridScript[] allGridScriptsWithoutFilters)
		{
			//Discarded unreachable code: IL_009e
			IEnumerable<GridScript> enumerable;
			SceneData sceneData = default(SceneData);
			bool flag = default(bool);
			do
			{
				Func<GridScript, bool> _003C_003E9__209_ = GridObjectGizmoSystem._003C_003Ec._003C_003E9__209_0;
				if (_003C_003E9__209_ == null)
				{
					GridObjectGizmoSystem._003C_003Ec._003C_003E9 = (GridObjectGizmoSystem._003C_003Ec)(object)(Func<T, TResult>)((GridScript x) => !x.Locked);
				}
				enumerable = (IEnumerable<GridScript>)Enumerable.Where<GridScript>((IEnumerable<>)(object)allGridScriptsWithoutFilters, (Func<, >)(object)_003C_003E9__209_);
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			}
			while (!flag);
			int num = 0;
			SceneData sceneData2 = default(SceneData);
			AsyncOperation operation2 = sceneData2.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig2 = sceneData2.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			Transform waterSurface = gameObject.GetComponent<Mdl.Environments.Environment>().WaterSurface;
			GridScript gridScript = default(GridScript);
			GridScript currentGrid = gridScript;
			Func<GridScript, bool> func = (Func<GridScript, bool>)(object)(Func<T, TResult>)delegate(GridScript x)
			{
				GridScript gridScript2 = currentGrid;
				return x == gridScript2;
			};
			return (IEnumerable<GridScript>)Enumerable.Where<GridScript>((IEnumerable<>)enumerable, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x6001171")]
		[Cpp2IlInjected.Address(RVA = "0xCEF2C0", Offset = "0xCEDCC0", VA = "0x180CEF2C0", Slot = "32")]
		protected override Boundaries[] GetCameraBoundaries(GameObject sceneRoot, GridScript[] allGridScripts)
		{
			//IL_0035: Expected O, but got I4
			bool flag = default(bool);
			SceneData sceneData = default(SceneData);
			GameObject gameObject = default(GameObject);
			GridScript gridScript = default(GridScript);
			Func<GridScript, IEnumerable<Boundaries>> func = default(Func<GridScript, IEnumerable<Boundaries>>);
			Boundaries[] array;
			Boundaries componentInChildren;
			do
			{
				IL_0000:
				int num = 0;
				if (flag)
				{
					AsyncOperation operation = sceneData.sceneInstance.m_Operation;
					CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
					Transform waterSurface = gameObject.GetComponent<Mdl.Environments.Environment>().WaterSurface;
					int num2 = 0;
					if (gridScript != (UnityEngine.Object)num2)
					{
						Boundaries[] components = gridScript.GetComponents<Boundaries>();
						if (components.Length != 0)
						{
							return components;
						}
					}
				}
				else
				{
					if (_003C_003Ec._003C_003E9__181_0 == null)
					{
						func = (Func<GridScript, IEnumerable<Boundaries>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GridScript x)
						{
							Boundaries[] components2 = x.GetComponents<Boundaries>();
							throw new NullReferenceException();
						});
					}
					if (Enumerable.SelectMany<GridScript, Boundaries>((IEnumerable<>)(object)allGridScripts, (Func<, >)(object)func).ToArray<Boundaries>().Length != 0)
					{
						goto IL_0000;
					}
				}
				array = new Boundaries[1];
				componentInChildren = sceneRoot.GetComponentInChildren<Boundaries>();
			}
			while ((object)componentInChildren != null && (object)componentInChildren == null);
			array[0] = componentInChildren;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001172")]
		[Cpp2IlInjected.Address(RVA = "0xCF6130", Offset = "0xCF4B30", VA = "0x180CF6130")]
		private void UpdateEditTargetPosition()
		{
			//Discarded unreachable code: IL_002b
			Transform transform = editTarget.transform;
			Camera camera = playerCamera;
			FreeCameraControl freeCameraControl = cameraNav;
			Transform transform2 = camera.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
		}

		[Cpp2IlInjected.Token(Token = "0x6001173")]
		[Cpp2IlInjected.Address(RVA = "0xCF5670", Offset = "0xCF4070", VA = "0x180CF5670")]
		private void SetCullingReferenceTransform(Transform referenceTransform)
		{
			//Discarded unreachable code: IL_002a
			CullingGroupStreamingManager[] components = GridObjectStreamingManager._instance.GetComponents<CullingGroupStreamingManager>();
			int num = 0;
			int length = components.Length;
			if (num < length)
			{
				components[num].SetDistanceReferencePoint(referenceTransform);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001174")]
		[Cpp2IlInjected.Address(RVA = "0xCF5630", Offset = "0xCF4030", VA = "0x180CF5630")]
		protected void SetCullingReferenceTransformToEditTarget()
		{
			//Discarded unreachable code: IL_0014
			Transform cullingReferenceTransform = editTarget.transform;
			SetCullingReferenceTransform(cullingReferenceTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6001175")]
		[Cpp2IlInjected.Address(RVA = "0xCF5600", Offset = "0xCF4000", VA = "0x180CF5600")]
		protected void ResetCullingReferenceTransform()
		{
			//Discarded unreachable code: IL_0014
			Transform _003Ctransform_003Ek__BackingField = avatar.transform;
			SetCullingReferenceTransform(_003Ctransform_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x6001176")]
		[Cpp2IlInjected.Address(RVA = "0xCF77D0", Offset = "0xCF61D0", VA = "0x180CF77D0")]
		public unsafe GridEditMode()
		{
			//IL_0019: Expected F4, but got I8
			//IL_0014: Expected native int or pointer, but got O
			//IL_004a: Expected F4, but got I4
			int num = 0;
			_houseUnlockDefaultZoom = 1f;
			ulong num2 = default(ulong);
			((Vector3*)(IntPtr)_decorChallengeWantedViewportPoint)->z = (long)num2;
			_fenceModeCameraPanSpeed = 4f;
			_removeWholeFencePressDelay = 1f;
			_undoAllPressDelay = 1f;
			_selectWallpaperFlashCurve = AnimationCurve.Constant(num, 1f, 0.25f);
			cart = (Dictionary<GridObjectScript, CancellationTokenSource>)(object)new Dictionary<TKey, TValue>();
			variationsPerItem = (Dictionary<Item, Item[]>)(object)new Dictionary<TKey, TValue>();
			base._002Ector();
		}
	}
}
