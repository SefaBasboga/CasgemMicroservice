﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos
{
	public class ResultOrderDetailsDto
	{
		public int OrderingDetailID { get; set; }
		public string ProductID { get; set; }
		public string ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public int ProductAmount { get; set; }
		public int OrderingID { get; set; }
	}
}
