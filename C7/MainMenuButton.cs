using Godot;

public partial class MainMenuButton : Button
{

	ImageTexture HoverButton;
	ImageTexture InactiveButton;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		HoverButton = Util.LoadTextureFromPCX("Art/buttonsFINAL.pcx", 22, 1, 20, 20, false);
		InactiveButton = Util.LoadTextureFromPCX("Art/buttonsFINAL.pcx", 1, 1, 20, 20, false);

		Icon = InactiveButton;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		if(IsHovered()) {
			Icon = HoverButton;
		}
		else {
			Icon = InactiveButton;
		}
	}
}
