using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Grid;
using Gameloft.Common;
using Mdl.Grid;
using Meta.Grids;
using UnityEngine;

namespace Mdl.Furnitures
{
	[Cpp2IlInjected.Token(Token = "0x200056A")]
	public class PictureFrame : GridObjectStateUser
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400218D")]
		public List<Renderer> PictureRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400218E")]
		private Texture2D picture;

		[Cpp2IlInjected.Token(Token = "0x600183A")]
		[Cpp2IlInjected.Address(RVA = "0xF12AB0", Offset = "0xF114B0", VA = "0x180F12AB0", Slot = "7")]
		protected override void InitWithGridObject(GridObject gridObject)
		{
			//Discarded unreachable code: IL_002c
			GridState state_ = gridObject.state_;
			if (state_ != null && state_.PictureFrameGridData != null)
			{
				PictureFrameGridData pictureFrameGridData = gridObject.state_.PictureFrameGridData;
				int num = 0;
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600183B")]
		[Cpp2IlInjected.Address(RVA = "0xF12980", Offset = "0xF11380", VA = "0x180F12980")]
		[AsyncStateMachine(typeof(_003CInitPictureFrame_003Ed__3))]
		private Task InitPictureFrame(PictureFrameGridData pictureFrameGridData)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600183C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public PictureFrame()
		{
		}
	}
}
