﻿namespace Models
{
    public class PropertyDetails
    {
        public string Url { get; set; }
        /// <summary>
        /// Ilość metrów kwadratowych powierzchni mieszkalnej
        /// </summary>
        public decimal Area { get; set; }

        /// <summary>
        /// Ilość pokoi.
        /// </summary>
        public int NumberOfRooms { get; set; }

        /// <summary>
        /// Numer piętra. Nie wymagany w przypadku domów
        /// </summary>
        public string? FloorNumber { get; set; }

        /// <summary>
        /// Rok zbudowania budynku.
        /// </summary>
        public int? YearOfConstruction { get; set; }

        /// <summary>
        /// Rodzaj ogrzewania
        /// </summary>
        public string? Heating { get; set; }
    }
}