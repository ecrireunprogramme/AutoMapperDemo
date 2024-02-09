using AutoMapper;
using AutoMapperDemo.DTOs;
using AutoMapperDemo.Entities;

namespace AutoMapperDemo.Mappings;

public class PathLengthResolver : IValueResolver<Colis, ColisDto, double>
{
    public double Resolve(Colis source, ColisDto destination, double destMember, ResolutionContext context)
    {
        // TODO: implémenter la logique de calcul

        return 10;
    }
}
