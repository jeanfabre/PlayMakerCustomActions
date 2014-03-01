// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Time)]
	[Tooltip("Scales time: 1 = normal, 0.5 = half speed, 2 = double speed.")]
	public class SetTimeScale : FsmStateAction
	{
		[RequiredField]
		[HasFloatSlider(0,4)]
		[Tooltip("Scales time: 1 = normal, 0.5 = half speed, 2 = double speed.")]
		public FsmFloat timeScale;

		[Tooltip("Repeat every frame. Useful when animating the value.")]
		public bool everyFrame;

		public override void Reset()
		{
			timeScale = 1.0f;
			everyFrame = false;
		}
		
		public override void OnEnter()
		{
			DoTimeScale();
			
			if (!everyFrame)
			{
				Finish();
			}
		}
		public override void OnUpdate()
		{
			DoTimeScale();
		}
		
		void DoTimeScale()
		{
			Time.timeScale = timeScale.Value;
		}
	}
}