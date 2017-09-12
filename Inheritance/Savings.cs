using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	/// <summary>
	/// Savings class inherits properties of account class
	/// but not the other way around.
	/// </summary>
	public class Savings : Account {
		public double IntRate;
	
	public override string ToPrint() {
		return base.ToPrint() + $"::{IntRate}";
		}
	}
}
