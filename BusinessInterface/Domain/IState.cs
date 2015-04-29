// <copyright file="IState.cs" company="CHS">
// Created By: Shrestha, Sharad
//  © 2015 CHS Inc.
// </copyright>
namespace Template.Business.Interface.Domain
{
    using Template.DomainInterface.DTO;

    public interface IState
    {
        IStateDto StateDto { get; set; }
    }
}