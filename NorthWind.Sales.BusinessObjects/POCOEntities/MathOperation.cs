namespace NorthWind.Sales.BusinessObjects.POCOEntities
{
    public class MathOperation
    {
        public int Id { get; set; }
        public decimal NumberOne { get; set; }
        public decimal NumberTwo { get; set; }
        public OperationType OperationType { get; set; }
        public string Result { get; set; }
        public DateTime OperationDate { get; set; } = DateTime.Now;
        public string NameOperation { get; set; }
    }
}
