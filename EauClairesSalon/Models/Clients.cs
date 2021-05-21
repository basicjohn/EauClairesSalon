namespace EauClairesSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string CurlinessType { get; set; }
    public string StrandsType { get; set; }
    public string VolumeType { get; set; }
    public int ContactNum { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}