using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class Pizza : MenuItem
    {
		private bool _isDeepPan;

		public bool IsDeepPan
		{
			get { return _isDeepPan; }
			set { _isDeepPan = value; }
		}

		public Pizza(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool isDeepPan) :base(number, name, description, price, type, isVegan, isOrganic)
		{
			_isDeepPan = isDeepPan;
		}

		public override string PrintInfo()
		{
			return base.PrintInfo() + $"\nIs it deep pan? {IsDeepPan}";
		}
	}
}
