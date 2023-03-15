using System;
using System.IO;
using Cpp2IlInjected;
using Mdl;
using UnityEngine;
using UnityEngine.SceneManagement;

[Cpp2IlInjected.Token(Token = "0x20000B3")]
[ExecuteInEditMode]
public class HeightmapBakerComponent : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private RenderTexture HeightmapRT;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public Material material;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public Rect heightmapSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public bool Bake;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public float MinHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public float MaxHeight;

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x154D180", Offset = "0x154BB80", VA = "0x18154D180")]
	private void Awake()
	{
		//Discarded unreachable code: IL_004e
		Material material = (this.material = new Material(Shader.Find("Custom/HeightmapBaker")));
		Material material2 = this.material;
		float minHeight = MinHeight;
		material2.SetFloat("MinHeight", minHeight);
		Material material3 = this.material;
		float maxHeight = MaxHeight;
		material3.SetFloat("MaxHeight", maxHeight);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x154D320", Offset = "0x154BD20", VA = "0x18154D320")]
	private void Start()
	{
		//Discarded unreachable code: IL_01aa, IL_026f
		RenderTexture renderTexture = default(RenderTexture);
		string path = default(string);
		string path2 = default(string);
		GameObject[] array = default(GameObject[]);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			renderTexture.name = "HeightmapRT";
			HeightmapRT = renderTexture;
			RenderTexture heightmapRT = HeightmapRT;
			int num3 = ((heightmapRT.autoGenerateMips = false) ? 1 : 0);
			RenderTexture heightmapRT2 = HeightmapRT;
			int num4 = ((heightmapRT2.useMipMap = false) ? 1 : 0);
			HeightmapRT.filterMode = FilterMode.Bilinear;
			HeightmapRT.wrapMode = TextureWrapMode.Clamp;
			int num5 = 0;
			RenderTexture heightmapRT3 = HeightmapRT;
			Color black = Color.black;
			RenderTexture heightmapRT4 = HeightmapRT;
			Camera component = base.gameObject.GetComponent<Camera>();
			RenderTexture heightmapRT5 = HeightmapRT;
			int height = 0;
			component.targetTexture = heightmapRT5;
			component.Render();
			Texture2D texture2D = new Texture2D(0, height);
			texture2D.name = "HeightmapTex";
			HeightmapRT.ToTexture2D(texture2D);
			Scene scene = base.gameObject.scene;
			string directoryName = Path.GetDirectoryName(path);
			Scene scene2 = base.gameObject.scene;
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path2);
			string path3 = directoryName + "/" + fileNameWithoutExtension + "_albedomap.tga";
			byte[] bytes = texture2D.EncodeToTGA();
			File.WriteAllBytes(path3, bytes);
			int num6 = 0;
			RenderTexture heightmapRT6 = HeightmapRT;
			Color black2 = Color.black;
			int num7 = 0;
			Scene activeScene = SceneManager.GetActiveScene();
			int num8 = 0;
			int num9 = 0;
			int length = array.Length;
			if (num8 >= length)
			{
				break;
			}
			Renderer[] componentsInChildren = array[num9].GetComponentsInChildren<Renderer>();
			int num10 = 0;
			if (num10 < componentsInChildren.Length)
			{
				Renderer renderer = componentsInChildren[num10];
				Material[] materialArray = new Material[renderer.GetSharedMaterialArray().Length];
				int num11 = 0;
				Material[] sharedMaterialArray = renderer.GetSharedMaterialArray();
				if (num11 < sharedMaterialArray.Length)
				{
					if ((object)material == null || sharedMaterialArray != null)
					{
						throw new IndexOutOfRangeException();
					}
					continue;
				}
				renderer.SetMaterialArray(materialArray);
				num10++;
			}
			num9++;
			break;
		}
		RenderTexture heightmapRT7 = HeightmapRT;
		Camera component2 = base.gameObject.GetComponent<Camera>();
		RenderTexture heightmapRT8 = HeightmapRT;
		int height2 = 0;
		component2.targetTexture = heightmapRT8;
		component2.Render();
		Texture2D texture2D2 = new Texture2D(0, height2);
		texture2D2.name = "HeightmapTex";
		HeightmapRT.ToTexture2D(texture2D2);
		Scene scene3 = base.gameObject.scene;
		string path4 = default(string);
		string directoryName2 = Path.GetDirectoryName(path4);
		Scene scene4 = base.gameObject.scene;
		string path5 = default(string);
		string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(path5);
		int num12 = 0;
		string path6 = directoryName2 + "/" + fileNameWithoutExtension2 + "_heightmap.tga";
		byte[] bytes2 = texture2D2.EncodeToTGA();
		File.WriteAllBytes(path6, bytes2);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void OnEnable()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x154D2C0", Offset = "0x154BCC0", VA = "0x18154D2C0")]
	private void OnDisable()
	{
		UnityEngine.Object.DestroyImmediate(HeightmapRT);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	private void OnValidate()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x154D260", Offset = "0x154BC60", VA = "0x18154D260")]
	private void ClearRT()
	{
		int num = 0;
		RenderTexture.SetActive(HeightmapRT);
		Color black = Color.black;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x154DA70", Offset = "0x154C470", VA = "0x18154DA70")]
	public HeightmapBakerComponent()
	{
		//IL_001f: Expected O, but got I4
		int num = 0;
		MinHeight = -10f;
		MaxHeight = 50f;
		heightmapSize = (Rect)num;
		base._002Ector();
	}
}
