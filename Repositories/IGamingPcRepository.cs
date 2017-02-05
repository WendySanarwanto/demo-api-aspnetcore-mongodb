using System.Collections.Generic;

using com.wendysa.apidemo.Models;

namespace com.wendysa.apidemo.Repositories {
    public interface IGamingPcRepository {
        IEnumerable<GamingPc> getAll(int limit);
    }
}