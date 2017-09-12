using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	/// <summary>
	/// Account class properties are inherited by
	/// Savings class, but not the other way around.
	/// </summary>
	public class Account
    {
		public int Number;
		public string Name;
		public double Balance;

		public virtual string ToPrint() {
			return $"{Number}:{Name}-{Balance}";
		}
    }
}
