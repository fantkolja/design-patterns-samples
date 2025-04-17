namespace DesignPatterns.State
{
    public interface IPlayerState
    {
      void PressPlay(MusicPlayer player);
    }

    public class MusicPlayer
    {
      private IPlayerState _state;
      public MusicPlayer()
      {
        _state = new StoppedState(); // Початковий стан
      }
      public void SetState(IPlayerState state)
      {
        _state = state;
      }
      public void PressPlay()
      {
        _state.PressPlay(this);
      }
    }

    public class StoppedState : IPlayerState
    {
      public void PressPlay(MusicPlayer player)
      {
        Console.WriteLine("Починаємо відтворення музики...");
        player.SetState(new PlayingState());
      }
    }
    public class PlayingState : IPlayerState
    {
      public void PressPlay(MusicPlayer player)
      {
        Console.WriteLine("Музику поставлено на паузу.");
        player.SetState(new PausedState());
      }
    }
    public class PausedState : IPlayerState
    {
      public void PressPlay(MusicPlayer player)
      {
        Console.WriteLine("Продовжуємо відтворення...");
        player.SetState(new PlayingState());
      }
    }
}

//     var player = new MusicPlayer();
//
//     player.PressPlay(); // Стоп → Відтворення
//     player.PressPlay(); // Відтворення → Пауза
//     player.PressPlay(); // Пауза → Відтворення
