// <copyright file="DtoBase.cs" company="CHS">
// Created By: Shrestha, Sharad
//  © 2015 CHS Inc.
// </copyright>
using Template.Business.Interface.Repository;
namespace Template.Business.DTO
{
     public abstract class DtoBase<T> where T: class
     {
         private T tDerived;

        //This should be fine in .NET 4 or higher cause of covariance
        public virtual IRepository<T> Repository { get; set; }
		
        public object Id { get; set; }

        public bool IsHydrated { get; set; }
        

        public void Persist()
        {
            if (this.Id != null)
            {
                this.Repository.Update(tDerived);
            }
            else
            {
                this.Repository.Insert(tDerived);
            }
            
            this.Repository.SaveChanges();
        }

        protected void Delete()
        {
            Repository.Delete(tDerived);
        }

    }
}