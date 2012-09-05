﻿using System;
using System.Text.RegularExpressions;
using Ziggurat.Contracts;
using Ziggurat.Contracts.Definition;
using Ziggurat.Infrastructure;

namespace Ziggurat.Definition.Domain.Project
{
    public sealed class ProjectAggregate : AggregateRootBase<ProjectState>
    {
        public void Create(Guid id, string name, string shortName)
        {
            if (State.Id != Guid.Empty) throw new InvalidOperationException("Project already created");

            EnsureShortName(shortName);

            var projectLayoutId = DefinitionIdGenerator.NewProjectLayoutId(id);

            Apply(new ProjectCreated(id, projectLayoutId, name, shortName));
        }


        public void AddForm(Guid formId)
        {
            //business logic: forms restriction, etc

            Apply(new FormAddedToProject(State.Id, State.LayoutId, formId));
        }

        private void EnsureShortName(string shortName)
        {
            if (!Regex.IsMatch(shortName, @"^\w+$")) throw new ArgumentException("shortName can only contain letters and digits", "shortName");
            if (shortName.Length > 20) throw new ArgumentException("shortName length cannot be more than 20 chars", "shortName");
        }
    }
}
