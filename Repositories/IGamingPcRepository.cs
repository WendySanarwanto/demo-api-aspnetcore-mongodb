using System.Collections.Generic;
using System.Threading.Tasks;

using com.wendysa.apidemo.Models;

namespace com.wendysa.apidemo.Repositories {
    public interface IGamingPcRepository {
        Task<IEnumerable<GamingPc>> getAllAsync(int limit);
    }
}