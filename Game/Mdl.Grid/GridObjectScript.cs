using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Systems;
using Meta.Grids;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200046F")]
	[ExecuteInEditMode]
	public class GridObjectScript : MonoBehaviour, IPlayerTaskData, IDitherable
	{
		[Cpp2IlInjected.Token(Token = "0x2000470")]
		public delegate void GridEditModeChangedDelegate(GridObjectScript sender, bool editModeResynchronize);

		[Cpp2IlInjected.Token(Token = "0x2000471")]
		public delegate void AnyTransformUpdateDelegate(GridObjectScript gridObjectScript, Vector3 previousPosition, Vector3 currentPosition, bool rotated);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001C3D")]
		public GameObject SpawnVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001C3E")]
		public AssetReferenceGameObject DespawnVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001C3F")]
		public AK.Wwise.Event SpawnSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001C40")]
		public AK.Wwise.Event DespawnSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001C41")]
		[FormerlySerializedAs("DespawnVFXDelayBeforeDestroy")]
		public float DelayBeforeDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001C42")]
		public bool DisableBoingSpawnEffect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4001C43")]
		public bool DisableAutoObjectDither;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E")]
		[Cpp2IlInjected.Token(Token = "0x4001C44")]
		public bool ForceAutoObjectDither;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F")]
		[Cpp2IlInjected.Token(Token = "0x4001C45")]
		public bool DisableAutoCameraCollision;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001C48")]
		private GameObject _gameObject;

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public GridObject GridObject
		{
			[Cpp2IlInjected.Token(Token = "0x6001362")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CGridObject_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001363")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CGridObject_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public GridScript GridScript
		{
			[Cpp2IlInjected.Token(Token = "0x6001364")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CGridScript_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001365")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CGridScript_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public new GameObject gameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6001366")]
			[Cpp2IlInjected.Address(RVA = "0x15384B0", Offset = "0x1536EB0", VA = "0x1815384B0")]
			get
			{
				//IL_0010: Expected O, but got I4
				GameObject gameObject = _gameObject;
				int num = 0;
				if (gameObject == (UnityEngine.Object)num)
				{
					GameObject gameObject2 = (_gameObject = base.gameObject);
				}
				return _gameObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		private CameraCollisionSystem CameraCollision
		{
			[Cpp2IlInjected.Token(Token = "0x6001376")]
			[Cpp2IlInjected.Address(RVA = "0x15383F0", Offset = "0x1536DF0", VA = "0x1815383F0")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<CameraCollisionSystem>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event GridEditModeChangedDelegate GridObjectChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6001367")]
			[Cpp2IlInjected.Address(RVA = "0x15381F0", Offset = "0x1536BF0", VA = "0x1815381F0")]
			[CompilerGenerated]
			add
			{
				GridEditModeChangedDelegate gridObjectChangedEvent = this.GridObjectChangedEvent;
				Delegate @delegate = Delegate.Combine(gridObjectChangedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != gridObjectChangedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001368")]
			[Cpp2IlInjected.Address(RVA = "0x15385E0", Offset = "0x1536FE0", VA = "0x1815385E0")]
			[CompilerGenerated]
			remove
			{
				GridEditModeChangedDelegate gridObjectChangedEvent = this.GridObjectChangedEvent;
				Delegate @delegate = Delegate.Remove(gridObjectChangedEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != gridObjectChangedEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002E")]
		public event EventHandler OnTransformUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6001369")]
			[Cpp2IlInjected.Address(RVA = "0x1538350", Offset = "0x1536D50", VA = "0x181538350")]
			[CompilerGenerated]
			add
			{
				EventHandler onTransformUpdate = this.OnTransformUpdate;
				Delegate @delegate = Delegate.Combine(onTransformUpdate, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTransformUpdate)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600136A")]
			[Cpp2IlInjected.Address(RVA = "0x1538740", Offset = "0x1537140", VA = "0x181538740")]
			[CompilerGenerated]
			remove
			{
				EventHandler onTransformUpdate = this.OnTransformUpdate;
				Delegate @delegate = Delegate.Remove(onTransformUpdate, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onTransformUpdate)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002F")]
		public static event AnyTransformUpdateDelegate OnAnyTransformUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600136B")]
			[Cpp2IlInjected.Address(RVA = "0x1538290", Offset = "0x1536C90", VA = "0x181538290")]
			[CompilerGenerated]
			add
			{
				AnyTransformUpdateDelegate onAnyTransformUpdate = GridObjectScript.OnAnyTransformUpdate;
				Delegate @delegate = Delegate.Combine(onAnyTransformUpdate, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(GridObjectScript).TypeHandle != onAnyTransformUpdate)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600136C")]
			[Cpp2IlInjected.Address(RVA = "0x1538680", Offset = "0x1537080", VA = "0x181538680")]
			[CompilerGenerated]
			remove
			{
				AnyTransformUpdateDelegate onAnyTransformUpdate = GridObjectScript.OnAnyTransformUpdate;
				Delegate @delegate = Delegate.Remove(onAnyTransformUpdate, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(GridObjectScript).TypeHandle != onAnyTransformUpdate)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000030")]
		public event EventHandler DitherableDestroyEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600136D")]
			[Cpp2IlInjected.Address(RVA = "0x1538150", Offset = "0x1536B50", VA = "0x181538150", Slot = "6")]
			[CompilerGenerated]
			add
			{
				EventHandler ditherableDestroyEvent = this.DitherableDestroyEvent;
				Delegate @delegate = Delegate.Combine(ditherableDestroyEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != ditherableDestroyEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600136E")]
			[Cpp2IlInjected.Address(RVA = "0x1538540", Offset = "0x1536F40", VA = "0x181538540", Slot = "7")]
			[CompilerGenerated]
			remove
			{
				EventHandler ditherableDestroyEvent = this.DitherableDestroyEvent;
				Delegate @delegate = Delegate.Remove(ditherableDestroyEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != ditherableDestroyEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600136F")]
		[Cpp2IlInjected.Address(RVA = "0x1537270", Offset = "0x1535C70", VA = "0x181537270")]
		internal void Init(GridScript gridScript, GridObject gridObject, bool editModeResynchronize = false)
		{
			//Discarded unreachable code: IL_00eb
			//IL_0026: Expected O, but got I4
			if (GridScript != gridScript)
			{
				GridScript = gridScript;
				GridScript gridScript2 = GridScript;
				int num = 0;
				if (!(gridScript2 != (UnityEngine.Object)num))
				{
					Transform transform = base.transform;
					int handle = this.gameObject.scene.m_Handle;
					GameObject gameObject = default(GameObject);
					Transform transform2 = gameObject.transform;
				}
				Transform transform3 = base.transform;
				Transform transform5 = (transform3.parent = GridScript.transform);
			}
			GridObject = gridObject;
			if ((long)GridObject != 0)
			{
				UpdateTransform();
			}
			this.GridObjectChangedEvent?.Invoke(this, editModeResynchronize);
			int num2 = 0;
			if (Application.isPlaying && !DisableAutoCameraCollision)
			{
				ItemScript component = GetComponent<ItemScript>();
				Item item = component.Item;
				CameraCollisionSystem cameraCollision = CameraCollision;
				Item item2 = component.Item;
				bool flag = default(bool);
				if (flag)
				{
					CameraCollisionSystem cameraCollision2 = CameraCollision;
					GameObject gameObject2 = this.gameObject;
					cameraCollision2.AddAutoCameraCollisionTo(gameObject2);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001370")]
		[Cpp2IlInjected.Address(RVA = "0x1537830", Offset = "0x1536230", VA = "0x181537830")]
		private void OnDestroy()
		{
			if (this.DitherableDestroyEvent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001371")]
		[Cpp2IlInjected.Address(RVA = "0x15370C0", Offset = "0x1535AC0", VA = "0x1815370C0")]
		public unsafe bool ChangeTransform([Optional] GridPosition? gridPositionOverride, [Optional] GridOrientation? gridOrientationOverride)
		{
			//Discarded unreachable code: IL_0076
			bool has_value = ((Nullable<>*)(&gridPositionOverride))->has_value;
			GridScript gridScript = GridScript;
			GridObject gridObject = GridObject;
			if (has_value)
			{
			}
			GridPosition position = gridObject.Position;
			if ((object)gridOrientationOverride == null)
			{
				GridOrientation orientation_ = GridObject.orientation_;
			}
			Meta.Grids.Grid _003CEditGrid_003Ek__BackingField = gridScript.EditGrid;
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				int num2 = 0;
				if (!Application.isPlaying && gridScript.EditorGridChangedEvent == null)
				{
				}
			}
			if (!flag)
			{
				int num3 = 0;
				if (Application.isPlaying)
				{
					goto IL_006f;
				}
			}
			UpdateTransform();
			goto IL_006f;
			IL_006f:
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6001372")]
		[Cpp2IlInjected.Address(RVA = "0x1537BD0", Offset = "0x15365D0", VA = "0x181537BD0")]
		public void UpdateTransform()
		{
			//Discarded unreachable code: IL_00df
			//IL_00de: Expected O, but got I4
			//IL_00de: Expected O, but got I4
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			GridObject gridObject = GridObject;
			GridScript gridScript = GridScript;
			GridPosition position = gridObject.Position;
			GridOrientation orientation_ = GridObject.orientation_;
			GridArea gridArea = gridObject.GetGridArea();
			Transform transform4 = base.transform;
			GridObject gridObject2 = GridObject;
			GridScript gridScript2 = GridScript;
			Transform transform5 = base.transform;
			int num = ((transform5.hasChanged = false) ? 1 : 0);
			Transform transform6 = base.transform;
			bool flag2 = default(bool);
			if (!flag2)
			{
				Transform transform7 = base.transform;
				bool flag3 = default(bool);
				if (!flag3)
				{
					return;
				}
			}
			int num2 = default(int);
			if (this.OnTransformUpdate != null)
			{
				num2 = 0;
			}
			AnyTransformUpdateDelegate onAnyTransformUpdate = GridObjectScript.OnAnyTransformUpdate;
			if (onAnyTransformUpdate != null)
			{
				Transform transform8 = base.transform;
				int num3 = 0;
				GridOrientation orientation_2 = GridObject.orientation_;
				if (orientation_2 == GridOrientation.Left)
				{
				}
				bool rotated = orientation_2 == GridOrientation.Right;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				onAnyTransformUpdate(this, (Vector3)num3, (Vector3)num2, rotated);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001373")]
		[Cpp2IlInjected.Address(RVA = "0x15378B0", Offset = "0x15362B0", VA = "0x1815378B0")]
		public void Rotate(bool clockwise)
		{
			//Discarded unreachable code: IL_006e
			int num = (int)GridObject.orientation_.Rotate(clockwise);
			GridObject gridObject = GridObject;
			GridScript gridScript = GridScript;
			GridPosition position = gridObject.Position;
			ulong num2 = default(ulong);
			if (num2 == 0)
			{
				GridObject gridObject2 = GridObject;
			}
			Meta.Grids.Grid _003CEditGrid_003Ek__BackingField = gridScript.EditGrid;
			bool flag = default(bool);
			if (flag)
			{
				int num3 = 0;
				if (!Application.isPlaying && gridScript.EditorGridChangedEvent == null)
				{
				}
			}
			if (!flag)
			{
				int num4 = 0;
				if (Application.isPlaying)
				{
					return;
				}
			}
			UpdateTransform();
		}

		[Cpp2IlInjected.Token(Token = "0x6001374")]
		[Cpp2IlInjected.Address(RVA = "0x1537F60", Offset = "0x1536960", VA = "0x181537F60")]
		public static GridOrientation? WallObjectGetCorrectOrientation(GridScript gridScript, GridPosition newGridPosition, GridOrientation currentOrientation, GridArea gridArea)
		{
			//IL_000b: Expected O, but got I4
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected I4, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected I4, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected I4, but got Unknown
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected I4, but got Unknown
			int num = 0;
			if (!(gridScript == (UnityEngine.Object)num))
			{
				if (currentOrientation != 0)
				{
					if (currentOrientation != 0)
					{
						if (currentOrientation != 0)
						{
							if (currentOrientation != GridOrientation.Right)
							{
								goto IL_004d;
							}
							if ((object)newGridPosition != null)
							{
								goto IL_0051;
							}
						}
						if ((object)newGridPosition != null)
						{
							goto IL_004d;
						}
					}
					int sizeX_ = gridScript.GridData.sizeX_;
					sizeX_ -= gridScript;
				}
				int sizeY_ = gridScript.GridData.sizeY_;
				sizeY_ -= gridScript;
				while ((IntPtr)newGridPosition == (IntPtr)sizeY_)
				{
				}
				goto IL_004d;
			}
			goto IL_0085;
			IL_004d:
			if ((object)newGridPosition != null)
			{
				goto IL_0051;
			}
			goto IL_0085;
			IL_0085:
			int num2 = 0;
			throw new NullReferenceException();
			IL_0051:
			int sizeX_2 = gridScript.GridData.sizeX_;
			sizeX_2 -= gridScript;
			if ((IntPtr)newGridPosition != (IntPtr)sizeX_2 && (object)newGridPosition != null)
			{
				int sizeY_2 = gridScript.GridData.sizeY_;
				sizeY_2 -= gridScript;
				if ((IntPtr)newGridPosition == (IntPtr)sizeY_2)
				{
				}
			}
			goto IL_0085;
		}

		[Cpp2IlInjected.Token(Token = "0x6001375")]
		[Cpp2IlInjected.Address(RVA = "0x15374D0", Offset = "0x1535ED0", VA = "0x1815374D0")]
		public unsafe bool Intersects(in GridPosition position, GridOrientation orientation, in GridArea area)
		{
			GridObject gridObject = GridObject;
			int num = 0;
			GridPosition position2 = GridObject.Position;
			GridPosition position3 = GridObject.Position;
			GridOrientation orientation_ = GridObject.orientation_;
			GridOrientation orientation_2 = GridObject.orientation_;
			bool flag = default(bool);
			if (flag)
			{
				GridPosition localGridPosition = GridObject.GetLocalGridPosition(in position);
				int num2 = 0;
				int num3 = default(int);
				if (num3 > 0)
				{
					int num4 = 0;
					int num5 = default(int);
					if (num5 > 0)
					{
						GridPosition gridPosition = position + *(GridPosition*)num2;
						GridObject gridObject2 = GridObject;
						GridPosition localGridPosition2 = gridObject2.GetLocalGridPosition(in *(GridPosition*)num2);
						if (localGridPosition < gridObject2)
						{
							GridLayers gridLayers = default(GridLayers);
							int num6 = (int)gridLayers;
							GridLayers gridLayers2 = area[num2, num4];
							bool flag2 = default(bool);
							if (flag2)
							{
								goto IL_00a6;
							}
						}
						num4++;
					}
					num2++;
				}
			}
			int num7 = 0;
			goto IL_00a6;
			IL_00a6:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001377")]
		[Cpp2IlInjected.Address(RVA = "0x1537B30", Offset = "0x1536530", VA = "0x181537B30", Slot = "4")]
		public bool ShouldDither()
		{
			if (!DisableAutoObjectDither)
			{
				if (!ForceAutoObjectDither)
				{
					ItemScript component = GetComponent<ItemScript>();
					Item item = component.Item;
					CameraCollisionSystem cameraCollision = CameraCollision;
					Item item2 = component.Item;
					bool result = default(bool);
					return result;
				}
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001378")]
		[Cpp2IlInjected.Address(RVA = "0x1537260", Offset = "0x1535C60", VA = "0x181537260", Slot = "5")]
		public GameObject GetDitherableGameObject()
		{
			return gameObject;
		}

		[Cpp2IlInjected.Token(Token = "0x6001379")]
		[Cpp2IlInjected.Address(RVA = "0x1537A90", Offset = "0x1536490", VA = "0x181537A90")]
		private bool ShouldAddCameraCollisionComponents()
		{
			int num = 0;
			if (Application.isPlaying && !DisableAutoCameraCollision)
			{
				ItemScript component = GetComponent<ItemScript>();
				Item item = component.Item;
				CameraCollisionSystem cameraCollision = CameraCollision;
				Item item2 = component.Item;
				bool result = default(bool);
				return result;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600137A")]
		[Cpp2IlInjected.Address(RVA = "0x1537070", Offset = "0x1535A70", VA = "0x181537070")]
		private void AddCameraCollisionComponents()
		{
			//Discarded unreachable code: IL_0016
			CameraCollisionSystem cameraCollision = CameraCollision;
			GameObject gameObject = this.gameObject;
			cameraCollision.AddAutoCameraCollisionTo(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600137B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public GridObjectScript()
		{
		}
	}
}
