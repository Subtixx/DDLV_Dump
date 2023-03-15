using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Gestures;
using Mdl.InputSystem;
using Meta.Util;
using UnityEngine;

namespace Mdl.Navigation.ControlSchemes
{
	[Cpp2IlInjected.Token(Token = "0x2000C9B")]
	public interface IControlScheme
	{
		[Cpp2IlInjected.Token(Token = "0x170007DD")]
		bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x6003A80")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003A81")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170007DE")]
		ControlSchemeType ControlSchemeType
		{
			[Cpp2IlInjected.Token(Token = "0x6003A82")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170007DF")]
		bool IsMaxUnzoom
		{
			[Cpp2IlInjected.Token(Token = "0x6003A83")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170007E0")]
		bool ShouldDisplayCursor
		{
			[Cpp2IlInjected.Token(Token = "0x6003A84")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170007E1")]
		bool RequiresInteractionAngle
		{
			[Cpp2IlInjected.Token(Token = "0x6003A85")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170007E2")]
		bool AutomaticRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6003A86")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170007E3")]
		bool HasCameraTransition
		{
			[Cpp2IlInjected.Token(Token = "0x6003A87")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6003A88")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Init(Camera camera, PlayerAvatar avatar, PlayerNavigationConfig playerConfig, Transform initialCamera, CameraNavigationConfig cameraConfig);

		[Cpp2IlInjected.Token(Token = "0x6003A89")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void MoveAvatar(float deltaTime, InputAction inputMoveAxes, bool controlsOverridden);

		[Cpp2IlInjected.Token(Token = "0x6003A8A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void MoveCamera(float deltaTime, MoveGesture move, bool controlsOverridden);

		[Cpp2IlInjected.Token(Token = "0x6003A8B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void MoveCamera(float deltaTime, InputAction panAction, InputAction rotateAction, InputAction zoomAction, bool controlsOverridden);

		[Cpp2IlInjected.Token(Token = "0x6003A8C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x6003A8D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ResetCameraPosition([Optional] float? offsetYaw, [Optional] float? offsetPitch, [Optional] float? transitionDuration);

		[Cpp2IlInjected.Token(Token = "0x6003A8E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void UpdateCameraTransition(float deltaTime);

		[Cpp2IlInjected.Token(Token = "0x6003A8F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void UpdateAvatarAnimatorParameters(Vector2 moveInput, ref bool move, ref float run);

		[Cpp2IlInjected.Token(Token = "0x6003A90")]
		[Cpp2IlInjected.Address(Slot = "16")]
		(Vector3, Quaternion) GetCameraDesiredPositionAndRotation();

		[Cpp2IlInjected.Token(Token = "0x6003A91")]
		[Cpp2IlInjected.Address(Slot = "17")]
		float DesiredPitch(CameraNavigationConfig currentCameraConfig);

		[Cpp2IlInjected.Token(Token = "0x6003A92")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Vector3 GetAvatarFacingDirection();

		[Cpp2IlInjected.Token(Token = "0x6003A93")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void UpdateDesiredFacingFromAvatar();

		[Cpp2IlInjected.Token(Token = "0x6003A94")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void DebugTrace();
	}
}
