// <copyright file="TimeStamp.cs" company="CHS">
// Created By: Shrestha, Sharad
//  © 2015 CHS Inc.
// </copyright>
using System;
using Template.Busines.Interface.Utility;

namespace Template.Business.Utility
{
    public class UserTimeStamp : IUserTimeStamp
    {
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}