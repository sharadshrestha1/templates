
using Template.DomainInterface;


namespace Template.Business
{
    public class CustomerFactory  //: IDomainFactory
    {
        //#region IEntityFactory Members

        //private IRepository<ICustomer> repository;
        //private IRepository<ICustomer> Repository
        //{
        //    get
        //    {
        //        if (repository == null)
        //            repository = DomainBase.Container<ICustomer>("customerRepository");

        //        return repository;
        //    }
        //}


        //public CustomerFactory()
        //{

        //}

        //public IDomainObject GetBusinessEntityById(int id)
        //{
        //    IDomainObject customer = new Customer(id);

        //    if (customer.BusinessEntityID != 0)
        //        return customer;
        //    return null;
        //}

        //public IDomainObject GetBusinessEntityByMasterEntityId(int id)
        //{
        //    IDomainObject customer = new Customer(id, true);
        //    if (customer.BusinessEntityID != 0)
        //        return customer;
        //    return null;
        //}

        //public IDomainObject CreateBusinessEntity()
        //{
        //    IDomainObject customer = new Customer();
        //    return customer;
        //}

        //#endregion
    }
}
