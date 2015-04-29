using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.DomainInterface
{
    /// <summary>
	/// IItemList comes handy when using for ListItems controls like dropdownlist or item list
	/// 
    /// </summary>
    public interface IItemList
    {
        /// <summary>
        /// Usually the 'value' that is not displayed but used as keys
        /// </summary>
        int ID { get ;}
        /// <summary>
        /// Text that is displayed 
        /// </summary>
        string Text { get; }
        /// <summary>
        /// Exra information that can be helpful like callouts, title of drop down list, etc.
        /// </summary>
        string Description { get; }
    }
}
