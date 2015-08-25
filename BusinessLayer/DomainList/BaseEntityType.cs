using System;
using System.Collections.Generic;
using Template.DomainInterface;
 

namespace Template.Business
{
	/// <summary>
	/// BaseEntityType abstract class for getting entity types that are unique in nature
	/// This base class implements IDisposible
	/// Entity Type would be some elements as Address Type [Residential, Business] or  Phone Type [mobile, home, work]
	/// </summary>
	[Serializable]
	public abstract class BaseEntityType : IDisposable
	{
		public abstract int ID { get; }
		public abstract string DisplayText { get; }

		public abstract IList<BaseEntityType> GetList();

		/// <summary>
		/// Common List Getter for all EntityTypes that inherits from BaseEntityType
		/// </summary>
		//public IEntityGetTypes<BaseEntityType> ListGetter
		//{
		//	get
		//	{
		//		var container = GenericSingleton<ComponentContainer>.GetInstance().Container;
		//		return container.Resolve<IEntityGetTypes<BaseEntityType>>("entityTypeList");
				
		//	}
		//}

		#region IDisposable Members

		protected bool disposed;

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					if (this != null)
					{
						disposed = true;
						this.Dispose();
					}
				}
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		#endregion
	}
}
