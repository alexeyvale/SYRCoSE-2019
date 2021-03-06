﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Land.Core.Lexing;

namespace Land.Core.Parsing.Tree
{
	public class LeafOptionProcessingVisitor : BaseTreeVisitor
	{
		protected Grammar grammar { get; set; }

		public LeafOptionProcessingVisitor(Grammar g)
		{
			grammar = g;
		}

		public override void Visit(Node node)
		{
			/// Если текущий узел должен быть листовым
			if (node.Options.NodeOption == NodeOption.LEAF || node.Options.NodeOption == null && (grammar.Options.IsSet(NodeOption.LEAF, node.Symbol)
				|| !String.IsNullOrEmpty(node.Alias) && grammar.Options.IsSet(NodeOption.LEAF, node.Alias)))
			{
				node.Value = node.GetValue();

				/// Перед тем, как удалить дочерние узлы, вычисляем соответствие нового листа тексту
				var tmp = node.Location;

				node.Children.Clear();

				if(node.Location != null)
					node.SetLocation(tmp.Start, tmp.End);
			}
			else
				base.Visit(node);
		}
	}
}
