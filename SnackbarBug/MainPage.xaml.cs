using CommunityToolkit.Maui.Alerts;

namespace SnackbarBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";
		var snackbar = new Snackbar
		{
			Action = () => Console.WriteLine("Test"),
			ActionButtonText = "Test button",
			Text = "Test Text",

		}; 
		snackbar.Show();
		

		SemanticScreenReader.Announce(CounterLabel.Text);
	}
}

