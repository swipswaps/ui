﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;

namespace PM.Level {

	public class LevelSetting {

		private string taskDescription;
		private string preCode;
		private string startCode;
		private int rowLimit;
		private int caseCount;
		private string[] smartButtons;
		private Compiler.Function[] functions;

		public LevelSetting (string taskDescription = "", string preCode = "", string startCode = "", int rowLimit = 100, int numberOfCases = 1, string[] smartButtons = null, Compiler.Function[] functions = null){
			this.taskDescription = taskDescription;
			this.preCode = preCode;
			this.startCode = startCode;
			this.rowLimit = rowLimit;
			this.caseCount = numberOfCases;
			this.smartButtons = smartButtons ?? new string[0];
			this.functions = functions ?? new Compiler.Function[0];
		}

		public void UseSettings () {
			PMWrapper.SetTaskDescription (taskDescription);
			PMWrapper.preCode = preCode;
			PMWrapper.AddCodeAtStart (startCode);
			PMWrapper.codeRowsLimit = rowLimit;
			UISingleton.instance.levelHandler.currentLevel.caseHandler = new CaseHandler (caseCount);
			PMWrapper.SetSmartButtons (smartButtons);
			PMWrapper.SetCompilerFunctions (functions);
		}
	}
}