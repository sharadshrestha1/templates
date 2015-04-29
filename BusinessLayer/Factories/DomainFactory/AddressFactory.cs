
using Template.Business.Interface.Domain;
using Template.Business.Interface.Factory;
using Template.DomainInterface;

namespace Template.Business
{
    using Template.Business.Domain;
    using Template.Business.DTO;
    using Template.Business.Interface.Repository;
    using Template.DomainInterface.DTO;

    public class AddressFactory : IDomainFactory
    {
        private IRepository<AddressDto> repo;

        public AddressFactory(IRepository<AddressDto> repo)
        {
            this.repo =  repo;
        }


        #region Implementation of IDomainFactory

        public IDomainObject CreateDomainObject(object id)
        {
            var addressDto = this.repo.Get(id);

            var address = new Address(this.repo, addressDto);

            return (IDomainObject)address;
        }

        public IDomainObject CreateDomainObject()
        {
            var address = new Address();
            return (IDomainObject)address;

        }

        #endregion
    }
}
