namespace ConsumindoServicos.Api
{
    public class ApiBase
    {
        protected virtual void SetHeader() { }
        public string Url { get; set; }
    }
}