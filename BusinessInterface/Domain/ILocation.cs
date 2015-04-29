namespace Template.Business.Interface.Domain
{
    public interface ILocation
    {
        int LocationId { get; set; }
        string Title { get; set; }
        IAddress Address { get; set; }
        IPhone Phone { get; set; }
        decimal? Latitude { get; set; }
        decimal? Longitude { get; set; }
        bool? Disabled { get; set; }
    }
}