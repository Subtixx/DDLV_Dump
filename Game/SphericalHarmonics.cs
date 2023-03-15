using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

[Cpp2IlInjected.Token(Token = "0x200009F")]
public class SphericalHarmonics
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0xF598A0", Offset = "0xF582A0", VA = "0x180F598A0")]
	public static TextureFormat ConvertFormat(RenderTextureFormat input_format)
	{
		//IL_000c: Expected I4, but got O
		//IL_0016: Expected I4, but got O
		//IL_0021: Expected I4, but got O
		switch (input_format)
		{
		case RenderTextureFormat.ARGB32:
			return (TextureFormat)typeof(Type).TypeHandle;
		case RenderTextureFormat.ARGBHalf:
			return (TextureFormat)typeof(Type).TypeHandle;
		case RenderTextureFormat.ARGBFloat:
			return (TextureFormat)typeof(Type).TypeHandle;
		default:
		{
			Type typeFromHandle = typeof(RenderTextureFormat);
			string name = Enum.GetName(typeFromHandle, typeFromHandle);
			object obj = Enum.Parse(typeof(TextureFormat), name);
			throw new NullReferenceException();
		}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0xF59A00", Offset = "0xF58400", VA = "0x180F59A00")]
	public static RenderTextureFormat ConvertRenderFormat(TextureFormat input_format)
	{
		//IL_0013: Expected I4, but got O
		//IL_001e: Expected I4, but got O
		if (input_format == TextureFormat.RGBA32)
		{
			int num = 0;
		}
		switch (input_format)
		{
		case TextureFormat.RGBAHalf:
			return (RenderTextureFormat)typeof(Type).TypeHandle;
		case TextureFormat.RGBAFloat:
			return (RenderTextureFormat)typeof(Type).TypeHandle;
		default:
		{
			Type typeFromHandle = typeof(TextureFormat);
			string name = Enum.GetName(typeFromHandle, typeFromHandle);
			object obj = Enum.Parse(typeof(RenderTextureFormat), name);
			throw new NullReferenceException();
		}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xF5B180", Offset = "0xF59B80", VA = "0x180F5B180")]
	public static Cubemap RenderTextureToCubemap(RenderTexture input)
	{
		//IL_00c3: Expected O, but got I4
		if (input.dimension == TextureDimension.Cube)
		{
			int width = input.width;
			int height = input.height;
			if (width == height)
			{
				int width2 = input.width;
				int format = (int)input.format;
				if (format == 0)
				{
				}
				if (format == 2)
				{
				}
				if (format == 11)
				{
				}
				Type typeFromHandle = typeof(RenderTextureFormat);
				string name = Enum.GetName(typeFromHandle, typeFromHandle);
				object obj = Enum.Parse(typeof(TextureFormat), name);
				int num = 0;
				width2 = input.width;
				int height2 = input.height;
				Cubemap cubemap = default(Cubemap);
				TextureFormat format2 = cubemap.format;
				Texture2D texture2D = default(Texture2D);
				texture2D.name = "SH_face";
				int num2 = 0;
				int mipLevel = 0;
				Graphics.SetRenderTarget(input, mipLevel, (CubemapFace)num);
				int width3 = input.width;
				int height3 = input.height;
				int num3 = 0;
				int destY = 0;
				int destX = 0;
				texture2D.ReadPixels((Rect)num3, destX, destY);
				Color[] pixels = texture2D.GetPixels();
				cubemap.SetPixels(pixels, (CubemapFace)num);
				num++;
				cubemap.Apply();
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
			Debug.LogWarning("Input render texture must be square");
			int num4 = 0;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0xF588E0", Offset = "0xF572E0", VA = "0x180F588E0")]
	public static float AreaElement(float x, float y)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0xF59B60", Offset = "0xF58560", VA = "0x180F59B60")]
	public static float DifferentialSolidAngle(int textureSize, float U, float V)
	{
		return U;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0xF59D70", Offset = "0xF58770", VA = "0x180F59D70")]
	public static Vector3 DirectionFromCubemapTexel(int face, float u, float v)
	{
		Vector3 zero = Vector3.zero;
		float num = v * -2f;
		Vector3 vector = default(Vector3);
		float z = vector.z;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xF59F30", Offset = "0xF58930", VA = "0x180F59F30")]
	public static int FindFace(Vector3 dir)
	{
		uint num = default(uint);
		int num2 = default(int);
		while (true)
		{
			float z = dir.z;
			if (num == 0)
			{
				break;
			}
			if (num == 0)
			{
				continue;
			}
			if (num != 0)
			{
				if (num == 0 || num != 1)
				{
					continue;
				}
				float z2 = dir.z;
				num2 = 0;
			}
			if (0 > num2)
			{
				break;
			}
		}
		int num3 = 0;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0xF5AE30", Offset = "0xF59830", VA = "0x180F5AE30")]
	public unsafe static int GetTexelIndexFromDirection(Vector3 dir, int cubemap_size)
	{
		//IL_0016: Expected native int or pointer, but got O
		//IL_0024: Expected native int or pointer, but got O
		//IL_003c: Expected native int or pointer, but got O
		//IL_004c: Expected native int or pointer, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected I4, but got Unknown
		int num = 0;
		int num2 = FindFace(dir);
		if (num2 <= 5)
		{
			float num3 = (((Vector3*)(IntPtr)dir)->z = dir.z);
			float num4 = (((Vector3*)(IntPtr)dir)->z = dir.z);
			float y = dir.y;
			float num5 = (((Vector3*)(IntPtr)dir)->z = dir.z);
			float num6 = (((Vector3*)(IntPtr)dir)->z = dir.z);
			float y2 = dir.y;
			float y3 = dir.y;
			if (num2 == 5)
			{
			}
			if (num2 != 5)
			{
			}
		}
		int num7 = num2 * cubemap_size;
		return (int)(num7 + dir);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0xF58DF0", Offset = "0xF577F0", VA = "0x180F58DF0")]
	public static bool CPU_Project_Uniform_9Coeff(Cubemap input, Vector4[] output, Color bot, Color mid, Color top)
	{
		//IL_0079: Expected O, but got F4
		if (output.Length == 9)
		{
			int width = input.width;
			int height = input.height;
			if (width == height)
			{
				int width2 = input.width;
				int num = 0;
				width = width2;
				int num2 = width2 * width2;
				Color[] pixels = input.GetPixels((CubemapFace)num);
				int num3 = 0;
				if (num2 > 0)
				{
					int num4 = 0;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					num3 += 2;
					num3 += num3;
					float num5 = Mathf.Clamp01(1f);
					float num6 = default(float);
					num5 = num6;
					num4 += num4;
					output[1] = (Vector4)z;
					num4++;
					num3++;
				}
				num++;
				if (num >= 6)
				{
				}
			}
			Debug.LogWarning("input cubemap must be square");
			int num7 = 0;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0xF59430", Offset = "0xF57E30", VA = "0x180F59430")]
	public unsafe static bool CPU_Project_Uniform_9Coeff(Cubemap input, Vector4[] output)
	{
		//IL_0062: Expected F4, but got I4
		//IL_0062: Expected F4, but got I4
		//IL_006e: Expected F4, but got I4
		//IL_0069: Expected native int or pointer, but got O
		if (output.Length == 9)
		{
			int width = input.width;
			int height = input.height;
			if (width == height)
			{
				int width2 = input.width;
				int num = 0;
				width = width2;
				int num2 = width2 * width2;
				int num3 = 0;
				Color[] pixels = input.GetPixels((CubemapFace)num);
				int num4 = 0;
				if (num2 > 0)
				{
					Vector3 vector = default(Vector3);
					float z = vector.z;
					num4 += 2;
					num4 += num4;
					float num5 = DifferentialSolidAngle(width, num, num3);
					int num6 = 0;
					((Vector4*)(IntPtr)output)->x = 0f;
					num6 += num6;
					num6++;
					num4++;
				}
				num++;
			}
			Debug.LogWarning("input cubemap must be square");
			int num7 = 0;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0xF58930", Offset = "0xF57330", VA = "0x180F58930")]
	public unsafe static bool CPU_Project_MonteCarlo_9Coeff(Cubemap input, Vector4[] output, int sample_count)
	{
		//IL_005a: Expected F4, but got I4
		//IL_0055: Expected native int or pointer, but got O
		//IL_006e: Expected F4, but got I4
		//IL_0069: Expected native int or pointer, but got O
		if (output.Length == 9)
		{
			List<Color[]> list = (List<Color[]>)(object)new List<T>();
			int num = 0;
			int miplevel = 0;
			Color[] pixels = input.GetPixels((CubemapFace)num, miplevel);
			((List<T>)(object)list).Add((T)pixels);
			num++;
			int num2 = 0;
			int num3 = 0;
			if (sample_count > 0)
			{
				float z = UnityEngine.Random.onUnitSphere.z;
				int height = input.height;
				int num4 = num4 + 2;
				num4 += num4;
				((Vector4*)(IntPtr)output)->x = 0f;
				num2 += num2;
				num3++;
			}
			((Vector4*)(IntPtr)output)->x = 0f;
			num2 += num2;
			num2++;
		}
		Debug.LogWarning("output size must be 9 for 9 coefficients");
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0xF5A4C0", Offset = "0xF58EC0", VA = "0x180F5A4C0")]
	public static bool GPU_Project_Uniform_9Coeff(Cubemap input, Vector4[] output)
	{
		//IL_00a9: Expected O, but got I4
		//IL_00dc: Expected F4, but got I4
		//IL_0190: Expected I4, but got I8
		//IL_01ef: Expected F4, but got I4
		//IL_0272: Expected I4, but got I8
		ComputeBuffer computeBuffer;
		ComputeBuffer computeBuffer2;
		int count = default(int);
		int num = default(int);
		ComputeBuffer computeBuffer3;
		ComputeShader computeShader;
		int num2;
		string text = default(string);
		ulong num8 = default(ulong);
		int kernelIndex2;
		ComputeBuffer[] array;
		int val;
		int num5;
		while (true)
		{
			int width = input.width;
			computeBuffer = new ComputeBuffer(9, 16);
			computeBuffer2 = new ComputeBuffer(count, 16);
			count = num * num;
			count += count;
			computeBuffer3 = new ComputeBuffer(count, 16);
			computeShader = Resources.Load<ComputeShader>("Shaders/Reduce_Uniform");
			num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int format = (int)input.format;
			num5 = 0;
			if (format == 4)
			{
			}
			if (format == 17)
			{
			}
			if (format == 20)
			{
			}
			Type typeFromHandle = typeof(TextureFormat);
			string name = Enum.GetName(typeFromHandle, typeFromHandle);
			object obj = Enum.Parse(typeof(RenderTextureFormat), name);
			int num6 = 0;
			int num7 = 0;
			int height = input.height;
			int width2 = input.width;
			RenderTexture renderTexture = new RenderTexture((RenderTextureDescriptor)0);
			bool flag = renderTexture.Create();
			int srcMip = 0;
			Graphics.CopyTexture(input, num5, srcMip, renderTexture, num5, num5);
			num5++;
			int width3 = input.width;
			val = Mathf.CeilToInt(num2);
			string name2 = "sh_" + text;
			int val2 = 0;
			int kernelIndex = computeShader.FindKernel(name2);
			computeShader.SetInt("coeff", val2);
			computeShader.SetTexture(kernelIndex, "input_data", renderTexture);
			computeShader.SetBuffer(kernelIndex, "output_buffer", computeBuffer2);
			computeShader.SetBuffer(kernelIndex, "coefficients", computeBuffer);
			computeShader.SetInt("ceiled_size", val);
			val = input.width;
			computeShader.SetInt("input_size", val);
			computeShader.SetInt("row_size", val);
			int val3 = val * val;
			computeShader.SetInt("face_size", val3);
			val3 = val;
			computeShader.Dispatch(kernelIndex, val3, val, (int)num8);
			kernelIndex2 = computeShader.FindKernel("Reduce");
			array = new ComputeBuffer[2];
			if (computeBuffer2 == null || array != null)
			{
				array[0] = computeBuffer2;
				if (computeBuffer3 == null || computeBuffer3 != null)
				{
					break;
				}
			}
		}
		array[1] = computeBuffer3;
		int num9 = default(int);
		if (val > 1)
		{
			computeShader.SetInt("input_size", val);
			num9 = Mathf.CeilToInt(num2);
			val = num9;
			val = num9;
			computeShader.SetInt("ceiled_size", val);
			computeShader.SetBuffer(kernelIndex2, "coefficients", computeBuffer);
			ComputeBuffer buffer = array[num5];
			computeShader.SetBuffer(kernelIndex2, "input_buffer", buffer);
			num5++;
			if (num5 < array.Length)
			{
				num5++;
			}
			ComputeBuffer buffer2 = array[num5];
			computeShader.SetBuffer(kernelIndex2, "output_buffer", buffer2);
			ulong num10 = default(ulong);
			computeShader.Dispatch(kernelIndex2, val, val, (int)num10);
		}
		num9++;
		if (num9 < 9)
		{
		}
		Vector4[] data = new Vector4[9];
		computeBuffer.GetData(data);
		num5 += 2;
		num5 += num5;
		num5++;
		computeBuffer3.Dispose();
		computeBuffer2.Dispose();
		computeBuffer.Dispose();
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0xF5A000", Offset = "0xF58A00", VA = "0x180F5A000")]
	public unsafe static bool GPU_Project_MonteCarlo_9Coeff(Cubemap input, Vector4[] output)
	{
		//IL_0028: Expected I4, but got I8
		//IL_006f: Expected F4, but got I4
		//IL_006a: Expected native int or pointer, but got O
		//IL_00b5: Expected O, but got I4
		//IL_010c: Expected I4, but got I8
		//IL_0132: Expected F4, but got I4
		//IL_012d: Expected native int or pointer, but got O
		if (output.Length == 9)
		{
			int num = 0;
			RenderTexture renderTexture = default(RenderTexture);
			renderTexture.name = "GPU_Project_MonteCarlo_9Coeff";
			uint num2 = default(uint);
			ulong num3 = default(ulong);
			Texture2D texture2D = new Texture2D((int)num2, (int)num2, TextureFormat.RGFloat, (byte)num != 0, (byte)num3 != 0);
			Color[] array = new Color[9216];
			int num4 = 0;
			int num7 = default(int);
			if (num < array.Length)
			{
				int num5 = 0;
				float value = UnityEngine.Random.value;
				int num6 = 0;
				float value2 = UnityEngine.Random.value;
				num7 = 0;
				num += 2;
				num += num;
				num++;
				((Color*)(IntPtr)array)->r = num7;
			}
			texture2D.SetPixels(array);
			texture2D.Apply();
			Material material = new Material(Shader.Find("SH/MonteCarloProject"));
			material.SetTexture("random_samples", texture2D);
			material.SetTexture("input_cubemap", input);
			Graphics.Blit((Texture)0, renderTexture, material, num);
			num++;
			ComputeBuffer computeBuffer = new ComputeBuffer(9, 16);
			ComputeShader computeShader = Resources.Load<ComputeShader>("Shaders/Reduce_MC_1024");
			int kernelIndex = computeShader.FindKernel("Reduce_MC_1024");
			computeShader.SetTexture(kernelIndex, "input_data", renderTexture);
			computeShader.SetBuffer(kernelIndex, "coefficients_buffer", computeBuffer);
			uint num8 = default(uint);
			ulong num9 = default(ulong);
			computeShader.Dispatch(kernelIndex, (int)num8, (int)num8, (int)num9);
			Vector4[] data = new Vector4[9];
			computeBuffer.GetData(data);
			num += 2;
			num += num;
			num++;
			((Vector4*)(IntPtr)output)->x = num7;
			computeBuffer.Dispose();
		}
		Debug.LogWarning("output size must be 9 for 9 coefficients");
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
	public SphericalHarmonics()
	{
	}
}
