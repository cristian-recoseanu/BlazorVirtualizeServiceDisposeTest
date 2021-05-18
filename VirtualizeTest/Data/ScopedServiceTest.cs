using System;
using System.Diagnostics;

namespace VirtualizeTest.Data
{
    public sealed class ScopedServiceTest : IDisposable
    {
        public Guid Id { get; }

        public ScopedServiceTest()
        {
            Id = Guid.NewGuid();
            Debug.WriteLine($"Creating service with id: {Id}");
        }

        public void Dispose()
        {
            Debug.WriteLine($"Disposing service with id: {Id}");
        }
    }
}
