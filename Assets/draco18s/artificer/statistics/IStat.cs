﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.draco18s.artificer.statistics {
	public interface IStat {
		object serializedValue { get; }
		string description { get; set; }
		int ID { get; set; }
		string statName { get; set; }
		bool isHidden { get; set; }

		string getDisplay();
		void setValue(object v);
		void resetValue();
		bool isGreaterThan(object v);
	}
}
