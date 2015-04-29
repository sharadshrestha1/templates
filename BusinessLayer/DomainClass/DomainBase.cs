using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Template.Business.Interface.Domain;
using Template.DomainInterface;

namespace Template.Business.Domain
{
    using System.Xml.Schema;

    using Template.Business.DTO;
    using Template.Business.Interface.Repository;
    using Template.ValidationMessaging;

    /// <summary>
    /// Abstract base class that provides the UnityContainer functionality and some
    /// other common attributes for Entity Classes
    /// </summary>
    [Serializable]
    public class DomainBase<TDto> : IDomainObject where TDto : class 
    {
        internal IRepository<TDto> Repository { get; set; }

        public TDto dto;
        protected DomainBase(IRepository<TDto> Repository, TDto dto)
        {
            this.Repository = Repository;
            this.dto = dto;
        }

        protected DomainBase()
        {
            
        }

        //Some ID given to use in client mode 
        public string ClientBehaviorId { get; set; }

        public bool StampDateTime { get; set; }

        public object Id { get; set; }


        public bool IsHydrated
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual void Persist()
        {
            if (this.Id == null)
            {
                Repository.Insert(dto);
            }
            else
            {
                Repository.Update(dto);
            }
            Repository.SaveChanges();
        }
    }
}
