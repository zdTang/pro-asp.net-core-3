using System.Collections.Generic;

namespace SimpleApp.Models {
    
    /// <summary>
    ///  This interface is used for unit test
    ///  To isolate the component and seperate the controller from the repository
    /// </summary>
    public interface IDataSource {

        IEnumerable<Product> Products { get; }
    }
}
