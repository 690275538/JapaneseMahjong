﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 日本麻将.Yakus {
	public sealed class 小三元 : Yaku {
		public override int OrderIndex => 20;

		public override YakuType Type => YakuType.None;

		protected internal override bool FilterTest(int junkoCount, int pungCount) {
			return pungCount >= 2;
		}

		protected internal override bool FilterTest(int[] kindCountsFromTiles, int[] kindCounts, int[] kindCountsWithoutPair) {
			return kindCounts[3] >= 3 && kindCountsWithoutPair[3] >= 2;
		}

		protected internal override bool Test(ICollection<YakuValue> result, Tile[] tiles, IGroups groups, YakuEnvironment env) {
			const KanjiTile.Kanji cmp = KanjiTile.Kanji.白 | KanjiTile.Kanji.发 | KanjiTile.Kanji.中;
			if (!(groups.Pair.Key is KanjiTile t) || (t.Value & cmp) == 0) return false;
			int count = groups.PungList.Count(g => g.Key is KanjiTile t2 && (t2.Value & cmp) != 0);
			if (count < 2) return false;
			result.Add(YakuValue.FromFanValue("小三元", 2));
			return true;
		}
	}
}
