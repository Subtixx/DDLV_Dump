using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic
{
	[Cpp2IlInjected.Token(Token = "0x20004B7")]
	public class TexturePool
	{
		[Cpp2IlInjected.Token(Token = "0x20004B8")]
		private class PooledTexture
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001DB9")]
			public RenderTexture texture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001DBA")]
			public int assignedTo;

			[Cpp2IlInjected.Token(Token = "0x60014EE")]
			[Cpp2IlInjected.Address(RVA = "0x1413330", Offset = "0x1411D30", VA = "0x181413330")]
			public PooledTexture(int textureSize, RenderTextureFormat format, int assignedTo)
			{
				//Discarded unreachable code: IL_0030
				this.assignedTo = assignedTo;
				int num = 0;
				RenderTexture renderTexture = default(RenderTexture);
				renderTexture.name = "TexturePool";
				texture = renderTexture;
				texture.wrapMode = TextureWrapMode.Clamp;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DB8")]
		private List<PooledTexture> _textures = (List<PooledTexture>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x1700029D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4001DB5")]
		public int TextureSize
		{
			[Cpp2IlInjected.Token(Token = "0x60014E1")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60014E2")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700029E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4001DB6")]
		public int MaxCount
		{
			[Cpp2IlInjected.Token(Token = "0x60014E3")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60014E4")]
			[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700029F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4001DB7")]
		public RenderTextureFormat Format
		{
			[Cpp2IlInjected.Token(Token = "0x60014E5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60014E6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x60014E7")]
		[Cpp2IlInjected.Address(RVA = "0x1073510", Offset = "0x1071F10", VA = "0x181073510")]
		public TexturePool(int textureSize, int maxCount, RenderTextureFormat format)
		{
			MaxCount = maxCount;
			Format = format;
			TextureSize = textureSize;
		}

		[Cpp2IlInjected.Token(Token = "0x60014E8")]
		[Cpp2IlInjected.Address(RVA = "0x1073100", Offset = "0x1071B00", VA = "0x181073100")]
		public List<int> GetAssignedIds()
		{
			List<PooledTexture> textures = _textures;
			Func<PooledTexture, bool> _003C_003E9__15_ = _003C_003Ec._003C_003E9__15_0;
			if (_003C_003E9__15_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((PooledTexture t) => t.assignedTo != -1);
			}
			IEnumerable<PooledTexture> enumerable = (IEnumerable<PooledTexture>)Enumerable.Where<PooledTexture>((IEnumerable<>)textures, (Func<, >)(object)_003C_003E9__15_);
			Func<PooledTexture, int> func = default(Func<PooledTexture, int>);
			if (_003C_003Ec._003C_003E9__15_1 == null)
			{
				func = (Func<PooledTexture, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((PooledTexture t) => t.assignedTo));
			}
			return (List<int>)(object)Enumerable.ToList<int>(Enumerable.Select<PooledTexture, int>((IEnumerable<>)enumerable, (Func<, >)(object)func));
		}

		[Cpp2IlInjected.Token(Token = "0x60014E9")]
		[Cpp2IlInjected.Address(RVA = "0x1072E90", Offset = "0x1071890", VA = "0x181072E90")]
		public bool CanAcquireTexture()
		{
			//Discarded unreachable code: IL_003b
			List<PooledTexture> textures = _textures;
			int num = MaxCount;
			Func<PooledTexture, bool> func = default(Func<PooledTexture, bool>);
			if (_003C_003Ec._003C_003E9__16_0 == null)
			{
				func = (Func<PooledTexture, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((PooledTexture t) => t.assignedTo == -1));
			}
			return Enumerable.FirstOrDefault<PooledTexture>((IEnumerable<>)textures, (Func<, >)(object)func) != null;
		}

		[Cpp2IlInjected.Token(Token = "0x60014EA")]
		[Cpp2IlInjected.Address(RVA = "0x1073330", Offset = "0x1071D30", VA = "0x181073330")]
		public RenderTexture GetTexture(int id)
		{
			//Discarded unreachable code: IL_0034
			List<PooledTexture> textures = _textures;
			Func<PooledTexture, bool> func = (Func<PooledTexture, bool>)(object)(Func<T, TResult>)delegate(PooledTexture t)
			{
				//Discarded unreachable code: IL_0011
				int num = id;
				return t.assignedTo == num;
			};
			PooledTexture pooledTexture = Enumerable.FirstOrDefault<PooledTexture>((IEnumerable<>)textures, (Func<, >)(object)func);
			if (pooledTexture == null)
			{
			}
			return pooledTexture.texture;
		}

		[Cpp2IlInjected.Token(Token = "0x60014EB")]
		[Cpp2IlInjected.Address(RVA = "0x1072C10", Offset = "0x1071610", VA = "0x181072C10")]
		public RenderTexture AcquireTexture(int id)
		{
			//IL_0083: Expected I4, but got O
			List<PooledTexture> textures = _textures;
			Func<PooledTexture, bool> func = (Func<PooledTexture, bool>)(object)(Func<T, TResult>)delegate(PooledTexture t)
			{
				//Discarded unreachable code: IL_0011
				int num3 = id;
				return t.assignedTo == num3;
			};
			if (Enumerable.FirstOrDefault<PooledTexture>((IEnumerable<>)textures, (Func<, >)(object)func) == null)
			{
				List<PooledTexture> textures2 = _textures;
				Func<PooledTexture, bool> _003C_003E9__18_ = _003C_003Ec._003C_003E9__18_1;
				if (_003C_003E9__18_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((PooledTexture t) => t.assignedTo == -1);
				}
				if (Enumerable.FirstOrDefault<PooledTexture>((IEnumerable<>)textures2, (Func<, >)(object)_003C_003E9__18_) == null)
				{
					List<PooledTexture> textures3 = _textures;
					int num = MaxCount;
					int num2 = 0;
				}
				PooledTexture pooledTexture = default(PooledTexture);
				RenderTexture texture = pooledTexture.texture;
				pooledTexture.assignedTo = (int)texture;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60014EC")]
		[Cpp2IlInjected.Address(RVA = "0x1073420", Offset = "0x1071E20", VA = "0x181073420")]
		public void ReleaseTexture(int id)
		{
			//Discarded unreachable code: IL_003e
			//IL_003d: Expected I4, but got I8
			List<PooledTexture> textures = _textures;
			Func<PooledTexture, bool> func = (Func<PooledTexture, bool>)(object)(Func<T, TResult>)delegate(PooledTexture t)
			{
				//Discarded unreachable code: IL_0011
				int num = id;
				return t.assignedTo == num;
			};
			PooledTexture pooledTexture = Enumerable.FirstOrDefault<PooledTexture>((IEnumerable<>)textures, (Func<, >)(object)func);
			if (pooledTexture != null)
			{
				pooledTexture.assignedTo = -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014ED")]
		[Cpp2IlInjected.Address(RVA = "0x1072FF0", Offset = "0x10719F0", VA = "0x181072FF0")]
		public void DestroyUnused()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
