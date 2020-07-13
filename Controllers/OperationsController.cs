using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ASP.NETCorePresentation.Models;
using ASP.NETCorePresentation.Services;
using Microsoft.AspNetCore.Mvc;


namespace ASP.NETCorePresentation.Controllers
{
    [ApiController]
    [Route("operations")]
    public class OperationsController : Controller
    {
        private readonly OperationService _operationService;
        private readonly IOperationTransient _transientOperation;
        private readonly IOperationScoped _scopedOperation;
        private readonly IOperationSingleton _singletonOperation;
        private readonly IOperationSingletonInstance _operationSingletonInstance;

        public OperationsController(OperationService operationService,
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation,
            IOperationSingletonInstance operationSingletonInstance)
        {
            _operationService = operationService;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            _operationSingletonInstance = operationSingletonInstance;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var tempList = new[]
            {
                new OperationResult("Transient Controller", _transientOperation.OperationId),
                new OperationResult("Scoped Controller", _scopedOperation.OperationId),
                new OperationResult("Singleton Controller", _singletonOperation.OperationId),

                new OperationResult("Transient Service", _operationService.TransientOperation.OperationId),
                new OperationResult("Scoped Service", _operationService.ScopedOperation.OperationId),
                new OperationResult("Singleton Service", _operationService.SingletonOperation.OperationId)
            };

            return Ok(tempList);
        }
    }
}
