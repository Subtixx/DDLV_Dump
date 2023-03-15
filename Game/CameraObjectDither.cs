using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class CameraObjectDither : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private struct DitherContext
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public IDitherable ditherableObjectInterface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private MeshRenderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private List<(MeshRenderer renderer, bool[] wasDithered)> originalDithered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private Action<DitherContext> destroyAction;

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private static int fadeKey = Shader.PropertyToID("fade");

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x13E4F10", Offset = "0x13E3910", VA = "0x1813E4F10")]
		public DitherContext(IDitherable ditherableInterface, Action<DitherContext> destroyAction)
		{
			//Discarded unreachable code: IL_005e
			this.destroyAction = destroyAction;
			ditherableObjectInterface = ditherableInterface;
			MeshRenderer[] array = default(MeshRenderer[]);
			renderers = array;
			progress = 1f;
			List<(MeshRenderer, bool[])> list = (originalDithered = (List<(MeshRenderer renderer, bool[] wasDithered)>)(object)new List<T>());
			int num = 0;
			int num2 = 0;
			bool flag = default(bool);
			uint num3 = default(uint);
			if (!flag && num3 != 2)
			{
				bool[] array2 = new bool[0];
				int num4 = 0;
				int num5 = fadeKey;
				num4++;
				int num6 = 0;
			}
			num2++;
			num = num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x13E4A30", Offset = "0x13E3430", VA = "0x1813E4A30")]
		private void DitherableObjectDestroyed(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_0018
			List<(MeshRenderer, bool[])> list = originalDithered;
			if (destroyAction != null)
			{
				List<(MeshRenderer, bool[])> list2 = originalDithered;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x13E4CB0", Offset = "0x13E36B0", VA = "0x1813E4CB0")]
		public bool Update(float dt)
		{
			progress = dt;
			if (!(dt >= 1f))
			{
				float ditherMin = CameraObjectDither.ditherMin;
				float num = (progress = CameraObjectDither.ditherMin);
				MeshRenderer[] array = renderers;
				int num2 = 0;
				int num3 = 0;
				int length = array.Length;
				if (num3 < length)
				{
					Material[] sharedMaterialArray = ((Renderer)array[num2]).GetSharedMaterialArray();
					int num4 = 0;
					if (num4 < sharedMaterialArray.Length)
					{
						Material material = sharedMaterialArray[num4];
						float value = progress;
						int name = fadeKey;
						material.SetFloatImpl(name, value);
						num4++;
					}
					num2++;
				}
				return true;
			}
			int num5 = 0;
			progress = 1f;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x13E46D0", Offset = "0x13E30D0", VA = "0x1813E46D0")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_0130
			//IL_0042: Expected O, but got I4
			//IL_0095: Expected F4, but got I4
			MeshRenderer[] array = renderers;
			int num = 0;
			int num2 = 0;
			if (num2 >= array.Length)
			{
				return;
			}
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
			MeshRenderer meshRenderer = (CS_0024_003C_003E8__locals0.renderer = array[num]);
			MeshRenderer renderer = CS_0024_003C_003E8__locals0.renderer;
			int num3 = 0;
			if (!(renderer == (UnityEngine.Object)num3) && CS_0024_003C_003E8__locals0.renderer.renderingLayerMask != 2)
			{
				Material[] sharedMaterialArray = ((Renderer)CS_0024_003C_003E8__locals0.renderer).GetSharedMaterialArray();
				int num4 = 0;
				if (num4 < sharedMaterialArray.Length)
				{
					Material material = sharedMaterialArray[num4];
					int num5 = 0;
					int name = fadeKey;
					material.SetFloatImpl(name, (float)num5);
					num4++;
				}
				List<(MeshRenderer, bool[])> list = originalDithered;
				Predicate<(MeshRenderer, bool[])> predicate = (Predicate<(MeshRenderer, bool[])>)(object)(Predicate<T>)(((MeshRenderer renderer, bool[] wasDithered) o) => default(bool));
				if (((List<T>)(object)list).FindIndex((Predicate<>)(object)predicate) == -1)
				{
					int num6 = 0;
					if (num6 >= sharedMaterialArray.Length)
					{
						goto IL_0129;
					}
					sharedMaterialArray[num6].DisableKeyword("LOD_FADE_CROSSFADE");
					num6++;
				}
				List<(MeshRenderer, bool[])> list2 = originalDithered;
				int num7 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				num7 += num7;
				int num8 = 0;
				int length = sharedMaterialArray.Length;
				if (num8 < length)
				{
					num2 = num8;
					sharedMaterialArray[num8].DisableKeyword("LOD_FADE_CROSSFADE");
					num8++;
				}
			}
			goto IL_0129;
			IL_0129:
			num++;
			num2 = num;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x13E4B60", Offset = "0x13E3560", VA = "0x1813E4B60", Slot = "3")]
		public override string ToString()
		{
			//IL_002c: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			if ("{0} ({1}) (%={2})" != null)
			{
			}
			int num = 0;
			if ("{0} ({1}) (%={2})" != null)
			{
			}
			int num2 = 0;
			float num3 = progress;
			return $"{num} ({num2}) (%={num2})";
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	private static int maxObjectDither;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private static float ditherSpeed;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private static float ditherMin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	private Collider[] results;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private IDitherable[] ditherableObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private DitherContext[] ditherContexts;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private int ditherContextCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private int physicsLayerMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	[SerializeField]
	private string[] IgnoreLayers;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x164E140", Offset = "0x164CB40", VA = "0x18164E140")]
	private void Start()
	{
		int num = (physicsLayerMask = LayerMask.GetMask(IgnoreLayers));
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x164E160", Offset = "0x164CB60", VA = "0x18164E160")]
	private unsafe void Update()
	{
		//Discarded unreachable code: IL_013a, IL_013f, IL_0147, IL_0222
		//IL_0016: Expected O, but got I4
		//IL_00f7: Expected I4, but got O
		//IL_021b: Expected O, but got I4
		//IL_0216: Expected native int or pointer, but got O
		int num;
		Vector3 vector = default(Vector3);
		int num3 = default(int);
		int num4 = default(int);
		DitherContext ditherContext = default(DitherContext);
		bool flag = default(bool);
		DitherContext ditherContext2 = default(DitherContext);
		int num5 = default(int);
		int num10 = default(int);
		while (true)
		{
			num = 0;
			CameraCollisionSystem system = SystemRoot.Instance.GetSystem<CameraCollisionSystem>();
			int num2 = 0;
			if (system != (UnityEngine.Object)num2)
			{
			}
			Transform transform = base.transform;
			float z = vector.z;
			if (num3 > 0)
			{
				if (results[num].transform.TryGetComponent<IDitherable>(out *(IDitherable*)num))
				{
					IDitherable[] array = ditherableObjects;
					IDitherable[] array2 = ditherableObjects;
					num++;
					if (num != 0 && num4 == 0)
					{
						continue;
					}
					((int*)num)->m_value = num;
				}
				num++;
				num5 = 0;
			}
			if (ditherContextCount <= 0)
			{
				break;
			}
			DitherContext[] array3 = ditherContexts;
			IDitherable ditherableObject = (IDitherable)ditherContext;
			IDitherable[] array4 = ditherableObjects;
			Predicate<IDitherable> predicate = (Predicate<IDitherable>)(object)(Predicate<T>)((IDitherable dos) => dos == ditherableObject);
			DitherContext[] array5 = ditherContexts;
			int num6 = 0;
			float deltaTime = Time.deltaTime;
			float num7 = ditherSpeed;
			if (!flag)
			{
				DitherContext[] array6 = ditherContexts;
				int length = ditherContexts.Length;
				int num8 = ditherContextCount;
				((int*)(num8 + 1))->m_value = (int)ditherContext2;
				int num9 = 0;
				float deltaTime2 = Time.deltaTime;
				IDitherable[] array7 = ditherableObjects;
				int length2 = array7.Length;
				IDitherable ditherable = array7[num];
				IDitherable ditherable2 = array7[num8];
				if (ditherable == null || length2 != 0)
				{
					throw new IndexOutOfRangeException();
				}
				continue;
			}
			num5++;
			num10 = 0;
			break;
		}
		if (num <= 0)
		{
			return;
		}
		IDitherable ditherable3 = ditherableObjects[num10];
		uint num11 = default(uint);
		if (num10 < (int)num11)
		{
			num10 += num10;
			num10++;
		}
		if (num10 != 0)
		{
			int length3 = ditherContexts.Length;
			if (ditherContextCount == length3)
			{
				length3 += length3;
				DitherContext[] destinationArray = new DitherContext[length3];
				DitherContext[] array8 = ditherContexts;
				int length4 = array8.Length;
				Array.Copy(array8, destinationArray, length4);
				ditherContexts = destinationArray;
			}
			IDitherable[] array9 = ditherableObjects;
			DitherContext[] array10 = ditherContexts;
			int num12 = ditherContextCount;
			IDitherable ditherable4 = array9[num10];
			Action<DitherContext> action = (Action<DitherContext>)(object)new Action<T>(OnDitherContextDestroyed);
			int num13 = 0;
			int num14 = 0;
			int num15 = num12 + 1;
			int num16 = 0;
			((DitherContext*)(IntPtr)array10)->ditherableObjectInterface = (IDitherable)num13;
		}
		num10++;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x164DFA0", Offset = "0x164C9A0", VA = "0x18164DFA0")]
	private void OnDitherContextDestroyed(DitherContext destroyedDitherContext)
	{
		//Discarded unreachable code: IL_0019
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		//IL_003f: Expected I4, but got O
		int num = ditherContextCount;
		int num2 = 0;
		if (num > 0)
		{
			DitherContext[] array = ditherContexts;
			num2++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x164EB80", Offset = "0x164D580", VA = "0x18164EB80")]
	public CameraObjectDither()
	{
		//Discarded unreachable code: IL_009f
		string[] array;
		while (true)
		{
			results = new Collider[maxObjectDither];
			ditherableObjects = new IDitherable[maxObjectDither];
			ditherContexts = new DitherContext[10];
			array = new string[3];
			if ("Ground" != null && "Ground" == null)
			{
				continue;
			}
			array[0] = "Ground";
			if ("CameraCollision" == null || "CameraCollision" != null)
			{
				array[1] = "CameraCollision";
				if ("Player" == null || "Player" != null)
				{
					break;
				}
			}
		}
		array[2] = "Player";
		IgnoreLayers = array;
		base._002Ector();
	}
}
