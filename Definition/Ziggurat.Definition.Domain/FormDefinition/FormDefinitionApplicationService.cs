﻿using System;
using Ziggurat.Contracts.Definition;
using Ziggurat.Infrastructure.EventStore;

namespace Ziggurat.Definition.Domain.FormDefinition
{
    public sealed class FormDefinitionApplicationService : ApplicationServiceBase<FormDefinitionAggregate>
    {
        public FormDefinitionApplicationService(IEventStore store) : base(store) { }

        public void When(CreateForm cmd)
        {
            if (cmd.FormId == Guid.Empty) throw new ArgumentException("Form ID is required");
            if (String.IsNullOrWhiteSpace(cmd.Name)) throw new ArgumentException("Name is required");
            if (String.IsNullOrWhiteSpace(cmd.UniqueName)) throw new ArgumentNullException("Unique Name is required");

            Update(cmd.FormId, form => form.Create(cmd.ProjectId, cmd.FormId, cmd.Name, cmd.UniqueName));
        }

        public void When(AddNewPropertyToForm cmd)
        {
            if (cmd.FormId == Guid.Empty) throw new ArgumentException("Form ID is required");
            if (String.IsNullOrWhiteSpace(cmd.Name)) throw new ArgumentException("Name is required");

            Update(cmd.FormId, form => form.AddNewProperty(cmd.PropertyId, cmd.Type, cmd.Name));
        }

        public void When(MakePropertyUsed cmd)
        {
            if (cmd.FormId == Guid.Empty) throw new ArgumentException("Form ID is required");
            Update(cmd.FormId, form => form.MakePropertyUsed(cmd.PropertyId));
        }

        public void When(MakePropertyUnused cmd)
        {
            if (cmd.FormId == Guid.Empty) throw new ArgumentException("Form ID is required");
            Update(cmd.FormId, form => form.MakePropertyUnused(cmd.PropertyId));
        }

        public void When(SetFormulaForConcatenationProperty cmd)
        {
            if (cmd.FormId == Guid.Empty) throw new ArgumentException("Form ID is required");
            if (cmd.PropertyId == Guid.Empty) throw new ArgumentException("Property ID is required");

            Update(cmd.FormId, form => form.SetConcatenationFormula(cmd.PropertyId, cmd.Formula));
        }
    }
}
