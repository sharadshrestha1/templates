//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//

//using Template.DomainInterface;
//using Template.DomainInterface.Enums;

//namespace Template.Business
//{
//    /// <summary>
//    /// State class that models after US States
//    /// </summary>
//    public class StateTEST:  BaseListClass
//    {
//        /// <summary>
//        /// constructor signature enforced by inheritance.
//        /// base property is populated at the creation of the class
//        /// </summary>
//        /// <param name="id">int ID for the object</param>
//        /// <param name="text">string Text </param>
//        /// <param name="description">string Description</param>
//        public State(int id, string text, string description) : base (id, text, description)
//        {

//        }

//        #region static methods to access state easily

//        /// <summary>
//        /// Quick Static Method to get State List
//        /// </summary>
//        /// <returns></returns>
//        public static List<IItemList> ListAll()
//        {
//            var listManager = BaseListClass.GetListManager();
//            return listManager.GetList<State>();
//        }


//        /// <summary>
//        /// Quick static method to get State by Id
//        /// </summary>
//        /// <param name="id"></param>
//        /// <returns></returns>
//        public static State GetStateById(int id)
//        {
//            return (State)ListAll().Find(st => st.ID == id);
//        }

//        #endregion
//    }
//}
