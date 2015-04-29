
using Template.Business.Interface.Domain;
using Template.Business.Interface.Factory;
using Template.DomainInterface;

namespace Template.Business
{
    using Template.Business.DTO;
    using Template.Business.Interface.Repository;

    public class StateFactory : IDomainFactory
    {
        private IRepository<StateDto> repo;

        public StateFactory(IRepository<StateDto> repo)
        {
            this.repo = repo;
        }


        #region Implementation of IDomainFactory

        public IDomainObject CreateDomainObject(object id)
        {
            var stateDto = this.repo.Get(id);

            var state = new State(repo, stateDto);

            return (IDomainObject)state;
        }


        public IDomainObject CreateDomainObject()
        {
            

            var state = new State();

            return (IDomainObject)state;
        }

        #endregion
    }
}
