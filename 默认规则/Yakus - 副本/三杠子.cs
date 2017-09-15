﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 日本麻将.Yakus {
	public sealed class 三杠子 : Yaku {
		public override int OrderIndex => 17;

		public override YakuType Type => YakuType.None;

		protected internal override bool FilterTest(int junkoCount, int pungCount) {
			return pungCount >= 3;
		}

		protected internal override bool Test(ICollection<YakuValue> result, Tile[] tiles, IGroups groups, YakuEnvironment env) {
			int count = groups.PungList.Count(g => g is Gan);
			if (count < 3) return false;
			result.Add(YakuValue.FromFanValue("三杠子", 2));
			return true;
		}
	}
}
