﻿namespace ExchangeRateUpdaterCk.Domain.Mappings;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Dummy, DummyDto>().ReverseMap();
    }
}