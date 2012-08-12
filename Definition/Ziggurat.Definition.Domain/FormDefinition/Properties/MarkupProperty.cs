using System;
using Ziggurat.Contracts;

namespace Ziggurat.Definition.Domain.FormDefinition
{
	public sealed class MarkupProperty : PropertyBase
	{
		public override PropertyType Type { get { return PropertyType.Markup; } }

        public MarkupProperty(FormDefinitionAggregate definition, Guid id)
            : base(definition, id) { }
	}
}