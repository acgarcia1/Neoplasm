using System;
using System.Collections.Generic;
using System.Text;

namespace Neoplasm.Untitled
{
	public interface ICharacter
	{
		int Age
		{
			get;
			set;
		}

		string Name
		{
			get;
			set;
		}

		int Strength
		{
			get;
			set;
		}

		int Speed
		{
			get;
			set;
		}

		int Size
		{
			get;
			set;
		}
	}
}
