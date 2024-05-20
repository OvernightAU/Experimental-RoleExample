public class HookBehaviour : MonoBehaviour
{
    public void Update()
    {
        if (PlayerControl.LocalPlayer != null)
        {
            PlayerControl.LocalPlayer.nameText.Text = "BOMBER COMING LATER DW";
        }
    }
}