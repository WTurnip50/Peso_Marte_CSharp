using Tecnm.Practica1.Core.Entities;
using Tecnm.Practica1.Core.Services.Interfaces;
using Tecnm.Practica1.Core.Managers.Interfaces;

namespace Tecnm.Practica1.Core.Managers;

public class pmManager : ipmManager{
    private readonly ipmService _service;

    public pmManager(ipmService service){
        _service = service;
    }

    public Result GetResult(Data data){
        return _service.processData(data);
    }
}