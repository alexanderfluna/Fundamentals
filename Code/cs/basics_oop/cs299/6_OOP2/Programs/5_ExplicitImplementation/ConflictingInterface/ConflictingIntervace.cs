public enum GameObjectMedium {Paper, Plastic, Electronic}

public interface IGameObject{

  int Value{
    get;
  }

  GameObjectMedium Medium{
    get;
  }
}