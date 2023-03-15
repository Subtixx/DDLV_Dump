using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000857")]
	public class RectTransformHelper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000773")]
		public RectTransform RectTransform
		{
			[Cpp2IlInjected.Token(Token = "0x60034C5")]
			[Cpp2IlInjected.Address(RVA = "0xF3F2A0", Offset = "0xF3DCA0", VA = "0x180F3F2A0")]
			get
			{
				while (true)
				{
					if ((object)base.transform == null)
					{
						/*Error: Could not find block for branch target IL_0009*/;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000774")]
		public int PivotPresetIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60034C6")]
			[Cpp2IlInjected.Address(RVA = "0xF3F240", Offset = "0xF3DC40", VA = "0x180F3F240")]
			get
			{
				//IL_0013: Expected O, but got I4
				Transform transform = base.transform;
				int num = 0;
				if ((object)transform != null)
				{
				}
				PivotPresetType pivotPreset = ((RectTransform)num).GetPivotPreset();
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x60034C7")]
			[Cpp2IlInjected.Address(RVA = "0xF3F870", Offset = "0xF3E270", VA = "0x180F3F870")]
			set
			{
				Transform transform = base.transform;
				int num = 0;
				if ((object)transform == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000775")]
		public int AnchorPresetIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60034C8")]
			[Cpp2IlInjected.Address(RVA = "0xF3EFB0", Offset = "0xF3D9B0", VA = "0x180F3EFB0")]
			get
			{
				//IL_0013: Expected O, but got I4
				Transform transform = base.transform;
				int num = 0;
				if ((object)transform != null)
				{
				}
				AnchorPresetType anchorPreset = ((RectTransform)num).GetAnchorPreset();
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x60034C9")]
			[Cpp2IlInjected.Address(RVA = "0xF3F4C0", Offset = "0xF3DEC0", VA = "0x180F3F4C0")]
			set
			{
				Transform transform = base.transform;
				int num = 0;
				if ((object)transform == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000776")]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x60034CA")]
			[Cpp2IlInjected.Address(RVA = "0xF3F3E0", Offset = "0xF3DDE0", VA = "0x180F3F3E0")]
			get
			{
				Transform transform = base.transform;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60034CB")]
			[Cpp2IlInjected.Address(RVA = "0xF3FAF0", Offset = "0xF3E4F0", VA = "0x180F3FAF0")]
			set
			{
				//Discarded unreachable code: IL_0015
				Transform transform = base.transform;
				int num = 0;
				if ((object)transform != null)
				{
				}
				Transform transform2 = base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000777")]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x60034CC")]
			[Cpp2IlInjected.Address(RVA = "0xF3F450", Offset = "0xF3DE50", VA = "0x180F3F450")]
			get
			{
				Transform transform = base.transform;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60034CD")]
			[Cpp2IlInjected.Address(RVA = "0xF3FBE0", Offset = "0xF3E5E0", VA = "0x180F3FBE0")]
			set
			{
				//Discarded unreachable code: IL_0015
				Transform transform = base.transform;
				int num = 0;
				if ((object)transform != null)
				{
				}
				Transform transform2 = base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000778")]
		public float Width
		{
			[Cpp2IlInjected.Token(Token = "0x60034CE")]
			[Cpp2IlInjected.Address(RVA = "0xF3F370", Offset = "0xF3DD70", VA = "0x180F3F370")]
			get
			{
				Transform transform = base.transform;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60034CF")]
			[Cpp2IlInjected.Address(RVA = "0xF3FA00", Offset = "0xF3E400", VA = "0x180F3FA00")]
			set
			{
				//Discarded unreachable code: IL_0015
				Transform transform = base.transform;
				int num = 0;
				if ((object)transform != null)
				{
				}
				Transform transform2 = base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000779")]
		public float Height
		{
			[Cpp2IlInjected.Token(Token = "0x60034D0")]
			[Cpp2IlInjected.Address(RVA = "0xF3F010", Offset = "0xF3DA10", VA = "0x180F3F010")]
			get
			{
				Transform transform = base.transform;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60034D1")]
			[Cpp2IlInjected.Address(RVA = "0xF3F530", Offset = "0xF3DF30", VA = "0x180F3F530")]
			set
			{
				//Discarded unreachable code: IL_0015
				Transform transform = base.transform;
				int num = 0;
				if ((object)transform != null)
				{
				}
				Transform transform2 = base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077A")]
		public float ScaleXY
		{
			[Cpp2IlInjected.Token(Token = "0x60034D2")]
			[Cpp2IlInjected.Address(RVA = "0xF3F300", Offset = "0xF3DD00", VA = "0x180F3F300")]
			get
			{
				Transform transform = base.transform;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60034D3")]
			[Cpp2IlInjected.Address(RVA = "0xF3F8E0", Offset = "0xF3E2E0", VA = "0x180F3F8E0")]
			set
			{
				//Discarded unreachable code: IL_0010
				Transform transform = base.transform;
				int num = 0;
				if ((object)transform != null)
				{
				}
				int num2 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077B")]
		public float SizeXY
		{
			[Cpp2IlInjected.Token(Token = "0x60034D4")]
			[Cpp2IlInjected.Address(RVA = "0xF3F370", Offset = "0xF3DD70", VA = "0x180F3F370")]
			get
			{
				Transform transform = base.transform;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60034D5")]
			[Cpp2IlInjected.Address(RVA = "0xF3F980", Offset = "0xF3E380", VA = "0x180F3F980")]
			set
			{
				//Discarded unreachable code: IL_000e
				Transform transform = base.transform;
				int num = 0;
				if ((object)transform == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077C")]
		public float OffSetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60034D6")]
			[Cpp2IlInjected.Address(RVA = "0xF3F0F0", Offset = "0xF3DAF0", VA = "0x180F3F0F0")]
			get
			{
				Transform transform = base.transform;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60034D7")]
			[Cpp2IlInjected.Address(RVA = "0xF3F6B0", Offset = "0xF3E0B0", VA = "0x180F3F6B0")]
			set
			{
				//Discarded unreachable code: IL_000a
				Transform transform = base.transform;
				int num = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077D")]
		public float OffSetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60034D8")]
			[Cpp2IlInjected.Address(RVA = "0xF3F160", Offset = "0xF3DB60", VA = "0x180F3F160")]
			get
			{
				Transform transform = base.transform;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60034D9")]
			[Cpp2IlInjected.Address(RVA = "0xF3F740", Offset = "0xF3E140", VA = "0x180F3F740")]
			set
			{
				//Discarded unreachable code: IL_000a
				Transform transform = base.transform;
				int num = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077E")]
		public float OffSetTop
		{
			[Cpp2IlInjected.Token(Token = "0x60034DA")]
			[Cpp2IlInjected.Address(RVA = "0xF3F1D0", Offset = "0xF3DBD0", VA = "0x180F3F1D0")]
			get
			{
				Transform transform = base.transform;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60034DB")]
			[Cpp2IlInjected.Address(RVA = "0xF3F7E0", Offset = "0xF3E1E0", VA = "0x180F3F7E0")]
			set
			{
				//Discarded unreachable code: IL_000a
				Transform transform = base.transform;
				int num = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700077F")]
		public float OffSetBottom
		{
			[Cpp2IlInjected.Token(Token = "0x60034DC")]
			[Cpp2IlInjected.Address(RVA = "0xF3F080", Offset = "0xF3DA80", VA = "0x180F3F080")]
			get
			{
				Transform transform = base.transform;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x60034DD")]
			[Cpp2IlInjected.Address(RVA = "0xF3F620", Offset = "0xF3E020", VA = "0x180F3F620")]
			set
			{
				//Discarded unreachable code: IL_000a
				Transform transform = base.transform;
				int num = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034DE")]
		[Cpp2IlInjected.Address(RVA = "0xF3EDC0", Offset = "0xF3D7C0", VA = "0x180F3EDC0")]
		public void SetStretchAll()
		{
			//Discarded unreachable code: IL_001a
			Transform transform = base.transform;
			int num = 0;
			if ((object)transform != null)
			{
			}
			int num2 = 0;
			int num3 = 0;
			(Vector2, Vector2) stretchAll = AnchorPresets.StretchAll;
		}

		[Cpp2IlInjected.Token(Token = "0x60034DF")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public RectTransformHelper()
		{
		}
	}
}
