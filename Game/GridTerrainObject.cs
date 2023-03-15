using System;
using Cpp2IlInjected;
using Mdl.Graphic;
using Mdl.Grid;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class GridTerrainObject : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	public MeshRenderer[] renderersToUpdate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private GridObjectScript gridObjectScript;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private static int firstTerrainIndexID = Shader.PropertyToID("_FirstTerrainIndex");

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private static int secondTerrainIndexID = Shader.PropertyToID("_SecondTerrainIndex");

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x1542D70", Offset = "0x1541770", VA = "0x181542D70")]
	private void Start()
	{
		//Discarded unreachable code: IL_004f
		//IL_001e: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		GridObjectScript gridObjectScript = (this.gridObjectScript = GetComponentInParent<GridObjectScript>());
		GridObjectScript gridObjectScript2 = this.gridObjectScript;
		int num = 0;
		if (gridObjectScript2 != (UnityEngine.Object)num)
		{
			GridObjectScript gridObjectScript3 = this.gridObjectScript;
			EventHandler value = UpdateTexture;
			gridObjectScript3.OnTransformUpdate += value;
		}
		int num2 = 0;
		int num3 = 0;
		UpdateTexture(num3, (EventArgs)num2);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x1542CA0", Offset = "0x15416A0", VA = "0x181542CA0")]
	private void OnDestroy()
	{
		//Discarded unreachable code: IL_002f
		//IL_0010: Expected O, but got I4
		GridObjectScript gridObjectScript = this.gridObjectScript;
		int num = 0;
		if (gridObjectScript != (UnityEngine.Object)num)
		{
			GridObjectScript gridObjectScript2 = this.gridObjectScript;
			EventHandler value = UpdateTexture;
			gridObjectScript2.OnTransformUpdate -= value;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x1542E80", Offset = "0x1541880", VA = "0x181542E80")]
	private unsafe void UpdateTexture(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_00f6
		//IL_001e: Expected O, but got I4
		//IL_004f: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		//IL_00d7: Expected I4, but got O
		if ((long)renderersToUpdate == 0)
		{
			return;
		}
		TerrainManager componentInParent = GetComponentInParent<TerrainManager>();
		int num = 0;
		if (!(componentInParent != (UnityEngine.Object)num))
		{
			MeshRenderer[] array = renderersToUpdate;
			int num2 = 0;
			int length = array.Length;
			if (num2 >= length)
			{
				return;
			}
			MeshRenderer meshRenderer = array[num2];
			int num3 = 0;
			if (meshRenderer != (UnityEngine.Object)num3)
			{
				int num4 = ((meshRenderer.enabled = false) ? 1 : 0);
			}
			num2++;
		}
		Transform transform = base.transform;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		MeshRenderer[] array2 = renderersToUpdate;
		int num5 = 0;
		int length2 = array2.Length;
		if (num5 >= length2)
		{
			return;
		}
		MeshRenderer meshRenderer2 = array2[num5];
		int num6 = 0;
		if (meshRenderer2 != (UnityEngine.Object)num6)
		{
			meshRenderer2.enabled = true;
			Material[] materialArray = ((Renderer)meshRenderer2).GetMaterialArray();
			if (num5 < materialArray.Length)
			{
				Material material = materialArray[num5];
				(int, int) tuple = default((int, int));
				int value = (int)((ValueTuple<, >*)(&tuple))->Item1;
				int nameID = firstTerrainIndexID;
				material.SetInt(nameID, value);
				num5++;
			}
		}
		num5++;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public GridTerrainObject()
	{
	}
}
