// <copyright file="State.cs" company="CHS">
// Created By: Shrestha, Sharad
//  © 2015 CHS Inc.
// </copyright>
namespace Template.Business
{
    using Template.Business.Domain;
    using Template.Business.DTO;
    using Template.Business.Interface.Domain;
    using Template.Business.Interface.Repository;
    

    public class State: DomainBase<StateDto>, IDomainObject
    {
        internal State(IRepository<StateDto> repository, StateDto addressDto) : base(repository, addressDto)
        {
            
        }

        internal State()
        {
            
        }
        public string ID { get; set; }


        public string DESCR { get; set; }

        public  object Id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value.ToString();
            }
        }


        //public  IValidationResult Validate()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}