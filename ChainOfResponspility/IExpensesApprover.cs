namespace ChainOfResponspility
{
    interface IExpensesApprover
    {
        ApproveResponse Approve(IExpensesReport report);
    }



}
