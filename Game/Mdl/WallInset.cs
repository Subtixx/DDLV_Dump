using System;
using Cpp2IlInjected;
using Mdl.Environments;
using Mdl.Grid;
using UnityEngine;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[ExecuteAlways]
	public class WallInset : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40010F4")]
		public MeshRenderer wallRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40010F5")]
		private HouseWallManager houseWallManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40010F6")]
		private GridObjectScript gridObjectScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40010F7")]
		private MaterialPropertyBlock mpb;

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0xD4DA40", Offset = "0xD4C440", VA = "0x180D4DA40")]
		private void Start()
		{
			//Discarded unreachable code: IL_004b
			//IL_001e: Expected O, but got I4
			HouseWallManager houseWallManager = (this.houseWallManager = GetComponentInParent<HouseWallManager>());
			HouseWallManager houseWallManager2 = this.houseWallManager;
			int num = 0;
			bool flag = default(bool);
			if (houseWallManager2 != (UnityEngine.Object)num && flag)
			{
				GridObjectScript gridObjectScript = this.gridObjectScript;
				EventHandler value = GridObjectScript_OnTransformUpdate;
				gridObjectScript.OnTransformUpdate += value;
				UpdateWallPosition();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0xD4D920", Offset = "0xD4C320", VA = "0x180D4D920")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0061
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			GridObjectScript gridObjectScript = this.gridObjectScript;
			int num = 0;
			if (gridObjectScript != (UnityEngine.Object)num)
			{
				HouseWallManager houseWallManager = this.houseWallManager;
				int num2 = 0;
				if (houseWallManager != (UnityEngine.Object)num2)
				{
					HouseWallManager houseWallManager2 = this.houseWallManager;
					GridObjectScript wallObject = this.gridObjectScript;
					bool flag = houseWallManager2.RemoveWallObject(wallObject);
				}
				GridObjectScript gridObjectScript2 = this.gridObjectScript;
				EventHandler value = GridObjectScript_OnTransformUpdate;
				gridObjectScript2.OnTransformUpdate -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0xD4DB70", Offset = "0xD4C570", VA = "0x180D4DB70")]
		public void UpdateWallPaper(Material wallpaperMaterial)
		{
			//Discarded unreachable code: IL_000d
			((Renderer)wallRenderer).SetMaterial(wallpaperMaterial);
		}

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0xD4DB90", Offset = "0xD4C590", VA = "0x180D4DB90")]
		private void UpdateWallPosition()
		{
			//Discarded unreachable code: IL_003f
			HouseWallManager houseWallManager = this.houseWallManager;
			if (mpb == null)
			{
				MaterialPropertyBlock materialPropertyBlock = (mpb = new MaterialPropertyBlock());
			}
			MeshRenderer meshRenderer = wallRenderer;
			MaterialPropertyBlock properties = mpb;
			((Renderer)meshRenderer).Internal_SetPropertyBlock(properties);
			MeshRenderer meshRenderer2 = wallRenderer;
		}

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0xD4D910", Offset = "0xD4C310", VA = "0x180D4D910")]
		private void GridObjectScript_OnTransformUpdate(object sender, EventArgs e)
		{
			UpdateWallPosition();
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public WallInset()
		{
		}
	}
}
