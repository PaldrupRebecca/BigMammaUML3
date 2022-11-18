using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public abstract class MenuItem : IMenuItem
    {
		private int _number;

		public int Number
		{
			get { return _number; }
			
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private double _price;

		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}

		private MenuType _type;

		public MenuType Type
		{
			get { return _type; }
			set { _type = value; }
		}

		private bool _isVegan;

		public bool IsVegan
		{
			get { return _isVegan; }
			set { _isVegan = value; }
		}

		private bool _isOrganic;

		public bool IsOrganic
		{
			get { return _isOrganic; }
			set { _isOrganic = value; }
		}

		public MenuItem(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic)
		{
			_number = number;
			_name = name;
			_description = description;
			_price = price;
			_type = type;
			_isVegan = isVegan;
			_isOrganic = isOrganic;
		}

		public virtual string PrintInfo()
		{
			return $"Number: {_number}\nName: {_name}\nDescription: {_description}\nPrice: {_price}\nMenu type: {_type}\nIs it vegan? {_isVegan}\nIs it organic? {_isOrganic}";
		}
	}
}
