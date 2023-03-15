using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000B6")]
[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
public class VisualGrid : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	public int xCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	public int yCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	public float tileSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private Vector3[] vertices;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private Mesh mesh;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0xD4AAA0", Offset = "0xD494A0", VA = "0x180D4AAA0")]
	private void Start()
	{
		Generate();
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void Update()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void Awake()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xD4A5E0", Offset = "0xD48FE0", VA = "0x180D4A5E0")]
	private void Generate()
	{
		//Discarded unreachable code: IL_013d
		//IL_0010: Expected O, but got I4
		//IL_007f: Expected O, but got I4
		//IL_0089: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_00ed: Expected I4, but got O
		//IL_00fa: Expected I4, but got O
		//IL_0107: Expected I4, but got O
		//IL_0114: Expected I4, but got O
		MeshFilter component = GetComponent<MeshFilter>();
		int num = 0;
		if (component == (UnityEngine.Object)num)
		{
			MeshFilter meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh2 = (component.mesh = (this.mesh = new Mesh()));
		component.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		component.name = "Procedural Grid";
		Vector3[] array = (vertices = new Vector3[0]);
		Vector2[] array2 = new Vector2[vertices.Length];
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		vertices[1] = (Vector3)num4;
		array2[0] = (Vector2)num4;
		num2++;
		array2[0] = (Vector2)num3;
		while (num4 >= num3)
		{
		}
		while (num4 >= num4)
		{
		}
		Vector3[] array3 = vertices;
		Color32[] array4 = new Color32[(object)array2];
		array4 = (Color32[])(object)((object)array4 + (object)array4);
		int[] array5 = new int[(object)array4];
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		if ((long)(IntPtr)mesh2 > 0L)
		{
			array5[0] = num6;
			array5[0] = (int)typeof(int[]).TypeHandle;
			array5[0] = (int)typeof(int[]).TypeHandle;
			array5[0] = (int)typeof(int[]).TypeHandle;
			array5[0] = (int)typeof(int[]).TypeHandle;
			num8++;
			array5[0] = num5;
			num5 += 6;
			num6++;
		}
		num7++;
		num6++;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public VisualGrid()
	{
	}
}
