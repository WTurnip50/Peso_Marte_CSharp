using Tecnm.Practica1.Core.Entities;
using Tecnm.Practica1.Core.Services.Interfaces;

namespace Tecnm.Practica1.Core.Services;

public class pmServices:ipmService{

    public Result processData(Data data){

        var datos = new Result();
        datos.PesoMarte = (float) (data.Peso * 3.7);
        datos.PesoMarte = (float) (datos.PesoMarte / 9.8);
        return datos;
    }
}