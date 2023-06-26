using Camera.MAUI;

namespace ExploracionPaquetes.Src.Security.Views;

public partial class CameraView : ContentPage
{
	public CameraView()
	{
		InitializeComponent();
	}

    void cameraView_CamerasLoaded(System.Object sender, System.EventArgs e)
    {
        if (cameraViewContainer.NumCamerasDetected > 0)
        {
            if (cameraViewContainer.NumMicrophonesDetected > 0)
                cameraViewContainer.Microphone = cameraViewContainer.Microphones.First();
            cameraViewContainer.Camera = cameraViewContainer.Cameras.First();
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                if (await cameraViewContainer.StartCameraAsync() == CameraResult.Success)
                {
                    //controlButton.Text = "Stop";
                    //playing = true;
                }
            });
        }
    }
}
