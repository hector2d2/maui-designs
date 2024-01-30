
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace ExploracionPaquetes.Src.Design.Views;

public partial class MyMapsView : ContentPage
{
	public MyMapsView()
	{
		InitializeComponent();
	}

    async void map_Loaded(System.Object sender, System.EventArgs e)
    {
        try
        {
            GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));

            var _cancelTokenSource = new CancellationTokenSource();

            Location location = await Geolocation.Default.GetLocationAsync(request, _cancelTokenSource.Token);

            MapSpan mapSpan = MapSpan.FromCenterAndRadius(location, Distance.FromKilometers(0.444));

            map.MoveToRegion(mapSpan);

            Polygon polygon = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromArgb("#1BA1E2"),
                FillColor = Color.FromArgb("#881BA1E2"),
                Geopath =
                {
                    new Location(19.44290764796544, -99.19168999837855),
                    new Location(19.442920146261326, -99.1919318767186),
                    new Location(19.44257003686456, -99.19215618379769),
                    new Location(19.441532385076385, -99.20060090358147),
                    location,

                }
            };
            map.MapElements.Add(polygon);
        }
        catch (Exception ex)
        {

        }
    }
}
