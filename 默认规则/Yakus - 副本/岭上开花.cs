﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 日本麻将.Yakus {
	public class 岭上开花 : Yaku {
		public override int OrderIndex => 3;

		public override YakuType Type => YakuType.环境;

		protected internal override bool Test(ICollection<YakuValue> result, Tile[] tiles, IGroups groups, YakuEnvironment env) {
			if ((env & YakuEnvironment.岭上开花) == 0) return false;
			result.Add(YakuValue.FromFanValue("岭上开花", 1));
			return true;
		}
	}
}
