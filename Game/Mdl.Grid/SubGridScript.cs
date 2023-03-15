using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Environments;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200048F")]
	public class SubGridScript : GridScript
	{
		[Cpp2IlInjected.Token(Token = "0x17000289")]
		public GridObjectScript GridObjectScript
		{
			[Cpp2IlInjected.Token(Token = "0x6001445")]
			[Cpp2IlInjected.Address(RVA = "0x7AD7F0", Offset = "0x7AC1F0", VA = "0x1807AD7F0")]
			[CompilerGenerated]
			get
			{
				return _003CGridObjectScript_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001446")]
			[Cpp2IlInjected.Address(RVA = "0x824230", Offset = "0x822C30", VA = "0x180824230")]
			[CompilerGenerated]
			private set
			{
				_003CGridObjectScript_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028A")]
		public override bool Locked
		{
			[Cpp2IlInjected.Token(Token = "0x6001447")]
			[Cpp2IlInjected.Address(RVA = "0x1065BE0", Offset = "0x10645E0", VA = "0x181065BE0", Slot = "4")]
			get
			{
				GridObjectScript gridObjectScript = GridObjectScript;
				if ((object)gridObjectScript != null)
				{
					GridScript _003CGridScript_003Ek__BackingField = gridObjectScript.GridScript;
					if ((object)_003CGridScript_003Ek__BackingField != null)
					{
						bool locked = _003CGridScript_003Ek__BackingField.Locked;
						int num = 0;
					}
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001448")]
		[Cpp2IlInjected.Address(RVA = "0x1065940", Offset = "0x1064340", VA = "0x181065940", Slot = "5")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_00ba
			base.Start();
			int num = 0;
			if (!Application.isPlaying)
			{
				return;
			}
			GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
			string gridDataPath = GridDataPath;
			Meta.Grids.Grid newEditGrid = system.GetNewEditGrid(gridDataPath);
			StartEditMode(newEditGrid);
			GridObjectScript gridObjectScript = (GridObjectScript = GetComponent<GridObjectScript>());
			GridObjectScript gridObjectScript2 = GridObjectScript;
			GridObjectScript.GridEditModeChangedDelegate value = GridObjectChangedEvent;
			gridObjectScript2.GridObjectChangedEvent += value;
			GridObject _003CGridObject_003Ek__BackingField = GridObjectScript.GridObject;
			if (_003CGridObject_003Ek__BackingField != null)
			{
				GridState state_ = _003CGridObject_003Ek__BackingField.state_;
				if (state_ != null && state_.SubGrid != null)
				{
					uint gridID_ = GridObjectScript.GridObject.state_.SubGrid.gridID_;
					Init(gridID_, loadObjects: true);
				}
				system.AddNewSubGrid(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001449")]
		[Cpp2IlInjected.Address(RVA = "0x10656E0", Offset = "0x10640E0", VA = "0x1810656E0", Slot = "6")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_0067
			//IL_001f: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			base.OnDestroy();
			int num = 0;
			if (Application.isPlaying)
			{
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				int num2 = 0;
				if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num2)
				{
					SystemRoot.Instance.GetSystem<GridEditMode>().RemoveSubGrid(this);
				}
				GridObjectScript gridObjectScript = GridObjectScript;
				int num3 = 0;
				if (gridObjectScript != (UnityEngine.Object)num3)
				{
					GridObjectScript gridObjectScript2 = GridObjectScript;
					GridObjectScript.GridEditModeChangedDelegate value = GridObjectChangedEvent;
					gridObjectScript2.GridObjectChangedEvent -= value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600144A")]
		[Cpp2IlInjected.Address(RVA = "0x10654F0", Offset = "0x1063EF0", VA = "0x1810654F0")]
		private void Init(uint gridID, bool loadObjects)
		{
			//Discarded unreachable code: IL_0042
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			SceneItemData sceneItemData = sceneData.sceneItemData;
			GameObject gameObject = default(GameObject);
			GridCollection _003CGridCollection_003Ek__BackingField = gameObject.GetComponent<Mdl.Environments.Environment>().GridCollection;
			bool flag = default(bool);
			if (flag)
			{
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600144B")]
		[Cpp2IlInjected.Address(RVA = "0x1065180", Offset = "0x1063B80", VA = "0x181065180")]
		private void GridObjectChangedEvent(GridObjectScript sender, bool editModeResynchronize)
		{
			//Discarded unreachable code: IL_00e5
			GridObject _003CGridObject_003Ek__BackingField = sender.GridObject;
			if (_003CGridObject_003Ek__BackingField != null)
			{
				GridState state_ = _003CGridObject_003Ek__BackingField.state_;
				if (state_ != null)
				{
					SubGrid subGrid = state_.SubGrid;
					if (subGrid != null)
					{
						if (base.Grid != null)
						{
							int num = 0;
							uint num2 = default(uint);
							if (num < (int)num2)
							{
								num += num;
								num++;
							}
							SubGrid subGrid2 = sender.GridObject.state_.SubGrid;
							if ((IntPtr)subGrid == (IntPtr)(int)subGrid2.gridID_)
							{
								goto IL_0090;
							}
						}
						uint gridID_ = sender.GridObject.state_.SubGrid.gridID_;
						bool loadObjects = !SystemRoot.Instance.GetSystem<GridEditMode>().IsQuitting;
						Init(gridID_, loadObjects);
					}
				}
			}
			goto IL_0090;
			IL_0090:
			if ((long)sender.GridObject != 0)
			{
				SystemRoot.Instance.GetSystem<GridEditMode>().AddNewSubGrid(this);
				GridObject _003CGridObject_003Ek__BackingField2 = sender.GridObject;
				GridState gridState = new GridState();
				SubGrid subGrid3 = new SubGrid();
				uint num3 = (subGrid3.gridID_ = base.GridID);
				gridState.SubGrid = subGrid3;
				_003CGridObject_003Ek__BackingField2.state_ = gridState;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600144C")]
		[Cpp2IlInjected.Address(RVA = "0x1064D40", Offset = "0x1063740", VA = "0x181064D40")]
		public GridPosition GetMainGridSpacePosition(GridObject gridObject)
		{
			//Discarded unreachable code: IL_00b2
			int num = 0;
			GridOrientation orientation_ = gridObject.orientation_;
			GridOrientation orientation_2 = gridObject.orientation_;
			GridObject _003CGridObject_003Ek__BackingField = GridObjectScript.GridObject;
			GridOrientation orientation_3 = _003CGridObject_003Ek__BackingField.orientation_;
			if (orientation_3 != 0)
			{
				if (orientation_3 != 0)
				{
					if (orientation_3 != 0 && orientation_3 == GridOrientation.Right)
					{
						GridPosition position = _003CGridObject_003Ek__BackingField.Position;
						GridData gridData = base.GridData;
						GridPosition position2 = gridObject.Position;
						GridPosition position3 = gridObject.Position;
					}
					GridPosition position4 = _003CGridObject_003Ek__BackingField.Position;
					GridPosition position5 = gridObject.Position;
				}
				GridPosition position6 = _003CGridObject_003Ek__BackingField.Position;
				GridData gridData2 = base.GridData;
				GridPosition position7 = gridObject.Position;
				GridPosition position8 = gridObject.Position;
			}
			GridPosition position9 = _003CGridObject_003Ek__BackingField.Position;
			GridData gridData3 = base.GridData;
			GridData gridData4 = base.GridData;
			GridPosition position10 = gridObject.Position;
			GridPosition result = default(GridPosition);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600144D")]
		[Cpp2IlInjected.Address(RVA = "0x10649A0", Offset = "0x10633A0", VA = "0x1810649A0")]
		public GridPosition GetLocalGridSpacePosition(GridPosition mainGridPosition)
		{
			GridObjectScript gridObjectScript = GridObjectScript;
			int num = 0;
			GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
			GridOrientation orientation_ = _003CGridObject_003Ek__BackingField.orientation_;
			if (orientation_ != 0)
			{
				if (orientation_ != 0)
				{
					if (orientation_ != 0 && orientation_ == GridOrientation.Right)
					{
						GridPosition position = _003CGridObject_003Ek__BackingField.Position;
						GridData gridData = base.GridData;
					}
					GridPosition position2 = _003CGridObject_003Ek__BackingField.Position;
				}
				GridPosition position3 = _003CGridObject_003Ek__BackingField.Position;
				GridData gridData2 = base.GridData;
			}
			GridPosition position4 = _003CGridObject_003Ek__BackingField.Position;
			int sizeX_ = base.GridData.sizeX_;
			GridData gridData3 = base.GridData;
			int sizeX_2 = base.GridData.sizeX_;
			int min = 0;
			sizeX_ = Mathf.Clamp(sizeX_, min, sizeX_2);
			GridData gridData4 = base.GridData;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600144E")]
		[Cpp2IlInjected.Address(RVA = "0x1064530", Offset = "0x1062F30", VA = "0x181064530")]
		public GridPosition GetLocalGridSpacePosition(GridPosition mainGridPosition, GridOrientation gridOrientation, GridArea gridArea)
		{
			int num = (int)gridOrientation;
			int num2 = 0;
			GridObjectScript gridObjectScript = GridObjectScript;
			int num3 = default(int);
			num = num3;
			GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
			GridOrientation orientation_ = _003CGridObject_003Ek__BackingField.orientation_;
			if (orientation_ != 0)
			{
				if (orientation_ != 0)
				{
					if (orientation_ != 0 && orientation_ == GridOrientation.Right)
					{
						GridPosition position = GridObjectScript.GridObject.Position;
						GridData gridData = base.GridData;
					}
					GridPosition position2 = _003CGridObject_003Ek__BackingField.Position;
				}
				GridPosition position3 = GridObjectScript.GridObject.Position;
				GridData gridData2 = base.GridData;
			}
			GridPosition position4 = GridObjectScript.GridObject.Position;
			int sizeX_ = base.GridData.sizeX_;
			GridData gridData3 = base.GridData;
			int sizeX_2 = base.GridData.sizeX_;
			int num4 = default(int);
			sizeX_2 -= num4;
			int min = 0;
			sizeX_ = Mathf.Clamp(sizeX_, min, sizeX_2);
			int sizeY_ = base.GridData.sizeY_;
			sizeY_ -= num;
			int num5 = default(int);
			sizeY_ = num5;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600144F")]
		[Cpp2IlInjected.Address(RVA = "0x1064D00", Offset = "0x1063700", VA = "0x181064D00")]
		public GridOrientation GetMainGridSpaceOrientation(GridOrientation orientation)
		{
			//Discarded unreachable code: IL_0012
			GridObjectScript gridObjectScript = GridObjectScript;
			GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
			GridOrientation result = default(GridOrientation);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001450")]
		[Cpp2IlInjected.Address(RVA = "0x10644F0", Offset = "0x1062EF0", VA = "0x1810644F0")]
		public GridOrientation GetLocalGridSpaceOrientation(GridOrientation orientation)
		{
			//Discarded unreachable code: IL_0012
			GridObjectScript gridObjectScript = GridObjectScript;
			GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
			GridOrientation result = default(GridOrientation);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001451")]
		[Cpp2IlInjected.Address(RVA = "0x1065B80", Offset = "0x1064580", VA = "0x181065B80")]
		public SubGridScript()
		{
		}
	}
}
