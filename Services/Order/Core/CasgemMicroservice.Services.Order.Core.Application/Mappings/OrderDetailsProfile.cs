using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Mappings
{
	public class OrderDetailsProfile: Profile
	{
		public OrderDetailsProfile()
		{
			CreateMap<ResultOrderDetailsDto,OrderingDetail>().ReverseMap();
			CreateMap<CreateOrderDetailsDto,OrderingDetail>().ReverseMap();
			CreateMap<UpdateOrderDetailsDto,OrderingDetail>().ReverseMap();
		}
	}
}
