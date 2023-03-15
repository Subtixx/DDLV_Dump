using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Systems;
using Mdl.Utils;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[Category("Mdl/Request")]
	[Icon("Dialogue", false, "")]
	public class Converse : MdlActionTask<Character>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private BBParameter<System.Threading.Tasks.Task> task;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x10F9C40", Offset = "0x10F8640", VA = "0x1810F9C40", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0030
			((object)this)._002Ector();
			BBParameter<System.Threading.Tasks.Task> bBParameter = this.task;
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			Character character = (Character)(object)((MdlActionTask<T>)(object)this).agent;
			System.Threading.Tasks.Task task = (System.Threading.Tasks.Task)(((BBParameter<T>)(object)bBParameter).value = (T)system.SetCharacterReadyForConversation(character, ready: true));
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x10F9DE0", Offset = "0x10F87E0", VA = "0x1810F9DE0", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_0027, IL_0066
			do
			{
				((object)this)._002Ector();
				System.Threading.Tasks.Task value = (System.Threading.Tasks.Task)((BBParameter<T>)(object)task).value;
				if (value != null && value.IsCompletedSuccessfully())
				{
					EndAction(success: true);
					return;
				}
			}
			while (((BBParameter<T>)(object)task).value != null && !((System.Threading.Tasks.Task)((BBParameter<T>)(object)task).value).IsCanceled && !((System.Threading.Tasks.Task)((BBParameter<T>)(object)task).value).IsFaulted);
			int success = 0;
			EndAction((byte)success != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x10F9D80", Offset = "0x10F8780", VA = "0x1810F9D80", Slot = "16")]
		protected override void OnStop()
		{
			//Discarded unreachable code: IL_0017
			//IL_0016: Expected O, but got I4
			((object)this)._002Ector();
			BBParameter<System.Threading.Tasks.Task> bBParameter = task;
			int num = 0;
			((BBParameter<T>)(object)bBParameter).value = (T)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x10F9EF0", Offset = "0x10F88F0", VA = "0x1810F9EF0")]
		public Converse()
		{
			((MdlActionTask<T>)(object)this)._002Ector();
		}
	}
}
