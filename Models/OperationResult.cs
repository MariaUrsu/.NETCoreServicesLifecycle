using System;

namespace ASP.NETCorePresentation.Models
{
    public class OperationResult
    {
        public string Name { get; }
        public Guid OperationId { get;}

        public OperationResult(string name, Guid id)
        {
            Name = name;
            OperationId = id;
        }
    }
}