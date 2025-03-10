﻿using MediatR;

namespace MartinAybar.Application.Features.Orders.Queries.GetOrdersForMonth;

public class GetOrdersForMonthQuery : IRequest<PagedOrdersForMonthVm>
{
    public DateTime Date { get; set; }
    public int Page { get; set; }
    public int Size { get; set; }
}
