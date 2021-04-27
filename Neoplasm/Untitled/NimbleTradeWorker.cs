using System;
using System.Collections.Generic;
using System.Text;

namespace Neoplasm.Untitled
{
	public class NimbleTradeWorker: Nimble
	{		

		public NimbleTradeWorker(int userAge, string userName) : base(userAge)
        {
			Age = userAge;
			Name = userName;

        }
	}
}
