using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.Business.Interface.Factory
{
    using Template.Business.Interface.Domain;

    /// <summary>
	/// Abstract Factory Interface to create/get an Business Entity
	/// </summary>
    public interface IDomainFactory
    {
        IDomainObject CreateDomainObject(object id);

        IDomainObject CreateDomainObject();
    }
}
