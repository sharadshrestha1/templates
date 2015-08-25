using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


using Template.Utilities;
using Template.DomainInterface;
using Template.DomainInterface.Enums;


namespace Template.Business
{
    [Serializable]
    public class Phone //: DomainBase //, IPhone, IDomainObject
    {
        protected internal Phone()
        {
            
        }

        //#region Constructor

        //[InjectionConstructor]
        //public Phone()
        //{
        //    IsOneToOneWithMaster = false;
        //    HasChildEntities = false;
        //}

        ///// <summary>
        ///// If you have an ID, the phone already exists so get it from the database
        ///// </summary>
        ///// <param name="id">ID to get the phone</param>
        //public Phone(int id)
        //{
        //     GetEntityById(id);
        //}

        //public Phone(int id, bool useMasterId)
        //{
        //    if (useMasterId)
        //       GetEntityByMasterId(id);
        //    else
        //       GetEntityById(id);
        //}

        //#endregion

        //#region Properties

        ///// <summary>
        ///// get or set for MarkedPhone. Property comes in handy when using this(phone) is bound to a grid and needs checked or marked
        ///// </summary>
        //public bool MarkedPhone { get; set; }

       
        //public IRepository<IPhone> Repository
        //{
        //    get { return GetContainer<IPhone>("phoneRepository");  }
        //}

        //#endregion

        //#region IPhone Members

      
        //public int? customerId { get; set; }
        //public string notes { get; set; }
        //public int phoneId { get; set; }
        //public string phoneNumber { get; set; }
        //public int? phoneTypeId { get; set; }
       
        //public int? CustomerEntityTypeID { get; set; }
        //public int? PhoneHolderID { get; set; }
        
        //#endregion

        //#region Methods
        //public Customer GetCustomerEntity(List<Customer> PhoneHolders)
        //{
        //    //Some really cookoo logic of return the first customer from List of customers
        //    //But hey! that could be a business logic
        //    return PhoneHolders.First();
        //}

        //public IDomainObject GetEntityById(int id)
        //{
        //    var phone = Repository.GetEntityById(id);

        //    if (phone != null)
        //    {
        //        phone.MapClass(this);
        //        return this;
        //    }
           
        //    return null;
            
        //}

        //public IDomainObject GetEntityByMasterId(int masterId)
        //{
        //    var phone = Repository.GetEntityByMasterId(masterId);

        //    if (phone != null)
        //    {
        //        phone.MapClass(this);
        //        return this;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //#endregion

        //#region IDomainObject

        //public override int BusinessEntityID
        //{
        //    get { return phoneId; }
        //}

        //public override void Update()
        //{
        //    Repository.Update(this);
        //}

        //public override void AddToDb()
        //{
        //    this.phoneId = Repository.Add(this);
        //}

        //public override void Delete()
        //{
        //    Repository.Remove(this.phoneId);
        //}

        //#endregion
    }
}
