using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Ui;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AddressableAssets;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[Description("Open the stall menu in which player can buy or sell items. \n IsSell: opens the sell part of the menu.")]
	[Category("Mdl/Request")]
	[Icon("Dialogue", false, "")]
	public class OpenStallMenu : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		[RequiredField]
		public BBParameter<bool> IsSell = (BBParameter<bool>)(object)new BBParameter<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AssetReference menuToOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private BBParameter<CancellationTokenSource> cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private System.Threading.Tasks.Task response;

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xF060F0", Offset = "0xF04AF0", VA = "0x180F060F0", Slot = "13")]
		protected override void OnExecute()
		{
			//IL_003e: Expected I4, but got O
			//IL_0051: Expected O, but got I4
			while (true)
			{
				BBParameter<> bBParameter = (BBParameter<>)(object)(cts = (BBParameter<CancellationTokenSource>)(object)BBParameter<T>.op_Implicit((T)new CancellationTokenSource()));
				if ((long)menuToOpen == 0)
				{
					break;
				}
				AssetReference menuAssetReference = menuToOpen;
				BaseUiRoot _003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
				object[] array = new object[1];
				bool flag = (byte)(int)((BBParameter<T>)(object)IsSell).value != 0;
				if (!flag || flag)
				{
					array[0] = flag;
					int isPopup = 0;
					System.Threading.Tasks.Task task = (response = _003CInstance_003Ek__BackingField.OpenMenu(menuAssetReference, (byte)isPopup != 0, waitUntilExit: true, array));
					return;
				}
			}
			int success = 0;
			EndAction((byte)success != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xF063B0", Offset = "0xF04DB0", VA = "0x180F063B0", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_001c
			if (response.IsCompleted)
			{
				EndAction(success: true);
			}
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0xF06340", Offset = "0xF04D40", VA = "0x180F06340", Slot = "16")]
		protected override void OnStop()
		{
			//Discarded unreachable code: IL_0017
			((object)this)._002Ector();
			((CancellationTokenSource)((BBParameter<T>)(object)cts).value).Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xF06400", Offset = "0xF04E00", VA = "0x180F06400")]
		public OpenStallMenu()
		{
		}
	}
}
