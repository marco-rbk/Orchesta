using System.Diagnostics.Metrics;

namespace Catalog.API;

public static class CatalogMetrics
{
    public const string MeterName = "Catalog.Metrics";

    public static readonly Meter Meter = new(MeterName, "1.0.0");

    public static readonly Counter<int> ProductsRetrievedCounter = 
        Meter.CreateCounter<int>("catalog.products.retrieved", description: "Measures the number of retrieved products.");
}
