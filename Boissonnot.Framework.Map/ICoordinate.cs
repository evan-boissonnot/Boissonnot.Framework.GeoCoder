namespace Boissonnot.Framework.Map
{
    public interface ICoordinate
    {
        /// <summary>
        /// Latitude trouvée
        /// </summary>
        decimal Latitude { get; set; }

        /// <summary>
        /// Longitude trouvée
        /// </summary>
        decimal Longitude { get; set; }
    }
}