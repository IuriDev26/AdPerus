namespace AdPerus.Domain.SalesContext.Enums;

public enum ESaleOrderStatus
{
    AwaitingPayment,
    Paid,
    Refunded,
    AwaitingProduct,
    ReadyToPickup,
    Completed,
    Cancelled,
}