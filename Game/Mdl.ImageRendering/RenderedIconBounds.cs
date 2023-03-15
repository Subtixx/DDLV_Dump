using System;
using Cpp2IlInjected;
using Mdl.Grid;
using Mdl.Systems;
using Rewired;
using UnityEngine;

namespace Mdl.ImageRendering
{
	[Cpp2IlInjected.Token(Token = "0x20003EB")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(BoxCollider))]
	public class RenderedIconBounds : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000218")]
		public Bounds Bounds
		{
			[Cpp2IlInjected.Token(Token = "0x60010CC")]
			[Cpp2IlInjected.Address(RVA = "0xCC0B40", Offset = "0xCBF540", VA = "0x180CC0B40")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010CD")]
		[Cpp2IlInjected.Address(RVA = "0xCC08D0", Offset = "0xCBF2D0", VA = "0x180CC08D0")]
		private void Start()
		{
			//Discarded unreachable code: IL_006f
			//IL_001c: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				GridEditMode system = _003CInstance_003Ek__BackingField.GetSystem<GridEditMode>();
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				BoxCollider component = GetComponent<BoxCollider>();
				int num3 = ((component.enabled = false) ? 1 : 0);
			}
			int num4 = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Player player = players.GetPlayer(playerId);
			if (player != null)
			{
				Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnAnyButtonPressed);
				int num5 = 0;
				player.AddInputEventDelegate((Action<>)(object)action, (UpdateLoopType)num5, InputActionEventType.ButtonJustPressed);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010CE")]
		[Cpp2IlInjected.Address(RVA = "0xCC0730", Offset = "0xCBF130", VA = "0x180CC0730")]
		private void OnDestroy()
		{
			int num = 0;
			ReInput.PlayerHelper players = ReInput.players;
			if (players != null)
			{
				int playerId = 0;
				Player player = players.GetPlayer(playerId);
				if (player != null)
				{
					Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnAnyButtonPressed);
					player.RemoveInputEventDelegate((Action<>)(object)action);
				}
			}
			Debug.LogWarning("RenderedIconBounds failed to perform: RemoveInputEventDelegate(OnAnyButtonPressed)");
		}

		[Cpp2IlInjected.Token(Token = "0x60010CF")]
		[Cpp2IlInjected.Address(RVA = "0xCC0620", Offset = "0xCBF020", VA = "0x180CC0620")]
		private void OnAnyButtonPressed(InputActionEventData obj)
		{
			//Discarded unreachable code: IL_0035
			GetComponent<BoxCollider>().isTrigger = true;
			int num = 0;
			ReInput.PlayerHelper players = ReInput.players;
			int playerId = 0;
			Player player = players.GetPlayer(playerId);
			Action<InputActionEventData> action = (Action<InputActionEventData>)(object)new Action<T>(OnAnyButtonPressed);
			player.RemoveInputEventDelegate((Action<>)(object)action);
		}

		[Cpp2IlInjected.Token(Token = "0x60010D0")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public RenderedIconBounds()
		{
		}
	}
}
