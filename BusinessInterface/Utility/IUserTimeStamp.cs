// <copyright file="ITimeStamp.cs" company="CHS">
// Created By: Shrestha, Sharad
//  © 2015 CHS Inc.
// </copyright>
namespace Template.Busines.Interface.Utility
{
    using System;

    public interface IUserTimeStamp
    {
        string CreatedBy { get; set; }

        DateTime? CreatedDate { get; set; }

        string UpdatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }
    }
}