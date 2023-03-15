using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000477")]
	public class NewGridObjectEventArgs : EventArgs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001C55")]
		public readonly GridScript gridScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001C56")]
		public readonly GridObject gridObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001C57")]
		public readonly GameObject gameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001C58")]
		public readonly GridAddObjectOptions addObjectOptions;

		[Cpp2IlInjected.Token(Token = "0x6001399")]
		[Cpp2IlInjected.Address(RVA = "0xF03180", Offset = "0xF01B80", VA = "0x180F03180")]
		public NewGridObjectEventArgs(GridScript gridScript, GridObject gridObject, GameObject gameObject, [Optional] GridAddObjectOptions addObjectOptions)
		{
			//IL_0022: Expected O, but got I4
			this.gridScript = gridScript;
			this.gridObject = gridObject;
			this.gameObject = gameObject;
			this.addObjectOptions = (GridAddObjectOptions)0;
			/*Error: Unexpected end of block*/;
		}
	}
}
