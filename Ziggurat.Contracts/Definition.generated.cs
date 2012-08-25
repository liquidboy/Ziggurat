// ----------------------------------------------------------------------------------------------------
// This code is generated based on *.dsl file.
// Do not edit this file. Edit *.dls files instead.
// ----------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ziggurat.Contracts.Definition
{
	[Serializable, DataContract]
	public sealed partial class CreateProject : ICommand
	{
		[DataMember(Order = 0 )] public Guid Id { get; set; }
		[DataMember(Order = 1 )] public string Name { get; set; }
		[DataMember(Order = 2 )] public string ShortName { get; set; }

		public CreateProject() { }
		public CreateProject(Guid id, string name, string shortName)
		{
			Id = id;
			Name = name;
			ShortName = shortName;
		}
	}

	[Serializable, DataContract]
	public sealed partial class ProjectCreated : IEvent
	{
		[DataMember(Order = 0 )] public Guid Id { get; set; }
		[DataMember(Order = 1 )] public Guid ProjectLayoutId { get; set; }
		[DataMember(Order = 2 )] public string Name { get; set; }
		[DataMember(Order = 3 )] public string ShortName { get; set; }

		public ProjectCreated() { }
		public ProjectCreated(Guid id, Guid projectLayoutId, string name, string shortName)
		{
			Id = id;
			ProjectLayoutId = projectLayoutId;
			Name = name;
			ShortName = shortName;
		}
	}

	[Serializable, DataContract]
	public sealed partial class CreateProjectLayout : ICommand
	{
		[DataMember(Order = 0 )] public Guid ProjectId { get; set; }
		[DataMember(Order = 1 )] public Guid Id { get; set; }

		public CreateProjectLayout() { }
		public CreateProjectLayout(Guid projectId, Guid id)
		{
			ProjectId = projectId;
			Id = id;
		}
	}

	[Serializable, DataContract]
	public sealed partial class ProjectLayoutCreated : IEvent
	{
		[DataMember(Order = 0 )] public Guid ProjectId { get; set; }
		[DataMember(Order = 1 )] public Guid Id { get; set; }

		public ProjectLayoutCreated() { }
		public ProjectLayoutCreated(Guid projectId, Guid id)
		{
			ProjectId = projectId;
			Id = id;
		}
	}

	[Serializable, DataContract]
	public sealed partial class AddFormToProject : ICommand
	{
		[DataMember(Order = 0 )] public Guid ProjectId { get; set; }
		[DataMember(Order = 1 )] public Guid FormId { get; set; }

		public AddFormToProject() { }
		public AddFormToProject(Guid projectId, Guid formId)
		{
			ProjectId = projectId;
			FormId = formId;
		}
	}

	[Serializable, DataContract]
	public sealed partial class FormAddedToProject : IEvent
	{
		[DataMember(Order = 0 )] public Guid ProjectId { get; set; }
		[DataMember(Order = 1 )] public Guid ProjectLayoutId { get; set; }
		[DataMember(Order = 2 )] public Guid FormId { get; set; }
		[DataMember(Order = 3 )] public string BlockHeaderName { get; set; }

		public FormAddedToProject() { }
		public FormAddedToProject(Guid projectId, Guid projectLayoutId, Guid formId, string blockHeaderName)
		{
			ProjectId = projectId;
			ProjectLayoutId = projectLayoutId;
			FormId = formId;
			BlockHeaderName = blockHeaderName;
		}
	}

	[Serializable, DataContract]
	public sealed partial class CreateForm : ICommand
	{
		[DataMember(Order = 0 )] public Guid ProjectId { get; set; }
		[DataMember(Order = 1 )] public Guid Id { get; set; }
		[DataMember(Order = 2 )] public string Name { get; set; }
		[DataMember(Order = 3 )] public string UniqueName { get; set; }

		public CreateForm() { }
		public CreateForm(Guid projectId, Guid id, string name, string uniqueName)
		{
			ProjectId = projectId;
			Id = id;
			Name = name;
			UniqueName = uniqueName;
		}
	}

	[Serializable, DataContract]
	public sealed partial class FormCreated : IEvent
	{
		[DataMember(Order = 0 )] public Guid ProjectId { get; set; }
		[DataMember(Order = 1 )] public Guid Id { get; set; }
		[DataMember(Order = 2 )] public string Name { get; set; }
		[DataMember(Order = 3 )] public string UniqueName { get; set; }

		public FormCreated() { }
		public FormCreated(Guid projectId, Guid id, string name, string uniqueName)
		{
			ProjectId = projectId;
			Id = id;
			Name = name;
			UniqueName = uniqueName;
		}
	}

	[Serializable, DataContract]
	public sealed partial class CreateProperty : ICommand
	{
		[DataMember(Order = 0 )] public Guid FormId { get; set; }
		[DataMember(Order = 1 )] public Guid PropertyId { get; set; }
		[DataMember(Order = 2 )] public PropertyType Type { get; set; }
		[DataMember(Order = 3 )] public string Name { get; set; }

		public CreateProperty() { }
		public CreateProperty(Guid formId, Guid propertyId, PropertyType type, string name)
		{
			FormId = formId;
			PropertyId = propertyId;
			Type = type;
			Name = name;
		}
	}

	[Serializable, DataContract]
	public sealed partial class PropertyCreated : IEvent
	{
		[DataMember(Order = 0 )] public Guid FormId { get; set; }
		[DataMember(Order = 1 )] public Guid PropertyId { get; set; }
		[DataMember(Order = 2 )] public PropertyType Type { get; set; }
		[DataMember(Order = 3 )] public string Name { get; set; }

		public PropertyCreated() { }
		public PropertyCreated(Guid formId, Guid propertyId, PropertyType type, string name)
		{
			FormId = formId;
			PropertyId = propertyId;
			Type = type;
			Name = name;
		}
	}

	[Serializable, DataContract]
	public sealed partial class MakePropertyUnused : ICommand
	{
		[DataMember(Order = 0 )] public Guid FormId { get; set; }
		[DataMember(Order = 1 )] public Guid PropertyId { get; set; }

		public MakePropertyUnused() { }
		public MakePropertyUnused(Guid formId, Guid propertyId)
		{
			FormId = formId;
			PropertyId = propertyId;
		}
	}

	[Serializable, DataContract]
	public sealed partial class MakePropertyUsed : ICommand
	{
		[DataMember(Order = 0 )] public Guid FormId { get; set; }
		[DataMember(Order = 1 )] public Guid PropertyId { get; set; }

		public MakePropertyUsed() { }
		public MakePropertyUsed(Guid formId, Guid propertyId)
		{
			FormId = formId;
			PropertyId = propertyId;
		}
	}

	[Serializable, DataContract]
	public sealed partial class PropertyMadeUnused : IPropertyDefinitionEvent
	{
		[DataMember(Order = 0 )] public Guid FormId { get; set; }
		[DataMember(Order = 1 )] public Guid PropertyId { get; set; }

		public PropertyMadeUnused() { }
		public PropertyMadeUnused(Guid formId, Guid propertyId)
		{
			FormId = formId;
			PropertyId = propertyId;
		}
	}

	[Serializable, DataContract]
	public sealed partial class PropertyMadeUsed : IPropertyDefinitionEvent
	{
		[DataMember(Order = 0 )] public Guid FormId { get; set; }
		[DataMember(Order = 1 )] public Guid PropertyId { get; set; }

		public PropertyMadeUsed() { }
		public PropertyMadeUsed(Guid formId, Guid propertyId)
		{
			FormId = formId;
			PropertyId = propertyId;
		}
	}

}

