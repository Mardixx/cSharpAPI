namespace API.DTOs.Stock
{
    public class StockDto
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty; //Authorizes empty string in db
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; } //Div for Divdend
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
    }
}
