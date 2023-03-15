using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

[Cpp2IlInjected.Token(Token = "0x2000091")]
[CreateAssetMenu]
public class WeatherMap : ScriptableObject
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class Map
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public string shaderName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public Texture2D output;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Map()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class Probe
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public Color[] colors = new Color[4];

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public float slow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public bool flowSource;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xF87D30", Offset = "0xF86730", VA = "0x180F87D30")]
		public Probe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xF87D90", Offset = "0xF86790", VA = "0x180F87D90")]
		public unsafe Probe(Vector3 position)
		{
			//IL_0022: Expected native int or pointer, but got O
			float z = position.z;
			((Vector3*)(IntPtr)this.position)->z = z;
			Color[] array = (colors = new Color[4]);
			/*Error: Unexpected end of block*/;
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class Area
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public List<Shape> shapes = (List<Shape>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Probe this[int a, int b]
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xF86F40", Offset = "0xF85940", VA = "0x180F86F40")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Probe this[(int, int) id]
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xF86EA0", Offset = "0xF858A0", VA = "0x180F86EA0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xF86C10", Offset = "0xF85610", VA = "0x180F86C10")]
		public unsafe Area(string name)
		{
			//Discarded unreachable code: IL_0090
			//IL_0068: Expected F4, but got I4
			//IL_0063: Expected native int or pointer, but got O
			this.name = name;
			List<Shape> list = shapes;
			Shape shape = new Shape();
			List<Probe> list2 = (shape.probes = (List<Probe>)(object)new List<T>());
			int num = 0;
			int num2 = 0;
			List<Probe> probes = shape.probes;
			Probe probe = new Probe();
			Color[] array = (probe.colors = new Color[4]);
			((Vector3*)(IntPtr)probe.position)->z = num;
			Color[] array2 = (probe.colors = new Color[4]);
			((List<T>)(object)probes).Add((T)probe);
			num2++;
			((List<T>)(object)list).Add((T)shape);
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class Shape
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public Mesh mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public List<Probe> probes = (List<Probe>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xF87E50", Offset = "0xF86850", VA = "0x180F87E50")]
		public unsafe Shape()
		{
			//Discarded unreachable code: IL_004e
			//IL_0039: Expected F4, but got I4
			//IL_0034: Expected native int or pointer, but got O
			int num = 0;
			int num2 = 0;
			Probe probe = new Probe();
			Color[] array = (probe.colors = new Color[4]);
			((Vector3*)(IntPtr)probe.position)->z = num;
			Color[] array2 = (probe.colors = new Color[4]);
			num2++;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	public Map[] maps = new Map[0];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	public Bounds bounds;

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x837A10", Offset = "0x836410", VA = "0x180837A10")]
	public void SendToShaders()
	{
		//Discarded unreachable code: IL_0079
		//IL_0041: Expected O, but got I4
		Vector3 vector = default(Vector3);
		float z = vector.z;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		Map[] array = maps;
		int num = 0;
		if (num < array.Length)
		{
			Texture2D output = array[num].output;
			int num2 = 0;
			if (!(output == (UnityEngine.Object)num2))
			{
				Map map = maps[num];
				Texture2D output2 = map.output;
				Shader.SetGlobalTexture(map.shaderName, output2);
			}
			Map[] array2 = maps;
			num++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x837BF0", Offset = "0x8365F0", VA = "0x180837BF0")]
	public void Send(CommandBuffer cmd)
	{
		//Discarded unreachable code: IL_006b
		//IL_0041: Expected O, but got I4
		Vector3 vector = default(Vector3);
		float z = vector.z;
		Vector3 vector2 = default(Vector3);
		float z2 = vector2.z;
		Map[] array = maps;
		int num = 0;
		if (num < array.Length)
		{
			Texture2D output = array[num].output;
			int num2 = 0;
			if (!(output == (UnityEngine.Object)num2))
			{
				Map map = maps[num];
				RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
				IntPtr bufferPointer = renderTargetIdentifier.m_BufferPointer;
			}
			Map[] array2 = maps;
			num++;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x837E40", Offset = "0x836840", VA = "0x180837E40")]
	public WeatherMap()
	{
	}
}
