﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Land.Core.Lexing;

namespace Land.Core.Parsing.Tree
{
	public abstract class BaseTreeVisitor: MarshalByRefObject
	{
		public virtual void Visit(Node node)
		{
			foreach (var child in node.Children)
				child.Accept(this);
		}

		public override object InitializeLifetimeService() => null;
	}
}
