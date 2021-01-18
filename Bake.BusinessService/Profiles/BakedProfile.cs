using AutoMapper;
using Bake.BusinessService.Dtos;
using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Profiles
{
    public class BakedProfile: Profile
    {
        public BakedProfile()
        {
            CreateMap<customer, CustomerReadDto>();
            CreateMap<CustomerCreateDto, customer>();
            CreateMap<CustomerUpdateDto, customer>();
            CreateMap<customer, CustomerUpdateDto>();

            CreateMap<item, ItemReadDto>();
            CreateMap<ItemCreateDto, item>();
            CreateMap<ItemUpdateDto, item>();
            CreateMap<item, ItemUpdateDto>();

            CreateMap<order, OrderReadDto>();
            CreateMap<OrderCreateDto, order>();
            CreateMap<OrderUpdateDto, order>();
            CreateMap<order, OrderUpdateDto>();
        }
    }
}
