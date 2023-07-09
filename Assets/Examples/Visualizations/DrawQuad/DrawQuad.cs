using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VidTools;
using VidTools.Vis;
using UnityEngine.InputSystem;

namespace VidTools.Examples
{
	public class DrawQuad : ImmediateAnimation
	{

		[Header("Display Settings")]
		public Vector2 quadPosition;
		public Vector2 quadSize;
		public Color quadColor;

		protected override void UpdateAnimation()
		{
			float quadAnimT = CalculateClipTime(1, Ease.Quadratic.InOut);
			Draw.Quad(quadPosition, quadSize, quadColor, quadAnimT);
			WaitUntilFinished();
		}
	}
}