// (c) Copyright HutongGames, LLC 2010-2012. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Get a Float Variable square root value")]
	public class FloatSquareRoot : FsmStateAction
	{
		
		public FsmFloat floatVariable;
		
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat result;
		
		public bool everyFrame;

		public override void Reset()
		{
			floatVariable = null;
			result = null;
			
			everyFrame = false;
		}

		public override void OnEnter()
		{
			DoFloatSquareRoot();
			
			if (!everyFrame)
				Finish();
		}

		public override void OnUpdate()
		{
			DoFloatSquareRoot();
		}
		
		void DoFloatSquareRoot()
		{
			if (!result.IsNone)
			{
				result.Value = Mathf.Sqrt(floatVariable.Value);
			}

		}
	}
}