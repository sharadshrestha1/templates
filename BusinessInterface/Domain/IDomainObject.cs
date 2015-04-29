using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.Business.Interface.Domain
{
	/// <summary>
	/// Interface for Product of Abstract Factory 
	/// Interface to be impletemented by BusinessEntities. When IDomainObject is implemented, it comes with 
	/// the overhead of having to implement CRUD operations too
	/// </summary>
    public interface IDomainObject
    {
        /// <summary>
        ///     Gets or sets the Id.
        /// </summary>
        object Id { get; set; }

        bool IsHydrated { get; }

        /// <summary>
        ///     The persist.
        /// </summary>
        void Persist(); 
    }
}
