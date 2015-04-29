// <copyright file="AddressDto.cs" company="CHS">
// Created By: Shrestha, Sharad
//  © 2015 CHS Inc.
// </copyright>
namespace Template.Business.DTO
{
    using Template.Business.Interface.Domain;
    using Template.Business.Interface.Repository;
    using Template.DomainInterface.DTO;

    public class AddressDto : DtoBase<AddressDto>, IDto, IAddressDto
    {
        public override IRepository<AddressDto> Repository { get; set; }


        #region Implementation of IAddress

        /// <summary>
        /// ID of the address entity
        /// </summary>
        public int addressId { get; set; }

        public string addressLine1 { get; set; }

        public string addressLine2 { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string zipCode { get; set; }

        public string zipCodePlus { get; set; }

        /// <summary>
        /// Type of Address in integer. eg Home = 1, Business = 2
        /// </summary>
        public int? addressTypeId { get; set; }

        /// <summary>
        /// Relational Field. CustomerID to whom the Address would belong to
        /// </summary>
        public int? customerId { get; set; }

        /// <summary>
        /// Relational Field. Some other id field
        /// </summary>
        public int? AddressModeID { get; set; }

        #endregion


 
    }
}