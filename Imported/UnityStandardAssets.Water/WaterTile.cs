using System;
using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public PlanarReflection reflection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public WaterBase waterBase;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8880", Offset = "0x3DC7280", VA = "0x183DC8880")]
		public void Start()
		{
			AcquireComponents();
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8520", Offset = "0x3DC6F20", VA = "0x183DC8520")]
		private void AcquireComponents()
		{
			if (!reflection)
			{
				if (!base.transform.parent)
				{
					Transform transform = base.transform;
				}
				PlanarReflection planarReflection = (reflection = base.transform.parent.GetComponent<PlanarReflection>());
			}
			if (!this.waterBase)
			{
				if ((bool)base.transform.parent)
				{
					Transform transform2 = default(Transform);
					Transform parent = transform2.parent;
					throw new NullReferenceException();
				}
				WaterBase waterBase = (this.waterBase = base.transform.GetComponent<WaterBase>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3DC8710", Offset = "0x3DC7110", VA = "0x183DC8710")]
		public void OnWillRenderObject()
		{
			//Discarded unreachable code: IL_0072
			if ((bool)reflection)
			{
				PlanarReflection planarReflection = reflection;
				Transform tr = base.transform;
				int num = 0;
				Camera current = Camera.current;
				planarReflection.WaterTileBeingRendered(tr, current);
			}
			if ((bool)this.waterBase)
			{
				WaterBase waterBase = this.waterBase;
				Transform transform = base.transform;
				int num2 = 0;
				Camera current2 = Camera.current;
				if ((bool)current2 && waterBase.edgeBlend)
				{
					DepthTextureMode depthTextureMode = current2.depthTextureMode;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public WaterTile()
		{
		}
	}
}
