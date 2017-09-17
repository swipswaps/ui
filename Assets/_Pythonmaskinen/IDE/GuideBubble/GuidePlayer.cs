﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PM.Guide {

	public class GuidePlayer : MonoBehaviour, IPMLevelChanged {

		public LevelGuide currentGuide;
		public bool shouldPlayNext = true;

		public void OnPMLevelChanged(){
			currentGuide = GuideLoader.GetCurrentLevelGuide ();
			currentGuide.currentGuideIndex = 0;
			shouldPlayNext = true;
		}

		private void FixedUpdate(){
			if (currentGuide != null) {
				if (shouldPlayNext) {
					currentGuide.PlayNextGuide ();
					shouldPlayNext = false;
				}
			}
		}
	}
}