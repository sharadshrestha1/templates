// <copyright file="IAddressDto.cs" company="CHS">
// Created By: Shrestha, Sharad
//  © 2015 CHS Inc.
// </copyright>
namespace Template.DomainInterface.DTO
{
    public interface IAddressDto : IDomainDto
    {
        int addressId { get; set; }

        #region Real World Address Properties

        string addressLine1 { get; set; }
        string addressLine2 { get; set; }
        string city { get; set; }
        string state { get; set; }
        string zipCode { get; set; }
        string zipCodePlus { get; set; }

        #endregion

        /// <summary>
        /// Type of Address in integer. eg Home = 1, Business = 2
        /// </summary>
        int? addressTypeId { get; set; }


        /// <summary>
        /// Relational Field. CustomerID to whom the Address would belong to
        /// </summary>
        int? customerId { get; set; }

        /// <summary>
        /// Relational Field. Some other id field
        /// </summary>
        int? AddressModeID { get; set; } 
    }
}