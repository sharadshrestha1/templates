// <copyright file="IStateDto.cs" company="CHS">
// Created By: Shrestha, Sharad
//  © 2015 CHS Inc.
// </copyright>
namespace Template.DomainInterface.DTO
{
    public interface IStateDto : IDomainDto
    {
        string ID { get; set; }
        string DESCR { get; set; } 
    }
}