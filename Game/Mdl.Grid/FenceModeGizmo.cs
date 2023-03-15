using System;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Grid;
using Mdl.Ui;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000403")]
	internal class FenceModeGizmo : MonoBehaviour, ICustomMoveHandler
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000404")]
		private struct Direction
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40019F6")]
			public GridOrientation direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40019F7")]
			public Collider collider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40019F8")]
			private SpriteRenderer renderer;

			[Cpp2IlInjected.Token(Token = "0x6001106")]
			[Cpp2IlInjected.Address(RVA = "0x11D92F0", Offset = "0x11D7CF0", VA = "0x1811D92F0")]
			public void SetSprite(Sprite sprite)
			{
				//Discarded unreachable code: IL_0033
				//IL_0010: Expected O, but got I4
				SpriteRenderer spriteRenderer = renderer;
				int num = 0;
				if (spriteRenderer == (UnityEngine.Object)num)
				{
					SpriteRenderer spriteRenderer2 = (renderer = collider.GetComponentInChildren<SpriteRenderer>());
				}
				renderer.sprite = sprite;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40019F0")]
		[SerializeField]
		private Direction[] directions = new Direction[4];

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40019F1")]
		[SerializeField]
		private Sprite normalSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40019F2")]
		[SerializeField]
		private Sprite hoverSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40019F3")]
		[SerializeField]
		private GameObject infoGizmoPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40019F4")]
		private GridEditMode.FenceMode fenceMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40019F5")]
		private bool moveInProgress;

		[Cpp2IlInjected.Token(Token = "0x60010FE")]
		[Cpp2IlInjected.Address(RVA = "0x136E040", Offset = "0x136CA40", VA = "0x18136E040")]
		private void Start()
		{
			//Discarded unreachable code: IL_0031
			//IL_0010: Expected O, but got I4
			GameObject gameObject = infoGizmoPrefab;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				CancellationTokenProvider orAddComponent = this.GetOrAddComponent<CancellationTokenProvider>();
				BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
				GameObject gameObject2 = base.gameObject;
				CancellationToken cancellationToken = orAddComponent.CancellationToken;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010FF")]
		[Cpp2IlInjected.Address(RVA = "0x136DB80", Offset = "0x136C580", VA = "0x18136DB80")]
		private void LateUpdate()
		{
			//Discarded unreachable code: IL_0030
			if (!moveInProgress)
			{
				int num = 0;
				int length = directions.Length;
				if (num < length)
				{
					GridEditMode.FenceMode fenceMode = this.fenceMode;
					GameObject gameObject = default(GameObject);
					bool active = default(bool);
					gameObject.SetActive(active);
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001100")]
		[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
		public void Init(GridEditMode.FenceMode fenceMode)
		{
			this.fenceMode = fenceMode;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001101")]
		[Cpp2IlInjected.Address(RVA = "0x136D950", Offset = "0x136C350", VA = "0x18136D950", Slot = "4")]
		public GameObject CheckHover(Vector2 screenPosition)
		{
			int num = 0;
			int num2 = 0;
			if ((moveInProgress ? 1 : 0) == num2)
			{
				int num3 = 0;
				Camera main = Camera.main;
				int length = directions.Length;
				if (num < length)
				{
					bool flag = default(bool);
					if (!flag)
					{
						Sprite sprite = normalSprite;
						num++;
					}
					Sprite sprite2 = hoverSprite;
					num++;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001102")]
		[Cpp2IlInjected.Address(RVA = "0x136DC50", Offset = "0x136C650", VA = "0x18136DC50", Slot = "5")]
		public bool ShouldBeginMove(Vector2 _screenPosition)
		{
			//IL_0061: Expected O, but got I4
			//IL_00aa: Expected I4, but got I8
			//IL_00cc: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Camera main = Camera.main;
			int num5 = 0;
			int length = directions.Length;
			if (num2 < length)
			{
				bool flag = default(bool);
				if (!flag)
				{
					num2++;
				}
				Direction direction = default(Direction);
				if ((object)direction != null)
				{
					if ((object)direction != null)
					{
						if ((object)direction == null)
						{
							goto IL_004e;
						}
						if ((long)direction != 1)
						{
							goto IL_0061;
						}
					}
					GridEditMode.FenceMode fenceMode = this.fenceMode;
				}
				goto IL_004e;
			}
			goto IL_00e8;
			IL_004e:
			GridEditMode.FenceMode fenceMode2 = this.fenceMode;
			int num6 = 0;
			fenceMode2.HorizontalMove = (bool?)(object)num2;
			goto IL_0061;
			IL_00e8:
			int num7 = 0;
			goto IL_00eb;
			IL_0061:
			Direction[] array = directions;
			moveInProgress = true;
			int length2 = array.Length;
			ulong num8 = default(ulong);
			if (num2 < length2)
			{
				Direction direction2 = default(Direction);
				if ((object)direction2 != null)
				{
					if ((object)direction2 != null)
					{
						if ((object)direction2 == null)
						{
							goto IL_00b6;
						}
						if ((long)direction2 != 1)
						{
							goto IL_00e4;
						}
					}
					GridEditMode.FenceMode fenceMode3 = this.fenceMode;
					bool flag2 = default(bool);
					if (!flag2)
					{
						goto IL_00d8;
					}
					GameObject gameObject = default(GameObject);
					gameObject.SetActive((byte)num8 != 0);
					Sprite sprite = hoverSprite;
					num2++;
				}
				goto IL_00b6;
			}
			goto IL_00eb;
			IL_00b6:
			GridEditMode.FenceMode fenceMode4 = this.fenceMode;
			bool flag3 = default(bool);
			if (!flag3)
			{
				GameObject gameObject2 = default(GameObject);
				gameObject2.SetActive((byte)num8 != 0);
				Sprite sprite2 = hoverSprite;
				num2++;
			}
			goto IL_00d8;
			IL_00e4:
			num2++;
			goto IL_00e8;
			IL_00eb:
			throw new IndexOutOfRangeException();
			IL_00d8:
			int active = 0;
			GameObject gameObject3 = default(GameObject);
			gameObject3.SetActive((byte)active != 0);
			goto IL_00e4;
		}

		[Cpp2IlInjected.Token(Token = "0x6001103")]
		[Cpp2IlInjected.Address(RVA = "0x136DB10", Offset = "0x136C510", VA = "0x18136DB10", Slot = "6")]
		public void EndMove()
		{
			//Discarded unreachable code: IL_001a
			//IL_0019: Expected O, but got I4
			moveInProgress = false;
			int num = 0;
			GridEditMode.FenceMode fenceMode = this.fenceMode;
			int num2 = 0;
			fenceMode.HorizontalMove = (bool?)(object)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001104")]
		[Cpp2IlInjected.Address(RVA = "0x136E400", Offset = "0x136CE00", VA = "0x18136E400")]
		public FenceModeGizmo()
		{
		}
	}
}
