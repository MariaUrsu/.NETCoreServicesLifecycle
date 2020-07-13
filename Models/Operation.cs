using System;

namespace ASP.NETCorePresentation.Models
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {
        public Operation() : this(Guid.NewGuid())
        {
        }

        public Guid OperationId { get; }

        public Operation(Guid id)
        {
            OperationId = id;
        }
    }
}