using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotResolve;

public class DnsClient
{
    public async ValueTask<DnsAnswer> Query(
        DnsQuery query,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
