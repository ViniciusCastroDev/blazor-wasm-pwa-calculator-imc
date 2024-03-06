using ImcBlazorWasm.Models;

public static class AppState
{
  public static List<ImcModel> History {get;set;} = new ();

  public static event EventHandler<EventArgs> onChanged;

  public static void NotifyChange (object? sender, EventArgs args)
  {
    onChanged.Invoke(sender, args);
  }
}